namespace Producción
{
    partial class Mecanico
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mecanico));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.gb_Busqueda = new System.Windows.Forms.GroupBox();
            this.txt_Equipo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.lbl_motor = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cbx_zona = new System.Windows.Forms.ComboBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.opciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_titulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            this.gb_Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.AllowUserToAddRows = false;
            this.dgv_resultado.AllowUserToDeleteRows = false;
            this.dgv_resultado.AllowUserToResizeColumns = false;
            this.dgv_resultado.AllowUserToResizeRows = false;
            this.dgv_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_resultado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 6, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_resultado.Location = new System.Drawing.Point(48, 305);
            this.dgv_resultado.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.ReadOnly = true;
            this.dgv_resultado.RowHeadersVisible = false;
            this.dgv_resultado.RowHeadersWidth = 51;
            this.dgv_resultado.RowTemplate.Height = 24;
            this.dgv_resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado.Size = new System.Drawing.Size(1034, 189);
            this.dgv_resultado.TabIndex = 18;
            this.dgv_resultado.DataSourceChanged += new System.EventHandler(this.dgv_resultado_DataSourceChanged);
            this.dgv_resultado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_resultado_CellMouseClick);
            // 
            // gb_Busqueda
            // 
            this.gb_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Busqueda.Controls.Add(this.txt_Equipo);
            this.gb_Busqueda.Controls.Add(this.lbl_ubicacion);
            this.gb_Busqueda.Controls.Add(this.lbl_motor);
            this.gb_Busqueda.Controls.Add(this.btn_Buscar);
            this.gb_Busqueda.Controls.Add(this.cbx_zona);
            this.gb_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Busqueda.Location = new System.Drawing.Point(27, 112);
            this.gb_Busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Busqueda.Name = "gb_Busqueda";
            this.gb_Busqueda.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Busqueda.Size = new System.Drawing.Size(1082, 136);
            this.gb_Busqueda.TabIndex = 19;
            this.gb_Busqueda.TabStop = false;
            // 
            // txt_Equipo
            // 
            this.txt_Equipo.AcceptsReturn = false;
            this.txt_Equipo.AcceptsTab = false;
            this.txt_Equipo.AnimationSpeed = 200;
            this.txt_Equipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Equipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Equipo.AutoSizeHeight = true;
            this.txt_Equipo.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Equipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Equipo.BackgroundImage")));
            this.txt_Equipo.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txt_Equipo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Equipo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_Equipo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_Equipo.BorderRadius = 1;
            this.txt_Equipo.BorderThickness = 1;
            this.txt_Equipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Equipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Equipo.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Equipo.DefaultText = "";
            this.txt_Equipo.FillColor = System.Drawing.SystemColors.Control;
            this.txt_Equipo.HideSelection = true;
            this.txt_Equipo.IconLeft = null;
            this.txt_Equipo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Equipo.IconPadding = 10;
            this.txt_Equipo.IconRight = null;
            this.txt_Equipo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Equipo.Lines = new string[0];
            this.txt_Equipo.Location = new System.Drawing.Point(39, 64);
            this.txt_Equipo.MaxLength = 32767;
            this.txt_Equipo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Equipo.Modified = false;
            this.txt_Equipo.Multiline = false;
            this.txt_Equipo.Name = "txt_Equipo";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Equipo.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Equipo.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Equipo.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.SystemColors.Control;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Equipo.OnIdleState = stateProperties8;
            this.txt_Equipo.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Equipo.PasswordChar = '\0';
            this.txt_Equipo.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_Equipo.PlaceholderText = "Ingrese el Código del Equipo";
            this.txt_Equipo.ReadOnly = false;
            this.txt_Equipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Equipo.SelectedText = "";
            this.txt_Equipo.SelectionLength = 0;
            this.txt_Equipo.SelectionStart = 0;
            this.txt_Equipo.ShortcutsEnabled = true;
            this.txt_Equipo.Size = new System.Drawing.Size(257, 38);
            this.txt_Equipo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txt_Equipo.TabIndex = 15;
            this.txt_Equipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Equipo.TextMarginBottom = 0;
            this.txt_Equipo.TextMarginLeft = 3;
            this.txt_Equipo.TextMarginTop = 1;
            this.txt_Equipo.TextPlaceholder = "Ingrese el Código del Equipo";
            this.txt_Equipo.UseSystemPasswordChar = false;
            this.txt_Equipo.WordWrap = true;
            this.txt_Equipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Equipo_KeyPress);
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ubicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl_ubicacion.Location = new System.Drawing.Point(385, 41);
            this.lbl_ubicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(40, 20);
            this.lbl_ubicacion.TabIndex = 14;
            this.lbl_ubicacion.Text = "ZONA";
            // 
            // lbl_motor
            // 
            this.lbl_motor.AutoSize = true;
            this.lbl_motor.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl_motor.Location = new System.Drawing.Point(35, 41);
            this.lbl_motor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_motor.Name = "lbl_motor";
            this.lbl_motor.Size = new System.Drawing.Size(56, 20);
            this.lbl_motor.TabIndex = 13;
            this.lbl_motor.Text = "EQUIPO";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Location = new System.Drawing.Point(977, 44);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(71, 58);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cbx_zona
            // 
            this.cbx_zona.BackColor = System.Drawing.SystemColors.Control;
            this.cbx_zona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_zona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_zona.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_zona.FormattingEnabled = true;
            this.cbx_zona.Items.AddRange(new object[] {
            "--Ingrese la Ubicación--",
            "DESPACHOS",
            "PINZA CHICA, GRANDE",
            "TOLVA"});
            this.cbx_zona.Location = new System.Drawing.Point(388, 67);
            this.cbx_zona.Name = "cbx_zona";
            this.cbx_zona.Size = new System.Drawing.Size(279, 29);
            this.cbx_zona.TabIndex = 11;
            this.cbx_zona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_zona_KeyPress);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(93, 511);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(54, 18);
            this.lbl_resultado.TabIndex = 20;
            this.lbl_resultado.Text = "label1";
            // 
            // opciones
            // 
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(61, 4);
            this.opciones.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.opciones_Closed);
            this.opciones.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.opciones_ItemClicked);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl_titulo.Location = new System.Drawing.Point(345, 27);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(288, 47);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "EQUIPOS 2022";
            // 
            // Mecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1131, 549);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.gb_Busqueda);
            this.Controls.Add(this.dgv_resultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mecanico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Mecanico_Shown);
            this.Resize += new System.EventHandler(this.Inicio_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            this.gb_Busqueda.ResumeLayout(false);
            this.gb_Busqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.GroupBox gb_Busqueda;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.Label lbl_motor;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cbx_zona;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.ContextMenuStrip opciones;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_titulo;
        private Bunifu.UI.WinForms.BunifuTextBox txt_Equipo;
    }
}

