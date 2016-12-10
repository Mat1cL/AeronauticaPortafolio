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
using Aeronautica.Vistas.Piloto;

namespace Aeronautica
{
    public partial class VistaPiloto : Form
    {
        public static string VariableRut;
        public static string VariableNombre;
        public static string VariableApellidoPaterno;
        public static string VariableApellidoMaterno;
        public VistaPiloto()
        {
            InitializeComponent();
        }
      
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresarPlanVuelo_Click(object sender, EventArgs e)
        {
            
            OracleConnection cnn = new OracleConnection((consultas.Variables.ConString));
            cnn.Open();
            string sqlString = ""+(consultas.Variables.ValidarEstadoPiloto)+"'" + txtUsuario.Text + "' "+(consultas.Variables.ValidarEstadoPiloto2)+"";
            OracleCommand dbCmdx2 = new OracleCommand(sqlString, cnn);
            OracleDataReader reader = dbCmdx2.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("El Piloto se encuentra deshabilitado, revise su casilla de correo para saber la razón", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IngresarPlanVuelo form = new IngresarPlanVuelo();
                form.ShowDialog();
            }
            
        }

        private void VistaPiloto_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Login.VariableRut;
            txtUsuario.Enabled = false;
            txtUsuario.Hide();

            OracleConnection Conn = new OracleConnection((consultas.Variables.ConString));
                    string Command = ""+(consultas.Variables.EnviarCorreo)+"'" + txtUsuario.Text + "'";
                    OracleCommand Comm1 = new OracleCommand(Command, Conn);
                    Conn.Open();
                    OracleDataReader DR1 = Comm1.ExecuteReader();
                    if (DR1.Read())
                    {   
                        
                        VariableNombre = DR1["NOMBRE_PILOTO"].ToString();
                        VariableApellidoPaterno = DR1["APELLIDO_PATERNO"].ToString();
                        VariableApellidoMaterno = DR1["APELLIDO_MATERNO"].ToString();

                    }
                    Conn.Close();
                    try
                    {
                        label4.Text = "Bienvenido Piloto: " + VariableNombre + " "+VariableApellidoPaterno+" "+VariableApellidoMaterno+"";
                    }
                    catch (Exception)
                    {
                        
                    }
                    
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaPiloto_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnConsultarVuelos_Click(object sender, EventArgs e)
        {
            VariableRut = txtUsuario.Text;
            ConsultarHoraDeVueloPiloto form = new ConsultarHoraDeVueloPiloto();
            form.ShowDialog();
        }
    }
}
