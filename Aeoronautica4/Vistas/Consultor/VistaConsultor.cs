using Aeronautica.Vistas.Consultor;
using Aeronautica.Vistas.Operador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeronautica
{
    public partial class VistaConsultor : Form
    {
        public VistaConsultor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultaHoras_Click(object sender, EventArgs e)
        {
            ConsultarHorasVuelo form = new ConsultarHorasVuelo();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarHorasVueloAeronave form = new ConsultarHorasVueloAeronave();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportePiloto form = new ReportePiloto();
            form.ShowDialog();
        }

        private void btnReporteAeronave_Click(object sender, EventArgs e)
        {
            ReportesAeronaves form = new ReportesAeronaves();
            form.ShowDialog();
        }

        private void btnConsultarVuelos_Click(object sender, EventArgs e)
        {
            ConsultarVuelosRealizados form = new ConsultarVuelosRealizados();
            form.ShowDialog();
        }
    }
}
