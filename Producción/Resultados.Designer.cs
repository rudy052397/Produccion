namespace Producción
{
    partial class Resultados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.cbx_asunto = new System.Windows.Forms.ComboBox();
            this.lbl_vacio = new System.Windows.Forms.Label();
            this.dgv_actividad = new System.Windows.Forms.DataGridView();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.dgv_lubricacion = new System.Windows.Forms.DataGridView();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.cm_Actividad = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cm_lubricacion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_actividad)).BeginInit();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lubricacion)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_detalle);
            this.panel1.Controls.Add(this.lbl_ubicacion);
            this.panel1.Controls.Add(this.cbx_asunto);
            this.panel1.Controls.Add(this.lbl_vacio);
            this.panel1.Controls.Add(this.dgv_actividad);
            this.panel1.Controls.Add(this.pnl_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 647);
            this.panel1.TabIndex = 2;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar.BackgroundImage")));
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(390, 95);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(48, 44);
            this.btn_agregar.TabIndex = 25;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 435);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "DETALLE :";
            // 
            // txt_detalle
            // 
            this.txt_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_detalle.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_detalle.Location = new System.Drawing.Point(17, 460);
            this.txt_detalle.Multiline = true;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(445, 175);
            this.txt_detalle.TabIndex = 23;
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ubicacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ubicacion.Location = new System.Drawing.Point(13, 105);
            this.lbl_ubicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(56, 20);
            this.lbl_ubicacion.TabIndex = 22;
            this.lbl_ubicacion.Text = "FILTRO :";
            // 
            // cbx_asunto
            // 
            this.cbx_asunto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_asunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_asunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_asunto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_asunto.FormattingEnabled = true;
            this.cbx_asunto.Items.AddRange(new object[] {
            "--Ingrese la Ubicación--",
            "DESPACHOS",
            "PINZA CHICA, GRANDE",
            "TOLVA"});
            this.cbx_asunto.Location = new System.Drawing.Point(114, 102);
            this.cbx_asunto.Name = "cbx_asunto";
            this.cbx_asunto.Size = new System.Drawing.Size(203, 29);
            this.cbx_asunto.TabIndex = 21;
            this.cbx_asunto.SelectedIndexChanged += new System.EventHandler(this.cbx_asunto_SelectedIndexChanged);
            // 
            // lbl_vacio
            // 
            this.lbl_vacio.AutoSize = true;
            this.lbl_vacio.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vacio.Location = new System.Drawing.Point(158, 352);
            this.lbl_vacio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_vacio.Name = "lbl_vacio";
            this.lbl_vacio.Size = new System.Drawing.Size(205, 17);
            this.lbl_vacio.TabIndex = 20;
            this.lbl_vacio.Text = "\"No se encontraron registros\"";
            this.lbl_vacio.Visible = false;
            // 
            // dgv_actividad
            // 
            this.dgv_actividad.AllowUserToAddRows = false;
            this.dgv_actividad.AllowUserToDeleteRows = false;
            this.dgv_actividad.AllowUserToResizeColumns = false;
            this.dgv_actividad.AllowUserToResizeRows = false;
            this.dgv_actividad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_actividad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_actividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_actividad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_actividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 6, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_actividad.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_actividad.EnableHeadersVisualStyles = false;
            this.dgv_actividad.Location = new System.Drawing.Point(17, 151);
            this.dgv_actividad.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_actividad.Name = "dgv_actividad";
            this.dgv_actividad.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_actividad.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_actividad.RowHeadersVisible = false;
            this.dgv_actividad.RowHeadersWidth = 51;
            this.dgv_actividad.RowTemplate.Height = 24;
            this.dgv_actividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_actividad.Size = new System.Drawing.Size(445, 257);
            this.dgv_actividad.TabIndex = 19;
            this.dgv_actividad.DataSourceChanged += new System.EventHandler(this.dgv_resultado_DataSourceChanged);
            this.dgv_actividad.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_resultado_CellMouseClick);
            this.dgv_actividad.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_resultado_CellMouseDoubleClick);
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnl_titulo.Controls.Add(this.pictureBox1);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(479, 84);
            this.pnl_titulo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_cod);
            this.panel2.Controls.Add(this.dgv_lubricacion);
            this.panel2.Controls.Add(this.lbl_nombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(479, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 647);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(234, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "PUNTOS DE LUBRICACION";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod.ForeColor = System.Drawing.Color.Red;
            this.lbl_cod.Location = new System.Drawing.Point(18, 24);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(113, 38);
            this.lbl_cod.TabIndex = 26;
            this.lbl_cod.Text = "label3";
            // 
            // dgv_lubricacion
            // 
            this.dgv_lubricacion.AllowUserToAddRows = false;
            this.dgv_lubricacion.AllowUserToDeleteRows = false;
            this.dgv_lubricacion.AllowUserToResizeColumns = false;
            this.dgv_lubricacion.AllowUserToResizeRows = false;
            this.dgv_lubricacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_lubricacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_lubricacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_lubricacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_lubricacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lubricacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_lubricacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 6, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_lubricacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_lubricacion.EnableHeadersVisualStyles = false;
            this.dgv_lubricacion.Location = new System.Drawing.Point(38, 209);
            this.dgv_lubricacion.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_lubricacion.Name = "dgv_lubricacion";
            this.dgv_lubricacion.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_lubricacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_lubricacion.RowHeadersVisible = false;
            this.dgv_lubricacion.RowHeadersWidth = 51;
            this.dgv_lubricacion.RowTemplate.Height = 24;
            this.dgv_lubricacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_lubricacion.Size = new System.Drawing.Size(596, 191);
            this.dgv_lubricacion.TabIndex = 25;
            this.dgv_lubricacion.DataSourceChanged += new System.EventHandler(this.dgv_lubricacion_DataSourceChanged);
            this.dgv_lubricacion.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_lubricacion_CellMouseClick);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_nombre.Location = new System.Drawing.Point(19, 80);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(216, 26);
            this.lbl_nombre.TabIndex = 25;
            this.lbl_nombre.Text = "PUNTOS DE LUBRICACION";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cm_Actividad
            // 
            this.cm_Actividad.Name = "cm_Actividad";
            this.cm_Actividad.Size = new System.Drawing.Size(61, 4);
            this.cm_Actividad.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cm_Actividad_Closed);
            this.cm_Actividad.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cm_Actividad_ItemClicked);
            // 
            // cm_lubricacion
            // 
            this.cm_lubricacion.Name = "cm_lubricacion";
            this.cm_lubricacion.Size = new System.Drawing.Size(61, 4);
            this.cm_lubricacion.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cm_lubricacion_Closed);
            this.cm_lubricacion.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cm_lubricacion_ItemClicked);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Resultados_FormClosed);
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.Shown += new System.EventHandler(this.Resultados_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_actividad)).EndInit();
            this.pnl_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lubricacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_vacio;
        public System.Windows.Forms.DataGridView dgv_actividad;
        private System.Windows.Forms.Label lbl_ubicacion;
        public System.Windows.Forms.ComboBox cbx_asunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_detalle;
        public System.Windows.Forms.DataGridView dgv_lubricacion;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_cod;
        public System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ContextMenuStrip cm_Actividad;
        private System.Windows.Forms.ContextMenuStrip cm_lubricacion;
    }
}