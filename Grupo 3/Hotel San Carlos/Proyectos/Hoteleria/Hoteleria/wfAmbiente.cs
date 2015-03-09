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
    public partial class wfAmbiente : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        BindingSource bsProductosAmbiente = new BindingSource();
        DataTable dtProductosAmbiente = new DataTable();
        DataTable dtDetalle = new DataTable();
        DataTable dtAmbientes = new DataTable();
        BindingSource bsAmbientes = new BindingSource();
        private string sCod_amb = string.Empty;
        private bool bModificarRegistro = false;
        private string sCodigo = string.Empty;

        public string SCod_amb
        {
            get { return sCod_amb; }
            set { sCod_amb = value; }
        }

        public wfAmbiente()
        {
            InitializeComponent();
        }

        private void wfAmbiente_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_amb);
            alDatosEnviados.Add(txtCod_tamb);
            alDatosEnviados.Add(txtPrecio_amb);
            alDatosEnviados.Add(txtDisponibilidad_amb);
            alDatosEnviados.Add(txtEstado_amb);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
            bsProductosAmbiente.DataSource = dtProductosAmbiente;
            dgvProductosAmbiente.DataSource = bsProductosAmbiente;
        }

        private void cboDisponibilidad_amb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDisponibilidad_amb.SelectedIndex)
            {
                case 0: txtDisponibilidad_amb.Text = "1"; break;
                case 1: txtDisponibilidad_amb.Text = "0"; break;
                default: txtDisponibilidad_amb.Text = string.Empty; break;            
            }
        }
        private void txtDisponibilidad_amb_TextChanged(object sender, EventArgs e)
        {
            switch (txtDisponibilidad_amb.Text)
            {
                case "1": cboDisponibilidad_amb.SelectedIndex = 0; break;
                case "0": cboDisponibilidad_amb.SelectedIndex = 1; break;
                default: cboDisponibilidad_amb.SelectedIndex = -1; break;
            }
        }

        private void cboEstado_amb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_amb.SelectedIndex)
            {
                case 0: txtEstado_amb.Text = "1"; break;
                case 1: txtEstado_amb.Text = "0"; break;
                default: txtEstado_amb.Text = string.Empty; break;
            }
        }

        private void txtEstado_amb_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_amb.Text)
            {
                case "1": cboEstado_amb.SelectedIndex = 0; break;
                case "0": cboEstado_amb.SelectedIndex = 1; break;
                default: cboEstado_amb.SelectedIndex = -1; break;
            }
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            dtDetalle = dtProductosAmbiente;
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            cboDisponibilidad_amb.SelectedIndex = 0;
            cboEstado_amb.SelectedIndex = 0;
            txtCod_amb.Focus();
            vLlenarCboProductos();
            vLlenarDgvProductosAmbiente();
        }

        private void txtCod_amb_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_amb.Enabled = false;
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_amb.Text = sCodigo;
            cboDisponibilidad_amb.SelectedIndex = 0;
            cboEstado_amb.SelectedIndex = 0;
            txtCod_amb.Focus();
            vLlenarCboProductos();
            vLlenarDgvProductosAmbiente();
            txtCantidad.Text = string.Empty;
        }

        private void txtDisponibilidad_amb_EnabledChanged(object sender, EventArgs e)
        {
            cboDisponibilidad_amb.Enabled = txtDisponibilidad_amb.Enabled;
        }

        private void txtEstado_amb_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_amb.Enabled = txtEstado_amb.Enabled;
        }

        private void txtPrecio_amb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtCod_amb_TextChanged(object sender, EventArgs e)
        {
            sCod_amb = txtCod_amb.Text;
            vLlenarDgvProductosAmbiente();
        }

        private void txtCod_tamb_Enter(object sender, EventArgs e)
        {
            wfTipoAmbiente TipoAmbiente = new wfTipoAmbiente();
            TipoAmbiente.ShowDialog();
            txtCod_tamb.Text = TipoAmbiente.SCod_tamb;
        }

        private void txtCod_tamb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void vLlenarDgvProductosAmbiente()
        {
            dtProductosAmbiente = Negocio.dtConsultarRegistros("select * from tabt_feambcatprod where cod_amb='" + txtCod_amb.Text + "'");
            if (dtProductosAmbiente.Rows.Count != 0)
            {
                dtProductosAmbiente.Columns.RemoveAt(0);
                dtProductosAmbiente.Columns[0].ColumnName = "Código";
                dtProductosAmbiente.Columns[1].ColumnName = "Cantidad";
                dtProductosAmbiente.Columns[2].ColumnName = "Estado";
            }
            else
            {
                dtProductosAmbiente.Columns.Add("Código");
                dtProductosAmbiente.Columns.Add("Cantidad");
                dtProductosAmbiente.Columns.Add("Estado");
            }
            bsProductosAmbiente.DataSource = dtProductosAmbiente;
            dgvProductosAmbiente.DataSource = bsProductosAmbiente;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtCantidad.Text, string.Empty) != 0)
            {
                dtProductosAmbiente.Rows.Add(cboCodigos.SelectedValue, txtCantidad.Text,"1");
                dgvProductosAmbiente.Refresh();
                cboCodigos.SelectedIndex = -1;
                txtCantidad.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
            }            
        }

        private void vLlenarCboProductos()
        {
            dtAmbientes = Negocio.dtConsultarRegistros("select cod_catprod, nom_catprod from tabm_fecatprod where estado_catprod = 1 and tipo_catprod='Mobiliario' order by nom_catprod asc");
            if (dtAmbientes.Rows.Count != 0)
            {
                dtAmbientes.Columns[0].ColumnName = "Código";
                dtAmbientes.Columns[1].ColumnName = "Producto";
                bsAmbientes.DataSource = dtAmbientes;
                cboCodigos.DataSource = bsAmbientes;
                cboCodigos.DisplayMember = "Producto";
                cboCodigos.ValueMember = "Código";
                cboCodigos.Refresh();
                cboCodigos.SelectedIndex = -1;
            }
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            bModificarRegistro = true;
            vLlenarCboProductos();
            dgvProductosAmbiente.ReadOnly = false;
            dgvProductosAmbiente.AllowUserToDeleteRows = false;
            dgvProductosAmbiente.Columns[0].ReadOnly = true;
            dgvProductosAmbiente.Columns[1].ReadOnly = false;
            dgvProductosAmbiente.Columns[2].ReadOnly = false;
            cboCodigos.Enabled = false;
            txtCantidad.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_amb.Text);
            Negocio.SNombreTabla = "tabt_feambcatprod";
            if (bModificarRegistro)
            {
                Negocio.vModificarRegistros(alCodigos, dtDetalle);
                bModificarRegistro = false;
            }
            else
            {
                Negocio.vInsertarRegistros(alCodigos, dtDetalle);
            }
            vLlenarDgvProductosAmbiente();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtCod_tamb_EnabledChanged(object sender, EventArgs e)
        {
            dgvProductosAmbiente.Enabled = txtCod_tamb.Enabled;
            cboCodigos.Enabled = txtCod_tamb.Enabled;
            txtCantidad.Enabled = txtCod_tamb.Enabled;
            btnAgregar.Enabled = txtCod_tamb.Enabled;
        }

        private void navegador1_btnEliminar_AfterClick(object sender, EventArgs e)
        {
            Negocio.SNombreTabla = "tabt_feambcatprod";
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_amb.Text);
            Negocio.vEliminarRegistros(alCodigos, dtProductosAmbiente);
            vLlenarDgvProductosAmbiente();
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_amb.Text;
        }

        private void navegador1_btnImprimir_AfterClick(object sender, EventArgs e)
        {
            Reporteador.wfReportes Reporteador = new Reporteador.wfReportes();
            Reporteador.SNombreReporte = "Ambientes";
            Reporteador.ShowDialog();
        }
    }
}
