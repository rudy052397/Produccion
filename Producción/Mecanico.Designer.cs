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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mecanico));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties33 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties34 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties35 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties36 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties37 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties38 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties39 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties40 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.txt_nombre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_Codigo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbl_zona = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.cbx_zona = new System.Windows.Forms.ComboBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.opciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_titulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.AllowUserToAddRows = false;
            this.dgv_resultado.AllowUserToDeleteRows = false;
            this.dgv_resultado.AllowUserToResizeColumns = false;
            this.dgv_resultado.AllowUserToResizeRows = false;
            this.dgv_resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_resultado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5, 0, 6, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_resultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_resultado.Location = new System.Drawing.Point(2, 125);
            this.dgv_resultado.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.ReadOnly = true;
            this.dgv_resultado.RowHeadersVisible = false;
            this.dgv_resultado.RowHeadersWidth = 51;
            this.dgv_resultado.RowTemplate.Height = 24;
            this.dgv_resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado.Size = new System.Drawing.Size(1057, 275);
            this.dgv_resultado.TabIndex = 18;
            this.dgv_resultado.DataSourceChanged += new System.EventHandler(this.dgv_resultado_DataSourceChanged);
            this.dgv_resultado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_resultado_CellMouseClick);
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
            this.txt_nombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_nombre.FillColor = System.Drawing.SystemColors.Control;
            this.txt_nombre.HideSelection = true;
            this.txt_nombre.IconLeft = null;
            this.txt_nombre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.IconPadding = 10;
            this.txt_nombre.IconRight = null;
            this.txt_nombre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(0, 22);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_nombre.Modified = false;
            this.txt_nombre.Multiline = false;
            this.txt_nombre.Name = "txt_nombre";
            stateProperties33.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            stateProperties33.FillColor = System.Drawing.Color.Empty;
            stateProperties33.ForeColor = System.Drawing.Color.Empty;
            stateProperties33.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_nombre.OnActiveState = stateProperties33;
            stateProperties34.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties34.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties34.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_nombre.OnDisabledState = stateProperties34;
            stateProperties35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            stateProperties35.FillColor = System.Drawing.Color.Empty;
            stateProperties35.ForeColor = System.Drawing.Color.Empty;
            stateProperties35.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_nombre.OnHoverState = stateProperties35;
            stateProperties36.BorderColor = System.Drawing.Color.Silver;
            stateProperties36.FillColor = System.Drawing.SystemColors.Control;
            stateProperties36.ForeColor = System.Drawing.Color.Empty;
            stateProperties36.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_nombre.OnIdleState = stateProperties36;
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
            this.txt_nombre.Size = new System.Drawing.Size(253, 38);
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
            this.lbl_nombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_nombre.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl_nombre.Location = new System.Drawing.Point(0, 0);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(63, 20);
            this.lbl_nombre.TabIndex = 16;
            this.lbl_nombre.Text = "NOMBRE";
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
            this.txt_Codigo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Codigo.FillColor = System.Drawing.SystemColors.Control;
            this.txt_Codigo.HideSelection = true;
            this.txt_Codigo.IconLeft = null;
            this.txt_Codigo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Codigo.IconPadding = 10;
            this.txt_Codigo.IconRight = null;
            this.txt_Codigo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Codigo.Lines = new string[0];
            this.txt_Codigo.Location = new System.Drawing.Point(0, 22);
            this.txt_Codigo.MaxLength = 32767;
            this.txt_Codigo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_Codigo.Modified = false;
            this.txt_Codigo.Multiline = false;
            this.txt_Codigo.Name = "txt_Codigo";
            stateProperties37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            stateProperties37.FillColor = System.Drawing.Color.Empty;
            stateProperties37.ForeColor = System.Drawing.Color.Empty;
            stateProperties37.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Codigo.OnActiveState = stateProperties37;
            stateProperties38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties38.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties38.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_Codigo.OnDisabledState = stateProperties38;
            stateProperties39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            stateProperties39.FillColor = System.Drawing.Color.Empty;
            stateProperties39.ForeColor = System.Drawing.Color.Empty;
            stateProperties39.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Codigo.OnHoverState = stateProperties39;
            stateProperties40.BorderColor = System.Drawing.Color.Silver;
            stateProperties40.FillColor = System.Drawing.SystemColors.Control;
            stateProperties40.ForeColor = System.Drawing.Color.Empty;
            stateProperties40.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_Codigo.OnIdleState = stateProperties40;
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
            this.txt_Codigo.Size = new System.Drawing.Size(213, 38);
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
            this.lbl_zona.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_zona.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl_zona.Location = new System.Drawing.Point(0, 0);
            this.lbl_zona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_zona.Name = "lbl_zona";
            this.lbl_zona.Size = new System.Drawing.Size(40, 20);
            this.lbl_zona.TabIndex = 14;
            this.lbl_zona.Text = "ZONA";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_codigo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl_codigo.Location = new System.Drawing.Point(0, 0);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(59, 20);
            this.lbl_codigo.TabIndex = 13;
            this.lbl_codigo.Text = "CODIGO";
            // 
            // cbx_zona
            // 
            this.cbx_zona.BackColor = System.Drawing.SystemColors.Control;
            this.cbx_zona.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbx_zona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_zona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_zona.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_zona.FormattingEnabled = true;
            this.cbx_zona.Items.AddRange(new object[] {
            "--Ingrese la Ubicación--",
            "DESPACHOS",
            "PINZA CHICA, GRANDE",
            "TOLVA"});
            this.cbx_zona.Location = new System.Drawing.Point(0, 32);
            this.cbx_zona.Name = "cbx_zona";
            this.cbx_zona.Size = new System.Drawing.Size(253, 28);
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
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lbl_titulo.Location = new System.Drawing.Point(392, 27);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(288, 47);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "EQUIPOS 2022";
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
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 60);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_codigo);
            this.panel2.Controls.Add(this.txt_Codigo);
            this.panel2.Location = new System.Drawing.Point(289, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 60);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_zona);
            this.panel3.Controls.Add(this.cbx_zona);
            this.panel3.Location = new System.Drawing.Point(535, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 60);
            this.panel3.TabIndex = 22;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Location = new System.Drawing.Point(5, 17);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 58);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Buscar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(949, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(84, 88);
            this.panel4.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_resultado, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1061, 402);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.AutoSize = true;
            this.bunifuPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuPanel1.BorderRadius = 10;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.tableLayoutPanel2);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1055, 117);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1036, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(940, 66);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // Mecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1085, 549);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_resultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mecanico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Mecanico_Shown);
            this.Resize += new System.EventHandler(this.Inicio_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.Label lbl_zona;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.ComboBox cbx_zona;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.ContextMenuStrip opciones;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_titulo;
        private Bunifu.UI.WinForms.BunifuTextBox txt_Codigo;
        private Bunifu.UI.WinForms.BunifuTextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

