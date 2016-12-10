using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Aeronave
    {
        private string matricula;
        public static string Matricula_;
        private string dtinspeccion;
        public static string FechaInspeccionAnual_;
        private string anofabricacion;
        public static string AnoFabricacion_;
        private string tipoaeronave;
        public static string tipo_aeronave;
        private string fabricante;
        public static string Fabricante_;
        private string modelo;
        public static string Modelo_;
        private string estado;
        public static string Estado_;
       

        public string Matricula
        {
            get
            {
                return this.matricula;
            }
            set
            {
                this.matricula = value;
            }
        }

        public string Dtinspeccion
        {
            get
            {
                return this.dtinspeccion;
            }
            set
            {
                this.dtinspeccion = value;
            }
        }

        public string Anofabricacion
        {
            get
            {
                return this.anofabricacion;
            }
            set
            {
                this.anofabricacion = value;
            }
        }

        public string Tipoaeronave
        {
            get
            {
                return this.tipoaeronave;
            }
            set
            {
                this.tipoaeronave = value;
            }
        }
        public string Fabricante
        {
            get
            {
                return this.fabricante;
            }
            set
            {
                this.fabricante = value;
            }
        }
        public string Modelo
        {
            get
            {
                return this.modelo;
            }
            set
            {
                this.modelo = value;
            }
        }

        public string Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
    }
}
