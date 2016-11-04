using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;
using Conexion;

namespace Logica
{

    public class datos
    {
        private string cadena = ""+(conexion.ConString)+"";
        public OracleConnection cn;
        private OracleCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public OracleDataAdapter da;
        public void conectar() { cn = new OracleConnection(cadena); }
        public OracleCommand comando;
        public datos() { conectar(); }





        //consultar
        public void consultar(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new OracleDataAdapter(sql, cn);
            cmb = new OracleCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public static void SoloNumerosyLetras(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }

            else
            {
                pE.Handled = true;
            }


        }

        //Solo Números
        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        //Solo Letras
        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        //eliminar
        public bool eliminar(string sql)
        {
            try
            {
                cn.Open();
                comando = new OracleCommand(sql, cn);
                int i = comando.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        //actualizar
        public bool actualizar(string sql)
        {
            try
            {
                cn.Open();
                comando = new OracleCommand(sql, cn);
                int i = comando.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable consultar2(string tabla)
        {
            string sql = "select * from" + tabla;
            da = new OracleDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }

        //insertar
        public bool insertar(string sql)
        {
            cn.Open();
            comando = new OracleCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void consultar()
        {
            throw new NotImplementedException();
        }




    }
}
