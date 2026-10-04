# Jeomatik.Kamu.Dashboard

Kamulaştırma verilerini ve tescil oranlarını görüntüleyen Windows Forms kullanıcı denetimi.

## Gereksinimler

- .NET Framework 4.7.2
- Visual Studio ve .NET masaüstü geliştirme araçları

`Dashboard.sln` dosyasını Visual Studio ile açıp derleyin. Proje bir sınıf kitaplığıdır; bir Windows Forms uygulamasında kullanılmak üzere `Dashboard.dll` üretir.

`Dashboard.Panel` nesnesini verilerle doldurup denetimin `FillDashboard(panel)` metoduna iletin. `Clear()` metodu gösterge değerlerini sıfırlar.
