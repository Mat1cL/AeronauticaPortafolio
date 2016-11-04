namespace Aeronautica
{
    partial class VistaPiloto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPiloto));
            this.btnPlanVuelo = new System.Windows.Forms.Label();
            this.btnConsultarVuelos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIngresarPlanVuelo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlanVuelo
            // 
            this.btnPlanVuelo.AutoSize = true;
            this.btnPlanVuelo.Location = new System.Drawing.Point(74, 236);
            this.btnPlanVuelo.Name = "btnPlanVuelo";
            this.btnPlanVuelo.Size = new System.Drawing.Size(160, 13);
            this.btnPlanVuelo.TabIndex = 57;
            this.btnPlanVuelo.Text = "Ingresar Plan de Vuelo Estimado";
            // 
            // btnConsultarVuelos
            // 
            this.btnConsultarVuelos.BackColor = System.Drawing.Color.SlateGray;
            this.btnConsultarVuelos.Image = global::Aeronautica.Properties.Resources.ConsultarHoradeVueloPiloto;
            this.btnConsultarVuelos.Location = new System.Drawing.Point(325, 121);
            this.btnConsultarVuelos.Name = "btnConsultarVuelos";
            this.btnConsultarVuelos.Size = new System.Drawing.Size(128, 112);
            this.btnConsultarVuelos.TabIndex = 54;
            this.btnConsultarVuelos.UseVisualStyleBackColor = false;
            this.btnConsultarVuelos.Click += new System.EventHandler(this.btnConsultarVuelos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Consultar Horas de Vuelo";
            // 
            // btnIngresarPlanVuelo
            // 
            this.btnIngresarPlanVuelo.BackColor = System.Drawing.Color.SlateGray;
            this.btnIngresarPlanVuelo.Image = global::Aeronautica.Properties.Resources.paper1X1;
            this.btnIngresarPlanVuelo.Location = new System.Drawing.Point(95, 121);
            this.btnIngresarPlanVuelo.Name = "btnIngresarPlanVuelo";
            this.btnIngresarPlanVuelo.Size = new System.Drawing.Size(128, 112);
            this.btnIngresarPlanVuelo.TabIndex = 53;
            this.btnIngresarPlanVuelo.UseVisualStyleBackColor = false;
            this.btnIngresarPlanVuelo.Click += new System.EventHandler(this.btnIngresarPlanVuelo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 19.75F, System.Drawing.FontStyle.Italic);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(50, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 33);
            this.label4.TabIndex = 55;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(227, 77);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 58;
            // 
            // VistaPiloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 397);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnPlanVuelo);
            this.Controls.Add(this.btnConsultarVuelos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIngresarPlanVuelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaPiloto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista de Piloto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VistaPiloto_FormClosing);
            this.Load += new System.EventHandler(this.VistaPiloto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnPlanVuelo;
        private System.Windows.Forms.Button btnConsultarVuelos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIngresarPlanVuelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtUsuario;

    }
}