
namespace CapaPresentacion.Detalles
{
    partial class TutorDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorDetalle));
            this.Matricula_Title = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.Matricula_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // Matricula_Title
            // 
            this.Matricula_Title.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Matricula_Title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Matricula_Title.BackgroundImage")));
            this.Matricula_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Matricula_Title.BorderColor = System.Drawing.Color.Transparent;
            this.Matricula_Title.BorderRadius = 10;
            this.Matricula_Title.BorderThickness = 1;
            this.Matricula_Title.Controls.Add(this.bunifuLabel1);
            this.Matricula_Title.Location = new System.Drawing.Point(57, 31);
            this.Matricula_Title.Name = "Matricula_Title";
            this.Matricula_Title.ShowBorders = true;
            this.Matricula_Title.Size = new System.Drawing.Size(661, 50);
            this.Matricula_Title.TabIndex = 57;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuLabel1.Location = new System.Drawing.Point(18, 10);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(56, 30);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Datos";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TutorDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 561);
            this.Controls.Add(this.Matricula_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TutorDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del tutor";
            this.Matricula_Title.ResumeLayout(false);
            this.Matricula_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel Matricula_Title;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}