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
    public partial class wfEmpresa : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        private string sCod_empsa = string.Empty;
        private string sCodigo = string.Empty;

        public string SCod_empsa
        {
            get { return sCod_empsa; }
            set { sCod_empsa = value; }
        }

        public wfEmpresa()
        {
            InitializeComponent();
        }

        private void wfEmpresa_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_empresa);
            alDatosEnviados.Add(txtCod_srie);
            alDatosEnviados.Add(txtRazsocial_empsa);
            alDatosEnviados.Add(txtNomcomercial_empsa);
            alDatosEnviados.Add(txtDire_empsa);
            alDatosEnviados.Add(txtNit_empsa);
            alDatosEnviados.Add(txtEstado_empsa);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
        }

        private void cboEstado_empsa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_empsa.SelectedIndex)
            {
                case 0: txtEstado_empsa.Text = "1"; break;
                case 1: txtEstado_empsa.Text = "0"; break;
                default: txtEstado_empsa.Text = string.Empty; break;
            }
        }

        private void txtEstado_empsa_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_empsa.Text)
            {
                case "1": cboEstado_empsa.SelectedIndex = 0; break;
                case "0": cboEstado_empsa.SelectedIndex = 1; break;
                default: cboEstado_empsa.SelectedIndex = -1; break;
            }
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }
      
        private void txtCod_empresa_TextChanged(object sender, EventArgs e)
        {
            sCod_empsa = txtCod_empresa.Text;
        }

        private void txtCod_srie_Enter(object sender, EventArgs e)
        {
            wfSerie Serie = new wfSerie();
            Serie.ShowDialog();
            txtCod_srie.Text = Serie.SCod_srie;
        }

        private void txtCod_srie_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtRazsocial_empsa_KeyPress(object sender, KeyPressEventArgs e)
        {
          Negocio.vValidarTexto(e, "0123456789-ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz");            
        }

        private void txtNomcomercial_empsa_KeyPress(object sender, KeyPressEventArgs e)
        { 
           Negocio.vValidarTexto(e, "0123456789-ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz^ ");
        }

        private void txtDire_empsa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789-ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz^ ");
        }

        private void txtNit_empsa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            cboEstado_empsa.SelectedIndex = 0;
            txtCod_empresa.Enabled = false;
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_empresa.Text = sCodigo;
            cboEstado_empsa.SelectedIndex = 0;
            txtCod_empresa.Enabled = false;
        }

        private void txtEstado_empsa_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_empsa.Enabled = txtEstado_empsa.Enabled;
        }

        private void txtCod_empresa_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_empresa.Enabled = false;
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_empresa.Text;
        }
    }
}
