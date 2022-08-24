namespace Producción
{
    partial class EditLubri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLubri));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_principal = new System.Windows.Forms.CheckBox();
            this.cbx_unidadTiempo = new System.Windows.Forms.ComboBox();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_tiempo = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_pto = new System.Windows.Forms.TextBox();
            this.lbl_pto = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.lbl_lubricante = new System.Windows.Forms.Label();
            this.txt_puntoL = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_frecuencia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_lubricante = new System.Windows.Forms.ComboBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_titulo.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_titulo.Location = new System.Drawing.Point(106, 18);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(216, 26);
            this.lbl_titulo.TabIndex = 26;
            this.lbl_titulo.Text = "LUBRICACION";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_principal);
            this.groupBox1.Controls.Add(this.cbx_unidadTiempo);
            this.groupBox1.Controls.Add(this.lbl_unidad);
            this.groupBox1.Controls.Add(this.cbx_estado);
            this.groupBox1.Controls.Add(this.lbl_estado);
            this.groupBox1.Controls.Add(this.txt_tiempo);
            this.groupBox1.Controls.Add(this.txt_cantidad);
            this.groupBox1.Controls.Add(this.lbl_cantidad);
            this.groupBox1.Controls.Add(this.txt_pto);
            this.groupBox1.Controls.Add(this.lbl_pto);
            this.groupBox1.Controls.Add(this.txt_tipo);
            this.groupBox1.Controls.Add(this.lbl_lubricante);
            this.groupBox1.Controls.Add(this.txt_puntoL);
            this.groupBox1.Controls.Add(this.lbl_tipo);
            this.groupBox1.Controls.Add(this.lbl_frecuencia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_lubricante);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 459);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // cbx_principal
            // 
            this.cbx_principal.AutoSize = true;
            this.cbx_principal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_principal.Location = new System.Drawing.Point(24, 415);
            this.cbx_principal.Name = "cbx_principal";
            this.cbx_principal.Size = new System.Drawing.Size(348, 21);
            this.cbx_principal.TabIndex = 45;
            this.cbx_principal.Text = "Seleccionar como punto de lubricación principal.";
            this.cbx_principal.UseVisualStyleBackColor = true;
            // 
            // cbx_unidadTiempo
            // 
            this.cbx_unidadTiempo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_unidadTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_unidadTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_unidadTiempo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_unidadTiempo.FormattingEnabled = true;
            this.cbx_unidadTiempo.Items.AddRange(new object[] {
            "Seleccione",
            "Dias",
            "Meses",
            "Años"});
            this.cbx_unidadTiempo.Location = new System.Drawing.Point(78, 332);
            this.cbx_unidadTiempo.Name = "cbx_unidadTiempo";
            this.cbx_unidadTiempo.Size = new System.Drawing.Size(97, 28);
            this.cbx_unidadTiempo.TabIndex = 44;
            this.cbx_unidadTiempo.SelectedIndexChanged += new System.EventHandler(this.cbx_frecuencia_SelectedIndexChanged);
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidad.Location = new System.Drawing.Point(316, 243);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(46, 18);
            this.lbl_unidad.TabIndex = 43;
            this.lbl_unidad.Text = "label2";
            // 
            // cbx_estado
            // 
            this.cbx_estado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_estado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "- - - - Estado - - - - -",
            "FUN",
            "DET"});
            this.cbx_estado.Location = new System.Drawing.Point(218, 332);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(149, 28);
            this.cbx_estado.TabIndex = 42;
            this.cbx_estado.SelectedIndexChanged += new System.EventHandler(this.cbx_estado_SelectedIndexChanged);
            // 
            // lbl_estado
            // 
            this.lbl_estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_estado.Location = new System.Drawing.Point(214, 314);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(52, 19);
            this.lbl_estado.TabIndex = 41;
            this.lbl_estado.Text = "ESTADO";
            this.lbl_estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_tiempo
            // 
            this.txt_tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiempo.Location = new System.Drawing.Point(24, 336);
            this.txt_tiempo.Name = "txt_tiempo";
            this.txt_tiempo.Size = new System.Drawing.Size(48, 24);
            this.txt_tiempo.TabIndex = 40;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(218, 240);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(92, 24);
            this.txt_cantidad.TabIndex = 39;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_cantidad.Location = new System.Drawing.Point(214, 218);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(66, 19);
            this.lbl_cantidad.TabIndex = 38;
            this.lbl_cantidad.Text = "CANTIDAD";
            this.lbl_cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pto
            // 
            this.txt_pto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pto.Location = new System.Drawing.Point(24, 240);
            this.txt_pto.Name = "txt_pto";
            this.txt_pto.Size = new System.Drawing.Size(151, 24);
            this.txt_pto.TabIndex = 37;
            // 
            // lbl_pto
            // 
            this.lbl_pto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_pto.AutoSize = true;
            this.lbl_pto.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_pto.Location = new System.Drawing.Point(20, 218);
            this.lbl_pto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pto.Name = "lbl_pto";
            this.lbl_pto.Size = new System.Drawing.Size(32, 19);
            this.lbl_pto.TabIndex = 36;
            this.lbl_pto.Text = "PTO";
            this.lbl_pto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_tipo
            // 
            this.txt_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo.Location = new System.Drawing.Point(218, 144);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(149, 24);
            this.txt_tipo.TabIndex = 35;
            // 
            // lbl_lubricante
            // 
            this.lbl_lubricante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lubricante.AutoSize = true;
            this.lbl_lubricante.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lubricante.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_lubricante.Location = new System.Drawing.Point(20, 122);
            this.lbl_lubricante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lubricante.Name = "lbl_lubricante";
            this.lbl_lubricante.Size = new System.Drawing.Size(79, 19);
            this.lbl_lubricante.TabIndex = 33;
            this.lbl_lubricante.Text = "LUBRICANTE";
            this.lbl_lubricante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_puntoL
            // 
            this.txt_puntoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_puntoL.Location = new System.Drawing.Point(24, 48);
            this.txt_puntoL.Name = "txt_puntoL";
            this.txt_puntoL.Size = new System.Drawing.Size(343, 24);
            this.txt_puntoL.TabIndex = 32;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_tipo.Location = new System.Drawing.Point(214, 122);
            this.lbl_tipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(36, 19);
            this.lbl_tipo.TabIndex = 30;
            this.lbl_tipo.Text = "TIPO";
            this.lbl_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_frecuencia
            // 
            this.lbl_frecuencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_frecuencia.AutoSize = true;
            this.lbl_frecuencia.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frecuencia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_frecuencia.Location = new System.Drawing.Point(20, 314);
            this.lbl_frecuencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_frecuencia.Name = "lbl_frecuencia";
            this.lbl_frecuencia.Size = new System.Drawing.Size(78, 19);
            this.lbl_frecuencia.TabIndex = 29;
            this.lbl_frecuencia.Text = "FRECUENCIA";
            this.lbl_frecuencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "PUNTO DE LUBRICACION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_lubricante
            // 
            this.cbx_lubricante.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_lubricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_lubricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_lubricante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_lubricante.FormattingEnabled = true;
            this.cbx_lubricante.Items.AddRange(new object[] {
            "- - - Lubricante - - -",
            "Aceite",
            "Grasa"});
            this.cbx_lubricante.Location = new System.Drawing.Point(24, 144);
            this.cbx_lubricante.Name = "cbx_lubricante";
            this.cbx_lubricante.Size = new System.Drawing.Size(151, 28);
            this.cbx_lubricante.TabIndex = 22;
            this.cbx_lubricante.SelectedIndexChanged += new System.EventHandler(this.cbx_lubricante_SelectedIndexChanged);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Aceptar.Location = new System.Drawing.Point(289, 543);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(90, 43);
            this.btn_Aceptar.TabIndex = 32;
            this.btn_Aceptar.Text = "GUARDAR";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Cancelar.Location = new System.Drawing.Point(36, 543);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(90, 43);
            this.btn_Cancelar.TabIndex = 33;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 61);
            this.panel1.TabIndex = 34;
            // 
            // EditLubri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(416, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditLubri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditLubri_FormClosed);
            this.Shown += new System.EventHandler(this.EditLubri_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_lubricante;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_frecuencia;
        private System.Windows.Forms.Label lbl_lubricante;
        private System.Windows.Forms.TextBox txt_puntoL;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_pto;
        private System.Windows.Forms.Label lbl_pto;
        private System.Windows.Forms.ComboBox cbx_unidadTiempo;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_tiempo;
        private System.Windows.Forms.CheckBox cbx_principal;
    }
}