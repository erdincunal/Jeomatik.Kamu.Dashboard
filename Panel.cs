namespace Dashboard
{
    /// <summary>Dashboard denetimine aktarılacak kamulaştırma özet verileri.</summary>
    /// <remarks>Mevcut uygulamalarla uyumluluk için veri üyeleri public alan olarak korunur.</remarks>
    public class Panel
    {
        // Toplamlar ve mülkiyet türüne göre parsel adetleri negatif olamaz.
        public int ToplamParselSayisi;
        public int ToplamMalikSayisi;

        public int SahisParselSayisi;
        public int KamuParselSayisi;
        public int MaliyeParselSayisi;
        public int OrmanParselSayisi;
        public int MeraParselSayisi;
        public int TescilHariciParselSayisi;
        public int DigerParselSayisi;

        /// <summary>Toplam kamulaştırma alanı, metrekare (m²) cinsindendir.</summary>
        public double ToplamKamulastirmaAlani;
        // Tüm bedeller TL cinsindedir; görüntülemede iki ondalık basamak kullanılır.
        public double ToplamKamulastirmaBedeli;
        public double ToplamMustemilatBedeli;
        public double ToplamMevsimlikBedeli;
        /// <summary>Acele kamulaştırma dava bedeli.</summary>
        public double ToplamDava27Bedeli;
        /// <summary>Tescil dava bedeli.</summary>
        public double ToplamDava10Bedeli;
        /// <summary>Rızaen tescil edilen pay: %25 için 0.25 verilir.</summary>
        public double RizaenTescilOrani;
        /// <summary>Hükmen tescil edilen pay; rızaen pay ile toplamı 1'i aşamaz.</summary>
        public double HukmenTescilOrani;

        // Alanlar değer tipidir; MemberwiseClone bu alanlar için bağımsız bir kopya üretir.
        // İleride referans tipinde veri eklenirse kopyalama davranışı yeniden değerlendirilmelidir.
        internal Panel CreateValidatedSnapshot()
        {
            var snapshot = (Panel)MemberwiseClone();
            snapshot.Validate();
            return snapshot;
        }

        private void Validate()
        {
            ValidateNonNegative(ToplamParselSayisi, nameof(ToplamParselSayisi));
            ValidateNonNegative(ToplamMalikSayisi, nameof(ToplamMalikSayisi));
            ValidateNonNegative(SahisParselSayisi, nameof(SahisParselSayisi));
            ValidateNonNegative(KamuParselSayisi, nameof(KamuParselSayisi));
            ValidateNonNegative(MaliyeParselSayisi, nameof(MaliyeParselSayisi));
            ValidateNonNegative(OrmanParselSayisi, nameof(OrmanParselSayisi));
            ValidateNonNegative(MeraParselSayisi, nameof(MeraParselSayisi));
            ValidateNonNegative(TescilHariciParselSayisi, nameof(TescilHariciParselSayisi));
            ValidateNonNegative(DigerParselSayisi, nameof(DigerParselSayisi));
            ValidateNonNegative(ToplamKamulastirmaAlani, nameof(ToplamKamulastirmaAlani));
            ValidateNonNegative(ToplamKamulastirmaBedeli, nameof(ToplamKamulastirmaBedeli));
            ValidateNonNegative(ToplamMustemilatBedeli, nameof(ToplamMustemilatBedeli));
            ValidateNonNegative(ToplamMevsimlikBedeli, nameof(ToplamMevsimlikBedeli));
            ValidateNonNegative(ToplamDava27Bedeli, nameof(ToplamDava27Bedeli));
            ValidateNonNegative(ToplamDava10Bedeli, nameof(ToplamDava10Bedeli));
            ValidateRatio(RizaenTescilOrani, nameof(RizaenTescilOrani));
            ValidateRatio(HukmenTescilOrani, nameof(HukmenTescilOrani));
            // Oranları sessizce değiştirmek yerine hatalı girdiyi reddet;
            // aksi halde halka grafiği negatif kalan pay veya yanıltıcı yüzdeler gösterir.
            if (RizaenTescilOrani + HukmenTescilOrani > 1)
                throw new System.ArgumentException("Tescil oranlarının toplamı 1'i aşmamalıdır.", "panel");
        }

        private static void ValidateRatio(double value, string name)
        {
            ValidateNonNegative(value, name);
            if (value > 1)
                throw new System.ArgumentOutOfRangeException(name, value, "Tescil oranı 0–1 aralığında olmalıdır.");
        }

        private static void ValidateNonNegative(double value, string name)
        {
            // NaN, yalnızca value < 0 kontrolüyle yakalanmaz; ayrıca denetlenmelidir.
            if (double.IsNaN(value) || double.IsInfinity(value) || value < 0)
                throw new System.ArgumentOutOfRangeException(name, value, "Değer sonlu ve sıfır veya pozitif olmalıdır.");
        }
    }
}
