/* Autor: Andrea Perez
 * Fecha: 02/08/2014 - Comentario: Listado de jugadores activos
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
    public partial class wfJugadores : Form
    {
        string gsQuery;
        int giCodigo,giIndex;

        public wfJugadores()
        {
            InitializeComponent();
        }

        private void wfJugadores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoJugadores' Puede moverla o quitarla según sea necesario.
            this.dsListadoJugadoresTA.Fill(this.dsDatosBD.dsListadoJugadores);
        }

        private void ObtenerRegSeleccionado()
        {
            foreach (DataGridViewRow row in dgvJugadores.Rows)
            {
                if (row.Selected == true)
                {
                    giIndex = row.Index;
                    giCodigo = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnRefrescar_Click(this, e);
            }
            else
            {
                DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ,. ");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Football Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ObtenerRegSeleccionado();
                gsQuery = "update tabm_jugador set activo_jdr=0 where cod_jdr=" + giCodigo;
                if (DLL_Football_Manager.csFunciones.Eliminar(gsQuery, "tabm_jugador") == 1)
                {
                    this.dsListadoJugadoresTA.Fill(this.dsDatosBD.dsListadoJugadores);
                    MessageBox.Show("Registro eliminado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.dgvJugadores.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObtenerRegSeleccionado();
            wfNuevoJugador NuevoJugador = new wfNuevoJugador();
            NuevoJugador.giCodigo = Convert.ToInt32(dsDatosBD.dsListadoJugadores.Rows[giIndex]["cod_jdr"].ToString());
            NuevoJugador.txtNombre.Text = dsDatosBD.dsListadoJugadores.Rows[giIndex]["nom_jdr"].ToString();
            NuevoJugador.txtApellido.Text = dsDatosBD.dsListadoJugadores.Rows[giIndex]["apell_jdr"].ToString();
            NuevoJugador.txtDireccion.Text = dsDatosBD.dsListadoJugadores.Rows[giIndex]["dire_jdr"].ToString();
            NuevoJugador.txtTelefono.Text = dsDatosBD.dsListadoJugadores.Rows[giIndex]["tel_jdr"].ToString();
            NuevoJugador.gsPath = dsDatosBD.dsListadoJugadores.Rows[giIndex]["foto_jdr"].ToString();
            NuevoJugador.Text = "Modificar Jugador";
            NuevoJugador.ShowDialog();
            this.dsListadoJugadoresTA.Fill(this.dsDatosBD.dsListadoJugadores);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            wfNuevoJugador NuevoJugador = new wfNuevoJugador();
            NuevoJugador.StartPosition = FormStartPosition.CenterParent;
            NuevoJugador.ShowDialog();
            this.dsListadoJugadoresTA.Fill(this.dsDatosBD.dsListadoJugadores);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.dsListadoJugadoresTA.Adapter.SelectCommand.CommandText = "select cod_jdr, nom_jdr, apell_jdr, dire_jdr, tel_jdr, foto_jdr from tabm_jugador where activo_jdr = 1 and (nom_jdr like '" + txtBuscar.Text + "%' or apell_jdr like '" + txtBuscar.Text + "%' or dire_jdr like '" + txtBuscar.Text + "%' or tel_jdr like '" + txtBuscar.Text + "%')";
            this.dsListadoJugadoresTA.Fill(this.dsDatosBD.dsListadoJugadores);
        }
    }
}
