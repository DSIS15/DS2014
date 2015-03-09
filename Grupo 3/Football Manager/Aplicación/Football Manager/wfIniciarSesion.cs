/* Autor: Anthony Molineros
 * Fecha: 02/08/2014 - Comentario: Diseño y Programación de wfIniciarSesion
 * Fecha: 03/08/2014 - Comentario: Validación de campos
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Football_Manager
{
    public partial class wfIniciarSesion : Form
    {
        public wfIniciarSesion()
        {
            InitializeComponent();
        }

        private void wfIniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text != "") && (txtContrasena.Text != ""))
            {
                if (DLL_Football_Manager.csFunciones.ValidarCredenciales(txtUsuario.Text, txtContrasena.Text) == 1)
                {
                    wfMenuPrincipal MenuPrincipal = new wfMenuPrincipal();
                    MenuPrincipal.gsUsuario = txtUsuario.Text;
                    MenuPrincipal.Owner = this;
                    txtUsuario.Text = "";
                    txtContrasena.Text = "";
                    txtUsuario.Focus();
                    switch (DLL_Football_Manager.csFunciones.gsNivel)
                    {
                        case "DBA":
                            MenuPrincipal.tsmiAdministracion.Visible = true;
                            MenuPrincipal.tsmiCalendarios.Visible = true;
                            MenuPrincipal.tsmiCampeonato.Visible = true;
                            MenuPrincipal.tsmiCampeonatos.Visible = true;
                            MenuPrincipal.tsmiCanchas.Visible = true;
                            MenuPrincipal.tsmiControl.Visible = true;
                            MenuPrincipal.tsmiEmpleado.Visible = true;
                            MenuPrincipal.tsmiEmpleados.Visible = true;
                            MenuPrincipal.tsmiEquipo.Visible = true;
                            MenuPrincipal.tsmiEstadisticas.Visible = true;
                            MenuPrincipal.tsmiJugador.Visible = true;
                            MenuPrincipal.tsmiJugadores.Visible = true;
                            MenuPrincipal.tsmiNuevo.Visible = true;
                            MenuPrincipal.tsmiTipoEmpleados.Visible = true;
                            MenuPrincipal.tsmiUsuarios.Visible = true;
                            MenuPrincipal.tsmiVisorEventos.Visible = true;
                            MenuPrincipal.tssSeparador1.Visible = true;
                            break;
                        case "Gerencial":
                            MenuPrincipal.tsmiAdministracion.Visible = true;
                            MenuPrincipal.tsmiCalendarios.Visible = true;
                            MenuPrincipal.tsmiCampeonatos.Visible = true;
                            MenuPrincipal.tsmiControl.Visible = true;
                            MenuPrincipal.tsmiEmpleados.Visible = true;
                            MenuPrincipal.tsmiEstadisticas.Visible = true;
                            MenuPrincipal.tsmiJugadores.Visible = true;
                            MenuPrincipal.tsmiTipoEmpleados.Visible = true;
                            break;
                        case "Administrativo":
                            MenuPrincipal.tsmiAdministracion.Visible = true;
                            MenuPrincipal.tsmiCampeonato.Visible = true;
                            MenuPrincipal.tsmiEmpleado.Visible = true;
                            MenuPrincipal.tsmiEmpleados.Visible = true;
                            MenuPrincipal.tsmiEquipo.Visible = true;
                            MenuPrincipal.tsmiJugador.Visible = true;
                            MenuPrincipal.tsmiJugadores.Visible = true;
                            MenuPrincipal.tsmiNuevo.Visible = true;
                            MenuPrincipal.tssSeparador1.Visible = true;
                            break;
                        case "Operativo":
                            MenuPrincipal.tsmiCalendarios.Visible = true;
                            MenuPrincipal.tsmiCampeonatos.Visible = true;
                            break;
                        default: break;
                    }
                    MenuPrincipal.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña invalida", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnIniciarSesion_Click(this, e);
            }
            else
            {
                DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
            }
        }
    }
}
