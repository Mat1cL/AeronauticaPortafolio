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
    public partial class ConsultarVuelosRealizados : Form
    {
        public ConsultarVuelosRealizados()
        {
            InitializeComponent();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            btnFiltrarWasClicked = false;
            txtMatricula.Clear();
            try
            {

                OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                conn.Open();
                OracleCommand cmd = new OracleCommand("" + (consultas.Variables.BtnConsultaVuelos) + "", conn);
                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dtgVuelos.DataSource = ds.Tables[0];
                dtgVuelos.AllowUserToResizeColumns = true;
                dtgVuelos.AllowUserToResizeRows = true;
                dtgVuelos.MultiSelect = true;
                dtgVuelos.Columns["ID_PLAN_VUELO_REAL"].Width = 158;
                dtgVuelos.Columns["ID_PLAN_VUELO_REAL"].HeaderText = "ID DE VUELO";
                dtgVuelos.Columns["FECHA_ORIGEN_REAL"].Width = 158;
                dtgVuelos.Columns["FECHA_ORIGEN_REAL"].HeaderText = "FECHA DE ORIGEN";
                dtgVuelos.Columns["FECHA_DESTINO_REAL"].Width = 158;
                dtgVuelos.Columns["FECHA_DESTINO_REAL"].HeaderText = "FECHA DE DESTINO";
                dtgVuelos.Columns["RUT_PILOTO"].Width = 158;
                dtgVuelos.Columns["RUT_PILOTO"].HeaderText = "RUT PILOTO";
                dtgVuelos.Columns["LICENCIA_PILOTO"].Width = 158;
                dtgVuelos.Columns["LICENCIA_PILOTO"].HeaderText = "LICENCIA PILOTO";
                dtgVuelos.Columns["RUT_COPILOTO"].Width = 158;
                dtgVuelos.Columns["RUT_COPILOTO"].HeaderText = "RUT COPILOTO";
                dtgVuelos.Columns["LICENCIA_COPILOTO"].Width = 158;
                dtgVuelos.Columns["LICENCIA_COPILOTO"].HeaderText = "LICENCIA COPILOTO";
                dtgVuelos.Columns["RUTA"].Width = 158;
                dtgVuelos.Columns["RUTA"].HeaderText = "RUTA";
                dtgVuelos.Columns["ORIGEN"].Width = 158;
                dtgVuelos.Columns["ORIGEN"].HeaderText = "ORIGEN";
                dtgVuelos.Columns["DESTINO"].Width = 158;
                dtgVuelos.Columns["DESTINO"].HeaderText = "DESTINO";
                dtgVuelos.Columns["CONDICION"].Width = 158;
                dtgVuelos.Columns["CONDICION"].HeaderText = "CONDICION";
                dtgVuelos.Columns["MISION"].Width = 158;
                dtgVuelos.Columns["MISION"].HeaderText = "MISION";
                dtgVuelos.Columns["MATRICULA"].Width = 158;
                dtgVuelos.Columns["MATRICULA"].HeaderText = "MATRICULA";
                dtgVuelos.Columns["TIPO_AERONAVE"].Width = 158;
                dtgVuelos.Columns["TIPO_AERONAVE"].HeaderText = "TIPO DE AERONAVE";
                dtgVuelos.Columns["MODELO"].Width = 158;
                dtgVuelos.Columns["MODELO"].HeaderText = "MODELO";

                dtHasta.Enabled = true;
                dtDesde.Enabled = true;
                btnFiltrar.Enabled = true;
                txtMatricula.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            btnFiltrarWasClicked = true;
            try
            {
                if (string.IsNullOrWhiteSpace(txtMatricula.Text))
                {

                    OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(""+(consultas.Variables.BtnFiltrarVuelos)+"'"+dtDesde.Text+"'"+(consultas.Variables.BtnFiltrarVuelos2)+"'"+dtHasta.Text+"'"+(consultas.Variables.BtnFiltrarVuelos3)+"", conn);
                    cmd.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    dtgVuelos.DataSource = ds.Tables[0];
                    dtgVuelos.AllowUserToResizeColumns = true;
                    dtgVuelos.AllowUserToResizeRows = true;
                    dtgVuelos.MultiSelect = true;
                    dtgVuelos.Columns["ID_PLAN_VUELO_REAL"].Width = 158;
                    dtgVuelos.Columns["ID_PLAN_VUELO_REAL"].HeaderText = "ID DE VUELO";
                    dtgVuelos.Columns["FECHA_ORIGEN_REAL"].Width = 158;
                    dtgVuelos.Columns["FECHA_ORIGEN_REAL"].HeaderText = "FECHA DE ORIGEN";
                    dtgVuelos.Columns["FECHA_DESTINO_REAL"].Width = 158;
                    dtgVuelos.Columns["FECHA_DESTINO_REAL"].HeaderText = "FECHA DE DESTINO";
                    dtgVuelos.Columns["RUT_PILOTO"].Width = 158;
                    dtgVuelos.Columns["RUT_PILOTO"].HeaderText = "RUT PILOTO";
                    dtgVuelos.Columns["LICENCIA_PILOTO"].Width = 158;
                    dtgVuelos.Columns["LICENCIA_PILOTO"].HeaderText = "LICENCIA PILOTO";
                    dtgVuelos.Columns["RUT_COPILOTO"].Width = 158;
                    dtgVuelos.Columns["RUT_COPILOTO"].HeaderText = "RUT COPILOTO";
                    dtgVuelos.Columns["LICENCIA_COPILOTO"].Width = 158;
                    dtgVuelos.Columns["LICENCIA_COPILOTO"].HeaderText = "LICENCIA COPILOTO";
                    dtgVuelos.Columns["RUTA"].Width = 158;
                    dtgVuelos.Columns["RUTA"].HeaderText = "RUTA";
                    dtgVuelos.Columns["ORIGEN"].Width = 158;
                    dtgVuelos.Columns["ORIGEN"].HeaderText = "ORIGEN";
                    dtgVuelos.Columns["DESTINO"].Width = 158;
                    dtgVuelos.Columns["DESTINO"].HeaderText = "DESTINO";
                    dtgVuelos.Columns["CONDICION"].Width = 158;
                    dtgVuelos.Columns["CONDICION"].HeaderText = "CONDICION";
                    dtgVuelos.Columns["MISION"].Width = 158;
                    dtgVuelos.Columns["MISION"].HeaderText = "MISION";
                    dtgVuelos.Columns["MATRICULA"].Width = 158;
                    dtgVuelos.Columns["MATRICULA"].HeaderText = "MATRICULA";
                    dtgVuelos.Columns["TIPO_AERONAVE"].Width = 158;
                    dtgVuelos.Columns["TIPO_AERONAVE"].HeaderText = "TIPO DE AERONAVE";
                    dtgVuelos.Columns["MODELO"].Width = 158;
                    dtgVuelos.Columns["MODELO"].HeaderText = "MODELO";
                    return;

                }
                else
                {

                    OracleDataReader dr = null;
                    OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                    OracleCommand cmd = new OracleCommand("" + (consultas.Variables.BtnFiltrarVuelosMatriculas) + "'" + dtDesde.Text + "'" + (consultas.Variables.BtnFiltrarVuelosMatriculas2) + "'" + dtHasta.Text + "'" + (consultas.Variables.BtnFiltrarVuelosMatriculas3) + " '" + txtMatricula.Text + "' "+(consultas.Variables.BtnFiltrarVuelosMatriculas4)+"", conn);
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    string ValidarMatriculaAeronave = "" + (consultas.Variables.ValidarSiExisteMatricula) + "'" + this.txtMatricula.Text + "'";
                    string ValidarMatricula = "" + (consultas.Variables.ValidarSiMatriculaPoseeVuelos) + "'" + this.txtMatricula.Text + "'";
                    OracleCommand cmdMatricula = new OracleCommand(ValidarMatricula, conn);
                    OracleDataReader readerMatricula = cmdMatricula.ExecuteReader();
                    OracleCommand cmdMatriculaAeronave = new OracleCommand(ValidarMatriculaAeronave, conn);
                    OracleDataReader readerMatriculaAeronave = cmdMatriculaAeronave.ExecuteReader();
                    if (readerMatriculaAeronave.Read())
                    {
                        if (readerMatricula.Read())
                        {
                            if (dr.Read() == true)
                            {
                                cmd.CommandType = CommandType.Text;
                                DataSet ds = new DataSet();
                                OracleDataAdapter da = new OracleDataAdapter();
                                da.SelectCommand = cmd;
                                da.Fill(ds);
                                dtgVuelos.DataSource = ds.Tables[0];
                                dtgVuelos.AllowUserToResizeColumns = true;
                                dtgVuelos.AllowUserToResizeRows = true;
                                dtgVuelos.MultiSelect = true;
                                dtgVuelos.Columns["ID_PLAN_VUELO_REAL"].Width = 158;
                                dtgVuelos.Columns["ID_PLAN_VUELO_REAL"].HeaderText = "ID \n DE VUELO";
                                dtgVuelos.Columns["FECHA_ORIGEN_REAL"].Width = 158;
                                dtgVuelos.Columns["FECHA_ORIGEN_REAL"].HeaderText = "FECHA \n DE ORIGEN";
                                dtgVuelos.Columns["FECHA_DESTINO_REAL"].Width = 158;
                                dtgVuelos.Columns["FECHA_DESTINO_REAL"].HeaderText = "FECHA \n DE DESTINO";
                                dtgVuelos.Columns["RUT_PILOTO"].Width = 158;
                                dtgVuelos.Columns["RUT_PILOTO"].HeaderText = "RUT \n PILOTO";
                                dtgVuelos.Columns["LICENCIA_PILOTO"].Width = 158;
                                dtgVuelos.Columns["LICENCIA_PILOTO"].HeaderText = "LICENCIA \n PILOTO";
                                dtgVuelos.Columns["RUT_COPILOTO"].Width = 158;
                                dtgVuelos.Columns["RUT_COPILOTO"].HeaderText = "RUT \n COPILOTO";
                                dtgVuelos.Columns["LICENCIA_COPILOTO"].Width = 158;
                                dtgVuelos.Columns["LICENCIA_COPILOTO"].HeaderText = "LICENCIA \n COPILOTO";
                                dtgVuelos.Columns["RUTA"].Width = 158;
                                dtgVuelos.Columns["RUTA"].HeaderText = "RUTA";
                                dtgVuelos.Columns["ORIGEN"].Width = 158;
                                dtgVuelos.Columns["ORIGEN"].HeaderText = "ORIGEN";
                                dtgVuelos.Columns["DESTINO"].Width = 158;
                                dtgVuelos.Columns["DESTINO"].HeaderText = "DESTINO";
                                dtgVuelos.Columns["CONDICION"].Width = 158;
                                dtgVuelos.Columns["CONDICION"].HeaderText = "CONDICION";
                                dtgVuelos.Columns["MISION"].Width = 158;
                                dtgVuelos.Columns["MISION"].HeaderText = "MISION";
                                dtgVuelos.Columns["MATRICULA"].Width = 158;
                                dtgVuelos.Columns["MATRICULA"].HeaderText = "MATRICULA";
                                dtgVuelos.Columns["TIPO_AERONAVE"].Width = 158;
                                dtgVuelos.Columns["TIPO_AERONAVE"].HeaderText = "TIPO \n DE AERONAVE";
                                dtgVuelos.Columns["MODELO"].Width = 158;
                                dtgVuelos.Columns["MODELO"].HeaderText = "MODELO";
                            }
                            else
                            {
                                MessageBox.Show("La Aeronave con Matricula \"" + txtMatricula.Text + "\" NO Posee Vuelos Entre Las Fechas Indicadas", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("La Aeronave con Matricula \"" + txtMatricula.Text + "\" NO Posee Vuelos Realizados", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La Matricula \"" + txtMatricula.Text + "\" NO esta asignada a ningún tipo de Aeronave", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ConsultarVuelosRealizados_Load(object sender, EventArgs e)
        {
            dtgVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgVuelos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgVuelos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dtgVuelos.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True; 
            txtMatricula.CharacterCasing = CharacterCasing.Upper;
            txtMatricula.Enabled = false;
            dtHasta.Enabled = false;
            dtDesde.Enabled = false;
            btnFiltrar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool btnFiltrarWasClicked = false;
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtgVuelos.Rows.Count == 0)
            {
                MessageBox.Show("Deben existir datos para generar un reporte", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Reporte Vuelos Realizados";
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
                    if (string.IsNullOrWhiteSpace(this.txtMatricula.Text) && btnFiltrarWasClicked)
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
                        p6.Add(new Chunk("FILTRADO DE REPORTE DE VUELOS REALIZADOS\n\n", boldFont));
                        doc.Add(p6);
                        
                        Paragraph p1 = new Paragraph("Fecha de Filtro: " + dtDesde.Text + " - " + dtHasta.Text + " \n\n");
                        p1.Font = FontFactory.GetFont("Arial", 10);
                        doc.Add(p1);
                        /*Insertar DataGrid*/
                        iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 4, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 4, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        PdfPTable table = new PdfPTable(dtgVuelos.Columns.Count);

                        for (int j = 0; j < dtgVuelos.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dtgVuelos.Columns[j].HeaderText, fontTable2));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dtgVuelos.Rows.Count; i++)
                        {
                            for (int k = 0; k < dtgVuelos.Columns.Count; k++)
                            {
                                if (dtgVuelos[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dtgVuelos[k, i].Value.ToString(), fontTable));
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
                        p6.Add(new Chunk("FILTRADO DE REPORTE DE VUELOS REALIZADOS\n\n", boldFont));
                        doc.Add(p6);

                        Paragraph p1 = new Paragraph("Fecha de Filtro: " + dtDesde.Text + " - " + dtHasta.Text + " \n");
                        p1.Font = FontFactory.GetFont("Arial", 10);
                        doc.Add(p1);
                        Paragraph p2 = new Paragraph("Matricula: " + txtMatricula.Text + " \n\n");
                        p1.Font = FontFactory.GetFont("Arial", 10);
                        doc.Add(p2);
                        /*Insertar DataGrid*/
                        iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 4, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 4, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        PdfPTable table = new PdfPTable(dtgVuelos.Columns.Count);

                        for (int j = 0; j < dtgVuelos.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dtgVuelos.Columns[j].HeaderText, fontTable2));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dtgVuelos.Rows.Count; i++)
                        {
                            for (int k = 0; k < dtgVuelos.Columns.Count; k++)
                            {
                                if (dtgVuelos[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dtgVuelos[k, i].Value.ToString(), fontTable));
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
                            p6.Add(new Chunk("REPORTE DE TODOS LOS VUELOS REALIZADOS\n\n", boldFont));
                            doc.Add(p6);

                            /*Insertar DataGrid*/
                            iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 4, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                            iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 4, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                            PdfPTable table = new PdfPTable(dtgVuelos.Columns.Count);

                            for (int j = 0; j < dtgVuelos.Columns.Count; j++)
                            {
                                table.AddCell(new Phrase(dtgVuelos.Columns[j].HeaderText, fontTable2));
                            }

                            table.HeaderRows = 1;

                            for (int i = 0; i < dtgVuelos.Rows.Count; i++)
                            {
                                for (int k = 0; k < dtgVuelos.Columns.Count; k++)
                                {
                                    if (dtgVuelos[k, i].Value != null)
                                    {
                                        table.AddCell(new Phrase(dtgVuelos[k, i].Value.ToString(), fontTable));
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
                   
                    
        }

        private void dtgVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMatricula.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
