namespace Aeronautica
{
    partial class IngresarPlanVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarPlanVuelo));
            this.label1 = new System.Windows.Forms.Label();
            this.cboPiloto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboOrigenPais = new System.Windows.Forms.ComboBox();
            this.cboOrigenRegion = new System.Windows.Forms.ComboBox();
            this.cboOrigenProvincia = new System.Windows.Forms.ComboBox();
            this.cboOrigenComuna = new System.Windows.Forms.ComboBox();
            this.cboDestinoPais = new System.Windows.Forms.ComboBox();
            this.cboDestinoRegion = new System.Windows.Forms.ComboBox();
            this.cboDestinoProvincia = new System.Windows.Forms.ComboBox();
            this.cboDestinoComuna = new System.Windows.Forms.ComboBox();
            this.dtSalida = new System.Windows.Forms.DateTimePicker();
            this.dtLlegada = new System.Windows.Forms.DateTimePicker();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMision = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCondicion = new System.Windows.Forms.ComboBox();
            this.dtHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTipoLicencia = new System.Windows.Forms.ComboBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.cboTipoLicenciaCopiloto = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboCopiloto = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboTipoAeronave = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboAeronave = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pbRojo = new System.Windows.Forms.PictureBox();
            this.pbVerde = new System.Windows.Forms.PictureBox();
            this.cboDisponible = new System.Windows.Forms.ComboBox();
            this.SPilotoVerde = new System.Windows.Forms.PictureBox();
            this.SPilotoRojo = new System.Windows.Forms.PictureBox();
            this.SCoPilotoRojo = new System.Windows.Forms.PictureBox();
            this.SCoPilotoVerde = new System.Windows.Forms.PictureBox();
            this.cboPilotoDisponible = new System.Windows.Forms.ComboBox();
            this.cboCoPilotoDisponible = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPilotoVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPilotoRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCoPilotoRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCoPilotoVerde)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Piloto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboPiloto
            // 
            this.cboPiloto.AccessibleName = "";
            this.cboPiloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPiloto.FormattingEnabled = true;
            this.cboPiloto.Location = new System.Drawing.Point(221, 56);
            this.cboPiloto.Name = "cboPiloto";
            this.cboPiloto.Size = new System.Drawing.Size(274, 21);
            this.cboPiloto.TabIndex = 0;
            this.cboPiloto.Tag = "";
            this.cboPiloto.SelectedIndexChanged += new System.EventHandler(this.cboPiloto_SelectedIndexChanged);
            this.cboPiloto.TextChanged += new System.EventHandler(this.cboPiloto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Salida (Estimada)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Llegada (Estimada)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Origen";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Destino";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cboOrigenPais
            // 
            this.cboOrigenPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigenPais.FormattingEnabled = true;
            this.cboOrigenPais.Location = new System.Drawing.Point(221, 266);
            this.cboOrigenPais.Name = "cboOrigenPais";
            this.cboOrigenPais.Size = new System.Drawing.Size(143, 21);
            this.cboOrigenPais.TabIndex = 10;
            this.cboOrigenPais.SelectedIndexChanged += new System.EventHandler(this.cboOrigenPais_SelectedIndexChanged);
            // 
            // cboOrigenRegion
            // 
            this.cboOrigenRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigenRegion.FormattingEnabled = true;
            this.cboOrigenRegion.Location = new System.Drawing.Point(370, 266);
            this.cboOrigenRegion.Name = "cboOrigenRegion";
            this.cboOrigenRegion.Size = new System.Drawing.Size(198, 21);
            this.cboOrigenRegion.TabIndex = 11;
            this.cboOrigenRegion.SelectedIndexChanged += new System.EventHandler(this.cboOrigenRegion_SelectedIndexChanged);
            // 
            // cboOrigenProvincia
            // 
            this.cboOrigenProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigenProvincia.FormattingEnabled = true;
            this.cboOrigenProvincia.Location = new System.Drawing.Point(575, 266);
            this.cboOrigenProvincia.Name = "cboOrigenProvincia";
            this.cboOrigenProvincia.Size = new System.Drawing.Size(164, 21);
            this.cboOrigenProvincia.TabIndex = 12;
            this.cboOrigenProvincia.SelectedIndexChanged += new System.EventHandler(this.cboOrigenProvincia_SelectedIndexChanged);
            // 
            // cboOrigenComuna
            // 
            this.cboOrigenComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigenComuna.FormattingEnabled = true;
            this.cboOrigenComuna.Location = new System.Drawing.Point(745, 266);
            this.cboOrigenComuna.Name = "cboOrigenComuna";
            this.cboOrigenComuna.Size = new System.Drawing.Size(143, 21);
            this.cboOrigenComuna.TabIndex = 13;
            this.cboOrigenComuna.SelectedIndexChanged += new System.EventHandler(this.cboOrigenComuna_SelectedIndexChanged);
            // 
            // cboDestinoPais
            // 
            this.cboDestinoPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestinoPais.FormattingEnabled = true;
            this.cboDestinoPais.Location = new System.Drawing.Point(221, 297);
            this.cboDestinoPais.Name = "cboDestinoPais";
            this.cboDestinoPais.Size = new System.Drawing.Size(143, 21);
            this.cboDestinoPais.TabIndex = 15;
            this.cboDestinoPais.SelectedIndexChanged += new System.EventHandler(this.cboDestinoPais_SelectedIndexChanged);
            // 
            // cboDestinoRegion
            // 
            this.cboDestinoRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestinoRegion.FormattingEnabled = true;
            this.cboDestinoRegion.Location = new System.Drawing.Point(370, 297);
            this.cboDestinoRegion.Name = "cboDestinoRegion";
            this.cboDestinoRegion.Size = new System.Drawing.Size(198, 21);
            this.cboDestinoRegion.TabIndex = 16;
            this.cboDestinoRegion.SelectedIndexChanged += new System.EventHandler(this.cboDestinoRegion_SelectedIndexChanged);
            // 
            // cboDestinoProvincia
            // 
            this.cboDestinoProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestinoProvincia.FormattingEnabled = true;
            this.cboDestinoProvincia.Location = new System.Drawing.Point(575, 297);
            this.cboDestinoProvincia.Name = "cboDestinoProvincia";
            this.cboDestinoProvincia.Size = new System.Drawing.Size(164, 21);
            this.cboDestinoProvincia.TabIndex = 17;
            this.cboDestinoProvincia.SelectedIndexChanged += new System.EventHandler(this.cboDestinoProvincia_SelectedIndexChanged);
            // 
            // cboDestinoComuna
            // 
            this.cboDestinoComuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestinoComuna.FormattingEnabled = true;
            this.cboDestinoComuna.Location = new System.Drawing.Point(745, 297);
            this.cboDestinoComuna.Name = "cboDestinoComuna";
            this.cboDestinoComuna.Size = new System.Drawing.Size(143, 21);
            this.cboDestinoComuna.TabIndex = 18;
            this.cboDestinoComuna.SelectedIndexChanged += new System.EventHandler(this.cboDestinoComuna_SelectedIndexChanged);
            // 
            // dtSalida
            // 
            this.dtSalida.CustomFormat = "dd/MM/yyyy";
            this.dtSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSalida.Location = new System.Drawing.Point(221, 188);
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.Size = new System.Drawing.Size(200, 20);
            this.dtSalida.TabIndex = 6;
            // 
            // dtLlegada
            // 
            this.dtLlegada.CustomFormat = "dd/MM/yyyy";
            this.dtLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLlegada.Location = new System.Drawing.Point(221, 227);
            this.dtLlegada.Name = "dtLlegada";
            this.dtLlegada.Size = new System.Drawing.Size(200, 20);
            this.dtLlegada.TabIndex = 8;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(380, 677);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(266, 677);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Misión";
            // 
            // cbMision
            // 
            this.cbMision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMision.FormattingEnabled = true;
            this.cbMision.Location = new System.Drawing.Point(221, 471);
            this.cbMision.Name = "cbMision";
            this.cbMision.Size = new System.Drawing.Size(162, 21);
            this.cbMision.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(221, 505);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(320, 131);
            this.txtDescripcion.TabIndex = 22;
            this.txtDescripcion.Text = "";
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Hora Salida (Estimada)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Hora Llegada (Estimada)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Condición";
            // 
            // cboCondicion
            // 
            this.cboCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondicion.FormattingEnabled = true;
            this.cboCondicion.Location = new System.Drawing.Point(221, 432);
            this.cboCondicion.Name = "cboCondicion";
            this.cboCondicion.Size = new System.Drawing.Size(162, 21);
            this.cboCondicion.TabIndex = 20;
            // 
            // dtHoraSalida
            // 
            this.dtHoraSalida.CustomFormat = "HH:mm";
            this.dtHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHoraSalida.Location = new System.Drawing.Point(575, 185);
            this.dtHoraSalida.Name = "dtHoraSalida";
            this.dtHoraSalida.ShowUpDown = true;
            this.dtHoraSalida.Size = new System.Drawing.Size(87, 20);
            this.dtHoraSalida.TabIndex = 7;
            this.dtHoraSalida.Value = new System.DateTime(2016, 10, 8, 0, 0, 0, 0);
            this.dtHoraSalida.ValueChanged += new System.EventHandler(this.dtHoraSalida_ValueChanged);
            // 
            // dtHoraLlegada
            // 
            this.dtHoraLlegada.CustomFormat = "HH:mm";
            this.dtHoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHoraLlegada.Location = new System.Drawing.Point(575, 221);
            this.dtHoraLlegada.Name = "dtHoraLlegada";
            this.dtHoraLlegada.ShowUpDown = true;
            this.dtHoraLlegada.Size = new System.Drawing.Size(87, 20);
            this.dtHoraLlegada.TabIndex = 9;
            this.dtHoraLlegada.Value = new System.DateTime(2016, 10, 3, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(572, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Tipo de Licencia";
            // 
            // cboTipoLicencia
            // 
            this.cboTipoLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoLicencia.FormattingEnabled = true;
            this.cboTipoLicencia.Location = new System.Drawing.Point(664, 53);
            this.cboTipoLicencia.Name = "cboTipoLicencia";
            this.cboTipoLicencia.Size = new System.Drawing.Size(261, 21);
            this.cboTipoLicencia.TabIndex = 1;
            // 
            // cboOrigen
            // 
            this.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(895, 265);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(143, 21);
            this.cboOrigen.TabIndex = 14;
            // 
            // cboDestino
            // 
            this.cboDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(895, 297);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(143, 21);
            this.cboDestino.TabIndex = 19;
            // 
            // cboTipoLicenciaCopiloto
            // 
            this.cboTipoLicenciaCopiloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoLicenciaCopiloto.FormattingEnabled = true;
            this.cboTipoLicenciaCopiloto.Location = new System.Drawing.Point(664, 101);
            this.cboTipoLicenciaCopiloto.Name = "cboTipoLicenciaCopiloto";
            this.cboTipoLicenciaCopiloto.Size = new System.Drawing.Size(261, 21);
            this.cboTipoLicenciaCopiloto.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(572, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Tipo de Licencia";
            // 
            // cboCopiloto
            // 
            this.cboCopiloto.AccessibleName = "";
            this.cboCopiloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCopiloto.FormattingEnabled = true;
            this.cboCopiloto.Location = new System.Drawing.Point(221, 104);
            this.cboCopiloto.Name = "cboCopiloto";
            this.cboCopiloto.Size = new System.Drawing.Size(274, 21);
            this.cboCopiloto.TabIndex = 2;
            this.cboCopiloto.Tag = "";
            this.cboCopiloto.SelectedIndexChanged += new System.EventHandler(this.cboCopiloto_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Copiloto";
            // 
            // cboTipoAeronave
            // 
            this.cboTipoAeronave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAeronave.FormattingEnabled = true;
            this.cboTipoAeronave.Location = new System.Drawing.Point(221, 150);
            this.cboTipoAeronave.Name = "cboTipoAeronave";
            this.cboTipoAeronave.Size = new System.Drawing.Size(185, 21);
            this.cboTipoAeronave.TabIndex = 4;
            this.cboTipoAeronave.SelectedIndexChanged += new System.EventHandler(this.cboTipoAeronave_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Aeronave";
            // 
            // cboAeronave
            // 
            this.cboAeronave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAeronave.FormattingEnabled = true;
            this.cboAeronave.Location = new System.Drawing.Point(412, 150);
            this.cboAeronave.Name = "cboAeronave";
            this.cboAeronave.Size = new System.Drawing.Size(162, 21);
            this.cboAeronave.TabIndex = 5;
            this.cboAeronave.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboAeronave_DrawItem);
            this.cboAeronave.SelectedIndexChanged += new System.EventHandler(this.cboAeronave_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(668, 188);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(180, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "(Horas : Minutos) (Formato 24 Horas)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(668, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "(Horas : Minutos) (Formato 24 Horas)";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(493, 677);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(221, 332);
            this.txtRuta.MaxLength = 300;
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(320, 85);
            this.txtRuta.TabIndex = 63;
            this.txtRuta.Text = "";
            this.txtRuta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuta_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(71, 335);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Ruta";
            // 
            // pbRojo
            // 
            this.pbRojo.Image = global::Aeronautica.Properties.Resources.rojo;
            this.pbRojo.InitialImage = null;
            this.pbRojo.Location = new System.Drawing.Point(580, 144);
            this.pbRojo.Name = "pbRojo";
            this.pbRojo.Size = new System.Drawing.Size(28, 35);
            this.pbRojo.TabIndex = 65;
            this.pbRojo.TabStop = false;
            this.pbRojo.Visible = false;
            // 
            // pbVerde
            // 
            this.pbVerde.Image = global::Aeronautica.Properties.Resources.verde;
            this.pbVerde.Location = new System.Drawing.Point(580, 144);
            this.pbVerde.Name = "pbVerde";
            this.pbVerde.Size = new System.Drawing.Size(28, 35);
            this.pbVerde.TabIndex = 66;
            this.pbVerde.TabStop = false;
            this.pbVerde.Visible = false;
            this.pbVerde.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboDisponible
            // 
            this.cboDisponible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisponible.FormattingEnabled = true;
            this.cboDisponible.Location = new System.Drawing.Point(580, 150);
            this.cboDisponible.Name = "cboDisponible";
            this.cboDisponible.Size = new System.Drawing.Size(28, 21);
            this.cboDisponible.TabIndex = 67;
            // 
            // SPilotoVerde
            // 
            this.SPilotoVerde.Image = global::Aeronautica.Properties.Resources.verde;
            this.SPilotoVerde.Location = new System.Drawing.Point(501, 53);
            this.SPilotoVerde.Name = "SPilotoVerde";
            this.SPilotoVerde.Size = new System.Drawing.Size(28, 35);
            this.SPilotoVerde.TabIndex = 68;
            this.SPilotoVerde.TabStop = false;
            this.SPilotoVerde.Visible = false;
            // 
            // SPilotoRojo
            // 
            this.SPilotoRojo.Image = global::Aeronautica.Properties.Resources.rojo;
            this.SPilotoRojo.InitialImage = null;
            this.SPilotoRojo.Location = new System.Drawing.Point(501, 53);
            this.SPilotoRojo.Name = "SPilotoRojo";
            this.SPilotoRojo.Size = new System.Drawing.Size(28, 35);
            this.SPilotoRojo.TabIndex = 69;
            this.SPilotoRojo.TabStop = false;
            this.SPilotoRojo.Visible = false;
            // 
            // SCoPilotoRojo
            // 
            this.SCoPilotoRojo.Image = global::Aeronautica.Properties.Resources.rojo;
            this.SCoPilotoRojo.InitialImage = null;
            this.SCoPilotoRojo.Location = new System.Drawing.Point(501, 94);
            this.SCoPilotoRojo.Name = "SCoPilotoRojo";
            this.SCoPilotoRojo.Size = new System.Drawing.Size(28, 35);
            this.SCoPilotoRojo.TabIndex = 70;
            this.SCoPilotoRojo.TabStop = false;
            this.SCoPilotoRojo.Visible = false;
            // 
            // SCoPilotoVerde
            // 
            this.SCoPilotoVerde.Image = global::Aeronautica.Properties.Resources.verde;
            this.SCoPilotoVerde.Location = new System.Drawing.Point(501, 94);
            this.SCoPilotoVerde.Name = "SCoPilotoVerde";
            this.SCoPilotoVerde.Size = new System.Drawing.Size(28, 35);
            this.SCoPilotoVerde.TabIndex = 71;
            this.SCoPilotoVerde.TabStop = false;
            this.SCoPilotoVerde.Visible = false;
            // 
            // cboPilotoDisponible
            // 
            this.cboPilotoDisponible.AccessibleName = "";
            this.cboPilotoDisponible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPilotoDisponible.FormattingEnabled = true;
            this.cboPilotoDisponible.Location = new System.Drawing.Point(501, 56);
            this.cboPilotoDisponible.Name = "cboPilotoDisponible";
            this.cboPilotoDisponible.Size = new System.Drawing.Size(40, 21);
            this.cboPilotoDisponible.TabIndex = 72;
            this.cboPilotoDisponible.Tag = "";
            // 
            // cboCoPilotoDisponible
            // 
            this.cboCoPilotoDisponible.AccessibleName = "";
            this.cboCoPilotoDisponible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCoPilotoDisponible.FormattingEnabled = true;
            this.cboCoPilotoDisponible.Location = new System.Drawing.Point(500, 104);
            this.cboCoPilotoDisponible.Name = "cboCoPilotoDisponible";
            this.cboCoPilotoDisponible.Size = new System.Drawing.Size(41, 21);
            this.cboCoPilotoDisponible.TabIndex = 73;
            this.cboCoPilotoDisponible.Tag = "";
            // 
            // IngresarPlanVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1096, 700);
            this.Controls.Add(this.cboCoPilotoDisponible);
            this.Controls.Add(this.cboPilotoDisponible);
            this.Controls.Add(this.SCoPilotoVerde);
            this.Controls.Add(this.SCoPilotoRojo);
            this.Controls.Add(this.SPilotoRojo);
            this.Controls.Add(this.SPilotoVerde);
            this.Controls.Add(this.cboDisponible);
            this.Controls.Add(this.pbVerde);
            this.Controls.Add(this.pbRojo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cboAeronave);
            this.Controls.Add(this.cboTipoAeronave);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboTipoLicenciaCopiloto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboCopiloto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.cboOrigen);
            this.Controls.Add(this.cboTipoLicencia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtHoraLlegada);
            this.Controls.Add(this.dtHoraSalida);
            this.Controls.Add(this.cboCondicion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMision);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtLlegada);
            this.Controls.Add(this.dtSalida);
            this.Controls.Add(this.cboDestinoComuna);
            this.Controls.Add(this.cboDestinoProvincia);
            this.Controls.Add(this.cboDestinoRegion);
            this.Controls.Add(this.cboDestinoPais);
            this.Controls.Add(this.cboOrigenComuna);
            this.Controls.Add(this.cboOrigenProvincia);
            this.Controls.Add(this.cboOrigenRegion);
            this.Controls.Add(this.cboOrigenPais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPiloto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IngresarPlanVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Plan de Vuelo";
            this.Load += new System.EventHandler(this.VistaOperadorIngresarVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPilotoVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPilotoRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCoPilotoRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCoPilotoVerde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPiloto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboOrigenPais;
        private System.Windows.Forms.ComboBox cboOrigenRegion;
        private System.Windows.Forms.ComboBox cboOrigenProvincia;
        private System.Windows.Forms.ComboBox cboOrigenComuna;
        private System.Windows.Forms.ComboBox cboDestinoPais;
        private System.Windows.Forms.ComboBox cboDestinoRegion;
        private System.Windows.Forms.ComboBox cboDestinoProvincia;
        private System.Windows.Forms.ComboBox cboDestinoComuna;
        private System.Windows.Forms.DateTimePicker dtSalida;
        private System.Windows.Forms.DateTimePicker dtLlegada;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCondicion;
        private System.Windows.Forms.DateTimePicker dtHoraSalida;
        private System.Windows.Forms.DateTimePicker dtHoraLlegada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTipoLicencia;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.ComboBox cboTipoLicenciaCopiloto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboCopiloto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboTipoAeronave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboAeronave;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox txtRuta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pbRojo;
        private System.Windows.Forms.PictureBox pbVerde;
        private System.Windows.Forms.ComboBox cboDisponible;
        private System.Windows.Forms.PictureBox SPilotoVerde;
        private System.Windows.Forms.PictureBox SPilotoRojo;
        private System.Windows.Forms.PictureBox SCoPilotoRojo;
        private System.Windows.Forms.PictureBox SCoPilotoVerde;
        private System.Windows.Forms.ComboBox cboPilotoDisponible;
        private System.Windows.Forms.ComboBox cboCoPilotoDisponible;
    }
}