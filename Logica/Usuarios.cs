using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Conexion;

namespace Logica
{
    public class Usuarios : conexion
    {
        private string rut;
        private string contraseña;
        private string tipo;


        //Metodo
        public Usuarios()
        {
            rut = string.Empty;
            contraseña = string.Empty;

            //Ejecuta consultas
            this.sql = string.Empty;
        }

        public string Rut
        {
            get
            {
                return this.rut;
            }
            set
            {
                this.rut = value;
            }
        }

        public string Contrseña
        {
            get
            {
                return this.contraseña;
            }
            set
            {
                this.contraseña = value;
            }
        }

        public String Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public bool Buscar()
        {
            bool Resultado = false;
            this.sql = string.Format(@"SELECT * FROM usuario INNER JOIN tipo_usuario ON usuario.tipo_usuario_id_tipo_usuario = tipo_usuario.id_tipo_usuario  WHERE rut='{0}' AND contrasena='{1}' AND nombre_tipo_usuario='{2}'", this.rut, this.contraseña, this.tipo);
            this.comandosql = new OracleCommand(this.sql, this.cnn);
            this.cnn.Open();
            OracleDataReader Reg = null;
            Reg = this.comandosql.ExecuteReader();
            if (Reg.Read())
            {
                Resultado = true;
                this.mensaje = "Bienvenido!!";
            }
            else
            {
                Resultado = false;
                this.mensaje = "Datos Incorrectos";

            }

            this.cnn.Close();
            return Resultado;
        }


    }
}
