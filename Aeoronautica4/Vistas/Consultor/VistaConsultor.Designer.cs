namespace Aeronautica
{
    partial class VistaConsultor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaConsultor));
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsultaHoras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReporteAeronave = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnConsultarVuelos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Consultar Horas de Vuelo de Aeronave";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Image = global::Aeronautica.Properties.Resources.ConsultarHorasDeVueloAeronave;
            this.button1.Location = new System.Drawing.Point(467, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 112);
            this.button1.TabIndex = 71;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Consultar Horas de Vuelo de Piloto";
            // 
            // btnConsultaHoras
            // 
            this.btnConsultaHoras.BackColor = System.Drawing.Color.SlateGray;
            this.btnConsultaHoras.Image = global::Aeronautica.Properties.Resources.ConsultarHoradeVueloPiloto;
            this.btnConsultaHoras.Location = new System.Drawing.Point(50, 139);
            this.btnConsultaHoras.Name = "btnConsultaHoras";
            this.btnConsultaHoras.Size = new System.Drawing.Size(128, 112);
            this.btnConsultaHoras.TabIndex = 69;
            this.btnConsultaHoras.UseVisualStyleBackColor = false;
            this.btnConsultaHoras.Click += new System.EventHandler(this.btnConsultaHoras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aeronautica.Properties.Resources.LogoAvion;
            this.pictureBox1.Location = new System.Drawing.Point(33, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Italic);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(248, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 40);
            this.label4.TabIndex = 73;
            this.label4.Text = "Consultas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.Image = global::Aeronautica.Properties.Resources.pilo;
            this.button3.Location = new System.Drawing.Point(50, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 112);
            this.button3.TabIndex = 75;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Reporte Piloto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Reporte Aeronave";
            // 
            // btnReporteAeronave
            // 
            this.btnReporteAeronave.BackColor = System.Drawing.Color.SlateGray;
            this.btnReporteAeronave.Image = global::Aeronautica.Properties.Resources.Aeronavexx22;
            this.btnReporteAeronave.Location = new System.Drawing.Point(467, 301);
            this.btnReporteAeronave.Name = "btnReporteAeronave";
            this.btnReporteAeronave.Size = new System.Drawing.Size(128, 112);
            this.btnReporteAeronave.TabIndex = 77;
            this.btnReporteAeronave.UseVisualStyleBackColor = false;
            this.btnReporteAeronave.Click += new System.EventHandler(this.btnReporteAeronave_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(252, 336);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 13);
            this.label16.TabIndex = 80;
            this.label16.Text = "Consultar Vuelos Realizados";
            // 
            // btnConsultarVuelos
            // 
            this.btnConsultarVuelos.BackColor = System.Drawing.Color.SlateGray;
            this.btnConsultarVuelos.Image = global::Aeronautica.Properties.Resources.search_bx;
            this.btnConsultarVuelos.Location = new System.Drawing.Point(255, 221);
            this.btnConsultarVuelos.Name = "btnConsultarVuelos";
            this.btnConsultarVuelos.Size = new System.Drawing.Size(128, 112);
            this.btnConsultarVuelos.TabIndex = 79;
            this.btnConsultarVuelos.UseVisualStyleBackColor = false;
            this.btnConsultarVuelos.Click += new System.EventHandler(this.btnConsultarVuelos_Click);
            // 
            // VistaConsultor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 470);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnConsultarVuelos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnReporteAeronave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConsultaHoras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaConsultor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaConsultor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultaHoras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReporteAeronave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnConsultarVuelos;
    }
}