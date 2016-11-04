using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Oracle.DataAccess.Client;
using Aeronautica;
using Logica;
using Conexion;

namespace Aeronautica
{
    public partial class MantenedorPiloto : Form
    {
        public MantenedorPiloto()
        {
            InitializeComponent();
        }

        conexion cn = new conexion();

        void FillCbDisponibilidad()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.FillCboDisponibilidad) + "'" + this.txtRutPiloto.Text + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                /*DataRow row = dt.NewRow();
                row["NOMBRE_TIPO_LICENCIA"] = "SELECCIONAR";
                dt.Rows.InsertAt(row, 0);*/

                this.cboDisponibilidad.DataSource = dt;
                this.cboDisponibilidad.DisplayMember = "nombre_estado";
                this.cboDisponibilidad.ValueMember = "estado_id_estado";
                this.cboDisponibilidad.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void FillCbDisponibilidadEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter((consultas.Variables.FillCboDisponibilidadEdit), conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();


                this.cboDisponibilidad.DataSource = dt;
                this.cboDisponibilidad.DisplayMember = "nombre_estado";
                this.cboDisponibilidad.ValueMember = "id_estado";
                this.cboDisponibilidad.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuarios UsuarioOb = new Usuarios();
            // Inicio Validar Rut

            UsuarioOb.Rut = this.txtRutPiloto.Text;

            string rutSinFormato = UsuarioOb.Rut;
            string rutFormateado = String.Empty;
            if (string.IsNullOrWhiteSpace(txtRutPiloto.Text))
            {
                MessageBox.Show("Debe ingresar su Rut");
                return;
            }
            else
            {
                if (Rut.ValidaRut(txtRutPiloto.Text))
                {
                    Console.WriteLine("Rut Valido");
                }
                else
                {
                    MessageBox.Show("Rut Inválido", "ERROR");
                    txtRutPiloto.Text = String.Empty;
                }
            }

            //



            //
            OracleDataReader dr = null;
            OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd = new OracleCommand(""+(consultas.Variables.SelectPilotoWhereRutPiloto)+"'" + txtRutPiloto.Text + "'", conn);
            conn.Open();
            try
            {

                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    lblMensaje.Hide();
                    btnBuscar.Hide();
                    btnVolveraBuscar.Show();
                    txtRutPiloto.Enabled = false;
                    btnModificar.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApellidoPaterno.Enabled = true;
                    txtApellidoMaterno.Enabled = true;
                    dtNacimiento.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtFijo.Enabled = true;
                    txtCelular.Enabled = true;
                    cboDisponibilidad.Enabled = true;
                    FillCbDisponibilidad();
                    txtNombre.Text = dr["NOMBRE_PILOTO"].ToString();
                    txtApellidoPaterno.Text = dr["APELLIDO_PATERNO"].ToString();
                    txtApellidoMaterno.Text = dr["APELLIDO_MATERNO"].ToString();
                    dtNacimiento.Text = dr["FECHA_NACIMIENTO"].ToString();
                    txtCorreo.Text = dr["CORREO"].ToString();
                    txtDireccion.Text = dr["DIRECCION"].ToString();
                    txtFijo.Text = dr["TEL_FIJO"].ToString();
                    txtCelular.Text = dr["TEL_CEL"].ToString();  
                }
                else
                {
                    lblMensaje.Show();
                    lblMensaje.Text = "No se pudo encontrar datos ERROR";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string cn2 = (consultas.Variables.ConString);
        
        datos obDAtos = new datos();
        private void btnModificar_Click(object sender, EventArgs e)
        {
            OracleConnection cnn = new OracleConnection(cn2);
            cnn.Open();
            string sqlString2 = ""+(consultas.Variables.ValidarCorreoAndPiloto)+"'" + txtCorreo.Text + "' "+(consultas.Variables.ValidarCorreoAndPiloto2)+"'" + txtRutPiloto.Text + "'";
            OracleCommand dbCmdx2 = new OracleCommand(sqlString2, cnn);
            OracleDataReader reader2 = dbCmdx2.ExecuteReader();
            string sqlString3 = ""+(consultas.Variables.ValidarCorreoMantenedorPiloto)+"'" + txtCorreo.Text + "'";
            OracleCommand dbCmdx3 = new OracleCommand(sqlString3, cnn);
            OracleDataReader reader3 = dbCmdx3.ExecuteReader();
            if (txtRutPiloto.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar los campo rut");
                return;
            }
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtCorreo.Text, pattern))
            {

            if (txtRutPiloto.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar los campo rut");
                return;
            }
            else
            {
                if (Rut.ValidaRut(txtRutPiloto.Text))
                {
                    if (txtNombre.Text.Trim() == "" || txtApellidoPaterno.Text.Trim() == "" || txtApellidoMaterno.Text.Trim() == "")
                    {
                        MessageBox.Show("Falta completar los campos...");
                        return;
                    }
                    else
                    {
                        if (reader2.Read())
                        {
                            string sqlx = "" + (consultas.Variables.ActualizarPiloto) + "'" + txtNombre.Text + "', " + (consultas.Variables.ActualizarPiloto2) + "'" + txtApellidoPaterno.Text + "', " + (consultas.Variables.ActualizarPiloto3) + "'" + txtApellidoMaterno.Text + "', " + (consultas.Variables.ActualizarPiloto4) + "'" + dtNacimiento.Text + "', " + (consultas.Variables.ActualizarPiloto5) + "'" + txtCorreo.Text + "', " + (consultas.Variables.ActualizarPiloto6) + "'" + txtDireccion.Text + "', " + (consultas.Variables.ActualizarPiloto7) + "'" + txtFijo.Text + "', " + (consultas.Variables.ActualizarPiloto8) + "'" + txtCelular.Text + "', " + (consultas.Variables.ActualizarPiloto9) + "'" + cboDisponibilidad.SelectedValue + "' " + (consultas.Variables.ActualizarPiloto10) + "'" + txtRutPiloto.Text + "'";

                            if (obDAtos.actualizar(sqlx))
                            {
                                MessageBox.Show("El piloto fue modificado Correctamente");
                                OracleConnection cnnx = new OracleConnection(cn2);
                                OracleCommand cmd = new OracleCommand(""+(consultas.Variables.SelectPilotoMantenedorPiloto)+"", cnnx);
                                cmd.CommandType = CommandType.Text;
                                DataSet ds = new DataSet();
                                OracleDataAdapter da = new OracleDataAdapter();
                                da.SelectCommand = cmd;
                                da.Fill(ds);
                                dgvPiloto.DataSource = ds.Tables[0];
                            }
                            else { MessageBox.Show("No se pudo Modificar"); }
                        }
                        else
                        {
                            if (reader3.Read())
                            {
                                MessageBox.Show("El e-mail ingresado ya se encuentra asociado a un Piloto");
                            }
                            else
                            {
                                string sql = ""+(consultas.Variables.ActualizarPiloto)+"'" + txtNombre.Text + "', "+(consultas.Variables.ActualizarPiloto2)+"'" + txtApellidoPaterno.Text + "', "+(consultas.Variables.ActualizarPiloto3)+"'" + txtApellidoMaterno.Text + "', "+(consultas.Variables.ActualizarPiloto4)+"'" + dtNacimiento.Text + "', "+(consultas.Variables.ActualizarPiloto5)+"'" + txtCorreo.Text + "', "+(consultas.Variables.ActualizarPiloto6)+"'" + txtDireccion.Text + "', "+(consultas.Variables.ActualizarPiloto7)+"'" + txtFijo.Text + "', "+(consultas.Variables.ActualizarPiloto8)+"'" + txtCelular.Text + "', "+(consultas.Variables.ActualizarPiloto9)+"'" + cboDisponibilidad.SelectedValue + "' "+(consultas.Variables.ActualizarPiloto10)+"'" + txtRutPiloto.Text + "'";

                                if (obDAtos.actualizar(sql))
                                {
                                    MessageBox.Show("El piloto fue modificado Correctamente");
                                    OracleConnection cnnx = new OracleConnection(cn2);
                                    OracleCommand cmd = new OracleCommand(""+(consultas.Variables.SelectPilotoMantenedorPiloto)+"", cnnx);
                                    cmd.CommandType = CommandType.Text;
                                    DataSet ds = new DataSet();
                                    OracleDataAdapter da = new OracleDataAdapter();
                                    da.SelectCommand = cmd;
                                    da.Fill(ds);
                                    dgvPiloto.DataSource = ds.Tables[0];
                                }
                                else { MessageBox.Show("No se pudo Modificar"); }
                               }
                             }
                           }
                         }
                    else 
                    { 
                        MessageBox.Show("Rut invalido"); 
                    }
                  }
                }
                else
                {
                    MessageBox.Show("E-mail inválido");
                }
             }

       

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(cn2);
            OracleCommand cmd = new OracleCommand("" + (consultas.Variables.SelectPilotoMantenedorPiloto) + "", conn);
            conn.Open();
            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dgvPiloto.DataSource = ds.Tables[0];
            dgvPiloto.AllowUserToResizeColumns = false;
            dgvPiloto.AllowUserToResizeRows = false;
            dgvPiloto.MultiSelect = false;
        }

        private void MantenedorPiloto_Load(object sender, EventArgs e)
        {
            btnVolveraBuscar.Hide();
            btnModificar.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidoPaterno.Enabled = false;
            txtApellidoMaterno.Enabled = false;
            dtNacimiento.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccion.Enabled = false;
            txtFijo.Enabled = false;
            txtCelular.Enabled = false;
            cboDisponibilidad.Enabled = false;
            
            
            txtRutPiloto.CharacterCasing = CharacterCasing.Upper;
            txtApellidoMaterno.CharacterCasing = CharacterCasing.Upper;
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtApellidoPaterno.CharacterCasing = CharacterCasing.Upper;
            txtCorreo.CharacterCasing = CharacterCasing.Upper;
            txtDireccion.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRutPiloto_Validated(object sender, EventArgs e)
        {
            Usuarios UsuarioOb = new Usuarios();
            // Inicio Validar Rut

            UsuarioOb.Rut = this.txtRutPiloto.Text;

            string rutSinFormato = UsuarioOb.Rut;
            string rutFormateado = String.Empty;
            if (txtRutPiloto.Text == "")
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
                txtRutPiloto.Text = rutFormateado;
                //la salida esperada para el ejemplo es 99.999.999-K
                //MessageBox.Show("RUT Formateado: " + rutFormateado);
            }
        }

        private void txtRutPiloto_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumerosyLetras(e);
        }

        private void txtRutPiloto_TextChanged(object sender, EventArgs e)
        {

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

        private void txtFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumeros(e);
        }

        private void cboDisponibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboDisponibilidad_MouseClick(object sender, MouseEventArgs e)
        {
            FillCbDisponibilidadEdit();
        }

        private void btnVolveraBuscar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            txtRutPiloto.Enabled = true;
            txtRutPiloto.Clear();
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtFijo.Clear();
            txtCelular.Clear();
            cboDisponibilidad.Text = "";
            btnVolveraBuscar.Hide();
            btnBuscar.Show();
            txtNombre.Enabled = false;
            txtApellidoPaterno.Enabled = false;
            txtApellidoMaterno.Enabled = false;
            dtNacimiento.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccion.Enabled = false;
            txtFijo.Enabled = false;
            txtCelular.Enabled = false;
            cboDisponibilidad.Enabled = false;
            dtNacimiento.Text = "01/01/2001";

        }
    }
}
