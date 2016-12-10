using Logica;
using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Aeronautica.Vistas.Operador.Ingresos
{
    public partial class IngresarDetalleMantenimiento : Form
    {
        public static string MatriculaVariable;
        public static string ModeloVariable;
        public static string TipoVariable;
        public static string FechaTerminoVariable;
        public static string FechaTerminoVariable2;
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
                    dr["Concatenacion"] = "" + dr["horas_vuelo"].ToString();
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
            label2.Hide();
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

            Logica.Clases.Mantenimiento.FechaIngreso_ = dtIngreso.Text;
            Logica.Clases.Mantenimiento.FechaTermino_ = dtTermino.Text;
            Logica.Clases.Mantenimiento.NombreTaller_ = cboTaller.SelectedValue.ToString();
            Logica.Clases.Mantenimiento.TipoMantenimiento_ = cboMantenimiento2.SelectedValue.ToString();
            Logica.Clases.Mantenimiento.Aeronave_ = cboAeronave.SelectedValue.ToString();

            try
            {
                /*INICIO LIMPIAR ERRORES*/
                if (cboTaller.Text != "Seleccione un Taller")
                {
                    errorProvider1.SetError(cboTaller, string.Empty);
                }
                if (cboAeronave.Text != "Seleccione una Aeronave")
                {
                    errorProvider1.SetError(cboAeronave, string.Empty);
                }
                if (cboMantenimiento2.Text != "Seleccione un Mantenimiento")
                {
                    errorProvider1.SetError(cboMantenimiento2, string.Empty);
                }
                if (dtIngreso.Value > DateTime.Today)
                {
                    errorProvider1.SetError(dtIngreso, string.Empty);
                }
                if (dtTermino.Value > DateTime.Today)
                {
                    errorProvider1.SetError(dtTermino, string.Empty);
                }
                if (dtIngreso.Value < dtTermino.Value)
                {
                    errorProvider1.SetError(dtTermino, string.Empty);
                }
                /*FIN LIMPIAR ERRORES*/

                /*INICIO DECLARAR ERRORES*/
                if (cboTaller.Text == "Seleccione un Taller")
                {
                    errorProvider1.SetError(cboTaller, "Debes seleccionar un Taller");
                }
                if (cboAeronave.Text == "Seleccione una Aeronave")
                {
                    errorProvider1.SetError(cboAeronave, "Debes seleccionar una Aeronave");
                }
                if (cboMantenimiento2.Text == "Seleccione un Mantenimiento")
                {
                    errorProvider1.SetError(cboMantenimiento2, "Debes seleccionar un Mantenimiento");
                }
                if (dtIngreso.Value < DateTime.Today)
                {
                    errorProvider1.SetError(dtIngreso, "No puedes ingresar una fecha de Ingreso de Mantenimiento inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");
                }
                if (dtTermino.Value < DateTime.Today)
                {
                    errorProvider1.SetError(dtTermino, "No puedes ingresar una fecha de Término de Mantenimiento inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "");
                }
                if (dtIngreso.Value > dtTermino.Value)
                {
                    errorProvider1.SetError(dtTermino, "La Fecha de Término debe ser mayor a la Fecha de Ingreso: " + dtIngreso.Text + "");
                }
                /*FIN DECLARAR ERRORES*/

                /*VALIDAR SI EXISTEN ERRORES*/
                if (errorProvider1.GetError(cboTaller) == "Debes seleccionar un Taller")
                {
                    return;
                }
                if (errorProvider1.GetError(cboAeronave) == "Debes seleccionar una Aeronave")
                {
                    return;
                }
                if (errorProvider1.GetError(cboMantenimiento2) == "Debes seleccionar un Mantenimiento")
                {
                    return;
                }
                if (errorProvider1.GetError(dtIngreso) == "No puedes ingresar una fecha de Ingreso de Mantenimiento inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "")
                {
                    return;
                }
                if (errorProvider1.GetError(dtTermino) == "No puedes ingresar una fecha de Término de Mantenimiento inferior a la Actual: " + DateTime.Now.ToString("dd/MM/yyyy") + "")
                {
                    return;
                }
                if (errorProvider1.GetError(dtTermino) == "La Fecha de Término debe ser mayor a la Fecha de Ingreso: " + dtIngreso.Text + "")
                {
                    return;
                }
                /*FIN VALIDAR SI EXISTEN ERRORES*/

                
                
                else
                {
                    string sqlStringx2 = "" + (consultas.Variables.ValidarMantenimiento) + "'" + Logica.Clases.Mantenimiento.Aeronave_ + "' " + (consultas.Variables.ValidarMatenimiento2) + "";
                    OracleCommand dbCmdxxx2 = new OracleCommand(sqlStringx2, con);
                    OracleDataReader readexr2 = dbCmdxxx2.ExecuteReader();
                    if (readexr2.Read())
                    {
                        MessageBox.Show("La Aeronave ya se encuentra en Mantenimiento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        OracleCommand sqlc = new OracleCommand("" + (consultas.Variables.InsertarDetalleMantenimiento) + "('" + Logica.Clases.Mantenimiento.FechaIngreso_ + "','" + Logica.Clases.Mantenimiento.FechaTermino_ + "','" + Logica.Clases.Mantenimiento.NombreTaller_ + "','" + Logica.Clases.Mantenimiento.TipoMantenimiento_ + "','" + Logica.Clases.Mantenimiento.Aeronave_ + "')", con);
                        OracleDataAdapter dtaa = new OracleDataAdapter();
                        dtaa.InsertCommand = sqlc;
                        dtaa.InsertCommand.ExecuteNonQuery();
                        /////////////////////////////////////////////////

                        string Query = "" + (consultas.Variables.UpdateAeronaveToEstado3) + "'" + Logica.Clases.Mantenimiento.Aeronave_ + "'";
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

                        }
                        string Query2 = "" + (consultas.Variables.UpdateAeronaveToEstado2) + "'" + Logica.Clases.Mantenimiento.Aeronave_ + "'";
                        OracleCommand cmdDataBasex = new OracleCommand(Query2, con);
                        cmdDataBasex.ExecuteReader();
                        OracleDataReader drxxx = null;
                        drxxx = cmdDataBasex.ExecuteReader();
                        MessageBox.Show("Ingreso correctamente", "INGRESO CORRECTAMENTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        try
                        {
                            string Command2 = "" + (consultas.Variables.AgruparCorreosDePilotos) + "";
                            OracleCommand Comm12 = new OracleCommand(Command2, con);
                            OracleDataReader DR12 = Comm12.ExecuteReader();
                            if (DR12.Read())
                            {
    
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
                                MessageBox.Show("CORREO DE MANTENIMIENTO ENVIADO CORRECTAMENTE", "CORREOS ENVIADOS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error de Conexión al Enviar Correos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        this.Close();


                    }
                    


                    ////////////////////////////////////////////////



                }

            }


            catch
            {
                MessageBox.Show("Error al Agregar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
