
namespace Capa_Presentacion
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDocente = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEstudiante = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnInicio = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.imgLogoMini = new System.Windows.Forms.PictureBox();
            this.menuTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.frmSubMenu1 = new Capa_Presentacion.frmSubMenu();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.pnlMainMenu.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoMini)).BeginInit();
            this.pnlSubMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.pnlMainMenu.Controls.Add(this.bunifuButton4);
            this.pnlMainMenu.Controls.Add(this.btnDocente);
            this.pnlMainMenu.Controls.Add(this.btnEstudiante);
            this.pnlMainMenu.Controls.Add(this.btnInicio);
            this.pnlMainMenu.Controls.Add(this.bunifuPanel1);
            this.menuTransition.SetDecoration(this.pnlMainMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(55, 761);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // bunifuButton4
            // 
            this.bunifuButton4.AllowAnimations = false;
            this.bunifuButton4.AllowMouseEffects = true;
            this.bunifuButton4.AllowToggling = true;
            this.bunifuButton4.AnimationSpeed = 200;
            this.bunifuButton4.AutoGenerateColors = false;
            this.bunifuButton4.AutoRoundBorders = false;
            this.bunifuButton4.AutoSizeLeftIcon = false;
            this.bunifuButton4.AutoSizeRightIcon = true;
            this.bunifuButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton4.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton4.BackgroundImage")));
            this.bunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.ButtonText = "Inicio";
            this.bunifuButton4.ButtonTextMarginLeft = 0;
            this.bunifuButton4.ColorContrastOnClick = 45;
            this.bunifuButton4.ColorContrastOnHover = 45;
            this.bunifuButton4.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton4.CustomizableEdges = borderEdges1;
            this.menuTransition.SetDecoration(this.bunifuButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.bunifuButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconLeftPadding = new System.Windows.Forms.Padding(17, 3, 3, 3);
            this.bunifuButton4.IconMarginLeft = 11;
            this.bunifuButton4.IconPadding = 10;
            this.bunifuButton4.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton4.IconSize = 20;
            this.bunifuButton4.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuButton4.IdleBorderRadius = 1;
            this.bunifuButton4.IdleBorderThickness = 1;
            this.bunifuButton4.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuButton4.IdleIconLeftImage = global::Capa_Presentacion.Properties.Resources.menu;
            this.bunifuButton4.IdleIconRightImage = null;
            this.bunifuButton4.IndicateFocus = true;
            this.bunifuButton4.Location = new System.Drawing.Point(0, 237);
            this.bunifuButton4.Name = "bunifuButton4";
            this.bunifuButton4.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton4.OnDisabledState.BorderRadius = 1;
            this.bunifuButton4.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnDisabledState.BorderThickness = 1;
            this.bunifuButton4.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton4.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton4.OnDisabledState.IconLeftImage = null;
            this.bunifuButton4.OnDisabledState.IconRightImage = null;
            this.bunifuButton4.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.bunifuButton4.onHoverState.BorderRadius = 1;
            this.bunifuButton4.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.onHoverState.BorderThickness = 1;
            this.bunifuButton4.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.bunifuButton4.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.onHoverState.IconLeftImage = null;
            this.bunifuButton4.onHoverState.IconRightImage = null;
            this.bunifuButton4.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuButton4.OnIdleState.BorderRadius = 1;
            this.bunifuButton4.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnIdleState.BorderThickness = 1;
            this.bunifuButton4.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuButton4.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.OnIdleState.IconLeftImage = global::Capa_Presentacion.Properties.Resources.menu;
            this.bunifuButton4.OnIdleState.IconRightImage = null;
            this.bunifuButton4.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.bunifuButton4.OnPressedState.BorderRadius = 1;
            this.bunifuButton4.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton4.OnPressedState.BorderThickness = 1;
            this.bunifuButton4.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.bunifuButton4.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton4.OnPressedState.IconLeftImage = null;
            this.bunifuButton4.OnPressedState.IconRightImage = null;
            this.bunifuButton4.Size = new System.Drawing.Size(55, 45);
            this.bunifuButton4.TabIndex = 6;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton4.TextMarginLeft = 0;
            this.bunifuButton4.TextPadding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.bunifuButton4.UseDefaultRadiusAndThickness = true;
            // 
            // btnDocente
            // 
            this.btnDocente.AllowAnimations = false;
            this.btnDocente.AllowMouseEffects = true;
            this.btnDocente.AllowToggling = true;
            this.btnDocente.AnimationSpeed = 200;
            this.btnDocente.AutoGenerateColors = false;
            this.btnDocente.AutoRoundBorders = false;
            this.btnDocente.AutoSizeLeftIcon = false;
            this.btnDocente.AutoSizeRightIcon = true;
            this.btnDocente.BackColor = System.Drawing.Color.Transparent;
            this.btnDocente.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnDocente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDocente.BackgroundImage")));
            this.btnDocente.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDocente.ButtonText = "Docente";
            this.btnDocente.ButtonTextMarginLeft = 0;
            this.btnDocente.ColorContrastOnClick = 45;
            this.btnDocente.ColorContrastOnHover = 45;
            this.btnDocente.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDocente.CustomizableEdges = borderEdges2;
            this.menuTransition.SetDecoration(this.btnDocente, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnDocente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDocente.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDocente.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDocente.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocente.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnDocente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocente.ForeColor = System.Drawing.Color.White;
            this.btnDocente.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocente.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDocente.IconLeftPadding = new System.Windows.Forms.Padding(17, 3, 3, 3);
            this.btnDocente.IconMarginLeft = 11;
            this.btnDocente.IconPadding = 10;
            this.btnDocente.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocente.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDocente.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDocente.IconSize = 20;
            this.btnDocente.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnDocente.IdleBorderRadius = 1;
            this.btnDocente.IdleBorderThickness = 1;
            this.btnDocente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnDocente.IdleIconLeftImage = global::Capa_Presentacion.Properties.Resources.maestro;
            this.btnDocente.IdleIconRightImage = null;
            this.btnDocente.IndicateFocus = true;
            this.btnDocente.Location = new System.Drawing.Point(0, 192);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDocente.OnDisabledState.BorderRadius = 1;
            this.btnDocente.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDocente.OnDisabledState.BorderThickness = 1;
            this.btnDocente.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDocente.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDocente.OnDisabledState.IconLeftImage = null;
            this.btnDocente.OnDisabledState.IconRightImage = null;
            this.btnDocente.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnDocente.onHoverState.BorderRadius = 1;
            this.btnDocente.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDocente.onHoverState.BorderThickness = 1;
            this.btnDocente.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnDocente.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDocente.onHoverState.IconLeftImage = null;
            this.btnDocente.onHoverState.IconRightImage = null;
            this.btnDocente.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnDocente.OnIdleState.BorderRadius = 1;
            this.btnDocente.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDocente.OnIdleState.BorderThickness = 1;
            this.btnDocente.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnDocente.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDocente.OnIdleState.IconLeftImage = global::Capa_Presentacion.Properties.Resources.maestro;
            this.btnDocente.OnIdleState.IconRightImage = null;
            this.btnDocente.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnDocente.OnPressedState.BorderRadius = 1;
            this.btnDocente.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDocente.OnPressedState.BorderThickness = 1;
            this.btnDocente.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnDocente.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDocente.OnPressedState.IconLeftImage = null;
            this.btnDocente.OnPressedState.IconRightImage = null;
            this.btnDocente.Size = new System.Drawing.Size(55, 45);
            this.btnDocente.TabIndex = 5;
            this.btnDocente.Tag = "2";
            this.btnDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDocente.TextMarginLeft = 0;
            this.btnDocente.TextPadding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.btnDocente.UseDefaultRadiusAndThickness = true;
            this.btnDocente.Click += new System.EventHandler(this.SideMenu_Click);
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.AllowAnimations = false;
            this.btnEstudiante.AllowMouseEffects = true;
            this.btnEstudiante.AllowToggling = true;
            this.btnEstudiante.AnimationSpeed = 200;
            this.btnEstudiante.AutoGenerateColors = false;
            this.btnEstudiante.AutoRoundBorders = false;
            this.btnEstudiante.AutoSizeLeftIcon = false;
            this.btnEstudiante.AutoSizeRightIcon = true;
            this.btnEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnEstudiante.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnEstudiante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEstudiante.BackgroundImage")));
            this.btnEstudiante.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEstudiante.ButtonText = "Estudiante";
            this.btnEstudiante.ButtonTextMarginLeft = 0;
            this.btnEstudiante.ColorContrastOnClick = 45;
            this.btnEstudiante.ColorContrastOnHover = 45;
            this.btnEstudiante.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnEstudiante.CustomizableEdges = borderEdges3;
            this.menuTransition.SetDecoration(this.btnEstudiante, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnEstudiante.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEstudiante.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEstudiante.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEstudiante.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstudiante.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnEstudiante.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiante.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEstudiante.IconLeftPadding = new System.Windows.Forms.Padding(17, 3, 3, 3);
            this.btnEstudiante.IconMarginLeft = 11;
            this.btnEstudiante.IconPadding = 10;
            this.btnEstudiante.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstudiante.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEstudiante.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEstudiante.IconSize = 20;
            this.btnEstudiante.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnEstudiante.IdleBorderRadius = 1;
            this.btnEstudiante.IdleBorderThickness = 1;
            this.btnEstudiante.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnEstudiante.IdleIconLeftImage = global::Capa_Presentacion.Properties.Resources.student;
            this.btnEstudiante.IdleIconRightImage = null;
            this.btnEstudiante.IndicateFocus = true;
            this.btnEstudiante.Location = new System.Drawing.Point(0, 147);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEstudiante.OnDisabledState.BorderRadius = 1;
            this.btnEstudiante.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEstudiante.OnDisabledState.BorderThickness = 1;
            this.btnEstudiante.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEstudiante.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEstudiante.OnDisabledState.IconLeftImage = null;
            this.btnEstudiante.OnDisabledState.IconRightImage = null;
            this.btnEstudiante.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnEstudiante.onHoverState.BorderRadius = 1;
            this.btnEstudiante.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEstudiante.onHoverState.BorderThickness = 1;
            this.btnEstudiante.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnEstudiante.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEstudiante.onHoverState.IconLeftImage = null;
            this.btnEstudiante.onHoverState.IconRightImage = null;
            this.btnEstudiante.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnEstudiante.OnIdleState.BorderRadius = 1;
            this.btnEstudiante.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEstudiante.OnIdleState.BorderThickness = 1;
            this.btnEstudiante.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnEstudiante.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEstudiante.OnIdleState.IconLeftImage = global::Capa_Presentacion.Properties.Resources.student;
            this.btnEstudiante.OnIdleState.IconRightImage = null;
            this.btnEstudiante.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnEstudiante.OnPressedState.BorderRadius = 1;
            this.btnEstudiante.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEstudiante.OnPressedState.BorderThickness = 1;
            this.btnEstudiante.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnEstudiante.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEstudiante.OnPressedState.IconLeftImage = null;
            this.btnEstudiante.OnPressedState.IconRightImage = null;
            this.btnEstudiante.Size = new System.Drawing.Size(55, 45);
            this.btnEstudiante.TabIndex = 4;
            this.btnEstudiante.Tag = "1";
            this.btnEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiante.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEstudiante.TextMarginLeft = 0;
            this.btnEstudiante.TextPadding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.btnEstudiante.UseDefaultRadiusAndThickness = true;
            this.btnEstudiante.Click += new System.EventHandler(this.SideMenu_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.AllowAnimations = false;
            this.btnInicio.AllowMouseEffects = true;
            this.btnInicio.AllowToggling = true;
            this.btnInicio.AnimationSpeed = 200;
            this.btnInicio.AutoGenerateColors = false;
            this.btnInicio.AutoRoundBorders = false;
            this.btnInicio.AutoSizeLeftIcon = false;
            this.btnInicio.AutoSizeRightIcon = true;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.BackgroundImage")));
            this.btnInicio.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInicio.ButtonText = "Inicio";
            this.btnInicio.ButtonTextMarginLeft = 0;
            this.btnInicio.ColorContrastOnClick = 45;
            this.btnInicio.ColorContrastOnHover = 45;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnInicio.CustomizableEdges = borderEdges4;
            this.menuTransition.SetDecoration(this.btnInicio, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnInicio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInicio.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInicio.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInicio.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnInicio.IconLeftPadding = new System.Windows.Forms.Padding(17, 3, 3, 3);
            this.btnInicio.IconMarginLeft = 11;
            this.btnInicio.IconPadding = 10;
            this.btnInicio.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicio.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnInicio.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnInicio.IconSize = 20;
            this.btnInicio.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnInicio.IdleBorderRadius = 1;
            this.btnInicio.IdleBorderThickness = 1;
            this.btnInicio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnInicio.IdleIconLeftImage = global::Capa_Presentacion.Properties.Resources.menu;
            this.btnInicio.IdleIconRightImage = null;
            this.btnInicio.IndicateFocus = true;
            this.btnInicio.Location = new System.Drawing.Point(0, 102);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnInicio.OnDisabledState.BorderRadius = 1;
            this.btnInicio.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInicio.OnDisabledState.BorderThickness = 1;
            this.btnInicio.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnInicio.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnInicio.OnDisabledState.IconLeftImage = null;
            this.btnInicio.OnDisabledState.IconRightImage = null;
            this.btnInicio.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnInicio.onHoverState.BorderRadius = 1;
            this.btnInicio.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInicio.onHoverState.BorderThickness = 1;
            this.btnInicio.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnInicio.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnInicio.onHoverState.IconLeftImage = null;
            this.btnInicio.onHoverState.IconRightImage = null;
            this.btnInicio.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnInicio.OnIdleState.BorderRadius = 1;
            this.btnInicio.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInicio.OnIdleState.BorderThickness = 1;
            this.btnInicio.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.btnInicio.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnInicio.OnIdleState.IconLeftImage = global::Capa_Presentacion.Properties.Resources.menu;
            this.btnInicio.OnIdleState.IconRightImage = null;
            this.btnInicio.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnInicio.OnPressedState.BorderRadius = 1;
            this.btnInicio.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnInicio.OnPressedState.BorderThickness = 1;
            this.btnInicio.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(79)))));
            this.btnInicio.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnInicio.OnPressedState.IconLeftImage = null;
            this.btnInicio.OnPressedState.IconRightImage = null;
            this.btnInicio.Size = new System.Drawing.Size(55, 45);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Tag = "0";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInicio.TextMarginLeft = 0;
            this.btnInicio.TextPadding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.btnInicio.UseDefaultRadiusAndThickness = true;
            this.btnInicio.Click += new System.EventHandler(this.SideMenu_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.imgLogoMini);
            this.menuTransition.SetDecoration(this.bunifuPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(55, 102);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // imgLogoMini
            // 
            this.imgLogoMini.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuTransition.SetDecoration(this.imgLogoMini, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.imgLogoMini.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoMini.Image")));
            this.imgLogoMini.Location = new System.Drawing.Point(5, 20);
            this.imgLogoMini.Name = "imgLogoMini";
            this.imgLogoMini.Size = new System.Drawing.Size(45, 50);
            this.imgLogoMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoMini.TabIndex = 0;
            this.imgLogoMini.TabStop = false;
            // 
            // menuTransition
            // 
            this.menuTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.menuTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.menuTransition.DefaultAnimation = animation1;
            // 
            // frmSubMenu1
            // 
            this.menuTransition.SetDecoration(this.frmSubMenu1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.frmSubMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSubMenu1.Location = new System.Drawing.Point(0, 74);
            this.frmSubMenu1.Name = "frmSubMenu1";
            this.frmSubMenu1.Size = new System.Drawing.Size(200, 687);
            this.frmSubMenu1.TabIndex = 1;
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.Controls.Add(this.frmSubMenu1);
            this.pnlSubMenu.Controls.Add(this.panel1);
            this.menuTransition.SetDecoration(this.pnlSubMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pnlSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubMenu.Location = new System.Drawing.Point(55, 0);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Size = new System.Drawing.Size(200, 761);
            this.pnlSubMenu.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.menuTransition.SetDecoration(this.panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 74);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.menuTransition.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.pnlSubMenu);
            this.Controls.Add(this.pnlMainMenu);
            this.menuTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Name = "frmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Escolar";
            this.pnlMainMenu.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoMini)).EndInit();
            this.pnlSubMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.PictureBox imgLogoMini;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnInicio;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDocente;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEstudiante;
        private Bunifu.UI.WinForms.BunifuTransition menuTransition;
        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Panel pnlSubMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private frmSubMenu frmSubMenu1;
    }
}