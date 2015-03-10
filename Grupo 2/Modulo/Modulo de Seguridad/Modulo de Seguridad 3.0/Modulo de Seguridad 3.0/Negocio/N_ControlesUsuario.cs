/* Desarrollador: Jorge Leonel Lam
 * Fecha: 01/10/2014
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_de_Seguridad_3._0.Datos;
using Modulo_de_Seguridad_3._0.Entidades;
using Modulo_de_Seguridad_3._0.Presentacion;
using System.Data.Odbc;
using System.IO;

namespace Modulo_de_Seguridad_3._0.Negocio
{
    public class N_ControlesUsuario
    {
        private E_Usuario eUsuario = new E_Usuario();
        private D_ControlUsuario dControlUser = new D_ControlUsuario();
        private static string gsConexion = "DSN=HSCconexion";
        private static OdbcConnection ocConnect;

        public Bitmap bmpObtenerImagen(byte[] bbImagen)
        {
            Bitmap bmpImagen = null;
            try
            {
                MemoryStream MemoryStream = new MemoryStream(bbImagen);
                bmpImagen = new Bitmap(MemoryStream);
                return bmpImagen;
            }
            catch
            {
                bmpImagen = global::Modulo_de_Seguridad_3._0.Properties.Resources.UserDefault;
                return bmpImagen;
            }
        }

        public Bitmap bmpRevisarConexion()
        {
            Bitmap bmpImagen = global::Modulo_de_Seguridad_3._0.Properties.Resources.GreenPoint;
            try
            {
                ocConnect = new OdbcConnection(gsConexion);
                ocConnect.Open();
                ocConnect.Close();
                return bmpImagen = global::Modulo_de_Seguridad_3._0.Properties.Resources.GreenPoint;
            }
            catch (OdbcException)
            {
                return bmpImagen = global::Modulo_de_Seguridad_3._0.Properties.Resources.RedPoint;
            }
        }
      
        public void vCerrarSesion()
        {
            Form fMenuCerrar = eUsuario.FormularioPrincipal;
            try
            {
                if (dControlUser.bCerrarSesion() == true)
                {
                    fMenuCerrar.Hide();
                    new wfInicioSesion().Show();
                }
            }
            catch
            {
                fMenuCerrar.Hide();
                new wfInicioSesion().Show();
                MessageBox.Show("Error al cerrar la sesion");
            }
        }

        public void vSalirSesion()
        {
            try
            {
                if (dControlUser.bCerrarSesion() == true)
                {
                    Application.Exit();
                }
            }
            catch
            {
                Application.Exit();
                MessageBox.Show("Error al cerrar la aplicación");
            }
        }

        public void vIniciar()
        {
            bool bBandera = false;
            if (bBandera = dControlUser.bObtenerNombre() == true)
            {
                if (bBandera = dControlUser.bObtenerPerfil() == true)
                {
                    bBandera = dControlUser.bObtenerImagen();
                }
            }
            dControlUser.vObtenerPrivilegio();
            if (bBandera == false)
            {
                MessageBox.Show("No se pudo cargar los datos de la cuenta");
            }
            else
            {
                eUsuario.ImagenUsuario = bmpObtenerImagen(eUsuario.ImagenBytes);
            }
        }

        public void vGuardarSalir()
        {
            Form fMenuCerrar = eUsuario.FormularioPrincipal;
            try
            {
                fMenuCerrar.Hide();
                new wfInicioSesion().Show();
                MessageBox.Show("La Sesion sera Guardada y podra ser utilizada más tarde", "Hotel San Carlos");
            }
            catch
            {
                fMenuCerrar.Hide();
                new wfInicioSesion().Show();
                MessageBox.Show("Error al cerrar la sesion");
            }
        }

       
    }
}
