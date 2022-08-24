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
using Transitions;

namespace Producción
{
    public partial class Principio : Form
    {
        
        public  Principio()
        {
            InitializeComponent();
            pnl_menu.Width = 296;
            pb_logo.Size = new Size(129, 145);
            pb_logo.Location = new Point(85, -40);
            pb_informe.Parent = btn_informe;
            pb_informe.Location = new Point(11, 10);
            pb_mecanico.Parent = btn_mecanico;
            pb_mecanico.Location = new Point(11, 10);
            pb_electrico.Parent = btn_electrico;
            pb_electrico.Location = new Point(11, 10);
            pb_lista.Parent = btn_lista;
            pb_lista.Location = new Point(11, 10);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            //var t = new Transition(new TransitionType_EaseInEaseOut(1000));

            if (pnl_menu.Width == 296)
            {
                Transition.run(this.pnl_menu, "Width",68, new TransitionType_EaseInEaseOut(200));
                pb_logo.Size = new Size(65, 62);
                pb_logo.Location = new Point(0, 3);

            }

            else
            {
                Transition.run(this.pnl_menu, "Width", 296, new TransitionType_EaseInEaseOut(300));
                pb_logo.Size = new Size(129, 145);
                pb_logo.Location = new Point(85, -40);
            }

            //if (pnl_menu.Width == 296)
            //{
            //    pnl_menu.Width = 68;
            //    pb_logo.Size = new Size(65, 62);
            //    pb_logo.Location = new Point(0, 3);
                

            //}
                
            //else
            //{
            //    pnl_menu.Width = 296;
            //    pb_logo.Size = new Size(129, 145);
            //    pb_logo.Location = new Point(85, -40);
            //}
        }
      
       
        #region BOTONES_PRINCIPALES
        private void btn_mecanico_Click(object sender, EventArgs e)
        {
            Mecanico Frm = new Mecanico();
            Frm.TopLevel = false;
            Frm.Dock = DockStyle.Fill;
            pnl_fondo.Controls.Add(Frm);
            Frm.Show();
            Frm.BringToFront();
            if (pnl_menu.Width == 296)
            {
                pnl_menu.Width = 68;
                pb_logo.Size = new Size(65, 62);
                pb_logo.Location = new Point(0, 3);


            }
            foreach (Control control in pnl_menu.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = SystemColors.Control;
                }
            }
            this.btn_mecanico.BackColor = Color.LightGray;
            btn_menu.BringToFront();

        }
        private void btn_electrico_Click(object sender, EventArgs e)
        {
            foreach (Control control in pnl_menu.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = SystemColors.Control;
                }
            }
            this.btn_electrico.BackColor = Color.LightGray;
            btn_menu.BringToFront();
        }
        private void btn_informe_Click(object sender, EventArgs e)
        {
            Informes Frm_1 = new Informes();
            Frm_1.TopLevel = false;
            Frm_1.Dock = DockStyle.Fill;
            pnl_fondo.Controls.Add(Frm_1);
            Frm_1.Show();
            Frm_1.BringToFront();
            if (pnl_menu.Width == 296)
            {
                pnl_menu.Width = 68;
                pb_logo.Size = new Size(65, 62);
                pb_logo.Location = new Point(0, 3);


            }
            foreach (Control control in pnl_menu.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = SystemColors.Control;
                }
            }
            this.btn_informe.BackColor = Color.LightGray;
            btn_menu.BringToFront();
        }
        #endregion
    }
}
