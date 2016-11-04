using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Oracle.DataAccess.Client;
using Logica;
using Conexion;
using System.Globalization;

namespace Aeronautica.Vistas.Consultor
{
    public partial class ReportesAeronaves : Form
    {
        public ReportesAeronaves()
        {
            InitializeComponent();
        }
        void FillCbAeronave()
        {
            DataTable dt = new DataTable();
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection((consultas.Variables.ConString));
                da = new OracleDataAdapter("" + (consultas.Variables.SelectCboAeronaveFormConsultarHorasVueloAeronave) + "", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();

                dt.Columns.Add("Concatenacion", typeof(string));

                foreach (DataRow dr in dt.Rows)
                {
                    dr["Concatenacion"] = dr["MATRICULA"].ToString();
                }
                DataRow row = dt.NewRow();
                row["Concatenacion"] = "Seleccione un Matricula";
                dt.Rows.InsertAt(row, 0);


                cboMatricula.DataSource = dt;
                cboMatricula.DisplayMember = "Concatenacion";
                cboMatricula.ValueMember = "matricula";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtMatricula.Text) || string.IsNullOrWhiteSpace(this.txtFechaInspeccion.Text))
            {
                MessageBox.Show("Debes Generar Una Busqueda Antes de Realizar un Reporte");
                return;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Reporte  " + txtMatricula.Text + " " + "TipoAeronave - " + txtTipo.Text + "";
                sfd.Filter = "Pdf File |*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                    Document doc = new Document();
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    //PdfWriter.GetInstance(doc, new FileStream("C://Reporte" + txtMatricula.Text + " "  + "TipoAeronave - " + txtTipo.Text + "" + ".PDF", FileMode.Create));
                    doc.Open();
                    var p6 = new Phrase();
                    Paragraph p1 = new Paragraph("Matricula: " + txtMatricula.Text);
                    Paragraph p2 = new Paragraph("Fecha Inspección Anual: " + txtFechaInspeccion.Text);
                    Paragraph p3 = new Paragraph("Días Restantes Para Próxima Fecha de Inspección: " + txtDias.Text);
                    Paragraph p4 = new Paragraph("Fecha de Último Viaje Realizado: " + txtUltimo.Text);
                    Paragraph p7 = new Paragraph("Total Horas de Vuelo: " + txtHorasDeVuelo.Text);
                    Paragraph p5 = new Paragraph("Tipo de Aeronave Seleccionada: " + txtTipo.Text);

                    p6.Add(new Chunk("REPORTE DE AERONAVE" + " " + txtTipo.Text + " " + txtMatricula.Text + "", boldFont));
                    doc.Add(p6);
                    doc.Add(p1);
                    doc.Add(p2);
                    doc.Add(p3);
                    doc.Add(p4);
                    doc.Add(p7);
                    doc.Add(p5);
                    doc.Close();
                    MessageBox.Show("Reporte Creado");
                }

            }
        }
       
        private void ReportesAeronaves_Load(object sender, EventArgs e)
        {
            
            button3.Hide();
            FillCbAeronave();
            ////////////////////////
            txtUltimo.Enabled = false;
            txtTipo.Enabled = false;
            txtMatricula.Enabled = false;
            txtFechaInspeccion.Enabled = false;
            txtHorasDeVuelo.Enabled = false;
            txtDias.Enabled = false;
            //////////////////
            txtMatricula.Hide();
            txtFechaInspeccion.Hide();
            txtDias.Hide();
            txtHorasDeVuelo.Hide();
            txtTipo.Hide();
            txtUltimo.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label6.Hide();
            lblHorasDeVuelo.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Hide();
            cboMatricula.Enabled = true;
            ////////////////////////
            txtUltimo.Enabled = false;
            txtTipo.Enabled = false;
            txtMatricula.Enabled = false;
            txtFechaInspeccion.Enabled = false;
            txtHorasDeVuelo.Enabled = false;
            txtDias.Enabled = false;
            txtDias.Clear();
            txtFechaInspeccion.Clear();
            txtHorasDeVuelo.Clear();
            txtMatricula.Clear();
            txtTipo.Clear();
            txtUltimo.Clear();
            //////////////////
            txtMatricula.Hide();
            txtFechaInspeccion.Hide();
            txtDias.Hide();
            txtHorasDeVuelo.Hide();
            txtTipo.Hide();
            txtUltimo.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label6.Hide();
            lblHorasDeVuelo.Hide();
        }

        private void btnAvion_Click_1(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
            conn.Open();
            try { } catch (Exception ex) { MessageBox.Show(ex.Message); }
            string ValidarAvion = ""+(consultas.Variables.ValidarExistenciaVuelos)+"'" + this.cboMatricula.SelectedValue + "'";
            OracleCommand dbCmdAvion = new OracleCommand(ValidarAvion, conn);
            OracleDataReader reader1 = dbCmdAvion.ExecuteReader();

            if (cboMatricula.Text == "Seleccione un Matricula")
            {
                MessageBox.Show("Debe Seleccionar un matricula");
            }
            OracleConnection cnn = new OracleConnection(consultas.Variables.ConString);
            cnn.Open();
            string sqlString = ""+(consultas.Variables.ValidarTipoAeronaveFormReporte)+"'" + this.cboMatricula.SelectedValue + "' "+(consultas.Variables.ValidarTipoAeronaveFormReporte2)+"";
            OracleCommand dbCmd = new OracleCommand(sqlString, cnn);
            OracleDataReader reader = dbCmd.ExecuteReader();
            if (reader.Read())
            {
                OracleDataReader dr = null;
                OracleCommand cmdx = new OracleCommand(""+(consultas.Variables.DatosAvion)+"'" + this.cboMatricula.SelectedValue + "' "+(consultas.Variables.DatosAvion2)+"", conn);
                try
                {
                    if (reader1.Read())
                    {
                        dr = cmdx.ExecuteReader();
                        if (dr.Read() == true)
                        {
                            button3.Show();
                            cboMatricula.Enabled = false;
                            label1.Show();
                            label2.Show();
                            label3.Show();
                            label4.Show();
                            label6.Show();
                            lblHorasDeVuelo.Show();
                            txtDias.Show();
                            txtFechaInspeccion.Show();
                            txtHorasDeVuelo.Show();
                            txtMatricula.Show();
                            txtTipo.Show();
                            txtUltimo.Show();

                            txtMatricula.Text = dr["MATRICULA"].ToString();
                            txtFechaInspeccion.Text = dr["FECHA_INSPECCION_ANUAL"].ToString();
                            txtUltimo.Text = dr["FECHA_ULTIMO_VUELO"].ToString();
                            txtDias.Text = dr["DIAS_PARA_INSPECCION"].ToString();
                            txtDias.Text = txtDias.Text.Remove(0, 1);
                            txtTipo.Text = "Avión";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Avión con Matricula  '" + this.cboMatricula.Text + "'  NO Posee Vuelos Registrados");
                    }
                    
                }
                catch (Exception ex){MessageBox.Show(ex.Message);}
            }
            else
            {
                if (cboMatricula.Text == "Seleccione un Matricula")
                {
                    
                }
                else
                {
                    MessageBox.Show("La Matricula Seleccionada No Pertenece a un Avión");
                }

                
            }

            OracleConnection cn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            if (cboMatricula.Text == "Seleccione un Matricula")
            {
               
            }
            else
            {
                cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloAeronave1) + "'" + this.cboMatricula.SelectedValue + "'", cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds);
                cn.Close();
                dgvHorasAeronave.DataSource = ds.Tables[0];

                cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloAeronave2) + "'" + this.cboMatricula.SelectedValue + "'", cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds);
                cn.Close();
                dgvHorasAeronave.DataSource = ds.Tables[0];

                cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloAeronave3) + "'" + this.cboMatricula.SelectedValue + "'", cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds);
                cn.Close();
                dgvHorasAeronave.DataSource = ds.Tables[0];

            }

            int suma = 0;
            foreach (DataGridViewRow row in dgvHorasAeronave.Rows)
            {
                suma += (Convert.ToInt32(row.Cells["horas"].Value)) * 60;
                suma += Convert.ToInt32(row.Cells["minutos"].Value);
            }

            int hrs = suma / 60;
            int min = suma %= 60;
            lblSubtotalPiloto.Text = " " + hrs.ToString() + " horas y " + min.ToString() + " minutos";
            txtHorasDeVuelo.Text = lblSubtotalPiloto.Text;
        }

        private void btnHelicoptero_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
            conn.Open();
            try{}catch (Exception ex) { MessageBox.Show(ex.Message); }
            string ValidarHelicoptero = "" + (consultas.Variables.ValidarExistenciaVuelos) + "'" + this.cboMatricula.SelectedValue + "'";
            OracleCommand dbCmdHelicoptero = new OracleCommand(ValidarHelicoptero, conn);
            OracleDataReader reader2 = dbCmdHelicoptero.ExecuteReader();

            if (cboMatricula.Text == "Seleccione un Matricula")
            {
                MessageBox.Show("Debe Seleccionar un matricula");
            }
            OracleConnection cnn = new OracleConnection(consultas.Variables.ConString);
            cnn.Open();
            string sqlString = ""+(consultas.Variables.ValidarTipoAeronaveFormReporteH)+"'" + this.cboMatricula.SelectedValue + "' "+(consultas.Variables.ValidarTipoAeronaveFormReporteH2)+"";
            OracleCommand dbCmd = new OracleCommand(sqlString, cnn);
            OracleDataReader reader = dbCmd.ExecuteReader();
            if (reader.Read())
            {
                OracleDataReader dr = null;
                OracleCommand cmdx = new OracleCommand(""+(consultas.Variables.DatosHelicoptero)+"'" + this.cboMatricula.SelectedValue + "' "+(consultas.Variables.DatosHelicoptero2)+"", conn);
                try
                {
                    if (reader2.Read())
                    {
                        dr = cmdx.ExecuteReader();
                        if (dr.Read() == true)
                        {
                            button3.Show();
                            cboMatricula.Enabled = false;
                            label1.Show();
                            label2.Show();
                            label3.Show();
                            label4.Show();
                            label6.Show();
                            lblHorasDeVuelo.Show();
                            txtDias.Show();
                            txtFechaInspeccion.Show();
                            txtHorasDeVuelo.Show();
                            txtMatricula.Show();
                            txtTipo.Show();
                            txtUltimo.Show();

                            txtMatricula.Text = dr["MATRICULA"].ToString();
                            txtFechaInspeccion.Text = dr["FECHA_INSPECCION_ANUAL"].ToString();
                            txtUltimo.Text = dr["FECHA_ULTIMO_VUELO"].ToString();
                            txtDias.Text = dr["DIAS_PARA_INSPECCION"].ToString();
                            txtDias.Text = txtDias.Text.Remove(0, 1);
                            txtTipo.Text = "Helicóptero";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Helicóptero con Matricula  '" + this.cboMatricula.Text + "'  NO Posee Vuelos Registrados");
                    }
                    
                }
                catch (Exception ex){MessageBox.Show(ex.Message);}
            }
            else
            {
                if (cboMatricula.Text == "Seleccione un Matricula")
                {
                   
                }
                else
                {
                    MessageBox.Show("La Matricula Seleccionada No Pertenece a un Helicóptero");
                }
                
            }

            OracleConnection cn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            if (cboMatricula.Text == "Seleccione un Matricula")
            {
                
            }
            else
            {
                cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloAeronave1) + "'" + this.cboMatricula.SelectedValue + "'", cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds);
                cn.Close();
                dgvHorasAeronave.DataSource = ds.Tables[0];

                cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloAeronave2) + "'" + this.cboMatricula.SelectedValue + "'", cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds);
                cn.Close();
                dgvHorasAeronave.DataSource = ds.Tables[0];

                cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloAeronave3) + "'" + this.cboMatricula.SelectedValue + "'", cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds);
                cn.Close();
                dgvHorasAeronave.DataSource = ds.Tables[0];

            }

            int suma = 0;
            foreach (DataGridViewRow row in dgvHorasAeronave.Rows)
            {
                suma += (Convert.ToInt32(row.Cells["horas"].Value)) * 60;
                suma += Convert.ToInt32(row.Cells["minutos"].Value);
            }

            int hrs = suma / 60;
            int min = suma %= 60;
            lblSubtotalPiloto.Text = " " + hrs.ToString() + " horas y " + min.ToString() + " minutos";
            txtHorasDeVuelo.Text = lblSubtotalPiloto.Text;
        }

        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


