using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_de_Seguridad_3._0.Entidades
{
    internal class E_Perfil
    {
        private static int iCodEmpleado;
        private static int iCodPerfil;
        private static int iCodPerfilAplicaciones;
        private static int iCodPerfilUsuario;
        private static int iCodPrivilegio;
        private static int iCodSesion;
        private static int iCodUsuario;
        private static int iCodAplicacionesPersonales;

        public int CodigoEmpleado
        {
            get { return iCodEmpleado; }
            set { iCodEmpleado = value; }
        }
        public int CodigoPerfilUsuario
        {
            get { return iCodPerfilUsuario; }
            set { iCodPerfilUsuario = value; }
        }
     
        public int CodigoPrivilegio
        {
            get { return iCodPrivilegio; }
            set { iCodPrivilegio = value; }
        }
        public int CodigoSesion
        {
            get { return iCodSesion; }
            set { iCodSesion = value; }
        }
        public int CodigoUsuario
        {
            get { return iCodUsuario; }
            set { iCodUsuario = value; }
        }
        public int CodigoAplicacionesPersonales
        {
            get { return iCodAplicacionesPersonales; }
            set { iCodAplicacionesPersonales = value; }
        }
        public int CodigoPerfil
        {
            get { return iCodPerfil; }
            set { iCodPerfil = value; }
        }
    }
}
