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


namespace Modulo_de_Seguridad_3._0.Entidades
{
    internal class E_Usuario
    {
        private static Bitmap bmpImagen;
        private static String sNombreUsuario;
        private static String sPerfil;
        private static String sPrivilegio;
        private static String sCuenta;
        private static Form fFormPrincipal;
        private static byte[] byImagen;

        public Form FormularioPrincipal { get { return fFormPrincipal; } set { fFormPrincipal = value; } }
        public Bitmap ImagenUsuario { get { return bmpImagen; } set { bmpImagen = value; } }
        public byte[] ImagenBytes { get { return byImagen; } set { byImagen = value; } }
        public String NombreUsuario { get { return sNombreUsuario; } set { sNombreUsuario = value; } }
        public String Privilegio { get { return sPrivilegio; } set { sPrivilegio = value; } }
        public String Perfil { get { return sPerfil; } set { sPerfil = value; } }
        public String Cuenta { get { return sCuenta; } set { sCuenta = value; } }
    }
}
