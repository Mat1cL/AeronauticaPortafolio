
namespace Aeronautica
{
    partial class VistaOperador
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaOperador));
            this.tabAeronaves = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnComponentes = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnFabricante = new System.Windows.Forms.Button();
            this.btnAeronave = new System.Windows.Forms.Button();
            this.btnMantenedorAeronave = new System.Windows.Forms.Button();
            this.tabPilotos = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMantenedorMedicamento = new System.Windows.Forms.Button();
            this.btnMantenedorPiloto = new System.Windows.Forms.Button();
            this.btnMantenedorLicencias = new System.Windows.Forms.Button();
            this.btnIngresarLicencia = new System.Windows.Forms.Button();
            this.btnIngresarPiloto = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnIngresarMedicamento = new System.Windows.Forms.Button();
            this.tabControlOperador = new System.Windows.Forms.TabControl();
            this.tabVuelos = new System.Windows.Forms.TabPage();
            this.btnPlanVuelo = new System.Windows.Forms.Label();
            this.btnPlanReal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIngresarPlanVuelo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabConsultas = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.btnConsultarVuelos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReporteAeronave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsultaHoras = new System.Windows.Forms.Button();
            this.tabAeronaves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPilotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabControlOperador.SuspendLayout();
            this.tabVuelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAeronaves
            // 
            this.tabAeronaves.Controls.Add(this.pictureBox2);
            this.tabAeronaves.Controls.Add(this.label20);
            this.tabAeronaves.Controls.Add(this.label14);
            this.tabAeronaves.Controls.Add(this.label15);
            this.tabAeronaves.Controls.Add(this.label17);
            this.tabAeronaves.Controls.Add(this.btnComponentes);
            this.tabAeronaves.Controls.Add(this.label18);
            this.tabAeronaves.Controls.Add(this.btnFabricante);
            this.tabAeronaves.Controls.Add(this.btnAeronave);
            this.tabAeronaves.Controls.Add(this.btnMantenedorAeronave);
            this.tabAeronaves.Location = new System.Drawing.Point(54, 4);
            this.tabAeronaves.Name = "tabAeronaves";
            this.tabAeronaves.Padding = new System.Windows.Forms.Padding(3);
            this.tabAeronaves.Size = new System.Drawing.Size(781, 519);
            this.tabAeronaves.TabIndex = 1;
            this.tabAeronaves.Text = "Gestioin Aeronave";
            this.tabAeronaves.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aeronautica.Properties.Resources.LogoAvion;
            this.pictureBox2.Location = new System.Drawing.Point(50, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Italic);
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(265, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(247, 40);
            this.label20.TabIndex = 63;
            this.label20.Text = "Gestion del Vuelo";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(442, 429);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 16);
            this.label14.TabIndex = 62;
            this.label14.Text = "Mantenimiento";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(176, 429);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 16);
            this.label15.TabIndex = 60;
            this.label15.Text = "Mantenedor Aeronave";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(189, 249);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 16);
            this.label17.TabIndex = 58;
            this.label17.Text = "Ingresar Aeronave";
            // 
            // btnComponentes
            // 
            this.btnComponentes.BackColor = System.Drawing.Color.SlateGray;
            this.btnComponentes.Image = global::Aeronautica.Properties.Resources.Componente;
            this.btnComponentes.Location = new System.Drawing.Point(422, 134);
            this.btnComponentes.Name = "btnComponentes";
            this.btnComponentes.Size = new System.Drawing.Size(128, 112);
            this.btnComponentes.TabIndex = 1;
            this.btnComponentes.UseVisualStyleBackColor = false;
            this.btnComponentes.Click += new System.EventHandler(this.btnComponentes_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(404, 249);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 16);
            this.label18.TabIndex = 56;
            this.label18.Text = "Ingresar Componentes";
            // 
            // btnFabricante
            // 
            this.btnFabricante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFabricante.BackColor = System.Drawing.Color.SlateGray;
            this.btnFabricante.Image = global::Aeronautica.Properties.Resources.DetalleMantenimiento2;
            this.btnFabricante.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFabricante.Location = new System.Drawing.Point(422, 314);
            this.btnFabricante.Name = "btnFabricante";
            this.btnFabricante.Size = new System.Drawing.Size(128, 112);
            this.btnFabricante.TabIndex = 5;
            this.btnFabricante.UseVisualStyleBackColor = false;
            this.btnFabricante.Click += new System.EventHandler(this.btnFabricante_Click);
            // 
            // btnAeronave
            // 
            this.btnAeronave.BackColor = System.Drawing.Color.SlateGray;
            this.btnAeronave.Image = global::Aeronautica.Properties.Resources.AddAeronave;
            this.btnAeronave.Location = new System.Drawing.Point(192, 134);
            this.btnAeronave.Name = "btnAeronave";
            this.btnAeronave.Size = new System.Drawing.Size(128, 112);
            this.btnAeronave.TabIndex = 0;
            this.btnAeronave.UseVisualStyleBackColor = false;
            this.btnAeronave.Click += new System.EventHandler(this.btnAeronave_Click);
            // 
            // btnMantenedorAeronave
            // 
            this.btnMantenedorAeronave.BackColor = System.Drawing.Color.SlateGray;
            this.btnMantenedorAeronave.Image = global::Aeronautica.Properties.Resources.EditAeronave;
            this.btnMantenedorAeronave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMantenedorAeronave.Location = new System.Drawing.Point(192, 314);
            this.btnMantenedorAeronave.Name = "btnMantenedorAeronave";
            this.btnMantenedorAeronave.Size = new System.Drawing.Size(128, 112);
            this.btnMantenedorAeronave.TabIndex = 3;
            this.btnMantenedorAeronave.UseVisualStyleBackColor = false;
            this.btnMantenedorAeronave.Click += new System.EventHandler(this.btnMantenedorAeronave_Click);
            // 
            // tabPilotos
            // 
            this.tabPilotos.Controls.Add(this.label11);
            this.tabPilotos.Controls.Add(this.label12);
            this.tabPilotos.Controls.Add(this.label13);
            this.tabPilotos.Controls.Add(this.label3);
            this.tabPilotos.Controls.Add(this.label2);
            this.tabPilotos.Controls.Add(this.label1);
            this.tabPilotos.Controls.Add(this.lblTitulo);
            this.tabPilotos.Controls.Add(this.btnMantenedorMedicamento);
            this.tabPilotos.Controls.Add(this.btnMantenedorPiloto);
            this.tabPilotos.Controls.Add(this.btnMantenedorLicencias);
            this.tabPilotos.Controls.Add(this.btnIngresarLicencia);
            this.tabPilotos.Controls.Add(this.btnIngresarPiloto);
            this.tabPilotos.Controls.Add(this.pbLogo);
            this.tabPilotos.Controls.Add(this.btnIngresarMedicamento);
            this.tabPilotos.Location = new System.Drawing.Point(54, 4);
            this.tabPilotos.Name = "tabPilotos";
            this.tabPilotos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPilotos.Size = new System.Drawing.Size(781, 519);
            this.tabPilotos.TabIndex = 0;
            this.tabPilotos.Text = "Gestion Piloto";
            this.tabPilotos.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 429);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Manenedor Piloto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "Mantenedor Licencias";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(534, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Mantenedor de Ficha Médica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ingresar Piloto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ingresar Licencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ingresar Ficha Médica";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Italic);
            this.lblTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitulo.Location = new System.Drawing.Point(265, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 40);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Gestion del Piloto";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMantenedorMedicamento
            // 
            this.btnMantenedorMedicamento.BackColor = System.Drawing.Color.SlateGray;
            this.btnMantenedorMedicamento.Image = global::Aeronautica.Properties.Resources.medicina2;
            this.btnMantenedorMedicamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMantenedorMedicamento.Location = new System.Drawing.Point(569, 314);
            this.btnMantenedorMedicamento.Name = "btnMantenedorMedicamento";
            this.btnMantenedorMedicamento.Size = new System.Drawing.Size(128, 112);
            this.btnMantenedorMedicamento.TabIndex = 5;
            this.btnMantenedorMedicamento.UseVisualStyleBackColor = false;
            this.btnMantenedorMedicamento.Click += new System.EventHandler(this.btnMantenedorMedicamento_Click);
            // 
            // btnMantenedorPiloto
            // 
            this.btnMantenedorPiloto.BackColor = System.Drawing.Color.SlateGray;
            this.btnMantenedorPiloto.Image = global::Aeronautica.Properties.Resources.PilotoMantenedor;
            this.btnMantenedorPiloto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMantenedorPiloto.Location = new System.Drawing.Point(88, 314);
            this.btnMantenedorPiloto.Name = "btnMantenedorPiloto";
            this.btnMantenedorPiloto.Size = new System.Drawing.Size(128, 112);
            this.btnMantenedorPiloto.TabIndex = 3;
            this.btnMantenedorPiloto.UseVisualStyleBackColor = false;
            this.btnMantenedorPiloto.Click += new System.EventHandler(this.btnMantenedorPiloto_Click);
            // 
            // btnMantenedorLicencias
            // 
            this.btnMantenedorLicencias.BackColor = System.Drawing.Color.SlateGray;
            this.btnMantenedorLicencias.Image = global::Aeronautica.Properties.Resources.licencia2x;
            this.btnMantenedorLicencias.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMantenedorLicencias.Location = new System.Drawing.Point(318, 314);
            this.btnMantenedorLicencias.Name = "btnMantenedorLicencias";
            this.btnMantenedorLicencias.Size = new System.Drawing.Size(128, 112);
            this.btnMantenedorLicencias.TabIndex = 4;
            this.btnMantenedorLicencias.UseVisualStyleBackColor = false;
            this.btnMantenedorLicencias.Click += new System.EventHandler(this.btnMantenedorLicencias_Click);
            // 
            // btnIngresarLicencia
            // 
            this.btnIngresarLicencia.BackColor = System.Drawing.Color.SlateGray;
            this.btnIngresarLicencia.Image = global::Aeronautica.Properties.Resources.licencia;
            this.btnIngresarLicencia.Location = new System.Drawing.Point(318, 140);
            this.btnIngresarLicencia.Name = "btnIngresarLicencia";
            this.btnIngresarLicencia.Size = new System.Drawing.Size(128, 112);
            this.btnIngresarLicencia.TabIndex = 1;
            this.btnIngresarLicencia.UseVisualStyleBackColor = false;
            this.btnIngresarLicencia.Click += new System.EventHandler(this.btnIngresarLicencia_Click);
            // 
            // btnIngresarPiloto
            // 
            this.btnIngresarPiloto.BackColor = System.Drawing.Color.SlateGray;
            this.btnIngresarPiloto.Image = global::Aeronautica.Properties.Resources.Occupations_Pilot_Male_Light_icon;
            this.btnIngresarPiloto.Location = new System.Drawing.Point(88, 140);
            this.btnIngresarPiloto.Name = "btnIngresarPiloto";
            this.btnIngresarPiloto.Size = new System.Drawing.Size(128, 112);
            this.btnIngresarPiloto.TabIndex = 0;
            this.btnIngresarPiloto.UseVisualStyleBackColor = false;
            this.btnIngresarPiloto.Click += new System.EventHandler(this.btnIngresarPiloto_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Aeronautica.Properties.Resources.LogoAvion;
            this.pbLogo.Location = new System.Drawing.Point(50, 25);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(156, 72);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 32;
            this.pbLogo.TabStop = false;
            // 
            // btnIngresarMedicamento
            // 
            this.btnIngresarMedicamento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresarMedicamento.BackColor = System.Drawing.Color.SlateGray;
            this.btnIngresarMedicamento.Image = global::Aeronautica.Properties.Resources.medicina;
            this.btnIngresarMedicamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIngresarMedicamento.Location = new System.Drawing.Point(569, 140);
            this.btnIngresarMedicamento.Name = "btnIngresarMedicamento";
            this.btnIngresarMedicamento.Size = new System.Drawing.Size(128, 112);
            this.btnIngresarMedicamento.TabIndex = 2;
            this.btnIngresarMedicamento.UseVisualStyleBackColor = false;
            this.btnIngresarMedicamento.Click += new System.EventHandler(this.btnIngresarMedicamento_Click);
            // 
            // tabControlOperador
            // 
            this.tabControlOperador.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlOperador.Controls.Add(this.tabVuelos);
            this.tabControlOperador.Controls.Add(this.tabPilotos);
            this.tabControlOperador.Controls.Add(this.tabAeronaves);
            this.tabControlOperador.Controls.Add(this.tabConsultas);
            this.tabControlOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.tabControlOperador.HotTrack = true;
            this.tabControlOperador.ItemSize = new System.Drawing.Size(130, 50);
            this.tabControlOperador.Location = new System.Drawing.Point(0, -2);
            this.tabControlOperador.Multiline = true;
            this.tabControlOperador.Name = "tabControlOperador";
            this.tabControlOperador.Padding = new System.Drawing.Point(6, 6);
            this.tabControlOperador.SelectedIndex = 0;
            this.tabControlOperador.Size = new System.Drawing.Size(839, 527);
            this.tabControlOperador.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlOperador.TabIndex = 0;
            // 
            // tabVuelos
            // 
            this.tabVuelos.Controls.Add(this.btnPlanVuelo);
            this.tabVuelos.Controls.Add(this.btnPlanReal);
            this.tabVuelos.Controls.Add(this.label6);
            this.tabVuelos.Controls.Add(this.btnIngresarPlanVuelo);
            this.tabVuelos.Controls.Add(this.pictureBox1);
            this.tabVuelos.Controls.Add(this.label4);
            this.tabVuelos.Location = new System.Drawing.Point(54, 4);
            this.tabVuelos.Name = "tabVuelos";
            this.tabVuelos.Size = new System.Drawing.Size(781, 519);
            this.tabVuelos.TabIndex = 2;
            this.tabVuelos.Text = "Gestion Vuelo";
            this.tabVuelos.UseVisualStyleBackColor = true;
            this.tabVuelos.Click += new System.EventHandler(this.tabVuelos_Click);
            this.tabVuelos.Leave += new System.EventHandler(this.tabVuelos_Leave);
            // 
            // btnPlanVuelo
            // 
            this.btnPlanVuelo.AutoSize = true;
            this.btnPlanVuelo.Location = new System.Drawing.Point(91, 277);
            this.btnPlanVuelo.Name = "btnPlanVuelo";
            this.btnPlanVuelo.Size = new System.Drawing.Size(235, 16);
            this.btnPlanVuelo.TabIndex = 45;
            this.btnPlanVuelo.Text = "Ingresar Plan de Vuelo Estimado";
            // 
            // btnPlanReal
            // 
            this.btnPlanReal.BackColor = System.Drawing.Color.SlateGray;
            this.btnPlanReal.Image = global::Aeronautica.Properties.Resources.paper2X;
            this.btnPlanReal.Location = new System.Drawing.Point(440, 162);
            this.btnPlanReal.Name = "btnPlanReal";
            this.btnPlanReal.Size = new System.Drawing.Size(128, 112);
            this.btnPlanReal.TabIndex = 1;
            this.btnPlanReal.UseVisualStyleBackColor = false;
            this.btnPlanReal.Click += new System.EventHandler(this.btnPlanReal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ingresar Plan de Vuelo Real";
            // 
            // btnIngresarPlanVuelo
            // 
            this.btnIngresarPlanVuelo.BackColor = System.Drawing.Color.SlateGray;
            this.btnIngresarPlanVuelo.Image = global::Aeronautica.Properties.Resources.paper1X;
            this.btnIngresarPlanVuelo.Location = new System.Drawing.Point(142, 162);
            this.btnIngresarPlanVuelo.Name = "btnIngresarPlanVuelo";
            this.btnIngresarPlanVuelo.Size = new System.Drawing.Size(128, 112);
            this.btnIngresarPlanVuelo.TabIndex = 0;
            this.btnIngresarPlanVuelo.UseVisualStyleBackColor = false;
            this.btnIngresarPlanVuelo.Click += new System.EventHandler(this.btnIngresarPlanVuelo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aeronautica.Properties.Resources.LogoAvion;
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Italic);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(265, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 40);
            this.label4.TabIndex = 33;
            this.label4.Text = "Gestion del Vuelo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabConsultas
            // 
            this.tabConsultas.Controls.Add(this.label16);
            this.tabConsultas.Controls.Add(this.btnConsultarVuelos);
            this.tabConsultas.Controls.Add(this.label10);
            this.tabConsultas.Controls.Add(this.btnReporteAeronave);
            this.tabConsultas.Controls.Add(this.label9);
            this.tabConsultas.Controls.Add(this.pictureBox3);
            this.tabConsultas.Controls.Add(this.label7);
            this.tabConsultas.Controls.Add(this.button3);
            this.tabConsultas.Controls.Add(this.label8);
            this.tabConsultas.Controls.Add(this.label5);
            this.tabConsultas.Controls.Add(this.button1);
            this.tabConsultas.Controls.Add(this.btnConsultaHoras);
            this.tabConsultas.Location = new System.Drawing.Point(54, 4);
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.Size = new System.Drawing.Size(781, 519);
            this.tabConsultas.TabIndex = 3;
            this.tabConsultas.Text = "Consultas";
            this.tabConsultas.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(272, 350);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(208, 16);
            this.label16.TabIndex = 76;
            this.label16.Text = "Consultar Vuelos Realizados";
            // 
            // btnConsultarVuelos
            // 
            this.btnConsultarVuelos.BackColor = System.Drawing.Color.SlateGray;
            this.btnConsultarVuelos.Image = global::Aeronautica.Properties.Resources.search_bx;
            this.btnConsultarVuelos.Location = new System.Drawing.Point(310, 235);
            this.btnConsultarVuelos.Name = "btnConsultarVuelos";
            this.btnConsultarVuelos.Size = new System.Drawing.Size(128, 112);
            this.btnConsultarVuelos.TabIndex = 75;
            this.btnConsultarVuelos.UseVisualStyleBackColor = false;
            this.btnConsultarVuelos.Click += new System.EventHandler(this.btnConsultarVuelos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(556, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 74;
            this.label10.Text = "Reporte Aeronave";
            // 
            // btnReporteAeronave
            // 
            this.btnReporteAeronave.BackColor = System.Drawing.Color.SlateGray;
            this.btnReporteAeronave.Image = global::Aeronautica.Properties.Resources.Aeronavexx22;
            this.btnReporteAeronave.Location = new System.Drawing.Point(559, 328);
            this.btnReporteAeronave.Name = "btnReporteAeronave";
            this.btnReporteAeronave.Size = new System.Drawing.Size(128, 112);
            this.btnReporteAeronave.TabIndex = 73;
            this.btnReporteAeronave.UseVisualStyleBackColor = false;
            this.btnReporteAeronave.Click += new System.EventHandler(this.btnReporteAeronave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Italic);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(334, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 40);
            this.label9.TabIndex = 71;
            this.label9.Text = "Consultas";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Aeronautica.Properties.Resources.LogoAvion;
            this.pictureBox3.Location = new System.Drawing.Point(75, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 72;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "Reporte Piloto";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.Image = global::Aeronautica.Properties.Resources.pilo;
            this.button3.Location = new System.Drawing.Point(91, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 112);
            this.button3.TabIndex = 69;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 16);
            this.label8.TabIndex = 68;
            this.label8.Text = "Consultar Horas de Vuelo de Aeronave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Consultar Horas de Vuelo de Piloto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Image = global::Aeronautica.Properties.Resources.ConsultarHorasDeVueloAeronave;
            this.button1.Location = new System.Drawing.Point(559, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 112);
            this.button1.TabIndex = 67;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsultaHoras
            // 
            this.btnConsultaHoras.BackColor = System.Drawing.Color.SlateGray;
            this.btnConsultaHoras.Image = global::Aeronautica.Properties.Resources.ConsultarHoradeVueloPiloto;
            this.btnConsultaHoras.Location = new System.Drawing.Point(91, 131);
            this.btnConsultaHoras.Name = "btnConsultaHoras";
            this.btnConsultaHoras.Size = new System.Drawing.Size(128, 112);
            this.btnConsultaHoras.TabIndex = 52;
            this.btnConsultaHoras.UseVisualStyleBackColor = false;
            this.btnConsultaHoras.Click += new System.EventHandler(this.btnConsultaHoras_Click);
            // 
            // VistaOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(838, 516);
            this.Controls.Add(this.tabControlOperador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VistaOperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VistaOperador_FormClosing);
            this.Leave += new System.EventHandler(this.VistaOperador_Leave);
            this.tabAeronaves.ResumeLayout(false);
            this.tabAeronaves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPilotos.ResumeLayout(false);
            this.tabPilotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabControlOperador.ResumeLayout(false);
            this.tabVuelos.ResumeLayout(false);
            this.tabVuelos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabConsultas.ResumeLayout(false);
            this.tabConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAeronaves;
        private System.Windows.Forms.TabPage tabPilotos;
        private System.Windows.Forms.TabControl tabControlOperador;
        private System.Windows.Forms.TabPage tabVuelos;
        private System.Windows.Forms.TabPage tabConsultas;
        private System.Windows.Forms.Button btnIngresarPiloto;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnMantenedorMedicamento;
        private System.Windows.Forms.Button btnMantenedorLicencias;
        private System.Windows.Forms.Button btnMantenedorPiloto;
        private System.Windows.Forms.Button btnIngresarMedicamento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresarLicencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btnPlanVuelo;
        private System.Windows.Forms.Button btnPlanReal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIngresarPlanVuelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFabricante;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnComponentes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnAeronave;
        private System.Windows.Forms.Button btnMantenedorAeronave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultaHoras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReporteAeronave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnConsultarVuelos;
    }
}

