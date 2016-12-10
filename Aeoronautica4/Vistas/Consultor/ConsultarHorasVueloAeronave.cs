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
    public partial class ConsultarHorasVueloAeronave : Form
    {
        public static string HorasA;
        public static string MinutosA;
        private BindingSource bindingSource1 = new BindingSource();
        public ConsultarHorasVueloAeronave()
        {
            InitializeComponent();
            FillCbAeronave();
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {

            OracleConnection cn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd;
            DataSet ds = new DataSet();
            DataSet ds2 = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            if (cboMatricula.Text == "Seleccione un Matricula")
            {
                MessageBox.Show("Debe Seleccionar un matricula");
            }
            else
            {
                cmd = new OracleCommand(""+(consultas.Variables.ConsultarHorasVueloAeronaveVHA)+"'" + this.cboMatricula.SelectedValue + "'", cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds);
                cn.Close();
                dgvHorasAeronave.DataSource = ds.Tables[0];


                cmd = new OracleCommand(""+(consultas.Variables.ConsultarHorasComponentes)+" '"+cboMatricula.SelectedValue+"'", cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds2);
                cn.Close();
                dgvhorasComponente.DataSource = ds2.Tables[0];

                lblSubtotalPiloto.Text = "Total Horas de Vuelo: " + dgvHorasAeronave.CurrentRow.Cells[0].Value.ToString() + " horas y " + dgvHorasAeronave.CurrentRow.Cells[1].Value.ToString() + " minutos";
                HorasA = dgvHorasAeronave.CurrentRow.Cells[0].Value.ToString();
                MinutosA = dgvHorasAeronave.CurrentRow.Cells[1].Value.ToString();

                btnGenerar.Enabled = true;

            }

            
        }




        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPiloto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cboLicencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarHorasVueloAeronave_Load(object sender, EventArgs e)
        {
            btnGenerar.Enabled = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dgvHorasAeronave.Rows.Count == 0)
            {
                MessageBox.Show("Deben existir datos para generar un reporte", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Reporte Horas de Vuelo Aeronave";
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

                    iTextSharp.text.Font fontTable5 = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                    var p6 = new Phrase();
                    p6.Add(new Chunk("REPORTE DE HORAS DE VUELO DE AERONAVE\n\n", boldFont));
                    doc.Add(p6);

                    var p71 = new Phrase();
                    p71.Add(new Chunk("\n\nAERONAVE\n\n", fontTable5));
                    doc.Add(p71);

                    Paragraph p2 = new Paragraph("Matricula: " + cboMatricula.SelectedValue + " \n\n");
                    doc.Add(p2);
                    /*Insertar DataGrid*/
                    iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                    /**/
                    PdfPTable tablex = new PdfPTable(2);



                    tablex.AddCell(new PdfPCell(new Phrase("HORAS", fontTable2)));
                    tablex.AddCell(new PdfPCell(new Phrase("MINUTOS", fontTable2))); 

                    PdfPTable tablex2 = new PdfPTable(2);

                     tablex2.AddCell(new PdfPCell(new Phrase(HorasA, fontTable)));
                     tablex2.AddCell(new PdfPCell(new Phrase(MinutosA, fontTable)));
                    

                   
                    doc.Add(tablex);
                    doc.Add(tablex2);

                    /**/


                    var p7 = new Phrase();
                    p7.Add(new Chunk("\n\nCOMPONENTES\n\n", fontTable5));
                    doc.Add(p7);

                    iTextSharp.text.Font fontTable3 = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    iTextSharp.text.Font fontTable4 = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                    PdfPTable table2 = new PdfPTable(dgvhorasComponente.Columns.Count);

                    for (int j = 0; j < dgvhorasComponente.Columns.Count; j++)
                    {
                        table2.AddCell(new Phrase(dgvhorasComponente.Columns[j].HeaderText, fontTable4));
                    }

                    table2.HeaderRows = 1;

                    for (int i = 0; i < dgvhorasComponente.Rows.Count; i++)
                    {
                        for (int k = 0; k < dgvhorasComponente.Columns.Count; k++)
                        {
                            if (dgvhorasComponente[k, i].Value != null)
                            {
                                table2.AddCell(new Phrase(dgvhorasComponente[k, i].Value.ToString(), fontTable3));
                            }
                        }
                    }
                    doc.Add(table2);


                    doc.Close();
                    MessageBox.Show("Reporte Creado", "REPORTE CREADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
        }

        private void dgvhorasComponente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
