using Aeoronautica;
using Aeronautica.Operador;
using Aeronautica.Vistas.Consultor;
using Aeronautica.Vistas.Operador;
using Aeronautica.Vistas.Operador.Ingresos;
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
    public partial class VistaOperador : Form
    {
        public VistaOperador()
        {
            InitializeComponent();
        }

        private void btnMantenedorPiloto_Click(object sender, EventArgs e)
        {
            MantenedorPiloto form = new MantenedorPiloto();
            form.ShowDialog();
        }

        private void btnMantenedorLicencias_Click(object sender, EventArgs e)
        {
            MantenedorLicencia form = new MantenedorLicencia();
            form.ShowDialog();
        }

        private void btnMantenedorAeronave_Click(object sender, EventArgs e)
        {
            MantenedorAeronave form = new MantenedorAeronave();
            form.ShowDialog();
        }

        private void btnIngresarPlanVuelo_Click(object sender, EventArgs e)
        {
            IngresarPlanVuelo form = new IngresarPlanVuelo();
            form.ShowDialog();
        }


        private void btnIngresarPiloto_Click(object sender, EventArgs e)
        {
            IngresarPiloto form = new IngresarPiloto();
            form.ShowDialog();
        }

        private void btnIngresarLicencia_Click(object sender, EventArgs e)
        {
            IngresarLicencia form = new IngresarLicencia();
            form.ShowDialog();
        }

        private void btnAeronave_Click(object sender, EventArgs e)
        {
            IngresarAeronave form = new IngresarAeronave();
            form.ShowDialog();
        }

        private void btnComponentes_Click(object sender, EventArgs e)
        {
            IngresarComponente form = new IngresarComponente();
            form.ShowDialog();
        }

        private void btnConsultaHoras_Click(object sender, EventArgs e)
        {
            ConsultarHorasVuelo form = new ConsultarHorasVuelo();
            form.ShowDialog();
        }

        private void btnPlanReal_Click(object sender, EventArgs e)
        {
            IngresarPlanVueloReal form = new IngresarPlanVueloReal();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarHorasVueloAeronave form = new ConsultarHorasVueloAeronave();
            form.ShowDialog();
        }

        private void btnIngresarMedicamento_Click(object sender, EventArgs e)
        {
            IngresarFichaMedica form = new IngresarFichaMedica();
            form.ShowDialog();
        }

        private void btnMantenedorMedicamento_Click(object sender, EventArgs e)
        {
            MantenedorFichaMedica form = new MantenedorFichaMedica();
            form.ShowDialog();
        }

 

        private void tabVuelos_Leave(object sender, EventArgs e)
        {
            
        }

        private void VistaOperador_Leave(object sender, EventArgs e)
        {
            
        }

        private void VistaOperador_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnFabricante_Click(object sender, EventArgs e)
        {
            IngresarDetalleMantenimiento form = new IngresarDetalleMantenimiento();
            form.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabVuelos_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

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
