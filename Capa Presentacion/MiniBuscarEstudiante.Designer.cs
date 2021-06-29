
namespace CapaPresentacion
{
    partial class MiniBuscarEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniBuscarEstudiante));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dgvEstudiantes = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnConfirmar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEstRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowCustomTheming = false;
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEstudiantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstudiantes.AutoGenerateColumns = false;
            this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudiantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstudiantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstudiantes.ColumnHeadersHeight = 40;
            this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apPaternoDataGridViewTextBoxColumn,
            this.apMaternoDataGridViewTextBoxColumn});
            this.dgvEstudiantes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvEstudiantes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEstudiantes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEstudiantes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEstudiantes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEstudiantes.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvEstudiantes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEstudiantes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEstudiantes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvEstudiantes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstudiantes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvEstudiantes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstudiantes.CurrentTheme.Name = null;
            this.dgvEstudiantes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEstudiantes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvEstudiantes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEstudiantes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvEstudiantes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEstudiantes.DataSource = this.estudianteBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstudiantes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstudiantes.EnableHeadersVisualStyles = false;
            this.dgvEstudiantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvEstudiantes.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvEstudiantes.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvEstudiantes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEstudiantes.Location = new System.Drawing.Point(12, 72);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.RowHeadersVisible = false;
            this.dgvEstudiantes.RowTemplate.Height = 40;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(760, 429);
            this.dgvEstudiantes.TabIndex = 22;
            this.dgvEstudiantes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnConfirmar.CustomizableEdges = borderEdges1;
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
            this.btnConfirmar.TabIndex = 25;
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirmar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmar.TextMarginLeft = 0;
            this.btnConfirmar.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConfirmar.UseDefaultRadiusAndThickness = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEstRefresh.CustomizableEdges = borderEdges2;
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
            this.btnEstRefresh.TabIndex = 24;
            this.btnEstRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEstRefresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEstRefresh.TextMarginLeft = 0;
            this.btnEstRefresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEstRefresh.UseDefaultRadiusAndThickness = true;
            this.btnEstRefresh.Click += new System.EventHandler(this.btnEstRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = global::CapaPresentacion.Properties.Resources.search;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(435, 12);
            this.txtSearch.MaxLength = 8;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Dni";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(337, 37);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Dni";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.OnIconRightClick += new System.EventHandler(this.txtSearch_OnIconRightClick);
            // 
            // tutorBindingSource
            // 
            this.tutorBindingSource.DataSource = typeof(CapaEntidad.Tutor);
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataSource = typeof(CapaEntidad.Estudiante);
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
            // MiniBuscarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnEstRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvEstudiantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MiniBuscarEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnConfirmar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEstRefresh;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvEstudiantes;
        private System.Windows.Forms.BindingSource tutorBindingSource;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apMaternoDataGridViewTextBoxColumn;
    }
}