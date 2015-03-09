/* Autor: Andrea Pérez, Marlon Aldana
 * Fecha: 31/10/2014 - 02/11/2014
 * Comentario: Capa de presentación modulo Inventario Hotel San Carlos
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

namespace Inventario
{
    public partial class wfSucursal : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        private string sCod_suc = string.Empty;
        private string sCodigo = string.Empty;

        public string SCod_suc
        {
            get { return sCod_suc; }
            set { sCod_suc = value; }
        }

        public wfSucursal()
        {
            InitializeComponent();
        }

        private void wfSucursal_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_suc);
            alDatosEnviados.Add(txtNom_suc);
            alDatosEnviados.Add(txtUbic_suc);
            alDatosEnviados.Add(txtEstadoSucursal);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
        }

        private void cboEstadoSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_suc.SelectedIndex)
            {
                case 0: txtEstadoSucursal.Text = "1"; break;
                case 1: txtEstadoSucursal.Text = "0"; break;
                default: txtEstadoSucursal.Text = string.Empty; break;
            }
        }

        private void txtEstadoSucursal_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoSucursal.Text)
            {
                case "1": cboEstado_suc.SelectedIndex = 0; break;
                case "0": cboEstado_suc.SelectedIndex = 1; break;
                default: cboEstado_suc.SelectedIndex = -1; break;
            }
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtNom_suc.Focus();
            cboEstado_suc.SelectedIndex = 0;
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_suc.Text = sCodigo;
            txtNom_suc.Focus();
            cboEstado_suc.SelectedIndex = 0;
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void txtCodSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "1234567890");
        }

        private void txtNombreSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtUbiSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtCodSucursal_TextChanged(object sender, EventArgs e)
        {
            SCod_suc = txtCod_suc.Text;
        }

        private void txtCod_suc_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_suc.Enabled = false;
        }

        private void txtEstadoSucursal_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_suc.Enabled = txtEstadoSucursal.Enabled;
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_suc.Text;
        }
    }
}
