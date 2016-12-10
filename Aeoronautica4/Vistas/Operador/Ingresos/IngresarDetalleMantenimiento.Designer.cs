namespace Aeronautica.Vistas.Operador.Ingresos
{
    partial class IngresarDetalleMantenimiento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarDetalleMantenimiento));
            this.cboAeronave = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtIngreso = new System.Windows.Forms.DateTimePicker();
            this.cboMantenimiento2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTaller = new System.Windows.Forms.ComboBox();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtreciever = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtsender = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAeronave
            // 
            this.cboAeronave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAeronave.FormattingEnabled = true;
            this.cboAeronave.Location = new System.Drawing.Point(167, 89);
            this.cboAeronave.Name = "cboAeronave";
            this.cboAeronave.Size = new System.Drawing.Size(162, 21);
            this.cboAeronave.TabIndex = 1;
            this.cboAeronave.SelectedIndexChanged += new System.EventHandler(this.cboAeronave_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Aeronave";
            // 
            // dtIngreso
            // 
            this.dtIngreso.CustomFormat = "dd/MM/yyyy";
            this.dtIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIngreso.Location = new System.Drawing.Point(167, 151);
            this.dtIngreso.Name = "dtIngreso";
            this.dtIngreso.Size = new System.Drawing.Size(162, 20);
            this.dtIngreso.TabIndex = 3;
            this.dtIngreso.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // cboMantenimiento2
            // 
            this.cboMantenimiento2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMantenimiento2.FormattingEnabled = true;
            this.cboMantenimiento2.Location = new System.Drawing.Point(167, 120);
            this.cboMantenimiento2.Name = "cboMantenimiento2";
            this.cboMantenimiento2.Size = new System.Drawing.Size(162, 21);
            this.cboMantenimiento2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mantenimiento";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(254, 216);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(167, 216);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDetalle.TabIndex = 5;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Fecha Término";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Fecha Ingreso";
            // 
            // dtTermino
            // 
            this.dtTermino.CustomFormat = "dd/MM/yyyy";
            this.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTermino.Location = new System.Drawing.Point(167, 179);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(162, 20);
            this.dtTermino.TabIndex = 4;
            this.dtTermino.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Taller Mecánico";
            // 
            // cboTaller
            // 
            this.cboTaller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTaller.FormattingEnabled = true;
            this.cboTaller.Location = new System.Drawing.Point(167, 57);
            this.cboTaller.Name = "cboTaller";
            this.cboTaller.Size = new System.Drawing.Size(162, 21);
            this.cboTaller.TabIndex = 0;
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(74, 242);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(10, 20);
            this.txtbody.TabIndex = 60;
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(90, 242);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(11, 20);
            this.txtsubject.TabIndex = 59;
            // 
            // txtreciever
            // 
            this.txtreciever.Location = new System.Drawing.Point(56, 242);
            this.txtreciever.Name = "txtreciever";
            this.txtreciever.Size = new System.Drawing.Size(10, 20);
            this.txtreciever.TabIndex = 63;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(11, 242);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(10, 20);
            this.txtpass.TabIndex = 62;
            // 
            // txtsender
            // 
            this.txtsender.Location = new System.Drawing.Point(32, 242);
            this.txtsender.Name = "txtsender";
            this.txtsender.Size = new System.Drawing.Size(10, 20);
            this.txtsender.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(323, 25);
            this.label11.TabIndex = 64;
            this.label11.Text = "INGRESO DE MANTENIMIENTO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "label2";
            // 
            // IngresarDetalleMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(387, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtreciever);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtsender);
            this.Controls.Add(this.cboAeronave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtIngreso);
            this.Controls.Add(this.cboMantenimiento2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtTermino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTaller);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IngresarDetalleMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matenimiento";
            this.Load += new System.EventHandler(this.IngresarDetalleMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAeronave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtIngreso;
        private System.Windows.Forms.ComboBox cboMantenimiento2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTaller;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.TextBox txtreciever;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtsender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
    }
}