namespace Aeronautica.Vistas.Piloto
{
    partial class ConsultarHoraDeVueloPiloto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarHoraDeVueloPiloto));
            this.lblSubtotalPiloto = new System.Windows.Forms.Label();
            this.lblhrsPiloto = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboLicencia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHorasPiloto = new System.Windows.Forms.DataGridView();
            this.txtPiloto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasPiloto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubtotalPiloto
            // 
            this.lblSubtotalPiloto.AutoSize = true;
            this.lblSubtotalPiloto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalPiloto.Location = new System.Drawing.Point(25, 306);
            this.lblSubtotalPiloto.Name = "lblSubtotalPiloto";
            this.lblSubtotalPiloto.Size = new System.Drawing.Size(44, 20);
            this.lblSubtotalPiloto.TabIndex = 22;
            this.lblSubtotalPiloto.Text = "Total";
            // 
            // lblhrsPiloto
            // 
            this.lblhrsPiloto.AutoSize = true;
            this.lblhrsPiloto.Location = new System.Drawing.Point(26, 111);
            this.lblhrsPiloto.Name = "lblhrsPiloto";
            this.lblhrsPiloto.Size = new System.Drawing.Size(64, 13);
            this.lblhrsPiloto.TabIndex = 21;
            this.lblhrsPiloto.Text = "Horas Piloto";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(232, 338);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(29, 338);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboLicencia
            // 
            this.cboLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLicencia.FormattingEnabled = true;
            this.cboLicencia.Location = new System.Drawing.Point(79, 68);
            this.cboLicencia.Name = "cboLicencia";
            this.cboLicencia.Size = new System.Drawing.Size(228, 21);
            this.cboLicencia.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Licencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Piloto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Consultar Horas de Vuelo";
            // 
            // dgvHorasPiloto
            // 
            this.dgvHorasPiloto.AllowUserToAddRows = false;
            this.dgvHorasPiloto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorasPiloto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorasPiloto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorasPiloto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorasPiloto.Location = new System.Drawing.Point(29, 141);
            this.dgvHorasPiloto.Name = "dgvHorasPiloto";
            this.dgvHorasPiloto.ReadOnly = true;
            this.dgvHorasPiloto.RowHeadersVisible = false;
            this.dgvHorasPiloto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHorasPiloto.Size = new System.Drawing.Size(278, 153);
            this.dgvHorasPiloto.TabIndex = 13;
            // 
            // txtPiloto
            // 
            this.txtPiloto.Location = new System.Drawing.Point(79, 33);
            this.txtPiloto.Name = "txtPiloto";
            this.txtPiloto.Size = new System.Drawing.Size(228, 20);
            this.txtPiloto.TabIndex = 23;
            // 
            // ConsultarHoraDeVueloPiloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(332, 371);
            this.Controls.Add(this.txtPiloto);
            this.Controls.Add(this.lblSubtotalPiloto);
            this.Controls.Add(this.lblhrsPiloto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cboLicencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHorasPiloto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarHoraDeVueloPiloto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Horas de Vuelo de Piloto";
            this.Load += new System.EventHandler(this.ConsultarHoraDeVueloPiloto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasPiloto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtotalPiloto;
        private System.Windows.Forms.Label lblhrsPiloto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboLicencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHorasPiloto;
        private System.Windows.Forms.TextBox txtPiloto;
    }
}