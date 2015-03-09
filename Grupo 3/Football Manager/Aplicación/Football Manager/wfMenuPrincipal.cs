/* Autor: TODOS
 * Fecha: 02/08/2014 - Comentario: Interfaz de proyecto general
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
    public partial class wfMenuPrincipal : Form
    {
        public string gsUsuario;

        public wfMenuPrincipal()
        {
            InitializeComponent();
        }

        private void wfMenuPrincipal_Load(object sender, EventArgs e)
        {
            ssBarraEstado.Text = "Conectado - " + gsUsuario;
        }

        private void tsmiSalir_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void tsmiCampeonato_Click(object sender, EventArgs e)
        {
            Form Validacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfNuevoCampeonato").SingleOrDefault();
            if (Validacion == null)
            {
                wfNuevoCampeonato NuevoCampeonato = new wfNuevoCampeonato();
                NuevoCampeonato.MdiParent = this;
                NuevoCampeonato.Show();
            }
        }

        private void stmiCerrarSesion_Click(object sender, EventArgs e)
        {
            DLL_Football_Manager.csFunciones.InsertarControl("Logout usuario " + gsUsuario);
            this.Owner.Show();
            this.Close();
        }

        private void tsmiCalendarios_Click(object sender, EventArgs e)
        {
            Form Validacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfEstadoCampeonato").SingleOrDefault();
            if (Validacion == null)
            {
                wfEstadoCampeonato EstadoCampeonatos = new wfEstadoCampeonato();
                EstadoCampeonatos.MdiParent = this;
                EstadoCampeonatos.Show();
            } 
        }

        private void tsmiEstadisticas_Click(object sender, EventArgs e)
        {
            Form Validacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfEstadisticas").SingleOrDefault();
            if (Validacion == null)
            {
                wfEstadisticas Estadisticas = new wfEstadisticas();
                Estadisticas.MdiParent = this;
                Estadisticas.Show();
            }
        }

        private void visorDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Validacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfVisorEventos").SingleOrDefault();
            if (Validacion == null)
            {
                wfVisorEventos Eventos = new wfVisorEventos();
                Eventos.MdiParent = this;
                Eventos.Show();
            }
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Validacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfUsuarios").SingleOrDefault();
            if (Validacion == null)
            {
                wfUsuarios Usuarios = new wfUsuarios();
                Usuarios.MdiParent = this;
                Usuarios.Show();
            }
        }

        private void tsmiManualUsuario_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelpIndex(this, hpAyuda.HelpNamespace);
        }

        private void tsmiAcercaDe_Click(object sender, EventArgs e)
        {
            wfAcercaDe AcercaDe = new wfAcercaDe();
            AcercaDe.ShowDialog();
        }

        private void wfMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tsmiCerrarSesion.Pressed == false)
            {
                DLL_Football_Manager.csFunciones.InsertarControl("Logout usuario " + gsUsuario);
                Application.Exit();
            }
        }

        private void tsmiEmpleados_Click(object sender, EventArgs e)
        {
            Form Validacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfEmpleados").SingleOrDefault();
            if (Validacion == null)
            {
                wfEmpleados Empleados = new wfEmpleados();
                Empleados.MdiParent = this;
                Empleados.Show();
            }
        }

        private void tsmiJugadores_Click(object sender, EventArgs e)
        {
            Form Validacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfJugadores").SingleOrDefault();
            if (Validacion == null)
            {
                wfJugadores Jugadores = new wfJugadores();
                Jugadores.MdiParent = this;
                Jugadores.Show();
            }
        }

        private void tsmiEmpleado_Click(object sender, EventArgs e)
        {
            wfNuevoEmpleado NuevoEmpleado = new wfNuevoEmpleado();
            NuevoEmpleado.ShowDialog();
        }

        private void tsmiJugador_Click(object sender, EventArgs e)
        {
            wfNuevoJugador NuevoJugador = new wfNuevoJugador();
            NuevoJugador.ShowDialog();
        }

        private void tsmiTipoEmpleados_Click(object sender, EventArgs e)
        {
            Form Validacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfTipoEmpleado").SingleOrDefault();
            if (Validacion == null)
            {
                wfTipoEmpleado TipoEmpleados = new wfTipoEmpleado();
                TipoEmpleados.MdiParent = this;
                TipoEmpleados.Show();
            }
        }

        private void tsmiCanchas_Click(object sender, EventArgs e)
        {
            Form Validacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfCanchas").SingleOrDefault();
            if (Validacion == null)
            {
                wfCanchas Canchas = new wfCanchas();
                Canchas.MdiParent = this;
                Canchas.Show();
            }
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tsmiEquipo_Click(object sender, EventArgs e)
        {
            wfNuevoEquipo NuevoEquipo = new wfNuevoEquipo();
            NuevoEquipo.ShowDialog();
        }
    }
}
