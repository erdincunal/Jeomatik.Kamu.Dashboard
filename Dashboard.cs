using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dashboard
{
    /// <summary>Kamulaştırma özetlerini ve tescil oranlarını gösteren Windows Forms denetimi.</summary>
    public partial class Dashboard : UserControl
    {
        // Ana uygulamanın kültüründen bağımsız olarak Türkçe sayı ve TL biçimi kullanılır.
        private static readonly CultureInfo DisplayCulture = CultureInfo.GetCultureInfo("tr-TR");
        private readonly Title totalRegistrationTitle;
        private readonly int uiThreadId = Thread.CurrentThread.ManagedThreadId;

        public Dashboard()
        {
            InitializeComponent();
            // Her veri yüklemesinde yeni başlık/font üretmek yerine aynı başlık güncellenir.
            totalRegistrationTitle = new Title
            {
                Name = "TotalRegistration",
                Docking = Docking.Bottom,
                Font = chartTescil.Titles[0].Font
            };
            chartTescil.Titles.Add(totalRegistrationTitle);
            Clear();
        }

        /// <summary>Özetleri sıfırlar, parsel grafiğini boşaltır ve toplam tescil başlığını gizler.</summary>
        /// <remarks>Denetimin oluşturulduğu UI iş parçacığında çağrılmalıdır.</remarks>
        /// <exception cref="InvalidOperationException">Çağrı farklı bir iş parçacığından yapılmıştır.</exception>
        /// <exception cref="ObjectDisposedException">Denetim kapatılmıştır.</exception>
        public void Clear()
        {
            EnsureCanUpdate();
            UpdateDashboard(new Panel(), true);
        }

        /// <summary>Veriyi doğrular ve aynı veri kopyasıyla özetleri ve grafikleri günceller.</summary>
        /// <param name="panel">Sayılar, m² cinsinden alan, TL cinsinden bedeller ve 0–1 aralığında oranlar.</param>
        /// <remarks>UI iş parçacığında çağırın; kaynak nesneyi kopyalama sırasında başka bir iş parçacığından değiştirmeyin.</remarks>
        /// <exception cref="ArgumentNullException">Veri nesnesi null'dır.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Bir alan negatif, sonlu olmayan veya izin verilen aralık dışındadır.</exception>
        /// <exception cref="ArgumentException">Tescil oranlarının toplamı 1'i aşmaktadır.</exception>
        /// <exception cref="InvalidOperationException">Çağrı farklı bir iş parçacığından yapılmıştır.</exception>
        /// <exception cref="ObjectDisposedException">Denetim kapatılmıştır.</exception>
        public void FillDashboard(Panel panel)
        {
            if (panel == null)
                throw new ArgumentNullException(nameof(panel));

            EnsureCanUpdate();
            // Doğrulama tamamlanmadan ekran değişmez. TextChanged gibi olaylarda
            // kaynak nesne değişse bile güncellemenin tamamı bu kopyayı kullanır.
            UpdateDashboard(panel.CreateValidatedSnapshot(), false);
        }

        private void EnsureCanUpdate()
        {
            if (IsDisposed || Disposing)
                throw new ObjectDisposedException(nameof(Dashboard));
            // Pencere tanıtıcısı henüz oluşmamışsa InvokeRequired false dönebilir.
            // Bu yüzden oluşturucu iş parçacığının kimliği doğrudan kontrol edilir.
            if (Thread.CurrentThread.ManagedThreadId != uiThreadId)
                throw new InvalidOperationException("Dashboard yalnızca oluşturulduğu UI iş parçacığında güncellenebilir.");
        }

        private void UpdateDashboard(Panel panel, bool clear)
        {
            // Yerleşim hesabını toplu güncelleme bitene kadar ertele; hata olsa da
            // finally ile yeniden etkinleştir. Bu işlem UI olaylarını durdurmaz.
            SuspendLayout();
            try
            {
                UpdateSummary(panel);
                UpdateOwnershipChart(panel, clear);
                UpdateRegistrationChart(panel, clear);
            }
            finally
            {
                ResumeLayout(true);
            }
        }

        private void UpdateSummary(Panel panel)
        {
            labelToplamParselSayisi.Text = panel.ToplamParselSayisi.ToString("N0", DisplayCulture);
            labelToplamMalikSayisi.Text = panel.ToplamMalikSayisi.ToString("N0", DisplayCulture);
            labelToplamKamulastirmaAlani.Text = panel.ToplamKamulastirmaAlani.ToString("N2", DisplayCulture) + " m²";
            SetAmount(labelToplamKamulastirmaBedeli, panel.ToplamKamulastirmaBedeli);
            SetAmount(labelToplamMustemilatBedeli, panel.ToplamMustemilatBedeli);
            SetAmount(labelToplamMevsimlikBedeli, panel.ToplamMevsimlikBedeli);
            SetAmount(labelToplamDava27Bedeli, panel.ToplamDava27Bedeli);
            SetAmount(labelToplamDava10Bedeli, panel.ToplamDava10Bedeli);
        }

        private void UpdateOwnershipChart(Panel panel, bool clear)
        {
            var ownership = chartMalikTip.Series[0];
            // Tekrarlanan yüklemelerde eski parsel noktaları yeni verilere eklenmemelidir.
            ownership.Points.Clear();
            if (clear)
                return;

            AddParcelCount(ownership, "Diğer", panel.DigerParselSayisi);
            AddParcelCount(ownership, "Mera", panel.MeraParselSayisi);
            AddParcelCount(ownership, "Maliye Hazinesi", panel.MaliyeParselSayisi);
            AddParcelCount(ownership, "Tescil Harici", panel.TescilHariciParselSayisi);
            AddParcelCount(ownership, "Orman", panel.OrmanParselSayisi);
            AddParcelCount(ownership, "Kamu", panel.KamuParselSayisi);
            AddParcelCount(ownership, "Şahıs", panel.SahisParselSayisi);
        }

        private void UpdateRegistrationChart(Panel panel, bool clear)
        {
            // Designer'daki üç dilim sırasıyla rızaen, hükmen ve tescil edilmeyen
            // paydır. Oranlar kesirdir: örneğin 0.25, %25'i temsil eder.
            var registration = chartTescil.Series[0];
            UpdateRegistrationPoint(registration.Points[0], panel.RizaenTescilOrani, "Rızaen Tescil Edilen");
            UpdateRegistrationPoint(registration.Points[1], panel.HukmenTescilOrani, "Hükmen Tescil Edilen");
            double total = panel.RizaenTescilOrani + panel.HukmenTescilOrani;
            // Model doğrulaması toplamı en fazla 1 kabul ettiği için kalan pay negatif olamaz.
            double remaining = 1 - total;
            registration.Points[2].SetValueXY(0, remaining);
            registration.Points[2].ToolTip = "Tescil Edilmeyen: " + remaining.ToString("P2", DisplayCulture);
            totalRegistrationTitle.Text = "Toplam Tescil Oranı: " + total.ToString("P2", DisplayCulture);
            totalRegistrationTitle.Visible = !clear;
        }

        private static void SetAmount(Label label, double amount)
        {
            label.Text = amount.ToString("C2", DisplayCulture);
        }

        private static void AddParcelCount(Series series, string category, int count)
        {
            int index = series.Points.AddXY(category, count);
            series.Points[index].ToolTip = count.ToString("N0", DisplayCulture);
        }

        private static void UpdateRegistrationPoint(DataPoint point, double ratio, string description)
        {
            point.SetValueXY(0, ratio);
            // Değerle birlikte etiket, açıklama ve ipucunu da yenile; eski yüzdeler kalmasın.
            point.Label = ratio.ToString("P0", DisplayCulture);
            point.LegendText = description + ": " + ratio.ToString("P2", DisplayCulture);
            point.ToolTip = point.LegendText;
        }

        private void chartMalikTip_Click(object sender, EventArgs e)
        {
            var series = chartMalikTip.Series[0];
            series.IsValueShownAsLabel = !series.IsValueShownAsLabel;
        }
    }
}
