using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace Conexion
{
    public class conexion
    {

        //Declarar Variables
        public string cadenaconexion;
        protected string sql; //Ejecuta consultas
        protected OracleConnection cnn;
        protected OracleCommand comandosql;
        protected string mensaje; //Mensaje enviado al Usuario
        public static string ConString = "User Id = system; Password = 123; Data Source=XE;";
        public static string AMNJD = "duoc2016";
        //Metodo de conexión
        public conexion()
        {
            //Pasar cadenaconexion
            this.cadenaconexion = ""+(conexion.ConString)+"";
            this.cnn = new OracleConnection(this.cadenaconexion);
        }

        //Declarar Metodo de Mensaje a Usuario
        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
        }
    }
}
