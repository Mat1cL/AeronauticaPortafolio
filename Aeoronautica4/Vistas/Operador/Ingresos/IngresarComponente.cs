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
    public partial class IngresarComponente : Form
    {
        public IngresarComponente()
        {
            InitializeComponent();
        }



        void FillCbMatricula()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.SelectCbMatricula) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["matricula"] = "Seleccione una Matricula";
                dt.Rows.InsertAt(row, 0);
                this.cbMatricula.DataSource = dt;
                this.cbMatricula.DisplayMember = "matricula";
                this.cbMatricula.ValueMember = "matricula";
                this.cbMatricula.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbProveedor()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+consultas.Variables.SelectCbProveedor+"", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["nombre_proveedor"] = "Seleccione un Proveedor";
                dt.Rows.InsertAt(row, 0);
                this.cbProveedor.DataSource = dt;
                this.cbProveedor.DisplayMember = "nombre_proveedor";
                this.cbProveedor.ValueMember = "id_proveedor";
                this.cbProveedor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaOperadorIngresarComponente_Load(object sender, EventArgs e)
        {
            txtComponente.CharacterCasing = CharacterCasing.Upper;
            FillCbMatricula();
            FillCbProveedor();
        }


        datos obDAtos = new datos();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            
            try
            {

                OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
                cnn.Open();

                string sqlString = ""+(consultas.Variables.SelectComponente)+"";
                OracleCommand dbCmd = new OracleCommand(sqlString, cnn);
                OracleDataReader reader = dbCmd.ExecuteReader();

                Logica.Componente.NombreComponente = txtComponente.Text;
                Logica.Componente.Descripcion_ = txtDescripcion.Text;
                Logica.Componente.Proveedor_ = cbProveedor.SelectedValue.ToString();
                Logica.Componente.Matricula_ = cbMatricula.SelectedValue.ToString();

                /*INICIAR LIMPIAR ERRORES*/
                if (txtComponente.Text.Length > 0)
                {
                    errorProvider1.SetError(txtComponente, string.Empty);
                }
                if (txtDescripcion.Text.Length > 0)
                {
                    errorProvider1.SetError(txtDescripcion, string.Empty);
                }
                if (cbMatricula.Text != "Seleccione una Matricula")
                {
                    errorProvider1.SetError(cbMatricula, string.Empty);
                }
                if (cbProveedor.Text != "Seleccione un Proveedor")
                {
                    errorProvider1.SetError(cbProveedor, string.Empty);
                }
                /*FIN LIMPIAR ERRORES*/

                /*INICIO DECLARAR ERRORES*/
                if (string.IsNullOrWhiteSpace(txtComponente.Text))
                {
                    errorProvider1.SetError(txtComponente, "Debes ingresar un nombre de Componente");
                }
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    errorProvider1.SetError(txtDescripcion, "Debes ingresar una Descripción");
                }
                if (cbMatricula.Text == "Seleccione una Matricula")
                {
                    errorProvider1.SetError(cbMatricula, "Debes Seleccionar una Matricula");
                }
                if (cbProveedor.Text == "Seleccione un Proveedor")
                {
                    errorProvider1.SetError(cbProveedor, "Debes Seleccionar un Proveedor");
                }
                /*FIN DECLARAR ERRORES*/

                /*VALIDAR SI EXISTEN ERRORES*/
                if (errorProvider1.GetError(txtComponente) == "Debes ingresar un nombre de Componente")
                {
                    return;
                }
                if (errorProvider1.GetError(txtDescripcion) == "Debes ingresar una Descripción")
                {
                    return;
                }
                if (errorProvider1.GetError(cbMatricula) == "Debes Seleccionar una Matricula")
                {
                    return;
                }
                if (errorProvider1.GetError(cbProveedor) == "Debes Seleccionar un Proveedor")
                {
                    return;
                }
                /*FIN VALIDAR SI EXISTEN ERRORES*/

                
                else
                {

                    string sql = "" + (consultas.Variables.InsertComponente) + " (id_componente.nextval,'" + Logica.Componente.NombreComponente + "','" + Logica.Componente.Descripcion_ + "','" + Logica.Componente.Proveedor_ + "','" + Logica.Componente.Matricula_ + "',sysdate)";

                    if (obDAtos.insertar(sql))
                    {
                        MessageBox.Show("Componente Insertado", "INGRESO CORRECTAMENTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al Insertar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void txtComponente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
