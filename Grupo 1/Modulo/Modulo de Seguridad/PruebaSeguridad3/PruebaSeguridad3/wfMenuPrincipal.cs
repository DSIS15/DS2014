using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_de_Seguridad_3._0.Negocio;
using Modulo_de_Seguridad_3._0.Presentacion;
using Modulo_de_Seguridad_3._0.Entidades;

using System.Collections;

namespace PruebaSeguridad3
{
    public partial class wfMenuPrincipal : Form
    {
        public wfMenuPrincipal()
        {
            InitializeComponent();
        }

        private N_ControlesUsuario Controles = new N_ControlesUsuario();

        private void wfMenuPrincipal_Load(object sender, EventArgs e)
        {
            Controles.vIniciar();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Controles.vCerrarSesion();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controles.vSalirSesion();
        }

        private void cuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new wfCuenta().Show();
        }

        private void conexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conexionToolStripMenuItem.Image = Controles.bmpRevisarConexion();
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String derechos = string.Empty;
            ArrayList alAplicaciones = new E_DatosPublicos().alAplicaciones;
            foreach (E_Aplicaciones Dato in alAplicaciones)
            {
                int codigoApp = Dato.CodigoAplicacion;
                string nombreApp = Dato.NombreAplicacion;
                Dictionary <string,int> DerechosApp = Dato.PrivilegiosAplicacion;
                foreach (KeyValuePair<string, int> Valor in DerechosApp)
                {
                    derechos += Valor.Key + ": " + Valor.Value + Environment.NewLine;
                }
                MessageBox.Show(codigoApp + ", " + nombreApp + Environment.NewLine + derechos);
                derechos = String.Empty;
            }
        }
    }
}
