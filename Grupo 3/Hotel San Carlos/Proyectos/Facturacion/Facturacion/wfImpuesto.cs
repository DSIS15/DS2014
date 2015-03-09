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
    public partial class wfImpuesto : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        private string sCod_imp = string.Empty;
        private string sCodigo = string.Empty;

        public string SCod_imp
        {
            get { return sCod_imp; }
            set { sCod_imp = value; }
        }

        public wfImpuesto()
        {
            InitializeComponent();
        }

        private void cboEstado_imp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_imp.SelectedIndex)
            {
                case 0: txtEstado_imp.Text = "1"; break;
                case 1: txtEstado_imp.Text = "0"; break;
                default: txtEstado_imp.Text = string.Empty; break;
            }
        }

        private void txtEstado_imp_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_imp.Text)
            {
                case "1": cboEstado_imp.SelectedIndex = 0; break;
                case "0": cboEstado_imp.SelectedIndex = 1; break;
                default: cboEstado_imp.SelectedIndex = -1; break;
            }
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void wfImpuesto_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_imp);
            alDatosEnviados.Add(txtNom_imp);
            alDatosEnviados.Add(txtValor_imp);
            alDatosEnviados.Add(txtEstado_imp);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
        }

        private void txtCod_imp_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_imp.Enabled = false;
        }

        private void txtNom_imp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789 ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,");   
        }

        private void txtValor_imp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtEstado_imp_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_imp.Enabled = txtEstado_imp.Enabled;
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_imp.Text = sCodigo;
            cboEstado_imp.SelectedIndex = 0;
            txtNom_imp.Focus();
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            cboEstado_imp.SelectedIndex = 0;
            txtNom_imp.Focus();
        }

        private void txtCod_imp_TextChanged(object sender, EventArgs e)
        {
            SCod_imp = txtCod_imp.Text;
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_imp.Text;
        }       
    }
}
