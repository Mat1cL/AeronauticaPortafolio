using Logica;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeronautica.Vistas.Administrador
{
    public partial class IngresarUsuario : Form
    {
        public IngresarUsuario()
        {
            InitializeComponent();
        }

        void FillCbTipoU()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter((consultas.Variables.SelectCboTipoU), conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["nombre_tipo_usuario"] = "Seleccione un Tipo de Usuario";
                dt.Rows.InsertAt(row, 0);

                this.cboTipoU.DataSource = dt;
                this.cboTipoU.DisplayMember = "nombre_tipo_usuario";
                this.cboTipoU.ValueMember = "id_tipo_usuario";
                this.cboTipoU.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        datos obDAtos = new datos();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuarios UsuarioOb = new Usuarios();
            // Inicio Validar Rut
            hash hs = new hash();
            UsuarioOb.Rut = this.txtRut.Text;
            string rutSinFormato = UsuarioOb.Rut;
            string rutFormateado = String.Empty;

            string hash = hs.CalculateMD5Hash(txtPass.Text);
            string passEncriptado = hash.Trim().ToLower();
            txtPass.Text = passEncriptado;

            string hash2 = hs.CalculateMD5Hash(txtRePass.Text);
            string passEncriptado2 = hash.Trim().ToLower();
            txtRePass.Text = passEncriptado;

            if (string.IsNullOrWhiteSpace(txtRut.Text) || (string.IsNullOrWhiteSpace(txtPass.Text)) || (string.IsNullOrWhiteSpace(txtRePass.Text)))
            {
                MessageBox.Show("Debe ingresar todos los datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRut.Clear();
                txtPass.Clear();
                txtRePass.Clear();
                return;
            }
            else if (cboTipoU.Text == "Seleccione un Tipo de Usuario")
            {
                MessageBox.Show("Debes Seleccionar un Tipo de Usuario", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRut.Clear();
                txtPass.Clear();
                txtRePass.Clear();
            }
            else if (txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Las contraseñas deben ser iguales", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRut.Clear();
                txtPass.Clear();
                txtRePass.Clear();
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
                        string sqlString = "" + (consultas.Variables.SelectUsuario) + "'" + txtRut.Text + "'";
                        OracleCommand dbCmd = new OracleCommand(sqlString, cnn);
                        OracleDataReader reader = dbCmd.ExecuteReader();
                        string sqlString2 = ""+(consultas.Variables.ValidarExistenciaPiloto)+"'" + txtRut.Text + "'";
                        OracleCommand dbCmd2 = new OracleCommand(sqlString2, cnn);
                        OracleDataReader reader2 = dbCmd2.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("El Rut ya se encuentra registrado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtRut.Clear();
                            txtPass.Clear();
                            txtRePass.Clear();
                        }
                        else
                        {
                            if(cboTipoU.Text == "Piloto")
                            {
                                if (reader2.Read())
                                {
                                    string sql = "" + (consultas.Variables.InsertUsuarios) + " ('" + this.txtRut.Text + "','" + this.txtPass.Text + "','" + this.cboTipoU.SelectedValue + "')";
                                    if (obDAtos.insertar(sql))
                                    {
                                        MessageBox.Show("Registro Insertado", "USUARIO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al Insertar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtRut.Clear();
                                        txtPass.Clear();
                                        txtRePass.Clear();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El Rut no se encuentra Asociado a ningún Piloto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtRut.Clear();
                                    txtPass.Clear();
                                    txtRePass.Clear();
                                }
                            }
                            else
                            { 
                            if(cboTipoU.Text == "Administrador")
                            {
                                if (reader2.Read())
                                {
                                    MessageBox.Show("El Rut se encuentra Asociado a un Piloto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtRut.Clear();
                                    txtPass.Clear();
                                    txtRePass.Clear();
                                }
                                else
                                {
                                    string sql = "" + (consultas.Variables.InsertUsuarios) + " ('" + this.txtRut.Text + "','" + this.txtPass.Text + "','" + this.cboTipoU.SelectedValue + "')";
                                    if (obDAtos.insertar(sql))
                                    {
                                        MessageBox.Show("Registro Insertado", "USUARIO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al Insertar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtRut.Clear();
                                        txtPass.Clear();
                                        txtRePass.Clear();
                                    }
                                }
                            }
                            else if (cboTipoU.Text == "Operador")
                            {
                                if (reader2.Read())
                                {
                                    MessageBox.Show("El Rut se encuentra Asociado a un Piloto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtRut.Clear();
                                    txtPass.Clear();
                                    txtRePass.Clear();
                                }
                                else
                                {
                                    string sql = "" + (consultas.Variables.InsertUsuarios) + " ('" + this.txtRut.Text + "','" + this.txtPass.Text + "','" + this.cboTipoU.SelectedValue + "')";
                                    if (obDAtos.insertar(sql))
                                    {
                                        MessageBox.Show("Registro Insertado", "USUARIO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al Insertar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtRut.Clear();
                                        txtPass.Clear();
                                        txtRePass.Clear();
                                    }
                                }
                            }
                            else if (cboTipoU.Text == "Consultor")
                            {
                                if (reader2.Read())
                                {
                                    MessageBox.Show("El Rut se encuentra Asociado a un Piloto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtRut.Clear();
                                    txtPass.Clear();
                                    txtRePass.Clear();
                                }
                                else
                                {
                                    string sql = "" + (consultas.Variables.InsertUsuarios) + " ('" + this.txtRut.Text + "','" + this.txtPass.Text + "','" + this.cboTipoU.SelectedValue + "')";
                                    if (obDAtos.insertar(sql))
                                    {
                                        MessageBox.Show("Registro Insertado", "USUARIO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al Insertar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtRut.Clear();
                                        txtPass.Clear();
                                        txtRePass.Clear();
                                    }
                                }
                            }
                            else
                            {
                                string sql2 = "" + (consultas.Variables.InsertUsuarios) + " ('" + this.txtRut.Text + "','" + this.txtPass.Text + "','" + this.cboTipoU.SelectedValue + "')";


                                if (obDAtos.insertar(sql2))
                                {
                                    MessageBox.Show("Registro Insertado", "USUARIO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al Insertar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
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

                else
                {
                    MessageBox.Show("Rut Inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        


        private void txtRut_Validated(object sender, EventArgs e)
        {
            Usuarios UsuarioOb = new Usuarios();
            // Inicio Validar Rut

            UsuarioOb.Rut = this.txtRut.Text;
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

        private void IngresarUsuario_Load(object sender, EventArgs e)
        {
            FillCbTipoU();
            txtRut.CharacterCasing = CharacterCasing.Upper;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumerosyLetras(e);
        }
    }
}
