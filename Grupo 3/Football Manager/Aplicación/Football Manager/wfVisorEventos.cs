/* Autor: Anthony Molineros
 * Se registran todos los movimientos que se realicen en el software de footballmanager
 * Fecha: 12/08/2014 - Comentario: Diseño y Programación de wfVisorEventos
 * Fecha: 03/08/2014 - Comentario: Configuración de dgvVisorEventos y preparación para interacción con BD
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
    public partial class wfVisorEventos : Form
    {
        public wfVisorEventos()
        {
            InitializeComponent();
        }

        private void wfVisorEventos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoEventos' Puede moverla o quitarla según sea necesario.
            this.dsListadoEventosTA.Fill(this.dsDatosBD.dsListadoEventos);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnRefrescar_Click(this, e);
            }
            else
            {
                DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
            }            
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.dsListadoEventosTA.Adapter.SelectCommand.CommandText = "select a.cod_ctrl,b.usuario_usr,a.fechhora_ctrl,a.accion_ctrl,a.ip_ctrl,a.maquina_ctrl from tabm_control a, tabm_usuario b where a.cod_usr=b.cod_usr and (b.usuario_usr like '" + txtFiltro.Text + "%' or a.fechhora_ctrl like '" + txtFiltro.Text + "%' or a.accion_ctrl like '" + txtFiltro.Text + "%' or a.ip_ctrl like '" + txtFiltro.Text + "%' or a.maquina_ctrl like '" + txtFiltro.Text + "%') order by a.fechhora_ctrl desc";
            this.dsListadoEventosTA.Fill(this.dsDatosBD.dsListadoEventos);
        }
    }
}
