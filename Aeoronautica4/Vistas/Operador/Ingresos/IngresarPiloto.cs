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
using System.Text.RegularExpressions;
using Aeronautica;
using Logica;
using Conexion;




namespace Aeronautica
{
    public partial class IngresarPiloto : Form
    {
        public IngresarPiloto()
        {
            InitializeComponent();

        }

  
        void FillCbPais()
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
                cboPais.DataSource = dt;
                cboPais.DisplayMember = "nombre_pais";
                cboPais.ValueMember = "nombre_pais";
                this.cboPais.SelectedIndex = 0;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbRegion()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboRegion)+"'" + this.cboPais.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_region"] = Convert.ToInt32("0");
                row["nombre_region"] = "Seleccione una Región";
                dt.Rows.InsertAt(row, 0);
                this.cboRegion.DataSource = dt;
                this.cboRegion.DisplayMember = "nombre_region";
                this.cboRegion.ValueMember = "nombre_region";
                this.cboRegion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbProvincia()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);;
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboProvincia)+"'" + this.cboRegion.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_provincia"] = Convert.ToInt32("0");
                row["nombre_provincia"] = "Seleccione una Provincia";
                dt.Rows.InsertAt(row, 0);
                this.cboProvincia.DataSource = dt;
                this.cboProvincia.DisplayMember = "nombre_provincia";
                this.cboProvincia.ValueMember = "nombre_provincia";
                this.cboProvincia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbComuna()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboComuna)+"'" + this.cboProvincia.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_comuna"] = Convert.ToInt32("0");
                row["nombre_comuna"] = "Seleccione una Comuna";
                dt.Rows.InsertAt(row, 0);
                this.cboComuna.DataSource = dt;
                this.cboComuna.DisplayMember = "nombre_comuna";
                this.cboComuna.ValueMember = "id_comuna";
                this.cboComuna.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }



        datos obDAtos = new datos();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtCorreo.Text, pattern))
            {
                if (string.IsNullOrWhiteSpace(txtRut.Text) || string.IsNullOrWhiteSpace(this.txtApellidoPaterno.Text) || string.IsNullOrWhiteSpace(this.txtApellidoMaterno.Text) || string.IsNullOrWhiteSpace(this.txtCorreo.Text) || string.IsNullOrWhiteSpace(this.txtDireccion.Text) || string.IsNullOrWhiteSpace(this.txtTelefono.Text) || string.IsNullOrWhiteSpace(this.txtCelular.Text) || string.IsNullOrWhiteSpace(this.Sexo))
                {
                    MessageBox.Show("Debes completar los campos...");
                    return;
                }
                if (cboPais.Text == "Seleccione un País")
                {
                    MessageBox.Show("Debes Seleccionar un País");
                }
                else if (cboRegion.Text == "Seleccione una Región")
                {
                    MessageBox.Show("Debes Seleccionar una Región");
                }
                else if (cboProvincia.Text == "Seleccione una Provincia")
                {
                    MessageBox.Show("Debes Seleccionar una Provincia");
                }
                else if (cboComuna.Text == "Seleccione una Comuna")
                {
                    MessageBox.Show("Debes Seleccionar una Comuna");
                }

                else
                {
                    if (Rut.ValidaRut(txtRut.Text))
                    {
                        Console.WriteLine("Rut Valido");
                        try
                        {

                            OracleConnection cnn = new OracleConnection(consultas.Variables.ConString);
                            cnn.Open();
                            string sqlString = ""+(consultas.Variables.SelectPiloto)+"'" + txtRut.Text + "'";
                            OracleCommand dbCmd = new OracleCommand(sqlString, cnn);
                            OracleDataReader reader = dbCmd.ExecuteReader();
                            string sqlString2 = ""+(consultas.Variables.SelectPilotoCorreo)+"'" + txtCorreo.Text + "'";
                            OracleCommand dbCmdx2 = new OracleCommand(sqlString2, cnn);
                            OracleDataReader reader2 = dbCmdx2.ExecuteReader();
                            string sqlString3 = ""+(consultas.Variables.ValidarRUT)+"'"+txtRut.Text+"' "+(consultas.Variables.ValidarRUT2)+"";
                            OracleCommand dbCmdx3 = new OracleCommand(sqlString3, cnn);
                            OracleDataReader reader3 = dbCmdx3.ExecuteReader();
                            if (reader.Read())
                            {
                                MessageBox.Show("El Rut ya se encuentra registrado");
                            }
                            else if (reader2.Read())
                            {
                                MessageBox.Show("El e-mail ingresado ya se encuentra asociado a un Piloto");
                            }
                            else if (reader3.Read())
                            {
                                MessageBox.Show("El RUT se encuentra asociado a un Administrador, Operado o Consultor");
                            }
                            else
                            {
                                string sql = ""+(consultas.Variables.InsertPiloto)+" ('" + this.txtRut.Text + "','" + this.txtNombre.Text + "','" + this.txtApellidoPaterno.Text + "','" + this.txtApellidoMaterno.Text + "','" + this.dtFecha.Text + "','" + this.txtCorreo.Text + "','" + this.txtDireccion.Text + "','" + this.txtTelefono.Text + "','" + this.txtCelular.Text + "','" + Sexo + "','" + this.cboComuna.SelectedValue + "',2)";

                                if (obDAtos.insertar(sql))
                                {
                                    MessageBox.Show("Piloto Insertado, Recuerda que el Piloto quedara deshabilitado hasta que se registre una Ficha Médica");
                                }
                                else
                                {
                                    MessageBox.Show("Error al Insertar");

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
                    else
                    {
                        MessageBox.Show("Rut Inválido", "ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("E-mail inválido");
            }








        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string Sexo;
        private void rM_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "1";
        }

        private void rF_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "2";
        }

       



        private void cboPrueba_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VistaOperadorIngresarPiloto_Load(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtApellidoPaterno.CharacterCasing = CharacterCasing.Upper;
            txtApellidoMaterno.CharacterCasing = CharacterCasing.Upper;
            txtCorreo.CharacterCasing = CharacterCasing.Upper;
            txtDireccion.CharacterCasing = CharacterCasing.Upper;
            txtRut.CharacterCasing = CharacterCasing.Upper;
            FillCbPais();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloLetras(e);
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloLetras(e);
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloLetras(e);
        }

        private void txtRut_Validated(object sender, EventArgs e)
        {


            string rutSinFormato = txtRut.Text;
            string rutFormateado = String.Empty;
            if (txtRut.Text == "")
            {
                //MessageBox.Show("Debes ingresar el Rut");
            }
            else
            {
                //obtengo la parte numerica del RUT
                string rutTemporal = rutSinFormato.Substring(0, rutSinFormato.Length - 1);

                //obtengo el Digito Verificador del RUT

                string dv = rutSinFormato.Substring(rutSinFormato.Length - 1, 1);

                Int64 rut;

                //aqui convierto a un numero el RUT si ocurre un error lo deja en CERO
                if (!Int64.TryParse(rutTemporal, out rut))
                {
                    rut = 0;
                }

                //este comando es el que formatea con los separadores de miles
                rutFormateado = rut.ToString("N0");

                if (rutFormateado.Equals("0"))
                {
                    rutFormateado = string.Empty;
                }
                else
                {
                    //si no hubo problemas con el formateo agrego el DV a la salida
                    rutFormateado += "-" + dv;

                    //y hago este replace por si el servidor tuviese configuracion anglosajona y reemplazo las comas por puntos
                    rutFormateado = rutFormateado.Replace(",", ".");
                }
                txtRut.Text = rutFormateado;
                //la salida esperada para el ejemplo es 99.999.999-K
                //MessageBox.Show("RUT Formateado: " + rutFormateado);
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumerosyLetras(e);
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbRegion();
        }
        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbProvincia();
        }
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbComuna();
        }

        private void cboComuna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumeros(e);
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumeros(e);
        }

        


    }
}
