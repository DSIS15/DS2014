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
            Application.Exit();
        }

        private void lklPregunta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            N_Inicio.vValidarFormPregunta(txtUsuario.Text);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSesion_Click(this, e);
            }
        }

        private void wfInicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void wfInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
