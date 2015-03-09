/* Autor: Daniel Moreno,Kevin Gutierrez
 * Fecha: 17/10/2014 - 19/10/2014 
 * Comentario: Capa de presentación modulo Facturación Hotel San Carlos
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class wfSerie : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        private string sCod_srie= string.Empty;
        private string sCodigo = string.Empty;

        public string SCod_srie
        {
            get { return sCod_srie; }
            set { sCod_srie = value; }
        }

        public wfSerie()
        {
            InitializeComponent();
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            cboEstado_srie.SelectedIndex = 0;
            txtSerie_srie.Focus();
        }

        private void wfSerie_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_srie);
            alDatosEnviados.Add(txtSerie_srie);
            alDatosEnviados.Add(txtEstado_srie);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
        }

        private void txtEstado_srie_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_srie.Text)
            {
                case "1": cboEstado_srie.SelectedIndex = 0; break;
                case "0": cboEstado_srie.SelectedIndex = 1; break;
                default: cboEstado_srie.SelectedIndex = -1; break;
            }
        }

        private void cboEstado_srie_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_srie.SelectedIndex)
            {
                case 0: txtEstado_srie.Text = "1"; break;
                case 1: txtEstado_srie.Text = "0"; break;
                default: txtEstado_srie.Text = string.Empty; break;
            }
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_srie.Text = sCodigo;
            cboEstado_srie.SelectedIndex = 0;
            txtSerie_srie.Focus();
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void txtCod_srie_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_srie.Enabled = false;
        }

        private void txtSerie_srie_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNOPQRSTUVWXYZ-abcdefghijklmnopqrstuvwxyz0123456789 ");
        }

        private void txtEstado_srie_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_srie.Enabled = txtEstado_srie.Enabled;
        }

        private void txtCod_srie_TextChanged(object sender, EventArgs e)
        {
            SCod_srie = txtCod_srie.Text;
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_srie.Text;
        }
    }
}
