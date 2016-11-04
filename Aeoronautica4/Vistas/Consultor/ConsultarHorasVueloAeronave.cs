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
    public partial class ConsultarHorasVueloAeronave : Form
    {
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
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboAeronaveFormConsultarHorasVueloAeronave)+"", conn);
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
            OracleDataAdapter da = new OracleDataAdapter();
            if (cboMatricula.Text == "Seleccione un Matricula")
            {
                MessageBox.Show("Debe Seleccionar un matricula");
            }
            else
            {
                cmd = new OracleCommand(""+(consultas.Variables.ConsultarHorasVueloAeronave1)+"'" + this.cboMatricula.SelectedValue + "'", cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds);
                cn.Close();
                dgvHorasAeronave.DataSource = ds.Tables[0];

                cmd = new OracleCommand(""+(consultas.Variables.ConsultarHorasVueloAeronave2)+"'" + this.cboMatricula.SelectedValue + "'", cn);
                cn.Open();
                cmd.CommandType = CommandType.Text;
                da.SelectCommand = cmd;
                da.Fill(ds);
                cn.Close();
                dgvHorasAeronave.DataSource = ds.Tables[0];

                cmd = new OracleCommand(""+(consultas.Variables.ConsultarHorasVueloAeronave3)+"'" + this.cboMatricula.SelectedValue + "'", cn);
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
            lblSubtotalPiloto.Text = "Total :" + hrs.ToString() + " horas y " + min.ToString() + " minutos";
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

        }
    }
}
