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

namespace Aeronautica
{
    public partial class MantenedorLicencia : Form
    {
        public MantenedorLicencia()
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
            string rut = txtRutPiloto.Text;
            OracleDataReader dr = null;
            OracleConnection cn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd;
            cn.Open();
            try
            {
                cmd = new OracleCommand(""+(consultas.Variables.SelectFormMantenedorLicencia)+"'" + txtRutPiloto.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    lblNombre.Text = "Nombre: " + dr["NOMBRE_PILOTO"].ToString() + " " + dr["APELLIDO_PATERNO"].ToString() + " " + dr["APELLIDO_MATERNO"].ToString();
                    lblSexo.Text = "Sexo: " + dr["NOMBRE_SEXO"].ToString();

                    cn.Close();

                    cmd = new OracleCommand(""+(consultas.Variables.SelectNombreSexo)+"'" + txtRutPiloto.Text + "' "+(consultas.Variables.SelectNombreSexo2)+"", cn);
                    
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dgvLicencias.DataSource = ds.Tables[0];
                    btnVolveraBuscar.Show();
                    txtRutPiloto.Enabled = false;
                    txtDescripcion.Enabled = true;
                    cbLicencia.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    lblMensaje.Text = string.Empty;
                    label2.Show();
                    label3.Show();
                    dgvLicencias.Columns["NUMERO"].Width = 71;
                    dgvLicencias.Columns["TIPO"].Width = 71;
                    dgvLicencias.MultiSelect = false;
                    dgvLicencias.AllowUserToResizeColumns = false;
                    dgvLicencias.AllowUserToResizeRows = false;

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

        void FillCbLicencia()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter((consultas.Variables.SelectCboTipoLicenciaFormMantenedorLicencia), conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["NOMBRE_TIPO_LICENCIA"] = "SELECCIONAR";
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

        private void dgvLicencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            int nFila = e.RowIndex;
            int nColumna = e.ColumnIndex;

            DataGridViewCell cellSelected = dgvLicencias.Rows[nFila].Cells[0];
            string query = string.Format((consultas.Variables.dgvLicenciasx), cellSelected.Value);
            OracleDataReader dr = null;
            OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd = new OracleCommand(query, conn);
            conn.Open();
            try
            {

                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    txtNumeroLicencia.Text = dr["NUMERO_LICENCIA"].ToString();
                    cbLicencia.Text = dr["NOMBRE_TIPO_LICENCIA"].ToString();
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



        private void MantenedorLicencia_Load(object sender, EventArgs e)
        {
            btnVolveraBuscar.Hide();
            txtDescripcion.Enabled = false;
            cbLicencia.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            label2.Hide();
            label3.Hide();
            txtRutPiloto.CharacterCasing = CharacterCasing.Upper;
            FillCbLicencia();
        }

        datos obDAtos = new datos();
        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            if (txtDescripcion.Text.Trim() == "" || cbLicencia.SelectedText == "SELECCIONAR")
            {
                MessageBox.Show("Falta completar los campos...");
                return;
            }
            else
            {
                string sql = ""+(consultas.Variables.ModificarLicencia1)+" '" + txtDescripcion.Text + "'," +
                            " " + (consultas.Variables.ModificarLicencia2) + " '" + cbLicencia.SelectedValue.ToString() +
                            "' " + (consultas.Variables.ModificarLicencia3) + "" + txtNumeroLicencia.Text + "";
                if (obDAtos.actualizar(sql))
                {
                    MessageBox.Show("Licencia modificada Correctamente");
                }
                else { MessageBox.Show("No se pudo Modificar"); }
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            if (txtNumeroLicencia.Text.Trim() == "")
            {
                MessageBox.Show("seleccione licencia"); return;
            }
            else
            {
                string sql = ""+(consultas.Variables.EliminarLicencia)+"'" + txtNumeroLicencia.Text + "'";
                if (obDAtos.eliminar(sql))
                {
                    txtNumeroLicencia.Text = string.Empty;
                    txtDescripcion.Text = string.Empty;
                    cbLicencia.SelectedIndex = 0;
                    MessageBox.Show("El piloto fue eliminado Correctamente");
                    OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
                    OracleCommand cmd;
                    cmd = new OracleCommand(""+(consultas.Variables.SelectNombreSexo)+"'" + txtRutPiloto.Text + "' "+(consultas.Variables.SelectNombreSexo2)+"", cnn);
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dgvLicencias.DataSource = ds.Tables[0];

                }
                else { MessageBox.Show("No se pudo eliminar"); }

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRutPiloto_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumerosyLetras(e);
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

        private void txtRutPiloto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvLicencias_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }

        private void btnVolveraBuscar_Click(object sender, EventArgs e)
        {
            btnVolveraBuscar.Hide();
            btnBuscar.Show();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cbLicencia.Text = "SELECCIONAR";
            cbLicencia.Enabled = false;
            txtRutPiloto.Clear();
            txtRutPiloto.Enabled = true;
            txtDescripcion.Clear();
            txtDescripcion.Enabled = false;
            txtNumeroLicencia.Clear();
            lblSexo.Text = "Sexo";
            lblNombre.Text = "Nombre";
            label2.Hide();
            label3.Hide();
            this.dgvLicencias.DataSource = null;

            
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
