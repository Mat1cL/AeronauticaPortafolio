using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Conexion;


namespace Logica.Clases
{
    public class Piloto
    {
        private string rutpiloto;
        public static string RutPiloto_;
        private string nombre;
        public static string Nombre_;
        private string apellidopaterno;
        public static string ApellidoPaterno_;
        private string apellidomaterno;
        public static string ApellidoMaterno_;
        private string fechanacimiento;
        public static string FechaNacimiento_;
        private string correo;
        public static string Correo_;
        private string direccion;
        public static string Direccion_;
        private string telefono;
        public static string Telefono_;
        private string celular;
        public static string Celular_;
        private string sexo;
        public static string Sexo_;
        private string comuna;
        public static string Comuna_;

        public string Rutpiloto
        {
            get 
            {
                return this.rutpiloto;
            }
            set
            {
                this.rutpiloto = value;
            }
        }
        
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellidopaterno
        {
            get
            {
                return this.apellidopaterno;
            }
            set
            {
                this.apellidopaterno = value;
            }
        }

        public string Apellidomaterno
        {
            get
            {
                return this.apellidomaterno;
            }
            set
            {
                this.apellidomaterno = value;
            }
        }

        public string Fechanacimiento
        {
            get
            {
                return this.fechanacimiento;
            }
            set
            {
                this.fechanacimiento = value;
            }
        }

        public string Correo
        {
            get
            {
                return this.correo;
            }
            set
            {
                this.correo = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        public string Celular
        {
            get
            {
                return this.celular;
            }
            set
            {
                this.celular = value;
            }
        }

        public string Sexo
        {
            get
            {
                return this.sexo;
            }
            set
            {
                this.sexo = value;
            }
        }

        public string Comuna
                {
                    get
                    {
                        return this.comuna;
                    }
                    set
                    {
                        this.comuna = value;
                    }
                }
    }
}
