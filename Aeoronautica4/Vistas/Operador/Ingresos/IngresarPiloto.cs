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
using System.Text.RegularExpressions;
using Aeronautica;
using Logica;
using Conexion;




namespace Aeronautica
{
    public partial class IngresarPiloto : Form
    {
        public IngresarPiloto()
        {
            InitializeComponent();

        }

  
        void FillCbPais()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;

            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter((consultas.Variables.SelectCboPais), conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_pais"] = Convert.ToInt32("0");
                row["nombre_pais"] = "Seleccione un País";
                dt.Rows.InsertAt(row, 0);
                cboPais.DataSource = dt;
                cboPais.DisplayMember = "nombre_pais";
                cboPais.ValueMember = "nombre_pais";
                this.cboPais.SelectedIndex = 0;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbRegion()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboRegion)+"'" + this.cboPais.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_region"] = Convert.ToInt32("0");
                row["nombre_region"] = "Seleccione una Región";
                dt.Rows.InsertAt(row, 0);
                this.cboRegion.DataSource = dt;
                this.cboRegion.DisplayMember = "nombre_region";
                this.cboRegion.ValueMember = "nombre_region";
                this.cboRegion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbProvincia()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);;
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboProvincia)+"'" + this.cboRegion.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_provincia"] = Convert.ToInt32("0");
                row["nombre_provincia"] = "Seleccione una Provincia";
                dt.Rows.InsertAt(row, 0);
                this.cboProvincia.DataSource = dt;
                this.cboProvincia.DisplayMember = "nombre_provincia";
                this.cboProvincia.ValueMember = "nombre_provincia";
                this.cboProvincia.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void FillCbComuna()
        {
            DataTable dt = new DataTable();
            String strconn = (consultas.Variables.ConString);
            OracleConnection conn;
            OracleDataAdapter da;
            try
            {
                conn = new OracleConnection(strconn);
                da = new OracleDataAdapter(""+(consultas.Variables.SelectCboComuna)+"'" + this.cboProvincia.SelectedValue + "'", conn);
                dt.Clear();
                da.Fill(dt);
                conn.Close();
                DataRow row = dt.NewRow();
                row["id_comuna"] = Convert.ToInt32("0");
                row["nombre_comuna"] = "Seleccione una Comuna";
                dt.Rows.InsertAt(row, 0);
                this.cboComuna.DataSource = dt;
                this.cboComuna.DisplayMember = "nombre_comuna";
                this.cboComuna.ValueMember = "id_comuna";
                this.cboComuna.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }


        string Sexo;
        datos obDAtos = new datos();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Logica.Clases.Piloto.RutPiloto_ = txtRut.Text;
            Logica.Clases.Piloto.Nombre_ = txtNombre.Text;
            Logica.Clases.Piloto.ApellidoPaterno_ = txtApellidoPaterno.Text;
            Logica.Clases.Piloto.ApellidoMaterno_ = txtApellidoMaterno.Text;
            Logica.Clases.Piloto.FechaNacimiento_ = dtFecha.Text;
            Logica.Clases.Piloto.Correo_ = txtCorreo.Text;
            Logica.Clases.Piloto.Direccion_ = txtDireccion.Text;
            Logica.Clases.Piloto.Telefono_ = txtTelefono.Text;
            Logica.Clases.Piloto.Celular_ = txtCelular.Text;
            Logica.Clases.Piloto.Sexo_ = Sexo;
            Logica.Clases.Piloto.Comuna_ = cboComuna.SelectedValue.ToString();


                if (txtRut.Text.Length > 0)
                {
                    errorProvider1.SetError(txtRut, string.Empty);
                    if (Rut.ValidaRut(txtRut.Text))
                    {
                        Console.WriteLine("Rut Valido");
                    }
                    else
                    {
                        MessageBox.Show("Rut Inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtRut.Clear();
                        errorProvider1.SetError(txtRut, string.Empty);
                    }
                }
                if (txtNombre.Text.Length > 0)
                {
                    errorProvider1.SetError(txtNombre, string.Empty);
                }
                if (txtApellidoPaterno.Text.Length > 0)
                {
                    errorProvider1.SetError(txtApellidoPaterno, string.Empty);
                }
                if (txtApellidoMaterno.Text.Length > 0)
                {
                    errorProvider1.SetError(txtApellidoMaterno, string.Empty);
                }
                if (txtCorreo.Text.Length > 0)
                {
                    errorProvider1.SetError(txtCorreo, string.Empty);
                    string pattern = null;
                    pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                    if (Regex.IsMatch(txtCorreo.Text, pattern))
                    {
                       
                    }
                    else
                    {
                        MessageBox.Show("E-mail inválido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (txtDireccion.Text.Length > 0)
                {
                    errorProvider1.SetError(txtDireccion, string.Empty);
                }
                if (txtTelefono.Text.Length > 0)
                {
                    errorProvider1.SetError(txtTelefono, string.Empty);
                }
                if (txtCelular.Text.Length > 0)
                {
                    errorProvider1.SetError(txtCelular, string.Empty);
                }
                if (dtFecha.Value <= DateTime.Now.AddYears(-17))
                {
                    errorProvider1.SetError(dtFecha, string.Empty);
                }
                if (rM.Checked == true)
                {
                    errorProvider1.SetError(grpSexo, string.Empty);
                }
                if (rF.Checked == true)
                {
                    errorProvider1.SetError(grpSexo, string.Empty);
                }
                if (cboPais.Text != "Seleccione un País")
                {
                    errorProvider1.SetError(cboPais, string.Empty);
                }
                if (cboRegion.Text != "Seleccione una Región")
                {
                    errorProvider1.SetError(cboRegion, string.Empty);
                }
                if (cboProvincia.Text != "Seleccione una Provincia")
                {
                    errorProvider1.SetError(cboProvincia, string.Empty);
                }
                if (cboComuna.Text != "Seleccione una Comuna")
                {
                    errorProvider1.SetError(cboComuna, string.Empty);
                }
            
                //**//
                if (string.IsNullOrWhiteSpace(txtRut.Text))
                {
                    errorProvider1.SetError(txtRut, "Debe ingresar su Rut");
                }
                if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
                {
                    errorProvider1.SetError(txtNombre, "Debe ingresar su Nombre");
                }
                if (string.IsNullOrWhiteSpace(this.txtApellidoPaterno.Text))
                {
                    errorProvider1.SetError(txtApellidoPaterno, "Debe ingresar su Apellido Paterno");
                }
                if (string.IsNullOrWhiteSpace(this.txtApellidoMaterno.Text))
                {
                    errorProvider1.SetError(txtApellidoMaterno, "Debe ingresar su Apellido Materno");
                }
                if (string.IsNullOrWhiteSpace(this.txtCorreo.Text))
                {
                    errorProvider1.SetError(txtCorreo, "Debe ingresar su correo");
                }
                if (string.IsNullOrWhiteSpace(this.txtDireccion.Text))
                {
                    errorProvider1.SetError(txtDireccion, "Debe ingresar su dirección");
                }
                if (cboPais.Text == "Seleccione un País")
                {
                    errorProvider1.SetError(cboPais, "Debes Seleccionar un País");
                }
                if (cboRegion.Text == "Seleccione una Región")
                {
                    errorProvider1.SetError(cboRegion, "Debes Seleccionar una Región");
                }
                if (cboProvincia.Text == "Seleccione una Provincia")
                {
                    errorProvider1.SetError(cboProvincia, "Debes Seleccionar una Provincia");
                }
                if (cboComuna.Text == "Seleccione una Comuna")
                {
                    errorProvider1.SetError(cboComuna, "Debes Seleccionar una Comuna");
                }
                if (string.IsNullOrWhiteSpace(this.txtTelefono.Text))
                {
                    errorProvider1.SetError(txtTelefono, "Debes ingresar un teléfono");
                }
                if (string.IsNullOrWhiteSpace(this.txtCelular.Text))
                {
                    errorProvider1.SetError(txtCelular, "Debes ingresar un celular");
                }
                if (dtFecha.Value >= DateTime.Now.AddYears(-17))
                {
                    errorProvider1.SetError(dtFecha, "El piloto debe ser mayor a 17 años");
                    
                }
                if (string.IsNullOrWhiteSpace(this.Sexo))
                {
                    errorProvider1.SetError(grpSexo, "Debes seleccionar un sexo");
                }

                /*VALIDAR SI EXISTEN ERRORES*/
                if (errorProvider1.GetError(txtRut) == "Debe ingresar su Rut")
                {
                    return;
                }
                if (errorProvider1.GetError(txtNombre) == "Debe ingresar su Nombre")
                {
                    return;
                }
                if (errorProvider1.GetError(txtApellidoPaterno) == "Debe ingresar su Apellido Paterno")
                {
                    return;
                }
                if (errorProvider1.GetError(txtApellidoMaterno) == "Debe ingresar su Apellido Materno")
                {
                    return;
                }
                if (errorProvider1.GetError(txtCorreo) == "Debe ingresar su correo")
                {
                    return;
                }
                if (errorProvider1.GetError(txtDireccion) == "Debe ingresar su dirección")
                {
                    return;
                }
                if (errorProvider1.GetError(cboPais) == "Debes Seleccionar un País")
                {
                    return;
                }
                if (errorProvider1.GetError(cboRegion) == "Debes Seleccionar una Región")
                {
                    return;
                }
                if (errorProvider1.GetError(cboProvincia) == "Debes Seleccionar una Provincia")
                {
                    return;
                }
                if (errorProvider1.GetError(cboComuna) == "Debes Seleccionar una Comuna")
                {
                    return;
                }
                if (errorProvider1.GetError(txtTelefono) == "Debes ingresar un teléfono")
                {
                    return;
                }
                if (errorProvider1.GetError(txtCelular) == "Debes ingresar un celular")
                {
                    return;
                }
                if (errorProvider1.GetError(dtFecha) == "El piloto debe ser mayor a 17 años")
                {
                    return;
                }
                if (errorProvider1.GetError(grpSexo) == "Debes seleccionar un sexo")
                {
                    return;
                }

                /*FIN VALIDAR SI EXISTEN ERRORES*/
                else
                {
                        try
                        {

                            OracleConnection cnn = new OracleConnection(consultas.Variables.ConString);
                            cnn.Open();
                            string sqlString = "" + (consultas.Variables.SelectPiloto) + "'" + Logica.Clases.Piloto.RutPiloto_ + "'";
                            OracleCommand dbCmd = new OracleCommand(sqlString, cnn);
                            OracleDataReader reader = dbCmd.ExecuteReader();
                            string sqlString2 = "" + (consultas.Variables.SelectPilotoCorreo) + "'" + Logica.Clases.Piloto.Correo_ + "'";
                            OracleCommand dbCmdx2 = new OracleCommand(sqlString2, cnn);
                            OracleDataReader reader2 = dbCmdx2.ExecuteReader();
                            string sqlString3 = "" + (consultas.Variables.ValidarRUT) + "'" + Logica.Clases.Piloto.RutPiloto_ + "' " + (consultas.Variables.ValidarRUT2) + "";
                            OracleCommand dbCmdx3 = new OracleCommand(sqlString3, cnn);
                            OracleDataReader reader3 = dbCmdx3.ExecuteReader();
                            if (reader.Read())
                            {
                                MessageBox.Show("El Rut ya se encuentra registrado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (reader2.Read())
                            {
                                MessageBox.Show("El e-mail ingresado ya se encuentra asociado a un Piloto");
                            }
                            else if (reader3.Read())
                            {
                                MessageBox.Show("El RUT se encuentra asociado a un Administrador, Operado o Consultor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string sql = "" + (consultas.Variables.InsertPiloto) + " ('" + Logica.Clases.Piloto.RutPiloto_ + "','" + Logica.Clases.Piloto.Nombre_ + "','" + Logica.Clases.Piloto.ApellidoPaterno_ + "','" + Logica.Clases.Piloto.ApellidoMaterno_ + "','" + Logica.Clases.Piloto.FechaNacimiento_ + "','" + Logica.Clases.Piloto.Correo_ + "','" + Logica.Clases.Piloto.Direccion_ + "','" + Logica.Clases.Piloto.Telefono_ + "','" + Logica.Clases.Piloto.Celular_ + "','" + Logica.Clases.Piloto.Sexo_ + "','" + Logica.Clases.Piloto.Comuna_ + "',2)";

                                if (obDAtos.insertar(sql))
                                {
                                    MessageBox.Show("Piloto Insertado, Recuerda que el Piloto quedara deshabilitado hasta que se registre una Ficha Médica", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al Insertar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }

                        }
                        catch (OracleException ex)
                        {
                            Console.WriteLine("Oracle Exception Message");
                            Console.WriteLine("Exception Message: " + ex.Message);
                            Console.WriteLine("Exception Source: " + ex.Source);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Exception Message");
                            Console.WriteLine("Exception Message: " + ex.Message);
                            Console.WriteLine("Exception Source: " + ex.Source);
                        }
                    
                }
            








        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void rM_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "1";
        }

        private void rF_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = "2";
        }

       



        private void cboPrueba_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VistaOperadorIngresarPiloto_Load(object sender, EventArgs e)
        {
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtApellidoPaterno.CharacterCasing = CharacterCasing.Upper;
            txtApellidoMaterno.CharacterCasing = CharacterCasing.Upper;
            txtCorreo.CharacterCasing = CharacterCasing.Upper;
            txtDireccion.CharacterCasing = CharacterCasing.Upper;
            txtRut.CharacterCasing = CharacterCasing.Upper;
            FillCbPais();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloLetras(e);
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloLetras(e);
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloLetras(e);
        }

        private void txtRut_Validated(object sender, EventArgs e)
        {


            string rutSinFormato = txtRut.Text;
            string rutFormateado = String.Empty;
            if (txtRut.Text == "")
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
                txtRut.Text = rutFormateado;
                //la salida esperada para el ejemplo es 99.999.999-K
                //MessageBox.Show("RUT Formateado: " + rutFormateado);
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumerosyLetras(e);
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbRegion();
        }
        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbProvincia();
        }
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCbComuna();
        }

        private void cboComuna_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumeros(e);
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.SoloNumeros(e);
        }

        private void txtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        


    }
}
