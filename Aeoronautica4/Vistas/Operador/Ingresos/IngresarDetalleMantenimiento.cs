using Logica;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeronautica.Vistas.Operador.Ingresos
{
    public partial class IngresarDetalleMantenimiento : Form
    {
        public static string MatriculaVariable;
        public static string ModeloVariable;
        public static string TipoVariable;
        public static string FechaTerminoVariable;
        public static string YearVariable;
        public IngresarDetalleMantenimiento()
        {
            InitializeComponent();
            this.dtIngreso.Value = DateTime.Now;
            this.dtTermino.Value = DateTime.Now;
        }

        void FillCbTaller()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.FillCboTallerMecanico) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["nombre_taller"] = "Seleccione un Taller";
                dt.Rows.InsertAt(row, 0);
                this.cboTaller.DataSource = dt;
                this.cboTaller.DisplayMember = "nombre_taller";
                this.cboTaller.ValueMember = "id_taller";
                this.cboTaller.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void FillCbAeronave2()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.FillCboAeronaveDetalleMantenimiento) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                dt.Columns.Add("Concatenacion", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["Concatenacion"] = dr["nombre_modelo"].ToString() + " - " + dr["matricula"].ToString();
                }
                DataRow row = dt.NewRow();
                row["matricula"] = Convert.ToInt32("0");
                row["Concatenacion"] = "Seleccione una Aeronave";
                dt.Rows.InsertAt(row, 0);
                this.cboAeronave.DataSource = dt;
                this.cboAeronave.DisplayMember = "Concatenacion";
                this.cboAeronave.ValueMember = "matricula";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbMantenimiento2()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter("" + (consultas.Variables.FillCboMantenimientoDetalleMantenimiento), conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                dt.Columns.Add("Concatenacion", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["Concatenacion"] = "Mantenimiento - " + dr["horas_vuelo"].ToString();
                }
                DataRow row = dt.NewRow();
                row["horas_vuelo"] = Convert.ToInt32("0");
                row["Concatenacion"] = "Seleccione un Mantenimiento";
                dt.Rows.InsertAt(row, 0);
                this.cboMantenimiento2.DataSource = dt;
                this.cboMantenimiento2.DisplayMember = "Concatenacion";
                this.cboMantenimiento2.ValueMember = "id_mantenimiento";
                this.cboMantenimiento2.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void IngresarDetalleMantenimiento_Load(object sender, EventArgs e)
        {
            FillCbAeronave2();
            FillCbMantenimiento2();
            FillCbTaller();
            string username = txtsender.Text;
            txtsender.Text = "" + (consultas.Variables.NombreCorreo) + "";
            txtsender.Enabled = false;
            string pass = txtpass.Text;
            txtpass.Text = "" + (consultas.Variables.PassCorreo) + "";
            txtpass.Enabled = false;
            txtreciever.Enabled = false;
            txtsubject.Enabled = false;
            txtbody.Enabled = false;
            txtsender.Hide();
            txtpass.Hide();
            txtreciever.Hide();
            txtsubject.Hide();
            txtbody.Hide();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection((consultas.Variables.ConString));
            con.Open();

            try
            {
                if (cboTaller.Text == "Seleccione un Taller")
                {
                    MessageBox.Show("Debe seleccionar un Taller");
                }
                else if (cboAeronave.Text == "Seleccione una Aeronave")
                {
                    MessageBox.Show("Debe seleccionar una Aeronave");
                }
                else if (cboMantenimiento2.Text == "Seleccione un Mantenimiento")
                {
                    MessageBox.Show("Debe seleccionar un Mantenimiento");
                }
                else if (dtIngreso.Value < DateTime.Today)
                {
                    MessageBox.Show("No puedes ingresar una fecha de Ingreso de Mantenimiento inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");
                }
                else if (dtTermino.Value < DateTime.Today)
                {
                    MessageBox.Show("No puedes ingresar una fecha de Termino de Mantenimiento inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");
                }
                else if (dtIngreso.Value > dtTermino.Value)
                {
                    MessageBox.Show("La Fecha de Termino debe ser mayor a la Fecha de Ingreso: " + dtIngreso.Text + "");
                }
                
                else
                {
                    string sqlStringx2 = "" + (consultas.Variables.ValidarMantenimiento) + "'" + cboAeronave.SelectedValue + "' " + (consultas.Variables.ValidarMatenimiento2) + "";
                    OracleCommand dbCmdxxx2 = new OracleCommand(sqlStringx2, con);
                    OracleDataReader readexr2 = dbCmdxxx2.ExecuteReader();
                    if (readexr2.Read())
                    {
                        MessageBox.Show("La Aeronave ya se encuentra en Mantenimiento");
                    }
                    else
                    {
                        OracleCommand sqlc = new OracleCommand("" + (consultas.Variables.InsertarDetalleMantenimiento) + "('" + dtIngreso.Text + "','" + dtTermino.Text + "','" + cboTaller.SelectedValue + "','" + cboMantenimiento2.SelectedValue + "','" + cboAeronave.SelectedValue + "')", con);
                        OracleDataAdapter dtaa = new OracleDataAdapter();
                        dtaa.InsertCommand = sqlc;
                        dtaa.InsertCommand.ExecuteNonQuery();
                        /////////////////////////////////////////////////

                        string Query = ""+(consultas.Variables.UpdateAeronaveToEstado3)+"'" + cboAeronave.SelectedValue + "'";
                        OracleCommand cmdDataBase = new OracleCommand(Query, con);
                        cmdDataBase.ExecuteReader();
                        OracleDataReader drxx = null;
                        drxx = cmdDataBase.ExecuteReader();

                        string sqlStringx = ""+(consultas.Variables.RecorrerAeronaveBuscandoEstado3)+"";
                        OracleCommand dbCmdxx2 = new OracleCommand(sqlStringx, con);
                        OracleDataReader readexr = dbCmdxx2.ExecuteReader();
                        if (readexr.Read())
                        {

                            TipoVariable = readexr["NOMBRE_TIPO_AERONAVE"].ToString();
                            MatriculaVariable = readexr["MATRICULA"].ToString();
                            ModeloVariable = readexr["NOMBRE_MODELO"].ToString();
                            YearVariable = readexr["ANO_FABRICACION"].ToString();
                            FechaTerminoVariable = readexr["FECHA_TERMINO"].ToString();


                            string Command2 = ""+(consultas.Variables.AgruparCorreosDePilotos)+"";
                            OracleCommand Comm12 = new OracleCommand(Command2, con);
                            OracleDataReader DR12 = Comm12.ExecuteReader();
                            if (DR12.Read())
                            {
                                FechaTerminoVariable = DateTime.Now.ToString("dd/MM/yyyy");
                                txtreciever.Text = DR12["correos"].ToString();
                                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Conexión a Gmail
                                MailMessage message = new MailMessage(); // Objeto E-mail
                                message.From = new MailAddress(txtreciever.Text); // Quien envia el e-mail
                                message.To.Add(txtreciever.Text); // Receptor del E-mail
                                txtbody.Text = "Pilotos les avisamos que El Tipo de Aeronave: " + TipoVariable + ", Modelo: " + ModeloVariable + ", del Año: " + YearVariable + " con Matricula / " + MatriculaVariable + " / Se encuentra en Mantenimiento hasta: " + FechaTerminoVariable + "";
                                message.Body = txtbody.Text; // Mensaje E-mail
                                txtsubject.Text = "Aeronave Entra a Mantención";
                                message.Subject = txtsubject.Text; // Asunto del E-mail
                                client.UseDefaultCredentials = false;
                                client.EnableSsl = true;
                                /*if(txtattachment.Text != null)
                                {
                                    message.Attachments.Add(new Attachment(txtattachment.Text)); //Adding attachment
                                }*/
                                client.Credentials = new System.Net.NetworkCredential(txtsender.Text, txtpass.Text);
                                Cursor.Current = Cursors.WaitCursor;
                                client.Send(message); //Enviar Email
                                Cursor.Current = Cursors.Default;
                                message = null; // Liberar Memoria



                            }


                        }
                        string Query2 = ""+(consultas.Variables.UpdateAeronaveToEstado2)+"'" + cboAeronave.SelectedValue + "'";
                        OracleCommand cmdDataBasex = new OracleCommand(Query2, con);
                        cmdDataBasex.ExecuteReader();
                        OracleDataReader drxxx = null;
                        drxxx = cmdDataBasex.ExecuteReader();
                        MessageBox.Show("Ingreso correctamente");
                    }
                   


                    ////////////////////////////////////////////////



                }

            }


            catch
            {
                MessageBox.Show("Error al Agregar");
            }
            con.Close();
        }

        private void cboAeronave_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbMantenimiento2();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
