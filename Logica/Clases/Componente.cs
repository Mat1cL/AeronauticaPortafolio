using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Conexion;

namespace Logica
{
    public class Componente
    {
        private string nombre_componente;
        public static string NombreComponente;
        private string descripcion;
        public static string Descripcion_;
        private string proveedor;
        public static string Proveedor_;
        private string matricula;
        public static string Matricula_;

        public string Nombre_componente
        {
            get
            {
                return this.nombre_componente;
            }
            set
            {
                this.nombre_componente = value;
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

        public string Proveedor
        {
            get
            {
                return this.proveedor;
            }
            set
            {
                this.proveedor = value;
            }
        }

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
    }
}
