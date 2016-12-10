namespace Aeronautica
{
    partial class ConsultarHorasVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarHorasVuelo));
            this.dgvHorasPiloto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLicencia = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cboPiloto = new System.Windows.Forms.ComboBox();
            this.lblhrsPiloto = new System.Windows.Forms.Label();
            this.lblSubtotalPiloto = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasPiloto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHorasPiloto
            // 
            this.dgvHorasPiloto.AllowUserToAddRows = false;
            this.dgvHorasPiloto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorasPiloto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorasPiloto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorasPiloto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorasPiloto.Location = new System.Drawing.Point(80, 155);
            this.dgvHorasPiloto.Name = "dgvHorasPiloto";
            this.dgvHorasPiloto.ReadOnly = true;
            this.dgvHorasPiloto.RowHeadersVisible = false;
            this.dgvHorasPiloto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHorasPiloto.Size = new System.Drawing.Size(278, 153);
            this.dgvHorasPiloto.TabIndex = 2;
            this.dgvHorasPiloto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar Horas de Vuelo de Piloto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Piloto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Licencia";
            // 
            // cboLicencia
            // 
            this.cboLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLicencia.FormattingEnabled = true;
            this.cboLicencia.Location = new System.Drawing.Point(100, 87);
            this.cboLicencia.Name = "cboLicencia";
            this.cboLicencia.Size = new System.Drawing.Size(279, 21);
            this.cboLicencia.TabIndex = 1;
            this.cboLicencia.SelectedIndexChanged += new System.EventHandler(this.cboLicencia_SelectedIndexChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(70, 369);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(165, 370);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cboPiloto
            // 
            this.cboPiloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPiloto.FormattingEnabled = true;
            this.cboPiloto.Location = new System.Drawing.Point(100, 49);
            this.cboPiloto.Name = "cboPiloto";
            this.cboPiloto.Size = new System.Drawing.Size(279, 21);
            this.cboPiloto.TabIndex = 0;
            this.cboPiloto.SelectedIndexChanged += new System.EventHandler(this.cboPiloto_SelectedIndexChanged);
            // 
            // lblhrsPiloto
            // 
            this.lblhrsPiloto.AutoSize = true;
            this.lblhrsPiloto.Location = new System.Drawing.Point(81, 139);
            this.lblhrsPiloto.Name = "lblhrsPiloto";
            this.lblhrsPiloto.Size = new System.Drawing.Size(64, 13);
            this.lblhrsPiloto.TabIndex = 9;
            this.lblhrsPiloto.Text = "Horas Piloto";
            // 
            // lblSubtotalPiloto
            // 
            this.lblSubtotalPiloto.AutoSize = true;
            this.lblSubtotalPiloto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalPiloto.Location = new System.Drawing.Point(66, 331);
            this.lblSubtotalPiloto.Name = "lblSubtotalPiloto";
            this.lblSubtotalPiloto.Size = new System.Drawing.Size(44, 20);
            this.lblSubtotalPiloto.TabIndex = 12;
            this.lblSubtotalPiloto.Text = "Total";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(261, 369);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(97, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // ConsultarHorasVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(427, 404);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblSubtotalPiloto);
            this.Controls.Add(this.lblhrsPiloto);
            this.Controls.Add(this.cboPiloto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cboLicencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHorasPiloto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarHorasVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Horas de Vuelo de Piloto";
            this.Load += new System.EventHandler(this.VistaOperadorConsultarHorasVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasPiloto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorasPiloto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLicencia;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cboPiloto;
        private System.Windows.Forms.Label lblhrsPiloto;
        private System.Windows.Forms.Label lblSubtotalPiloto;
        private System.Windows.Forms.Button btnGenerar;
    }
}