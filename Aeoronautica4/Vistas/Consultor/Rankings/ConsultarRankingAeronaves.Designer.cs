namespace Aeronautica.Vistas.Consultor
{
    partial class ConsultarRankingAeronaves
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarRankingAeronaves));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaPiloto = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvListaPiloto2 = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.dgvListaPiloto3 = new System.Windows.Forms.DataGridView();
            this.btnVolverFiltrar = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPiloto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPiloto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPiloto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ranking de Aeronaves";
            // 
            // dgvListaPiloto
            // 
            this.dgvListaPiloto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPiloto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPiloto.Location = new System.Drawing.Point(169, 88);
            this.dgvListaPiloto.Name = "dgvListaPiloto";
            this.dgvListaPiloto.RowHeadersVisible = false;
            this.dgvListaPiloto.Size = new System.Drawing.Size(450, 207);
            this.dgvListaPiloto.TabIndex = 13;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(433, 609);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(254, 609);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(96, 23);
            this.btnReporte.TabIndex = 17;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(128, 311);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "HORAS";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(544, 281);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // dgvListaPiloto2
            // 
            this.dgvListaPiloto2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPiloto2.Location = new System.Drawing.Point(544, 645);
            this.dgvListaPiloto2.Name = "dgvListaPiloto2";
            this.dgvListaPiloto2.Size = new System.Drawing.Size(54, 15);
            this.dgvListaPiloto2.TabIndex = 19;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(500, 49);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 33);
            this.btnFiltrar.TabIndex = 29;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Desde";
            // 
            // dtHasta
            // 
            this.dtHasta.CustomFormat = "dd/MM/yyyy";
            this.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHasta.Location = new System.Drawing.Point(384, 53);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(89, 20);
            this.dtHasta.TabIndex = 26;
            // 
            // dtDesde
            // 
            this.dtDesde.CustomFormat = "dd/MM/yyyy";
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDesde.Location = new System.Drawing.Point(245, 53);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(89, 20);
            this.dtDesde.TabIndex = 25;
            // 
            // dgvListaPiloto3
            // 
            this.dgvListaPiloto3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPiloto3.Location = new System.Drawing.Point(604, 643);
            this.dgvListaPiloto3.Name = "dgvListaPiloto3";
            this.dgvListaPiloto3.Size = new System.Drawing.Size(33, 17);
            this.dgvListaPiloto3.TabIndex = 31;
            // 
            // btnVolverFiltrar
            // 
            this.btnVolverFiltrar.Location = new System.Drawing.Point(500, 49);
            this.btnVolverFiltrar.Name = "btnVolverFiltrar";
            this.btnVolverFiltrar.Size = new System.Drawing.Size(85, 33);
            this.btnVolverFiltrar.TabIndex = 33;
            this.btnVolverFiltrar.Text = "Volver a Filtrar";
            this.btnVolverFiltrar.UseVisualStyleBackColor = true;
            this.btnVolverFiltrar.Click += new System.EventHandler(this.btnVolverFiltrar_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(128, 311);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "HORAS.";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(544, 281);
            this.chart2.TabIndex = 34;
            this.chart2.Text = "chart2";
            // 
            // ConsultarRankingAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(774, 639);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnVolverFiltrar);
            this.Controls.Add(this.dgvListaPiloto3);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.dgvListaPiloto2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaPiloto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarRankingAeronaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Horas de Vuelo de Aeronave";
            this.Load += new System.EventHandler(this.ConsultarRankingAeronaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPiloto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPiloto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPiloto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaPiloto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgvListaPiloto2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.DataGridView dgvListaPiloto3;
        private System.Windows.Forms.Button btnVolverFiltrar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}