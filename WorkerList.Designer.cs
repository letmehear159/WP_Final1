namespace WP_Final_Project
{
    partial class WorkerList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerList));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dropDownOccupation = new Bunifu.UI.WinForms.BunifuDropdown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.gvWorkerList = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ddAddress = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ddExp = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ddRate = new Bunifu.UI.WinForms.BunifuDropdown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkerList)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.ddRate);
            this.bunifuPanel1.Controls.Add(this.ddExp);
            this.bunifuPanel1.Controls.Add(this.ddAddress);
            this.bunifuPanel1.Controls.Add(this.dropDownOccupation);
            this.bunifuPanel1.Controls.Add(this.pictureBox1);
            this.bunifuPanel1.Controls.Add(this.bunifuTextBox1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1005, 50);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // dropDownOccupation
            // 
            this.dropDownOccupation.BackColor = System.Drawing.Color.Transparent;
            this.dropDownOccupation.BackgroundColor = System.Drawing.Color.White;
            this.dropDownOccupation.BorderColor = System.Drawing.Color.Silver;
            this.dropDownOccupation.BorderRadius = 1;
            this.dropDownOccupation.Color = System.Drawing.Color.Silver;
            this.dropDownOccupation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDownOccupation.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dropDownOccupation.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropDownOccupation.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dropDownOccupation.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dropDownOccupation.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dropDownOccupation.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dropDownOccupation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropDownOccupation.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dropDownOccupation.DropDownHeight = 100;
            this.dropDownOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownOccupation.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropDownOccupation.FillDropDown = true;
            this.dropDownOccupation.FillIndicator = false;
            this.dropDownOccupation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropDownOccupation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropDownOccupation.ForeColor = System.Drawing.Color.Black;
            this.dropDownOccupation.FormattingEnabled = true;
            this.dropDownOccupation.Icon = null;
            this.dropDownOccupation.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropDownOccupation.IndicatorColor = System.Drawing.Color.Gray;
            this.dropDownOccupation.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dropDownOccupation.IntegralHeight = false;
            this.dropDownOccupation.ItemBackColor = System.Drawing.Color.White;
            this.dropDownOccupation.ItemBorderColor = System.Drawing.Color.White;
            this.dropDownOccupation.ItemForeColor = System.Drawing.Color.Black;
            this.dropDownOccupation.ItemHeight = 20;
            this.dropDownOccupation.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dropDownOccupation.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dropDownOccupation.Items.AddRange(new object[] {
            "Occupation(All)",
            "Builder",
            "IT"});
            this.dropDownOccupation.ItemTopMargin = 3;
            this.dropDownOccupation.Location = new System.Drawing.Point(327, 15);
            this.dropDownOccupation.Name = "dropDownOccupation";
            this.dropDownOccupation.Size = new System.Drawing.Size(122, 26);
            this.dropDownOccupation.TabIndex = 2;
            this.dropDownOccupation.Text = null;
            this.dropDownOccupation.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dropDownOccupation.TextLeftMargin = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Image = global::WP_Final_Project.Properties.Resources.icons8_search_480px;
            this.pictureBox1.Location = new System.Drawing.Point(265, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BorderRadius = 5;
            this.bunifuTextBox1.BorderThickness = 0;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(25, 14);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.bunifuTextBox1.PlaceholderText = "Find Name...";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(234, 27);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 0;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextMarginTop = 0;
            this.bunifuTextBox1.TextPlaceholder = "Find Name...";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            // 
            // gvWorkerList
            // 
            this.gvWorkerList.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gvWorkerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvWorkerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvWorkerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvWorkerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvWorkerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvWorkerList.ColumnHeadersHeight = 40;
            this.gvWorkerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.gvWorkerList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvWorkerList.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvWorkerList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvWorkerList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gvWorkerList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvWorkerList.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.gvWorkerList.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.gvWorkerList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.gvWorkerList.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.gvWorkerList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvWorkerList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.gvWorkerList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gvWorkerList.CurrentTheme.Name = null;
            this.gvWorkerList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvWorkerList.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gvWorkerList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvWorkerList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.gvWorkerList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(121)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvWorkerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvWorkerList.EnableHeadersVisualStyles = false;
            this.gvWorkerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gvWorkerList.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.gvWorkerList.HeaderBgColor = System.Drawing.Color.Empty;
            this.gvWorkerList.HeaderForeColor = System.Drawing.Color.White;
            this.gvWorkerList.Location = new System.Drawing.Point(3, 56);
            this.gvWorkerList.Name = "gvWorkerList";
            this.gvWorkerList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvWorkerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvWorkerList.RowHeadersVisible = false;
            this.gvWorkerList.RowTemplate.DividerHeight = 3;
            this.gvWorkerList.RowTemplate.Height = 30;
            this.gvWorkerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvWorkerList.Size = new System.Drawing.Size(999, 414);
            this.gvWorkerList.TabIndex = 1;
            this.gvWorkerList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ddAddress
            // 
            this.ddAddress.BackColor = System.Drawing.Color.Transparent;
            this.ddAddress.BackgroundColor = System.Drawing.Color.White;
            this.ddAddress.BorderColor = System.Drawing.Color.Silver;
            this.ddAddress.BorderRadius = 1;
            this.ddAddress.Color = System.Drawing.Color.Silver;
            this.ddAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddAddress.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddAddress.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddAddress.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddAddress.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddAddress.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddAddress.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddAddress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddAddress.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddAddress.DropDownHeight = 100;
            this.ddAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddAddress.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddAddress.FillDropDown = true;
            this.ddAddress.FillIndicator = false;
            this.ddAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddAddress.ForeColor = System.Drawing.Color.Black;
            this.ddAddress.FormattingEnabled = true;
            this.ddAddress.Icon = null;
            this.ddAddress.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddAddress.IndicatorColor = System.Drawing.Color.Gray;
            this.ddAddress.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddAddress.IntegralHeight = false;
            this.ddAddress.ItemBackColor = System.Drawing.Color.White;
            this.ddAddress.ItemBorderColor = System.Drawing.Color.White;
            this.ddAddress.ItemForeColor = System.Drawing.Color.Black;
            this.ddAddress.ItemHeight = 20;
            this.ddAddress.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddAddress.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddAddress.Items.AddRange(new object[] {
            "Address",
            "Nearest"});
            this.ddAddress.ItemTopMargin = 3;
            this.ddAddress.Location = new System.Drawing.Point(464, 15);
            this.ddAddress.Name = "ddAddress";
            this.ddAddress.Size = new System.Drawing.Size(122, 26);
            this.ddAddress.TabIndex = 3;
            this.ddAddress.Text = null;
            this.ddAddress.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddAddress.TextLeftMargin = 5;
            // 
            // ddExp
            // 
            this.ddExp.BackColor = System.Drawing.Color.Transparent;
            this.ddExp.BackgroundColor = System.Drawing.Color.White;
            this.ddExp.BorderColor = System.Drawing.Color.Silver;
            this.ddExp.BorderRadius = 1;
            this.ddExp.Color = System.Drawing.Color.Silver;
            this.ddExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddExp.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddExp.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddExp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddExp.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddExp.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddExp.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddExp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddExp.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddExp.DropDownHeight = 100;
            this.ddExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddExp.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddExp.FillDropDown = true;
            this.ddExp.FillIndicator = false;
            this.ddExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddExp.ForeColor = System.Drawing.Color.Black;
            this.ddExp.FormattingEnabled = true;
            this.ddExp.Icon = null;
            this.ddExp.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddExp.IndicatorColor = System.Drawing.Color.Gray;
            this.ddExp.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddExp.IntegralHeight = false;
            this.ddExp.ItemBackColor = System.Drawing.Color.White;
            this.ddExp.ItemBorderColor = System.Drawing.Color.White;
            this.ddExp.ItemForeColor = System.Drawing.Color.Black;
            this.ddExp.ItemHeight = 20;
            this.ddExp.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddExp.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddExp.Items.AddRange(new object[] {
            "Experience"});
            this.ddExp.ItemTopMargin = 3;
            this.ddExp.Location = new System.Drawing.Point(601, 15);
            this.ddExp.Name = "ddExp";
            this.ddExp.Size = new System.Drawing.Size(122, 26);
            this.ddExp.TabIndex = 4;
            this.ddExp.Text = null;
            this.ddExp.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddExp.TextLeftMargin = 5;
            // 
            // ddRate
            // 
            this.ddRate.BackColor = System.Drawing.Color.Transparent;
            this.ddRate.BackgroundColor = System.Drawing.Color.White;
            this.ddRate.BorderColor = System.Drawing.Color.Silver;
            this.ddRate.BorderRadius = 1;
            this.ddRate.Color = System.Drawing.Color.Silver;
            this.ddRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddRate.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddRate.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddRate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddRate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddRate.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddRate.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddRate.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddRate.DropDownHeight = 100;
            this.ddRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddRate.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddRate.FillDropDown = true;
            this.ddRate.FillIndicator = false;
            this.ddRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddRate.ForeColor = System.Drawing.Color.Black;
            this.ddRate.FormattingEnabled = true;
            this.ddRate.Icon = null;
            this.ddRate.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddRate.IndicatorColor = System.Drawing.Color.Gray;
            this.ddRate.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddRate.IntegralHeight = false;
            this.ddRate.ItemBackColor = System.Drawing.Color.White;
            this.ddRate.ItemBorderColor = System.Drawing.Color.White;
            this.ddRate.ItemForeColor = System.Drawing.Color.Black;
            this.ddRate.ItemHeight = 20;
            this.ddRate.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddRate.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddRate.Items.AddRange(new object[] {
            "Rate ",
            "Highest"});
            this.ddRate.ItemTopMargin = 3;
            this.ddRate.Location = new System.Drawing.Point(738, 15);
            this.ddRate.Name = "ddRate";
            this.ddRate.Size = new System.Drawing.Size(122, 26);
            this.ddRate.TabIndex = 5;
            this.ddRate.Text = null;
            this.ddRate.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddRate.TextLeftMargin = 5;
            this.ddRate.SelectedIndexChanged += new System.EventHandler(this.bunifuDropdown3_SelectedIndexChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Occupation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Age";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Experience";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Rate";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.pictureBox1;
            // 
            // WorkerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvWorkerList);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "WorkerList";
            this.Size = new System.Drawing.Size(1005, 519);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.UI.WinForms.BunifuDropdown dropDownOccupation;
        public Bunifu.UI.WinForms.BunifuDataGridView gvWorkerList;
        public Bunifu.UI.WinForms.BunifuDropdown ddRate;
        public Bunifu.UI.WinForms.BunifuDropdown ddExp;
        public Bunifu.UI.WinForms.BunifuDropdown ddAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
