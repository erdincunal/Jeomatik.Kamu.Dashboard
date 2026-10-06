# Jeomatik.Kamu.Dashboard

Kamulaştırma verilerini ve tescil oranlarını görüntüleyen Windows Forms kullanıcı denetimi. Proje bir sınıf kitaplığıdır; bir Windows Forms uygulamasına eklenmek üzere `Dashboard.dll` üretir.

## Gösterilen veriler

- Toplam parsel ve malik sayısı.
- Kamulaştırma alanı ve bedeli; müştemilat ve mevsimlik ürün bedelleri.
- Acele kamulaştırma ve tescil dava bedelleri.
- Mülkiyet türlerine göre parsel sayıları: diğer, mera, maliye hazinesi, tescil harici, orman, kamu ve şahıs.
- Rızaen, hükmen ve tescil edilmeyen payları gösteren halka grafiği.

Parsel grafiğine tıklamak, çubukların değer etiketlerini açıp kapatır.

## Gereksinimler

- Windows.
- .NET Framework 4.7.2 Developer Pack / hedefleme araçları.
- Visual Studio ve .NET masaüstü geliştirme iş yükü (MSBuild dahil).
- Regresyon testleri için Windows PowerShell 5.1.

## Derleme

`Dashboard.sln` dosyasını Visual Studio ile açıp Release yapılandırmasında derleyin. Alternatif olarak proje klasöründe Visual Studio Developer PowerShell üzerinden çalıştırın:

```powershell
msbuild Dashboard.sln /t:Build /p:Configuration=Release /verbosity:minimal
```

Çıktı: `bin\Release\Dashboard.dll`. `bin`, `obj` ve Visual Studio kullanıcı ayarları Git'e dahil edilmez. Projede harici NuGet paketi bağımlılığı yoktur.

## Kullanım

Ana Windows Forms projenize `Dashboard.csproj` proje başvurusu veya derlenen DLL başvurusu ekleyin. Aşağıdaki örneği formun UI iş parçacığında, örneğin `Load` olayında çalıştırın:

```csharp
var dashboard = new Dashboard.Dashboard
{
    Dock = System.Windows.Forms.DockStyle.Fill
};
Controls.Add(dashboard);

var data = new Dashboard.Panel
{
    ToplamParselSayisi = 100,
    ToplamMalikSayisi = 140,
    SahisParselSayisi = 60,
    KamuParselSayisi = 20,
    MaliyeParselSayisi = 10,
    OrmanParselSayisi = 5,
    MeraParselSayisi = 3,
    TescilHariciParselSayisi = 1,
    DigerParselSayisi = 1,
    ToplamKamulastirmaAlani = 12500.50,
    ToplamKamulastirmaBedeli = 2500000,
    ToplamMustemilatBedeli = 150000,
    ToplamMevsimlikBedeli = 25000,
    ToplamDava27Bedeli = 500000,
    ToplamDava10Bedeli = 750000,
    RizaenTescilOrani = 0.25,
    HukmenTescilOrani = 0.50
};

dashboard.FillDashboard(data);
```

`FillDashboard(data)` mevcut gösterimi yeni verilerle değiştirir. `Clear()` sayıları ve bedelleri sıfırlar, parsel grafiğini boşaltır ve toplam tescil başlığını gizler. Halka grafiğinin kalan payı bu durumda %100'dür. Tekrarlanan çağrılar grafik noktaları veya başlıklarını biriktirmez.

## Veri kuralları ve hata davranışı

| Veri | Birim / kural |
| --- | --- |
| Parsel ve malik sayıları | Negatif olmayan tam sayı |
| `ToplamKamulastirmaAlani` | Metrekare (m²); sonlu ve negatif olmayan değer |
| Bedel alanları | TL; sonlu ve negatif olmayan değer |
| `RizaenTescilOrani`, `HukmenTescilOrani` | 0–1 aralığında kesir; örneğin %25 için `0.25` |
| Tescil oranlarının toplamı | En fazla 1; kalan pay `1 - toplam` olarak hesaplanır |

Sayılar ana uygulamanın kültüründen bağımsız olarak `tr-TR` ile biçimlendirilir. Alan ve bedeller iki ondalık basamakla gösterilir. Modeldeki toplam parsel sayısı ile kategori toplamının eşitliği kontrol edilmez; bu tutarlılığı veri sağlayan uygulama sağlamalıdır.

| Durum | İstisna |
| --- | --- |
| `FillDashboard(null)` | `ArgumentNullException` |
| Negatif değer, NaN, sonsuzluk veya 1'den büyük tekil tescil oranı | `ArgumentOutOfRangeException` |
| Tescil oranları toplamının 1'i aşması | `ArgumentException` |
| Güncellemenin farklı bir iş parçacığından çağrılması | `InvalidOperationException` |
| Kapatılmış denetimin güncellenmesi | `ObjectDisposedException` |

Geçersiz veri, ekran değiştirilmeden önce reddedilir. `Clear()` ve `FillDashboard()` denetimin oluşturulduğu UI iş parçacığında çağrılmalıdır. Arka plan işlemleri sonucu gelen güncellemeleri ana uygulamanın UI iş parçacığına aktarın.

Güncelleme doğrulanmış bir veri kopyasını kullanır. `TextChanged` gibi senkron ekran olaylarında kaynak nesne değişse bile etiketler ve grafikler aynı kopyadan beslenir. Kaynak nesneyi kopyalama sırasında başka bir iş parçacığından değiştirmeyin.

## Kod yapısı

| Dosya | Sorumluluk |
| --- | --- |
| `Dashboard.cs` | Denetimin yaşam döngüsü, biçimlendirme ve grafik güncellemeleri |
| `Panel.cs` | Veri alanları, kopyalama ve girdi doğrulaması |
| `Dashboard.Designer.cs` | Windows Forms yerleşimi ve grafik bileşenlerinin başlangıç ayarları |
| `Dashboard.resx` | Denetimin kaynak dosyası |
| `tests/Dashboard.Tests.ps1` | Regresyon kontrolleri |

`Panel` sınıfının public alanları ve denetimin `FillDashboard`/`Clear` metotları mevcut ana uygulamalarla uyumluluk için korunmuştur.

## Testler

Release derlemesinden sonra Windows PowerShell ile regresyon kontrollerini çalıştırın:

```powershell
powershell.exe -NoProfile -ExecutionPolicy Bypass -STA -File tests\Dashboard.Tests.ps1
```

Başarılı sonuç: `PASS: dashboard regression checks`.

Testler Türkçe sayı biçimini, dava açıklamalarını, yüzde etiketlerini, tekrarlanan yükleme ve temizlemeyi, geçersiz girdide beklenen istisnaları, güncelleme sırasında kaynak veri değişimini, iş parçacığı ve kapatılmış denetim kontrollerini doğrular. Grafiklerin normal, tamamen tescil edilmiş ve temizlenmiş durumlarda PNG görüntüsü üretebildiği de kontrol edilir. Görsel yerleşimin kullanıcı tarafından incelenmesi ayrıca yapılmalıdır.
