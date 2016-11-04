using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Aeronautica;
using Logica;
using Conexion;

namespace Aeronautica
{

    public partial class IngresarPlanVuelo : Form
    {
        public IngresarPlanVuelo()
        {
            InitializeComponent();
        }


        //CargaCondicion

        void FillCbCondicion()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter((consultas.Variables.SelectCboCondicion), conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_condicion"] = Convert.ToInt32("0");
                row["nombre_condicion"] = "Seleccione una Condición";
                dt.Rows.InsertAt(row, 0);
                this.cboCondicion.DataSource = dt;
                this.cboCondicion.DisplayMember = "nombre_condicion";
                this.cboCondicion.ValueMember = "id_condicion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //FinCargaCondicion

        //CargaMision

        void FillCbMision()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter((consultas.Variables.SelectCboMision), conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_mision"] = Convert.ToInt32("0");
                row["nombre_mision"] = "Seleccione una Misión";
                dt.Rows.InsertAt(row, 0);
                this.cbMision.DataSource = dt;
                this.cbMision.DisplayMember = "nombre_mision";
                this.cbMision.ValueMember = "id_mision";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //FinCargaMision


        //CargaTipoLicencia

        void FillCbTipoLicencia()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboTipoLicencia)+"'" + this.cboPiloto.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["numero_licencia"] = Convert.ToInt32("0");
                row["nombre_tipo_licencia"] = "Seleccione un Tipo de Licencia";
                dt.Rows.InsertAt(row, 0);
                this.cboTipoLicencia.DataSource = dt;
                this.cboTipoLicencia.DisplayMember = "nombre_tipo_licencia";
                this.cboTipoLicencia.ValueMember = "numero_licencia";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //FinCargaTipoLicencia

        //InicioCargaTipoLicenciaCoPiloto

        void FillCbTipoLicencia2()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboTipoLicencia2)+"'" + this.cboCopiloto.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["numero_licencia"] = Convert.ToInt32("0");
                row["nombre_tipo_licencia"] = "Seleccione un Tipo de Licencia";
                dt.Rows.InsertAt(row, 0);
                this.cboTipoLicenciaCopiloto.DataSource = dt;
                this.cboTipoLicenciaCopiloto.DisplayMember = "nombre_tipo_licencia";
                this.cboTipoLicenciaCopiloto.ValueMember = "numero_licencia";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //FinCargaTipoLicenciaCoPiloto


        //CargaPiloto

        void FillCbPiloto()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectTodosPilotos)+"", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();

                dt.Columns.Add("Concatenacion", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["Concatenacion"] = dr["nombre_piloto"].ToString() + " " + dr["apellido_paterno"].ToString() + " " + dr["apellido_materno"].ToString() + " - " + dr["rut_piloto"].ToString();
                }
                DataRow row = dt.NewRow();
                row["rut_piloto"] = Convert.ToInt32("0");
                row["Concatenacion"] = "Seleccione un Piloto";
                dt.Rows.InsertAt(row, 0);
                
               
                cboPiloto.DataSource = dt;
                cboPiloto.DisplayMember = "Concatenacion";
                cboPiloto.ValueMember = "rut_piloto";

               
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Fin CargaPiloto

        //
        void FillCbPilotoDisponible()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCbPilotoDisponible)+"'" + this.cboPiloto.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboPilotoDisponible.DataSource = dt;
                this.cboPilotoDisponible.DisplayMember = "ESTADO_ID_ESTADO";
                this.cboPilotoDisponible.ValueMember = "ESTADO_ID_ESTADO";
                (consultas.Variables.estadoPiloto) = cboPilotoDisponible.Text;
                if (cboPiloto.Text == "Seleccione un Piloto")
                {
                    SPilotoRojo.Hide();
                    SPilotoVerde.Hide();
                }
                if ((consultas.Variables.estadoPiloto) == "1")
                {
                    SPilotoVerde.Show();
                    SPilotoRojo.Hide();
                    cboTipoLicencia.Enabled = true;
                }
                else if ((consultas.Variables.estadoPiloto) == "2")
                {
                    SPilotoRojo.Show();
                    SPilotoVerde.Hide();
                    cboTipoLicencia.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        //

        //Inicio CargaCopiloto

        void FillCbCoPiloto()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.SelectTodosPilotos) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();

                dt.Columns.Add("Concatenacion", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["Concatenacion"] = dr["nombre_piloto"].ToString() + " " + dr["apellido_paterno"].ToString() + " " + dr["apellido_materno"].ToString() + " - " + dr["rut_piloto"].ToString();
                }
                DataRow row = dt.NewRow();
                row["rut_piloto"] = Convert.ToInt32("0");
                row["Concatenacion"] = "Seleccione un Piloto";
                dt.Rows.InsertAt(row, 0);


                cboCopiloto.DataSource = dt;
                cboCopiloto.DisplayMember = "Concatenacion";
                cboCopiloto.ValueMember = "rut_piloto";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Fin CargaCopiloto

        //
        void FillCbCoPilotoDisponible()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCbCopilotoDisponible)+"'" + this.cboCopiloto.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboCoPilotoDisponible.DataSource = dt;
                this.cboCoPilotoDisponible.DisplayMember = "ESTADO_ID_ESTADO";
                this.cboCoPilotoDisponible.ValueMember = "ESTADO_ID_ESTADO";
                (consultas.Variables.estadoPiloto) = cboCoPilotoDisponible.Text;
                if (cboCopiloto.Text == "Seleccione un Piloto")
                {
                    SCoPilotoRojo.Hide();
                    SCoPilotoVerde.Hide();
                }
                if ((consultas.Variables.estadoPiloto) == "1")
                {
                    SCoPilotoVerde.Show();
                    SCoPilotoRojo.Hide();
                    cboTipoLicenciaCopiloto.Enabled = true;
                }
                else if ((consultas.Variables.estadoPiloto) == "2")
                {
                    SCoPilotoRojo.Show();
                    SCoPilotoVerde.Hide();
                    cboTipoLicenciaCopiloto.Enabled = false;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        //

        //Inicio CargaTipoAeronave

        void FillCbTipoAeronave()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboTipoAeronave)+"", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_tipo_aeronave"] = Convert.ToInt32("0");
                row["nombre_tipo_aeronave"] = "Seleccione un Tipo de Aeronave";
                dt.Rows.InsertAt(row, 0);
                cboTipoAeronave.DataSource = dt;
                cboTipoAeronave.DisplayMember = "nombre_tipo_aeronave";
                cboTipoAeronave.ValueMember = "nombre_tipo_aeronave";
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Fin CargaTipoAeronave

        //Inicio CargaAeronave
        void FillCbAeronave()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.SelectCboAeronave) + "'" + cboTipoAeronave.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                dt.Columns.Add("Concatenacion", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["Concatenacion"] = dr["nombre_modelo"].ToString() + " - " + dr["matricula"].ToString();
                }
                DataRow row = dt.NewRow();
                row["matricula"] = Convert.ToInt32("0");
                row["Concatenacion"] = "Seleccione una Aeronave";
                dt.Rows.InsertAt(row, 0);
                this.cboAeronave.DataSource = dt;
                this.cboAeronave.DisplayMember = "Concatenacion";
                this.cboAeronave.ValueMember = "matricula";
                if (cboAeronave.Text == "Seleccione una Aeronave")
                {
                    pbRojo.Hide();
                    pbVerde.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Fin CargaAeronave

        //
        void FillCbAeronaveDisponible()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCbAeronaveDisponible)+"'" + cboAeronave.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboDisponible.DataSource = dt;
                this.cboDisponible.DisplayMember = "ESTADO_ID_ESTADO";
                this.cboDisponible.ValueMember = "ESTADO_ID_ESTADO";
                (consultas.Variables.estado) = cboDisponible.Text;
                if (cboAeronave.Text == "Seleccione una Aeronave")
                {
                    pbRojo.Hide();
                    pbVerde.Hide();
                }              
                if ((consultas.Variables.estado) == "1")
                {
                    pbVerde.Show();
                    pbRojo.Hide();
                }
                else if ((consultas.Variables.estado) == "2")
                {
                    pbRojo.Show();
                    pbVerde.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        //

        //Carga Origen

        void FillCbOrigenPais()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter((consultas.Variables.SelectCboPais), conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_pais"] = Convert.ToInt32("0");
                row["nombre_pais"] = "Seleccione un País";
                dt.Rows.InsertAt(row, 0);
                cboOrigenPais.DataSource = dt;
                cboOrigenPais.DisplayMember = "nombre_pais";
                cboOrigenPais.ValueMember = "nombre_pais";
                this.cboOrigenPais.SelectedIndex = 0;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbOrigenRegion()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboRegion)+"'" + this.cboOrigenPais.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_region"] = Convert.ToInt32("0");
                row["nombre_region"] = "Seleccione una Región";
                dt.Rows.InsertAt(row, 0);
                this.cboOrigenRegion.DataSource = dt;
                this.cboOrigenRegion.DisplayMember = "nombre_region";
                this.cboOrigenRegion.ValueMember = "nombre_region";
                this.cboOrigenRegion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbOrigenProvincia()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboProvincia)+"'" + this.cboOrigenRegion.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_provincia"] = Convert.ToInt32("0");
                row["nombre_provincia"] = "Seleccione una Provincia";
                dt.Rows.InsertAt(row, 0);
                this.cboOrigenProvincia.DataSource = dt;
                this.cboOrigenProvincia.DisplayMember = "nombre_provincia";
                this.cboOrigenProvincia.ValueMember = "nombre_provincia";
                this.cboOrigenProvincia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbOrigenComuna()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString); ;
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboComuna)+"'" + this.cboOrigenProvincia.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_comuna"] = Convert.ToInt32("0");
                row["nombre_comuna"] = "Seleccione una Comuna";
                dt.Rows.InsertAt(row, 0);
                this.cboOrigenComuna.DataSource = dt;
                this.cboOrigenComuna.DisplayMember = "nombre_comuna";
                this.cboOrigenComuna.ValueMember = "nombre_comuna";
                this.cboOrigenComuna.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbOrigen()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.SelectCboOrigen) + "'" + this.cboOrigenProvincia.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_origen"] = Convert.ToInt32("0");
                row["nombre_origen"] = "Seleccione Origen";
                dt.Rows.InsertAt(row, 0);
                this.cboOrigen.DataSource = dt;
                this.cboOrigen.DisplayMember = "nombre_origen";
                this.cboOrigen.ValueMember = "id_origen";
                this.cboOrigen.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Fin Carga Origen

        //Carga Destino

        void FillCbDestinoPais()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter((consultas.Variables.SelectCboPais), conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_pais"] = Convert.ToInt32("0");
                row["nombre_pais"] = "Seleccione un País";
                dt.Rows.InsertAt(row, 0);
                cboDestinoPais.DataSource = dt;
                cboDestinoPais.DisplayMember = "nombre_pais";
                cboDestinoPais.ValueMember = "nombre_pais";
                this.cboDestinoPais.SelectedIndex = 0;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbDestinoRegion()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboRegion)+"'" + this.cboDestinoPais.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_region"] = Convert.ToInt32("0");
                row["nombre_region"] = "Seleccione una Región";
                dt.Rows.InsertAt(row, 0);
                this.cboDestinoRegion.DataSource = dt;
                this.cboDestinoRegion.DisplayMember = "nombre_region";
                this.cboDestinoRegion.ValueMember = "nombre_region";
                this.cboDestinoRegion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbDestinoProvincia()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboProvincia)+"'" + this.cboDestinoRegion.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_provincia"] = Convert.ToInt32("0");
                row["nombre_provincia"] = "Seleccione una Provincia";
                dt.Rows.InsertAt(row, 0);
                this.cboDestinoProvincia.DataSource = dt;
                this.cboDestinoProvincia.DisplayMember = "nombre_provincia";
                this.cboDestinoProvincia.ValueMember = "nombre_provincia";
                this.cboDestinoProvincia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbDestinoComuna()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboComuna)+"'" + this.cboDestinoProvincia.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_comuna"] = Convert.ToInt32("0");
                row["nombre_comuna"] = "Seleccione una Comuna";
                dt.Rows.InsertAt(row, 0);
                this.cboDestinoComuna.DataSource = dt;
                this.cboDestinoComuna.DisplayMember = "nombre_comuna";
                this.cboDestinoComuna.ValueMember = "nombre_comuna";
                this.cboDestinoComuna.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbDestino()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboDestino)+"'" + this.cboDestinoComuna.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_destino"] = Convert.ToInt32("0");
                row["nombre_destino"] = "Seleccione Destino";
                dt.Rows.InsertAt(row, 0);
                this.cboDestino.DataSource = dt;
                this.cboDestino.DisplayMember = "nombre_destino";
                this.cboDestino.ValueMember = "id_destino";
                this.cboDestino.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Fin Carga Destino
        

        private void VistaOperadorIngresarVuelo_Load(object sender, EventArgs e)
        {
            //txtRuta.CharacterCasing = CharacterCasing.Upper;
            //txtDescripcion.CharacterCasing = CharacterCasing.Upper;
            cboPilotoDisponible.Hide();
            cboCoPilotoDisponible.Hide();
            SPilotoRojo.Hide();
            SPilotoVerde.Hide();
            SCoPilotoRojo.Hide();
            SCoPilotoVerde.Hide();
            cboDisponible.Hide();
            pbRojo.Hide();
            pbVerde.Hide();
            FillCbTipoAeronave();
            FillCbCoPiloto();
            FillCbPiloto();
            FillCbMision();
            FillCbCondicion();
            FillCbOrigenPais();
            FillCbDestinoPais();

        }
        

      

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        datos obDAtos = new datos();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtDescripcion.Text) || string.IsNullOrWhiteSpace(this.txtRuta.Text))
            {
                MessageBox.Show("Debes completar los campos...");
                return;
            }
            if (cboPiloto.Text == "Seleccione un Piloto")
            {
                MessageBox.Show("Debes Seleccionar un Piloto");
            }
            else if (cboTipoLicencia.Text == "Seleccione un Tipo de Licencia")
            {
                MessageBox.Show("Debes Seleccionar un Tipo de Licencia Para el Piloto");
            }
            else if (cboCopiloto.Text == "Seleccione un Piloto")
            {
                MessageBox.Show("Debes Seleccionar un Copiloto");
            }
            else if (cboTipoLicenciaCopiloto.Text == "Seleccione un Tipo de Licencia")
            {
                MessageBox.Show("Debes Seleccionar un Tipo de Licencia Para el Copiloto");
            }
            else if (cboTipoAeronave.Text == "Seleccione un Tipo de Aeronave")
            {
                MessageBox.Show("Debes Seleccionar un Tipo de Aeronave");
            }
            else if (cboAeronave.Text == "Seleccione una Aeronave")
            {
                MessageBox.Show("Debes Seleccionar una Aeronave");
            }
            else if (dtSalida.Value < DateTime.Today)
            {
                MessageBox.Show("No puedes ingresar una fecha de Salida inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");

            }
            else if (dtLlegada.Value < DateTime.Today)
            {
                MessageBox.Show("No puedes ingresar una fecha de Llegada inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");
            }
            else if (cboOrigenPais.Text == "Seleccione un País")
            {
                MessageBox.Show("Debes Seleccionar un País de Origen");
            }
            else if (cboOrigenRegion.Text == "Seleccione una Región")
            {
                MessageBox.Show("Debes Seleccionar una Región de Origen");
            }
            else if (cboOrigenProvincia.Text == "Seleccione una Provincia")
            {
                MessageBox.Show("Debes Seleccionar una Provincia de Origen");
            }
            else if (cboOrigenComuna.Text == "Seleccione una Comuna")
            {
                MessageBox.Show("Debes Seleccionar una Comuna de Origen");
            }
            else if (cboOrigen.Text == "Seleccione Origen")
            {
                MessageBox.Show("Debes Seleccionar un Origen");
            }
            else if (cboDestinoPais.Text == "Seleccione un País")
            {
                MessageBox.Show("Debes Seleccionar un País de Destino");
            }
            else if (cboDestinoRegion.Text == "Seleccione una Región")
            {
                MessageBox.Show("Debes Seleccionar una Región de Destino");
            }
            else if (cboDestinoProvincia.Text == "Seleccione una Provincia")
            {
                MessageBox.Show("Debes Seleccionar una Provincia de Destino");
            }
            else if (cboDestinoComuna.Text == "Seleccione una Comuna")
            {
                MessageBox.Show("Debes Seleccionar una Comuna de Destino");
            }
            else if (cboDestino.Text == "Seleccione Destino")
            {
                MessageBox.Show("Debes Seleccionar un Destino");
            }
            else if (cboCondicion.Text == "Seleccione una Condición")
            {
                MessageBox.Show("Debes Seleccionar una Condición");
            }
            else if (cbMision.Text == "Seleccione una Misión")
            {
                MessageBox.Show("Debes Seleccionar una Misión");
            }
            else if (cboPiloto.Text == cboCopiloto.Text)
            {
                MessageBox.Show("El Piloto y el Copiloto deben ser diferentes");
            }
            else if (cboDisponible.Text == "2")
            {
                MessageBox.Show("La Aeronave se encuentra en Mantenimiento");
            }
            else if (cboPilotoDisponible.Text == "2")
            {
                MessageBox.Show("El Piloto Seleccionado se encuentra deshabilitado");
            }
            else if (cboCoPilotoDisponible.Text == "2")
            {
                MessageBox.Show("El Copiloto Seleccionado se encuentra deshabilitado");
            }
            
            else 
                {
                        string sql = ""+(consultas.Variables.IngresoPlanVuelo)+" (id_vuelo.nextval,'" + this.txtDescripcion.Text + "','" + this.dtSalida.Text + this.dtHoraSalida.Text + ":00" + "','" + this.dtLlegada.Text + this.dtHoraLlegada.Text + ":00" + "','" + this.cboCondicion.SelectedValue + "', '" + this.cbMision.SelectedValue + "','" + this.cboPiloto.SelectedValue + "','" + this.cboCopiloto.SelectedValue + "','" + this.cboTipoLicencia.SelectedValue + "','" + this.cboTipoLicenciaCopiloto.SelectedValue + "','"+this.txtRuta.Text+"','" + this.cboDestino.SelectedValue + "','" + this.cboOrigen.SelectedValue + "','" + this.cboAeronave.SelectedValue + "')";
                        if (obDAtos.insertar(sql))
                        {
                          MessageBox.Show("Plan de Vuelo Registrado");
                        }
                        else
                        {
                          MessageBox.Show("Error al Registrar Plan de Vuelo");
                        }
                    } 
            }

        private void cboPiloto_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbTipoLicencia();
            FillCbPilotoDisponible();
        }

       
        private void cboOrigenPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbOrigenRegion();
        }

        private void cboOrigenRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbOrigenProvincia();
        }

        private void cboOrigenProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbOrigenComuna();
        }

        private void cboOrigenComuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbOrigen();
        }

        private void cboDestinoComuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbDestino();
        }

        private void cboDestinoPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbDestinoRegion();
        }

        private void cboDestinoRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbDestinoProvincia();
        }

        private void cboDestinoProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbDestinoComuna();
        }

        private void cboCopiloto_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbTipoLicencia2();
            FillCbCoPilotoDisponible();
        }

        private void cboTipoAeronave_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbAeronave();
        }

        private void cboPiloto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtHoraSalida_ValueChanged(object sender, EventArgs e)
        {

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pbVerde.Hide();
            pbRojo.Hide();
            if (dtHoraSalida != null)
            {
                dtHoraSalida.Text = "00:00";
            }
            if (dtHoraLlegada != null)
            {
                dtHoraLlegada.Text = "00:00";
            }
            if (dtSalida != null)
            {
                dtSalida.Text = String.Empty;
            } 
            if (dtLlegada != null)
            {
                dtLlegada.Text = String.Empty;
            }
            txtDescripcion.Clear();
            cboPiloto.SelectedIndex = 0;
            cboCopiloto.SelectedIndex = 0;
            cboTipoLicencia.SelectedIndex = 0;
            cboTipoLicenciaCopiloto.SelectedIndex = 0;
            cboTipoAeronave.SelectedIndex = 0;
            cboAeronave.SelectedIndex = 0;
            cboOrigenPais.SelectedIndex = 0;
            cboOrigenRegion.SelectedIndex = 0;
            cboOrigenProvincia.SelectedIndex = 0;
            cboOrigenComuna.SelectedIndex = 0;
            cboOrigen.SelectedIndex = 0;
            cboDestinoPais.SelectedIndex = 0;
            cboDestinoRegion.SelectedIndex = 0;
            cboDestinoProvincia.SelectedIndex = 0;
            cboDestinoComuna.SelectedIndex = 0;
            cboDestino.SelectedIndex = 0;
            cboCondicion.SelectedIndex = 0;
            cbMision.SelectedIndex = 0;

            
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cboAeronave_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbAeronaveDisponible();
        }

        private void cboAeronave_DrawItem(object sender, DrawItemEventArgs e)
        {
           
        }

        private void txtRuta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }


        }

        
    }

