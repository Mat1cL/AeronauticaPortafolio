namespace Aeronautica
{
    partial class MantenedorAeronave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorAeronave));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.gbDatosAeronave = new System.Windows.Forms.GroupBox();
            this.cboDisponible = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminarAeronave = new System.Windows.Forms.Button();
            this.btnModificarAeronave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombreDGV = new System.Windows.Forms.Label();
            this.lblIDDGV = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.btnEliminarComponente = new System.Windows.Forms.Button();
            this.btnEditarComponente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvComponentes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.cbTipoAeronave = new System.Windows.Forms.ComboBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtMatricula1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnVolveraBuscar = new System.Windows.Forms.Button();
            this.gbDatosAeronave.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(290, 30);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Buscar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricula Aeronave";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(176, 30);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 0;
            // 
            // gbDatosAeronave
            // 
            this.gbDatosAeronave.Controls.Add(this.cboDisponible);
            this.gbDatosAeronave.Controls.Add(this.label10);
            this.gbDatosAeronave.Controls.Add(this.btnVolver);
            this.gbDatosAeronave.Controls.Add(this.btnEliminarAeronave);
            this.gbDatosAeronave.Controls.Add(this.btnModificarAeronave);
            this.gbDatosAeronave.Controls.Add(this.groupBox1);
            this.gbDatosAeronave.Controls.Add(this.cbFabricante);
            this.gbDatosAeronave.Controls.Add(this.cbTipoAeronave);
            this.gbDatosAeronave.Controls.Add(this.txtAño);
            this.gbDatosAeronave.Controls.Add(this.txtMatricula1);
            this.gbDatosAeronave.Controls.Add(this.label5);
            this.gbDatosAeronave.Controls.Add(this.label4);
            this.gbDatosAeronave.Controls.Add(this.label3);
            this.gbDatosAeronave.Controls.Add(this.label2);
            this.gbDatosAeronave.Location = new System.Drawing.Point(57, 68);
            this.gbDatosAeronave.Name = "gbDatosAeronave";
            this.gbDatosAeronave.Size = new System.Drawing.Size(499, 382);
            this.gbDatosAeronave.TabIndex = 2;
            this.gbDatosAeronave.TabStop = false;
            this.gbDatosAeronave.Text = "Datos de Aeronave";
            // 
            // cboDisponible
            // 
            this.cboDisponible.FormattingEnabled = true;
            this.cboDisponible.Location = new System.Drawing.Point(352, 57);
            this.cboDisponible.Name = "cboDisponible";
            this.cboDisponible.Size = new System.Drawing.Size(122, 21);
            this.cboDisponible.TabIndex = 10;
            this.cboDisponible.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboDisponible_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estado";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(328, 320);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 34);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminarAeronave
            // 
            this.btnEliminarAeronave.Location = new System.Drawing.Point(187, 320);
            this.btnEliminarAeronave.Name = "btnEliminarAeronave";
            this.btnEliminarAeronave.Size = new System.Drawing.Size(112, 34);
            this.btnEliminarAeronave.TabIndex = 7;
            this.btnEliminarAeronave.Text = "Eliminar Aeronave";
            this.btnEliminarAeronave.UseVisualStyleBackColor = true;
            this.btnEliminarAeronave.Click += new System.EventHandler(this.btnEliminarAeronave_Click);
            // 
            // btnModificarAeronave
            // 
            this.btnModificarAeronave.Location = new System.Drawing.Point(49, 320);
            this.btnModificarAeronave.Name = "btnModificarAeronave";
            this.btnModificarAeronave.Size = new System.Drawing.Size(113, 34);
            this.btnModificarAeronave.TabIndex = 6;
            this.btnModificarAeronave.Text = "Modificar Aeronave";
            this.btnModificarAeronave.UseVisualStyleBackColor = true;
            this.btnModificarAeronave.Click += new System.EventHandler(this.btnModificarAeronave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreDGV);
            this.groupBox1.Controls.Add(this.lblIDDGV);
            this.groupBox1.Controls.Add(this.cbProveedor);
            this.groupBox1.Controls.Add(this.btnEliminarComponente);
            this.groupBox1.Controls.Add(this.btnEditarComponente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.dgvComponentes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(17, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Componentes";
            // 
            // lblNombreDGV
            // 
            this.lblNombreDGV.AutoSize = true;
            this.lblNombreDGV.Location = new System.Drawing.Point(67, 23);
            this.lblNombreDGV.Name = "lblNombreDGV";
            this.lblNombreDGV.Size = new System.Drawing.Size(54, 13);
            this.lblNombreDGV.TabIndex = 19;
            this.lblNombreDGV.Text = "NOMBRE";
            // 
            // lblIDDGV
            // 
            this.lblIDDGV.AutoSize = true;
            this.lblIDDGV.Location = new System.Drawing.Point(20, 24);
            this.lblIDDGV.Name = "lblIDDGV";
            this.lblIDDGV.Size = new System.Drawing.Size(18, 13);
            this.lblIDDGV.TabIndex = 18;
            this.lblIDDGV.Text = "ID";
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(199, 75);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(139, 21);
            this.cbProveedor.TabIndex = 2;
            this.cbProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProveedor_KeyPress);
            // 
            // btnEliminarComponente
            // 
            this.btnEliminarComponente.Location = new System.Drawing.Point(359, 76);
            this.btnEliminarComponente.Name = "btnEliminarComponente";
            this.btnEliminarComponente.Size = new System.Drawing.Size(75, 43);
            this.btnEliminarComponente.TabIndex = 5;
            this.btnEliminarComponente.Text = "Eliminar Componente";
            this.btnEliminarComponente.UseVisualStyleBackColor = true;
            this.btnEliminarComponente.Click += new System.EventHandler(this.btnEliminarComponente_Click);
            // 
            // btnEditarComponente
            // 
            this.btnEditarComponente.Location = new System.Drawing.Point(359, 23);
            this.btnEditarComponente.Name = "btnEditarComponente";
            this.btnEditarComponente.Size = new System.Drawing.Size(75, 43);
            this.btnEditarComponente.TabIndex = 4;
            this.btnEditarComponente.Text = "Modificar Componente";
            this.btnEditarComponente.UseVisualStyleBackColor = true;
            this.btnEditarComponente.Click += new System.EventHandler(this.btnEditarComponente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Proveedor";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 122);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(191, 45);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descripcion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(199, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(199, 20);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(139, 20);
            this.txtID.TabIndex = 0;
            // 
            // dgvComponentes
            // 
            this.dgvComponentes.AllowUserToAddRows = false;
            this.dgvComponentes.AllowUserToDeleteRows = false;
            this.dgvComponentes.AllowUserToOrderColumns = true;
            this.dgvComponentes.AllowUserToResizeColumns = false;
            this.dgvComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComponentes.ColumnHeadersVisible = false;
            this.dgvComponentes.Location = new System.Drawing.Point(6, 40);
            this.dgvComponentes.MultiSelect = false;
            this.dgvComponentes.Name = "dgvComponentes";
            this.dgvComponentes.ReadOnly = true;
            this.dgvComponentes.RowHeadersVisible = false;
            this.dgvComponentes.Size = new System.Drawing.Size(125, 127);
            this.dgvComponentes.TabIndex = 0;
            this.dgvComponentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComponentes_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID";
            // 
            // cbFabricante
            // 
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(119, 89);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(132, 21);
            this.cbFabricante.TabIndex = 2;
            // 
            // cbTipoAeronave
            // 
            this.cbTipoAeronave.FormattingEnabled = true;
            this.cbTipoAeronave.Location = new System.Drawing.Point(119, 58);
            this.cbTipoAeronave.Name = "cbTipoAeronave";
            this.cbTipoAeronave.Size = new System.Drawing.Size(132, 21);
            this.cbTipoAeronave.TabIndex = 1;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(352, 29);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(72, 20);
            this.txtAño.TabIndex = 3;
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            this.txtAño.Validating += new System.ComponentModel.CancelEventHandler(this.txtAño_Validating);
            // 
            // txtMatricula1
            // 
            this.txtMatricula1.Location = new System.Drawing.Point(119, 29);
            this.txtMatricula1.Name = "txtMatricula1";
            this.txtMatricula1.ReadOnly = true;
            this.txtMatricula1.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fabricante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Aeronave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Año Fabricacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Matricula";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(374, 35);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 4;
            // 
            // btnVolveraBuscar
            // 
            this.btnVolveraBuscar.Location = new System.Drawing.Point(290, 30);
            this.btnVolveraBuscar.Name = "btnVolveraBuscar";
            this.btnVolveraBuscar.Size = new System.Drawing.Size(94, 23);
            this.btnVolveraBuscar.TabIndex = 5;
            this.btnVolveraBuscar.Text = "Volver a Buscar";
            this.btnVolveraBuscar.UseVisualStyleBackColor = true;
            this.btnVolveraBuscar.Click += new System.EventHandler(this.btnVolveraBuscar_Click);
            // 
            // MantenedorAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.btnVolveraBuscar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.gbDatosAeronave);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MantenedorAeronave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Aeronave";
            this.Load += new System.EventHandler(this.MantenedorAeronave_Load);
            this.gbDatosAeronave.ResumeLayout(false);
            this.gbDatosAeronave.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComponentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.GroupBox gbDatosAeronave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvComponentes;
        private System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.ComboBox cbTipoAeronave;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtMatricula1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarAeronave;
        private System.Windows.Forms.Button btnModificarAeronave;
        private System.Windows.Forms.Button btnEliminarComponente;
        private System.Windows.Forms.Button btnEditarComponente;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnVolveraBuscar;
        private System.Windows.Forms.Label lblNombreDGV;
        private System.Windows.Forms.Label lblIDDGV;
        private System.Windows.Forms.ComboBox cboDisponible;
        private System.Windows.Forms.Label label10;
    }
}