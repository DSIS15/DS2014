/* Autor: Kevin Gutierrez
* Fecha: 12/08/2014
* Comentario: Función btnGuardar(), Envia a guardar los datos a la tabla partido 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;

namespace Football_Manager
{
    public partial class wfFichaPartido : Form
    {
        public int giLocal, giVisitante, giCamp, giPartido, giJugado, giJornada;
        public string gsQuery, gsQuery2;

        public wfFichaPartido()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int iResp, iTA = 0, iTR = 0, iGol = 0, iTotL = 0, iTotV = 0;
            for (int iCount = 0; iCount < dgvEquipoLocal.RowCount; iCount++)
            {
                int iCodigo = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_dptd", "tabt_dettpartido");
                if (dgvEquipoLocal.Rows[iCount].Cells[3].Value != null)
                {
                    iTA = Convert.ToInt32(dgvEquipoLocal.Rows[iCount].Cells[3].Value.ToString());
                }
                else
                {
                    iTA = 0;
                }
                if (dgvEquipoLocal.Rows[iCount].Cells[4].Value != null)
                {
                    iTR = Convert.ToInt32(dgvEquipoLocal.Rows[iCount].Cells[4].Value.ToString());
                }
                else
                {
                    iTR = 0;
                }
                if (dgvEquipoLocal.Rows[iCount].Cells[5].Value != null)
                {
                    iGol = Convert.ToInt32(dgvEquipoLocal.Rows[iCount].Cells[5].Value.ToString());
                    iTotL += iGol;
                }
                else
                {
                    iGol = 0;
                }
                gsQuery = "Insert into tabt_dettpartido values(" + iCodigo + "," + giPartido + "," + giLocal + "," + iTA + "," + iTR + "," + iGol + ")";
                iResp = DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabt_dettpartido");
            }
            for (int iCountV = 0; iCountV < dgvEquipoVisitante.RowCount; iCountV++)
            {
                int iCodigo = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_dptd", "tabt_dettpartido");
                if (dgvEquipoVisitante.Rows[iCountV].Cells[3].Value != null)
                {
                    iTA = Convert.ToInt32(dgvEquipoVisitante.Rows[iCountV].Cells[3].Value.ToString());
                }
                else
                {
                    iTA = 0;
                }
                if (dgvEquipoVisitante.Rows[iCountV].Cells[4].Value != null)
                {
                    iTR = Convert.ToInt32(dgvEquipoVisitante.Rows[iCountV].Cells[4].Value.ToString());
                }
                else
                {
                    iTR = 0;
                }
                if (dgvEquipoVisitante.Rows[iCountV].Cells[5].Value != null)
                {
                    iGol = Convert.ToInt32(dgvEquipoVisitante.Rows[iCountV].Cells[5].Value.ToString());
                    iTotV += iGol;
                }
                else
                {
                    iGol = 0;
                }
                gsQuery2 = "Insert into tabt_dettpartido values(" + iCodigo + "," + giPartido + "," + giVisitante + "," + iTA + "," + iTR + "," + iGol + ")";
                iResp = DLL_Football_Manager.csFunciones.Insertar(gsQuery2, "tabt_dettpartido");
            }
            gsQuery = "Update tabm_partido set mlocal_ptd = " + iTotL + ", mVisitante_ptd = " + iTotV + ", jugado_ptd =1 where cod_ptd = " + giPartido;
            iResp = DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabm_partido");
            DLL_Football_Manager.csFunciones.ActualizarEstadisticas(giCamp, giJornada, giLocal, giVisitante, iTotL, iTotV);
            MessageBox.Show("Registro guardado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (iTotL > iTotV)
            {
                MessageBox.Show("El equipo ganador es " + txtEquipoLocal.Text , "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (iTotL < iTotV)
                {
                    MessageBox.Show("El equipo ganador es " + txtEquipoVisitante.Text, "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El partido terminó empatado", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wfPartido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsPartidoVisitante' Puede moverla o quitarla según sea necesario.
            this.dsPartidoVisitanteTA.Fill(this.dsDatosBD.dsPartidoVisitante);
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsPartidoLocal' Puede moverla o quitarla según sea necesario.
            this.dsPartidoLocalTA.Fill(this.dsDatosBD.dsPartidoLocal);
            this.dsPartidoLocalTA.Adapter.SelectCommand.CommandText = "SELECT a.cod_jdr, b.cod_djdr, a.nom_jdr, a.apell_jdr FROM tabm_jugador a, tabt_dettjugador b WHERE a.cod_jdr = b.cod_jdr and b.cod_camp =" + giCamp + " and b.cod_eqp = " + giLocal;
            this.dsPartidoLocalTA.Fill(this.dsDatosBD.dsPartidoLocal);
            this.dsPartidoVisitanteTA.Adapter.SelectCommand.CommandText = "SELECT a.cod_jdr, b.cod_djdr, a.nom_jdr, a.apell_jdr FROM tabm_jugador a, tabt_dettjugador b WHERE a.cod_jdr = b.cod_jdr and b.cod_camp =" + giCamp + " and b.cod_eqp = " + giVisitante;
            this.dsPartidoVisitanteTA.Fill(this.dsDatosBD.dsPartidoVisitante);    
            if(giJugado == 1)
            {
                dgvEquipoLocal.Enabled = false;
                dgvEquipoVisitante.Enabled = false;
            }
        }
                                           

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEquipoLocal_Click(object sender, EventArgs e)
        {

        }

        private void txtEquipoLocal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipoVisitante_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEquipoLocal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string iTA { get; set; }

        public string iTR { get; set; }
    }
}
