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
    public partial class wfDocumentos : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        BindingSource bsDocumentos = new BindingSource();
        DataTable dtDocumentos = new DataTable();
        DataTable dtDetalle = new DataTable();
        BindingSource bsCatProductos = new BindingSource();
        DataTable dtCatProductos = new DataTable();
        BindingSource bsBodegas = new BindingSource();
        DataTable dtBodegas = new DataTable();
        private bool bModificarRegistro = false;
        private string sCod_docs = string.Empty;
        private string sCodigo = string.Empty;

        public string SCod_docs
        {
            get { return sCod_docs; }
            set { sCod_docs = value; }
        }

        public wfDocumentos()
        {
            InitializeComponent();
        }

        private void wfDocumentos_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_docs);
            alDatosEnviados.Add(txtCod_empsa);
            alDatosEnviados.Add(txtCod_srie);
            alDatosEnviados.Add(txtCod_suc);
            alDatosEnviados.Add(txtCod_ttrans);
            alDatosEnviados.Add(txtFechent_inv);
            alDatosEnviados.Add(txtTotal_docs);
            alDatosEnviados.Add(txtEstado_docs);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
        }

        private void cboEstadoDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_docs.SelectedIndex)
            {
                case 0: txtEstado_docs.Text = "1"; break;
                case 1: txtEstado_docs.Text = "0"; break;
                default: txtEstado_docs.Text = string.Empty; break;
            }
        }

        private void txtEstadoDocs_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_docs.Text)
            {
                case "1": cboEstado_docs.SelectedIndex = 0; break;
                case "0": cboEstado_docs.SelectedIndex = 1; break;
                default: cboEstado_docs.SelectedIndex = -1; break;                
            }
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            dtDetalle = dtDocumentos;   
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            vLlenarCboBodega();
            vLlenarCboCatalogo();
            vLlenarDgvDocumentos();
            txtFechent_inv.Text = dtpFechent_inv.Text;
            cboEstado_docs.SelectedIndex = 0;
        }

        private void txtCodDocs_TextChanged(object sender, EventArgs e)
        {
            SCod_docs = txtCod_docs.Text;
            vLlenarDgvDocumentos();
        }

        private void txtCod_empsa_Enter(object sender, EventArgs e)
        {
            Facturacion.wfEmpresa Empresa = new Facturacion.wfEmpresa();
            Empresa.ShowDialog();
            txtCod_empsa.Text = Empresa.SCod_empsa;
        }

        private void txtCod_srie_Enter(object sender, EventArgs e)
        {
            Facturacion.wfSerie Serie = new Facturacion.wfSerie();
            Serie.ShowDialog();
            txtCod_srie.Text = Serie.SCod_srie;
        }

        private void txtCod_suc_Enter(object sender, EventArgs e)
        {
            wfSucursal Sucursal = new wfSucursal();
            Sucursal.ShowDialog();
            txtCod_suc.Text = Sucursal.SCod_suc;
        }

        private void txtTotal_docs_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtCod_docs_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtCod_empsa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtCod_srie_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtCod_suc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtCod_ttrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtFechent_inv_TextChanged(object sender, EventArgs e)
        {
            dtpFechent_inv.Text = txtFechent_inv.Text;
        }

        private void dtpFechent_inv_ValueChanged(object sender, EventArgs e)
        {
            txtFechent_inv.Text = dtpFechent_inv.Text;
        }

        private void txtCod_docs_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_docs.Enabled = false;
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_docs.Text = sCodigo;
            txtFechent_inv.Text = dtpFechent_inv.Text;
            cboEstado_docs.SelectedIndex = 0;
            vLlenarDgvDocumentos();
            vLlenarCboCatalogo();
            vLlenarCboBodega();
        }

        private void txtEstado_docs_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_docs.Enabled = txtEstado_docs.Enabled;
        }

        private void txtFechent_inv_EnabledChanged(object sender, EventArgs e)
        {
            dtpFechent_inv.Enabled = txtFechent_inv.Enabled;
        }

        private void vLlenarDgvDocumentos()
        {
            dtDocumentos = Negocio.dtConsultarRegistros("select * from tabt_feddocumentos where cod_docs='" + txtCod_docs.Text + "'");
            if (dtDocumentos.Rows.Count != 0)
            {
                dtDocumentos.Columns.RemoveAt(0);
                dtDocumentos.Columns.RemoveAt(0);
                dtDocumentos.Columns[0].ColumnName = "Producto";
                dtDocumentos.Columns[1].ColumnName = "Bodega";
                dtDocumentos.Columns[2].ColumnName = "P. Compra";
                dtDocumentos.Columns[3].ColumnName = "P. Venta";
                dtDocumentos.Columns[4].ColumnName = "Cantidad";
                dtDocumentos.Columns[5].ColumnName = "Valor";
                dtDocumentos.Columns[6].ColumnName = "Estado";
            }
            else
            {
                dtDocumentos.Columns.Add("Producto");
                dtDocumentos.Columns.Add("Bodega");
                dtDocumentos.Columns.Add("P. Compra");
                dtDocumentos.Columns.Add("P. Venta");
                dtDocumentos.Columns.Add("Cantidad");
                dtDocumentos.Columns.Add("Valor");
                dtDocumentos.Columns.Add("Estado");
            }
            bsDocumentos.DataSource = dtDocumentos;
            dgvDocumentos.DataSource = bsDocumentos; 
        }

        private void vLlenarCboCatalogo()
        {
            dtCatProductos = Negocio.dtConsultarRegistros("select cod_catprod, nom_catprod from tabm_fecatprod where estado_catprod = 1 and tipo_catprod='Producto' order by nom_catprod asc");
            if (dtCatProductos.Rows.Count != 0)
            {
                dtCatProductos.Columns[0].ColumnName = "Código";
                dtCatProductos.Columns[1].ColumnName = "Producto";
                bsCatProductos.DataSource = dtCatProductos;
                cboCodigosCat.DataSource = bsCatProductos;
                cboCodigosCat.DisplayMember = "Producto";
                cboCodigosCat.ValueMember = "Código";
                cboCodigosCat.Refresh();
                cboCodigosCat.SelectedIndex = -1;
            }
        }

        private void vLlenarCboBodega()
        {
            dtBodegas = Negocio.dtConsultarRegistros("select cod_bga, descrip_bga from tabm_febodega where estado_bga = 1 order by descrip_bga asc");
            if (dtBodegas.Rows.Count != 0)
            {
                dtBodegas.Columns[0].ColumnName = "Código";
                dtBodegas.Columns[1].ColumnName = "Bodega";
                bsBodegas.DataSource = dtBodegas;
                cboCodigoBodega.DataSource = bsBodegas;
                cboCodigoBodega.DisplayMember = "Bodega";
                cboCodigoBodega.ValueMember = "Código";
                cboCodigoBodega.Refresh();
                cboCodigoBodega.SelectedIndex = -1;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtCantidad.Text, string.Empty) != 0)
            {
                dtDocumentos.Rows.Add(cboCodigosCat.SelectedValue, cboCodigoBodega.SelectedValue, txtPrecioc.Text, txtPreciov.Text, txtCantidad.Text, txtValor.Text, "1");
                dgvDocumentos.Refresh();
                cboCodigosCat.SelectedIndex = -1;
                cboCodigoBodega.SelectedIndex = -1;
                txtPrecioc.Text = string.Empty;
                txtPreciov.Text = string.Empty;
                txtCantidad.Text = string.Empty;
                txtValor.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioc.Focus(); 
            }
        }

        private void txtCod_empsa_EnabledChanged(object sender, EventArgs e)
        {
            dgvDocumentos.Enabled = txtCod_empsa.Enabled;
            cboCodigosCat.Enabled = txtCod_empsa.Enabled;
            cboCodigoBodega.Enabled = txtCod_empsa.Enabled;
            txtPrecioc.Enabled = txtCod_empsa.Enabled;
            txtPreciov.Enabled = txtCod_empsa.Enabled;
            txtCantidad.Enabled = txtCod_empsa.Enabled;
            txtValor.Enabled = txtCod_empsa.Enabled;
            btnAgregar.Enabled = txtCod_empsa.Enabled;
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            bModificarRegistro = true;
            vLlenarCboCatalogo();
            vLlenarCboBodega();
            dgvDocumentos.ReadOnly = false;
            dgvDocumentos.AllowUserToDeleteRows = false;
            dgvDocumentos.Columns[0].ReadOnly = true;
            dgvDocumentos.Columns[1].ReadOnly = true;
            dgvDocumentos.Columns[2].ReadOnly = false;
            dgvDocumentos.Columns[3].ReadOnly = false;
            dgvDocumentos.Columns[4].ReadOnly = false;
            dgvDocumentos.Columns[5].ReadOnly = false;
            dgvDocumentos.Columns[6].ReadOnly = false;
            cboCodigosCat.Enabled = false;
            cboCodigoBodega.Enabled = false;
            txtPrecioc.Enabled = false;
            txtPreciov.Enabled = false;
            txtCantidad.Enabled = false;
            txtValor.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_docs.Text);
            alCodigos.Add(txtCod_srie.Text);
            Negocio.SNombreTabla = "tabt_feddocumentos";
            if(bModificarRegistro)
            {
                Negocio.vModificarRegistros(alCodigos, dtDetalle);
                bModificarRegistro = false;
            }
            else
            {
                Negocio.vInsertarRegistros(alCodigos, dtDetalle);
            }
            vLlenarDgvDocumentos();
        }

        private void txtPrecioc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtPreciov_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void navegador1_btnEliminar_AfterClick(object sender, EventArgs e)
        {
            Negocio.SNombreTabla = "tabt_feddocumentos";
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_docs.Text);
            alCodigos.Add(txtCod_srie.Text);
            Negocio.vEliminarRegistros(alCodigos, dtDocumentos);
            vLlenarDgvDocumentos();
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_docs.Text;
        }

        private void txtPrecioc_TextChanged(object sender, EventArgs e)
        {
            if ((string.Compare(txtPrecioc.Text, string.Empty) != 0) && (string.Compare(txtCantidad.Text, string.Empty) != 0))
            {
                float fPrecioc = Convert.ToSingle(txtPrecioc.Text);
                float fCantidad = Convert.ToSingle(txtCantidad.Text);
                txtValor.Text = (fPrecioc * fCantidad).ToString();
            }
            else
            {
                txtValor.Text = string.Empty;
            }
        }

        private void txtValor_EnabledChanged(object sender, EventArgs e)
        {
            txtValor.Enabled = false;
        }

        private void txtTotal_docs_EnabledChanged(object sender, EventArgs e)
        {
            txtTotal_docs.Enabled = false;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if ((string.Compare(txtPrecioc.Text, string.Empty) != 0) && (string.Compare(txtCantidad.Text, string.Empty) != 0))
            {
                float fPrecioc = Convert.ToSingle(txtPrecioc.Text);
                float fCantidad = Convert.ToSingle(txtCantidad.Text);
                txtValor.Text = (fPrecioc * fCantidad).ToString();
            }
            else
            {
                txtValor.Text = string.Empty;
            }
        }

        private void dgvDocumentos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            float fTotalReservacion = 0;
            for (int iPosicion = 0; iPosicion < dgvDocumentos.Rows.Count; iPosicion++)
            {
                fTotalReservacion += Convert.ToSingle(dgvDocumentos.Rows[iPosicion].Cells[5].Value);
            }
            txtTotal_docs.Text = fTotalReservacion.ToString();
        }

        private void dgvDocumentos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            float fTotalReservacion = 0;
            for (int iPosicion = 0; iPosicion < dgvDocumentos.Rows.Count; iPosicion++)
            {
                fTotalReservacion += Convert.ToSingle(dgvDocumentos.Rows[iPosicion].Cells[5].Value);
            }
            txtTotal_docs.Text = fTotalReservacion.ToString();
        }

        private void navegador1_btnImprimir_AfterClick(object sender, EventArgs e)
        {
            Reporteador.wfReportes Reporteador = new Reporteador.wfReportes();
            Reporteador.SNombreReporte = "Documentos";
            Reporteador.ShowDialog();
        }
    }
}