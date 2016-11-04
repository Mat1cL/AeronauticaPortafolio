using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Aeronautica.Properties;
using Oracle.DataAccess.Client;
using Aeronautica;
using Logica;
using Conexion;
using System.Net.Mail;

namespace Aeronautica
{
    public partial class Login : Form
    {
        public static string VariableRut;
        public static string VariableEstadoPilotoInactividad;
        //Inicializa el Form
        public Login()
        {
            InitializeComponent();
        }
        //Fin de inicialización del form
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
            
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Usuarios UsuarioOb = new Usuarios();
            // Inicio Validar Rut
            
            UsuarioOb.Rut = this.txtUsuario.Text;

            string rutSinFormato = UsuarioOb.Rut;
            string rutFormateado = String.Empty;
            


            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar su Rut");
                return;
            }
            else
            {
                if (Rut.ValidaRut(txtUsuario.Text))
                {
                    Console.WriteLine("Rut Valido");
                }
                else
                {
                    MessageBox.Show("Rut Inválido", "ERROR");
                    txtUsuario.Text = String.Empty;
                    
                }
            }
            // Fin Validar Rut

            // Inicio Validar Contraseña
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Debe ingresar su Contraseña");
                return;
            }
            else
            {
                UsuarioOb.Contrseña = this.txtContraseña.Text;
            }
            // Fin Validar Contraseña

            // Inicio Valida ComboBox
            if (this.comboBox1.Text == "Seleccione Tipo de Usuario")
            {
                MessageBox.Show("Seleccione un tipo de usuario");
            }
    
            else
            { 
                UsuarioOb.Tipo = this.comboBox1.SelectedItem.ToString();
            

            //Establecer Condición

            // Inicio Validar Datos de ComboBox
            if (UsuarioOb.Buscar() == true)
            {
                OracleConnection conDataBase = new OracleConnection((consultas.Variables.ConString));

                try
                {
                    conDataBase.Open();
                    ////////INICIO FECHA MÉDICA/////////////
                    string Command2 = ""+(consultas.Variables.CorreoFichaMedica)+"";
                    OracleCommand Comm12 = new OracleCommand(Command2, conDataBase);
                    OracleDataReader DR12 = Comm12.ExecuteReader();
                    if (DR12.Read())
                    {
                        txtreciever.Text = DR12["correos"].ToString();
                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Conexión a Gmail
                        MailMessage message = new MailMessage(); // Objeto E-mail
                        message.From = new MailAddress(txtreciever.Text); // Quien envia el e-mail
                        message.To.Add(txtreciever.Text); // Receptor del E-mail
                        txtbody.Text = "Piloto le informamos que ha sido deshabilitado por que su Ficha Médica se encuentra Vencida";
                        message.Body = txtbody.Text; // Mensaje E-mail
                        txtsubject.Text = "Deshabilitado Por Vencimiento de Ficha Médica";
                        message.Subject = txtsubject.Text; // Asunto del E-mail
                        client.UseDefaultCredentials = false;
                        client.EnableSsl = true;
                        /*if(txtattachment.Text != null)
                        {
                            message.Attachments.Add(new Attachment(txtattachment.Text)); //Adding attachment
                        }*/
                        client.Credentials = new System.Net.NetworkCredential(txtsender.Text, txtpass.Text);
                        Cursor.Current = Cursors.WaitCursor;
                        client.Send(message); //Enviar Email
                        Cursor.Current = Cursors.Default;
                        message = null; // Liberar Memoria

                        string QueryUpdate3 = ""+(consultas.Variables.UpdateCorreoFichaMedica)+"";
                        OracleCommand cmdDataBasez3 = new OracleCommand(QueryUpdate3, conDataBase);
                        cmdDataBasez3.ExecuteReader();
                        OracleDataReader dr = null;
                        dr = cmdDataBasez3.ExecuteReader();
                    }
                    ////////FIN FECHA MÉDICA/////////////

                    ////////INICIO CORREO INACTIVIDAD/////////////
                    string Command3 = ""+(consultas.Variables.CorreoInactividad)+"";
                    OracleCommand Comm13 = new OracleCommand(Command3, conDataBase);
                    OracleDataReader DR13 = Comm13.ExecuteReader();
                    if (DR13.Read())
                    {
                        txtreciever.Text = DR13["correos"].ToString();
                        SmtpClient client2 = new SmtpClient("smtp.gmail.com", 587); //Conexión a Gmail
                        MailMessage message2 = new MailMessage(); // Objeto E-mail
                        message2.From = new MailAddress(txtreciever.Text); // Quien envia el e-mail
                        message2.To.Add(txtreciever.Text); // Receptor del E-mail
                        txtbody.Text = "Piloto le informamos que ha sido deshabilitado por inactividad de vuelos, por favor comunicarse con un operador para normalizar su situación";
                        message2.Body = txtbody.Text; // Mensaje E-mail
                        txtsubject.Text = "Deshabilitado Por Inactividad de Vuelos";
                        message2.Subject = txtsubject.Text; // Asunto del E-mail
                        client2.UseDefaultCredentials = false;
                        client2.EnableSsl = true;
                        /*if(txtattachment.Text != null)
                        {
                            message.Attachments.Add(new Attachment(txtattachment.Text)); //Adding attachment
                        }*/
                        client2.Credentials = new System.Net.NetworkCredential(txtsender.Text, txtpass.Text);
                        Cursor.Current = Cursors.WaitCursor;
                        client2.Send(message2); //Enviar Email
                        Cursor.Current = Cursors.Default;
                        message2 = null; // Liberar Memoria

                        string QueryUpdate3 = ""+(consultas.Variables.UpdateCorreoInactividad)+"";
                        OracleCommand cmdDataBasez3 = new OracleCommand(QueryUpdate3, conDataBase);
                        cmdDataBasez3.ExecuteReader();
                        OracleDataReader dr = null;
                        dr = cmdDataBasez3.ExecuteReader();

                        ////////FIN CORREO INACTIVIDAD/////////////


                    }
                    
                }



                catch (Exception)
                {

                }

                
                    
                    


                
               
                
                
                ////////////////////////////////////////////////////////////////////////

                if (this.comboBox1.Text == "Administrador")
                { 
                this.Hide();
                VistaAdministrador f = new VistaAdministrador();
                f.ShowDialog();
                }
                else if (this.comboBox1.Text == "Piloto")
                {
                    string Command4 = ""+(consultas.Variables.ValidarEstadoPilotoLogin)+"'" + txtUsuario.Text + "' "+(consultas.Variables.ValidarEstadoPilotoLogin2)+"";
                    OracleCommand Comm14 = new OracleCommand(Command4, conDataBase);
                    OracleDataReader DR14 = Comm14.ExecuteReader();
                    if (DR14.Read())
                    {
                        MessageBox.Show("Piloto te encuentras deshabilitado, revisa tu correo para ver tu situación.");
                        this.Hide();
                        VariableRut = txtUsuario.Text;
                        VistaPiloto f = new VistaPiloto();
                        f.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        VariableRut = txtUsuario.Text;
                        VistaPiloto f = new VistaPiloto();
                        f.ShowDialog();
                    }
                        

                }
                else if (this.comboBox1.Text == "Operador")
                {
                    this.Hide();
                    VistaOperador f = new VistaOperador();
                    f.ShowDialog();
                }
                else if (this.comboBox1.Text == "Consultor")
                {
                    this.Hide();
                    VistaConsultor f = new VistaConsultor();
                    f.ShowDialog();
                }
                
            }
            else
            {
                txtContraseña.Clear();
                txtUsuario.Clear();
               // txtContraseña.Text = String.Empty;
                MessageBox.Show(UsuarioOb.Mensaje, "ERROR");
                // txtUsuario.Text = String.Empty;
                
            }
            // Fin Validar Datos de ComboBox
            }
            // Fin Validar ComboBox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            this.comboBox1.SelectedIndex = 0;
            txtUsuario.CharacterCasing = CharacterCasing.Upper;

            string username = txtsender.Text;
            txtsender.Text = ""+(consultas.Variables.NombreCorreo)+"";
            txtsender.Enabled = false;
            string pass = txtpass.Text;
            txtpass.Text = ""+(consultas.Variables.PassCorreo)+"";
            txtpass.Enabled = false;
            txtreciever.Enabled = false;
            txtsubject.Enabled = false;
            txtbody.Enabled = false;
            txtsender.Hide();
            txtpass.Hide();
            txtreciever.Hide();
            txtsubject.Hide();
            txtbody.Hide();
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            Usuarios UsuarioOb = new Usuarios();
            // Inicio Validar Rut

            UsuarioOb.Rut = this.txtUsuario.Text;

            string rutSinFormato = UsuarioOb.Rut;
            string rutFormateado = String.Empty;
            if (txtUsuario.Text == "")
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
            txtUsuario.Text = rutFormateado;
            //la salida esperada para el ejemplo es 99.999.999-K
            //MessageBox.Show("RUT Formateado: " + rutFormateado);
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumerosyLetras(e);
        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
