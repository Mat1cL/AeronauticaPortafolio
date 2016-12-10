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
using Conexion;
using Logica;

namespace Aeronautica
{
    public partial class IngresarAeronave : Form
    {
        public IngresarAeronave()
        {
            InitializeComponent();
            dtYear.Format = DateTimePickerFormat.Custom;
            dtYear.CustomFormat = "yyyy";
            dtYear.ShowUpDown = true;
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
                da = new OracleDataAdapter("" + (consultas.Variables.SelectTipoAeronaveFormIngresarAeronave) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_tipo_aeronave"] = Convert.ToInt32("0");
                row["nombre_tipo_aeronave"] = "Seleccione un Tipo de Aeronave";
                dt.Rows.InsertAt(row, 0);
                this.cbTipo.DataSource = dt;
                this.cbTipo.DisplayMember = "nombre_tipo_aeronave";
                this.cbTipo.ValueMember = "id_tipo_aeronave";
                this.cbTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbEstado()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.SelectEstadoFormIngresarAeronave) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_estado"] = Convert.ToInt32("0");
                row["nombre_estado"] = "Seleccione un Estado";
                dt.Rows.InsertAt(row, 0);
                this.cboEstado.DataSource = dt;
                this.cboEstado.DisplayMember = "nombre_estado";
                this.cboEstado.ValueMember = "id_estado";
                this.cboEstado.SelectedIndex = 0;
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
                da = new OracleDataAdapter("" + (consultas.Variables.SelectFabricanteFormIngresarAeronave) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_fabricante"] = Convert.ToInt32("0");
                row["nombre_fabricante"] = "Seleccione un Fabricante";
                dt.Rows.InsertAt(row, 0);
                this.cbFabricante.DataSource = dt;
                this.cbFabricante.DisplayMember = "nombre_fabricante";
                this.cbFabricante.ValueMember = "id_fabricante";
                this.cbFabricante.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbModelo()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.SelectModeloFormIngresarAeronave) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["nombre_modelo"] = "Seleccione un Modelo";
                dt.Rows.InsertAt(row, 0);
                this.cboModelo.DataSource = dt;
                this.cboModelo.DisplayMember = "nombre_modelo";
                this.cboModelo.ValueMember = "id_modelo";
                this.cboModelo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaOperadorIngresarAeronave_Load(object sender, EventArgs e)
        {
            txtMatricula.CharacterCasing = CharacterCasing.Upper;

            FillCbTipo();
            FillCbFabricante();
            FillCbModelo();
            FillCbEstado();
        }

        datos obDAtos = new datos();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Logica.Aeronave.Matricula_ = txtMatricula.Text;
            Logica.Aeronave.FechaInspeccionAnual_ = dtInspeccion.Text;
            Logica.Aeronave.AnoFabricacion_ = dtYear.Text;
            Logica.Aeronave.tipo_aeronave = cbTipo.SelectedValue.ToString();
            Logica.Aeronave.Fabricante_ = cbFabricante.SelectedValue.ToString();
            Logica.Aeronave.Modelo_ = cboModelo.SelectedValue.ToString();
            Logica.Aeronave.Estado_ = cboEstado.SelectedValue.ToString();
            /*INICIO LIMPIAR ERRORES*/
            if (txtMatricula.Text.Length > 0)
            {
                errorProvider1.SetError(txtMatricula, string.Empty);
            }
            if (dtYear.Text.Length > 0)
            {
                errorProvider1.SetError(dtYear, string.Empty);
            }
            if (cboModelo.Text != "Seleccione un Modelo")
            {
                errorProvider1.SetError(cboModelo, string.Empty);
            }
            if (dtInspeccion.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtInspeccion, string.Empty);
            }
            if (dtYear.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtYear, string.Empty);
            }
            if (cbTipo.Text != "Seleccione un Tipo de Aeronave")
            {
                errorProvider1.SetError(cbTipo, string.Empty);
            }
            if (cbFabricante.Text != "Seleccione un Fabricante")
            {
                errorProvider1.SetError(cbFabricante, string.Empty);
            }
            if (cboEstado.Text != "Seleccione un Estado")
            {
                errorProvider1.SetError(cboEstado, string.Empty);
            }
            /*FIN LIMPIAR ERRORES*/

            /*INICIO DECLARAR ERRORES*/
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                errorProvider1.SetError(txtMatricula, "Debes ingresar una Matricula");
            }
            if (string.IsNullOrWhiteSpace(dtYear.Text))
            {
                errorProvider1.SetError(txtMatricula, "Debes ingresar un año de fabricación");
            }
            if (cboModelo.Text == "Seleccione un Modelo")
            {
                errorProvider1.SetError(cboModelo, "Debes Seleccionar un Modelo");
            }
            if (dtInspeccion.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtInspeccion, "La fecha de Inspección Anual no puede ser menor a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");
            }
            if (dtYear.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtYear, "El año de Aeronave no puede ser mayor al Actual: " + DateTime.Now.ToString("yyyy") + "");
            }
            if (cbTipo.Text == "Seleccione un Tipo de Aeronave")
            {
                errorProvider1.SetError(cbTipo, "Debes Seleccionar un Tipo de Aeronave");
            }
            if (cbFabricante.Text == "Seleccione un Fabricante")
            {
                errorProvider1.SetError(cbFabricante, "Debes Seleccionar un Fabricante");
            }
            if (cboEstado.Text == "Seleccione un Estado")
            {
                errorProvider1.SetError(cboEstado, "Debes Seleccionar un Estado");
            }
            /*FIN DECLARAR ERRORES*/

            /*VALIDAR SI EXISTEN ERRORES*/
            if (errorProvider1.GetError(txtMatricula) == "Debes ingresar una Matricula")
            {
                return;
            }
            if (errorProvider1.GetError(dtYear) == "Debes ingresar un año de fabricación")
            {
                return;
            }
            if (errorProvider1.GetError(cboModelo) == "Debes Seleccionar un Modelo")
            {
                return;
            }
            if (errorProvider1.GetError(dtInspeccion) == "La fecha de Inspección Anual no puede ser menor a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "")
            {
                return;
            }
            if (errorProvider1.GetError(dtYear) == "El año de Aeronave no puede ser mayor al Actual: " + DateTime.Now.ToString("yyyy") + "")
            {
                return;
            }
            if (errorProvider1.GetError(cbTipo) == "Debes Seleccionar un Tipo de Aeronave")
            {
                return;
            }
            if (errorProvider1.GetError(cbFabricante) == "Debes Seleccionar un Fabricante")
            {
                return;
            }
            if (errorProvider1.GetError(cboEstado) == "Debes Seleccionar un Estado")
            {
                return;
            }
            /*FIN VALIDAR SI EXISTEN ERRORES*/

            

            else
            {
                try
                {
                    OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
                    cnn.Open();
                    string sqlString = "" + (consultas.Variables.ValidarMatriculaFormIngresarAeronave) + "'" + Logica.Aeronave.Matricula_ + "'";
                    OracleCommand dbCmd = new OracleCommand(sqlString, cnn);
                    OracleDataReader reader = dbCmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("La matricula ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string sql = "" + (consultas.Variables.InsertAeronaveFormIngresarAeronave) + " ('" + Logica.Aeronave.Matricula_ + "','" + Logica.Aeronave.FechaInspeccionAnual_ + "'," + Logica.Aeronave.AnoFabricacion_ + ",'" + Logica.Aeronave.tipo_aeronave + "','" + Logica.Aeronave.Fabricante_ + "','" + Logica.Aeronave.Modelo_ + "','" + Logica.Aeronave.Estado_ + "')";
                            if (obDAtos.insertar(sql))
                            {
                                MessageBox.Show("Aeronave Registrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al Registrar Aeronave", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            datos.SoloNumeros(e);
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMatricula.CharacterCasing = CharacterCasing.Upper;
        }

    }
}
