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
    public partial class MantenedorAeronave : Form
    {
        public static string DateTimeString;
        public MantenedorAeronave()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            OracleDataReader dr = null;
            OracleConnection cn = new OracleConnection(consultas.Variables.ConString);
            OracleCommand cmd;
            cn.Open();
            try
            {
                cmd = new OracleCommand(""+(consultas.Variables.MostrarAeronaveMantenedorAeronave)+"'" + txtMatricula.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    cboDisponible.Enabled = true;
                    lblIDDGV.Show();
                    lblNombreDGV.Show();
                    btnVolveraBuscar.Show();
                    txtMatricula.Enabled = false;
                    cbTipoAeronave.Enabled = true;
                    cbFabricante.Enabled = true;
                    txtAño.Enabled = true;
                    btnModificarAeronave.Enabled = true;
                    btnEliminarAeronave.Enabled = true;
                    btnEditarComponente.Enabled = true;
                    btnEliminarComponente.Enabled = true;
                    txtMatricula1.Text = dr["MATRICULA"].ToString();
                    txtAño.Text = dr["ANO_FABRICACION"].ToString();
                    cbTipoAeronave.Text = dr["NOMBRE_TIPO_AERONAVE"].ToString();
                    cbFabricante.Text = dr["NOMBRE_FABRICANTE"].ToString();
                    cboDisponible.Text = dr["NOMBRE_ESTADO"].ToString();
                    lblMensaje.Hide();


                    

                    cn.Close();

                    LlenarGirdView(matricula);
                    if (dgvComponentes.Rows.Count == 0)
                    {
                        btnEditarComponente.Enabled = false;
                        btnEliminarComponente.Enabled = false;
                    }
                }
                else
                {
                    lblMensaje.Show();
                    lblMensaje.Text = "No se pudo encontrar Aeronave";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MantenedorAeronave_Load(object sender, EventArgs e)
        {
            cboDisponible.Enabled = false;
            txtMatricula.CharacterCasing = CharacterCasing.Upper;
            txtMatricula1.CharacterCasing = CharacterCasing.Upper;
            lblIDDGV.Hide();
            lblNombreDGV.Hide();
            btnVolveraBuscar.Hide();
            cbTipoAeronave.Enabled = false;
            cbFabricante.Enabled = false;
            txtAño.Enabled = false;
            txtDescripcion.Enabled = false;
            cbProveedor.Enabled = false;
            txtNombre.Enabled = false;
            btnModificarAeronave.Enabled = false;
            btnEliminarAeronave.Enabled = false;
            btnEditarComponente.Enabled = false;
            btnEliminarComponente.Enabled = false;
            FillCbTipo();
            FillCbProveedor();
            FillCbFabricante();
            FillCbDisponible();
            cboDisponible.Text = "";
            cbFabricante.Text = "";
            cbProveedor.Text = "";
            cbTipoAeronave.Text = "";
        }

        void FillCbTipo()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboAeronaveMatenedorAeronave)+"", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();

                this.cbTipoAeronave.DataSource = dt;
                this.cbTipoAeronave.DisplayMember = "NOMBRE_TIPO_AERONAVE";
                this.cbTipoAeronave.ValueMember = "ID_TIPO_AERONAVE";
                this.cbTipoAeronave.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void FillCbFabricante()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboFabricanteMantenedorAeronave)+"", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();


                this.cbFabricante.DataSource = dt;
                this.cbFabricante.DisplayMember = "NOMBRE_FABRICANTE";
                this.cbFabricante.ValueMember = "ID_FABRICANTE";
                this.cbFabricante.SelectedIndex = 0;
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
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboProveedorMantenedorAeronave)+"", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();

                this.cbProveedor.DataSource = dt;
                this.cbProveedor.DisplayMember = "NOMBRE_PROVEEDOR";
                this.cbProveedor.ValueMember = "ID_PROVEEDOR";
                this.cbProveedor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbDisponible()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.FillCboDisponibilidadEditFormMantenedorAeronave) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();


                this.cboDisponible.DataSource = dt;
                this.cboDisponible.DisplayMember = "NOMBRE_ESTADO";
                this.cboDisponible.ValueMember = "ID_ESTADO";
                this.cboDisponible.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void LlenarGirdView(string matricula)
        {

            OracleConnection cn = new OracleConnection(consultas.Variables.ConString);
            OracleCommand cmd;


            cmd = new OracleCommand(""+(consultas.Variables.LlenarGridMatenedorAeronave)+"'" + matricula + "' "+(consultas.Variables.LlenarGridMatenedorAeronave2)+"", cn);

            cn.Open();
            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dgvComponentes.DataSource = ds.Tables[0];
            dgvComponentes.MultiSelect = false;
            dgvComponentes.AllowUserToResizeColumns = false;
            dgvComponentes.AllowUserToResizeRows = false;
            dgvComponentes.Columns["ID"].Width = 50;
            dgvComponentes.Columns["NOMBRE"].Width = 72;
            lblMensaje.Text = string.Empty;
            cn.Close();
        }
        private void dgvComponentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int nFila = e.RowIndex;
            int nColumna = e.ColumnIndex;

            DataGridViewCell cellSelected = dgvComponentes.Rows[nFila].Cells[0];
            string query = string.Format("" + (consultas.Variables.CellComponentes) + "", cellSelected.Value);

            OracleDataReader dr = null;
            OracleConnection conn = new OracleConnection(consultas.Variables.ConString);
            OracleCommand cmd = new OracleCommand(query, conn);
            conn.Open();
            try
            {

                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    txtNombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                    cbProveedor.Enabled = true;
                    txtID.Text = dr["ID_COMPONENTE"].ToString();
                    txtNombre.Text = dr["NOMBRE_COMPONENTE"].ToString();
                    cbProveedor.Text = dr["NOMBRE_PROVEEDOR"].ToString();
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

        datos obDAtos = new datos();
        private void btnEditarComponente_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            if (txtNombre.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || cbProveedor.SelectedText == "SELECCIONAR")
            {
                MessageBox.Show("Debes Completar Los Campos Pertenecientes a Componentes");
                return;
            }
            else
            {
                string sql = ""+(consultas.Variables.ModificarComponente)+"'" + txtNombre.Text + "',"+(consultas.Variables.ModificarComponente2)+"'" + txtDescripcion.Text + "', "+(consultas.Variables.ModificarComponente3)+"" + cbProveedor.SelectedValue.ToString() +" "+(consultas.Variables.ModificarComponente4)+"" + txtID.Text + "";
                if (obDAtos.actualizar(sql))
                {
                    MessageBox.Show("Componente Modificado Correctamente");

                    OracleConnection cnx = new OracleConnection(consultas.Variables.ConString);
                    OracleCommand cmd;
                    cmd = new OracleCommand("" + (consultas.Variables.LlenarGridMatenedorAeronave) + "'" + txtMatricula.Text + "' " + (consultas.Variables.LlenarGridMatenedorAeronave2) + "", cnx);
                    cnx.Open();
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dgvComponentes.DataSource = ds.Tables[0];
                    dgvComponentes.MultiSelect = false;
                    dgvComponentes.AllowUserToResizeColumns = false;
                    dgvComponentes.AllowUserToResizeRows = false;
                    dgvComponentes.Columns["ID"].Width = 50;
                    dgvComponentes.Columns["NOMBRE"].Width = 72;
                    lblMensaje.Text = string.Empty;

                    cnx.Close();
                }
                else { MessageBox.Show("No se pudo Modificar"); }
            }
        }

        private void btnEliminarComponente_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Debe Seleccionar un Componente"); return;
            }
            else
            {
                string sql = ""+(consultas.Variables.EliminarComponente)+"'" + txtID.Text + "'";
                if (obDAtos.eliminar(sql))
                {
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    cbProveedor.Enabled = false;
                    txtID.Text = string.Empty;
                    txtNombre.Text = string.Empty;
                    txtDescripcion.Text = string.Empty;
                    cbProveedor.SelectedIndex = 0;
                    MessageBox.Show("El Componente fue eliminado Correctamente");

                    OracleConnection cnx = new OracleConnection(consultas.Variables.ConString);
                    OracleCommand cmd;
                    cmd = new OracleCommand("" + (consultas.Variables.LlenarGridMatenedorAeronave) + "'" + txtMatricula.Text + "' " + (consultas.Variables.LlenarGridMatenedorAeronave2) + "", cnx);
                    cnx.Open();
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dgvComponentes.DataSource = ds.Tables[0];
                    dgvComponentes.MultiSelect = false;
                    dgvComponentes.AllowUserToResizeColumns = false;
                    dgvComponentes.AllowUserToResizeRows = false;
                    dgvComponentes.Columns["ID"].Width = 50;
                    dgvComponentes.Columns["NOMBRE"].Width = 72;
                    lblMensaje.Text = string.Empty;
                    if (dgvComponentes.Rows.Count == 0)
                    {
                        btnEditarComponente.Enabled = false;
                        btnEliminarComponente.Enabled = false;
                    }
                    cnx.Close();
                }
                else { MessageBox.Show("No se pudo eliminar"); }

            }
        }

        private void btnModificarAeronave_Click(object sender, EventArgs e)
        {
            var yearseleccionado = DateTime.Parse("01/01/" + txtAño.Text);
            DateTimeString = DateTime.Now.ToString("yyyy");
            var yearactual = DateTime.Parse("01/01/" + DateTimeString);

            conexion cn = new conexion();
            if (txtMatricula1.Text.Trim() == "" || txtAño.Text.Trim() == "" || cbTipoAeronave.SelectedText == "SELECCIONAR" || cbFabricante.SelectedText == "SELECCIONAR")
            {
                MessageBox.Show("Falta completar los campos de Aeronave");
                return;
            }

            else if (yearseleccionado > yearactual)
            {
                MessageBox.Show("El año de fabricación debe ser igual o menor al Actual: " + DateTime.Now.ToString("yyyy") + "");

            }
            else
            {
                string sql = "" + (consultas.Variables.ModificarAeronave) + "'" + txtAño.Text + "', " + (consultas.Variables.ModificarAeronave2) + "" + cbTipoAeronave.SelectedValue.ToString() + ", ESTADO_ID_ESTADO='"+cboDisponible.SelectedValue+"'" + (consultas.Variables.ModificarAeronave3) + "" + cbFabricante.SelectedValue.ToString() + "" + (consultas.Variables.ModificarAeronave4) + "'" + txtMatricula1.Text + "'";
                if (obDAtos.actualizar(sql))
                {
                    MessageBox.Show("Aeronave modificada Correctamente");
                }
                else { MessageBox.Show("No se pudo Modificar"); }
            }
        }

        private void btnEliminarAeronave_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            if (txtMatricula1.Text.Trim() == "")
            {
                MessageBox.Show("SELECCIONE AERONAVE"); return;
            }
            else
            {
                string sql = ""+(consultas.Variables.EliminarAeronave)+"'" + txtMatricula1.Text + "'";
                if (obDAtos.eliminar(sql))
                {
                    txtMatricula.Text = string.Empty;
                    txtMatricula1.Text = string.Empty;
                    cbFabricante.SelectedIndex = 0;
                    cbTipoAeronave.SelectedIndex = 0;
                    txtAño.Text = string.Empty;
                    MessageBox.Show("La Aeronave fue eliminada Correctamente");
                    cbFabricante.Enabled = false;
                    cbTipoAeronave.Enabled = false;
                    btnEditarComponente.Enabled = false;
                    btnEliminarComponente.Enabled = false;
                    btnModificarAeronave.Enabled = false;
                    btnEliminarAeronave.Enabled = false;
                }
                else { MessageBox.Show("No se pudo eliminar la Aeronave, Comrpueba primero que no contenga componentes"); }

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumeros(e);
        }

        private void txtAño_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnVolveraBuscar_Click(object sender, EventArgs e)
        {
            cboDisponible.Enabled = false;
            cboDisponible.Text = "";
            txtID.Clear();
            lblIDDGV.Hide();
            lblNombreDGV.Hide();
            btnVolveraBuscar.Hide();
            btnMostrar.Show();
            txtMatricula.Enabled = true;
            txtMatricula.Clear();
            txtMatricula1.Enabled = false;
            txtMatricula1.Clear();
            cbTipoAeronave.Enabled = false;
            cbTipoAeronave.Text = "";
            cbProveedor.Enabled = false;
            cbProveedor.Text = "";
            cbFabricante.Enabled = false;
            cbFabricante.Text = "";
            txtAño.Enabled = false;
            txtAño.Clear();
            txtNombre.Enabled = false;
            txtNombre.Clear();
            txtDescripcion.Enabled = false;
            txtDescripcion.Clear();
            btnModificarAeronave.Enabled = false;
            btnEliminarAeronave.Enabled = false;
            btnEliminarComponente.Enabled = false;
            btnEditarComponente.Enabled = false;
            this.dgvComponentes.DataSource = null;
        }

        private void cboDisponible_MouseClick(object sender, MouseEventArgs e)
        {
            //FillCbDisponibleEdit();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void cbProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
