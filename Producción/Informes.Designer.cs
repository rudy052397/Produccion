namespace Producción
{
    partial class Informes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datas = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced();
            this.chart_bar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuDatavizAdvanced1 = new Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(988, 749);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // datas
            // 
            this.datas.animationEnabled = false;
            this.datas.AxisLineColor = System.Drawing.Color.LightGray;
            this.datas.AxisXFontColor = System.Drawing.Color.Gray;
            this.datas.AxisXGridColor = System.Drawing.Color.Gray;
            this.datas.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.datas.AxisYFontColor = System.Drawing.Color.Gray;
            this.datas.AxisYGridColor = System.Drawing.Color.Gray;
            this.datas.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.datas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.datas.Location = new System.Drawing.Point(37, 127);
            this.datas.Name = "datas";
            this.datas.Size = new System.Drawing.Size(357, 323);
            this.datas.TabIndex = 17;
            this.datas.Theme = Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._theme.theme1;
            this.datas.Title = "";
            // 
            // chart_bar
            // 
            this.chart_bar.BorderlineColor = System.Drawing.Color.Gainsboro;
            this.chart_bar.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Humnst777 Lt BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.Size = 4F;
            chartArea1.AxisX.MaximumAutoSize = 60F;
            chartArea1.AxisX.ScaleView.Position = 0D;
            chartArea1.AxisX.ScaleView.Size = 17D;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.None;
            chartArea1.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.ScrollBar.Size = 9D;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea1.AxisY.ScrollBar.Size = 10D;
            chartArea1.Name = "ChartArea1";
            this.chart_bar.ChartAreas.Add(chartArea1);
            this.chart_bar.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chart_bar.Legends.Add(legend1);
            this.chart_bar.Location = new System.Drawing.Point(0, 0);
            this.chart_bar.Name = "chart_bar";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_bar.Series.Add(series1);
            this.chart_bar.Size = new System.Drawing.Size(443, 749);
            this.chart_bar.TabIndex = 18;
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Mantenimiento por Equipo";
            this.chart_bar.Titles.Add(title1);
            this.chart_bar.MouseEnter += new System.EventHandler(this.chart_bar_MouseEnter);
            // 
            // bunifuDatavizAdvanced1
            // 
            this.bunifuDatavizAdvanced1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDatavizAdvanced1.animationEnabled = false;
            this.bunifuDatavizAdvanced1.AxisLineColor = System.Drawing.Color.LightGray;
            this.bunifuDatavizAdvanced1.AxisXFontColor = System.Drawing.Color.Gray;
            this.bunifuDatavizAdvanced1.AxisXGridColor = System.Drawing.Color.Gray;
            this.bunifuDatavizAdvanced1.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDatavizAdvanced1.AxisYFontColor = System.Drawing.Color.Gray;
            this.bunifuDatavizAdvanced1.AxisYGridColor = System.Drawing.Color.Gray;
            this.bunifuDatavizAdvanced1.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bunifuDatavizAdvanced1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuDatavizAdvanced1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDatavizAdvanced1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatavizAdvanced1.Location = new System.Drawing.Point(963, 12);
            this.bunifuDatavizAdvanced1.Margin = new System.Windows.Forms.Padding(26, 30, 26, 30);
            this.bunifuDatavizAdvanced1.Name = "bunifuDatavizAdvanced1";
            this.bunifuDatavizAdvanced1.Size = new System.Drawing.Size(13, 16);
            this.bunifuDatavizAdvanced1.TabIndex = 20;
            this.bunifuDatavizAdvanced1.Theme = Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced._theme.theme2;
            this.bunifuDatavizAdvanced1.Title = "Mantenimiento por Zona";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Gainsboro;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.Inclination = 0;
            chartArea2.Area3DStyle.PointDepth = 0;
            chartArea2.Area3DStyle.PointGapDepth = 0;
            chartArea2.Area3DStyle.Rotation = 0;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(443, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsVisibleInLegend = false;
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(545, 483);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Mantenimiento por Zona";
            this.chart1.Titles.Add(title2);
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 749);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.bunifuDatavizAdvanced1);
            this.Controls.Add(this.chart_bar);
            this.Controls.Add(this.datas);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Informes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Informes_Load);
            this.Shown += new System.EventHandler(this.Informes_Shown);
            this.SizeChanged += new System.EventHandler(this.Informes_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced datas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_bar;
        private Bunifu.Dataviz.WinForms.BunifuDatavizAdvanced bunifuDatavizAdvanced1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}