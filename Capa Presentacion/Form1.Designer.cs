
namespace Capa_Presentacion
{
    partial class main_window
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
            this.pnl_sideMenu = new System.Windows.Forms.Panel();
            this.pn_top = new System.Windows.Forms.Panel();
            this.pn_central = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.pctb_logo = new System.Windows.Forms.PictureBox();
            this.btn_estudiantes = new System.Windows.Forms.Button();
            this.pnl_estudiantesSubMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_sideMenu.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctb_logo)).BeginInit();
            this.pnl_estudiantesSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sideMenu
            // 
            this.pnl_sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pnl_sideMenu.Controls.Add(this.pnl_estudiantesSubMenu);
            this.pnl_sideMenu.Controls.Add(this.btn_estudiantes);
            this.pnl_sideMenu.Controls.Add(this.pnl_logo);
            this.pnl_sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_sideMenu.Name = "pnl_sideMenu";
            this.pnl_sideMenu.Size = new System.Drawing.Size(245, 761);
            this.pnl_sideMenu.TabIndex = 0;
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.Color.White;
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Location = new System.Drawing.Point(245, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(1019, 80);
            this.pn_top.TabIndex = 1;
            // 
            // pn_central
            // 
            this.pn_central.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_central.BackColor = System.Drawing.Color.White;
            this.pn_central.Location = new System.Drawing.Point(245, 86);
            this.pn_central.Name = "pn_central";
            this.pn_central.Size = new System.Drawing.Size(1019, 675);
            this.pn_central.TabIndex = 3;
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pnl_logo.Controls.Add(this.pctb_logo);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(245, 128);
            this.pnl_logo.TabIndex = 0;
            // 
            // pctb_logo
            // 
            this.pctb_logo.Image = global::Capa_Presentacion.Properties.Resources.logo;
            this.pctb_logo.Location = new System.Drawing.Point(12, 29);
            this.pctb_logo.Name = "pctb_logo";
            this.pctb_logo.Size = new System.Drawing.Size(218, 68);
            this.pctb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctb_logo.TabIndex = 0;
            this.pctb_logo.TabStop = false;
            // 
            // btn_estudiantes
            // 
            this.btn_estudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btn_estudiantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_estudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_estudiantes.FlatAppearance.BorderSize = 0;
            this.btn_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estudiantes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_estudiantes.ForeColor = System.Drawing.Color.White;
            this.btn_estudiantes.Image = global::Capa_Presentacion.Properties.Resources.student_button;
            this.btn_estudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estudiantes.Location = new System.Drawing.Point(0, 128);
            this.btn_estudiantes.Name = "btn_estudiantes";
            this.btn_estudiantes.Padding = new System.Windows.Forms.Padding(10, 0, 70, 0);
            this.btn_estudiantes.Size = new System.Drawing.Size(245, 45);
            this.btn_estudiantes.TabIndex = 1;
            this.btn_estudiantes.Text = "Estudiantes";
            this.btn_estudiantes.UseVisualStyleBackColor = false;
            // 
            // pnl_estudiantesSubMenu
            // 
            this.pnl_estudiantesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.pnl_estudiantesSubMenu.Controls.Add(this.button1);
            this.pnl_estudiantesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_estudiantesSubMenu.Location = new System.Drawing.Point(0, 173);
            this.pnl_estudiantesSubMenu.Name = "pnl_estudiantesSubMenu";
            this.pnl_estudiantesSubMenu.Size = new System.Drawing.Size(245, 236);
            this.pnl_estudiantesSubMenu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Capa_Presentacion.Properties.Resources.student_button;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 50, 0);
            this.button1.Size = new System.Drawing.Size(245, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Estudiantes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.pn_central);
            this.Controls.Add(this.pn_top);
            this.Controls.Add(this.pnl_sideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_window";
            this.Text = "Sistema Escolar";
            this.pnl_sideMenu.ResumeLayout(false);
            this.pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctb_logo)).EndInit();
            this.pnl_estudiantesSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_sideMenu;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.Panel pn_central;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.PictureBox pctb_logo;
        private System.Windows.Forms.Button btn_estudiantes;
        private System.Windows.Forms.Panel pnl_estudiantesSubMenu;
        private System.Windows.Forms.Button button1;
    }
}

