using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Conexion;


namespace Logica
{
    public class PlanVuelo
    {
        private string descripcion;
        public static string Descripcion_;
        private string fechasalida;
        public static string FechaSalida_;
        private string horasalida;
        public static string HoraSalida_;
        private string fechallegada;
        public static string FechaLlegada_;
        private string horallegada;
        public static string HoraLlegada_;
        private string condicion;
        public static string Condicion_;
        private string mision;
        public static string Mision_;
        private string piloto;
        public static string Piloto_;
        private string copiloto;
        public static string Copiloto_;
        private string tipolicenciapiloto;
        public static string TipoLicenciaPiloto_;
        private string tipolicenciacopiloto;
        public static string TipoLicenciaCopiloto_;
        private string ruta;
        public static string Ruta_;
        private string destino;
        public static string Destino_;
        private string origen;
        public static string Origen_;
        private string aeronave;
        public static string Aeronave_;

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

        public string Fechasalida
        {
            get
            {
                return this.fechasalida;
            }
            set
            {
                this.fechasalida = value;
            }
        }

        public string Horasalida
        {
            get
            {
                return this.horasalida;
            }
            set
            {
                this.horasalida = value;
            }
        }

        public string Fechallegada
        {
            get
            {
                return this.fechallegada;
            }
            set
            {
                this.fechallegada = value;
            }
        }

        public string Horallegada
        {
            get
            {
                return this.horallegada;
            }
            set
            {
                this.horallegada = value;
            }
        }

        public string Condicion
        {
            get
            {
                return this.condicion;
            }
            set
            {
                this.condicion = value;
            }
        }

        public string Mision
        {
            get
            {
                return this.mision;
            }
            set
            {
                this.mision = value;
            }
        }

        public string Piloto
        {
            get
            {
                return this.piloto;
            }
            set
            {
                this.piloto = value;
            }
        }

        public string Copiloto
        {
            get
            {
                return this.copiloto;
            }
            set
            {
                this.copiloto = value;
            }
        }

        public string Tipolicenciapiloto
        {
            get
            {
                return this.tipolicenciapiloto;
            }
            set
            {
                this.tipolicenciapiloto = value;
            }
        }

        public string Tipolicenciacopiloto
        {
            get
            {
                return this.tipolicenciacopiloto;
            }
            set
            {
                this.tipolicenciacopiloto = value;
            }
        }

        public string Ruta
        {
            get
            {
                return this.ruta;
            }
            set
            {
                this.ruta = value;
            }
        }

        public string Destino
        {
            get
            {
                return this.destino;
            }
            set
            {
                this.destino = value;
            }
        }

        public string Origen
        {
            get
            {
                return this.origen;
            }
            set
            {
                this.origen = value;
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
