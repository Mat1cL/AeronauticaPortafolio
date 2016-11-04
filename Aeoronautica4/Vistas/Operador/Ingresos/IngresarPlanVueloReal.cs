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

namespace Aeoronautica
{
    public partial class IngresarPlanVueloReal : Form
    {
        public IngresarPlanVueloReal()
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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealSelectCboCondicion) + "'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboCondicion.DataSource = dt;
                this.cboCondicion.DisplayMember = "nombre_condicion";
                this.cboCondicion.ValueMember = "id_condicion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void FillCbCondicionEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealSelectCboCondicionEdit) + "", conn);
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
                da = new OracleDataAdapter("select id_vuelo, id_mision, nombre_mision from plan_vuelo INNER JOIN mision ON plan_vuelo.MISION_ID_MISION = mision.id_mision where id_vuelo='" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cbMision.DataSource = dt;
                this.cbMision.DisplayMember = "nombre_mision";
                this.cbMision.ValueMember = "id_mision";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void FillCbMisionEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("Select * from mision", conn);
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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealCboTipoLicenciaPiloto) + "'" + this.cboPiloto.SelectedValue + "') " + (consultas.Variables.PlanVueloRealCboTipoLicenciaPiloto2) + "'" + this.cboPiloto.SelectedValue + "'" + (consultas.Variables.PlanVueloRealCboTipoLicenciaPiloto3) + "'" + this.txtID.Text + "' " + (consultas.Variables.PlanVueloRealCboTipoLicenciaPiloto4) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboTipoLicencia.DataSource = dt;
                this.cboTipoLicencia.DisplayMember = "nombre_tipo_licencia";
                this.cboTipoLicencia.ValueMember = "licencia_piloto";
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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealCboTipoLicenciaCopiloto) + "'" + this.cboCopiloto.SelectedValue + "') " + (consultas.Variables.PlanVueloRealCboTipoLicenciaCopiloto2) + "'" + this.cboCopiloto.SelectedValue + "' " + (consultas.Variables.PlanVueloRealCboTipoLicenciaCopiloto3) + "'" + this.txtID.Text + "' " + (consultas.Variables.PlanVueloRealCboTipoLicenciaCopiloto4) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboTipoLicenciaCopiloto.DataSource = dt;
                this.cboTipoLicenciaCopiloto.DisplayMember = "nombre_tipo_licencia";
                this.cboTipoLicenciaCopiloto.ValueMember = "licencia_copiloto";
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
                da = new OracleDataAdapter(""+(consultas.Variables.PlanVueloRealCboPiloto)+"'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();

                dt.Columns.Add("Concatenacion", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["Concatenacion"] = dr["nombre_piloto"].ToString() + " " + dr["apellido_paterno"].ToString() + " " + dr["apellido_materno"].ToString() + " - " + dr["piloto_rut_piloto"].ToString();
                }
                /*DataRow row = dt.NewRow();
                row["rut_piloto"] = Convert.ToInt32("0");
                row["Concatenacion"] = "Seleccione un Piloto";
                dt.Rows.InsertAt(row, 0);*/


                cboPiloto.DataSource = dt;
                cboPiloto.DisplayMember = "Concatenacion";
                cboPiloto.ValueMember = "piloto_rut_piloto";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Fin CargaPiloto

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
                da = new OracleDataAdapter(""+(consultas.Variables.PlanVueloRealCboCopiloto)+"'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();

                dt.Columns.Add("Concatenacion", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["Concatenacion"] = dr["nombre_piloto"].ToString() + " " + dr["apellido_paterno"].ToString() + " " + dr["apellido_materno"].ToString() + " - " + dr["rut_copiloto"].ToString();
                }
                /*DataRow row = dt.NewRow();
                row["rut_copiloto"] = Convert.ToInt32("0");
                row["Concatenacion"] = "Seleccione un Piloto";
                dt.Rows.InsertAt(row, 0);*/


                cboCopiloto.DataSource = dt;
                cboCopiloto.DisplayMember = "Concatenacion";
                cboCopiloto.ValueMember = "rut_copiloto";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Fin CargaCopiloto

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
                da = new OracleDataAdapter(""+(consultas.Variables.PlanVueloRealCboTipoAeronave)+"'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
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
                da = new OracleDataAdapter(""+(consultas.Variables.PlanVueloRealCboAeronave)+"'" + this.txtID.Text + "' "+(consultas.Variables.PlanVueloRealCboAeronave2)+"'" + this.cboTipoAeronave.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                dt.Columns.Add("Concatenacion", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["Concatenacion"] = dr["nombre_modelo"].ToString() + " - " + dr["aeronave_matricula"].ToString();
                }
                //DataRow row = dt.NewRow();
                //row["aeronave_matricula"] = Convert.ToInt32("0");
                //row["Concatenacion"] = "Seleccione una Aeronave";
                //dt.Rows.InsertAt(row, 0);
                this.cboAeronave.DataSource = dt;
                this.cboAeronave.DisplayMember = "Concatenacion";
                this.cboAeronave.ValueMember = "aeronave_matricula";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Fin CargaAeronave


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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealOrigenPais) + "'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                cboOrigenPais.DataSource = dt;
                cboOrigenPais.DisplayMember = "nombre_pais";
                cboOrigenPais.ValueMember = "nombre_pais";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbOrigenPaisEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealOrigenPaisEdit) + "", conn);
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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealOrigenRegion) + "'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboOrigenRegion.DataSource = dt;
                this.cboOrigenRegion.DisplayMember = "nombre_region";
                this.cboOrigenRegion.ValueMember = "nombre_region";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbOrigenRegionEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealOrigenRegionEdit) + "'" + this.cboOrigenPais.SelectedValue + "'", conn);
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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealOrigenProvincia) + "'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboOrigenProvincia.DataSource = dt;
                this.cboOrigenProvincia.DisplayMember = "nombre_provincia";
                this.cboOrigenProvincia.ValueMember = "nombre_provincia";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void FillCbOrigenProvinciaEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealOrigenProvinciaEdit) + "'" + this.cboOrigenRegion.SelectedValue + "'", conn);
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
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealOrigenComuna) + "'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboOrigenComuna.DataSource = dt;
                this.cboOrigenComuna.DisplayMember = "nombre_comuna";
                this.cboOrigenComuna.ValueMember = "nombre_comuna";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbOrigenComunaEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealOrigenComunaEdit) + "'" + this.cboOrigenProvincia.SelectedValue + "'", conn);
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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealOrigen) + "'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboOrigen.DataSource = dt;
                this.cboOrigen.DisplayMember = "nombre_origen";
                this.cboOrigen.ValueMember = "id_origen";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbOrigenEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealOrigenEdit) + "'" + this.cboOrigenComuna.SelectedValue + "'", conn);
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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealDestinoPais) + "'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                cboDestinoPais.DataSource = dt;
                cboDestinoPais.DisplayMember = "nombre_pais";
                cboDestinoPais.ValueMember = "nombre_pais";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void FillCbDestinoPaisEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealDestinoPaisEdit) + "", conn);
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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealDestinoRegion) + "'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboDestinoRegion.DataSource = dt;
                this.cboDestinoRegion.DisplayMember = "nombre_region";
                this.cboDestinoRegion.ValueMember = "nombre_region";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbDestinoRegionEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealDestinoRegionEdit) + "'" + this.cboDestinoPais.SelectedValue + "'", conn);
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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealDestinoProvincia) + "'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboDestinoProvincia.DataSource = dt;
                this.cboDestinoProvincia.DisplayMember = "nombre_provincia";
                this.cboDestinoProvincia.ValueMember = "nombre_provincia";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void FillCbDestinoProvinciaEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealDestinoProvinciaEdit) + "'" + this.cboDestinoRegion.SelectedValue + "'", conn);
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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealDestinoComuna) + "'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboDestinoComuna.DataSource = dt;
                this.cboDestinoComuna.DisplayMember = "nombre_comuna";
                this.cboDestinoComuna.ValueMember = "nombre_comuna";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void FillCbDestinoComunaEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealDestinoComunaEdit) + "'" + this.cboDestinoProvincia.SelectedValue + "'", conn);
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
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealFillCbDestino) + "'" + this.txtID.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboDestino.DataSource = dt;
                this.cboDestino.DisplayMember = "nombre_destino";
                this.cboDestino.ValueMember = "id_destino";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbDestinoEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.PlanVueloRealFillCbDestinoEdit) + "'" + this.cboDestinoComuna.SelectedValue + "'", conn);
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
            cboPilotoHoras.Enabled = false;
            cboCopilotoHoras.Enabled = false;
            cboPilotoMinutos.Enabled = false;
            cboCopilotoMinutos.Enabled = false;
            txtDescripcion.Enabled = false;
            txtRuta.Enabled = false;
            this.cboPilotoHoras.SelectedIndex = 0;
            this.cboPilotoMinutos.SelectedIndex = 0;
            this.cboCopilotoHoras.SelectedIndex = 0;
            this.cboCopilotoMinutos.SelectedIndex = 0;
            dtHoraLlegada.Enabled = false;
            dtHoraSalida.Enabled = false;
            dtLlegada.Enabled = false;
            dtSalida.Enabled = false;
            cboPiloto.Enabled = false;
            cboCopiloto.Enabled = false;
            cboTipoAeronave.Enabled = false;
            cboAeronave.Enabled = false;
            cboTipoLicencia.Enabled = false;
            cboTipoLicenciaCopiloto.Enabled = false;
            dtTaxeoLlegada.Enabled = false;
            dtTaxeoSalida.Enabled = false;
            dtHoraSalida.Enabled = false;
            dtHoraLlegada.Enabled = false;
            //dtHorasPiloto.Enabled = false;
            //dtHorasCopiloto.Enabled = false;
            dtSalida.Enabled = false;
            dtLlegada.Enabled = false;
            btnCambiarOrigen.Enabled = false;
            btnCambiarDestino.Enabled = false;
            btnCambiarMision.Enabled = false;
            btnCambiarCondicion.Enabled = false;
            btnCambiarHoraSalida.Enabled = false;
            btnCambiarHoraLlegada.Enabled = false;
            btnCambiarFechaLlegada.Enabled = false;
            btnCambiarFechaSalida.Enabled = false;
            btnCambiarRuta.Enabled = false;
            btnCambiarDescripcion.Enabled = false;
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
            if (cboPiloto.Text == cboCopiloto.Text)
            {
                MessageBox.Show("El Piloto y el Copiloto deben ser diferentes");
            }
            else
            {

                if (cboPiloto.Text == cboCopiloto.Text)
                {
                    MessageBox.Show("El Piloto y el Copiloto deben ser diferentes");
                }
                else
                {

                    OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
                    cnn.Open();
                    string sqlString2 = "" + (consultas.Variables.VerificarIDVuelo) + "'" + txtID.Text + "'";
                    OracleCommand dbCmdx2 = new OracleCommand(sqlString2, cnn);
                    OracleDataReader reader = dbCmdx2.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("El 'ID' ya se encuentra registrado en Plan de Vuelo Real");
                    }
                    else
                    {
                        string sql = "" + (consultas.Variables.InsertPlanVueloReal) + " (id_plan_vuelo_real.nextval,'" + this.txtDescripcion.Text + "','" + this.dtSalida.Text + this.dtHoraSalida.Text + ":00" + "','" + this.dtLlegada.Text + this.dtHoraLlegada.Text + ":00" + "','" + "01/01/2001" + this.dtTaxeoSalida.Text + ":00" + "','" + "01/01/2001" + this.dtTaxeoLlegada.Text + ":00" + "','" + this.cboPiloto.SelectedValue + "','" + this.cboCopiloto.SelectedValue + "','" + this.cboTipoLicencia.SelectedValue + "','" + this.cboTipoLicenciaCopiloto.SelectedValue + "','" + this.cboPilotoHoras.Text + "','" + this.cboCopilotoHoras.Text + "','" + this.cboPilotoMinutos.Text + "','" + this.cboCopilotoMinutos.Text + "','"+this.txtRuta.Text+"','" + this.cboOrigen.SelectedValue + "','" + this.cboDestino.SelectedValue + "','" + this.cboAeronave.SelectedValue + "','" + this.cbMision.SelectedValue + "','" + this.cboCondicion.SelectedValue + "','" + this.txtID.Text + "')";
                        if (obDAtos.insertar(sql))
                        {
                            MessageBox.Show("Vuelo Registrado");
                        }
                        else
                        {
                            MessageBox.Show("Error al Registrar Plan de Vuelo");
                        }
                    }



                }


            }

        }

        private void cboPiloto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cboOrigenPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbOrigenRegionEdit();
        }

        private void cboOrigenRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbOrigenProvinciaEdit();
        }

        private void cboOrigenProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbOrigenComunaEdit();
        }

        private void cboOrigenComuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbOrigenEdit();
        }

        private void cboDestinoComuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbDestinoEdit();
        }

        private void cboDestinoPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbDestinoRegionEdit();
        }

        private void cboDestinoRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbDestinoProvinciaEdit();
        }

        private void cboDestinoProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbDestinoComunaEdit();
        }

        private void cboCopiloto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoAeronave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPiloto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtHoraSalida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtID.Text))
            {
                MessageBox.Show("Debes Ingresar un ID de Plan de Vuelo");
                return;

            }
            else
            {

                OracleDataReader reader = null;
                OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
                OracleCommand dbCmdx2 = new OracleCommand("" + (consultas.Variables.BtnConsultar) + "'" + txtID.Text + "'", cnn);
                cnn.Open();
                try
                {
                    reader = dbCmdx2.ExecuteReader();
                    if (reader.Read())
                    {
                        txtDescripcion.Enabled = false;
                        dtHoraLlegada.Enabled = false;
                        dtHoraSalida.Enabled = false;
                        dtLlegada.Enabled = false;
                        dtSalida.Enabled = false;
                        txtID.Enabled = false;
                        dtTaxeoSalida.Enabled = true;
                        dtTaxeoLlegada.Enabled = true;
                        cboPilotoHoras.Enabled = true;
                        cboPilotoMinutos.Enabled = true;
                        cboCopilotoHoras.Enabled = true;
                        cboCopilotoMinutos.Enabled = true;
                        //dtHorasPiloto.Enabled = true;
                        //dtHorasCopiloto.Enabled = true;

                        dtLlegada.Text = reader["FECHA_DESTINO_ESTIMADA"].ToString();

                        dtHoraSalida.Text = reader["FECHA_ORIGEN_ESTIMADA"].ToString();
                        dtSalida.Text = reader["FECHA_ORIGEN_ESTIMADA"].ToString();

                        dtHoraLlegada.Text = reader["FECHA_DESTINO_ESTIMADA"].ToString();
                        txtRuta.Enabled = false;
                        txtDescripcion.Text = reader["DESCRIPCION"].ToString();
                        txtRuta.Text = reader["RUTA"].ToString();
                        btnCambiarOrigen.Enabled = true;
                        btnCambiarDestino.Enabled = true;
                        btnCambiarMision.Enabled = true;
                        btnCambiarCondicion.Enabled = true;
                        FillCbPiloto();
                        FillCbCoPiloto();
                        FillCbTipoLicencia();
                        FillCbTipoLicencia2();
                        FillCbTipoAeronave();
                        FillCbAeronave();
                        FillCbOrigenPais();
                        cboOrigenPais.Enabled = false;
                        FillCbOrigenRegion();
                        cboOrigenRegion.Enabled = false;
                        FillCbOrigenProvincia();
                        cboOrigenProvincia.Enabled = false;
                        FillCbOrigenComuna();
                        cboOrigenComuna.Enabled = false;
                        FillCbOrigen();
                        cboOrigen.Enabled = false;
                        FillCbDestinoPais();
                        cboDestinoPais.Enabled = false;
                        FillCbDestinoRegion();
                        cboDestinoRegion.Enabled = false;
                        FillCbDestinoProvincia();
                        cboDestinoProvincia.Enabled = false;
                        FillCbDestinoComuna();
                        cboDestinoComuna.Enabled = false;
                        FillCbDestino();
                        cboDestino.Enabled = false;
                        FillCbCondicion();
                        cboCondicion.Enabled = false;
                        FillCbMision();
                        cbMision.Enabled = false;
                        btnCambiarHoraSalida.Enabled = true;
                        btnCambiarHoraLlegada.Enabled = true;
                        btnCambiarFechaLlegada.Enabled = true;
                        btnCambiarFechaSalida.Enabled = true;
                        btnCambiarRuta.Enabled = true;
                        btnCambiarDescripcion.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El 'ID' no se encuentra asignado a un Plan de Vuelo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }



        }

        private void btnCambiarOrigen_Click(object sender, EventArgs e)
        {
            FillCbOrigenPaisEdit();
            cboOrigenPais.Enabled = true;
            FillCbOrigenRegionEdit();
            cboOrigenRegion.Enabled = true;
            FillCbOrigenProvinciaEdit();
            cboOrigenProvincia.Enabled = true;
            FillCbOrigenComunaEdit();
            cboOrigenComuna.Enabled = true;
            FillCbOrigenEdit();
            cboOrigen.Enabled = true;


        }

        private void btnCambiarDestino_Click(object sender, EventArgs e)
        {
            FillCbDestinoPaisEdit();
            cboDestinoPais.Enabled = true;
            FillCbDestinoRegionEdit();
            cboDestinoRegion.Enabled = true;
            FillCbDestinoProvinciaEdit();
            cboDestinoProvincia.Enabled = true;
            FillCbDestinoComunaEdit();
            cboDestinoComuna.Enabled = true;
            FillCbDestinoEdit();
            cboDestino.Enabled = true;
        }

        private void btnCambiarCondicion_Click(object sender, EventArgs e)
        {
            FillCbCondicionEdit();
            cboCondicion.Enabled = true;

        }

        private void btnCambiarMision_Click(object sender, EventArgs e)
        {
            FillCbMisionEdit();
            cbMision.Enabled = true;
        }

        private void dtHorasCopiloto_ValueChanged(object sender, EventArgs e)
        {

        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnCambiarRuta.Enabled = false;
            btnCambiarHoraSalida.Enabled = false;
            btnCambiarHoraLlegada.Enabled = false;
            btnCambiarFechaLlegada.Enabled = false;
            btnCambiarFechaSalida.Enabled = false;
            btnCambiarDescripcion.Enabled = false;
            /*FormClosed += (o, a) => new IngresarPlanVueloReal().ShowDialog();
            Hide();
            Close();*/
            txtID.Enabled = true;
            btnConsultar.Enabled = true;

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
            /* if (dtHorasPiloto != null)
             {
                 dtHorasPiloto.Text = "00:00";
             }
             if (dtHorasCopiloto != null)
             {
                 dtHorasCopiloto.Text = "00:00";
             }*/
            if (dtTaxeoSalida != null)
            {
                dtTaxeoSalida.Text = "00:00";
            }
            if (dtTaxeoLlegada != null)
            {
                dtTaxeoLlegada.Text = "00:00";
            }

            txtDescripcion.Enabled = false;
            txtRuta.Enabled = false;
            dtTaxeoSalida.Enabled = false;
            dtTaxeoLlegada.Enabled = false;

            cboPilotoHoras.Enabled = false;
            cboPilotoHoras.Text = "0";
            cboCopilotoHoras.Enabled = false;
            cboCopilotoHoras.Text = "0";
            cboPilotoMinutos.Enabled = false;
            cboPilotoMinutos.Text = "0";
            cboCopilotoMinutos.Enabled = false;
            cboCopilotoMinutos.Text = "0";
            //dtHorasPiloto.Enabled = false;
            //dtHorasCopiloto.Enabled = false;
            dtSalida.Enabled = false;
            dtLlegada.Enabled = false;
            dtHoraSalida.Enabled = false;
            dtHoraLlegada.Enabled = false;

            btnCambiarOrigen.Enabled = false;
            btnCambiarDestino.Enabled = false;
            btnCambiarMision.Enabled = false;
            btnCambiarCondicion.Enabled = false;

    

            txtID.Clear();
            txtRuta.Clear();
            txtDescripcion.Clear();
            cboPiloto.DataSource = null;
            cboPiloto.Items.Clear();
            cboTipoLicencia.DataSource = null;
            cboTipoLicencia.Items.Clear();
            cboCopiloto.DataSource = null;
            cboCopiloto.Items.Clear();
            cboTipoLicenciaCopiloto.DataSource = null;
            cboTipoLicenciaCopiloto.Items.Clear();
            cboTipoAeronave.DataSource = null;
            cboTipoAeronave.Items.Clear();
            cboAeronave.DataSource = null;
            cboAeronave.Items.Clear();
            cboOrigenPais.DataSource = null;
            cboOrigenPais.Items.Clear();
            cboOrigenRegion.DataSource = null;
            cboOrigenRegion.Items.Clear();
            cboOrigenProvincia.DataSource = null;
            cboOrigenProvincia.Items.Clear();
            cboOrigenComuna.DataSource = null;
            cboOrigenComuna.Items.Clear();
            cboOrigen.DataSource = null;
            cboOrigen.Items.Clear();
            cboDestinoPais.DataSource = null;
            cboDestinoPais.Items.Clear();
            cboDestinoRegion.DataSource = null;
            cboDestinoRegion.Items.Clear();
            cboDestinoProvincia.DataSource = null;
            cboDestinoProvincia.Items.Clear();
            cboDestinoComuna.DataSource = null;
            cboDestinoComuna.Items.Clear();
            cboDestino.DataSource = null;
            cboDestino.Items.Clear();
            cboCondicion.DataSource = null;
            cboCondicion.Items.Clear();
            cbMision.DataSource = null;
            cbMision.Items.Clear();


        }

        private void cboPilotoHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumeros(e);
            if (cboPilotoHoras.Text == "0")
            {
                cboPilotoHoras.MaxLength = 1;
            }
            else
            {
                cboPilotoHoras.MaxLength = 2;
            }

        }

        private void cboPilotoMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {

            datos.SoloNumeros(e);
            if (cboPilotoHoras.Text == "0")
            {
                cboPilotoHoras.MaxLength = 1;
            }
            else
            {
                cboPilotoHoras.MaxLength = 2;
            }
        }

        private void cboPilotoHoras_Validated(object sender, EventArgs e)
        {
            if (cboPilotoHoras.Text == "")
            {
                MessageBox.Show("No se acepta espacio en blanco");
                cboPilotoHoras.Text = "0";
            }
            else
            {
                ComboBox tb = sender as ComboBox;
                if (tb != null)
                {
                    int i;
                    if (int.TryParse(tb.Text, out i))
                    {
                        if (i >= 0 && i <= 16)
                            return;
                    }
                }
                MessageBox.Show("Las horas no pueden ser mayor a '16'");
                cboPilotoHoras.Text = "0";
            }


        }

        private void cboPilotoMinutos_Validated(object sender, EventArgs e)
        {
            if (cboPilotoMinutos.Text == "")
            {
                MessageBox.Show("No se acepta espacio en blanco");
                cboPilotoMinutos.Text = "0";
            }
            else
            {
                ComboBox tb = sender as ComboBox;
                if (tb != null)
                {
                    int i;
                    if (int.TryParse(tb.Text, out i))
                    {
                        if (i >= 0 && i <= 60)
                            return;
                    }
                }
                MessageBox.Show("Los minutos no pueden ser mayor a '60'");
                cboPilotoMinutos.Text = "0";
            }

        }

        private void cboPilotoMinutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCopilotoHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumeros(e);
            if (cboCopilotoHoras.Text == "0")
            {
                cboCopilotoHoras.MaxLength = 1;
            }
            else
            {
                cboCopilotoHoras.MaxLength = 2;
            }
        }

        private void cboCopilotoHoras_Validated(object sender, EventArgs e)
        {
            if (cboCopilotoHoras.Text == "")
            {
                MessageBox.Show("No se acepta espacio en blanco");
                cboCopilotoHoras.Text = "0";
            }
            else
            {
                ComboBox tb = sender as ComboBox;
                if (tb != null)
                {
                    int i;
                    if (int.TryParse(tb.Text, out i))
                    {
                        if (i >= 0 && i <= 16)
                            return;
                    }
                }
                MessageBox.Show("Las horas no pueden ser mayor a '16'");
                cboCopilotoHoras.Text = "0";
            }



        }

        private void cboCopilotoMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumeros(e);
            if (cboCopilotoMinutos.Text == "0")
            {
                cboCopilotoMinutos.MaxLength = 1;
            }
            else
            {
                cboCopilotoMinutos.MaxLength = 2;
            }
        }

        private void cboCopilotoMinutos_Validated(object sender, EventArgs e)
        {
            if (cboCopilotoMinutos.Text == "")
            {
                MessageBox.Show("No se acepta espacio en blanco");
                cboCopilotoMinutos.Text = "0";
            }
            else
            {
                ComboBox tb = sender as ComboBox;
                if (tb != null)
                {
                    int i;
                    if (int.TryParse(tb.Text, out i))
                    {
                        if (i >= 0 && i <= 60)
                            return;
                    }
                }
                MessageBox.Show("Los minutos no pueden ser mayor a '60'");
                cboCopilotoMinutos.Text = "0";
            }

        }

        private void btnCambiarFechaSalida_Click(object sender, EventArgs e)
        {
            dtSalida.Enabled = true;
        }

        private void btnCambiarFechaLlegada_Click(object sender, EventArgs e)
        {
            dtLlegada.Enabled = true;
        }

        private void btnCambiarHoraSalida_Click(object sender, EventArgs e)
        {
            dtHoraSalida.Enabled = true;
        }

        private void btnCambiarRuta_Click(object sender, EventArgs e)
        {
            txtRuta.Enabled = true;
        }

        private void btnCambiarDescripcion_Click(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = true;
        }
        private void btnCambiarHoraLlegada_Click(object sender, EventArgs e)
        {
            dtHoraLlegada.Enabled = true;
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                conn.Open();
                OracleCommand cmd = new OracleCommand("" + (consultas.Variables.BtnVuelos) + "", conn);
                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dgvVuelos.DataSource = ds.Tables[0];
                dgvVuelos.AllowUserToResizeColumns = false;
                dgvVuelos.AllowUserToResizeRows = false;
                dgvVuelos.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void dgvVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

