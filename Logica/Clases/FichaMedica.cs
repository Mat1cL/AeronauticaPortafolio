using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class FichaMedica
    {
        private string fecha_vencimiento;
        public static string FechaVencimiento;
        private string descripcion;
        public static string Descripcion_;
        private string rutpiloto;
        public static string RutPiloto_;

        public string Fecha_vencimiento
        {
            get
            {
                return this.fecha_vencimiento;
            }
            set
            {
                this.fecha_vencimiento = value;
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
    }
}
