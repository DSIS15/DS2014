/*Autor: Marlon Aldana
 * Fecha: 05/julio/2014
 * Comentario: Presenta reportes de tabla de posiciones y el control de goleadores
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
    public partial class wfEstadisticas : Form
    {
        public wfEstadisticas()
        {
            InitializeComponent();
        }

        private void wfEstadisticas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsEstadisticaEquipos' Puede moverla o quitarla según sea necesario.
            this.dsEstadisticaEquiposTA.Fill(this.dsDatosBD.dsEstadisticaEquipos);
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsDettCamp' Puede moverla o quitarla según sea necesario.
            this.dsListadoGoleadoresTA.Fill(this.dsDatosBD.dsListadoGoleadores);
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoJornadas' Puede moverla o quitarla según sea necesario.
            this.dsListadoJornadasTA.Fill(this.dsDatosBD.dsListadoJornadas);
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD1.dsListadoPartidos' Puede moverla o quitarla según sea necesario.
            this.dsListadoPartidosTA.Fill(this.dsDatosBD1.dsListadoPartidos);
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoCampeonatos' Puede moverla o quitarla según sea necesario.
            this.dsListadoCampeonatosTA.Fill(this.dsDatosBD.dsListadoCampeonatos);
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsDettCamp' Puede moverla o quitarla según sea necesario.
            this.rvPosiciones.RefreshReport();
            this.rvGoleadores.RefreshReport();
            cboJornada.SelectedIndex = -1;
            cbElegirCpn.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbElegirCpn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbElegirCpn.SelectedIndex != -1)
            {
                this.dsListadoJornadasTA.Adapter.SelectCommand.CommandText = "SELECT DISTINCT jornada_dcamp FROM tabt_dettcamp where cod_camp =" + cbElegirCpn.SelectedValue;
                this.dsListadoJornadasTA.Fill(this.dsDatosBD.dsListadoJornadas);
                cboJornada.SelectedIndex = -1;
            }
        }

        private void cboJornada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboJornada.SelectedIndex != -1)
            {
                this.dsEstadisticaEquiposTA.Adapter.SelectCommand.CommandText = "SELECT b.nom_eqp, a.pj_dcamp, a.pg_dcamp, a.pe_dcamp, a.pp_dcamp, a.gf_dcamp, a.gc_dcamp, a.gf_dcamp - a.gc_dcamp AS dg FROM tabt_dettcamp a, tabm_equipo b WHERE a.cod_eqp = b.cod_eqp AND a.cod_camp = " + cbElegirCpn.SelectedValue + " and a.jornada_dcamp=" + cboJornada.SelectedValue + " and (a.cod_eqp != 0) ORDER BY dg DESC";
                this.dsEstadisticaEquiposTA.Fill(this.dsDatosBD.dsEstadisticaEquipos);
                this.dsListadoGoleadoresTA.Adapter.SelectCommand.CommandText = "select e.nom_eqp, c.nom_jdr,c.apell_jdr, a.gl_dptd from tabt_dettpartido a, tabt_dettjugador b, tabm_jugador c, tabm_partido d, tabm_equipo e where a.cod_ptd=d.cod_ptd and a.cod_djdr=b.cod_djdr and b.cod_jdr=c.cod_jdr and b.cod_eqp=e.cod_eqp and b.cod_camp =" + cbElegirCpn.SelectedValue + " and d.jornada_ptd=" + cboJornada.SelectedValue;
                this.dsListadoGoleadoresTA.Fill(this.dsDatosBD.dsListadoGoleadores);
                this.dsListadoCampeonatosTA.Adapter.SelectCommand.CommandText = "SELECT cod_camp, nom_camp, fechini_camp, fechfin_camp, estado_camp FROM tabm_campeonato where cod_camp = " + cbElegirCpn.SelectedValue;
                this.dsListadoCampeonatosTA.Fill(this.dsDatosBD.dsListadoCampeonatos);
                this.dsListadoJornadasTA.Fill(this.dsDatosBD.dsListadoJornadas);
                this.rvPosiciones.RefreshReport();
                this.rvGoleadores.RefreshReport();
                rvPosiciones.Visible = true;
                rvGoleadores.Visible = true;
            }
        }

        private void rvPosiciones_Load(object sender, EventArgs e)
        {

        }
    }
}
