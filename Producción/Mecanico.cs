using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
namespace Producción
{
    public partial class Mecanico : Form
    {
        public Mecanico()
        {
            InitializeComponent();
        }
        private void Inicio_Resize(object sender, EventArgs e)
        {
            this.lbl_titulo.Location = new Point((this.Size.Width / 2) - 150, this.lbl_titulo.Location.Y);
            if (this.Size.Width < 1100)
            {
                this.gb_Busqueda.Height = 193;
                this.lbl_zona.Location = new Point(37, 112);
                this.cbx_zona.Location = new Point(32, 145);
                this.dgv_resultado.Location = new Point(this.dgv_resultado.Location.X, 313);
            }
            else
            {
                this.gb_Busqueda.Height = 105;
                this.lbl_zona.Location = new Point(643, 21);
                this.cbx_zona.Location = new Point(640, 54);
                this.dgv_resultado.Location = new Point(this.dgv_resultado.Location.X, 236);
            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            dgv_resultado.DataSource = MEdio.Buscar(ver(), txt_Codigo.Text, cbx_zona.Text);
        }
        private void txt_Equipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_Buscar.PerformClick();
            }
        }
        private void cbx_zona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_Buscar.PerformClick();
                lbl_titulo.Focus();
            }
        }
        private void dgv_resultado_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_resultado.Columns.Count > 0)
                {
                    foreach (DataGridViewRow i in dgv_resultado.Rows)
                    {
                        if ((DateTime?)(i.Cells["FECHA"].Value) <= DateTime.Now.AddDays(20))
                        {
                            i.DefaultCellStyle.BackColor = Color.FromArgb(255, 74, 74);
                        }
                        else if ((DateTime?)(i.Cells["FECHA"].Value) <= DateTime.Now.AddMonths(4) && (DateTime?)(i.Cells["FECHA"].Value) > DateTime.Now.AddDays(20))
                        {
                            i.DefaultCellStyle.BackColor = Color.FromArgb(236, 238, 158);
                        }
                        else if ((DateTime?)(i.Cells["FECHA"].Value) > DateTime.Now.AddMonths(4))
                        { i.DefaultCellStyle.BackColor = Color.FromArgb(109, 218, 90); }
                    }
                    dgv_resultado.Columns["FECHA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_resultado.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

            }
            catch (Exception ex) { }
            lbl_resultado.Text = "Se encontraron " + dgv_resultado.Rows.Count.ToString() + " resultados";
            dgv_resultado.ClearSelection();
            dgv_resultado.CurrentCell = null;
        }
        private void dgv_resultado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                opciones.Items.Add("Ver").Name = "VER";
                dgv_resultado.Rows[e.RowIndex].Selected = true;
                dgv_resultado.CurrentCell = dgv_resultado.Rows[e.RowIndex].Cells[0];
                opciones.Show(dgv_resultado, e.Location);
                opciones.Show(Cursor.Position);

            }
        }
        private void opciones_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            opciones.Items.Clear();
        }
        private void opciones_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "VER")
            {

                Resultados formEsp = new Resultados();
                AddOwnedForm(formEsp);

                formEsp.dgv_actividad.DataSource = MEdio.actividad(int.Parse(dgv_resultado.Rows[dgv_resultado.CurrentCell.RowIndex].Cells["ID"].Value.ToString()));
                formEsp.cbx_asunto.DataSource = MEdio.comboBox_actividad(int.Parse(dgv_resultado.Rows[dgv_resultado.CurrentCell.RowIndex].Cells["ID"].Value.ToString()));
                formEsp.dgv_lubricacion.DataSource = MEdio.lubricacion(int.Parse(dgv_resultado.Rows[dgv_resultado.CurrentCell.RowIndex].Cells["ID"].Value.ToString()));
                formEsp.ide = (int)dgv_resultado.Rows[dgv_resultado.CurrentCell.RowIndex].Cells["ID"].Value;
                formEsp.lbl_cod.Text = dgv_resultado.Rows[dgv_resultado.CurrentCell.RowIndex].Cells["CODIGO_ADM"].Value.ToString();
                formEsp.lbl_nombre.Text = dgv_resultado.Rows[dgv_resultado.CurrentCell.RowIndex].Cells["NOMBRE"].Value.ToString();
                formEsp.ShowDialog();

            }
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_Codigo.Text = "";
            cbx_zona.DataSource = MEdio.comboBox();
            dgv_resultado.DataSource = MEdio.inicio();
        }
        public ComboBox _cbx_zona { get => cbx_zona; set => cbx_zona = value; }
        public DataGridView _dgv_resultado { get => dgv_resultado; set => dgv_resultado = value; }
        private void Mecanico_Shown(object sender, EventArgs e)
        {
            this.lbl_titulo.Location = new Point((this.Size.Width / 2) - 150, this.lbl_titulo.Location.Y);
            cbx_zona.DataSource = MEdio.comboBox();
            dgv_resultado.DataSource = MEdio.inicio();
        }
        private int ver()
        {
            if (txt_Codigo.Text.TrimStart() == "" && cbx_zona.SelectedIndex == 0)
                return 0;
            else if (txt_Codigo.Text.TrimStart() == "" && cbx_zona.SelectedIndex > 0)
                return 1;
            else if (txt_Codigo.Text.TrimStart() != "" && cbx_zona.SelectedIndex == 0)
                return 2;
            else return 3;

        }
        //private void filtrodgv(DataGridView dgv)
        //{
        //    try
        //    {
        //        linqdatasource
        //    }
        //    catch (Exception ex)
        //    { }
        //}

    }
}
