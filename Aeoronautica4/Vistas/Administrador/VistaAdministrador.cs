using Aeronautica.Vistas.Administrador;
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
    public partial class VistaAdministrador : Form
    {
        public VistaAdministrador()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresarPlanVuelo_Click(object sender, EventArgs e)
        {
            IngresarUsuario form = new IngresarUsuario();
            form.ShowDialog();
        }

        private void btnPlanReal_Click(object sender, EventArgs e)
        {
            MantenedorUsuario form = new MantenedorUsuario();
            form.ShowDialog();
        }

        private void VistaAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
