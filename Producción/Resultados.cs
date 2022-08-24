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

namespace Producción
{
    public partial class Resultados : Form
    {
        public int ide;

        public Resultados()
        {
         
            InitializeComponent();
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            if (dgv_actividad.Columns.Count>0)
            {
                dgv_actividad.Columns["ID"].Visible = false;
                dgv_actividad.Columns["FECHA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgv_lubricacion.Columns.Count>0)
            {
                dgv_lubricacion.Columns["ID"].Visible = false;
                dgv_lubricacion.Columns["CANTIDAD_0"].Visible = false;
                dgv_lubricacion.Columns["TIEMPO"].Visible = false;
                dgv_lubricacion.Columns["UNIDAD_TIEMPO"].Visible = false;
                dgv_lubricacion.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_lubricacion.Columns["FRECUENCIA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_lubricacion.Columns["PTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void cbx_asunto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_asunto.SelectedIndex!=0)
            {

                dgv_actividad.DataSource = Conexion.MEdio.actividadFiltro(ide, cbx_asunto.Text);
                pictureBox1.Focus();
            }
        }

        private void dgv_resultado_DataSourceChanged(object sender, EventArgs e)
        {

            dgv_actividad.ClearSelection();
            dgv_actividad.CurrentCell = null;
        }

        private void Resultados_Shown(object sender, EventArgs e)
        {
            dgv_actividad.ClearSelection();
            dgv_actividad.CurrentCell = null;
            
        }

        private void dgv_resultado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_detalle.Text = Conexion.MEdio.actividadDetalle((int)(dgv_actividad.Rows[e.RowIndex].Cells["ID"].Value)).Replace("\n", "\r\n");
        }

        private void dgv_lubricacion_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            NuevoAct newForm = new NuevoAct();
            AddOwnedForm(newForm);
            newForm.ide = ide;
            newForm.ShowDialog();
        }

        private void dgv_resultado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                cm_Actividad.Items.Add("Editar").Name = "EDITAR";
                cm_Actividad.Items.Add("Eliminar").Name = "ELIMINAR";
                //dgv_actividad.Rows[e.RowIndex].Selected = true;
                dgv_actividad.CurrentCell = dgv_actividad.Rows[e.RowIndex].Cells[1];
                cm_Actividad.Show(dgv_actividad, e.Location);
                cm_Actividad.Show(Cursor.Position);

            }
        }

        private void cm_Actividad_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            cm_Actividad.Items.Clear();
        }

        private void cm_Actividad_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "EDITAR")
            {

                EditAct form = new EditAct();
                AddOwnedForm(form);
                int id_act= (int)(dgv_actividad.Rows[dgv_actividad.CurrentCell.RowIndex].Cells["ID"].Value);
                form.ide_actividad = id_act;
                form._cbx_actividad.Text= dgv_actividad.Rows[dgv_actividad.CurrentCell.RowIndex].Cells["ASUNTO"].Value.ToString();
                form._dt_fecha.Text= dgv_actividad.Rows[dgv_actividad.CurrentCell.RowIndex].Cells["FECHA"].Value.ToString();
                form._txt_descripcion.Text= Conexion.MEdio.actividadDetalle(id_act);
                form._lbl_titulo.Text = "Actividad N° " + id_act.ToString();
                form.ShowDialog();

            }
        }

        private void dgv_lubricacion_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                cm_lubricacion.Items.Add("Editar").Name = "EDITAR";
                cm_lubricacion.Items.Add("Eliminar").Name = "ELIMINAR";
                //dgv_lubricacion.Rows[e.RowIndex].Selected = true;
                dgv_lubricacion.CurrentCell = dgv_lubricacion.Rows[e.RowIndex].Cells[1];
                cm_lubricacion.Show(dgv_lubricacion, e.Location);
                cm_lubricacion.Show(Cursor.Position);

            }
        }

        private void cm_lubricacion_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            cm_lubricacion.Items.Clear();
        }

        private void cm_lubricacion_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "EDITAR")
            {

                EditLubri form = new EditLubri();
                AddOwnedForm(form);
                int id_lub = (int)(dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["ID"].Value);
                form.ide = ide;
                form.ide_lubricacion = id_lub;
                form._txt_puntoL.Text = dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["PUNTOS"].Value?.ToString();

                if (dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["LUBRICANTE"].Value == null)
                    form._cbx_lubricante.SelectedIndex = 0;
                else form._cbx_lubricante.Text = dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["LUBRICANTE"].Value?.ToString();

                form._txt_tipo.Text = dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["TIPO"].Value?.ToString();
                form._txt_pto.Text= dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["PTO"].Value?.ToString();
                form._txt_cantidad.Text= dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["CANTIDAD_0"].Value?.ToString();
                form._txt_tiempo.Text= dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["TIEMPO"].Value?.ToString();

                if (dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["UNIDAD_TIEMPO"].Value == null)
                    form._cbx_unidadTiempo.SelectedIndex = 0;
                else form._cbx_unidadTiempo.Text = dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["UNIDAD_TIEMPO"].Value?.ToString();

                if (dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["ESTADO"].Value == null)
                    form._cbx_estado.SelectedIndex = 0;
                else form._cbx_estado.Text = dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["ESTADO"].Value?.ToString();

                form._lbl_titulo.Text = "LUBRICACION " + id_lub.ToString();

                if (dgv_lubricacion.Rows[dgv_lubricacion.CurrentCell.RowIndex].Cells["PRINCIPAL"].Value?.ToString() == "SI")
                    form._cbx_principal.Checked = true;
                else form._cbx_principal.Checked= false;

                form.ShowDialog();

            }
        }

        private void Resultados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mecanico miInterfaz = this.Owner as Mecanico;
            if (miInterfaz != null)
                miInterfaz._cbx_zona.DataSource = Conexion.MEdio.comboBox();
                miInterfaz._dgv_resultado.DataSource = Conexion.MEdio.inicio();
            this.Dispose();
        }
    }
}
