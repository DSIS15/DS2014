/* Desarrollador: Anthony Molineros
 * Fecha: 26/09/2014
 * Comentario: Programación de funciones de Inserción, Eliminación, Modificación y Consulta
 */

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace ODBCconnector
{
    public class csFunciones : csConexion
    {
        private static void vEjecutarDDL(string sQuery, string sAccion, bool bHabilitarMensaje)
        {
            if (bAbrirConexion())
            {
                try
                {
                    OdbcCommand ocComando = new OdbcCommand(sQuery, Conexion);
                    ocComando.ExecuteNonQuery();
                    vCerrarConexion();
                    if (bHabilitarMensaje == true) 
                    {
                        MessageBox.Show("Registro "+sAccion+" Correctamente","Hotel San Carlos");
                    }
                }
                catch (OdbcException ex)
                {
                    vControlErrores(ex.Errors);
                }
            }
        }

        public static void vEliminar(string sQuery, bool bHabilitarMensaje = true)
        {
            vEjecutarDDL(sQuery, "eliminado", bHabilitarMensaje);
        }

        public static void vInsertar(string sQuery, bool bHabilitarMensaje = true)
        {
            vEjecutarDDL(sQuery, "insertado", bHabilitarMensaje);
        }

        public static void vModificar(string sQuery, bool bHabilitarMensaje = true)
        {
            vEjecutarDDL(sQuery, "modificado", bHabilitarMensaje);
        }

        public static ArrayList alConsultar(string sQuery)
        {
            ArrayList alDatos = new ArrayList();
            if (bAbrirConexion())
            {
                try
                {
                    OdbcCommand ocComando = new OdbcCommand(sQuery, Conexion);
                    OdbcDataReader odReader = ocComando.ExecuteReader();
                    while (odReader.Read())
                    {
                        ArrayList alFila = new ArrayList();
                        for (int iCont = 0; iCont < odReader.FieldCount; iCont++)
                        {
                            alFila.Add(odReader.GetString(iCont));
                        }
                        alDatos.Add(alFila);
                    }
                    vCerrarConexion();
                    return alDatos;
                }
                catch (OdbcException ex)
                {
                    vControlErrores(ex.Errors);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
