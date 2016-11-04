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
using System.Diagnostics;
using Aeronautica;
using Logica;
using Conexion;

namespace Aeronautica
{
    public partial class IngresarLicencia : Form
    {
        public IngresarLicencia()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        void FillCbLicencia()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter((consultas.Variables.SelectCboLicencia), conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["nombre_tipo_licencia"] = "Seleccione Tipo de Licencia";
                dt.Rows.InsertAt(row, 0);

                this.cbLicencia.DataSource = dt;
                this.cbLicencia.DisplayMember = "nombre_tipo_licencia";
                this.cbLicencia.ValueMember = "id_tipo_licencia";
                this.cbLicencia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbPiloto()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.SelectTodosPilotosFormLicencia) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();

                dt.Columns.Add("Concatenacion", typeof(string));


                foreach (DataRow dr in dt.Rows)
                {
                    dr["Concatenacion"] = dr["nombre_piloto"].ToString() + " " + dr["apellido_paterno"].ToString() + " " + dr["apellido_materno"].ToString() + " - " + dr["rut_piloto"].ToString();
                }
                DataRow row = dt.NewRow();
                row["Concatenacion"] = "Seleccione un Piloto";
                dt.Rows.InsertAt(row, 0);
                cbPiloto.DataSource = dt;
                cbPiloto.DisplayMember = "Concatenacion";
                cbPiloto.ValueMember = "rut_piloto";

                this.cbPiloto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }





        datos obDAtos = new datos();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || (string.IsNullOrWhiteSpace(txtNumero.Text)))
            {
                MessageBox.Show("Debe ingresar todos los datos");
                return;
            }
            if (cbPiloto.Text == "Seleccione un Piloto")
            {
                MessageBox.Show("Debes Seleccionar un Piloto");
            }
            else if (cbLicencia.Text == "Seleccione Tipo de Licencia")
            {
                MessageBox.Show("Debes Seleccionar una Licencia");
            }
            else
            {
                try
                {


                    OracleConnection cnn = new OracleConnection(consultas.Variables.ConString);
                    cnn.Open();
                    //string sqlString2 = "select  rut_piloto, numero_licencia  from piloto INNER JOIN licencia ON  piloto.rut_piloto = licencia.piloto_rut_piloto where rut_piloto = = '" + cbPiloto.SelectedValue + "' and numero_licencia =" + txtNumero;
                    string sqlString2 = "" + (consultas.Variables.SelectLicenciaNumeroLicencia) + "'" + txtNumero.Text + "'";
                    OracleCommand dbCmd2 = new OracleCommand(sqlString2, cnn);
                    OracleDataReader reader2 = dbCmd2.ExecuteReader();
                    string sqlString = "" + (consultas.Variables.ValidarPilotoLicencia) + " '" + cbPiloto.SelectedValue + "' " + (consultas.Variables.ValidarPilotoLicencia2) + "" + cbLicencia.SelectedValue;
                    OracleCommand dbCmd = new OracleCommand(sqlString, cnn);
                    OracleDataReader reader = dbCmd.ExecuteReader();

                    if (reader2.Read())
                    {
                        MessageBox.Show("El Número de Licencia ya Existe");
                    }
                    else if (dtFecha.Value < DateTime.Now)
                    {
                        MessageBox.Show("La fecha de Expiración no puede ser menor a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");
                    }
                    else
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("El Piloto ya posee esta licencia");
                        }

                        else
                        {
                            string sql = "" + (consultas.Variables.InsertLicencia) + " (" + this.txtNumero.Text + ",'" + this.txtDescripcion.Text + "','" + this.dtFecha.Text + "','" + this.cbPiloto.SelectedValue + "','" + this.cbLicencia.SelectedValue + "')";
                            if (obDAtos.insertar(sql))
                            {
                                MessageBox.Show("Licencia Registrada");
                            }
                            else
                            {
                                MessageBox.Show("Error al Registrar Licencia");
                            }

                        }
                    }




                }
                catch (OracleException ex)
                {
                    Console.WriteLine("Oracle Exception Message");
                    Console.WriteLine("Exception Message: " + ex.Message);
                    Console.WriteLine("Exception Source: " + ex.Source);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception Message");
                    Console.WriteLine("Exception Message: " + ex.Message);
                    Console.WriteLine("Exception Source: " + ex.Source);
                }
            }

        }




        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaOperadorIngresarLicencia_Load(object sender, EventArgs e)
        {
            FillCbPiloto();
            FillCbLicencia();

        }

        private void cbPiloto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumeros(e);
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
