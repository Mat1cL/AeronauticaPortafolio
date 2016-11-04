namespace Aeronautica
{
    partial class VistaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAdministrador));
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlanVuelo = new System.Windows.Forms.Label();
            this.btnPlanReal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngresarPlanVuelo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlanVuelo
            // 
            this.btnPlanVuelo.AutoSize = true;
            this.btnPlanVuelo.Location = new System.Drawing.Point(203, 274);
            this.btnPlanVuelo.Name = "btnPlanVuelo";
            this.btnPlanVuelo.Size = new System.Drawing.Size(84, 13);
            this.btnPlanVuelo.TabIndex = 51;
            this.btnPlanVuelo.Text = "Ingresar Usuario";
            // 
            // btnPlanReal
            // 
            this.btnPlanReal.BackColor = System.Drawing.Color.SlateGray;
            this.btnPlanReal.Image = global::Aeronautica.Properties.Resources.EditUsuario;
            this.btnPlanReal.Location = new System.Drawing.Point(412, 159);
            this.btnPlanReal.Name = "btnPlanReal";
            this.btnPlanReal.Size = new System.Drawing.Size(128, 112);
            this.btnPlanReal.TabIndex = 47;
            this.btnPlanReal.UseVisualStyleBackColor = false;
            this.btnPlanReal.Click += new System.EventHandler(this.btnPlanReal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Mantenedor de Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Italic);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(273, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 40);
            this.label4.TabIndex = 48;
            this.label4.Text = "Gestion de Usuarios";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnIngresarPlanVuelo
            // 
            this.btnIngresarPlanVuelo.BackColor = System.Drawing.Color.SlateGray;
            this.btnIngresarPlanVuelo.Image = global::Aeronautica.Properties.Resources.AddUsuario;
            this.btnIngresarPlanVuelo.Location = new System.Drawing.Point(182, 159);
            this.btnIngresarPlanVuelo.Name = "btnIngresarPlanVuelo";
            this.btnIngresarPlanVuelo.Size = new System.Drawing.Size(128, 112);
            this.btnIngresarPlanVuelo.TabIndex = 46;
            this.btnIngresarPlanVuelo.UseVisualStyleBackColor = false;
            this.btnIngresarPlanVuelo.Click += new System.EventHandler(this.btnIngresarPlanVuelo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aeronautica.Properties.Resources.LogoAvion;
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // VistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.btnPlanVuelo);
            this.Controls.Add(this.btnPlanReal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIngresarPlanVuelo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VistaAdministrador_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label btnPlanVuelo;
        private System.Windows.Forms.Button btnPlanReal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIngresarPlanVuelo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}