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

namespace Aeronautica.Vistas.Operador
{
    public partial class ReportePiloto : Form
    {
        public static string UltimaFecha;
        public ReportePiloto()
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
                da = new OracleDataAdapter("" + (consultas.Variables.ConsultarHorasVueloPilotoCboTipoLicencia) + "'" + this.cboPiloto.SelectedValue + "'", conn);
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
                da = new OracleDataAdapter("" + (consultas.Variables.ConsultarHorasVueloPilotoCboPiloto) + "", conn);
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



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtRut.Text) || string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                MessageBox.Show("Debes Generar Una Busqueda Antes de Realizar un Reporte");
                return;
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Reporte " + txtRut.Text + " " + txtNombre.Text + "  " + " TipoAeronave - " + txtTipo.Text + "";
                sfd.Filter = "Pdf File |*.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                    Document doc = new Document();
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    //PdfWriter.GetInstance(doc, new FileStream("C://Reporte" + txtRut.Text + "" + txtNombre.Text + "" + "TipoAeronave-" + txtTipo.Text + "" + ".PDF", FileMode.Create));
                    doc.Open();
                    var p6 = new Phrase();
                    Paragraph p1 = new Paragraph("Rut Piloto: " + txtRut.Text);
                    Paragraph p2 = new Paragraph("Nombre Piloto: " + txtNombre.Text);
                    Paragraph p3 = new Paragraph("Fecha de Vencimiento de Ficha Médica: " + txtMedica.Text);
                    Paragraph p4 = new Paragraph("Fecha de Último Viaje Realizado: " + txtUltimo.Text);
                    Paragraph p7 = new Paragraph("Último Numero de Licencia Utilizado: " + txtNumero.Text);
                    Paragraph p5 = new Paragraph("Total Horas de Vuelo: " + txtHorasDeVuelo.Text);
                    Paragraph p8 = new Paragraph("Tipo de Aeronave: " + txtTipo.Text);

                    p6.Add(new Chunk("REPORTE DE PILOTO", boldFont));
                    doc.Add(p6);
                    doc.Add(p1);
                    doc.Add(p2);
                    doc.Add(p3);
                    doc.Add(p4);
                    doc.Add(p7);
                    doc.Add(p5);
                    doc.Add(p8);
                    doc.Close();
                    MessageBox.Show("Reporte Creado");
                }
            }


        }

        private void PruebaPDF_Load(object sender, EventArgs e)
        {
            txtTipo.Enabled = false;
            txtNumero.Enabled = false;
            label5.Hide();
            txtNumero.Hide();
            dgvHorasPiloto.Hide();
            button3.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label6.Hide();
            txtTipo.Hide();
            lblHorasDeVuelo.Hide();
            txtUltimo.Hide();
            txtRut.Hide();
            txtHorasDeVuelo.Hide();
            txtNombre.Hide();
            txtMedica.Hide();
            txtUltimo.Enabled = false;
            txtMedica.Enabled = false;
            FillCbPiloto();
            lblSubtotalPiloto.Hide();
            cboLicencia.Hide();
            txtHorasDeVuelo.Enabled = false;
            txtRut.Enabled = false;
            txtNombre.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void cboPiloto_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbTipoLicencia();

        }

        private void lblHorasDeVuelo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Hide();
            txtTipo.Hide();
            cboPiloto.Enabled = true;
            txtNumero.Hide();
            txtNumero.Clear();
            label5.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            lblHorasDeVuelo.Hide();
            button3.Hide();
            txtUltimo.Hide();
            txtRut.Hide();
            txtHorasDeVuelo.Hide();
            txtNombre.Hide();
            txtMedica.Hide();
            txtUltimo.Clear();
            txtRut.Clear();
            txtHorasDeVuelo.Clear();
            txtNombre.Clear();
            txtMedica.Clear();
            cboPiloto.Text = "Seleccione un Piloto";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAvion_Click(object sender, EventArgs e)
        {

            if (cboPiloto.Text == "Seleccione un Piloto")
            {
                MessageBox.Show("Debe Seleccionar Un Piloto");
            }
            else
            {
                OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                conn.Open();
                try { }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                string ValidarFichaMedicaBtnAvion = "" + (consultas.Variables.ValidarFichaMedicaReportePiloto) + "'" + this.cboPiloto.SelectedValue + "'";
                OracleCommand dbCmdx2 = new OracleCommand(ValidarFichaMedicaBtnAvion, conn);
                OracleDataReader reader = dbCmdx2.ExecuteReader();
                if (reader.Read())
                {
                    OracleDataReader dr = null;
                    OracleCommand cmdx = new OracleCommand("" + (consultas.Variables.ReportePilotoAvion) + "'" + this.cboPiloto.SelectedValue + "' " + (consultas.Variables.ReportePilotoAvion2) + "'" + this.cboPiloto.SelectedValue + "' " + (consultas.Variables.ReportePilotoAvion3) + "", conn);

                    dr = cmdx.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        label6.Show();
                        txtTipo.Show();
                        button3.Show();
                        cboPiloto.Enabled = false;
                        txtNumero.Show();
                        button3.Show();
                        label1.Show();
                        label2.Show();
                        label3.Show();
                        label4.Show();
                        label5.Show();
                        lblHorasDeVuelo.Show();
                        txtUltimo.Show();
                        txtRut.Show();
                        txtHorasDeVuelo.Show();
                        txtNombre.Show();
                        txtMedica.Show();
                        txtRut.Text = dr["RUT_PILOTO_PVR"].ToString();
                        txtNombre.Text = dr["NOMBRE_PILOTO"].ToString() + " " + dr["APELLIDO_PATERNO"].ToString() + " " + dr["APELLIDO_MATERNO"].ToString();
                        txtMedica.Text = dr["FECHA_VENCIMIENTO"].ToString();
                        txtUltimo.Text = dr["FECHA_DESTINO_REAL"].ToString();
                        txtNumero.Text = dr["NUMERO_LICENCIA"].ToString();
                        txtTipo.Text = dr["NOMBRE_TIPO_AERONAVE"].ToString();



                    }
                    else
                    {
                        MessageBox.Show("El Piloto Seleccionado No Posee Vuelos Con Aviones");
                    }

                    OracleConnection cn = new OracleConnection((consultas.Variables.ConString));
                    OracleCommand cmd;
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter();
                    if (cboPiloto.Text == "Seleccione un Piloto")
                    {
                        MessageBox.Show("Debe Seleccionar un Piloto");
                    }
                    else
                    {



                        if (cboLicencia.Text == "Seleccione un Tipo de Licencia")
                        {
                            cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloPiloto) + "'" + this.cboPiloto.SelectedValue + "'", cn);
                            cn.Open();
                            cmd.CommandType = CommandType.Text;
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            cn.Close();
                            dgvHorasPiloto.DataSource = ds.Tables[0];

                            cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloPiloto2) + "'" + this.cboPiloto.SelectedValue + "'", cn);
                            cn.Open();
                            cmd.CommandType = CommandType.Text;
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            cn.Close();
                            dgvHorasPiloto.DataSource = ds.Tables[0];

                        }
                        else
                        {
                            cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloPiloto3) + "'" + this.cboPiloto.SelectedValue + "' " + (consultas.Variables.ConsultarHorasVueloPiloto3_1) + " " + this.cboLicencia.SelectedValue, cn);
                            cn.Open();
                            cmd.CommandType = CommandType.Text;
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            cn.Close();
                            dgvHorasPiloto.DataSource = ds.Tables[0];

                            cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloPiloto4) + "'" + this.cboPiloto.SelectedValue + "' " + (consultas.Variables.ConsultarHorasVueloPiloto4_1) + " " + this.cboLicencia.SelectedValue, cn);
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
                        lblSubtotalPiloto.Text = " " + hrs.ToString() + " Horas y " + min.ToString() + " Minutos";
                        txtHorasDeVuelo.Text = lblSubtotalPiloto.Text;
                    }
                }
                else
                {
                    MessageBox.Show("El Piloto Seleccionado NO posee Ficha Médica");
                }
            }

        }

        private void btnHelicoptero_Click(object sender, EventArgs e)
        {
            if (cboPiloto.Text == "Seleccione un Piloto")
            {
                MessageBox.Show("Debe Seleccionar Un Piloto");
            }
            else
            {
                OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                conn.Open();
                try { }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                string ValidarFichaMedicaBtnHelicoptero = "" + (consultas.Variables.ValidarFichaMedicaReportePiloto) + "'" + this.cboPiloto.SelectedValue + "'";
                OracleCommand dbCmdx2 = new OracleCommand(ValidarFichaMedicaBtnHelicoptero, conn);
                OracleDataReader reader = dbCmdx2.ExecuteReader();
                if (reader.Read())
                {
                    OracleDataReader dr = null;
                    OracleCommand cmdx = new OracleCommand("" + (consultas.Variables.ReportePilotoHelic) + "'" + this.cboPiloto.SelectedValue + "' " + (consultas.Variables.ReportePilotoHelic2) + "'" + this.cboPiloto.SelectedValue + "' " + (consultas.Variables.ReportePilotoHelic3) + "", conn);

                    dr = cmdx.ExecuteReader();
                    if (dr.Read() == true)
                    {

                        label6.Show();
                        txtTipo.Show();
                        button3.Show();
                        cboPiloto.Enabled = false;
                        txtNumero.Show();
                        button3.Show();
                        label1.Show();
                        label2.Show();
                        label3.Show();
                        label4.Show();
                        label5.Show();
                        lblHorasDeVuelo.Show();
                        txtUltimo.Show();
                        txtRut.Show();
                        txtHorasDeVuelo.Show();
                        txtNombre.Show();
                        txtMedica.Show();
                        txtRut.Text = dr["RUT_PILOTO_PVR"].ToString();
                        txtNombre.Text = dr["NOMBRE_PILOTO"].ToString() + " " + dr["APELLIDO_PATERNO"].ToString() + " " + dr["APELLIDO_MATERNO"].ToString();
                        txtMedica.Text = dr["FECHA_VENCIMIENTO"].ToString();
                        txtUltimo.Text = dr["FECHA_DESTINO_REAL"].ToString();
                        txtNumero.Text = dr["NUMERO_LICENCIA"].ToString();
                        txtTipo.Text = dr["NOMBRE_TIPO_AERONAVE"].ToString();



                    }
                    else
                    {
                        MessageBox.Show("El Piloto Seleccionado No Posee Vuelos Con Helicópteros");
                    }


                    OracleConnection cn = new OracleConnection((consultas.Variables.ConString));
                    OracleCommand cmd;
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter();
                    if (cboPiloto.Text == "Seleccione un Piloto")
                    {
                        MessageBox.Show("Debe Seleccionar un Piloto");
                    }
                    else
                    {



                        if (cboLicencia.Text == "Seleccione un Tipo de Licencia")
                        {
                            cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloPiloto) + "'" + this.cboPiloto.SelectedValue + "'", cn);
                            cn.Open();
                            cmd.CommandType = CommandType.Text;
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            cn.Close();
                            dgvHorasPiloto.DataSource = ds.Tables[0];

                            cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloPiloto2) + "'" + this.cboPiloto.SelectedValue + "'", cn);
                            cn.Open();
                            cmd.CommandType = CommandType.Text;
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            cn.Close();
                            dgvHorasPiloto.DataSource = ds.Tables[0];

                        }
                        else
                        {
                            cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloPiloto3) + "'" + this.cboPiloto.SelectedValue + "' " + (consultas.Variables.ConsultarHorasVueloPiloto3_1) + " " + this.cboLicencia.SelectedValue, cn);
                            cn.Open();
                            cmd.CommandType = CommandType.Text;
                            da.SelectCommand = cmd;
                            da.Fill(ds);
                            cn.Close();
                            dgvHorasPiloto.DataSource = ds.Tables[0];

                            cmd = new OracleCommand("" + (consultas.Variables.ConsultarHorasVueloPiloto4) + "'" + this.cboPiloto.SelectedValue + "' " + (consultas.Variables.ConsultarHorasVueloPiloto4_1) + " " + this.cboLicencia.SelectedValue, cn);
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
                        lblSubtotalPiloto.Text = " " + hrs.ToString() + " Horas y " + min.ToString() + " Minutos";
                        txtHorasDeVuelo.Text = lblSubtotalPiloto.Text;
                    }
                }
                else
                {
                    MessageBox.Show("El Piloto Seleccionado NO posee Ficha Médica");
                }
            }

        }
    }
}

