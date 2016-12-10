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


namespace Aeronautica.Vistas.Consultor.Mantenimientos
{
    public partial class ConsultarMantenimientosHistoricos : Form
    {
        public ConsultarMantenimientosHistoricos()
        {
            InitializeComponent();
        }

        private void ConsultarMantenimientosHistoricos_Load(object sender, EventArgs e)
        {
            btnFiltrar.Enabled = false;
            txtMatricula.Enabled = false;
            btnReporte.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
            txtMatricula.Enabled = true;
            btnReporte.Enabled = true;
            btnFiltrar.Enabled = true;
            txtMatricula.Clear();
            btnFiltrarWasClicked = false;
            try
            {
                OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                conn.Open();
                OracleCommand cmd = new OracleCommand(""+(consultas.Variables.ConsultarMantenimientosHistoricos)+"", conn);
                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dgvMantenimientos.DefaultCellStyle.Format = "g";
                dgvMantenimientos.DataSource = ds.Tables[0];
                dgvMantenimientos.AllowUserToResizeColumns = false;
                dgvMantenimientos.AllowUserToResizeRows = false;
                dgvMantenimientos.MultiSelect = false;
                dgvMantenimientos.Columns["TIPO_AERONAVE"].HeaderText = "TIPO DE AERONAVE";
                dgvMantenimientos.Columns["FABRICANTE"].HeaderText = "FABRICANTE DE AERONAVE";
                dgvMantenimientos.Columns["FABRICANTE"].Width = 168;
                dgvMantenimientos.Columns["HORAS_VUELO"].HeaderText = "TIPO DE MANTENIMIENTO";
                dgvMantenimientos.Columns["HORAS_VUELO"].Width = 140;
                dgvMantenimientos.Columns["FECHA_INGRESO"].HeaderText = "FECHA DE INGRESO";
                dgvMantenimientos.Columns["FECHA_TERMINO"].HeaderText = "FECHA DE TÉRMINO";
                dgvMantenimientos.Columns["TALLER"].HeaderText = "NOMBRE DE TALLER MECÁNICO";
                dgvMantenimientos.Columns["TALLER"].Width = 123;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            btnFiltrarWasClicked = true;
            OracleConnection cnn = new OracleConnection(consultas.Variables.ConString);
            cnn.Open();
            string sqlString2 = "" + (consultas.Variables.FiltrarMatriculaMantenimientoHistoricoValidarSiExiste) + " '" + txtMatricula.Text + "'";
            OracleCommand dbCmdx2 = new OracleCommand(sqlString2, cnn);
            OracleDataReader reader = dbCmdx2.ExecuteReader();
            if (reader.Read())
            {
                try
                {
                    OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(""+(consultas.Variables.FiltrarMatriculaMantenimientoHistorico)+" '"+txtMatricula.Text+"'", conn);
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dgvMantenimientos.DefaultCellStyle.Format = "g";
                    dgvMantenimientos.DataSource = ds.Tables[0];
                    dgvMantenimientos.AllowUserToResizeColumns = false;
                    dgvMantenimientos.AllowUserToResizeRows = false;
                    dgvMantenimientos.MultiSelect = false;
                    dgvMantenimientos.Columns["TIPO_AERONAVE"].HeaderText = "TIPO DE AERONAVE";
                    dgvMantenimientos.Columns["FABRICANTE"].HeaderText = "FABRICANTE DE AERONAVE";
                    dgvMantenimientos.Columns["FABRICANTE"].Width = 168;
                    dgvMantenimientos.Columns["HORAS_VUELO"].HeaderText = "TIPO DE MANTENIMIENTO";
                    dgvMantenimientos.Columns["HORAS_VUELO"].Width = 140;
                    dgvMantenimientos.Columns["FECHA_INGRESO"].HeaderText = "FECHA DE INGRESO";
                    dgvMantenimientos.Columns["FECHA_TERMINO"].HeaderText = "FECHA DE TÉRMINO";
                    dgvMantenimientos.Columns["TALLER"].HeaderText = "NOMBRE DE TALLER MECÁNICO";
                    dgvMantenimientos.Columns["TALLER"].Width = 123;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
            else
            {
                MessageBox.Show("La Aeronave filtrada no posee Mantenimientos Históricos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool btnFiltrarWasClicked = false;
        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dgvMantenimientos.Rows.Count == 0)
            {
                MessageBox.Show("Deben existir datos para generar un reporte", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Reporte Mantenimientos Historicos";
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

                    if ((txtMatricula.Text.Length > 0) && btnFiltrarWasClicked)
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
                        p6.Add(new Chunk("FILTRADO DE MANTENIMIENTOS\n\n HISTÓRICOS\n\n", boldFont));
                        doc.Add(p6);


                        Paragraph p2 = new Paragraph("Filtro de Matricula: " + txtMatricula.Text + " \n\n");
                        doc.Add(p2);
                        /*Insertar DataGrid*/
                        iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        PdfPTable table = new PdfPTable(dgvMantenimientos.Columns.Count);

                        for (int j = 0; j < dgvMantenimientos.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvMantenimientos.Columns[j].HeaderText, fontTable2));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dgvMantenimientos.Rows.Count; i++)
                        {
                            for (int k = 0; k < dgvMantenimientos.Columns.Count; k++)
                            {
                                if (dgvMantenimientos[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvMantenimientos[k, i].Value.ToString(), fontTable));
                                }
                            }
                        }
                        doc.Add(table);
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
                        p6.Add(new Chunk("REPORTE DE TODOS LOS MANTENIMIENTOS\n\n HISTÓRICOS\n\n", boldFont));
                        doc.Add(p6);

                        /*Insertar DataGrid*/
                        iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        PdfPTable table = new PdfPTable(dgvMantenimientos.Columns.Count);

                        for (int j = 0; j < dgvMantenimientos.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvMantenimientos.Columns[j].HeaderText, fontTable2));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dgvMantenimientos.Rows.Count; i++)
                        {
                            for (int k = 0; k < dgvMantenimientos.Columns.Count; k++)
                            {
                                if (dgvMantenimientos[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvMantenimientos[k, i].Value.ToString(), fontTable));
                                }
                            }
                        }
                        doc.Add(table);
                        /*Fin Insertar DataGrid*/




                        doc.Close();

                        MessageBox.Show("Reporte Creado", "REPORTE CREADO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }






            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMatricula.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
