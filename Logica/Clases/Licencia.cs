using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Licencia
    {
        private string numerolicencia;
        public static string NumeroLicencia_;
        private string descripcion;
        public static string Descripcion_;
        private string fechavencimiento;
        public static string FechaVencimiento_;
        private string rutpiloto;
        public static string RutPiloto_;
        private string asd;
        public static string Licencia_;

        public string Numerolicencia
        {
            get
            {
                return this.numerolicencia;
            }
            set
            {
                this.numerolicencia = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        public string Fechavencimiento
        {
            get
            {
                return this.fechavencimiento;
            }
            set
            {
                this.fechavencimiento = value;
            }
        }

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

        public string Asd
        {
            get
            {
                return this.asd;
            }
            set
            {
                this.asd = value;
            }
        }
    }
}
