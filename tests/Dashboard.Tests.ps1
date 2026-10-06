$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.Windows.Forms
Add-Type -AssemblyName System.Windows.Forms.DataVisualization
$assemblyPath = (Resolve-Path (Join-Path $PSScriptRoot '..\bin\Release\Dashboard.dll')).Path
Add-Type -Path $assemblyPath
Add-Type -ReferencedAssemblies $assemblyPath, System.Windows.Forms -TypeDefinition @'
using System;
using System.Threading;
public static class DashboardThreadProbe
{
    public static Exception UpdateFromWorker(Dashboard.Dashboard control, bool clear)
    {
        Exception failure = null;
        var thread = new Thread(() =>
        {
            try
            {
                if (clear) control.Clear();
                else control.FillDashboard(new Dashboard.Panel());
            }
            catch (Exception ex) { failure = ex; }
        });
        thread.Start();
        thread.Join();
        return failure;
    }
}
'@

function Assert($condition, $message) {
    if (-not $condition) { throw $message }
}

function Get-Field($control, $name) {
    $control.GetType().GetField($name, [Reflection.BindingFlags]'Instance,NonPublic').GetValue($control)
}

function Assert-Throws($action, [type]$exceptionType, $parameterName) {
    $failure = $null
    try { & $action } catch { $failure = $_.Exception.GetBaseException() }
    Assert ($null -ne $failure) ('Expected ' + $exceptionType.Name)
    Assert ($failure.GetType() -eq $exceptionType) ('Unexpected exception: ' + $failure.GetType().Name)
    if ($parameterName) {
        Assert ($failure.ParamName -eq $parameterName) ('Unexpected parameter: ' + $failure.ParamName)
    }
}

function Assert-ChartRenders($chart) {
    $stream = New-Object IO.MemoryStream
    try {
        $chart.SaveImage($stream, [Windows.Forms.DataVisualization.Charting.ChartImageFormat]::Png)
        Assert ($stream.Length -gt 0) 'Chart produced an empty image'
    }
    finally { $stream.Dispose() }
}

$control = New-Object Dashboard.Dashboard
try {
    $registration = Get-Field $control 'chartTescil'
    $ownership = Get-Field $control 'chartMalikTip'
    $countLabel = Get-Field $control 'labelToplamParselSayisi'
    Assert ([DashboardThreadProbe]::UpdateFromWorker($control, $true) -is [InvalidOperationException]) 'Worker update before handle creation'
    Assert ($registration.Series[0].Points[2].YValues[0] -eq 1) 'Initial remaining ratio'
    Assert ((Get-Field $control 'label9').Text -eq 'Toplam Acele Kamulaştırma Dava Bedeli') 'Article 27 caption'
    Assert ((Get-Field $control 'label11').Text -eq 'Toplam Tescil Dava Bedeli') 'Article 10 caption'

    $panel = New-Object Dashboard.Panel
    $panel.ToplamParselSayisi = 1234
    $panel.SahisParselSayisi = 12
    $panel.RizaenTescilOrani = 0.25
    $panel.HukmenTescilOrani = 0.5
    $culture = [Globalization.CultureInfo]::GetCultureInfo('tr-TR')
    $control.FillDashboard($panel)
    Assert ($countLabel.Text -eq '1.234') 'Turkish number formatting'
    Assert ($registration.Series[0].Points[0].Label -eq (0.25).ToString('P0', $culture)) 'Updated percentage label'
    Assert ($registration.Series[0].Points[2].YValues[0] -eq 0.25) 'Remaining ratio'
    Assert ($ownership.Series[0].Points[6].YValues[0] -eq 12) 'Ownership category mapping'
    1..100 | ForEach-Object { $control.FillDashboard($panel) }
    Assert ($ownership.Series[0].Points.Count -eq 7) 'Repeated fill must not append points'
    Assert ($registration.Titles.Count -eq 2) 'Repeated fill must not append titles'
    Assert-ChartRenders $registration
    Assert-ChartRenders $ownership

    # A host application's synchronous TextChanged handler can mutate its model.
    $mutateSource = [EventHandler]{ $panel.SahisParselSayisi = -10; $panel.RizaenTescilOrani = 2 }
    $countLabel.add_TextChanged($mutateSource)
    try {
        $panel.ToplamParselSayisi = 4321
        $control.FillDashboard($panel)
        Assert ($ownership.Series[0].Points[6].YValues[0] -eq 12) 'Snapshot ownership changed during update'
        Assert ($registration.Series[0].Points[0].YValues[0] -eq 0.25) 'Snapshot ratio changed during update'
    }
    finally {
        $countLabel.remove_TextChanged($mutateSource)
        $panel.ToplamParselSayisi = 1234
        $panel.SahisParselSayisi = 12
        $panel.RizaenTescilOrani = 0.25
    }
    $control.FillDashboard($panel)
    $null = $control.Handle
    Assert ([DashboardThreadProbe]::UpdateFromWorker($control, $false) -is [InvalidOperationException]) 'Worker update after handle creation'
    Assert ($countLabel.Text -eq '1.234') 'Worker update changed displayed data'

    $invalidCases = @(
        @{ Name = 'RizaenTescilOrani'; Value = -0.1 },
        @{ Name = 'RizaenTescilOrani'; Value = 1.1 },
        @{ Name = 'RizaenTescilOrani'; Value = 0.6 },
        @{ Name = 'HukmenTescilOrani'; Value = [double]::NaN },
        @{ Name = 'ToplamKamulastirmaBedeli'; Value = [double]::PositiveInfinity },
        @{ Name = 'ToplamMalikSayisi'; Value = -1 }
    )
    foreach ($case in $invalidCases) {
        $field = $panel.GetType().GetField($case.Name)
        $original = $field.GetValue($panel)
        $panel.($case.Name) = $case.Value
        $exceptionType = [ArgumentOutOfRangeException]
        $parameterName = $case.Name
        if ($case.Name -eq 'RizaenTescilOrani' -and $case.Value -eq 0.6) {
            $exceptionType = [ArgumentException]
            $parameterName = 'panel'
        }
        Assert-Throws { $control.FillDashboard($panel) } $exceptionType $parameterName
        Assert ($countLabel.Text -eq '1.234') 'Invalid input changed displayed data'
        Assert ($registration.Series[0].Points[0].YValues[0] -eq 0.25) 'Invalid input changed chart'
        $field.SetValue($panel, $original)
    }
    Assert-Throws { $control.FillDashboard($null) } ([ArgumentNullException]) 'panel'

    $panel.RizaenTescilOrani = 1
    $panel.HukmenTescilOrani = 0
    $control.FillDashboard($panel)
    Assert ($registration.Series[0].Points[2].YValues[0] -eq 0) 'Full registration boundary'
    Assert-ChartRenders $registration
    $control.Clear()
    $control.Clear()
    Assert ($countLabel.Text -eq '0') 'Clear count'
    Assert ($ownership.Series[0].Points.Count -eq 0) 'Clear ownership'
    Assert ($registration.Series[0].Points[0].YValues[0] -eq 0) 'Clear registration'
    Assert ($registration.Series[0].Points[2].YValues[0] -eq 1) 'Clear remaining ratio'
    Assert (-not $registration.Titles['TotalRegistration'].Visible) 'Clear total title'
    Assert-ChartRenders $registration
    Assert-ChartRenders $ownership
    $control.Dispose()
    Assert-Throws { $control.Clear() } ([ObjectDisposedException])
    Assert-Throws { $control.FillDashboard($panel) } ([ObjectDisposedException])
    Write-Output 'PASS: dashboard regression checks'
}
finally {
    $control.Dispose()
}
