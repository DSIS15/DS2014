/*Autor: "Daniel Moreno"
 * Fecha:"05/julio/2014"
 * Comentario: "Este modulo genera las plantillas de un equipo"
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
    public partial class wfDetalleJugador : Form
    {
        public string gsFecha;
        public int giCodCamp;
        public string gsQuery;

        public wfDetalleJugador()
        {
            InitializeComponent();
        }

        private void wfPlantilla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoJugadoresDisponibles' Puede moverla o quitarla según sea necesario.
            this.dsListadoJugadoresDisponiblesTA.Fill(this.dsDatosBD.dsListadoJugadoresDisponibles);
            this.dsListadoJugadoresDisponiblesTA.Adapter.SelectCommand.CommandText = "select distinct a.cod_jdr,a.nom_jdr,a.apell_jdr,a.tel_jdr from tabm_jugador a, tabt_dettjugador b, tabm_campeonato c where a.cod_jdr=b.cod_jdr and c.cod_camp=b.cod_camp and c.fechfin_camp<'" + gsFecha + "' and a.activo_jdr=1 union select distinct a.cod_jdr,a.nom_jdr,a.apell_jdr,a.tel_jdr  from tabm_jugador a where a.cod_jdr not in (select cod_jdr from tabt_dettjugador);";
            this.dsListadoJugadoresDisponiblesTA.Fill(this.dsDatosBD.dsListadoJugadoresDisponibles);
            
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoEquiposDisponibles' Puede moverla o quitarla según sea necesario.
            this.dsListadoEquiposDisponiblesTA.Fill(this.dsDatosBD.dsListadoEquiposDisponibles);
            this.dsListadoEquiposDisponiblesTA.Adapter.SelectCommand.CommandText = "select distinct a.cod_eqp, a.nom_eqp, a.escudo_eqp from tabm_equipo a, tabt_dettjugador b, tabm_campeonato c where a.cod_eqp=b.cod_eqp and c.cod_camp=b.cod_camp and c.fechfin_camp < '" + gsFecha + "' and a.activo_eqp=1 union select distinct a.cod_eqp, a.nom_eqp, a.escudo_eqp from tabm_equipo a where a.cod_eqp not in (select cod_eqp from tabt_dettjugador)";
            this.dsListadoEquiposDisponiblesTA.Fill(this.dsDatosBD.dsListadoEquiposDisponibles);
        }

        private void btnNuevoJugador_Click(object sender, EventArgs e)
        {
            wfNuevoJugador NuevoJugador = new wfNuevoJugador();
            NuevoJugador.ShowDialog();
            this.dsListadoJugadoresDisponiblesTA.Fill(this.dsDatosBD.dsListadoJugadoresDisponibles);
        }

        private void btnAñadirEquipo_Click(object sender, EventArgs e)
        {
            int iResp;
            int iCodigo;
            int sObtenerRegistro;
            for (int iCount = 0; iCount < dgvSeleccionados.RowCount; iCount++)
            {
                iCodigo = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_djdr", "tabt_dettjugador");
                sObtenerRegistro = Convert.ToInt32(dgvSeleccionados.Rows[iCount].Cells[0].Value.ToString());
                gsQuery = "Insert into tabt_dettjugador values (" + iCodigo + "," + giCodCamp + "," + Convert.ToInt32(cboSeleccionarEquipo.SelectedValue.ToString()) + "," + sObtenerRegistro + ")";
                iResp = DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabt_dettjugador");
            }
            MessageBox.Show("Registros guardados correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSeleccionados.Rows.Clear();
            this.dsListadoJugadoresDisponiblesTA.Fill(this.dsDatosBD.dsListadoJugadoresDisponibles);
            this.dsListadoEquiposDisponiblesTA.Fill(this.dsDatosBD.dsListadoEquiposDisponibles);
        }

        private void btnNuevoEquipo_Click(object sender, EventArgs e)
        {
            wfNuevoEquipo NuevoEquipo = new wfNuevoEquipo();
            NuevoEquipo.ShowDialog();
            this.dsListadoEquiposDisponiblesTA.Fill(this.dsDatosBD.dsListadoEquiposDisponibles);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (DLL_Football_Manager.csFunciones.GenerarCombinaciones(giCodCamp, gsFecha) == 1)
            {
                MessageBox.Show("Combinaciones generadas exitosamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wfEstadoCampeonato EstadoCampeonato = new wfEstadoCampeonato();
                EstadoCampeonato.MdiParent = this.ParentForm;
                EstadoCampeonato.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al generar combinaciones", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String sCodigo,sNombre,sApellido,sTel,sComparar;
            int iBandera = 0;
            DataGridViewRow dgvFila = this.dgvDisponibles.CurrentRow;
            if(dgvFila!=null)
            {
                sCodigo = dgvFila.Cells["codjdrDataGridViewTextBoxColumn"].Value.ToString();
                sNombre = dgvFila.Cells["nomjdrDataGridViewTextBoxColumn"].Value.ToString();
                sApellido = dgvFila.Cells["apelljdrDataGridViewTextBoxColumn"].Value.ToString();
                sTel = dgvFila.Cells["teljdrDataGridViewTextBoxColumn"].Value.ToString();
                for (int i = 0; i < dgvSeleccionados.RowCount; i++)
                {
                    sComparar = dgvSeleccionados.Rows[i].Cells[0].Value.ToString();
                    if(sCodigo.CompareTo(sComparar)==0)
                    {
                        iBandera = 1;
                    }
                }
                if (iBandera != 1)
                {
                    this.dgvSeleccionados.Rows.Add(sCodigo, sNombre, sApellido, sTel);
                }
                else
                {
                    MessageBox.Show("Este jugador ya esta agregado", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvFila = this.dgvSeleccionados.CurrentRow;
            if (dgvFila != null)
            {
                this.dgvSeleccionados.Rows.Remove(dgvFila);
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buscar();
                
            }
            else
            {
                DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ,. ");
            }
                    
        }

        private void buscar()
        {
        this.dsListadoJugadoresDisponiblesTA.Fill(this.dsDatosBD.dsListadoJugadoresDisponibles);
        this.dsListadoJugadoresDisponiblesTA.Adapter.SelectCommand.CommandText = "select distinct a.cod_jdr,a.nom_jdr,a.apell_jdr,a.tel_jdr from tabm_jugador a, tabt_dettjugador b, tabm_campeonato c where a.cod_jdr=b.cod_jdr and c.cod_camp=b.cod_camp and c.fechfin_camp<'" + gsFecha + "' and a.activo_jdr=1 and (a.nom_jdr Like '" + txtBuscar.Text + "%' or a.apell_jdr like '" + txtBuscar.Text + "%' or a.tel_jdr like '" + txtBuscar.Text + "%' ) union select distinct a.cod_jdr,a.nom_jdr,a.apell_jdr,a.tel_jdr  from tabm_jugador a where a.cod_jdr not in (select cod_jdr from tabt_dettjugador) and (a.nom_jdr Like '" + txtBuscar.Text + "%' or a.apell_jdr like '" + txtBuscar.Text + "%' or a.tel_jdr like '" + txtBuscar.Text + "%');";
        this.dsListadoJugadoresDisponiblesTA.Fill(this.dsDatosBD.dsListadoJugadoresDisponibles);   
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
