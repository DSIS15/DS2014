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
    public partial class wfCatalogoProducto : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        private string sCod_catprod = string.Empty;
        private string sCodigo = string.Empty;

        public string SCod_catprod
        {
            get { return sCod_catprod; }
            set { sCod_catprod = value; }
        }

        public wfCatalogoProducto()
        {
            InitializeComponent();
        }

        private void txtEstado_catprod_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_catprod.Text)
            {
                case "1": cboEstado_catprod.SelectedIndex = 0; break;
                case "0": cboEstado_catprod.SelectedIndex = 1; break;
                default: cboEstado_catprod.SelectedIndex = -1; break;
            }
        }


        private void txtEstado_catprod_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_catprod.Enabled = txtEstado_catprod.Enabled;
        }

        private void txtCod_catprod_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_catprod.Enabled = false;
        }

        private void wfCatalogoProducto_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_catprod);
            alDatosEnviados.Add(txtTipo_catprod);
            alDatosEnviados.Add(txtNom_catprod);
            alDatosEnviados.Add(txtPrecioc_catprod);
            alDatosEnviados.Add(txtPreciov_catprod);
            alDatosEnviados.Add(txtCmax_catprod);
            alDatosEnviados.Add(txtCmin_catprod);
            alDatosEnviados.Add(txtCtotal_catprod);
            alDatosEnviados.Add(txtEstado_catprod);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            if (!Negocio.bValidarTextBoxes(alDatosEnviados)) 
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_catprod.Text = sCodigo;
            txtTipo_catprod.Focus();
            cboTipo_catprod.SelectedIndex = 0;
            cboEstado_catprod.SelectedIndex = 0;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtTipo_catprod.Focus();
            cboTipo_catprod.SelectedIndex = 0;
            cboEstado_catprod.SelectedIndex = 0;
        }

        private void txtNom_catprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtPrecioc_catprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtPreciov_catprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtCmax_catprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "1234567890.");
        }

        private void txtCmin_catprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "1234567890.");
        }

        private void txtCtotal_catprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "1234567890.");
        }

        private void cboEstado_catprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_catprod.SelectedIndex)
            {
                case 1: txtEstado_catprod.Text = "0"; break;
                case 0: txtEstado_catprod.Text = "1"; break;
                default: txtEstado_catprod.Text = string.Empty; break;
            }
        }

        private void txtCod_catprod_TextChanged(object sender, EventArgs e)
        {
            SCod_catprod = txtCod_catprod.Text;
        }

        private void txtTipo_catprod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtTipo_catprod_TextChanged(object sender, EventArgs e)
        {
            switch (txtTipo_catprod.Text)
            {
                case "Mobiliario": cboTipo_catprod.SelectedIndex = 0; break;
                case "Producto": cboTipo_catprod.SelectedIndex = 1; break;
                default: cboTipo_catprod.SelectedIndex = -1; break;
            }
        }

        private void cboTipo_catprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipo_catprod.SelectedIndex)
            {
                case 0: txtTipo_catprod.Text = "Mobiliario"; break;
                case 1: txtTipo_catprod.Text = "Producto"; break;
                default: txtTipo_catprod.Text = string.Empty; break;
            }
        }

        private void txtTipo_catprod_EnabledChanged(object sender, EventArgs e)
        {
            cboTipo_catprod.Enabled = txtTipo_catprod.Enabled;
        }

        private void txtPreciov_catprod_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_catprod.Text;
        }

        private void navegador1_btnImprimir_AfterClick(object sender, EventArgs e)
        {
            Reporteador.wfReportes Reporteador = new Reporteador.wfReportes();
            Reporteador.SNombreReporte = "Catálogo de Productos";
            Reporteador.ShowDialog();
        }

    }
}
