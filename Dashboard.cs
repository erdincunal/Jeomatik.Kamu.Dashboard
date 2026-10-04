using System.Windows.Forms;

namespace Dashboard
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            try
            {
                labelToplamParselSayisi.Text = "0";
                labelToplamMalikSayisi.Text = "0";
                labelToplamKamulastirmaAlani.Text = "0";
                labelToplamKamulastirmaBedeli.Text = "0";
                labelToplamMustemilatBedeli.Text = "0";
                labelToplamMevsimlikBedeli.Text = "0";
                labelToplamDava27Bedeli.Text = "0";
                labelToplamDava10Bedeli.Text = "0";


                double RizaenTescilOrani = 0.0;
                double HukmenTescilOrani = 0.0;
                chartTescil.Series[0].Points[0].SetValueXY(0, RizaenTescilOrani);
                chartTescil.Series[0].Points[1].SetValueXY(0, HukmenTescilOrani);
                chartTescil.Series[0].Points[2].SetValueXY(0, (1 - RizaenTescilOrani - HukmenTescilOrani));
                chartTescil.Series[0].Points[0].Label = $"{RizaenTescilOrani:%0}";
                chartTescil.Series[0].Points[1].Label = $"{HukmenTescilOrani:%0}";
                chartTescil.Series[0].Points[0].LegendText = $"Rızaen Tescil Edilen: {RizaenTescilOrani:%0.00}";
                chartTescil.Series[0].Points[1].LegendText = $"Hükmen Tescil Edilen: {HukmenTescilOrani:%0.00}";

                chartMalikTip.Series[0].Points.Clear();
                chartTescil.Titles.Clear();

                chartTescil.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title("Tescil Oranı", System.Windows.Forms.DataVisualization.Charting.Docking.Top, new System.Drawing.Font("Trebuchet MS", 16), System.Drawing.Color.Black));
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void FillDashboard(Panel panel)
        {
            try
            {
                Clear();
                Application.DoEvents();

                labelToplamParselSayisi.Text = $"{panel.ToplamParselSayisi:N0}";
                labelToplamMalikSayisi.Text = $"{panel.ToplamMalikSayisi:N0}";
                labelToplamKamulastirmaAlani.Text = $"{panel.ToplamKamulastirmaAlani:N2} m²";
                labelToplamKamulastirmaBedeli.Text = $"{panel.ToplamKamulastirmaBedeli:C}";
                labelToplamMustemilatBedeli.Text = $"{panel.ToplamMustemilatBedeli:C}";
                labelToplamMevsimlikBedeli.Text = $"{panel.ToplamMevsimlikBedeli:C}";
                labelToplamDava27Bedeli.Text = $"{panel.ToplamDava27Bedeli:C}";
                labelToplamDava10Bedeli.Text = $"{panel.ToplamDava10Bedeli:C}";

                chartMalikTip.Series[0].Points.AddXY("Diğer", panel.DigerParselSayisi);
                chartMalikTip.Series[0].Points[0].ToolTip = $"{panel.DigerParselSayisi}";

                chartMalikTip.Series[0].Points.AddXY("Mera", panel.MeraParselSayisi);
                chartMalikTip.Series[0].Points[1].ToolTip = $"{panel.MeraParselSayisi}";

                chartMalikTip.Series[0].Points.AddXY("Maliye Hazinesi", panel.MaliyeParselSayisi);
                chartMalikTip.Series[0].Points[2].ToolTip = $"{panel.MaliyeParselSayisi}";

                chartMalikTip.Series[0].Points.AddXY("Tescil Harici", panel.TescilHariciParselSayisi);
                chartMalikTip.Series[0].Points[3].ToolTip = $"{panel.TescilHariciParselSayisi}";

                chartMalikTip.Series[0].Points.AddXY("Orman", panel.OrmanParselSayisi);
                chartMalikTip.Series[0].Points[4].ToolTip = $"{panel.OrmanParselSayisi}";

                chartMalikTip.Series[0].Points.AddXY("Kamu", panel.KamuParselSayisi);
                chartMalikTip.Series[0].Points[5].ToolTip = $"{panel.KamuParselSayisi}";

                chartMalikTip.Series[0].Points.AddXY("Şahıs", panel.SahisParselSayisi);
                chartMalikTip.Series[0].Points[6].ToolTip = $"{panel.SahisParselSayisi}";

                chartTescil.Series[0].Points[0].SetValueXY(0, panel.RizaenTescilOrani);
                chartTescil.Series[0].Points[1].SetValueXY(0, panel.HukmenTescilOrani);
                chartTescil.Series[0].Points[2].SetValueXY(0, (1 - panel.RizaenTescilOrani - panel.HukmenTescilOrani));
                chartTescil.Series[0].Points[0].LegendText = $"Rızaen Tescil Edilen: {panel.RizaenTescilOrani:%0.00}";
                chartTescil.Series[0].Points[1].LegendText = $"Hükmen Tescil Edilen: {panel.HukmenTescilOrani:%0.00}";
                chartTescil.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title($"Toplam Tescil Oranı: {panel.RizaenTescilOrani + panel.HukmenTescilOrani:%0.00}", System.Windows.Forms.DataVisualization.Charting.Docking.Bottom, new System.Drawing.Font("Trebuchet MS", 14), System.Drawing.Color.Black));
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private void chartMalikTip_Click(object sender, System.EventArgs e)
        {
            chartMalikTip.Series[0].IsValueShownAsLabel = !chartMalikTip.Series[0].IsValueShownAsLabel;
        }

        //private void Dashboard_Resize(object sender, System.EventArgs e)
        //{
        //    try
        //    {
        //        labelToplamParselSayisi.Font = new System.Drawing.Font("Trebuchet MS", 10);
        //        labelToplamMalikSayisi.Height = 10;
        //        labelToplamKamulastirmaAlani.Height = 15;
        //        labelToplamKamulastirmaBedeli.Height = 17;
        //        labelToplamMustemilatBedeli.Height = 30;
        //        labelToplamMevsimlikBedeli.Height = 40;
        //        labelToplamDava27Bedeli.Height = 32;
        //        labelToplamDava10Bedeli.Height = 48;
        //    }
        //    catch (System.Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
