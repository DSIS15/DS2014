/* Desarrollador: Anthony Molineros
 * Fecha: 26/09/2014
 * Comentario: Programación de funciones Abrir conexion y Cerrar conexion
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace ODBCconnector
{
    public class csConexion : csErrores
    {
        private static string gsConexion = "DSN=HSCconexion";
        private static OdbcConnection ocConexion;

        protected static OdbcConnection Conexion
        {
            get { return ocConexion; }
            set { ocConexion = value; }
        }

        public csConexion()
        {
            ocConexion = new OdbcConnection(gsConexion);
        }

        protected static bool bAbrirConexion()
        {
            try
            {
                ocConexion = new OdbcConnection(gsConexion);
                ocConexion.Open();
                return true;
            }
            catch (OdbcException ex)
            {
                vControlErrores(ex.Errors);
                return false;
            }
        }

        protected static void vCerrarConexion()
        {
            try
            {
                ocConexion.Close();
            }
            catch (OdbcException ex)
            {
                vControlErrores(ex.Errors);
            }
        }
    }
}
