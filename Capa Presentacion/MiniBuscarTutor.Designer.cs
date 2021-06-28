
namespace CapaPresentacion
{
    partial class MiniBuscarTutor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniBuscarTutor));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvTutores = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.txtTutSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEstRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnConfirmar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTutores
            // 
            this.dgvTutores.AllowCustomTheming = false;
            this.dgvTutores.AllowUserToAddRows = false;
            this.dgvTutores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTutores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTutores.AutoGenerateColumns = false;
            this.dgvTutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apPaternoDataGridViewTextBoxColumn,
            this.apMaternoDataGridViewTextBoxColumn});
            this.dgvTutores.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvTutores.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTutores.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTutores.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTutores.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTutores.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvTutores.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTutores.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTutores.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvTutores.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTutores.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvTutores.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTutores.CurrentTheme.Name = null;
            this.dgvTutores.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTutores.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTutores.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTutores.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvTutores.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTutores.DataSource = this.tutorBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTutores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTutores.EnableHeadersVisualStyles = false;
            this.dgvTutores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvTutores.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvTutores.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvTutores.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTutores.Location = new System.Drawing.Point(12, 72);
            this.dgvTutores.Name = "dgvTutores";
            this.dgvTutores.ReadOnly = true;
            this.dgvTutores.RowHeadersVisible = false;
            this.dgvTutores.RowTemplate.Height = 40;
            this.dgvTutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTutores.Size = new System.Drawing.Size(760, 429);
            this.dgvTutores.TabIndex = 0;
            this.dgvTutores.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // txtTutSearch
            // 
            this.txtTutSearch.AcceptsReturn = false;
            this.txtTutSearch.AcceptsTab = false;
            this.txtTutSearch.AnimationSpeed = 200;
            this.txtTutSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTutSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTutSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtTutSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTutSearch.BackgroundImage")));
            this.txtTutSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTutSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTutSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTutSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTutSearch.BorderRadius = 1;
            this.txtTutSearch.BorderThickness = 1;
            this.txtTutSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTutSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTutSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtTutSearch.DefaultText = "";
            this.txtTutSearch.FillColor = System.Drawing.Color.White;
            this.txtTutSearch.HideSelection = true;
            this.txtTutSearch.IconLeft = null;
            this.txtTutSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTutSearch.IconPadding = 10;
            this.txtTutSearch.IconRight = global::CapaPresentacion.Properties.Resources.search;
            this.txtTutSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTutSearch.Lines = new string[0];
            this.txtTutSearch.Location = new System.Drawing.Point(435, 12);
            this.txtTutSearch.MaxLength = 8;
            this.txtTutSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTutSearch.Modified = false;
            this.txtTutSearch.Multiline = false;
            this.txtTutSearch.Name = "txtTutSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTutSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTutSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTutSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTutSearch.OnIdleState = stateProperties4;
            this.txtTutSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtTutSearch.PasswordChar = '\0';
            this.txtTutSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTutSearch.PlaceholderText = "Dni";
            this.txtTutSearch.ReadOnly = false;
            this.txtTutSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTutSearch.SelectedText = "";
            this.txtTutSearch.SelectionLength = 0;
            this.txtTutSearch.SelectionStart = 0;
            this.txtTutSearch.ShortcutsEnabled = true;
            this.txtTutSearch.Size = new System.Drawing.Size(337, 37);
            this.txtTutSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTutSearch.TabIndex = 1;
            this.txtTutSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTutSearch.TextMarginBottom = 0;
            this.txtTutSearch.TextMarginLeft = 3;
            this.txtTutSearch.TextMarginTop = 0;
            this.txtTutSearch.TextPlaceholder = "Dni";
            this.txtTutSearch.UseSystemPasswordChar = false;
            this.txtTutSearch.WordWrap = true;
            this.txtTutSearch.OnIconRightClick += new System.EventHandler(this.txtTutSearch_OnIconRightClick);
            // 
            // tutorBindingSource
            // 
            this.tutorBindingSource.DataSource = typeof(CapaEntidad.Tutor);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            this.dniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apPaternoDataGridViewTextBoxColumn
            // 
            this.apPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApPaterno";
            this.apPaternoDataGridViewTextBoxColumn.HeaderText = "ApPaterno";
            this.apPaternoDataGridViewTextBoxColumn.Name = "apPaternoDataGridViewTextBoxColumn";
            this.apPaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apMaternoDataGridViewTextBoxColumn
            // 
            this.apMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApMaterno";
            this.apMaternoDataGridViewTextBoxColumn.HeaderText = "ApMaterno";
            this.apMaternoDataGridViewTextBoxColumn.Name = "apMaternoDataGridViewTextBoxColumn";
            this.apMaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnEstRefresh
            // 
            this.btnEstRefresh.AllowAnimations = true;
            this.btnEstRefresh.AllowMouseEffects = true;
            this.btnEstRefresh.AllowToggling = false;
            this.btnEstRefresh.AnimationSpeed = 200;
            this.btnEstRefresh.AutoGenerateColors = false;
            this.btnEstRefresh.AutoRoundBorders = false;
            this.btnEstRefresh.AutoSizeLeftIcon = true;
            this.btnEstRefresh.AutoSizeRightIcon = true;
            this.btnEstRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnEstRefresh.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnEstRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEstRefresh.BackgroundImage")));
            this.btnEstRefresh.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEstRefresh.ButtonText = "";
            this.btnEstRefresh.ButtonTextMarginLeft = 0;
            this.btnEstRefresh.ColorContrastOnClick = 10;
            this.btnEstRefresh.ColorContrastOnHover = 45;
            this.btnEstRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnEstRefresh.CustomizableEdges = borderEdges1;
            this.btnEstRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEstRefresh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEstRefresh.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEstRefresh.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEstRefresh.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEstRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEstRefresh.ForeColor = System.Drawing.Color.White;
            this.btnEstRefresh.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstRefresh.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEstRefresh.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEstRefresh.IconMarginLeft = 11;
            this.btnEstRefresh.IconPadding = 10;
            this.btnEstRefresh.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEstRefresh.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEstRefresh.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEstRefresh.IconSize = 25;
            this.btnEstRefresh.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEstRefresh.IdleBorderRadius = 35;
            this.btnEstRefresh.IdleBorderThickness = 1;
            this.btnEstRefresh.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnEstRefresh.IdleIconLeftImage = null;
            this.btnEstRefresh.IdleIconRightImage = global::CapaPresentacion.Properties.Resources.refresh_26px;
            this.btnEstRefresh.IndicateFocus = false;
            this.btnEstRefresh.Location = new System.Drawing.Point(393, 12);
            this.btnEstRefresh.Name = "btnEstRefresh";
            this.btnEstRefresh.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEstRefresh.OnDisabledState.BorderRadius = 35;
            this.btnEstRefresh.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEstRefresh.OnDisabledState.BorderThickness = 1;
            this.btnEstRefresh.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEstRefresh.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEstRefresh.OnDisabledState.IconLeftImage = null;
            this.btnEstRefresh.OnDisabledState.IconRightImage = null;
            this.btnEstRefresh.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEstRefresh.onHoverState.BorderRadius = 35;
            this.btnEstRefresh.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEstRefresh.onHoverState.BorderThickness = 1;
            this.btnEstRefresh.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEstRefresh.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEstRefresh.onHoverState.IconLeftImage = null;
            this.btnEstRefresh.onHoverState.IconRightImage = null;
            this.btnEstRefresh.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEstRefresh.OnIdleState.BorderRadius = 35;
            this.btnEstRefresh.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEstRefresh.OnIdleState.BorderThickness = 1;
            this.btnEstRefresh.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnEstRefresh.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEstRefresh.OnIdleState.IconLeftImage = null;
            this.btnEstRefresh.OnIdleState.IconRightImage = global::CapaPresentacion.Properties.Resources.refresh_26px;
            this.btnEstRefresh.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEstRefresh.OnPressedState.BorderRadius = 35;
            this.btnEstRefresh.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEstRefresh.OnPressedState.BorderThickness = 1;
            this.btnEstRefresh.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnEstRefresh.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEstRefresh.OnPressedState.IconLeftImage = null;
            this.btnEstRefresh.OnPressedState.IconRightImage = null;
            this.btnEstRefresh.Size = new System.Drawing.Size(36, 37);
            this.btnEstRefresh.TabIndex = 4;
            this.btnEstRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEstRefresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEstRefresh.TextMarginLeft = 0;
            this.btnEstRefresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEstRefresh.UseDefaultRadiusAndThickness = true;
            this.btnEstRefresh.Click += new System.EventHandler(this.btnEstRefresh_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AllowAnimations = true;
            this.btnConfirmar.AllowMouseEffects = true;
            this.btnConfirmar.AllowToggling = false;
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.AnimationSpeed = 200;
            this.btnConfirmar.AutoGenerateColors = false;
            this.btnConfirmar.AutoRoundBorders = true;
            this.btnConfirmar.AutoSizeLeftIcon = true;
            this.btnConfirmar.AutoSizeRightIcon = true;
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmar.ButtonText = "Confirmar";
            this.btnConfirmar.ButtonTextMarginLeft = 0;
            this.btnConfirmar.ColorContrastOnClick = 45;
            this.btnConfirmar.ColorContrastOnHover = 45;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnConfirmar.CustomizableEdges = borderEdges2;
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmar.IconLeftPadding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnConfirmar.IconMarginLeft = 11;
            this.btnConfirmar.IconPadding = 10;
            this.btnConfirmar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmar.IconRightPadding = new System.Windows.Forms.Padding(3);
            this.btnConfirmar.IconSize = 25;
            this.btnConfirmar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmar.IdleBorderRadius = 37;
            this.btnConfirmar.IdleBorderThickness = 1;
            this.btnConfirmar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmar.IdleIconLeftImage = global::CapaPresentacion.Properties.Resources.checked_26px;
            this.btnConfirmar.IdleIconRightImage = null;
            this.btnConfirmar.IndicateFocus = false;
            this.btnConfirmar.Location = new System.Drawing.Point(626, 510);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnConfirmar.OnDisabledState.BorderRadius = 1;
            this.btnConfirmar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmar.OnDisabledState.BorderThickness = 1;
            this.btnConfirmar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnConfirmar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnConfirmar.OnDisabledState.IconLeftImage = null;
            this.btnConfirmar.OnDisabledState.IconRightImage = null;
            this.btnConfirmar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmar.onHoverState.BorderRadius = 1;
            this.btnConfirmar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmar.onHoverState.BorderThickness = 1;
            this.btnConfirmar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnConfirmar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.onHoverState.IconLeftImage = null;
            this.btnConfirmar.onHoverState.IconRightImage = null;
            this.btnConfirmar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmar.OnIdleState.BorderRadius = 1;
            this.btnConfirmar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmar.OnIdleState.BorderThickness = 1;
            this.btnConfirmar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.OnIdleState.IconLeftImage = global::CapaPresentacion.Properties.Resources.checked_26px;
            this.btnConfirmar.OnIdleState.IconRightImage = null;
            this.btnConfirmar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmar.OnPressedState.BorderRadius = 1;
            this.btnConfirmar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnConfirmar.OnPressedState.BorderThickness = 1;
            this.btnConfirmar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnConfirmar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.OnPressedState.IconLeftImage = null;
            this.btnConfirmar.OnPressedState.IconRightImage = null;
            this.btnConfirmar.Size = new System.Drawing.Size(146, 39);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmar.TextMarginLeft = 0;
            this.btnConfirmar.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConfirmar.UseDefaultRadiusAndThickness = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // MiniBuscarTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnEstRefresh);
            this.Controls.Add(this.txtTutSearch);
            this.Controls.Add(this.dgvTutores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MiniBuscarTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniBuscarTutor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvTutores;
        private Bunifu.UI.WinForms.BunifuTextBox txtTutSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tutorBindingSource;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEstRefresh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfirmar;
    }
}