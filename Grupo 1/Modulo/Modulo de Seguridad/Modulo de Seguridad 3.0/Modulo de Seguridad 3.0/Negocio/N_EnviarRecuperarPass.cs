/* Desarrollador: Jorge Leonel Lam
 * Fecha: 01/10/2014
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvioCorreos;
using Modulo_de_Seguridad_3._0.Datos;
using Modulo_de_Seguridad_3._0.Entidades;
using System.Windows.Forms;

namespace Modulo_de_Seguridad_3._0.Negocio
{
    internal class N_EnviarRecuperarPass
    {
        private Correo NuevoCorreo = new Correo();
        private D_ControlUsuario dControles = new D_ControlUsuario();
        private E_Usuario eUsuario = new E_Usuario();

        private void vObtenerNombreCuenta(String sCuenta)
        {
            if (dControles.bObtenerNombreCorreo(sCuenta) == false)
            {
                MessageBox.Show("Error al obtener datos para el mensaje","Hotel San Carlos");
            }
        }
        public void vEnviarRecuperacion(String sCorreo, String sPass, String sCuenta)
        {
            vObtenerNombreCuenta(sCuenta);
            NuevoCorreo.Para = sCorreo;
            NuevoCorreo.Remitente = "leokirap014@gmail.com";
            NuevoCorreo.Asunto = "Hotel San Carlos - Recuperación de Contaseña";
            NuevoCorreo.Mensaje = "Buenos Días, Estimado Empleado de Hotel San Carlos" + Environment.NewLine
                + eUsuario.NombreUsuario + Environment.NewLine + Environment.NewLine + Environment.NewLine
                + "Su contraseña es: " + sPass
                + Environment.NewLine + Environment.NewLine
                + "Gracias! por usar el Servicio de Correo de Hotel San Carlos";
            NuevoCorreo.TipoCliente = "smtp.live.com";
            NuevoCorreo.PuertoCliente = 587;
            NuevoCorreo.Credencial = "";
            NuevoCorreo.PassCredencial = "";
            NuevoCorreo.vEnviarCorreo();
        }
    }
}
