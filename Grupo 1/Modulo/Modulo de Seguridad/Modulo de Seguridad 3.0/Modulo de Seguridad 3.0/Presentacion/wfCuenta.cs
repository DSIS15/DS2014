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

namespace Modulo_de_Seguridad_3._0.Presentacion
{
    public partial class wfCuenta : Form
    {
        private E_Usuario eUsuario = new E_Usuario();
        public wfCuenta()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void wfCuenta_Load(object sender, EventArgs e)
        {
            lblNombre.Text = eUsuario.NombreUsuario;
            lblCuenta.Text = eUsuario.Cuenta;
            lblPerfil.Text = eUsuario.Perfil;
            lblPrivilegio.Text = eUsuario.Privilegio;
            pboImagenUsuario.Image = eUsuario.ImagenUsuario;
        }
    }
}
