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

namespace Aeronautica.Vistas.Consultor
{
    
    public partial class CosultarListaPilotos : Form
    {
        public CosultarListaPilotos()
        {
            InitializeComponent();
            fill();
        }

        public static string V1;
        public static string V2;
     
        public void fill(){
            OracleConnection cn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();

            cmd = new OracleCommand(""+(consultas.Variables.consultarlistaPilotos), cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    cn.Close();
                    dgvListaPiloto.DataSource = ds.Tables[0];
        }
        public void fill2()
        {
            OracleConnection cn = new OracleConnection((consultas.Variables.ConString));
            OracleCommand cmd;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            V1 = dtDesde.Value.ToString();
            V2 = dtHasta.Value.ToString();
            cmd = new OracleCommand(""+(consultas.Variables.ConsultarRankingPilotoFiltrado)+"'"+dtDesde.Text+"'"+(consultas.Variables.ConsultarRankingPilotoFiltrado2)+"'"+dtHasta.Text+"' "+(consultas.Variables.ConsultarRankingPilotoFiltrado3)+"'"+dtDesde.Text+"'"+(consultas.Variables.ConsultarRankingPilotoFiltrado4)+"'"+dtHasta.Text+"'"+(consultas.Variables.ConsultarRankingPilotoFiltrado5)+"", cn);
            cn.Open();
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;
            da.Fill(ds);
            cn.Close();
            dgvListaPiloto.DataSource = ds.Tables[0];
        }
  

        private void CosultarListaPilotos_Load(object sender, EventArgs e)
        {
            btnVolverFiltrar.Hide();
            chart2.Hide();
            try
            {
                for (int i = 0; i < dgvListaPiloto.Rows.Count - 1; i++)
                {
                    this.chart1.Series["HORAS"].Points.AddXY(dgvListaPiloto.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dgvListaPiloto.Rows[i].Cells[3].Value.ToString()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CARGAR GRÁFICO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
            }

        private void dgvListaPiloto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool btnFiltrarWasClicked = false;
        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dgvListaPiloto.Rows.Count == 0)
            {
                MessageBox.Show("Deben existir datos para generar un reporte", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Reporte TOP Pilotos";
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
                    if (btnFiltrarWasClicked)
                    {
                        /*Insertar Imagen*/
                        System.Drawing.Image test = System.Drawing.Image.FromHbitmap(Properties.Resources.logoescuadrilla.GetHbitmap());
                        iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(test, System.Drawing.Imaging.ImageFormat.Png);
                        PNG.ScalePercent(35f);
                        PNG.Alignment = Element.ALIGN_RIGHT;
                        doc.Add(PNG);
                        /*Fin Insertar Imagen*/

                        var p6 = new Phrase();
                        p6.Add(new Chunk("REPORTE TOP DE PILOTOS FILTRADO\n\n", boldFont));
                        doc.Add(p6);

                        Paragraph p2 = new Paragraph("Fecha de Filtro: " + dtDesde.Text + " - " + dtHasta.Text + " \n\n");
                        doc.Add(p2);

                        /*Insertar DataGrid*/
                        PdfPTable table = new PdfPTable(dgvListaPiloto.Columns.Count);

                        for (int j = 0; j < dgvListaPiloto.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvListaPiloto.Columns[j].HeaderText));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dgvListaPiloto.Rows.Count; i++)
                        {
                            for (int k = 0; k < dgvListaPiloto.Columns.Count; k++)
                            {
                                if (dgvListaPiloto[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvListaPiloto[k, i].Value.ToString()));
                                }
                            }
                        }
                        doc.Add(table);
                        /*Fin Insertar DataGrid*/

                        Paragraph p1 = new Paragraph("\n\n");
                        doc.Add(p1);

                        /*Insertar Gráfico*/
                        var chartimage = new MemoryStream();
                        chart2.SaveImage(chartimage, ChartImageFormat.Png);
                        iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
                        doc.Add(Chart_image);
                        /*Fin Insertar Gráfico*/
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

                        var p6 = new Phrase();
                        p6.Add(new Chunk("REPORTE TOP DE PILOTOS\n\n", boldFont));
                        doc.Add(p6);

                        /*Insertar DataGrid*/
                        PdfPTable table = new PdfPTable(dgvListaPiloto.Columns.Count);

                        for (int j = 0; j < dgvListaPiloto.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvListaPiloto.Columns[j].HeaderText));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dgvListaPiloto.Rows.Count; i++)
                        {
                            for (int k = 0; k < dgvListaPiloto.Columns.Count; k++)
                            {
                                if (dgvListaPiloto[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvListaPiloto[k, i].Value.ToString()));
                                }
                            }
                        }
                        doc.Add(table);
                        /*Fin Insertar DataGrid*/

                        Paragraph p1 = new Paragraph("\n\n");
                        doc.Add(p1);

                        /*Insertar Gráfico*/
                        var chartimage = new MemoryStream();
                        chart1.SaveImage(chartimage, ChartImageFormat.Png);
                        iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
                        doc.Add(Chart_image);
                        /*Fin Insertar Gráfico*/
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            btnFiltrarWasClicked = true;
            fill2();
            chart1.Hide();
            chart2.Show();
            dtDesde.Enabled = false;
            dtHasta.Enabled = false;
            btnFiltrar.Hide();
            btnVolverFiltrar.Show();
            try
            {
                for (int i = 0; i < dgvListaPiloto.Rows.Count - 1; i++)
                {
                    this.chart2.Series["HORAS."].Points.AddXY(dgvListaPiloto.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dgvListaPiloto.Rows[i].Cells[3].Value.ToString()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL CARGAR GRÁFICO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolverFiltrar_Click(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            chart2.Series.Add("HORAS.");
            dtDesde.Enabled = true;
            dtHasta.Enabled = true;
            btnFiltrar.Show();
            btnVolverFiltrar.Hide();
        }
        }

        
    }

