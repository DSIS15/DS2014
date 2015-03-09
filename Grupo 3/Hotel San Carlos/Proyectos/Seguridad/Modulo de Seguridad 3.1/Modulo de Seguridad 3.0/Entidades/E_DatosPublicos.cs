using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_de_Seguridad_3._0.Entidades
{
    public class E_DatosPublicos
    {
        private static ArrayList alApps;
        private static ArrayList alAppsPersonales;
        private static int iCodUsr;
        private static int iPrivilegio;

        public ArrayList alAplicaciones
        {
            get { return alApps; }
            set { alApps = value; }
        }

        public ArrayList alAplicacionesPersonales
        {
            get { return alAppsPersonales; }
            set { alAplicacionesPersonales = value; }
        }

        public int iCodigoUsuario
        {
            get { return iCodUsr; }
            set { iCodUsr = value; }
        }

        public int iCodigoPrivilegio
        {
            get { return iPrivilegio; }
            set { iPrivilegio = value; }
        }
    }
}
