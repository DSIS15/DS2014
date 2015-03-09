/* Autor: Anthony Molineros
 * Fecha: 02/08/2014 - Comentario: Insercion de un campeonato nuevo.
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
    public partial class wfNuevoCampeonato : Form
    {
        string gsQuery;
        int giCodigo;

        public wfNuevoCampeonato()
        {
            InitializeComponent();
        }

        private void wfNuevoCampeonato_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNomCpn.Text != "")
            {
                giCodigo = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_camp", "tabm_campeonato");
                gsQuery = "insert into tabm_campeonato values (" + giCodigo + ",'" + txtNomCpn.Text + "','" + dtpFechIni.Text + " 12:00:00','"+ dtpFechIni.Text+" 12:00:00',1)";
                if (DLL_Football_Manager.csFunciones.Insertar(gsQuery,"tabm_campeonato") == 1)
                {
                    wfDetalleJugador SeleccionJugadores = new wfDetalleJugador();
                    SeleccionJugadores.MdiParent = this.ParentForm;
                    SeleccionJugadores.gsFecha = dtpFechIni.Text + " 00:00:00";
                    SeleccionJugadores.giCodCamp = giCodigo;
                    SeleccionJugadores.Text = "Equipos Campeonato - " + txtNomCpn.Text;
                    SeleccionJugadores.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomCpn.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomCpn.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomCpn_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNomCpn.Text = "";
            dtpFechIni.Value = System.DateTime.Now;
        }
    }
}
