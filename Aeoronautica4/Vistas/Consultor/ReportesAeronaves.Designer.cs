namespace Aeronautica.Vistas.Consultor
{
    partial class ReportesAeronaves
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesAeronaves));
            this.dgvHorasAeronave = new System.Windows.Forms.DataGridView();
            this.lblSubtotalPiloto = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHelicoptero = new System.Windows.Forms.Button();
            this.btnAvion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUltimo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtFechaInspeccion = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombrePiloto = new System.Windows.Forms.Label();
            this.lblHorasDeVuelo = new System.Windows.Forms.Label();
            this.cboMatricula = new System.Windows.Forms.ComboBox();
            this.txtHorasDeVuelo = new System.Windows.Forms.TextBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasAeronave)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHorasAeronave
            // 
            this.dgvHorasAeronave.AllowUserToAddRows = false;
            this.dgvHorasAeronave.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorasAeronave.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorasAeronave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorasAeronave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorasAeronave.Location = new System.Drawing.Point(91, 557);
            this.dgvHorasAeronave.Name = "dgvHorasAeronave";
            this.dgvHorasAeronave.ReadOnly = true;
            this.dgvHorasAeronave.RowHeadersVisible = false;
            this.dgvHorasAeronave.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHorasAeronave.Size = new System.Drawing.Size(10, 13);
            this.dgvHorasAeronave.TabIndex = 72;
            // 
            // lblSubtotalPiloto
            // 
            this.lblSubtotalPiloto.AutoSize = true;
            this.lblSubtotalPiloto.Location = new System.Drawing.Point(50, 557);
            this.lblSubtotalPiloto.Name = "lblSubtotalPiloto";
            this.lblSubtotalPiloto.Size = new System.Drawing.Size(35, 13);
            this.lblSubtotalPiloto.TabIndex = 71;
            this.lblSubtotalPiloto.Text = "label1";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(296, 334);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(270, 20);
            this.txtTipo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Tipo de Aeronave Seleccionada";
            // 
            // btnHelicoptero
            // 
            this.btnHelicoptero.Location = new System.Drawing.Point(361, 120);
            this.btnHelicoptero.Name = "btnHelicoptero";
            this.btnHelicoptero.Size = new System.Drawing.Size(96, 41);
            this.btnHelicoptero.TabIndex = 2;
            this.btnHelicoptero.Text = "Helicóptero";
            this.btnHelicoptero.UseVisualStyleBackColor = true;
            this.btnHelicoptero.Click += new System.EventHandler(this.btnHelicoptero_Click);
            // 
            // btnAvion
            // 
            this.btnAvion.Location = new System.Drawing.Point(126, 120);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(96, 41);
            this.btnAvion.TabIndex = 1;
            this.btnAvion.Text = "Avión";
            this.btnAvion.UseVisualStyleBackColor = true;
            this.btnAvion.Click += new System.EventHandler(this.btnAvion_Click_1);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(238, 508);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Volver a Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Fecha Último Viaje Realizado";
            // 
            // txtUltimo
            // 
            this.txtUltimo.Location = new System.Drawing.Point(296, 279);
            this.txtUltimo.Name = "txtUltimo";
            this.txtUltimo.Size = new System.Drawing.Size(270, 20);
            this.txtUltimo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Días Restantes Para Próxima Fecha de Inspección:";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(296, 249);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(270, 20);
            this.txtDias.TabIndex = 6;
            // 
            // txtFechaInspeccion
            // 
            this.txtFechaInspeccion.Location = new System.Drawing.Point(296, 220);
            this.txtFechaInspeccion.Name = "txtFechaInspeccion";
            this.txtFechaInspeccion.Size = new System.Drawing.Size(270, 20);
            this.txtFechaInspeccion.TabIndex = 5;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(296, 187);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(270, 20);
            this.txtMatricula.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Fecha Inspección Anual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Matricula:";
            // 
            // lblNombrePiloto
            // 
            this.lblNombrePiloto.AutoSize = true;
            this.lblNombrePiloto.Location = new System.Drawing.Point(43, 71);
            this.lblNombrePiloto.Name = "lblNombrePiloto";
            this.lblNombrePiloto.Size = new System.Drawing.Size(53, 13);
            this.lblNombrePiloto.TabIndex = 56;
            this.lblNombrePiloto.Text = "Matricula:";
            // 
            // lblHorasDeVuelo
            // 
            this.lblHorasDeVuelo.AutoSize = true;
            this.lblHorasDeVuelo.Location = new System.Drawing.Point(43, 308);
            this.lblHorasDeVuelo.Name = "lblHorasDeVuelo";
            this.lblHorasDeVuelo.Size = new System.Drawing.Size(113, 13);
            this.lblHorasDeVuelo.TabIndex = 55;
            this.lblHorasDeVuelo.Text = "Total Horas de Vuelo: ";
            // 
            // cboMatricula
            // 
            this.cboMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatricula.FormattingEnabled = true;
            this.cboMatricula.Location = new System.Drawing.Point(161, 68);
            this.cboMatricula.Name = "cboMatricula";
            this.cboMatricula.Size = new System.Drawing.Size(270, 21);
            this.cboMatricula.TabIndex = 0;
            // 
            // txtHorasDeVuelo
            // 
            this.txtHorasDeVuelo.Location = new System.Drawing.Point(296, 308);
            this.txtHorasDeVuelo.Name = "txtHorasDeVuelo";
            this.txtHorasDeVuelo.Size = new System.Drawing.Size(270, 20);
            this.txtHorasDeVuelo.TabIndex = 8;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(207, 397);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(146, 83);
            this.btnGenerarReporte.TabIndex = 10;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(156, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 25);
            this.label7.TabIndex = 73;
            this.label7.Text = "REPORTE DE AERONAVE";
            // 
            // ReportesAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(613, 544);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvHorasAeronave);
            this.Controls.Add(this.lblSubtotalPiloto);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHelicoptero);
            this.Controls.Add(this.btnAvion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUltimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtFechaInspeccion);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombrePiloto);
            this.Controls.Add(this.lblHorasDeVuelo);
            this.Controls.Add(this.cboMatricula);
            this.Controls.Add(this.txtHorasDeVuelo);
            this.Controls.Add(this.btnGenerarReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportesAeronaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Aeronaves";
            this.Load += new System.EventHandler(this.ReportesAeronaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasAeronave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorasAeronave;
        private System.Windows.Forms.Label lblSubtotalPiloto;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHelicoptero;
        private System.Windows.Forms.Button btnAvion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUltimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtFechaInspeccion;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombrePiloto;
        private System.Windows.Forms.Label lblHorasDeVuelo;
        private System.Windows.Forms.ComboBox cboMatricula;
        private System.Windows.Forms.TextBox txtHorasDeVuelo;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Label label7;
    }
}