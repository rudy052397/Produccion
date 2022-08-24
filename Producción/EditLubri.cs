using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producción
{
    public partial class EditLubri : Form
    {
        public int ide;

        public int ide_lubricacion;
        byte? ti;
        byte? ut;
        public EditLubri()
        {
            InitializeComponent();
            cbx_estado.SelectedIndex = 0;
            cbx_unidadTiempo.SelectedIndex = 0;
            cbx_lubricante.SelectedIndex = 0;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("¿Esta seguro que desea actualizar los datos?", "CONFIRMACION!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (s == DialogResult.Yes)
            {
                if (cbx_principal.Checked && Conexion.MEdio.verificarLubricacionP(ide, ide_lubricacion))
                {
                    MessageBox.Show("Ya se ha establecido otro Punto de lubricacion como PRINCIPAL, deshabilitelo para poder habilitar este como punto principal", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbx_principal.Checked && !Conexion.MEdio.verificarLubricacionP(ide, ide_lubricacion))
                {
                    actualizar();
                    Conexion.MEdio.editLubricacionP(ide, ti, ut);

                }
                else
                {
                    actualizar();
                }

            }

        }

        private void cbx_lubricante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_lubricante.SelectedIndex == 0)
                lbl_unidad.Text = "";
            else if (cbx_lubricante.SelectedIndex == 1)
                lbl_unidad.Text = "Litros";
            else if (cbx_lubricante.SelectedIndex == 2)
                lbl_unidad.Text = "gramos";
            lbl_titulo.Focus();
        }

        private void EditLubri_Shown(object sender, EventArgs e)
        {
            lbl_titulo.Focus();
        }

        private void cbx_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_titulo.Focus();
        }

        private void cbx_frecuencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_titulo.Focus();
        }

        private void actualizar()
        {

            //try
            //{
            
            bool? pr;
            byte? pto;
            
            string cant;
            string lub;
            string est;
            string tip;
            if (cbx_unidadTiempo.Text == "Dias")
                ut = 1;
            else if (cbx_unidadTiempo.Text == "Meses")
                ut = 2;
            else if (cbx_unidadTiempo.Text == "Años")
                ut = 3;
            else ut = null;

            if (cbx_principal.Checked)
                pr = true;
            else pr = false;

            if (txt_pto.Text.TrimStart() != "")
                pto = Convert.ToByte(txt_pto.Text.TrimStart());
            else pto = null;

            if (txt_cantidad.Text.TrimStart() != "")
                cant = txt_cantidad.Text.TrimStart();
            else cant = null;

            if (txt_tiempo.Text.TrimStart() != "")
                ti = Convert.ToByte(txt_tiempo.Text.TrimStart());
            else ti = null;

            if (cbx_estado.SelectedIndex == 0)
                est = null;
            else est = cbx_estado.Text;

            if (cbx_lubricante.SelectedIndex == 0)
                lub = null;
            else lub = cbx_lubricante.Text;

            if (txt_tipo.Text.TrimStart() == "")
                tip = null;
            else tip = txt_tipo.Text.TrimStart();

            Conexion.MEdio.editarLiubricacion(ide_lubricacion, txt_puntoL.Text.TrimStart(), lub, txt_tipo.Text, pto, cant, ti, ut, est, pr);
            MessageBox.Show("Se ha actualizado CORRECTAMENTE", "EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{ MessageBox.Show(ex.ToString()); }
        }
        public TextBox _txt_puntoL { get => txt_puntoL; set => txt_puntoL = value; }
        public ComboBox _cbx_lubricante { get => cbx_lubricante; set => cbx_lubricante = value; }
        public TextBox _txt_tipo { get => txt_tipo; set => txt_tipo = value; }
        public TextBox _txt_pto { get => txt_pto; set => txt_pto = value; }
        public TextBox _txt_cantidad { get => txt_cantidad; set => txt_cantidad = value; }
        public Label _lbl_unidad { get => lbl_unidad; set => lbl_unidad = value; }
        public TextBox _txt_tiempo { get => txt_tiempo; set => txt_tiempo = value; }
        public ComboBox _cbx_unidadTiempo { get => cbx_unidadTiempo; set => cbx_unidadTiempo = value; }
        public ComboBox _cbx_estado { get => cbx_estado; set => cbx_estado = value; }
        public Label _lbl_titulo { get => lbl_titulo; set => lbl_titulo = value; }
        public CheckBox _cbx_principal { get => cbx_principal; set => cbx_principal = value; }

        private void EditLubri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Resultados miInterfaz = this.Owner as Resultados;
            if (miInterfaz != null)
                miInterfaz.dgv_actividad.DataSource = Conexion.MEdio.actividad(miInterfaz.ide);
                miInterfaz.cbx_asunto.DataSource = Conexion.MEdio.comboBox_actividad(miInterfaz.ide);
                miInterfaz.dgv_lubricacion.DataSource = Conexion.MEdio.lubricacion(miInterfaz.ide);
            this.Dispose();
        }
    }
}
