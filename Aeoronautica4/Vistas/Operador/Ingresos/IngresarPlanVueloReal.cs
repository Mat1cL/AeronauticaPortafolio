using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
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
                da = new OracleDataAdapter(""+(consultas.Variables.PlanVueloRealCboMision)+"'" + this.txtID.Text + "'", conn);
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
                da = new OracleDataAdapter(""+(consultas.Variables.PlanVueloRealCboMisionEdit)+"", conn);
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

        //CargaTipoLicenciaEdit

        void FillCbTipoLicenciaEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.LicenciaPilotoEdit)+" '"+cboPiloto.SelectedValue+"'", conn);
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

        //FinCargaTipoLicenciaEdit

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

        //CargaTipoLicenciaEdit

        void FillCbTipoLicencia2Edit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.LicenciaCopilotoEdit)+" '" + cboCopiloto.SelectedValue + "'", conn);
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

        //FinCargaTipoLicenciaEdit

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

        //EditCargaPiloto
        void FillCbPilotoEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectAllPilotos_)+"", conn);
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
                FillCbTipoLicenciaEdit();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //FinEditCargaPiloto

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

        //Cambiar Copiloto
        void FillCbCoPilotoEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.SelectAllPilotos_) + "", conn);
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
                FillCbTipoLicencia2Edit();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        //Fin Cambiar Copiloto

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
        string matricula = "";
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
                    matricula = dr["aeronave_matricula"].ToString();
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
        public static string xD;

        private void VistaOperadorIngresarVuelo_Load(object sender, EventArgs e)
        {
            dtLlegada2.Hide();
            dtSalida2.Hide();
            btnVolveraConsultar.Hide();
            /*
            int suma = 0;
            suma += Convert.ToInt32(cboPilotoHoras.Text) * 60;
            suma += Convert.ToInt32(cbo);
            int hrs = suma / 60;
            int min = suma %= 60;
            dgvListaPiloto3.Rows[n].Cells[1].Value = hrs.ToString();
            dgvListaPiloto3.Rows[n].Cells[2].Value = min.ToString();*/
            btnCambiarCopiloto.Enabled = false;
            btnCambiarPiloto.Enabled = false;
            btnCambiarLicenciaCopiloto.Enabled = false;
            btnCambiarLicenciaPiloto.Enabled = false;
            btnFiltrar.Enabled = false;
            dtDesde.Enabled = false;
            dtHasta.Enabled = false;
            dtHoraSalida2.Hide();
            dtHoraLlegada2.Hide();
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
        public static string LicenciaPiloto;
        public static string LicenciaCopiloto;
        datos obDAtos = new datos();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Logica.Clases.PlanVueloReal.ID_ = txtID.Text;
            Logica.Clases.PlanVueloReal.PilotoHoras_ = cboPilotoHoras.Text;
            Logica.Clases.PlanVueloReal.PilotoMinutos_ = cboPilotoMinutos.Text;
            Logica.Clases.PlanVueloReal.CopilotoHoras_ = cboCopilotoHoras.Text;
            Logica.Clases.PlanVueloReal.CopilotoMinutos_ = cboCopilotoMinutos.Text;
            Logica.Clases.PlanVueloReal.Descripcion_ = txtDescripcion.Text;
            Logica.Clases.PlanVueloReal.FechaSalida_ = dtSalida.Text;
            Logica.Clases.PlanVueloReal.HoraSalida_ = dtHoraSalida.Text;
            Logica.Clases.PlanVueloReal.FechaLlegada_ = dtLlegada.Text;
            Logica.Clases.PlanVueloReal.HoraLlegada_ = dtHoraLlegada.Text;
            Logica.Clases.PlanVueloReal.TaxeoSalida_ = dtTaxeoSalida.Text;
            Logica.Clases.PlanVueloReal.TaxeoLlegada_ = dtTaxeoLlegada.Text;
            Logica.Clases.PlanVueloReal.Condicion_ = cboCondicion.SelectedValue.ToString();
            Logica.Clases.PlanVueloReal.Mision_ = cbMision.SelectedValue.ToString();
            Logica.Clases.PlanVueloReal.Piloto_ = cboPiloto.SelectedValue.ToString();
            Logica.Clases.PlanVueloReal.Copiloto_ = cboCopiloto.SelectedValue.ToString();
            Logica.Clases.PlanVueloReal.TipoLicenciaPiloto_ = cboTipoLicencia.SelectedValue.ToString();
            Logica.Clases.PlanVueloReal.TipoLicenciaCopiloto_ = cboTipoLicenciaCopiloto.SelectedValue.ToString();
            Logica.Clases.PlanVueloReal.Ruta_ = txtRuta.Text;
            Logica.Clases.PlanVueloReal.Destino_ = cboDestino.SelectedValue.ToString();
            Logica.Clases.PlanVueloReal.Origen_ = cboOrigen.SelectedValue.ToString();
            Logica.Clases.PlanVueloReal.Aeronave_ = cboAeronave.SelectedValue.ToString();

            if (string.IsNullOrWhiteSpace(this.txtDescripcion.Text) || string.IsNullOrWhiteSpace(this.txtRuta.Text))
            {
                MessageBox.Show("Debes completar los campos...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboPiloto.Text == "Seleccione un Piloto")
            {
                MessageBox.Show("Debes Seleccionar un Piloto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboTipoLicencia.Text == "Seleccione un Tipo de Licencia")
            {
                MessageBox.Show("Debes Seleccionar un Tipo de Licencia Para el Piloto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboCopiloto.Text == "Seleccione un Piloto")
            {
                MessageBox.Show("Debes Seleccionar un Copiloto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboTipoLicenciaCopiloto.Text == "Seleccione un Tipo de Licencia")
            {
                MessageBox.Show("Debes Seleccionar un Tipo de Licencia Para el Copiloto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboTipoAeronave.Text == "Seleccione un Tipo de Aeronave")
            {
                MessageBox.Show("Debes Seleccionar un Tipo de Aeronave", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboAeronave.Text == "Seleccione una Aeronave")
            {
                MessageBox.Show("Debes Seleccionar una Aeronave", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dtSalida.Value > dtLlegada.Value)
            {
                MessageBox.Show("No puedes ingresar una fecha de Llegada \n inferior a la de Salida: " + dtSalida.Text + "", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OracleConnection cnn = new OracleConnection(consultas.Variables.ConString);
            cnn.Open();
            string sqlStringx = ""+(consultas.Variables.ValidarLicenciaPilotoPVR1)+" '" + cboPiloto.SelectedValue + "' "+(consultas.Variables.ValidarLicenciaPilotoPVR2)+" '" + cboTipoLicencia.Text + "'";
            OracleDataReader dr = null;
            OracleCommand cmd = new OracleCommand(sqlStringx, cnn);
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                LicenciaPiloto = dr["LICENCIA"].ToString();
            }
            string sqlStringx2 = ""+(consultas.Variables.ValidarLicenciaCopilotoPVR1)+" '" + cboCopiloto.SelectedValue + "' "+(consultas.Variables.ValidarLicenciaCopilotoPVR2)+" '" + cboTipoLicenciaCopiloto.Text + "'";
            OracleDataReader dr2 = null;
            OracleCommand cmd2 = new OracleCommand(sqlStringx2, cnn);
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read() == true)
            {
                LicenciaCopiloto = dr2["LICENCIA"].ToString();
            }
                
            if (LicenciaPiloto == "2")
            {

                if (cboTipoAeronave.SelectedValue.ToString() == "Helicóptero")
                {
                    MessageBox.Show("Piloto '" + cboPiloto.Text + "'\nNo puedes pilotar un Helicóptero con una Licencia de Avión", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            if (LicenciaPiloto == "3")
            {
                if (cboTipoAeronave.SelectedValue.ToString() == "Avión")
                {
                    MessageBox.Show("Piloto '" + cboPiloto.Text + "'\nNo puedes pilotar un Avión con una Licencia de Helicóptero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            //*/

            if (LicenciaCopiloto == "2")
            {

                if (cboTipoAeronave.SelectedValue.ToString() == "Helicóptero")
                {
                    MessageBox.Show("Coiloto '" + cboCopiloto.Text + "'\nNo puedes pilotar un Helicóptero con una Licencia de Avión", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            if (LicenciaCopiloto == "3")
            {
                if (cboTipoAeronave.SelectedValue.ToString() == "Avión")
                {
                    MessageBox.Show("Copiloto '" + cboCopiloto.Text + "'\nNo puedes pilotar un Avión con una Licencia de Helicóptero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

            /**/

            

            if (LicenciaPiloto == "1" && LicenciaCopiloto == "1")
            {
                MessageBox.Show("Dos estudiantes no pueden pilotar un tipo de Aeronave\nSe necesita de un experto en compañia del estudiante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (dtSalida.Text == dtLlegada.Text)
            {
                dtHoraLlegada2 = dtHoraLlegada;
                dtHoraSalida2 = dtHoraSalida;
                var dtsalidastring = dtHoraSalida2.Value.ToString("HH:mm");
                var dtllegadastring = dtHoraLlegada2.Value.ToString("HH:mm");
                DateTime dtHoraSalida2x = DateTime.ParseExact(dtsalidastring, "HH:mm", CultureInfo.InvariantCulture);
                DateTime dtHoraLlegada2x = DateTime.ParseExact(dtllegadastring, "HH:mm", CultureInfo.InvariantCulture);
                if (dtHoraLlegada2x < dtHoraSalida2x)
                {

                    MessageBox.Show("No puedes ingresar una hora de llegada menor o igual \n a la de salida: " + dtHoraSalida.Text + "", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (dtHoraLlegada2x == dtHoraSalida2x)
                {

                    MessageBox.Show("Debes ingresar una hora de llegada mayor a \n la de salida: " + dtHoraSalida.Text + "", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
              

            }

            /*VALIDAR INGRESO DE HORAS DE VUELO PILOTOS*/

            int cboPilotoHorasx = 0;
            int cboCoPilotoHorasx = 0;
            int xd;
            cboPilotoHorasx = Convert.ToInt32(cboPilotoHoras.Text);
            cboCoPilotoHorasx = Convert.ToInt32(cboCopilotoHoras.Text);
            xd = cboPilotoHorasx + cboCoPilotoHorasx;


            int cboPilotoMinutosx = 0;
            int cboCoPilotoMinutosx = 0;
            int xdd;
            cboPilotoMinutosx = Convert.ToInt32(cboPilotoMinutos.Text);
            cboCoPilotoMinutosx = Convert.ToInt32(cboCopilotoMinutos.Text);
            xdd = cboPilotoMinutosx + cboCoPilotoMinutosx;



            int suma = 0;
            suma += Convert.ToInt32(xd) * 60;
            suma += Convert.ToInt32(xdd);
            int hrs = suma / 60;
            int min = suma %= 60;
            /**************/

            dtHoraLlegada2 = dtHoraLlegada;
            dtHoraSalida2 = dtHoraSalida;


            string sd = dtSalida.Value.ToString("'" + dtSalida.Text + "' '" + dtHoraSalida.Text + ":00'");
            string sd2 = dtSalida.Value.ToString("'" + dtLlegada.Text + "' '" + dtHoraLlegada.Text + ":00'");


            DateTime myDate = DateTime.ParseExact(sd, "dd/MM/yyyy HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);

            DateTime myDate2 = DateTime.ParseExact(sd2, "dd/MM/yyyy HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);




            TimeSpan diff = myDate2.Subtract(myDate);
            TimeSpan diff1;
            diff1 = myDate2 - myDate;

            if (diff1.TotalHours > 23.99)
            {
                string span;
                string span2;

                span = diff1.ToString().Split('.')[0];
                span2 = diff1.ToString().Substring(diff1.ToString().IndexOf('.') + 1);

                int Horas = Convert.ToInt32(span) * 24;

                string str2;
                str2 = span2.Substring(0, 2);
                string str3;
                str3 = span2.Remove(span2.Length - 3);
                string aux;
                aux = str3.Substring(3);

                int HorasSub = Convert.ToInt32(str2);
                int HorasFinal = HorasSub + Horas;
                //label39.Text = HorasFinal.ToString();
                //label40.Text = aux.ToString();

                string AddHoras;
                string AddMinutos;

                if (hrs.ToString().Length == 1 && min.ToString().Length == 1)
                {
                    AddHoras = "0" + hrs.ToString();
                    //label41.Text = AddHoras.ToString();
                    AddMinutos = "0" + min.ToString();
                    //label33.Text = AddMinutos.ToString();

                    if (HorasFinal.ToString() == AddHoras && aux.ToString() == AddMinutos.ToString())
                    {

                    }
                    else
                    {
                        MessageBox.Show("Las horas de vuelo de Piloto y Copiloto\nNo coinciden con las del Plan de Vuelo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                else if (min.ToString().Length == 1)
                {
                    AddMinutos = "0" + min.ToString();
                    //label33.Text = AddMinutos.ToString();

                    if (hrs.ToString() == HorasFinal.ToString() && AddMinutos.ToString() == aux.ToString())
                    {

                    }
                    else
                    {
                        MessageBox.Show("Las horas de vuelo de Piloto y Copiloto\nNo coinciden con las del Plan de Vuelo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (hrs.ToString() == HorasFinal.ToString() && min.ToString() == aux.ToString())
                {

                }
                else
                {
                    MessageBox.Show("Las horas de vuelo de Piloto y Copiloto\nNo coinciden con las del Plan de Vuelo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }




            }
            else
            {
                string strHoras;
                strHoras = diff1.ToString().Remove(diff1.ToString().Length - 6);
                string str5;
                str5 = diff1.ToString().Remove(diff1.ToString().Length - 3);
                string strMinutos;
                strMinutos = str5.ToString().Substring(3);
                //label38.Text = strHoras.ToString();
                //label37.Text = strMinutos.ToString();


                string AddHoras;
                string AddMinutos;

                if (hrs.ToString().Length == 1 && min.ToString().Length == 1)
                {
                    AddHoras = "0" + hrs.ToString();
                    //label41.Text = AddHoras.ToString();
                    AddMinutos = "0" + min.ToString();
                    //label33.Text = AddMinutos.ToString();

                    if (strHoras.ToString() == AddHoras && strMinutos.ToString() == AddMinutos.ToString())
                    {

                    }
                    else
                    {
                        MessageBox.Show("Las horas de vuelo de Piloto y Copiloto\nNo coinciden con las del Plan de Vuelo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                else if (min.ToString().Length == 1)
                {
                    AddMinutos = "0" + min.ToString();
                    //label33.Text = AddMinutos.ToString();

                    if (hrs.ToString() == strHoras.ToString() && AddMinutos.ToString() == strMinutos.ToString())
                    {

                    }
                    else
                    {
                        MessageBox.Show("Las horas de vuelo de Piloto y Copiloto\nNo coinciden con las del Plan de Vuelo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                else if (hrs.ToString() == strHoras.ToString() && min.ToString() == strMinutos.ToString())
                {

                }
                else
                {
                    MessageBox.Show("Las horas de vuelo de Piloto y Copiloto\nNo coinciden con las del Plan de Vuelo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }


            /*VALIDAR INGRESO DE HORAS DE VUELO PILOTOS*/
            if (cboOrigenPais.Text == "Seleccione un País")
            {
                MessageBox.Show("Debes Seleccionar un País de Origen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboOrigenRegion.Text == "Seleccione una Región")
            {
                MessageBox.Show("Debes Seleccionar una Región de Origen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboOrigenProvincia.Text == "Seleccione una Provincia")
            {
                MessageBox.Show("Debes Seleccionar una Provincia de Origen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboOrigenComuna.Text == "Seleccione una Comuna")
            {
                MessageBox.Show("Debes Seleccionar una Comuna de Origen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboOrigen.Text == "Seleccione Origen")
            {
                MessageBox.Show("Debes Seleccionar un Origen", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboDestinoPais.Text == "Seleccione un País")
            {
                MessageBox.Show("Debes Seleccionar un País de Destino", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboDestinoRegion.Text == "Seleccione una Región")
            {
                MessageBox.Show("Debes Seleccionar una Región de Destino", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboDestinoProvincia.Text == "Seleccione una Provincia")
            {
                MessageBox.Show("Debes Seleccionar una Provincia de Destino", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboDestinoComuna.Text == "Seleccione una Comuna")
            {
                MessageBox.Show("Debes Seleccionar una Comuna de Destino", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboDestino.Text == "Seleccione Destino")
            {
                MessageBox.Show("Debes Seleccionar un Destino", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cboCondicion.Text == "Seleccione una Condición")
            {
                MessageBox.Show("Debes Seleccionar una Condición", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbMision.Text == "Seleccione una Misión")
            {
                MessageBox.Show("Debes Seleccionar una Misión", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboPiloto.Text == cboCopiloto.Text)
            {
                return;
            }
            else
            {

                if (cboPiloto.Text == cboCopiloto.Text)
                {
                    MessageBox.Show("El Piloto y el Copiloto deben ser diferentes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    
                    
                    string sqlString2 = "" + (consultas.Variables.VerificarIDVuelo) + "'" + Logica.Clases.PlanVueloReal.ID_ + "'";
                    OracleCommand dbCmdx2 = new OracleCommand(sqlString2, cnn);
                    OracleDataReader reader = dbCmdx2.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("El 'ID' ya se encuentra registrado en Plan de Vuelo Real", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "" + (consultas.Variables.InsertPlanVueloReal) + " (id_plan_vuelo_real.nextval,'" + Logica.Clases.PlanVueloReal.Descripcion_ + "','" + Logica.Clases.PlanVueloReal.FechaSalida_ + Logica.Clases.PlanVueloReal.HoraSalida_ + ":00" + "','" + Logica.Clases.PlanVueloReal.FechaLlegada_ + Logica.Clases.PlanVueloReal.HoraLlegada_ + ":00" + "','" + "01/01/2001" + Logica.Clases.PlanVueloReal.TaxeoSalida_ + ":00" + "','" + "01/01/2001" + Logica.Clases.PlanVueloReal.TaxeoLlegada_ + ":00" + "','" + Logica.Clases.PlanVueloReal.Piloto_ + "','" + Logica.Clases.PlanVueloReal.Copiloto_ + "','" + Logica.Clases.PlanVueloReal.TipoLicenciaPiloto_ + "','" + Logica.Clases.PlanVueloReal.TipoLicenciaCopiloto_ + "','" + Logica.Clases.PlanVueloReal.PilotoHoras_ + "','" + Logica.Clases.PlanVueloReal.CopilotoHoras_ + "','" + Logica.Clases.PlanVueloReal.PilotoMinutos_ + "','" + Logica.Clases.PlanVueloReal.CopilotoMinutos_ + "','" + Logica.Clases.PlanVueloReal.Ruta_ + "','" + Logica.Clases.PlanVueloReal.Origen_ + "','" + Logica.Clases.PlanVueloReal.Destino_ + "','" + Logica.Clases.PlanVueloReal.Aeronave_ + "','" + Logica.Clases.PlanVueloReal.Mision_ + "','" + Logica.Clases.PlanVueloReal.Condicion_ + "','" + Logica.Clases.PlanVueloReal.ID_ + "')";
                        if (obDAtos.insertar(sql))
                        {
                            actualizarHorasLicencias();
                            actualizarHorasAeronave();
                            actualizarComponente();
                            MessageBox.Show("Vuelo Registrado", "VUELO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Error al Registrar Plan de Vuelo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }                    
                }
            }
        }
        private void actualizarComponente()
        {
            using (OracleConnection cn = new OracleConnection(Logica.consultas.Variables.ConString))
            {
                cn.Open();

                OracleCommand cmd = new OracleCommand("UPDATE_TIEMPOCOMPONENTE", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("MATRICULA", Convert.ToString(matricula));
                cmd.ExecuteNonQuery();
            }
        }
        private void actualizarHorasAeronave()
        {
            using (OracleConnection cn = new OracleConnection(Logica.consultas.Variables.ConString))
            {
                cn.Open();

                OracleCommand cmd = new OracleCommand("UPDATE_HORAS_AERONAVE", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
        }        
        private void actualizarHorasLicencias()
        {
            using (OracleConnection cn = new OracleConnection(Logica.consultas.Variables.ConString))
            {
                cn.Open();

                OracleCommand cmd = new OracleCommand("UPDATE_HORAS_LICENCIA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
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
            btnConsultar.Hide();
            btnVolveraConsultar.Show();

            if (string.IsNullOrWhiteSpace(this.txtID.Text))
            {
                MessageBox.Show("Debes Ingresar un ID de Plan de Vuelo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        btnCambiarCopiloto.Enabled = true;
                        btnCambiarPiloto.Enabled = true;
                        btnCambiarLicenciaCopiloto.Enabled = true;
                        btnCambiarLicenciaPiloto.Enabled = true;
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
                        MessageBox.Show("El 'ID' no se encuentra asignado a un Plan de Vuelo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            btnCambiarCopiloto.Enabled = false;
            btnCambiarPiloto.Enabled = false;
            btnCambiarLicenciaCopiloto.Enabled = false;
            btnCambiarLicenciaPiloto.Enabled = false;
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
                MessageBox.Show("No se acepta espacio en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Las horas no pueden ser mayor a '16'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPilotoHoras.Text = "0";
            }


        }

        private void cboPilotoMinutos_Validated(object sender, EventArgs e)
        {
            if (cboPilotoMinutos.Text == "")
            {
                MessageBox.Show("No se acepta espacio en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Los minutos no pueden ser mayor a '60'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("No se acepta espacio en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Las horas no pueden ser mayor a '16'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("No se acepta espacio en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Los minutos no pueden ser mayor a '60'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        

            /*************************************/
            btnFiltrar.Enabled = true;
            dtDesde.Enabled = true;
            dtHasta.Enabled = true;
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
                dgvVuelos.DefaultCellStyle.Format = "g";
                dgvVuelos.DataSource = ds.Tables[0];
                dgvVuelos.AllowUserToResizeColumns = false;
                dgvVuelos.AllowUserToResizeRows = false;
                dgvVuelos.MultiSelect = false;
                dgvVuelos.Columns["ID_VUELO"].HeaderText = "ID DE VUELO";
                dgvVuelos.Columns["ID_VUELO"].Width = 60;
                dgvVuelos.Columns["FECHA_ORIGEN_ESTIMADA"].HeaderText = "FECHA Y HORA ORIGEN ESTIMADA";
                dgvVuelos.Columns["FECHA_ORIGEN_ESTIMADA"].Width = 142;
                dgvVuelos.Columns["FECHA_DESTINO_ESTIMADA"].HeaderText = "FECHA Y HORA DESTINO ESTIMADA";
                dgvVuelos.Columns["FECHA_DESTINO_ESTIMADA"].Width = 142;
                dgvVuelos.Columns["RUT_PILOTO"].HeaderText = "RUT PILOTO";
                dgvVuelos.Columns["RUT_COPILOTO"].HeaderText = "RUT COPILOTO";
                dgvVuelos.Columns["ORIGEN"].HeaderText = "ORIGEN";
                dgvVuelos.Columns["DESTINO"].HeaderText = "DESTINO";
                dgvVuelos.Columns["MATRICULA_AERONAVE"].HeaderText = "MATRICULA DE AERONAVE";
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                conn.Open();
                OracleCommand cmd = new OracleCommand("" + (consultas.Variables.PlanVueloRealFiltrarVuelos) + "'" + dtDesde.Text + "'" + (consultas.Variables.PlanVueloRealFiltrarVuelos2) + "'" + dtHasta.Text + "'" + (consultas.Variables.PlanVueloRealFiltrarVuelos3) + "", conn);
                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dgvVuelos.DefaultCellStyle.Format = "g";
                dgvVuelos.DataSource = ds.Tables[0];
                dgvVuelos.AllowUserToResizeColumns = false;
                dgvVuelos.AllowUserToResizeRows = false;
                dgvVuelos.MultiSelect = false;
                dgvVuelos.Columns["ID_VUELO"].HeaderText = "ID DE VUELO";
                dgvVuelos.Columns["ID_VUELO"].Width = 60;
                dgvVuelos.Columns["FECHA_ORIGEN_ESTIMADA"].HeaderText = "FECHA Y HORA ORIGEN ESTIMADA";
                dgvVuelos.Columns["FECHA_ORIGEN_ESTIMADA"].Width = 142;
                dgvVuelos.Columns["FECHA_DESTINO_ESTIMADA"].HeaderText = "FECHA Y HORA DESTINO ESTIMADA";
                dgvVuelos.Columns["FECHA_DESTINO_ESTIMADA"].Width = 142;
                dgvVuelos.Columns["RUT_PILOTO"].HeaderText = "RUT PILOTO";
                dgvVuelos.Columns["RUT_COPILOTO"].HeaderText = "RUT COPILOTO";
                dgvVuelos.Columns["ORIGEN"].HeaderText = "ORIGEN";
                dgvVuelos.Columns["DESTINO"].HeaderText = "DESTINO";
                dgvVuelos.Columns["MATRICULA_AERONAVE"].HeaderText = "MATRICULA DE AERONAVE";


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

        private void dgvVuelos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvVuelos.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                
                if (txtID.Enabled == true)
                {
                    DataGridViewRow row = cell.OwningRow;
                    txtID.Text = row.Cells["ID_VUELO"].Value.ToString();
                }
                

                
            }
        }

        private void btnVolveraConsultar_Click(object sender, EventArgs e)
        {
            btnVolveraConsultar.Hide();
            btnConsultar.Show();
            btnCambiarCopiloto.Enabled = false;
            btnCambiarPiloto.Enabled = false;
            btnCambiarLicenciaCopiloto.Enabled = false;
            btnCambiarLicenciaPiloto.Enabled = false;
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

        private void btnCambiarPiloto_Click(object sender, EventArgs e)
        {
            FillCbPilotoEdit();
            cboPiloto.Enabled = true;
            cboTipoLicencia.Enabled = true;
        }

        private void btnCambiarLicenciaPiloto_Click(object sender, EventArgs e)
        {
            FillCbTipoLicenciaEdit();
            cboTipoLicencia.Enabled = true;
            cboPiloto.Enabled = true;
        }

        private void btnCambiarCopiloto_Click(object sender, EventArgs e)
        {
            FillCbCoPilotoEdit();
            cboCopiloto.Enabled = true;
            cboTipoLicenciaCopiloto.Enabled = true;
        }

        private void btnCambiarLicenciaCopiloto_Click(object sender, EventArgs e)
        {
            FillCbTipoLicencia2Edit();
            cboTipoLicenciaCopiloto.Enabled = true;
            cboCopiloto.Enabled = true;
        }

        private void cboPiloto_SelectedValueChanged(object sender, EventArgs e)
        {
            FillCbTipoLicenciaEdit();
        }

        private void cboCopiloto_SelectedValueChanged(object sender, EventArgs e)
        {
            FillCbTipoLicencia2Edit();
        }

        

  

        

        




    }


}

