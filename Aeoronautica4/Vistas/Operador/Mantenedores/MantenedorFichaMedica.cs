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
using Logica;
using Conexion;

namespace Aeronautica.Operador
{
    public partial class MantenedorFichaMedica : Form
    {
        public MantenedorFichaMedica()
        {
            InitializeComponent();
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
            OracleCommand cmd = new OracleCommand(""+(consultas.Variables.SelectFromFichaMedica)+"'" + txtRutPiloto.Text + "'", conn);
            conn.Open();
            try
            {

                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    btnVolveraBuscar.Show();
                    txtRutPiloto.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtID.Text = dr["ID_FICHA_MEDICA"].ToString();
                    txtDescripcion.Text = dr["DESCRIPCION"].ToString();

                }
                else
                {
                    lblMensaje.Text = "No se pudo encontrar datos ERROR";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd = new OracleCommand(""+(consultas.Variables.MostrarFichaMedica)+"", conn);
            conn.Open();
            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dgvFicha.DataSource = ds.Tables[0];
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

        private void MantenedorFichaMedica_Load(object sender, EventArgs e)
        {
            btnVolveraBuscar.Hide();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            txtDescripcion.Enabled = false;
            txtRutPiloto.CharacterCasing = CharacterCasing.Upper;
        }

        datos obDAtos = new datos();
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtRutPiloto.Text.Trim() == "")
            {
                MessageBox.Show("Debes Completar el Campo de Rut");
                return;
            }
            else
            {
                if (Rut.ValidaRut(txtRutPiloto.Text))
                {
                    if (txtDescripcion.Text.Trim() == "")
                    {
                        MessageBox.Show("Falta completar los campos...");
                        return;
                    }
                    else
                    {
                        string sql = ""+(consultas.Variables.UpdateFichaMedica)+"'" + txtDescripcion.Text + "' "+(consultas.Variables.UpdateFichaMedica2)+"" + txtID.Text;

                        if (obDAtos.actualizar(sql))
                        {
                            MessageBox.Show("La Ficha Médica se ha actualizado correctamente");
                            OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
                            OracleCommand cmd;
                            cmd = new OracleCommand(""+(consultas.Variables.MostrarFichaMedica)+"", cnn);
                            cmd.CommandType = CommandType.Text;
                            DataSet ds = new DataSet();
                            OracleDataAdapter da = new OracleDataAdapter();
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            dgvFicha.DataSource = ds.Tables[0];

                        }
                        else { MessageBox.Show("No se pudo Modificar"); }
                    }

                }
                else { MessageBox.Show("Rut invalido"); }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtRutPiloto.Text.Trim() == "")
            {
                MessageBox.Show("Debes Completar el Campo de Rut");
                return;
            }
            else
            {
                conexion cn = new conexion();
                string sql = ""+(consultas.Variables.DeleteFichaMedica)+"'" + txtID.Text + "'";
                if (obDAtos.eliminar(sql))
                {
                    txtID.Text = string.Empty;
                    txtDescripcion.Text = string.Empty;
                    MessageBox.Show("La Ficha Médica se ha eliminado correctamente");
                    OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
                    OracleCommand cmd;
                    cmd = new OracleCommand(""+(consultas.Variables.MostrarFichaMedica)+"", cnn);
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dgvFicha.DataSource = ds.Tables[0];
                }
                else { MessageBox.Show("No se pudo eliminar"); }
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFicha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolveraBuscar_Click(object sender, EventArgs e)
        {
            btnVolveraBuscar.Hide();
            txtRutPiloto.Enabled = true;
            txtDescripcion.Enabled = false;
            btnBuscar.Show();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            txtRutPiloto.Clear();
            txtID.Clear();
            txtDescripcion.Clear();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
