namespace Dashboard
{
    partial class Dashboard
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.chartMalikTip = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTescil = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelToplamKamulastirmaBedeli = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelToplamKamulastirmaAlani = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelToplamParselSayisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelToplamMalikSayisi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.labelToplamMustemilatBedeli = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelToplamMevsimlikBedeli = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.labelToplamDava27Bedeli = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelToplamDava10Bedeli = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMalikTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTescil)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMain.Controls.Add(this.chartMalikTip, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.chartTescil, 2, 2);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel6, 2, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1101, 684);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // chartMalikTip
            // 
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.Name = "ChartArea1";
            this.chartMalikTip.ChartAreas.Add(chartArea1);
            this.tableLayoutPanelMain.SetColumnSpan(this.chartMalikTip, 2);
            this.chartMalikTip.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chartMalikTip.Legends.Add(legend1);
            this.chartMalikTip.Location = new System.Drawing.Point(4, 346);
            this.chartMalikTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartMalikTip.Name = "chartMalikTip";
            this.chartMalikTip.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.CustomProperties = "BarLabelStyle=Right";
            series1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.Legend = "Legend1";
            series1.Name = "Parsel Sayısı";
            this.chartMalikTip.Series.Add(series1);
            this.chartMalikTip.Size = new System.Drawing.Size(707, 334);
            this.chartMalikTip.TabIndex = 11;
            this.chartMalikTip.Text = "chart2";
            title1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.Name = "Mülkiyet Deseni";
            title1.Text = "Parsel Sayıları";
            this.chartMalikTip.Titles.Add(title1);
            this.chartMalikTip.Click += new System.EventHandler(this.chartMalikTip_Click);
            // 
            // chartTescil
            // 
            chartArea2.Area3DStyle.Inclination = 0;
            chartArea2.Area3DStyle.IsClustered = true;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.Rotation = 0;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 100F;
            chartArea2.InnerPlotPosition.Width = 100F;
            chartArea2.Name = "ChartArea1";
            this.chartTescil.ChartAreas.Add(chartArea2);
            this.chartTescil.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            legend2.TitleFont = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chartTescil.Legends.Add(legend2);
            this.chartTescil.Location = new System.Drawing.Point(719, 347);
            this.chartTescil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartTescil.Name = "chartTescil";
            this.chartTescil.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartTescil.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.Silver};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.CustomProperties = "PieStartAngle=270, DoughnutRadius=40, CollectedSliceExploded=True, PieLabelStyle=" +
    "Disabled";
            series2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series2.Legend = "Legend1";
            series2.Name = "Oran";
            dataPoint1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            dataPoint1.CustomProperties = "PieLabelStyle=Disabled";
            dataPoint1.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataPoint1.IsValueShownAsLabel = true;
            dataPoint1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            dataPoint1.LabelForeColor = System.Drawing.Color.Black;
            dataPoint1.LegendText = "Rızaen Tescil Edilen";
            dataPoint2.Font = new System.Drawing.Font("Trebuchet MS", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataPoint2.IsValueShownAsLabel = true;
            dataPoint2.LegendText = "Hükmen Tescil Edilen";
            dataPoint3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataPoint3.IsVisibleInLegend = false;
            dataPoint3.Label = "";
            series2.Points.Add(dataPoint1);
            series2.Points.Add(dataPoint2);
            series2.Points.Add(dataPoint3);
            this.chartTescil.Series.Add(series2);
            this.chartTescil.Size = new System.Drawing.Size(378, 332);
            this.chartTescil.TabIndex = 10;
            this.chartTescil.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title2.Name = "Title1";
            title2.Text = "Tescil Oranı";
            this.chartTescil.Titles.Add(title2);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.labelToplamKamulastirmaBedeli, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(719, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(378, 161);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // labelToplamKamulastirmaBedeli
            // 
            this.labelToplamKamulastirmaBedeli.AutoEllipsis = true;
            this.labelToplamKamulastirmaBedeli.AutoSize = true;
            this.labelToplamKamulastirmaBedeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelToplamKamulastirmaBedeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToplamKamulastirmaBedeli.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamKamulastirmaBedeli.Location = new System.Drawing.Point(4, 0);
            this.labelToplamKamulastirmaBedeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToplamKamulastirmaBedeli.Name = "labelToplamKamulastirmaBedeli";
            this.labelToplamKamulastirmaBedeli.Size = new System.Drawing.Size(370, 128);
            this.labelToplamKamulastirmaBedeli.TabIndex = 0;
            this.labelToplamKamulastirmaBedeli.Text = "0";
            this.labelToplamKamulastirmaBedeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(4, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "Toplam Kamulaştırma Bedeli";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelToplamKamulastirmaAlani, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(334, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(377, 161);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // labelToplamKamulastirmaAlani
            // 
            this.labelToplamKamulastirmaAlani.AutoEllipsis = true;
            this.labelToplamKamulastirmaAlani.AutoSize = true;
            this.labelToplamKamulastirmaAlani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelToplamKamulastirmaAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToplamKamulastirmaAlani.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamKamulastirmaAlani.Location = new System.Drawing.Point(4, 0);
            this.labelToplamKamulastirmaAlani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToplamKamulastirmaAlani.Name = "labelToplamKamulastirmaAlani";
            this.labelToplamKamulastirmaAlani.Size = new System.Drawing.Size(369, 128);
            this.labelToplamKamulastirmaAlani.TabIndex = 0;
            this.labelToplamKamulastirmaAlani.Text = "0";
            this.labelToplamKamulastirmaAlani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(4, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Kamulaştırma Alanı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelToplamParselSayisi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(322, 161);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelToplamParselSayisi
            // 
            this.labelToplamParselSayisi.AutoEllipsis = true;
            this.labelToplamParselSayisi.AutoSize = true;
            this.labelToplamParselSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelToplamParselSayisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToplamParselSayisi.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamParselSayisi.Location = new System.Drawing.Point(4, 0);
            this.labelToplamParselSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToplamParselSayisi.Name = "labelToplamParselSayisi";
            this.labelToplamParselSayisi.Size = new System.Drawing.Size(314, 128);
            this.labelToplamParselSayisi.TabIndex = 0;
            this.labelToplamParselSayisi.Text = "0";
            this.labelToplamParselSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(4, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Parsel Sayısı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelToplamMalikSayisi, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 176);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(322, 161);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // labelToplamMalikSayisi
            // 
            this.labelToplamMalikSayisi.AutoEllipsis = true;
            this.labelToplamMalikSayisi.AutoSize = true;
            this.labelToplamMalikSayisi.BackColor = System.Drawing.Color.Silver;
            this.labelToplamMalikSayisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToplamMalikSayisi.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamMalikSayisi.Location = new System.Drawing.Point(4, 0);
            this.labelToplamMalikSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToplamMalikSayisi.Name = "labelToplamMalikSayisi";
            this.labelToplamMalikSayisi.Size = new System.Drawing.Size(314, 128);
            this.labelToplamMalikSayisi.TabIndex = 0;
            this.labelToplamMalikSayisi.Text = "0";
            this.labelToplamMalikSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(4, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toplam Malik Sayısı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.labelToplamMustemilatBedeli, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelToplamMevsimlikBedeli, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(334, 176);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(377, 161);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(4, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(369, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Toplam Mevsimlik Ürün Bedeli";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelToplamMustemilatBedeli
            // 
            this.labelToplamMustemilatBedeli.AutoEllipsis = true;
            this.labelToplamMustemilatBedeli.AutoSize = true;
            this.labelToplamMustemilatBedeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelToplamMustemilatBedeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToplamMustemilatBedeli.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamMustemilatBedeli.ForeColor = System.Drawing.Color.Black;
            this.labelToplamMustemilatBedeli.Location = new System.Drawing.Point(4, 0);
            this.labelToplamMustemilatBedeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToplamMustemilatBedeli.Name = "labelToplamMustemilatBedeli";
            this.labelToplamMustemilatBedeli.Size = new System.Drawing.Size(369, 56);
            this.labelToplamMustemilatBedeli.TabIndex = 0;
            this.labelToplamMustemilatBedeli.Text = "0";
            this.labelToplamMustemilatBedeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(4, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Toplam Müştemilat Bedeli";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelToplamMevsimlikBedeli
            // 
            this.labelToplamMevsimlikBedeli.AutoEllipsis = true;
            this.labelToplamMevsimlikBedeli.AutoSize = true;
            this.labelToplamMevsimlikBedeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelToplamMevsimlikBedeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToplamMevsimlikBedeli.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamMevsimlikBedeli.ForeColor = System.Drawing.Color.Black;
            this.labelToplamMevsimlikBedeli.Location = new System.Drawing.Point(4, 80);
            this.labelToplamMevsimlikBedeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToplamMevsimlikBedeli.Name = "labelToplamMevsimlikBedeli";
            this.labelToplamMevsimlikBedeli.Size = new System.Drawing.Size(369, 56);
            this.labelToplamMevsimlikBedeli.TabIndex = 2;
            this.labelToplamMevsimlikBedeli.Text = "0";
            this.labelToplamMevsimlikBedeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.labelToplamDava27Bedeli, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelToplamDava10Bedeli, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(719, 176);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(378, 161);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(4, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(370, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Toplam Tescil Dava Bedeli";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelToplamDava27Bedeli
            // 
            this.labelToplamDava27Bedeli.AutoEllipsis = true;
            this.labelToplamDava27Bedeli.AutoSize = true;
            this.labelToplamDava27Bedeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelToplamDava27Bedeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToplamDava27Bedeli.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamDava27Bedeli.ForeColor = System.Drawing.Color.Black;
            this.labelToplamDava27Bedeli.Location = new System.Drawing.Point(4, 0);
            this.labelToplamDava27Bedeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToplamDava27Bedeli.Name = "labelToplamDava27Bedeli";
            this.labelToplamDava27Bedeli.Size = new System.Drawing.Size(370, 56);
            this.labelToplamDava27Bedeli.TabIndex = 0;
            this.labelToplamDava27Bedeli.Text = "0";
            this.labelToplamDava27Bedeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(4, 56);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(370, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Toplam Acele Kamulaştırma Dava Bedeli";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelToplamDava10Bedeli
            // 
            this.labelToplamDava10Bedeli.AutoEllipsis = true;
            this.labelToplamDava10Bedeli.AutoSize = true;
            this.labelToplamDava10Bedeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelToplamDava10Bedeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToplamDava10Bedeli.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamDava10Bedeli.ForeColor = System.Drawing.Color.Black;
            this.labelToplamDava10Bedeli.Location = new System.Drawing.Point(4, 80);
            this.labelToplamDava10Bedeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToplamDava10Bedeli.Name = "labelToplamDava10Bedeli";
            this.labelToplamDava10Bedeli.Size = new System.Drawing.Size(370, 56);
            this.labelToplamDava10Bedeli.TabIndex = 2;
            this.labelToplamDava10Bedeli.Text = "0";
            this.labelToplamDava10Bedeli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1101, 684);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMalikTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTescil)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMalikTip;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTescil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelToplamKamulastirmaBedeli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelToplamKamulastirmaAlani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelToplamParselSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelToplamMalikSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelToplamMustemilatBedeli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelToplamMevsimlikBedeli;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelToplamDava27Bedeli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelToplamDava10Bedeli;
    }
}
