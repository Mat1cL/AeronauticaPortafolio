namespace Aeronautica
{
    partial class ConsultarHorasVueloAeronave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarHorasVueloAeronave));
            this.dgvHorasAeronave = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cboMatricula = new System.Windows.Forms.ComboBox();
            this.lblhrsPiloto = new System.Windows.Forms.Label();
            this.lblSubtotalPiloto = new System.Windows.Forms.Label();
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
            this.dgvHorasAeronave.Location = new System.Drawing.Point(16, 141);
            this.dgvHorasAeronave.Name = "dgvHorasAeronave";
            this.dgvHorasAeronave.ReadOnly = true;
            this.dgvHorasAeronave.RowHeadersVisible = false;
            this.dgvHorasAeronave.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHorasAeronave.Size = new System.Drawing.Size(278, 153);
            this.dgvHorasAeronave.TabIndex = 0;
            this.dgvHorasAeronave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar Horas de Vuelo";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(13, 33);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matricula";
            this.lblMatricula.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(16, 338);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(219, 338);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cboMatricula
            // 
            this.cboMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatricula.FormattingEnabled = true;
            this.cboMatricula.Location = new System.Drawing.Point(66, 30);
            this.cboMatricula.Name = "cboMatricula";
            this.cboMatricula.Size = new System.Drawing.Size(228, 21);
            this.cboMatricula.TabIndex = 8;
            this.cboMatricula.SelectedIndexChanged += new System.EventHandler(this.cboPiloto_SelectedIndexChanged);
            // 
            // lblhrsPiloto
            // 
            this.lblhrsPiloto.AutoSize = true;
            this.lblhrsPiloto.Location = new System.Drawing.Point(13, 111);
            this.lblhrsPiloto.Name = "lblhrsPiloto";
            this.lblhrsPiloto.Size = new System.Drawing.Size(84, 13);
            this.lblhrsPiloto.TabIndex = 9;
            this.lblhrsPiloto.Text = "Horas Aeronave";
            // 
            // lblSubtotalPiloto
            // 
            this.lblSubtotalPiloto.AutoSize = true;
            this.lblSubtotalPiloto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalPiloto.Location = new System.Drawing.Point(12, 306);
            this.lblSubtotalPiloto.Name = "lblSubtotalPiloto";
            this.lblSubtotalPiloto.Size = new System.Drawing.Size(44, 20);
            this.lblSubtotalPiloto.TabIndex = 12;
            this.lblSubtotalPiloto.Text = "Total";
            // 
            // ConsultarHorasVueloAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(320, 398);
            this.Controls.Add(this.lblSubtotalPiloto);
            this.Controls.Add(this.lblhrsPiloto);
            this.Controls.Add(this.cboMatricula);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHorasAeronave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarHorasVueloAeronave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Horas de Vuelo de Aeronave";
            this.Load += new System.EventHandler(this.ConsultarHorasVueloAeronave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorasAeronave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorasAeronave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cboMatricula;
        private System.Windows.Forms.Label lblhrsPiloto;
        private System.Windows.Forms.Label lblSubtotalPiloto;
    }
}