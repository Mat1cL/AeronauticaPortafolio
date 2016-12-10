namespace Aeronautica.Vistas.Operador
{
    partial class BitacoraPiloto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitacoraPiloto));
            this.button1 = new System.Windows.Forms.Button();
            this.txtHorasDeVuelo = new System.Windows.Forms.TextBox();
            this.cboPiloto = new System.Windows.Forms.ComboBox();
            this.dgvHorasPiloto = new System.Windows.Forms.DataGridView();
            this.lblSubtotalPiloto = new System.Windows.Forms.Label();
            this.cboLicencia = new System.Windows.Forms.ComboBox();
            this.lblHorasDeVuelo = new System.Windows.Forms.Label();
            this.lblNombrePiloto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUltimo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAvion = new System.Windows.Forms.Button();
            this.btnHelicoptero = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasPiloto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 83);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHorasDeVuelo
            // 
            this.txtHorasDeVuelo.Location = new System.Drawing.Point(208, 322);
            this.txtHorasDeVuelo.Name = "txtHorasDeVuelo";
            this.txtHorasDeVuelo.Size = new System.Drawing.Size(270, 20);
            this.txtHorasDeVuelo.TabIndex = 9;
            // 
            // cboPiloto
            // 
            this.cboPiloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPiloto.FormattingEnabled = true;
            this.cboPiloto.Location = new System.Drawing.Point(181, 59);
            this.cboPiloto.Name = "cboPiloto";
            this.cboPiloto.Size = new System.Drawing.Size(270, 21);
            this.cboPiloto.TabIndex = 0;
            this.cboPiloto.SelectedIndexChanged += new System.EventHandler(this.cboPiloto_SelectedIndexChanged);
            // 
            // dgvHorasPiloto
            // 
            this.dgvHorasPiloto.AllowUserToAddRows = false;
            this.dgvHorasPiloto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorasPiloto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorasPiloto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorasPiloto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorasPiloto.Location = new System.Drawing.Point(58, 551);
            this.dgvHorasPiloto.Name = "dgvHorasPiloto";
            this.dgvHorasPiloto.ReadOnly = true;
            this.dgvHorasPiloto.RowHeadersVisible = false;
            this.dgvHorasPiloto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHorasPiloto.Size = new System.Drawing.Size(10, 10);
            this.dgvHorasPiloto.TabIndex = 4;
            // 
            // lblSubtotalPiloto
            // 
            this.lblSubtotalPiloto.AutoSize = true;
            this.lblSubtotalPiloto.Location = new System.Drawing.Point(17, 548);
            this.lblSubtotalPiloto.Name = "lblSubtotalPiloto";
            this.lblSubtotalPiloto.Size = new System.Drawing.Size(35, 13);
            this.lblSubtotalPiloto.TabIndex = 5;
            this.lblSubtotalPiloto.Text = "label1";
            // 
            // cboLicencia
            // 
            this.cboLicencia.FormattingEnabled = true;
            this.cboLicencia.Location = new System.Drawing.Point(74, 545);
            this.cboLicencia.Name = "cboLicencia";
            this.cboLicencia.Size = new System.Drawing.Size(10, 21);
            this.cboLicencia.TabIndex = 6;
            // 
            // lblHorasDeVuelo
            // 
            this.lblHorasDeVuelo.AutoSize = true;
            this.lblHorasDeVuelo.Location = new System.Drawing.Point(38, 325);
            this.lblHorasDeVuelo.Name = "lblHorasDeVuelo";
            this.lblHorasDeVuelo.Size = new System.Drawing.Size(113, 13);
            this.lblHorasDeVuelo.TabIndex = 7;
            this.lblHorasDeVuelo.Text = "Total Horas de Vuelo: ";
            this.lblHorasDeVuelo.Click += new System.EventHandler(this.lblHorasDeVuelo_Click);
            // 
            // lblNombrePiloto
            // 
            this.lblNombrePiloto.AutoSize = true;
            this.lblNombrePiloto.Location = new System.Drawing.Point(25, 62);
            this.lblNombrePiloto.Name = "lblNombrePiloto";
            this.lblNombrePiloto.Size = new System.Drawing.Size(75, 13);
            this.lblNombrePiloto.TabIndex = 8;
            this.lblNombrePiloto.Text = "Buscar Piloto: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "RUT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(208, 175);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(270, 20);
            this.txtRut.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(208, 208);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(270, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Vencimiento Ficha Médica;";
            // 
            // txtMedica
            // 
            this.txtMedica.Location = new System.Drawing.Point(208, 237);
            this.txtMedica.Name = "txtMedica";
            this.txtMedica.Size = new System.Drawing.Size(270, 20);
            this.txtMedica.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha Último Viaje Realizado";
            // 
            // txtUltimo
            // 
            this.txtUltimo.Location = new System.Drawing.Point(208, 267);
            this.txtUltimo.Name = "txtUltimo";
            this.txtUltimo.Size = new System.Drawing.Size(270, 20);
            this.txtUltimo.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(471, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Volver a Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Numero de Licencia Utilizado";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(208, 295);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(270, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(271, 510);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAvion
            // 
            this.btnAvion.Location = new System.Drawing.Point(147, 112);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(96, 41);
            this.btnAvion.TabIndex = 1;
            this.btnAvion.Text = "Avión";
            this.btnAvion.UseVisualStyleBackColor = true;
            this.btnAvion.Click += new System.EventHandler(this.btnAvion_Click);
            // 
            // btnHelicoptero
            // 
            this.btnHelicoptero.Location = new System.Drawing.Point(382, 112);
            this.btnHelicoptero.Name = "btnHelicoptero";
            this.btnHelicoptero.Size = new System.Drawing.Size(96, 41);
            this.btnHelicoptero.TabIndex = 2;
            this.btnHelicoptero.Text = "Helicóptero";
            this.btnHelicoptero.UseVisualStyleBackColor = true;
            this.btnHelicoptero.Click += new System.EventHandler(this.btnHelicoptero_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tipo de Aeronave Seleccionada";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(208, 348);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(270, 20);
            this.txtTipo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "REPORTE DE PILOTO";
            // 
            // BitacoraPiloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(591, 544);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHelicoptero);
            this.Controls.Add(this.btnAvion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUltimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedica);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombrePiloto);
            this.Controls.Add(this.lblHorasDeVuelo);
            this.Controls.Add(this.cboLicencia);
            this.Controls.Add(this.lblSubtotalPiloto);
            this.Controls.Add(this.dgvHorasPiloto);
            this.Controls.Add(this.cboPiloto);
            this.Controls.Add(this.txtHorasDeVuelo);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BitacoraPiloto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Pilotos";
            this.Load += new System.EventHandler(this.PruebaPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasPiloto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHorasDeVuelo;
        private System.Windows.Forms.ComboBox cboPiloto;
        private System.Windows.Forms.DataGridView dgvHorasPiloto;
        private System.Windows.Forms.Label lblSubtotalPiloto;
        private System.Windows.Forms.ComboBox cboLicencia;
        private System.Windows.Forms.Label lblHorasDeVuelo;
        private System.Windows.Forms.Label lblNombrePiloto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUltimo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAvion;
        private System.Windows.Forms.Button btnHelicoptero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label7;
    }
}