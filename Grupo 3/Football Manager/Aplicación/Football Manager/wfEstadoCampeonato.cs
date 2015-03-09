/*Autor: Anthony Molineros y Marlon Aldana
 * Fecha: 05/julio/2014
 * Comentario: Muestra el listado de los partidos a jugar en un campeonato determinado.
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
    public partial class wfEstadoCampeonato : Form
    {
        int giPartido, giLocal, giVisitante, giJugado, giJornada;
        string gsLocal, gsVisitante;
        
        public wfEstadoCampeonato()
        {
            InitializeComponent();
        }

        private void wfEstadoCampeonato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoPartidos' Puede moverla o quitarla según sea necesario.
            this.dsListadoPartidosTA.Fill(this.dsDatosBD.dsListadoPartidos);
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoCampeonatos' Puede moverla o quitarla según sea necesario.
            this.dsListadoCampeonatosTA.Fill(this.dsDatosBD.dsListadoCampeonatos);
            this.dsListadoPartidosTA.Adapter.SelectCommand.CommandText = "SELECT a.cod_ptd, d.cod_eqp, e.cod_eqp AS Expr2, b.nom_emp, c.nom_cha, a.jornada_ptd, a.fechhora_ptd, d.nom_eqp, a.mlocal_ptd, a.mvisitante_ptd, e.nom_eqp AS Expr1, a.jugado_ptd FROM tabm_partido a, tabm_empleado b, tabm_cancha c, tabm_equipo d, tabm_equipo e WHERE a.cod_emp = b.cod_emp AND a.cod_cha = c.cod_cha AND a.elocal_ptd = d.cod_eqp AND a.evisitante_ptd = e.cod_eqp AND a.cod_camp = 0";
            this.dsListadoPartidosTA.Fill(this.dsDatosBD.dsListadoPartidos);
            cboCamponato.SelectedIndex = -1;
        }

        private void ObtenerRegSeleccionado()
        {
            foreach (DataGridViewRow row in dgvPartidos.Rows)
            {
                if (row.Selected == true)
                {
                    giPartido = Convert.ToInt32(row.Cells[0].Value.ToString());
                    giLocal = Convert.ToInt32(row.Cells[2].Value.ToString());
                    giVisitante = Convert.ToInt32(row.Cells[3].Value.ToString());
                    gsLocal = row.Cells[7].Value.ToString();
                    gsVisitante = row.Cells[11].Value.ToString();
                    giJugado = Convert.ToInt32(row.Cells[12].Value.ToString());
                    giJornada = Convert.ToInt32(row.Cells[5].Value.ToString());
                }
            }
        }

        private void cboCamponato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCamponato.SelectedIndex != -1)
            {
                btnPartido.Enabled = true;
                txtFechIni.Text = dsDatosBD.dsListadoCampeonatos.Rows[cboCamponato.SelectedIndex]["fechini_camp"].ToString();
                txtFechFin.Text = dsDatosBD.dsListadoCampeonatos.Rows[cboCamponato.SelectedIndex]["fechfin_camp"].ToString();
                if (Convert.ToInt32(dsDatosBD.dsListadoCampeonatos.Rows[cboCamponato.SelectedIndex]["estado_camp"].ToString()) == 0)
                {
                    txtEstado.Text = "Finalizado";
                }
                else
                {
                    txtEstado.Text = "En curso";
                }
                this.dsListadoPartidosTA.Adapter.SelectCommand.CommandText = "SELECT a.cod_ptd, d.cod_eqp, e.cod_eqp AS Expr2, CONCAT(b.nom_emp,' ',b.apell_emp)  AS Expr3, c.nom_cha, a.jornada_ptd, a.fechhora_ptd, d.nom_eqp, a.mlocal_ptd, a.mvisitante_ptd, e.nom_eqp AS Expr1, a.jugado_ptd FROM            tabm_partido a, tabm_empleado b, tabm_cancha c, tabm_equipo d, tabm_equipo e WHERE a.cod_emp = b.cod_emp AND a.cod_cha = c.cod_cha AND a.elocal_ptd = d.cod_eqp AND a.evisitante_ptd = e.cod_eqp AND a.cod_camp =" + cboCamponato.SelectedValue + " ORDER BY a.jornada_ptd ASC";
                this.dsListadoPartidosTA.Fill(this.dsDatosBD.dsListadoPartidos);
            }
            else
            {
                btnPartido.Enabled = false;                
            }
        }

        private void btnPartido_Click(object sender, EventArgs e)
        {
            string sQuery;
            int iResp;
            ObtenerRegSeleccionado();
            int iCodigo = Convert.ToInt32(cboCamponato.SelectedValue.ToString());;
            if ((giLocal != 0) && (giVisitante != 0))
            {
                wfFichaPartido FichaPartido = new wfFichaPartido();
                FichaPartido.giCamp = iCodigo;
                FichaPartido.giPartido = giPartido;
                FichaPartido.giLocal = giLocal;
                FichaPartido.giVisitante = giVisitante;
                FichaPartido.giJugado = giJugado;
                FichaPartido.txtEquipoLocal.Text = gsLocal;
                FichaPartido.txtEquipoVisitante.Text = gsVisitante;
                FichaPartido.giJornada = giJornada;
                FichaPartido.ShowDialog();
                cboCamponato.SelectedIndex = -1;
                cboCamponato.SelectedValue = iCodigo;
            }
            else
            {
                DLL_Football_Manager.csFunciones.ActualizarEstadisticas(iCodigo, 0, giLocal, giVisitante, 0, 0);
                sQuery = "Update tabm_partido set jugado_ptd =1 where cod_ptd = " + giPartido;
                iResp = DLL_Football_Manager.csFunciones.Insertar(sQuery, "tabm_partido");
                MessageBox.Show("Jornada de descanso", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPartidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerRegSeleccionado();
            if (giJugado == 1)
            {
                btnPartido.Enabled = false;
            }
            else
            {
                btnPartido.Enabled = true;
            }
        }
    }
}
