using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Logica;
using Conexion;

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
                MessageBox.Show("Debe Seleccionar un Piloto");
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
                lblSubtotalPiloto.Text = "Total : " + hrs.ToString() + " horas y " + min.ToString() + " minutos";
            }

        }

        

        private void VistaOperadorConsultarHorasVuelo_Load(object sender, EventArgs e)
        {
            FillCbPiloto();

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
    }
}
