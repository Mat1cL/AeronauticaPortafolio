using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Logica;
using Oracle.DataAccess.Client;

namespace Aeronautica.Vistas.Administrador
{
    public partial class MantenedorUsuario : Form
    {
        public MantenedorUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void FillCbTipoUsuario()
         {
             DataTable dt = new DataTable();
             String strconn = (consultas.Variables.ConString);
             OracleConnection conn;
             OracleDataAdapter da;
             try
             {
                 conn = new OracleConnection(strconn);
                 da = new OracleDataAdapter(""+(consultas.Variables.MantenedorUsuarioCbTipoUsuario)+"'" + txtRut.Text + "'", conn);
                 dt.Clear();
                 da.Fill(dt);
                 conn.Close();
                 this.cboTipoUsuario.DataSource = dt;
                 this.cboTipoUsuario.DisplayMember = "NOMBRE_TIPO_USUARIO";
                 this.cboTipoUsuario.ValueMember = "TIPO_USUARIO_ID_TIPO_USUARIO";
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);

             }
         }
        void FillCbTipoUsuarioEdit()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.MantenedorUsuarioCbTipoUsuarioEdit)+"", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                this.cboTipoUsuario.DataSource = dt;
                this.cboTipoUsuario.DisplayMember = "NOMBRE_TIPO_USUARIO";
                this.cboTipoUsuario.ValueMember = "ID_TIPO_USUARIO";
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
            UsuarioOb.Rut = this.txtRut.Text;


            string rutSinFormato = UsuarioOb.Rut;
            string rutFormateado = String.Empty;
            if (string.IsNullOrWhiteSpace(txtRut.Text))
            {
                MessageBox.Show("Debe ingresar su Rut", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (Rut.ValidaRut(txtRut.Text))
                {
                    Console.WriteLine("Rut Valido");
                }
                else
                {
                    MessageBox.Show("Rut Inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRut.Text = String.Empty;
                }

            OracleDataReader dr = null;
            OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd = new OracleCommand(""+(consultas.Variables.TraerDatosUsuario)+"'" + txtRut.Text + "'", conn);
            conn.Open();
            try
            {

                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    FillCbTipoUsuario();
                    cboTipoUsuario.Enabled = false;
                    lblMensaje.Hide();
                    btnBuscar.Hide();
                    btnVolveraBuscar.Show();
                    txtRut.Enabled = false;
                    txtContrasena.Enabled = true;
                    txtRut.Text = dr["RUT"].ToString();
                    txtContrasena.Text = dr["CONTRASENA"].ToString();



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

        private void MantenedorUsuario_Load(object sender, EventArgs e)
        {
            btnVolveraBuscar.Hide();
            txtRut.CharacterCasing = CharacterCasing.Upper;
            txtContrasena.Enabled = false;
            cboTipoUsuario.Enabled = false;
        }

        datos obDAtos = new datos();
        private void btnModificar_Click(object sender, EventArgs e)
        {
            hash hs = new hash();
            string hash = hs.CalculateMD5Hash(txtContrasena.Text);
            string passEncriptado = hash.Trim().ToLower();
            txtContrasena.Text = passEncriptado;
            if (txtRut.Text.Trim() == "")
            {
                MessageBox.Show("Debes Completar el Campo de Rut", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Clear();
                return;
            }
            else
            {
                if (Rut.ValidaRut(txtRut.Text))
                {
                    if (txtContrasena.Text.Trim() == "")
                    {
                        MessageBox.Show("Falta completar los campos...", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtContrasena.Clear();
                        return;
                    }
                    else
                    {
                        string sql = ""+(consultas.Variables.ActualizarUsuario)+"'" + txtContrasena.Text + "',"+(consultas.Variables.ActualizarUsuario2)+"'"+cboTipoUsuario.SelectedValue+"' "+(consultas.Variables.ActualizarUsuario3)+"'"+ txtRut.Text+"'";

                        if (obDAtos.actualizar(sql))
                        {
                            MessageBox.Show("El Usuario se ha actualizado correctamente", "USUARIO ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
                            OracleCommand cmd;
                            cmd = new OracleCommand(""+(consultas.Variables.ActualizarGridMantenedorUsuario)+"", cnn);
                            cmd.CommandType = CommandType.Text;
                            DataSet ds = new DataSet();
                            OracleDataAdapter da = new OracleDataAdapter();
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            dgvUsuario.DataSource = ds.Tables[0];
                            txtContrasena.Clear();
                        }
                        else { MessageBox.Show("No se pudo Modificar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtContrasena.Clear(); }
                    }

                }
                else { MessageBox.Show("Rut invalido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtContrasena.Clear(); }
            }
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd = new OracleCommand(""+(consultas.Variables.ActualizarGridMantenedorUsuario)+"", cnn);
            cnn.Open();
            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dgvUsuario.DataSource = ds.Tables[0];
            dgvUsuario.Columns["NOMBRE_TIPO_USUARIO"].Width = 158;
            dgvUsuario.Columns["NOMBRE_TIPO_USUARIO"].HeaderText = "NOMBRE DEL TIPO DE USUARIO";
            txtContrasena.Clear();
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumerosyLetras(e);
        }

        private void cboTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTipoUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            FillCbTipoUsuarioEdit();
        }

        private void btnVolveraBuscar_Click(object sender, EventArgs e)
        {
            
            txtRut.Enabled = true;
            txtContrasena.Clear();
            txtContrasena.Clear();
            txtContrasena.Enabled = false;
            cboTipoUsuario.Enabled = false;
            cboTipoUsuario.Text = "";
            btnVolveraBuscar.Hide();
            btnBuscar.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtRut.Text.Trim() == "")
            {
                MessageBox.Show("Debes Completar el Campo de Rut", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                conexion cn = new conexion();
                string sql = ""+(consultas.Variables.MantenedorUsuarioDelete)+"'" + txtRut.Text + "'";
                if (obDAtos.eliminar(sql))
                {
                    MessageBox.Show("La credencial de Usuario se ha eliminado correctamente", "CREDENCIAL DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cboTipoUsuario.Text = "";
                    cboTipoUsuario.Enabled = false;
                    txtContrasena.Text = string.Empty;
                    txtContrasena.Enabled = false;
                    txtRut.Text = string.Empty;
                    txtRut.Enabled = true;
                    btnVolveraBuscar.Hide();
                    btnBuscar.Show();
                    OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
                    OracleCommand cmd = new OracleCommand(""+(consultas.Variables.ActualizarGridMantenedorUsuario)+"", cnn);
                    cnn.Open();
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dgvUsuario.DataSource = ds.Tables[0];
                }
                else { MessageBox.Show("No se pudo eliminar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        }
    }

