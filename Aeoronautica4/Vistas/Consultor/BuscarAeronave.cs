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
    public partial class BuscarAeronave : Form
    {
        public BuscarAeronave()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            btnVolverFiltrar.Hide();
            btnFiltrar.Show();
            txtMatricula.Enabled = true;
            btnReporte.Enabled = true;
            btnFiltrar.Enabled = true;
            txtMatricula.Clear();
            btnFiltrarWasClicked = false;
            try
            {
                OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                conn.Open();
                OracleCommand cmd = new OracleCommand(""+(consultas.Variables.BuscarAeronavex)+"", conn);
                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dgvAeronave.DefaultCellStyle.Format = "g";
                dgvAeronave.DataSource = ds.Tables[0];
                dgvAeronave.AllowUserToResizeColumns = false;
                dgvAeronave.AllowUserToResizeRows = false;
                dgvAeronave.MultiSelect = false;
                dgvAeronave.Columns["FECHA_INSPECCION_ANUAL"].HeaderText = "FECHA DE INSPECCION ANUAL";
                dgvAeronave.Columns["FECHA_INSPECCION_ANUAL"].Width = 100;
                dgvAeronave.Columns["ANO_FABRICACION"].HeaderText = "AÑO DE FABRICACIÓN";
                dgvAeronave.Columns["ANO_FABRICACION"].Width = 100;
                dgvAeronave.Columns["NOMBRE_TIPO_AERONAVE"].HeaderText = "TIPO DE AERONAVE";
                dgvAeronave.Columns["NOMBRE_FABRICANTE"].HeaderText = "NOMBRE DE FABRICANTE";
                dgvAeronave.Columns["NOMBRE_FABRICANTE"].Width = 170;
                dgvAeronave.Columns["NOMBRE_MODELO"].HeaderText = "MODELO";
                dgvAeronave.Columns["NOMBRE_MODELO"].Width = 100;
                dgvAeronave.Columns["NOMBRE_ESTADO"].HeaderText = "ESTADO";
                dgvAeronave.Columns["NOMBRE_ESTADO"].Width = 107;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnVolverFiltrar_Click(object sender, EventArgs e)
        {
            btnVolverFiltrar.Hide();
            btnFiltrar.Show();
            txtMatricula.Clear();
            txtMatricula.Enabled = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            btnFiltrarWasClicked = true;

            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Debe Ingresar una Matricula", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                OracleConnection cnn = new OracleConnection(consultas.Variables.ConString);
                cnn.Open();
                string sqlString2 = "" + (consultas.Variables.ValidarSiExisteAeronavex) + "'" + txtMatricula.Text + "'";
                OracleCommand dbCmdx2 = new OracleCommand(sqlString2, cnn);
                OracleDataReader reader = dbCmdx2.ExecuteReader();
                if (reader.Read())
                {
                    try
                    {
                        OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                        conn.Open();
                        OracleCommand cmd = new OracleCommand(""+(consultas.Variables.BuscarAeronavexFiltro)+"'" + txtMatricula.Text + "'", conn);
                        cmd.CommandType = CommandType.Text;
                        DataSet ds = new DataSet();
                        OracleDataAdapter da = new OracleDataAdapter();
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        dgvAeronave.DefaultCellStyle.Format = "g";
                        dgvAeronave.DataSource = ds.Tables[0];
                        dgvAeronave.AllowUserToResizeColumns = false;
                        dgvAeronave.AllowUserToResizeRows = false;
                        dgvAeronave.MultiSelect = false;
                        dgvAeronave.Columns["FECHA_INSPECCION_ANUAL"].HeaderText = "FECHA DE INSPECCION ANUAL";
                        dgvAeronave.Columns["FECHA_INSPECCION_ANUAL"].Width = 100;
                        dgvAeronave.Columns["ANO_FABRICACION"].HeaderText = "AÑO DE FABRICACIÓN";
                        dgvAeronave.Columns["ANO_FABRICACION"].Width = 100;
                        dgvAeronave.Columns["NOMBRE_TIPO_AERONAVE"].HeaderText = "TIPO DE AERONAVE";
                        dgvAeronave.Columns["NOMBRE_FABRICANTE"].HeaderText = "NOMBRE DE FABRICANTE";
                        dgvAeronave.Columns["NOMBRE_FABRICANTE"].Width = 170;
                        dgvAeronave.Columns["NOMBRE_MODELO"].HeaderText = "MODELO";
                        dgvAeronave.Columns["NOMBRE_MODELO"].Width = 100;
                        dgvAeronave.Columns["NOMBRE_ESTADO"].HeaderText = "ESTADO";
                        dgvAeronave.Columns["NOMBRE_ESTADO"].Width = 107;
                        txtMatricula.Enabled = false;
                        btnFiltrar.Hide();
                        btnVolverFiltrar.Show();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
                else
                {
                    MessageBox.Show("La Matricula no se encuentra asignada a una Aeronave", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private bool btnFiltrarWasClicked = false;
        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dgvAeronave.Rows.Count == 0)
            {
                MessageBox.Show("Deben existir datos para generar un reporte", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Reporte Datos Aeronave";
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
                        p6.Add(new Chunk("FILTRADO DE AERONAVE\n\n", boldFont));
                        doc.Add(p6);


                        Paragraph p2 = new Paragraph("Filtro de Matricula: " + txtMatricula.Text + " \n\n");
                        doc.Add(p2);
                        /*Insertar DataGrid*/
                        iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        PdfPTable table = new PdfPTable(dgvAeronave.Columns.Count);

                        for (int j = 0; j < dgvAeronave.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvAeronave.Columns[j].HeaderText, fontTable2));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dgvAeronave.Rows.Count; i++)
                        {
                            for (int k = 0; k < dgvAeronave.Columns.Count; k++)
                            {
                                if (dgvAeronave[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvAeronave[k, i].Value.ToString(), fontTable));
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
                        p6.Add(new Chunk("REPORTE DE TODAS LAS AERONAVES\n\n", boldFont));
                        doc.Add(p6);

                        /*Insertar DataGrid*/
                        iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 6, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        PdfPTable table = new PdfPTable(dgvAeronave.Columns.Count);

                        for (int j = 0; j < dgvAeronave.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvAeronave.Columns[j].HeaderText, fontTable2));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dgvAeronave.Rows.Count; i++)
                        {
                            for (int k = 0; k < dgvAeronave.Columns.Count; k++)
                            {
                                if (dgvAeronave[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvAeronave[k, i].Value.ToString(), fontTable));
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BuscarAeronave_Load(object sender, EventArgs e)
        {
            txtMatricula.Enabled = false;
            btnVolverFiltrar.Hide();
            btnFiltrar.Enabled = false;
            txtMatricula.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
