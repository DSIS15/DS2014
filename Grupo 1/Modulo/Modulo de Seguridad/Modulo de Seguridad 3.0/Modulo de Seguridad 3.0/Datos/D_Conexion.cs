/* Desarrollador: Jorge Leonel Lam
 * Fecha: 01/10/2014
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Modulo_de_Seguridad_3._0.Datos
{
    internal class D_Conexion
    {
        private static string gsConexion = "DSN=HSCconexion";
        private static OdbcConnection ocConexion;

        protected static OdbcConnection Conexion
        {
            get { return ocConexion; }
            set { ocConexion = value; }
        }

        public D_Conexion()
        {
            ocConexion = new OdbcConnection(gsConexion);
        }

        public static bool bAbrirConexion()
        {
            try
            {
                ocConexion = new OdbcConnection(gsConexion);
                ocConexion.Open();
                return true;
            }
            catch (OdbcException)
            {
                //vControlErrores(ex.Errors);
                return false;
            }
        }

        public static void vCerrarConexion()
        {
            try
            {
                ocConexion.Close();
            }
            catch (OdbcException)
            {
                //vControlErrores(ex.Errors);
            }
        }
    }
}
