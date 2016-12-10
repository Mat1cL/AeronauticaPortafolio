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
using System.Windows.Forms.DataVisualization.Charting;

namespace Aeronautica
{
    public partial class ConsultarHorasVuelo : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public ConsultarHorasVuelo()
        {
            InitializeComponent();
        }
        void FillCbTipoLicencia()
        {
            DataTable dt = new DataTable();
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection((consultas.Variables.ConString));
                da = new OracleDataAdapter(""+(consultas.Variables.ConsultarHorasVueloPilotoCboTipoLicencia)+"'" + this.cboPiloto.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["numero_licencia"] = Convert.ToInt32("0");
                row["nombre_tipo_licencia"] = "Seleccione un Tipo de Licencia";
                dt.Rows.InsertAt(row, 0);
                this.cboLicencia.DataSource = dt;
                this.cboLicencia.DisplayMember = "nombre_tipo_licencia";
                this.cboLicencia.ValueMember = "numero_licencia";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        void FillCbPiloto()
        {
            DataTable dt = new DataTable();
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection((consultas.Variables.ConString));
                da = new OracleDataAdapter(""+(consultas.Variables.ConsultarHorasVueloPilotoCboPiloto)+"", conn);
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {

            OracleConnection cn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            if (cboPiloto.Text == "Seleccione un Piloto")
            {
                MessageBox.Show("Debe Seleccionar un Piloto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (cboLicencia.Text == "Seleccione un Tipo de Licencia")
                {
                    cmd = new OracleCommand(""+(consultas.Variables.ConsultarHorasVueloPiloto)+"'" + this.cboPiloto.SelectedValue + "'", cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    cn.Close();
                    dgvHorasPiloto.DataSource = ds.Tables[0];

                    cmd = new OracleCommand(""+(consultas.Variables.ConsultarHorasVueloPiloto2)+"'" + this.cboPiloto.SelectedValue + "'", cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    cn.Close();
                    dgvHorasPiloto.DataSource = ds.Tables[0];

                }
                else
                {
                    cmd = new OracleCommand(""+(consultas.Variables.ConsultarHorasVueloPiloto3)+"'" + this.cboPiloto.SelectedValue + "' "+(consultas.Variables.ConsultarHorasVueloPiloto3_1)+" " + this.cboLicencia.SelectedValue, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    cn.Close();
                    dgvHorasPiloto.DataSource = ds.Tables[0];

                    cmd = new OracleCommand(""+(consultas.Variables.ConsultarHorasVueloPiloto4)+"'" + this.cboPiloto.SelectedValue + "' "+(consultas.Variables.ConsultarHorasVueloPiloto4_1)+" " + this.cboLicencia.SelectedValue, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    cn.Close();
                    dgvHorasPiloto.DataSource = ds.Tables[0];
                }

                int suma = 0;
                foreach (DataGridViewRow row in dgvHorasPiloto.Rows)
                {
                    suma += (Convert.ToInt32(row.Cells["horas"].Value)) * 60;
                    suma += Convert.ToInt32(row.Cells["minutos"].Value);
                }

                int hrs = suma / 60;
                int min = suma %= 60;
                lblSubtotalPiloto.Text = "Total Horas de Vuelo: " + hrs.ToString() + " horas y " + min.ToString() + " minutos";
                btnGenerar.Enabled = true;
            }

        }

        

        private void VistaOperadorConsultarHorasVuelo_Load(object sender, EventArgs e)
        {
            FillCbPiloto();
            btnGenerar.Enabled = false;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPiloto_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbTipoLicencia();
        }


        private void cboLicencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dgvHorasPiloto.Rows.Count == 0)
            {
                MessageBox.Show("Deben existir datos para generar un reporte", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Reporte de Horas de Vuelo Piloto";
                sfd.Filter = "Pdf File |*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                    Document doc = new Document();
                    try
                    {
                        PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    }
                    catch
                    {
                        MessageBox.Show("El archivo que intenta reemplazar actualmente se encuentra en ejecución", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    doc.Open();

                    if (cboLicencia.Text != "Seleccione un Tipo de Licencia")
                    {
                        //btnFiltrarWasClicked = false;
                        /*Insertar Imagen*/
                        System.Drawing.Image test = System.Drawing.Image.FromHbitmap(Properties.Resources.logoescuadrilla.GetHbitmap());
                        iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(test, System.Drawing.Imaging.ImageFormat.Png);
                        PNG.ScalePercent(35f);
                        PNG.Alignment = Element.ALIGN_RIGHT;
                        doc.Add(PNG);
                        /*Fin Insertar Imagen*/

                        Paragraph p3 = new Paragraph("\n\n");
                        doc.Add(p3);

                        var p6 = new Phrase();
                        p6.Add(new Chunk("HORAS DE VUELO PILOTO FILTRADO POR LICENCIA\n\n", boldFont));
                        doc.Add(p6);

                        Paragraph p45 = new Paragraph("Piloto: " + cboPiloto.Text + " \n\n");
                        doc.Add(p45);

                        Paragraph p2 = new Paragraph("Nombre Licencia: " + cboLicencia.Text + " \n\n");
                        doc.Add(p2);
                        /*Insertar DataGrid*/
                        iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        PdfPTable table = new PdfPTable(dgvHorasPiloto.Columns.Count);

                        for (int j = 0; j < dgvHorasPiloto.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvHorasPiloto.Columns[j].HeaderText, fontTable2));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dgvHorasPiloto.Rows.Count; i++)
                        {
                            for (int k = 0; k < dgvHorasPiloto.Columns.Count; k++)
                            {
                                if (dgvHorasPiloto[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvHorasPiloto[k, i].Value.ToString(), fontTable));
                                }
                            }
                        }
                        doc.Add(table);

                        Paragraph p9 = new Paragraph("\n" + lblSubtotalPiloto.Text + "");
                        doc.Add(p9);
                        /*Fin Insertar DataGrid*/




                        doc.Close();
                        MessageBox.Show("Reporte Creado", "REPORTE CREADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        /*Insertar Imagen*/
                        System.Drawing.Image test = System.Drawing.Image.FromHbitmap(Properties.Resources.logoescuadrilla.GetHbitmap());
                        iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(test, System.Drawing.Imaging.ImageFormat.Png);
                        PNG.ScalePercent(35f);
                        PNG.Alignment = Element.ALIGN_RIGHT;
                        doc.Add(PNG);
                        /*Fin Insertar Imagen*/

                        Paragraph p3 = new Paragraph("\n\n");
                        doc.Add(p3);

                        var p6 = new Phrase();
                        p6.Add(new Chunk("TODAS LAS HORAS DE VUELO PILOTO\n\n", boldFont));
                        doc.Add(p6);

                        Paragraph p45 = new Paragraph("Piloto: " + cboPiloto.Text + " \n\n");
                        doc.Add(p45);

                        /*Insertar DataGrid*/
                        iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        PdfPTable table = new PdfPTable(dgvHorasPiloto.Columns.Count);

                        for (int j = 0; j < dgvHorasPiloto.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvHorasPiloto.Columns[j].HeaderText, fontTable2));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dgvHorasPiloto.Rows.Count; i++)
                        {
                            for (int k = 0; k < dgvHorasPiloto.Columns.Count; k++)
                            {
                                if (dgvHorasPiloto[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvHorasPiloto[k, i].Value.ToString(), fontTable));
                                }
                            }
                        }
                        doc.Add(table);
                        Paragraph p9 = new Paragraph("\n" + lblSubtotalPiloto.Text + "");
                        doc.Add(p9);
                        /*Fin Insertar DataGrid*/




                        doc.Close();

                        MessageBox.Show("Reporte Creado", "REPORTE CREADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }






            }
        }
    }
}
