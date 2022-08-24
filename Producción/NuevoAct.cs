using System;
using System.Windows.Forms;

namespace Producción
{
    public partial class NuevoAct : Form
    {
        public int ide;
        
        public NuevoAct()
        {
            InitializeComponent();
            cbx_actividad.SelectedIndex = 0;
            dt_fecha.Text = "01-01-1999";
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
            if (cbx_actividad.SelectedIndex>0 && txt_descripcion.Text.TrimStart()!="" && dt_fecha.Value.Year!=1999)
            {
                DialogResult mensaje = MessageBox.Show("¿Estas seguro de querer guardar?", "Confirmacion", MessageBoxButtons.YesNo);
                if (mensaje == DialogResult.Yes)
                {
                    try
                    {
                        Conexion.MEdio.AgregarActividad(ide, dt_fecha.Value, cbx_actividad.Text, txt_descripcion.Text);
                        MessageBox.Show("Guardado Correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar Guardar:" + ex.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Debes de completar todos los espacios","Advertencia!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void NuevoAct_FormClosed(object sender, FormClosedEventArgs e)
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
