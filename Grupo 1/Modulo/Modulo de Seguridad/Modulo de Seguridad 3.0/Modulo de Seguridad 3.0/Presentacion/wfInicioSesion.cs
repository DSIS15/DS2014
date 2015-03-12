/* Desarrollador: Jorge Leonel Lam
 * Fecha: 01/10/2014
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_de_Seguridad_3._0.Entidades;
using Modulo_de_Seguridad_3._0.Negocio;

namespace Modulo_de_Seguridad_3._0.Presentacion
{
    public partial class wfInicioSesion : Form
    {
        private N_InicioSesion N_Inicio = new N_InicioSesion();
        private E_Usuario eUser = new E_Usuario();

        public wfInicioSesion(Form fMenuPrincipal = null)
        {
            if (fMenuPrincipal != null)
            {
                eUser.FormularioPrincipal = fMenuPrincipal;
            }
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            N_Inicio.vValidarUsuario(txtUsuario.Text, txtPassword.Text);
        }

        private void btnCancelarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lklPregunta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            N_Inicio.vValidarFormPregunta(txtUsuario.Text);
        }
    }
}
