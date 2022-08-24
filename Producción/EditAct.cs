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
    public partial class EditAct : Form
    {

        public int ide_actividad;
        public EditAct()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            lbl_titulo.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            if (cbx_asunto.SelectedIndex>0 && txt_descripcion.Text.TrimStart()!="" && dt_fecha.Value.Year!=1999)
            {
                DialogResult mensaje = MessageBox.Show("¿Estas seguro de querer ACTUALIZAR los datos?", "Confirmacion", MessageBoxButtons.YesNo);
                if (mensaje == DialogResult.Yes)
                {
                    try
                    {
                        Conexion.MEdio.editarActividad(ide_actividad, cbx_asunto.Text, dt_fecha.Value, txt_descripcion.Text);
                        MessageBox.Show("Guardado Correctamente", "Exito!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar Guardar:"+ex.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

            }
            else
            {
                MessageBox.Show("Debes de completar todos los espacios","Advertencia!",MessageBoxButtons.OK);
            }
            

        }

        public ComboBox _cbx_actividad { get => cbx_asunto; set => cbx_asunto = value; }
        public DateTimePicker _dt_fecha { get => dt_fecha; set => dt_fecha = value; }
        public TextBox _txt_descripcion { get => txt_descripcion; set => txt_descripcion = value; }
        public Label _lbl_titulo { get => lbl_titulo; set => lbl_titulo = value;}

        private void EditAct_FormClosed(object sender, FormClosedEventArgs e)
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
