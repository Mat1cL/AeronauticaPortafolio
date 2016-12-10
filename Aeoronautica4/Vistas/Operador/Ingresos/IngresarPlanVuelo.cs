using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Aeronautica;
using Logica;
using Logica.Clases;
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
            dtHoraSalida2.Hide();
            dtHoraLlegada2.Hide();
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

        public static string LicenciaPiloto;
        public static string LicenciaCopiloto;
        datos obDAtos = new datos();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Logica.PlanVuelo.Descripcion_ = txtDescripcion.Text;
            Logica.PlanVuelo.FechaSalida_ = dtSalida.Text;
            Logica.PlanVuelo.HoraSalida_ = dtHoraSalida.Text;
            Logica.PlanVuelo.FechaLlegada_ = dtLlegada.Text;
            Logica.PlanVuelo.HoraLlegada_ = dtHoraLlegada.Text;
            Logica.PlanVuelo.Condicion_ = cboCondicion.SelectedValue.ToString();
            Logica.PlanVuelo.Mision_ = cbMision.SelectedValue.ToString();
            Logica.PlanVuelo.Piloto_ = cboPiloto.SelectedValue.ToString();
            Logica.PlanVuelo.Copiloto_ = cboCopiloto.SelectedValue.ToString();
            Logica.PlanVuelo.TipoLicenciaPiloto_ = cboTipoLicencia.SelectedValue.ToString();
            Logica.PlanVuelo.TipoLicenciaCopiloto_ = cboTipoLicenciaCopiloto.SelectedValue.ToString();
            Logica.PlanVuelo.Ruta_ = txtRuta.Text;
            Logica.PlanVuelo.Destino_ = cboDestino.SelectedValue.ToString();
            Logica.PlanVuelo.Origen_ = cboOrigen.SelectedValue.ToString();
            Logica.PlanVuelo.Aeronave_ = cboAeronave.SelectedValue.ToString();

            /*************************************************************************** INICIO LIMPIAR ERRORES  ***********************************/
            OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
            cnn.Open();
            if (cboPiloto.Text != "Seleccione un Piloto" && cboTipoLicencia.Text != "Seleccione un Tipo de Licencia")
            {
                string sqlStringx = ""+(consultas.Variables.ValidarLicenciaPiloto)+" '" + cboPiloto.SelectedValue + "' "+(consultas.Variables.ValidarLicenciaPiloto2)+" '" + cboTipoLicencia.Text + "'";
                OracleDataReader dr = null;
                OracleCommand cmd = new OracleCommand(sqlStringx, cnn);
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    LicenciaPiloto = dr["LICENCIA"].ToString();
                }
            }
            if (cboCopiloto.Text != "Seleccione un Piloto" && cboTipoLicenciaCopiloto.Text != "Seleccione un Tipo de Licencia")
            {
                string sqlStringx2 = ""+(consultas.Variables.ValidarLicenciaCopiloto)+" '" + cboCopiloto.SelectedValue + "' "+(consultas.Variables.ValidarLicenciaCopiloto2)+" '" + cboTipoLicenciaCopiloto.Text + "'";
                OracleDataReader dr2 = null;
                OracleCommand cmd2 = new OracleCommand(sqlStringx2, cnn);
                dr2 = cmd2.ExecuteReader();
                if (dr2.Read() == true)
                {
                    LicenciaCopiloto = dr2["LICENCIA"].ToString();
                }
            }
            
            /**/
            if (txtDescripcion.Text.Length > 0)
            {
                errorProvider1.SetError(txtDescripcion, string.Empty);
            }
            if (txtRuta.Text.Length > 0)
            {
                errorProvider1.SetError(txtRuta, string.Empty);
            }
            if (cboPiloto.Text != "Seleccione un Piloto")
            {
                errorProvider1.SetError(cboPiloto, string.Empty);
            }
            if (cboTipoLicencia.Text != "Seleccione un Tipo de Licencia")
            {
                errorProvider1.SetError(cboTipoLicencia, string.Empty);
            }
            if (cboCopiloto.Text != "Seleccione un Piloto")
            {
                errorProvider1.SetError(cboCopiloto, string.Empty);
            }
            if (cboTipoLicenciaCopiloto.Text != "Seleccione un Tipo de Licencia")
            {
                errorProvider1.SetError(cboTipoLicenciaCopiloto, string.Empty);
            }

            if (cboTipoAeronave.Text != "Seleccione un Tipo de Aeronave")
            {
                errorProvider1.SetError(cboTipoAeronave, string.Empty);
            }
            if (cboAeronave.Text != "Seleccione una Aeronave")
            {
                errorProvider1.SetError(cboAeronave, string.Empty);
            }
            if (LicenciaPiloto == "2")
            {

                if (cboTipoAeronave.SelectedValue.ToString() == "Avión")
                {
                    errorProvider1.SetError(cboTipoLicencia, string.Empty);
                }

            }

            if (LicenciaPiloto == "3")
            {
                if (cboTipoAeronave.SelectedValue.ToString() == "Helicóptero")
                {
                    errorProvider1.SetError(cboTipoLicencia, string.Empty);
                }

            }
            if (LicenciaCopiloto == "2")
            {

                if (cboTipoAeronave.SelectedValue.ToString() == "Avión")
                {
                    errorProvider1.SetError(cboTipoLicenciaCopiloto, string.Empty);
                }

            }

            if (LicenciaCopiloto == "3")
            {
                if (cboTipoAeronave.SelectedValue.ToString() == "Helicóptero")
                {
                    errorProvider1.SetError(cboTipoLicenciaCopiloto, string.Empty);
                }

            }
            if (cboTipoLicencia.ToString() != cboTipoLicenciaCopiloto.ToString())
            {
                errorProvider1.SetError(cboTipoLicencia, string.Empty);
                errorProvider1.SetError(cboTipoLicenciaCopiloto, string.Empty);
            }
            if (dtSalida.Value > DateTime.Today)
            {
                errorProvider1.SetError(dtSalida, string.Empty);
            }
            if (dtLlegada.Value > DateTime.Today)
            {
                errorProvider1.SetError(dtLlegada, string.Empty);
            }
            if (dtLlegada.Text == dtSalida.Text)
            {
                errorProvider1.SetError(dtLlegada, string.Empty);
            }
            if (dtLlegada.Value > dtSalida.Value)
            {
                errorProvider1.SetError(dtLlegada, string.Empty);
            }
            if (cboOrigenPais.Text != "Seleccione un País")
            {
                errorProvider1.SetError(cboOrigenPais, string.Empty);
            }
            if (cboOrigenRegion.Text != "Seleccione una Región")
            {
                errorProvider1.SetError(cboOrigenRegion, string.Empty);
            }
            if (cboOrigenProvincia.Text != "Seleccione una Provincia")
            {
                errorProvider1.SetError(cboOrigenProvincia, string.Empty);
            }
            if (cboOrigenComuna.Text != "Seleccione una Comuna")
            {
                errorProvider1.SetError(cboOrigenComuna, string.Empty);
            }
            if (cboOrigen.Text != "Seleccione Origen")
            {
                errorProvider1.SetError(cboOrigen, string.Empty);
            }
            if (cboDestinoPais.Text != "Seleccione un País")
            {
                errorProvider1.SetError(cboDestinoPais, string.Empty);
            }
            if (cboDestinoRegion.Text != "Seleccione una Región")
            {
                errorProvider1.SetError(cboDestinoRegion, string.Empty);
            }
            if (cboDestinoProvincia.Text != "Seleccione una Provincia")
            {
                errorProvider1.SetError(cboDestinoProvincia, string.Empty);
            }
            if (cboDestinoComuna.Text != "Seleccione una Comuna")
            {
                errorProvider1.SetError(cboDestinoComuna, string.Empty);
            }
            if (cboDestino.Text != "Seleccione Destino")
            {
                errorProvider1.SetError(cboDestino, string.Empty);
            }
            if (cboCondicion.Text != "Seleccione una Condición")
            {
                errorProvider1.SetError(cboCondicion, string.Empty);
            }
            if (cbMision.Text != "Seleccione una Misión")
            {
                errorProvider1.SetError(cbMision, string.Empty);
            }
            
           
            /*************************************************************************** FIN LIMPIAR ERRORES  ***********************************/

            /*************************************************************************** INICIO DECLARAR ERRORES  ***********************************/

            
            if (string.IsNullOrWhiteSpace(this.txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, "Debes dar una descripción");
            }
            if (string.IsNullOrWhiteSpace(this.txtRuta.Text))
            {
                errorProvider1.SetError(txtRuta, "Debes describir una Ruta");
            }
            if (cboPiloto.Text == "Seleccione un Piloto")
            {
                errorProvider1.SetError(cboPiloto, "Debes Seleccionar un Piloto");
            }
            if (cboTipoLicencia.Text == "Seleccione un Tipo de Licencia")
            {
                errorProvider1.SetError(cboTipoLicencia, "Debes Seleccionar un Piloto");
            }
            if (cboCopiloto.Text == "Seleccione un Piloto")
            {
                errorProvider1.SetError(cboCopiloto, "Debes Seleccionar un Copiloto");
            }
            if (cboTipoLicenciaCopiloto.Text == "Seleccione un Tipo de Licencia")
            {
                errorProvider1.SetError(cboTipoLicenciaCopiloto, "Debes Seleccionar un Tipo de Licencia Para el Copiloto");
            }
            if (cboTipoAeronave.Text == "Seleccione un Tipo de Aeronave")
            {
                errorProvider1.SetError(cboTipoAeronave, "Debes Seleccionar un Tipo de Aeronave");
            }
            if (cboAeronave.Text == "Seleccione una Aeronave")
            {
                errorProvider1.SetError(cboAeronave, "Debes Seleccionar una Aeronave");
            }
            if (LicenciaPiloto == "2")
            {

                if (cboTipoAeronave.SelectedValue.ToString() == "Helicóptero")
                {
                    errorProvider1.SetError(cboTipoLicencia, "No puedes pilotar un Helicóptero con una Licencia de Avión");
                }

            }

            if (LicenciaPiloto == "3")
            {
                if (cboTipoAeronave.SelectedValue.ToString() == "Avión")
                {
                    errorProvider1.SetError(cboTipoLicencia, "No puedes pilotar un Avión con una Licencia de Helicóptero");
                }

            }

            //*/

            if (LicenciaCopiloto == "2")
            {

                if (cboTipoAeronave.SelectedValue.ToString() == "Helicóptero")
                {
                    errorProvider1.SetError(cboTipoLicenciaCopiloto, "No puedes pilotar un Helicóptero con una Licencia de Avión");
                }

            }

            if (LicenciaCopiloto == "3")
            {
                if (cboTipoAeronave.SelectedValue.ToString() == "Avión")
                {
                    errorProvider1.SetError(cboTipoLicenciaCopiloto, "No puedes pilotar un Avión con una Licencia de Helicóptero");
                }

            }

            /**/
            if (LicenciaPiloto == "1" && LicenciaCopiloto == "1")
            {
                errorProvider1.SetError(cboTipoLicencia, "Dos estudiantes no pueden pilotar un tipo de Aeronave\nse necesita de un experto en compañia del estudiante");
                errorProvider1.SetError(cboTipoLicenciaCopiloto, "Dos estudiantes no pueden pilotar un tipo de Aeronave\nse necesita de un experto en compañia del estudiante");
            }

            /****/
            if (dtSalida.Value < DateTime.Today)
            {
                errorProvider1.SetError(dtSalida, "No puedes ingresar una fecha de Salida inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");
            }
            if (dtLlegada.Value < DateTime.Today)
            {
                errorProvider1.SetError(dtLlegada, "No puedes ingresar una fecha de Llegada inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");
            }
            if (dtSalida.Value > dtLlegada.Value)
            {
                if (dtSalida.Text == dtLlegada.Text)
                {
                    dtHoraLlegada2 = dtHoraLlegada;
                    dtHoraSalida2 = dtHoraSalida;
                    var dtsalidastring = dtHoraSalida2.Value.ToString("HH:mm");
                    var dtllegadastring = dtHoraLlegada2.Value.ToString("HH:mm");
                    DateTime dtHoraSalida2x = DateTime.ParseExact(dtsalidastring, "HH:mm",CultureInfo.InvariantCulture);
                    DateTime dtHoraLlegada2x = DateTime.ParseExact(dtllegadastring, "HH:mm", CultureInfo.InvariantCulture);
                    errorProvider1.SetError(dtLlegada, string.Empty);
                    if (dtHoraLlegada2x < dtHoraSalida2x)
                    {
                        errorProvider1.SetError(dtHoraLlegada, "No puedes ingresar una hora de llegada menor o igual a la de salida: " + dtHoraSalida.Text + "");
                    }
                    else if (dtHoraLlegada2x == dtHoraSalida2x)
                    {
                        errorProvider1.SetError(dtHoraLlegada, "Debes ingresar una hora de llegada mayor a la de salida: " + dtHoraSalida.Text + "");
                    }
                    else if (dtHoraLlegada2x != dtHoraSalida2x)
                    {
                        errorProvider1.SetError(dtHoraLlegada, string.Empty);
                    }
                    
                }
                else
                {
                    errorProvider1.SetError(dtLlegada, "No puedes ingresar una fecha de Llegada inferior a la de Salida: " + dtSalida.Text + "");
                }
                
            }
            if (cboOrigenPais.Text == "Seleccione un País")
            {
                errorProvider1.SetError(cboOrigenPais, "Debes Seleccionar un País de Origen");
            }
            if (cboOrigenRegion.Text == "Seleccione una Región")
            {
                errorProvider1.SetError(cboOrigenRegion, "Debes Seleccionar una Región de Origen");
            }
            if (cboOrigenProvincia.Text == "Seleccione una Provincia")
            {
                errorProvider1.SetError(cboOrigenProvincia, "Debes Seleccionar una Provincia de Origen");
            }
            if (cboOrigenComuna.Text == "Seleccione una Comuna")
            {
                errorProvider1.SetError(cboOrigenComuna, "Debes Seleccionar una Comuna de Origen");
            }
            if (cboOrigen.Text == "Seleccione Origen")
            {
                errorProvider1.SetError(cboOrigen, "Debes Seleccionar un Origen");
            }
            if (cboDestinoPais.Text == "Seleccione un País")
            {
                errorProvider1.SetError(cboDestinoPais, "Debes Seleccionar un País de Destino");
            }
            if (cboDestinoRegion.Text == "Seleccione una Región")
            {
                errorProvider1.SetError(cboDestinoRegion, "Debes Seleccionar una Región de Destino");
            }
            if (cboDestinoProvincia.Text == "Seleccione una Provincia")
            {
                errorProvider1.SetError(cboDestinoProvincia, "Debes Seleccionar una Provincia de Destino");
            }
            if (cboDestinoComuna.Text == "Seleccione una Comuna")
            {
                errorProvider1.SetError(cboDestinoComuna, "Debes Seleccionar una Comuna de Destino");
            }
            if (cboDestino.Text == "Seleccione Destino")
            {
                errorProvider1.SetError(cboDestino, "Debes Seleccionar un Destino");
            }
            if (cboCondicion.Text == "Seleccione una Condición")
            {
                errorProvider1.SetError(cboCondicion, "Debes Seleccionar una Condición");
            }
            if (cbMision.Text == "Seleccione una Misión")
            {
                errorProvider1.SetError(cbMision, "Debes Seleccionar una Misión");
            }
            if (cboDisponible.Text == "2")
            {
                MessageBox.Show("La Aeronave se encuentra en Mantenimiento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cboPilotoDisponible.Text == "2")
            {
                MessageBox.Show("El Piloto Seleccionado se encuentra deshabilitado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cboCoPilotoDisponible.Text == "2")
            {
                MessageBox.Show("El Copiloto Seleccionado se encuentra deshabilitado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*************************************************************************** FIN DECLARAR ERRORES  ***********************************/


            /*************************************************************************** VALIDAR SI EXISTEN ERRORES ***********************************/
            if (errorProvider1.GetError(cboTipoLicencia) == "No puedes pilotar un Helicóptero con una Licencia de Avión")
            {
                return;
            }
            if (errorProvider1.GetError(cboTipoLicencia) == "No puedes pilotar un Avión con una Licencia de Helicóptero")
            {
                return;
            }
            if (errorProvider1.GetError(cboTipoLicenciaCopiloto) == "No puedes pilotar un Helicóptero con una Licencia de Avión")
            {
                return;
            }
            if (errorProvider1.GetError(cboTipoLicenciaCopiloto) == "No puedes pilotar un Avión con una Licencia de Helicóptero")
            {
                return;
            }
            if (errorProvider1.GetError(cboTipoLicencia) == "Dos estudiantes no pueden pilotar un tipo de Aeronave\nse necesita de un experto en compañia del estudiante")
            {
                return;
            }
            if (errorProvider1.GetError(cboTipoLicenciaCopiloto) == "Dos estudiantes no pueden pilotar un tipo de Aeronave\nse necesita de un experto en compañia del estudiante")
            {
                return;
            }
            if (errorProvider1.GetError(txtDescripcion) == "Debes dar una descripción")
            {
                return;
            }
            if (errorProvider1.GetError(txtRuta) == "Debes describir una Ruta")
            {
                return;
            }
            if (cboPiloto.Text != "Seleccione un Piloto" || cboCopiloto.Text != "Seleccione un Piloto")
            {
                if (cboPiloto.Text == cboCopiloto.Text)
                {
                    MessageBox.Show("El Piloto y el Copiloto deben ser diferentes", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (errorProvider1.GetError(cboPiloto) == "Debes Seleccionar un Piloto")
            {
                return;
            }
            if (errorProvider1.GetError(cboTipoLicencia) == "Debes Seleccionar un Piloto")
            {
                return;
            }
            if (errorProvider1.GetError(cboCopiloto) == "Debes Seleccionar un Copiloto")
            {
                return;
            }
            if (errorProvider1.GetError(cboTipoLicenciaCopiloto) == "Debes Seleccionar un Tipo de Licencia Para el Copiloto")
            {
                return;
            }
            if (errorProvider1.GetError(cboTipoAeronave) == "Debes Seleccionar un Tipo de Aeronave")
            {
                return;
            }
            if (errorProvider1.GetError(cboAeronave) == "Debes Seleccionar una Aeronave")
            {
                return;
            }
            if (errorProvider1.GetError(dtSalida) == "No puedes ingresar una fecha de Salida inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "")
            {
                return;
            }
            if (errorProvider1.GetError(dtLlegada) == "No puedes ingresar una fecha de Llegada inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "")
            {
                return;
            }
            if (errorProvider1.GetError(cboOrigenPais) == "Debes Seleccionar un País de Origen")
            {
                return;
            }
            if (errorProvider1.GetError(cboOrigenRegion) == "Debes Seleccionar una Región de Origen")
            {
                return;
            }
            if (errorProvider1.GetError(cboOrigenProvincia) == "Debes Seleccionar una Provincia de Origen")
            {
                return;
            }
            if (errorProvider1.GetError(cboOrigenComuna) == "Debes Seleccionar una Comuna de Origen")
            {
                return;
            }
            if (errorProvider1.GetError(cboOrigen) == "Debes Seleccionar un Origen")
            {
                return;
            }
            if (errorProvider1.GetError(cboDestinoPais) == "Debes Seleccionar un País de Destino")
            {
                return;
            }
            if (errorProvider1.GetError(cboDestinoRegion) == "Debes Seleccionar una Región de Destino")
            {
                return;
            }
            if (errorProvider1.GetError(cboDestinoProvincia) == "Debes Seleccionar una Provincia de Destino")
            {
                return;
            }
            if (errorProvider1.GetError(cboDestinoComuna) == "Debes Seleccionar una Comuna de Destino")
            {
                return;
            }
            if (errorProvider1.GetError(cboDestino) == "Debes Seleccionar un Destino")
            {
                return;
            }
            if (errorProvider1.GetError(cboCondicion) == "Debes Seleccionar una Condición")
            {
                return;
            }
            if (errorProvider1.GetError(cbMision) == "Debes Seleccionar una Misión")
            {
                return;
            }
            if (errorProvider1.GetError(dtLlegada) == "No puedes ingresar una fecha de Llegada inferior a la de Salida: " + dtSalida.Text + "")
            {
                return;
            }
            if (errorProvider1.GetError(dtHoraLlegada) == "Debes ingresar una hora de llegada mayor a la de salida: " + dtHoraSalida.Text + "")
            {
                return;
            }
            if (errorProvider1.GetError(dtHoraLlegada) == "No puedes ingresar una hora de llegada menor o igual a la de salida: " + dtHoraSalida.Text + "")
            {
                return;
            }
            
            /*************************************************************************** FIN VALIDAR SI EXISTEN ERRORES ***********************************/  

            /*VALIDAR SI PILOTO YA SE ENCUENTRA EN UN PLAN DE VUELO*/

           
            string sqlString2 = "" + (consultas.Variables.cboPilotoValidarRutPiloto) + "'" + cboPiloto.SelectedValue + "' " + (consultas.Variables.cboPilotoValidarRutPiloto2) + "'" + dtSalida.Text + dtHoraSalida.Text + ":00" + "'" + (consultas.Variables.cboPilotoValidarRutPiloto3) + "'" + dtLlegada.Text + dtHoraLlegada.Text + ":00" + "'" + (consultas.Variables.cboPilotoValidarRutPiloto4) + "'" + dtSalida.Text + dtHoraSalida.Text + ":00" + "'" + (consultas.Variables.cboPilotoValidarRutPiloto5) + "'" + dtLlegada.Text + dtHoraLlegada.Text + ":00" + "')";
            OracleCommand dbCmd2 = new OracleCommand(sqlString2, cnn);
            OracleDataReader reader2 = dbCmd2.ExecuteReader();
            /**/
            string sqlString3 = "" + (consultas.Variables.cboCoPilotoValidarRutPiloto) + "'" + cboCopiloto.SelectedValue + "' " + (consultas.Variables.cboCoPilotoValidarRutPiloto2) + "'" + dtSalida.Text + dtHoraSalida.Text + ":00" + "'" + (consultas.Variables.cboCoPilotoValidarRutPiloto3) + "'" + dtLlegada.Text + dtHoraLlegada.Text + ":00" + "'" + (consultas.Variables.cboCoPilotoValidarRutPiloto4) + "'" + dtSalida.Text + dtHoraSalida.Text + ":00" + "'" + (consultas.Variables.cboCoPilotoValidarRutPiloto5) + "'" + dtLlegada.Text + dtHoraLlegada.Text + ":00" + "')";
            OracleCommand dbCmd3 = new OracleCommand(sqlString3, cnn);
            OracleDataReader reader3 = dbCmd3.ExecuteReader();
            /**/
            /**/
            string sqlString4 = "" + (consultas.Variables.cboPilotoValidarRutCoPiloto) + "'" + cboPiloto.SelectedValue + "' " + (consultas.Variables.cboPilotoValidarRutCoPiloto2) + "'" + dtSalida.Text + dtHoraSalida.Text + ":00" + "'" + (consultas.Variables.cboPilotoValidarRutCoPiloto3) + "'" + dtLlegada.Text + dtHoraLlegada.Text + ":00" + "'" + (consultas.Variables.cboPilotoValidarRutCoPiloto4) + "'" + dtSalida.Text + dtHoraSalida.Text + ":00" + "'" + (consultas.Variables.cboPilotoValidarRutCoPiloto5) + "'" + dtLlegada.Text + dtHoraLlegada.Text + ":00" + "')";
            OracleCommand dbCmd4 = new OracleCommand(sqlString4, cnn);
            OracleDataReader reader4 = dbCmd4.ExecuteReader();
            /**/
            /**/
            string sqlString5 = "" + (consultas.Variables.cboCoPilotoValidarRutCoPiloto) + " '" + cboCopiloto.SelectedValue + "' " + (consultas.Variables.cboCoPilotoValidarRutCoPiloto2) + "'" + dtSalida.Text + dtHoraSalida.Text + ":00" + "'" + (consultas.Variables.cboCoPilotoValidarRutCoPiloto3) + "'" + dtLlegada.Text + dtHoraLlegada.Text + ":00" + "'" + (consultas.Variables.cboCoPilotoValidarRutCoPiloto4) + "'" + dtSalida.Text + dtHoraSalida.Text + ":00" + "'" + (consultas.Variables.cboCoPilotoValidarRutCoPiloto5) + "'" + dtLlegada.Text + dtHoraLlegada.Text + ":00" + "')";
            OracleCommand dbCmd5 = new OracleCommand(sqlString5, cnn);
            OracleDataReader reader5 = dbCmd5.ExecuteReader();
            /**/
            if (reader2.Read())
            {
                MessageBox.Show("El Piloto '" + cboPiloto.Text + "' ya se encuentra en un Plan de vuelo estimado \nentre las fechas y Horarios: '" + dtSalida.Text + "  " + dtHoraSalida.Text + "' - '" + dtLlegada.Text + " " +dtHoraLlegada.Text + "'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (reader3.Read())
            {
                MessageBox.Show("El Piloto '" + cboPiloto.Text + "' ya se encuentra en un Plan de vuelo estimado \nentre las fechas y Horarios: '" + dtSalida.Text + "  " + dtHoraSalida.Text + "' - '" + dtLlegada.Text + " " + dtHoraLlegada.Text + "'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (reader4.Read())
            {
                MessageBox.Show("El Copiloto '" + cboCopiloto.Text + "' ya se encuentra en un Plan de vuelo estimado \nentre las fechas y Horarios: '" + dtSalida.Text + "  " + dtHoraSalida.Text + "' - '" + dtLlegada.Text + " " + dtHoraLlegada.Text + "'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (reader5.Read())
            {
                MessageBox.Show("El Copiloto '" + cboCopiloto.Text + "' ya se encuentra en un Plan de vuelo estimado \nentre las fechas y Horarios: '" + dtSalida.Text + "  " + dtHoraSalida.Text + "' - '" + dtLlegada.Text + " " + dtHoraLlegada.Text + "'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
              
            
            /*FIN VALIDAR*/
            
            else
            {

                string sql = "" + (consultas.Variables.IngresoPlanVuelo) + " (id_vuelo.nextval,'" + Logica.PlanVuelo.Descripcion_ + "','" + Logica.PlanVuelo.FechaSalida_ + Logica.PlanVuelo.HoraSalida_ + ":00" + "','" + Logica.PlanVuelo.FechaLlegada_ + Logica.PlanVuelo.HoraLlegada_ + ":00" + "','" + Logica.PlanVuelo.Condicion_ + "', '" + Logica.PlanVuelo.Mision_ + "','" + Logica.PlanVuelo.Piloto_ + "','" + Logica.PlanVuelo.Copiloto_ + "','" + Logica.PlanVuelo.TipoLicenciaPiloto_ + "','" + Logica.PlanVuelo.TipoLicenciaCopiloto_ + "','" + Logica.PlanVuelo.Ruta_ + "','" + Logica.PlanVuelo.Destino_ + "','" + Logica.PlanVuelo.Origen_ + "','" + Logica.PlanVuelo.Aeronave_ + "')";
                if (obDAtos.insertar(sql))
                {
                    MessageBox.Show("Plan de Vuelo Registrado", "PLAN DE VUELO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al Registrar Plan de Vuelo","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

