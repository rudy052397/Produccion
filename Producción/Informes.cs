using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Bunifu.Dataviz.WinForms;


namespace Producción
{
    public partial class Informes : Form
    {
        BunifuDatavizAdvanced.DataPoint datapoint;
        public Informes()
        {
            InitializeComponent();
            this.chart_bar.MouseWheel += new MouseEventHandler(chart_bar_MouseWheel);
            chart_bar.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_bar.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart_bar.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_bar.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Conexion.Informes.BitacoraZona();
            var barra = Conexion.Informes.BitacoraEquipo();
            chart_bar.Series[0].Points.DataBindXY(barra,"EQUIPO", barra,"CANTIDAD");
            double ymax = chart_bar.Series[0].Points.Count();
            chart_bar.ChartAreas["ChartArea1"].AxisX.ScaleView.Position = ymax - 17;

        }

        private void chart_bar_MouseWheel(object sender, MouseEventArgs e)
        {
            double ymax = chart_bar.Series[0].Points.Count();
            if (e.Delta < 0 && chart_bar.ChartAreas["ChartArea1"].AxisX.ScaleView.Position >= 0)

            {
                chart_bar.ChartAreas[0].AxisX.ScaleView.Position -= 1;
            }

            if (e.Delta > 0 && chart_bar.ChartAreas["ChartArea1"].AxisX.ScaleView.Position <= (ymax - 17))
            {
                chart_bar.ChartAreas[0].AxisX.ScaleView.Position += 1;
            }
        }

        private void chart_bar_MouseEnter(object sender, EventArgs e)
        {
            this.chart_bar.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Informes_Shown(object sender, EventArgs e)
        {
            var pastel = Conexion.Informes.BitacoraZona();

            foreach (var item in pastel)
            {
                var me = (Conexion.info)item;
                int index = chart1.Series[0].Points.AddY(me.CANTIDAD);
                chart1.Series[0].Points[index].Label = me.ZONA + " (" + me.CANTIDAD.ToString()+")";
            }
            chart1.Series[0]["PieLabelStyle"] = "outside";
            chart1.Series[0]["PieLineColor"] = "silver";
        }

        private void Informes_SizeChanged(object sender, EventArgs e)
        {
            chart_bar.Width = (this.Width / 2)-100;
        }
    }

}
