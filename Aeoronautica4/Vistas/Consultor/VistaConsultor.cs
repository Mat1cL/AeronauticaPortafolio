using Aeronautica.Vistas.Consultor;
using Aeronautica.Vistas.Consultor.Mantenimientos;
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
            BitacoraPiloto form = new BitacoraPiloto();
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

        private void button2_Click(object sender, EventArgs e)
        {
            CosultarListaPilotos form = new CosultarListaPilotos();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultarRankingAeronaves form = new ConsultarRankingAeronaves();
            form.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabConsultas_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultasMantenimientos_Click(object sender, EventArgs e)
        {
            ConsultarMantenimientos form = new ConsultarMantenimientos();
            form.ShowDialog();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            ConsultarMantenimientosHistoricos form = new ConsultarMantenimientosHistoricos();
            form.ShowDialog();
        }

        private void btnConsultaHoras_Click_1(object sender, EventArgs e)
        {
            ConsultarHorasVuelo form = new ConsultarHorasVuelo();
            form.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BitacoraPiloto form = new BitacoraPiloto();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CosultarListaPilotos form = new CosultarListaPilotos();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BuscarPiloto form = new BuscarPiloto();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ConsultarHorasVueloAeronave form = new ConsultarHorasVueloAeronave();
            form.ShowDialog();
        }

        private void btnReporteAeronave_Click_1(object sender, EventArgs e)
        {
            ReportesAeronaves form = new ReportesAeronaves();
            form.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ConsultarRankingAeronaves form = new ConsultarRankingAeronaves();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BuscarAeronave form = new BuscarAeronave();
            form.ShowDialog();
        }

        private void btnConsultarVuelos_Click_1(object sender, EventArgs e)
        {
            ConsultarVuelosRealizados form = new ConsultarVuelosRealizados();
            form.ShowDialog();
        }

        private void VistaConsultor_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
