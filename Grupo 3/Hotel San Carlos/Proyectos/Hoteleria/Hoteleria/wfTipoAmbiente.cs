/* Autor: Anthony Molineros,Jennifer López
 * Fecha: 17/10/2014 - 19/10/2014 
 * Comentario: Capa de presentación modulo Hoteleria Hotel San Carlos
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

namespace Hoteleria
{
    public partial class wfTipoAmbiente : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        private string sCod_tamb = string.Empty;

        public string SCod_tamb
        {
            get { return sCod_tamb; }
            set { sCod_tamb = value; }
        }

        public wfTipoAmbiente()
        {
            InitializeComponent();
        }

        private void wfTipoAmbiente_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_tamb);
            alDatosEnviados.Add(txtAmbiente_tamb);
            alDatosEnviados.Add(txtEstado_tamb);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
        }

        private void txtEstado_tamb_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_tamb.Enabled = txtEstado_tamb.Enabled;
        }

        private void txtCod_tamb_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_tamb.Enabled = false;
        }

        private void txtEstado_tamb_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_tamb.Text)
            {
                case "1": cboEstado_tamb.SelectedIndex = 0; break;
                case "0": cboEstado_tamb.SelectedIndex = 1; break;
                default: cboEstado_tamb.SelectedIndex = -1; break;
            }
        }

        private void cboEstado_tamb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_tamb.SelectedIndex)
            {
                case 0: txtEstado_tamb.Text = "1"; break;
                case 1: txtEstado_tamb.Text = "0"; break;
                default: txtEstado_tamb.Text = string.Empty; break;
            }
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            cboEstado_tamb.SelectedIndex = 0;
            txtAmbiente_tamb.Focus();
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            cboEstado_tamb.SelectedIndex = 0;
            txtAmbiente_tamb.Focus();
        }

        private void txtAmbiente_tamb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtCod_tamb_TextChanged(object sender, EventArgs e)
        {
            SCod_tamb = txtCod_tamb.Text;
        }
    }
}
