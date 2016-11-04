namespace Aeronautica.Vistas.Consultor
{
    partial class ConsultarVuelosRealizados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVuelosRealizados));
            this.dtgVuelos = new System.Windows.Forms.DataGridView();
            this.btnVuelos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVuelos
            // 
            this.dtgVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVuelos.Location = new System.Drawing.Point(12, 31);
            this.dtgVuelos.Name = "dtgVuelos";
            this.dtgVuelos.Size = new System.Drawing.Size(1119, 287);
            this.dtgVuelos.TabIndex = 0;
            // 
            // btnVuelos
            // 
            this.btnVuelos.Location = new System.Drawing.Point(506, 345);
            this.btnVuelos.Name = "btnVuelos";
            this.btnVuelos.Size = new System.Drawing.Size(117, 41);
            this.btnVuelos.TabIndex = 1;
            this.btnVuelos.Text = "Consultar Vuelos";
            this.btnVuelos.UseVisualStyleBackColor = true;
            this.btnVuelos.Click += new System.EventHandler(this.btnVuelos_Click);
            // 
            // ConsultarVuelosRealizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 410);
            this.Controls.Add(this.btnVuelos);
            this.Controls.Add(this.dtgVuelos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarVuelosRealizados";
            this.Text = "ConsultarVuelosRealizados";
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVuelos;
        private System.Windows.Forms.Button btnVuelos;
    }
}