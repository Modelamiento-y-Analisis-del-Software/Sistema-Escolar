
using System;
using System.Windows.Forms;

namespace Mantenedor
{
    partial class MantenedorCurso
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAgregarCurso;
        private Button btnCancelarCurso;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dgvCurso;
        private Button button1;
        private Button button2;
        private TextBox textBox7;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBoxDatosCurso;
        private EventHandler button1_Click;
        private EventHandler label2_Click;
        private System.Windows.Forms.DataGridView dgvCurso;

        public MantenedorCurso(DataGridView dgvCurso) => this.dgvCurso = dgvCurso;

        private EventHandler Mantenedor_Load;
        private DataGridViewCellEventHandler dataGridView1_CellContentClick;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.btnCancelarCurso = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxDatosCurso = new System.Windows.Forms.GroupBox();
            ((this.dgvCurso) as System.ComponentModel.ISupportInitialize).BeginInit();
            this.groupBoxDatosCurso.SuspendLayout();
            this.SuspendLayout();
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarCurso.Location = new System.Drawing.Point(44, 389);
            this.btnAgregarCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCurso.Name = "btnAgregarAlumno";
            this.btnAgregarCurso.Size = new System.Drawing.Size(79, 29);
            this.btnAgregarCurso.TabIndex = 0;
            this.btnAgregarCurso.Text = "AGREGAR";
            this.btnAgregarCurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarCurso.UseVisualStyleBackColor = false;
            this.btnAgregarCurso.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarCurso
            // 
            this.btnCancelarCurso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarCurso.Location = new System.Drawing.Point(659, 389);
            this.btnCancelarCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarCurso.Name = "btnCancelarCurso";
            this.btnCancelarCurso.Size = new System.Drawing.Size(79, 29);
            this.btnCancelarCurso.TabIndex = 1;
            this.btnCancelarCurso.Text = "Cancelar";
            this.btnCancelarCurso.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 111);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // this.textBox2.Location = new System.Drawing.Point(97, 150);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 231);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 190);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 270);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(209, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(97, 310);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(209, 20);
            this.textBox6.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Salon de Clase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(30, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre de curso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Docente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(30, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Código curso";
            // 
            // dgvCurso
            // 
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(344, 23);
            this.dgvCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.RowHeadersWidth = 51;
            this.dgvCurso.RowTemplate.Height = 24;
            this.dgvCurso.Size = new System.Drawing.Size(394, 290);
            this.dgvCurso.TabIndex = 14;
            this.dgvCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(258, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Modificar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(455, 389);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "Eliminar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(421, 336);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(318, 20);
            this.textBox7.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(344, 334);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 22);
            this.button3.TabIndex = 20;
            this.button3.Text = "Buscar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Location = new System.Drawing.Point(35, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(68, 76);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxDatosAlumno
            // 
            this.groupBoxDatosCurso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxDatosCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxDatosCurso.Controls.Add(this.groupBox1);
            this.groupBoxDatosCurso.Controls.Add(this.label5);
            this.groupBoxDatosCurso.Controls.Add(this.label4);
            this.groupBoxDatosCurso.Controls.Add(this.label3);
            this.groupBoxDatosCurso.Controls.Add(this.label2);
            this.groupBoxDatosCurso.Controls.Add(this.label1);
            this.groupBoxDatosCurso.Controls.Add(this.textBox6);
            this.groupBoxDatosCurso.Controls.Add(this.textBox5);
            this.groupBoxDatosCurso.Controls.Add(this.textBox4);
            this.groupBoxDatosCurso.Controls.Add(this.textBox3);
            this.groupBoxDatosCurso.Controls.Add(this.textBox2);
            this.groupBoxDatosCurso.Controls.Add(this.textBox1);
            this.groupBoxDatosCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxDatosCurso.Location = new System.Drawing.Point(9, 10);
            this.groupBoxDatosCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDatosCurso.Name = "groupBoxDatosCurso";
            this.groupBoxDatosCurso.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDatosCurso.Size = new System.Drawing.Size(320, 363);
            this.groupBoxDatosCurso.TabIndex = 21;
            this.groupBoxDatosCurso.TabStop = false;
            this.groupBoxDatosCurso.Text = "REGISTRAR DATOS DEL CURSO";
            // 
            // CrudAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(758, 428);
            this.Controls.Add(this.groupBoxDatosCurso);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add((Control)this.dgvCurso);
            this.Controls.Add(this.btnCancelarCurso);
            this.Controls.Add(this.btnAgregarCurso);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MantenedorClase";
            this.Text = "MantenedorClase";
            this.Load += new System.EventHandler(this.Mantenedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.groupBoxDatosCurso.ResumeLayout(false);
            this.groupBoxDatosCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}