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
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) || (string.IsNullOrWhiteSpace(dtYear.Text)))
            {
                MessageBox.Show("Debe ingresar todos los datos");
                return;
            }
            else if (cboModelo.Text == "Seleccione un Modelo")
            {
                MessageBox.Show("Debe Seleccionar un Modelo");
            }
            else if (dtInspeccion.Value < DateTime.Now)
            {
                MessageBox.Show("La fecha de Inspección Anual no puede ser menor a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy")+ "");
            }
            else if (dtYear.Value > DateTime.Now)
            {
                MessageBox.Show("El año de Aeronave no puede ser mayor al Actual: " + DateTime.Now.ToString("yyyy")+ "");
            }
            else if (cbTipo.Text == "Seleccione un Tipo de Aeronave")
            {
                MessageBox.Show("Debe Seleccionar un Tipo de Aeronave");
            }
            else if (cbFabricante.Text == "Seleccione un Fabricante")
            {
                MessageBox.Show("Debe Seleccionar un Fabricante");
            }
            else if (cboEstado.Text == "Seleccione un Estado")
            {
                MessageBox.Show("Debe Seleccionar un Estado");
            }

            else
            {
                try
                {
                    OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
                    cnn.Open();
                    string sqlString = "" + (consultas.Variables.ValidarMatriculaFormIngresarAeronave) + "'" + txtMatricula.Text + "'";
                    OracleCommand dbCmd = new OracleCommand(sqlString, cnn);
                    OracleDataReader reader = dbCmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("La matricula ya existe");
                        }
                        else
                        {
                            string sql = "" + (consultas.Variables.InsertAeronaveFormIngresarAeronave) + " ('" + this.txtMatricula.Text + "','" + this.dtInspeccion.Text + "'," + this.dtYear.Text + ",'" + this.cbTipo.SelectedValue + "','" + this.cbFabricante.SelectedValue + "','" + this.cboModelo.SelectedValue + "','" + this.cboEstado.SelectedValue + "')";
                            if (obDAtos.insertar(sql))
                            {
                                MessageBox.Show("Aeronave Registrada");
                            }
                            else
                            {
                                MessageBox.Show("Error al Registrar Aeronave");
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
