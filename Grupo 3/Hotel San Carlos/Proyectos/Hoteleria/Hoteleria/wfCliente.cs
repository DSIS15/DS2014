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
    public partial class wfCliente : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        private string sCod_cte = string.Empty;
        private string sCodigo = string.Empty;

        public string SCod_cte
        {
            get { return sCod_cte; }
            set { sCod_cte = value; }
        }

        public wfCliente()
        {
            InitializeComponent();
        }

        private void wfCliente_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_cte);
            alDatosEnviados.Add(txtDpi_cte);
            alDatosEnviados.Add(txtNit_cte);
            alDatosEnviados.Add(txtNom1_cte);
            alDatosEnviados.Add(txtNom2_cte);
            alDatosEnviados.Add(txtApell1_cte);
            alDatosEnviados.Add(txtApell2_cte);
            alDatosEnviados.Add(txtTel_cte);
            alDatosEnviados.Add(txtCredito_cte);
            alDatosEnviados.Add(txtCargo_cte);
            alDatosEnviados.Add(txtAbono_cte);
            alDatosEnviados.Add(txtCargoacum_cte);
            alDatosEnviados.Add(txtEstado_cte);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
        }

        private void cboEstado_cte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_cte.SelectedIndex)
            {
                case 0: txtEstado_cte.Text = "1"; break;
                case 1: txtEstado_cte.Text = "0"; break;
                default: txtEstado_cte.Text = string.Empty; break;
            }
        }

        private void txtEstado_cte_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_cte.Text)
            {
                case "1": cboEstado_cte.SelectedIndex = 0; break;
                case "0": cboEstado_cte.SelectedIndex = 1; break;
                default: cboEstado_cte.SelectedIndex = -1; break;
            }
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void txtEstado_cte_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_cte.Enabled = txtEstado_cte.Enabled;
        }

        private void txtCod_cte_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_cte.Enabled = false;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            cboEstado_cte.SelectedIndex = 0;
            txtDpi_cte.Focus();
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_cte.Text = sCodigo;
            cboEstado_cte.SelectedIndex = 0;
            txtDpi_cte.Focus();
        }

        private void txtDoc_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtNumdoc_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -.,0123456789");
        }

        private void txtNom1_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz");
        }

        private void txtNom2_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz");
        }

        private void txtApell1_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz");
        }

        private void txtApell2_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz");
        }

        private void txtTel_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "+()-0123456789");
        }

        private void txtCredito_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtCargo_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtAbono_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtCargoacum_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtCod_cte_TextChanged(object sender, EventArgs e)
        {
            SCod_cte = txtCod_cte.Text;
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_cte.Text;
        }

        private void navegador1_btnImprimir_AfterClick(object sender, EventArgs e)
        {
            Reporteador.wfReportes Reporteador = new Reporteador.wfReportes();
            Reporteador.SNombreReporte = "Clientes";
            Reporteador.ShowDialog();
        }
    }
}
