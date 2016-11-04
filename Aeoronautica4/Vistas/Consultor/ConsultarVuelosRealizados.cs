using Logica;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection((consultas.Variables.ConString));
                conn.Open();
                OracleCommand cmd = new OracleCommand(""+(consultas.Variables.BtnFiltrarVuelos)+" '"+dtDesde.Text+"' "+(consultas.Variables.BtnFiltrarVuelos2)+" '"+dtHasta.Text+"'", conn);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ConsultarVuelosRealizados_Load(object sender, EventArgs e)
        {
            dtHasta.Enabled = false;
            dtDesde.Enabled = false;
            btnFiltrar.Enabled = false;
        }
    }
}
