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

namespace Modulo_de_Seguridad_3._0.Presentacion
{
    public partial class wfRecuperarPass : Form
    {
        private N_EnviarRecuperarPass nEnviarPass = new N_EnviarRecuperarPass();
        private static string sPregunta;
        private static string sRespuesta;
        private static string sPassword;
        private static string sCorreo;
        private static string sCuenta;

        public string Pregunta { set { sPregunta = value; } }

        public string Respuesta { set { sRespuesta = value; } }

        public string Password { set { sPassword = value; } }

        public string Correo { set { sCorreo = value; } }

        public string Cuenta { set { sCuenta = value; } }

        public wfRecuperarPass()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtRespuesta.Text == sRespuesta)
            {
                try
                {
                    nEnviarPass.vEnviarRecuperacion(sCorreo, sPassword, sCuenta);
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Error al intentar enviar el Correo","Hotel San Carlos");
                }
            }
            else
            {
                MessageBox.Show("No coincide");
            }
        }

        private void wfRecuperarPass_Load(object sender, EventArgs e)
        {
            lblPregunta.Text = sPregunta;
        }
    }
}
