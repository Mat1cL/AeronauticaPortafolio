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
            Logica.Clases.Licencia.NumeroLicencia_ = txtNumero.Text;
            Logica.Clases.Licencia.Descripcion_ = txtDescripcion.Text;
            Logica.Clases.Licencia.FechaVencimiento_ = dtFecha.Text;
            Logica.Clases.Licencia.RutPiloto_ = cbPiloto.SelectedValue.ToString();
            Logica.Clases.Licencia.Licencia_ = cbLicencia.SelectedValue.ToString();
            /*INICIO LIMPIAR ERRORES*/
            if (txtDescripcion.Text.Length > 0)
            {
                errorProvider1.SetError(txtDescripcion, string.Empty);
            }
            if (txtNumero.Text.Length > 0)
            {
                errorProvider1.SetError(txtNumero, string.Empty);
            }
            if (cbPiloto.Text != "Seleccione un Piloto")
            {
                errorProvider1.SetError(cbPiloto, string.Empty);
            }
            if (cbLicencia.Text != "Seleccione Tipo de Licencia")
            {
                errorProvider1.SetError(cbLicencia, string.Empty);
            }
            if (dtFecha.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtFecha, string.Empty);
            }
            /*FIN LIMPIAR ERRORES*/

            /*INICIO DECLARAR ERRORES*/
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, "Debes ingresar una descripción");
            }
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, "Debes ingresar un número de licencia");
            }
            if (cbPiloto.Text == "Seleccione un Piloto")
            {
                errorProvider1.SetError(cbPiloto, "Debes Seleccionar un Piloto");
            }
            if (cbLicencia.Text == "Seleccione Tipo de Licencia")
            {
                errorProvider1.SetError(cbLicencia, "Debes Seleccionar una Licencia");
            }
            if (dtFecha.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtFecha, "La fecha de Expiración no puede ser menor a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");
            }
            /*FIN DECLARAR ERRORES*/

            /*VALIDAR SI EXISTEN ERRORES*/
            if (errorProvider1.GetError(txtDescripcion) == "Debes ingresar una descripción")
            {
                return;
            }
            if (errorProvider1.GetError(txtNumero) == "Debes ingresar un número de licencia")
            {
                return;
            }
            if (errorProvider1.GetError(cbPiloto) == "Debes Seleccionar un Piloto")
            {
                return;
            }
            if (errorProvider1.GetError(cbLicencia) == "Debes Seleccionar una Licencia")
            {
                return;
            }
            if (errorProvider1.GetError(dtFecha) == "La fecha de Expiración no puede ser menor a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "")
            {
                return;
            }
            /*FIN VALIDAR SI EXISTEN ERRORES*/
            else
            {
                try
                {


                    OracleConnection cnn = new OracleConnection(consultas.Variables.ConString);
                    cnn.Open();
                    string sqlString2 = "" + (consultas.Variables.SelectLicenciaNumeroLicencia) + "'" + Logica.Clases.Licencia.NumeroLicencia_ + "'";
                    OracleCommand dbCmd2 = new OracleCommand(sqlString2, cnn);
                    OracleDataReader reader2 = dbCmd2.ExecuteReader();
                    string sqlString = "" + (consultas.Variables.ValidarPilotoLicencia) + " '" + Logica.Clases.Licencia.RutPiloto_ + "' " + (consultas.Variables.ValidarPilotoLicencia2) + "" + Logica.Clases.Licencia.Licencia_;
                    OracleCommand dbCmd = new OracleCommand(sqlString, cnn);
                    OracleDataReader reader = dbCmd.ExecuteReader();

                    if (reader2.Read())
                    {
                        MessageBox.Show("El Número de Licencia ya Existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    else
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("El Piloto ya posee esta licencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else
                        {
                            string sql = "" + (consultas.Variables.InsertLicencia) + " (" + Logica.Clases.Licencia.NumeroLicencia_ + ",'" + Logica.Clases.Licencia.Descripcion_ + "','" + Logica.Clases.Licencia.FechaVencimiento_ + "','" + Logica.Clases.Licencia.RutPiloto_ + "','" + Logica.Clases.Licencia.Licencia_ + "')";
                            if (obDAtos.insertar(sql))
                            {
                                MessageBox.Show("Licencia Registrada", "LICENCIA REGISTRADA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("Error al Registrar Licencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
