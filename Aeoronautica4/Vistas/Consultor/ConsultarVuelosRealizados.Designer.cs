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
            this.label1 = new System.Windows.Forms.Label();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVuelos
            // 
            this.dtgVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVuelos.Location = new System.Drawing.Point(12, 164);
            this.dtgVuelos.Name = "dtgVuelos";
            this.dtgVuelos.Size = new System.Drawing.Size(1119, 287);
            this.dtgVuelos.TabIndex = 0;
            // 
            // btnVuelos
            // 
            this.btnVuelos.Location = new System.Drawing.Point(506, 478);
            this.btnVuelos.Name = "btnVuelos";
            this.btnVuelos.Size = new System.Drawing.Size(117, 41);
            this.btnVuelos.TabIndex = 1;
            this.btnVuelos.Text = "Consultar Vuelos";
            this.btnVuelos.UseVisualStyleBackColor = true;
            this.btnVuelos.Click += new System.EventHandler(this.btnVuelos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "VUELOS REALIZADOS";
            // 
            // dtDesde
            // 
            this.dtDesde.CustomFormat = "dd/MM/yyyy";
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDesde.Location = new System.Drawing.Point(446, 103);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(89, 20);
            this.dtDesde.TabIndex = 15;
            // 
            // dtHasta
            // 
            this.dtHasta.CustomFormat = "dd/MM/yyyy";
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHasta.Location = new System.Drawing.Point(585, 103);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(89, 20);
            this.dtHasta.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hasta";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(693, 103);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 19;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // ConsultarVuelosRealizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1143, 544);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVuelos);
            this.Controls.Add(this.dtgVuelos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarVuelosRealizados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuelos Realizados";
            this.Load += new System.EventHandler(this.ConsultarVuelosRealizados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVuelos;
        private System.Windows.Forms.Button btnVuelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrar;
    }
}