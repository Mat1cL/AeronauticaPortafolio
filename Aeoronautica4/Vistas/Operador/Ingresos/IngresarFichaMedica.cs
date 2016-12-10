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
using Logica.Clases;

namespace Aeronautica.Operador
{
    public partial class IngresarFichaMedica : Form
    {
        public IngresarFichaMedica()
        {
            InitializeComponent();
            this.dtVencimiento.Value = DateTime.Now;
        }

     
        //CargaPiloto

        void FillCbPiloto()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.SelectTodosPilotosFormFichaMedica) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();

                dt.Columns.Add("Concatenacion", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["Concatenacion"] = dr["nombre_piloto"].ToString() + " " + dr["apellido_paterno"].ToString() + " " + dr["apellido_materno"].ToString() + " - " + dr["rut_piloto"].ToString();
                }
                DataRow row = dt.NewRow();
                row["rut_piloto"] = Convert.ToInt32("0");
                row["Concatenacion"] = "Seleccione un Piloto";
                dt.Rows.InsertAt(row, 0);


                cboPiloto.DataSource = dt;
                cboPiloto.DisplayMember = "Concatenacion";
                cboPiloto.ValueMember = "rut_piloto";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //Fin CargaPiloto

        datos obDAtos = new datos();
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Logica.Clases.FichaMedica.FechaVencimiento = dtVencimiento.Text;
            Logica.Clases.FichaMedica.Descripcion_ = txtDescripcion.Text;
            Logica.Clases.FichaMedica.RutPiloto_ = cboPiloto.SelectedValue.ToString();
            /*INICIO LIMPIAR ERRORES*/
            if (txtDescripcion.Text.Length > 0)
            {
                errorProvider1.SetError(txtDescripcion, string.Empty);
            }
            if (cboPiloto.Text != "Seleccione un Piloto")
            {
                errorProvider1.SetError(cboPiloto, string.Empty);
            }
            if (dtVencimiento.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtVencimiento, string.Empty);
            }
            /*FIN LIMPIAR ERRORES*/

            /*INICIO DECLARAR ERRORES*/
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, "Debes ingresar una descripción");
            }
            if (cboPiloto.Text == "Seleccione un Piloto")
            {
                errorProvider1.SetError(cboPiloto, "Debes Seleccionar un Piloto");
            }
            if (dtVencimiento.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtVencimiento, "No puedes ingresar una Fecha de Vencimiento inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");
            }
            /*FIN DECLARAR ERRORES*/

            /*VALIDAR SI EXISTEN ERRORES*/
            if (errorProvider1.GetError(txtDescripcion) == "Debes ingresar una descripción")
            {
                return;
            }
            if (errorProvider1.GetError(cboPiloto) == "Debes Seleccionar un Piloto")
            {
                return;
            }
            if (errorProvider1.GetError(dtVencimiento) == "No puedes ingresar una Fecha de Vencimiento inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "")
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
                    string sqlString2 = "" + (consultas.Variables.ValidaRutFormFichaMedica) + "'" + Logica.Clases.FichaMedica.RutPiloto_ + "'";
                    OracleCommand dbCmd2 = new OracleCommand(sqlString2, cnn);
                    OracleDataReader reader2 = dbCmd2.ExecuteReader();
                    if (reader2.Read())
                    {
                        MessageBox.Show("El Rut ya se encuentra asociado a una Ficha Médica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "" + (consultas.Variables.InsertFichaMedica) + " (id_ficha_medica.nextval,'" + Logica.Clases.FichaMedica.FechaVencimiento + "','" + Logica.Clases.FichaMedica.Descripcion_ + "','" + Logica.Clases.FichaMedica.RutPiloto_ + "')";
                        if (obDAtos.insertar(sql))
                        {
                            string QueryUpdate3 = ""+(consultas.Variables.UpdatePilotoHabilitar)+"'"+this.cboPiloto.SelectedValue+"'";
                            OracleCommand cmdDataBasez3 = new OracleCommand(QueryUpdate3, cnn);
                            cmdDataBasez3.ExecuteReader();
                            OracleDataReader dr = null;
                            dr = cmdDataBasez3.ExecuteReader();

                            MessageBox.Show("Ficha Médica Registrada, El Piloto ahora se encuentra Habilitado", "FICHA MÉDICA REGISTRADA", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al Registrar Ficha Médica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void IngresarFichaMedica_Load(object sender, EventArgs e)
        {
            FillCbPiloto();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
