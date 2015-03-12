/* Desarrollador: Jorge Leonel Lam
 * Fecha: 01/10/2014
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Modulo_de_Seguridad_3._0.Entidades;
using ODBCconnector;
using System.Windows.Forms;
using Modulo_de_Seguridad_3._0.Datos;
using Modulo_de_Seguridad_3._0.Presentacion;

namespace Modulo_de_Seguridad_3._0
{
    internal class N_InicioSesion: D_InicioSesion 
    {
        private ArrayList alResultados = new ArrayList();
        private E_Usuario E_Usuario = new E_Usuario();
        private wfRecuperarPass wfRecuperar = new wfRecuperarPass();

        private void vCargarMenuPrincipal(bool bCargaForm)
        {
            if (bCargaForm == true)
            {
                try
                {
                    Form fFormularioPrincipal = E_Usuario.FormularioPrincipal;
                    fFormularioPrincipal.Dock = DockStyle.Fill;
                    fFormularioPrincipal.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("No hay Formulario Principal Cargado");
                }
            }
        }

        public void vValidarUsuario(String sUser, String sPass)
        {
            if (sUser.Length != 0 && sPass.Length != 0)
            {
                try
                {
                    if (bBuscarUsuario(sUser, sPass) == true)
                    {
                        if (bComprobarFuente() == true)
                        {
                            if (bObtenerPrivilegio() == true)
                            {
                                if (bBuscarSesionesAbiertas() == true)
                                {
                                    if (bObtenerPerfilUsuario() == true)
                                    {
                                        if (bObtenerPerfil() == true)
                                        {
                                            wfInicioSesion.ActiveForm.Hide();
                                            vCargarMenuPrincipal(bBuscarAplicaciones());
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error al Inicio de Sesion");
                }
            }
            else
            {
                MessageBox.Show("Usuario/Password Vacios", "Hotel San Carlos");
            }
        }

        public void vValidarFormPregunta(String sUser)
        {
            if (sUser.Length != 0)
            {
                if (bObtenerPregunta(sUser) == true)
                {
                    new wfRecuperarPass().Show();
                }
                else
                {
                    MessageBox.Show("No se pudo encotrar el Usuario","Hotel San Carlos");
                }
            }
            else
            {
                MessageBox.Show("No se ha ingresado el Usuario a recuperar contraseña","Hotel San Carlos");
            }
        } 
    }
}
