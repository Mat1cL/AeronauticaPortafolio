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
            this.btnPlanVuelo = new System.Windows.Forms.Label();
            this.btnPlanReal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngresarPlanVuelo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlanVuelo
            // 
            this.btnPlanVuelo.AutoSize = true;
            this.btnPlanVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanVuelo.Location = new System.Drawing.Point(186, 290);
            this.btnPlanVuelo.Name = "btnPlanVuelo";
            this.btnPlanVuelo.Size = new System.Drawing.Size(123, 16);
            this.btnPlanVuelo.TabIndex = 51;
            this.btnPlanVuelo.Text = "Ingresar Usuario";
            // 
            // btnPlanReal
            // 
            this.btnPlanReal.BackColor = System.Drawing.Color.SlateGray;
            this.btnPlanReal.Image = global::Aeronautica.Properties.Resources.EditUsuario;
            this.btnPlanReal.Location = new System.Drawing.Point(411, 175);
            this.btnPlanReal.Name = "btnPlanReal";
            this.btnPlanReal.Size = new System.Drawing.Size(128, 112);
            this.btnPlanReal.TabIndex = 1;
            this.btnPlanReal.UseVisualStyleBackColor = false;
            this.btnPlanReal.Click += new System.EventHandler(this.btnPlanReal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Mantenedor de Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Italic);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(237, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 40);
            this.label4.TabIndex = 48;
            this.label4.Text = "Gestión de Usuarios";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnIngresarPlanVuelo
            // 
            this.btnIngresarPlanVuelo.BackColor = System.Drawing.Color.SlateGray;
            this.btnIngresarPlanVuelo.Image = global::Aeronautica.Properties.Resources.AddUsuario;
            this.btnIngresarPlanVuelo.Location = new System.Drawing.Point(181, 175);
            this.btnIngresarPlanVuelo.Name = "btnIngresarPlanVuelo";
            this.btnIngresarPlanVuelo.Size = new System.Drawing.Size(128, 112);
            this.btnIngresarPlanVuelo.TabIndex = 0;
            this.btnIngresarPlanVuelo.UseVisualStyleBackColor = false;
            this.btnIngresarPlanVuelo.Click += new System.EventHandler(this.btnIngresarPlanVuelo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Aeronautica.Properties.Resources.LogoEmpresa;
            this.pictureBox3.Location = new System.Drawing.Point(561, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 97;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aeronautica.Properties.Resources.logoescuadrilla;
            this.pictureBox2.Location = new System.Drawing.Point(21, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            // 
            // VistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPlanVuelo);
            this.Controls.Add(this.btnPlanReal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIngresarPlanVuelo);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VistaAdministrador_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnPlanVuelo;
        private System.Windows.Forms.Button btnPlanReal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIngresarPlanVuelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}