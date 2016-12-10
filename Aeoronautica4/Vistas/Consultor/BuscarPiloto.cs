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
    public partial class BuscarPiloto : Form
    {
        public static string Rutb;
        public BuscarPiloto()
        {
           
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            btnVolverFiltrar.Hide();
            btnFiltrar.Show();
            txtRut.Enabled = true;
            btnReporte.Enabled = true;
            btnFiltrar.Enabled = true;
            txtRut.Clear();
            btnFiltrarWasClicked = false;
            try
            {
                OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                conn.Open();
                OracleCommand cmd = new OracleCommand(""+(consultas.Variables.BuscarPilotos)+"", conn);
                cmd.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dgvPilotos.DefaultCellStyle.Format = "g";
                dgvPilotos.DataSource = ds.Tables[0];
                dgvPilotos.AllowUserToResizeColumns = false;
                dgvPilotos.AllowUserToResizeRows = false;
                dgvPilotos.MultiSelect = false;
                dgvPilotos.Columns["PILOTO"].HeaderText = "RUT";
                dgvPilotos.Columns["PILOTO"].Width = 80;
                dgvPilotos.Columns["APELLIDO_PATERNO"].HeaderText = "APELLIDO PATERNO";
                dgvPilotos.Columns["APELLIDO_PATERNO"].Width = 100;
                dgvPilotos.Columns["APELLIDO_MATERNO"].HeaderText = "APELLIDO MATERNO";
                dgvPilotos.Columns["FECHA_NACIMIENTO"].HeaderText = "FECHA DE NACIMIENTO";
                dgvPilotos.Columns["TEL_FIJO"].HeaderText = "TELÉFONO FIJO";
                dgvPilotos.Columns["TEL_CEL"].HeaderText = "TELÉFONO CELULAR";
                dgvPilotos.Columns["TEL_FIJO"].Width = 70;
                dgvPilotos.Columns["TEL_CEL"].Width = 70;
                dgvPilotos.Columns["SEXO"].Width = 60;
                dgvPilotos.Columns["CORREO"].Width = 150;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool btnFiltrarWasClicked = false;
        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dgvPilotos.Rows.Count == 0)
            {
                MessageBox.Show("Deben existir datos para generar un reporte", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Reporte Datos Piloto";
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

                    if ((txtRut.Text.Length > 0) && btnFiltrarWasClicked)
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
                        p6.Add(new Chunk("FILTRADO DE PILOTO\n\n", boldFont));
                        doc.Add(p6);


                        Paragraph p2 = new Paragraph("Filtro de Rut: " + txtRut.Text + " \n\n");
                        doc.Add(p2);
                        /*Insertar DataGrid*/
                        iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 4, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 4, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        PdfPTable table = new PdfPTable(dgvPilotos.Columns.Count);

                        for (int j = 0; j < dgvPilotos.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvPilotos.Columns[j].HeaderText, fontTable2));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dgvPilotos.Rows.Count; i++)
                        {
                            for (int k = 0; k < dgvPilotos.Columns.Count; k++)
                            {
                                if (dgvPilotos[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvPilotos[k, i].Value.ToString(), fontTable));
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
                        p6.Add(new Chunk("REPORTE DE TODOS LOS PILOTOS\n\n", boldFont));
                        doc.Add(p6);

                        /*Insertar DataGrid*/
                        iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 4, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        iTextSharp.text.Font fontTable2 = FontFactory.GetFont("Arial", 4, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

                        PdfPTable table = new PdfPTable(dgvPilotos.Columns.Count);

                        for (int j = 0; j < dgvPilotos.Columns.Count; j++)
                        {
                            table.AddCell(new Phrase(dgvPilotos.Columns[j].HeaderText, fontTable2));
                        }

                        table.HeaderRows = 1;

                        for (int i = 0; i < dgvPilotos.Rows.Count; i++)
                        {
                            for (int k = 0; k < dgvPilotos.Columns.Count; k++)
                            {
                                if (dgvPilotos[k, i].Value != null)
                                {
                                    table.AddCell(new Phrase(dgvPilotos[k, i].Value.ToString(), fontTable));
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            
            btnFiltrarWasClicked = true;
            Usuarios UsuarioOb = new Usuarios();
            // Inicio Validar Rut

            UsuarioOb.Rut = this.txtRut.Text;

            string rutSinFormato = UsuarioOb.Rut;
            string rutFormateado = String.Empty;
            if (string.IsNullOrWhiteSpace(txtRut.Text))
            {
                MessageBox.Show("Debe Ingresar un Rut", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Rut.ValidaRut(txtRut.Text))
                {
                    Console.WriteLine("Rut Valido");
                    Rutb = txtRut.Text;
                    OracleConnection cnn = new OracleConnection(consultas.Variables.ConString);
                    cnn.Open();
                    string sqlString2 = ""+(consultas.Variables.ValidarSiExistePiloto)+"'" + txtRut.Text + "'";
                    OracleCommand dbCmdx2 = new OracleCommand(sqlString2, cnn);
                    OracleDataReader reader = dbCmdx2.ExecuteReader();
                    if (reader.Read())
                    {
                        try
                        {
                            OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                            conn.Open();
                            OracleCommand cmd = new OracleCommand("" + (consultas.Variables.BuscarPilotosFiltro) + "'" + txtRut.Text + "'", conn);
                            cmd.CommandType = CommandType.Text;
                            DataSet ds = new DataSet();
                            OracleDataAdapter da = new OracleDataAdapter();
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            dgvPilotos.DefaultCellStyle.Format = "g";
                            dgvPilotos.DataSource = ds.Tables[0];
                            dgvPilotos.AllowUserToResizeColumns = false;
                            dgvPilotos.AllowUserToResizeRows = false;
                            dgvPilotos.MultiSelect = false;
                            dgvPilotos.Columns["PILOTO"].HeaderText = "RUT";
                            dgvPilotos.Columns["PILOTO"].Width = 80;
                            dgvPilotos.Columns["APELLIDO_PATERNO"].HeaderText = "APELLIDO PATERNO";
                            dgvPilotos.Columns["APELLIDO_PATERNO"].Width = 100;
                            dgvPilotos.Columns["APELLIDO_MATERNO"].HeaderText = "APELLIDO MATERNO";
                            dgvPilotos.Columns["FECHA_NACIMIENTO"].HeaderText = "FECHA DE NACIMIENTO";
                            dgvPilotos.Columns["TEL_FIJO"].HeaderText = "TELÉFONO FIJO";
                            dgvPilotos.Columns["TEL_CEL"].HeaderText = "TELÉFONO CELULAR";
                            dgvPilotos.Columns["TEL_FIJO"].Width = 70;
                            dgvPilotos.Columns["TEL_CEL"].Width = 70;
                            dgvPilotos.Columns["SEXO"].Width = 60;
                            dgvPilotos.Columns["CORREO"].Width = 150;
                            txtRut.Enabled = false;
                            txtRut.Text = Rutb;
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
                        MessageBox.Show("El RUT no se encuentra asociado a un Piloto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Rut Inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRut.Text = String.Empty;
                    return;
                }
            }
            
            

        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumerosyLetras(e);
        }

        private void BuscarPiloto_Load(object sender, EventArgs e)
        {
            txtRut.Enabled = false;
            btnVolverFiltrar.Hide();
            btnFiltrar.Enabled = false;
            txtRut.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtRut_Validated(object sender, EventArgs e)
        {

            Usuarios UsuarioOb = new Usuarios();
            // Inicio Validar Rut

            UsuarioOb.Rut = this.txtRut.Text;

            string rutSinFormato = UsuarioOb.Rut;
            string rutFormateado = String.Empty;
            if (txtRut.Text == "")
            {
                //MessageBox.Show("Debes ingresar el Rut");
            }
            else
            {
                //obtengo la parte numerica del RUT
                string rutTemporal = rutSinFormato.Substring(0, rutSinFormato.Length - 1);

                //obtengo el Digito Verificador del RUT

                string dv = rutSinFormato.Substring(rutSinFormato.Length - 1, 1);

                Int64 rut;

                //aqui convierto a un numero el RUT si ocurre un error lo deja en CERO
                if (!Int64.TryParse(rutTemporal, out rut))
                {
                    rut = 0;
                }

                //este comando es el que formatea con los separadores de miles
                rutFormateado = rut.ToString("N0");

                if (rutFormateado.Equals("0"))
                {
                    rutFormateado = string.Empty;
                }
                else
                {
                    //si no hubo problemas con el formateo agrego el DV a la salida
                    rutFormateado += "-" + dv;

                    //y hago este replace por si el servidor tuviese configuracion anglosajona y reemplazo las comas por puntos
                    rutFormateado = rutFormateado.Replace(",", ".");
                }
                txtRut.Text = rutFormateado;
                //la salida esperada para el ejemplo es 99.999.999-K
                //MessageBox.Show("RUT Formateado: " + rutFormateado);
            }
        }

        private void btnVolverFiltrar_Click(object sender, EventArgs e)
        {
            btnVolverFiltrar.Hide();
            btnFiltrar.Show();
            txtRut.Clear();
            txtRut.Enabled = true;
        }
    }
}
