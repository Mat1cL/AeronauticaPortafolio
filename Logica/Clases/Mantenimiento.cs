using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Conexion;


namespace Logica.Clases
{
    public class Mantenimiento
    {

        private string fechaingreso;
        public static string FechaIngreso_;
        private string fechatermino;
        public static string FechaTermino_;
        private string nombretaller;
        public static string NombreTaller_;
        private string tipomantenimiento;
        public static string TipoMantenimiento_;
        private string aeronave;
        public static string Aeronave_;

        public string Fechatermino
        {
            get
            {
                return this.fechatermino;
            }
            set
            {
                this.fechatermino = value;
            }
        }

        public string Nombretaller
        {
            get
            {
                return this.nombretaller;
            }
            set
            {
                this.nombretaller = value;
            }
        }

        public string Fechaingreso
        {
            get
            {
                return this.fechaingreso;
            }
            set
            {
                this.fechaingreso = value;
            }
        }

        public string Tipomantenimiento
        {
            get
            {
                return this.tipomantenimiento;
            }
            set
            {
                this.tipomantenimiento = value;
            }
        }

        public string Aeronave
        {
            get
            {
                return this.aeronave;
            }
            set
            {
                this.aeronave = value;
            }
        }
    }
}
