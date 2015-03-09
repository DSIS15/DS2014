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
    public partial class wfServicio : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        private string sCod_serv = string.Empty;
        private string sCodigo = string.Empty;

        public string SCod_serv
        {
            get { return sCod_serv; }
            set { sCod_serv = value; }
        }

        public wfServicio()
        {
            InitializeComponent();
        }

        private void wfServicio_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_serv);
            alDatosEnviados.Add(txtServicio_serv);
            alDatosEnviados.Add(txtPrecio_serv);
            alDatosEnviados.Add(txtDisponibilidad_serv);
            alDatosEnviados.Add(txtEstado_serv);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
        }

        private void txtCod_serv_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_serv.Enabled = false;
        }

        private void txtDisponibilidad_serv_TextChanged(object sender, EventArgs e)
        {
            switch (txtDisponibilidad_serv.Text)
            {
                case "1": cboDisponibilidad_serv.SelectedIndex = 0; break;
                case "0": cboDisponibilidad_serv.SelectedIndex = 1; break;
                default: cboDisponibilidad_serv.SelectedIndex = -1; break;
            }
        }

        private void cboDisponibilidad_serv_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDisponibilidad_serv.SelectedIndex)
            {
                case 0: txtDisponibilidad_serv.Text = "1"; break;
                case 1: txtDisponibilidad_serv.Text = "0"; break;
                default: txtDisponibilidad_serv.Text = string.Empty; break;
            }
        }

        private void txtDisponibilidad_serv_EnabledChanged(object sender, EventArgs e)
        {
            cboDisponibilidad_serv.Enabled = txtDisponibilidad_serv.Enabled;
        }

        private void txtEstado_serv_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_serv.Enabled = txtEstado_serv.Enabled;
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
            cboDisponibilidad_serv.SelectedIndex = 0;
            cboEstado_serv.SelectedIndex = 0;
            txtServicio_serv.Focus();
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_serv.Text = sCodigo;
            cboDisponibilidad_serv.SelectedIndex = 0;
            cboEstado_serv.SelectedIndex = 0;
            txtServicio_serv.Focus();
        }

        private void txtServicio_serv_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtEstado_serv_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_serv.Text)
            {
                case "1": cboEstado_serv.SelectedIndex = 0; break;
                case "0": cboEstado_serv.SelectedIndex = 1; break;
                default: cboEstado_serv.SelectedIndex = -1; break;
            }
        }

        private void cboEstado_serv_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_serv.SelectedIndex)
            {
                case 0: txtEstado_serv.Text = "1"; break;
                case 1: txtEstado_serv.Text = "0"; break;
                default: txtEstado_serv.Text = string.Empty; break;
            }
        }

        private void txtPrecio_serv_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_serv.Text;
        }

        private void navegador1_btnImprimir_AfterClick(object sender, EventArgs e)
        {
            Reporteador.wfReportes Reporteador = new Reporteador.wfReportes();
            Reporteador.SNombreReporte = "Servicios";
            Reporteador.ShowDialog();
        }
    }
}
