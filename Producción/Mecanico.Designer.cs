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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mecanico));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.gb_Busqueda = new System.Windows.Forms.GroupBox();
            this.txt_Codigo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbl_zona = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cbx_zona = new System.Windows.Forms.ComboBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.opciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_titulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_nombre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 6, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_resultado.Location = new System.Drawing.Point(48, 234);
            this.dgv_resultado.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.ReadOnly = true;
            this.dgv_resultado.RowHeadersVisible = false;
            this.dgv_resultado.RowHeadersWidth = 51;
            this.dgv_resultado.RowTemplate.Height = 24;
            this.dgv_resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado.Size = new System.Drawing.Size(1251, 260);
            this.dgv_resultado.TabIndex = 18;
            this.dgv_resultado.DataSourceChanged += new System.EventHandler(this.dgv_resultado_DataSourceChanged);
            this.dgv_resultado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_resultado_CellMouseClick);
            // 
            // gb_Busqueda
            // 
            this.gb_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Busqueda.Controls.Add(this.label1);
            this.gb_Busqueda.Controls.Add(this.comboBox1);
            this.gb_Busqueda.Controls.Add(this.txt_nombre);
            this.gb_Busqueda.Controls.Add(this.lbl_nombre);
            this.gb_Busqueda.Controls.Add(this.txt_Codigo);
            this.gb_Busqueda.Controls.Add(this.lbl_zona);
            this.gb_Busqueda.Controls.Add(this.lbl_codigo);
            this.gb_Busqueda.Controls.Add(this.btn_Buscar);
            this.gb_Busqueda.Controls.Add(this.cbx_zona);
            this.gb_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Busqueda.Location = new System.Drawing.Point(27, 100);
            this.gb_Busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Busqueda.Name = "gb_Busqueda";
            this.gb_Busqueda.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Busqueda.Size = new System.Drawing.Size(1299, 192);
            this.gb_Busqueda.TabIndex = 19;
            this.gb_Busqueda.TabStop = false;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.AcceptsReturn = false;
            this.txt_Codigo.AcceptsTab = false;
            this.txt_Codigo.AnimationSpeed = 200;
            this.txt_Codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Codigo.AutoSizeHeight = true;
            this.txt_Codigo.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Codigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Codigo.BackgroundImage")));
            this.txt_Codigo.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txt_Codigo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Codigo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_Codigo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_Codigo.BorderRadius = 1;
            this.txt_Codigo.BorderThickness = 1;
            this.txt_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Codigo.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.DefaultText = "";
            this.txt_Codigo.FillColor = System.Drawing.SystemColors.Control;
            this.txt_Codigo.HideSelection = true;
            this.txt_Codigo.IconLeft = null;
            this.txt_Codigo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Codigo.IconPadding = 10;
            this.txt_Codigo.IconRight = null;
            this.txt_Codigo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Codigo.Lines = new string[0];
            this.txt_Codigo.Location = new System.Drawing.Point(345, 44);
            this.txt_Codigo.MaxLength = 32767;
            this.txt_Codigo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Codigo.Modified = false;
            this.txt_Codigo.Multiline = false;
            this.txt_Codigo.Name = "txt_Codigo";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Codigo.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Codigo.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Codigo.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.SystemColors.Control;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Codigo.OnIdleState = stateProperties8;
            this.txt_Codigo.Padding = new System.Windows.Forms.Padding(3);
            this.txt_Codigo.PasswordChar = '\0';
            this.txt_Codigo.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_Codigo.PlaceholderText = "Ingrese el Código del Equipo";
            this.txt_Codigo.ReadOnly = false;
            this.txt_Codigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Codigo.SelectedText = "";
            this.txt_Codigo.SelectionLength = 0;
            this.txt_Codigo.SelectionStart = 0;
            this.txt_Codigo.ShortcutsEnabled = true;
            this.txt_Codigo.Size = new System.Drawing.Size(212, 38);
            this.txt_Codigo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txt_Codigo.TabIndex = 15;
            this.txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Codigo.TextMarginBottom = 0;
            this.txt_Codigo.TextMarginLeft = 3;
            this.txt_Codigo.TextMarginTop = 1;
            this.txt_Codigo.TextPlaceholder = "Ingrese el Código del Equipo";
            this.txt_Codigo.UseSystemPasswordChar = false;
            this.txt_Codigo.WordWrap = true;
            this.txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Equipo_KeyPress);
            // 
            // lbl_zona
            // 
            this.lbl_zona.AutoSize = true;
            this.lbl_zona.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl_zona.Location = new System.Drawing.Point(643, 21);
            this.lbl_zona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_zona.Name = "lbl_zona";
            this.lbl_zona.Size = new System.Drawing.Size(40, 20);
            this.lbl_zona.TabIndex = 14;
            this.lbl_zona.Text = "ZONA";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl_codigo.Location = new System.Drawing.Point(355, 21);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(59, 20);
            this.lbl_codigo.TabIndex = 13;
            this.lbl_codigo.Text = "CODIGO";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Location = new System.Drawing.Point(1201, 24);
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
            this.cbx_zona.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_zona.FormattingEnabled = true;
            this.cbx_zona.Items.AddRange(new object[] {
            "--Ingrese la Ubicación--",
            "DESPACHOS",
            "PINZA CHICA, GRANDE",
            "TOLVA"});
            this.cbx_zona.Location = new System.Drawing.Point(640, 54);
            this.cbx_zona.Name = "cbx_zona";
            this.cbx_zona.Size = new System.Drawing.Size(262, 28);
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
            // txt_nombre
            // 
            this.txt_nombre.AcceptsReturn = false;
            this.txt_nombre.AcceptsTab = false;
            this.txt_nombre.AnimationSpeed = 200;
            this.txt_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_nombre.AutoSizeHeight = true;
            this.txt_nombre.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_nombre.BackgroundImage")));
            this.txt_nombre.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txt_nombre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_nombre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_nombre.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_nombre.BorderRadius = 1;
            this.txt_nombre.BorderThickness = 1;
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.DefaultText = "";
            this.txt_nombre.FillColor = System.Drawing.SystemColors.Control;
            this.txt_nombre.HideSelection = true;
            this.txt_nombre.IconLeft = null;
            this.txt_nombre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.IconPadding = 10;
            this.txt_nombre.IconRight = null;
            this.txt_nombre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(32, 44);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_nombre.Modified = false;
            this.txt_nombre.Multiline = false;
            this.txt_nombre.Name = "txt_nombre";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_nombre.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_nombre.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_nombre.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.SystemColors.Control;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_nombre.OnIdleState = stateProperties4;
            this.txt_nombre.Padding = new System.Windows.Forms.Padding(3);
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_nombre.PlaceholderText = "Ingrese el nombre del Equipo";
            this.txt_nombre.ReadOnly = false;
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.ShortcutsEnabled = true;
            this.txt_nombre.Size = new System.Drawing.Size(248, 38);
            this.txt_nombre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txt_nombre.TabIndex = 17;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nombre.TextMarginBottom = 0;
            this.txt_nombre.TextMarginLeft = 3;
            this.txt_nombre.TextMarginTop = 1;
            this.txt_nombre.TextPlaceholder = "Ingrese el nombre del Equipo";
            this.txt_nombre.UseSystemPasswordChar = false;
            this.txt_nombre.WordWrap = true;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl_nombre.Location = new System.Drawing.Point(42, 21);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(63, 20);
            this.lbl_nombre.TabIndex = 16;
            this.lbl_nombre.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(37, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ZONA";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Ingrese la Ubicación--",
            "DESPACHOS",
            "PINZA CHICA, GRANDE",
            "TOLVA"});
            this.comboBox1.Location = new System.Drawing.Point(32, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // Mecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1348, 549);
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
        private System.Windows.Forms.Label lbl_zona;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cbx_zona;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.ContextMenuStrip opciones;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_titulo;
        private Bunifu.UI.WinForms.BunifuTextBox txt_Codigo;
        private Bunifu.UI.WinForms.BunifuTextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

