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
    public partial class wfFactura : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();        
        DataTable dtImpuestos = new DataTable();
        BindingSource bsImpuesto = new BindingSource();        
        BindingSource bsDetalleImpuesto = new BindingSource();
        DataTable dtDetalleImpuesto = new DataTable();
        DataTable dtDetalle = new DataTable();
        BindingSource bsDetalleFactura = new BindingSource();
        DataTable dtDetalleFactura = new DataTable();
        private float fTotal;
        private string sCod_fra = string.Empty;
        private bool bModificarRegistro = false;
        private string sCodigo = string.Empty;

        public string SCod_fra
        {
            get { return sCod_fra; }
            set { sCod_fra = value; }
        }

        public wfFactura()
        {
            InitializeComponent();
        }

        private void wfFactura_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_fra);
            alDatosEnviados.Add(txtCod_srie);
            alDatosEnviados.Add(txtCod_suc);
            alDatosEnviados.Add(txtCod_empsa);
            alDatosEnviados.Add(txtCod_flocte);
            alDatosEnviados.Add(txtFechaemitida_fra);
            alDatosEnviados.Add(txtValor_fra);
            alDatosEnviados.Add(txtImpuesto_fra);
            alDatosEnviados.Add(txtTotal_fra);
            alDatosEnviados.Add(txtEstado_fra);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
        }

        private void txtCod_fra_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_fra.Enabled = false;
            cboSeleccionarImp.Enabled = txtCod_fra.Enabled;
            dgvDetalleFactura.Enabled = txtCod_fra.Enabled;
            dgvDetalleImpuesto.Enabled = txtCod_fra.Enabled;
            btnAgregarImp.Enabled = txtCod_fra.Enabled;
        }

        private void txtFechaemitida_fra_TextChanged(object sender, EventArgs e)
        {
            dtpFechemitida_fra.Text = txtFechaemitida_fra.Text;
        }

        private void txtFechaemitida_fra_EnabledChanged(object sender, EventArgs e)
        {
            dtpFechemitida_fra.Enabled = txtFechaemitida_fra.Enabled;
            btnGenerarDetalle.Enabled = txtFechaemitida_fra.Enabled;
        }

        private void dtpFechemitida_fra_ValueChanged(object sender, EventArgs e)
        {
            txtFechaemitida_fra.Text = dtpFechemitida_fra.Text;
        }

        private void txtValor_fra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtImpuesto_fra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtTotal_fra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }
        
        private void txtCod_srie_Enter(object sender, EventArgs e)
        {
            wfSerie Serie = new wfSerie();
            Serie.ShowDialog();
            txtCod_srie.Text = Serie.SCod_srie;
        }

        private void txtCod_suc_Enter(object sender, EventArgs e)
        {
            Inventario.wfSucursal Sucursal = new Inventario.wfSucursal();
            Sucursal.ShowDialog();
            txtCod_suc.Text = Sucursal.SCod_suc;
        }

        private void txtCod_empsa_Enter(object sender, EventArgs e)
        {
            wfEmpresa Empresa = new wfEmpresa();
            Empresa.ShowDialog();
            txtCod_empsa.Text = Empresa.SCod_empsa; 
        }

        private void txtCod_flocte_Enter(object sender, EventArgs e)
        {
            Hoteleria.wfFolioCliente Folio = new Hoteleria.wfFolioCliente();
            Folio.ShowDialog();
            txtCod_flocte.Text = Folio.SCod_flocte;
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            dtDetalle = dtDetalleImpuesto;
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void txtCod_suc_Enter_1(object sender, EventArgs e)
        {
            Inventario.wfSucursal Sucursales = new Inventario.wfSucursal();
            Sucursales.ShowDialog();
            txtCod_suc.Text = Sucursales.SCod_suc;
        }        
        
        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {
            dtImpuestos = Negocio.dtConsultarRegistros("select");
            if (dtImpuestos.Rows.Count != 0)
            {
                dtImpuestos.Columns[0].ColumnName = "Codigo";
                dtImpuestos.Columns[1].ColumnName = "Servicio";
                dtImpuestos.Columns[2].ColumnName = "Precio";                
            }             
        }

        private void vLlenarDgvDetalleFactura()
        {
            dtDetalleFactura = Negocio.dtConsultarRegistros("select concat(b.cod_amb,'-',a.ambiente_tamb), c.dias_drsva, c.total_drsva from tabm_fetambiente a, tabm_feambiente b, tabt_fedrsva c, tabm_fereservacion d, tabm_fefoliocliente e where a.cod_tamb = b.cod_tamb and b.cod_amb = c.cod_amb and c.cod_rsva = d.cod_rsva and d.cod_rsva = e.cod_rsva and e.cod_flocte = '" + txtCod_flocte.Text + "' union select f.servicio_serv, g.cant_servflocte, g.total_servflocte from tabm_feservicio f, tabt_feservflocte g where f.cod_serv = g.cod_serv and g.cod_flocte = '" + txtCod_flocte.Text + "'");
            if (dtDetalleFactura.Rows.Count != 0)
            {
                dtDetalleFactura.Columns[0].ColumnName = "Servicio";
                dtDetalleFactura.Columns[1].ColumnName = "Cantidad";
                dtDetalleFactura.Columns[2].ColumnName = "Total";
            }
            else
            {
                dtDetalleFactura.Columns.Add("Servicio");
                dtDetalleFactura.Columns.Add("Cantidad");
                dtDetalleFactura.Columns.Add("Total");
            }
            bsDetalleFactura.DataSource = dtDetalleFactura;
            dgvDetalleFactura.DataSource = bsDetalleFactura;
            dgvDetalleFactura.Refresh();
        }

        private void btnGenerarDetalle_Click(object sender, EventArgs e)
        {
            dgvDetalleImpuesto.Enabled = true;
            dgvDetalleFactura.Enabled = true;
            cboSeleccionarImp.Enabled = true;
            btnAgregarImp.Enabled = true;
            fTotal = 0;
            vLlenarDgvDetalleFactura();
            foreach (DataRow drFila in dtDetalleFactura.Rows)
            {
                fTotal += Convert.ToSingle(drFila[2].ToString());
            }
            txtValor_fra.Text = fTotal.ToString();
        }

        private void txtTotal_fra_Enter(object sender, EventArgs e)
        {
            txtTotal_fra.Enabled = false;
        }

        private void txtValor_fra_EnabledChanged(object sender, EventArgs e)
        {
            txtValor_fra.Enabled = false;
        }
        
        private void vLlenarDgvDetalleImpuesto()
        {
            dtDetalleImpuesto = Negocio.dtConsultarRegistros("select * from tabt_fefraim where cod_fra = '" + txtCod_fra.Text + "' and cod_srie = '" + txtCod_srie.Text + "' and cod_suc = '" + txtCod_suc.Text + "'");
            if (dtDetalleImpuesto.Rows.Count != 0)
            {
                dtDetalleImpuesto.Columns.RemoveAt(0);
                dtDetalleImpuesto.Columns.RemoveAt(0);
                dtDetalleImpuesto.Columns.RemoveAt(0);
                dtDetalleImpuesto.Columns[0].ColumnName = "Código";
                dtDetalleImpuesto.Columns[1].ColumnName = "Total";
                dtDetalleImpuesto.Columns[2].ColumnName = "Estado";
            }
            else
            {
                dtDetalleImpuesto.Columns.Add("Código");
                dtDetalleImpuesto.Columns.Add("Total");
                dtDetalleImpuesto.Columns.Add("Estado");                   
            }
            bsDetalleImpuesto.DataSource = dtDetalleImpuesto;
            dgvDetalleImpuesto.DataSource = bsDetalleImpuesto;
            dgvDetalleImpuesto.Refresh();
        }

        private void txtCod_fra_TextChanged(object sender, EventArgs e)
        {
            SCod_fra = txtCod_fra.Text;
        }

        private void btnAgregarImp_Click(object sender, EventArgs e)
        {
            dtDetalleImpuesto.Rows.Add(cboSeleccionarImp.SelectedValue, txtTotalImp.Text,"1");
            dgvDetalleImpuesto.Refresh();
            float fImpuestos = Convert.ToSingle(txtImpuesto_fra.Text) + Convert.ToSingle(txtTotalImp.Text);
            txtImpuesto_fra.Text = fImpuestos.ToString();
        }

        private void vLlenarCboSeleccionarImp()
        {
            dtImpuestos = Negocio.dtConsultarRegistros("select cod_imp, nom_imp, valor_imp from tabm_feimpuesto where estado_imp = '1'");
            if (dtImpuestos.Rows.Count != 0)
            {
                dtImpuestos.Columns[0].ColumnName = "Codigo";
                dtImpuestos.Columns[1].ColumnName = "Impuesto";
                dtImpuestos.Columns[2].ColumnName = "Valor";
                bsImpuesto.DataSource = dtImpuestos;
                cboSeleccionarImp.DataSource = bsImpuesto;
                cboSeleccionarImp.DisplayMember = "Impuesto";
                cboSeleccionarImp.ValueMember = "Codigo";
                cboSeleccionarImp.Refresh();
                cboSeleccionarImp.SelectedIndex = -1;
            }
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            bModificarRegistro = true;
            vLlenarDgvDetalleImpuesto();
            dgvDetalleImpuesto.ReadOnly = false;
            dgvDetalleImpuesto.AllowUserToDeleteRows = false;
            dgvDetalleImpuesto.Columns[0].ReadOnly = true;
            dgvDetalleImpuesto.Columns[1].ReadOnly = false;
            dgvDetalleImpuesto.Columns[2].ReadOnly = false;
            vLlenarDgvDetalleImpuesto();
            cboSeleccionarImp.Enabled = false; 
            btnAgregarImp.Enabled = false;
        }

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_fra.Text);
            alCodigos.Add(txtCod_srie.Text);
            alCodigos.Add(txtCod_suc.Text);
            Negocio.SNombreTabla = "tabt_fefraim";
            if (bModificarRegistro)
            {
                Negocio.vModificarRegistros(alCodigos, dtDetalle);
                bModificarRegistro = false;
            }
            else
            {               
                Negocio.vInsertarRegistros(alCodigos, dtDetalle);
            }
            vLlenarDgvDetalleImpuesto();
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            vLlenarCboSeleccionarImp();
            vLlenarDgvDetalleImpuesto();
            txtValor_fra.Text = "0";
            txtImpuesto_fra.Text = "0";
            txtTotal_fra.Text = "0";
            txtFechaemitida_fra.Text = dtpFechemitida_fra.Text;
            cboEstado_fra.SelectedIndex = 0;
        }

        private void cboSeleccionarImp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string.Compare(txtValor_fra.Text, string.Empty) != 0) && (cboSeleccionarImp.SelectedIndex != -1))
            {
                float fPrecio = 0;
                foreach (DataRow drFila in dtImpuestos.Rows)
                {
                    if (string.Compare(cboSeleccionarImp.SelectedValue.ToString(), drFila[0].ToString()) == 0)
                    {
                        fPrecio = Convert.ToSingle(drFila[2].ToString());
                    }
                }
                float fTotal = fPrecio * Convert.ToSingle(txtValor_fra.Text);
                txtTotalImp.Text = fTotal.ToString();
            }
        }

        private void txtImpuesto_fra_EnabledChanged(object sender, EventArgs e)
        {
            txtImpuesto_fra.Enabled = false;
        }

        private void txtTotal_fra_EnabledChanged(object sender, EventArgs e)
        {
            txtTotal_fra.Enabled = false;
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_fra.Text = sCodigo;
            vLlenarCboSeleccionarImp();
            vLlenarDgvDetalleImpuesto();
            txtValor_fra.Text = "0";
            txtImpuesto_fra.Text = "0";
            txtTotal_fra.Text = "0";
            txtFechaemitida_fra.Text = dtpFechemitida_fra.Text;
            cboEstado_fra.SelectedIndex = 0;
        }

        private void txtImpuesto_fra_TextChanged(object sender, EventArgs e)
        {
            if((string.Compare(txtValor_fra.Text,string.Empty) !=0 ) && (string.Compare(txtImpuesto_fra.Text,string.Empty) != 0))
            {
                txtTotal_fra.Text = (Convert.ToSingle(txtValor_fra.Text) + Convert.ToSingle(txtImpuesto_fra.Text)).ToString();
            }
        }

        private void txtEstado_fra_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_fra.Enabled = txtEstado_fra.Enabled;
        }

        private void cboEstado_fra_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_fra.SelectedIndex)
            {
                case 0: txtEstado_fra.Text = "1"; break;
                case 1: txtEstado_fra.Text = "0"; break;
                default: txtEstado_fra.Text = string.Empty; break;
            }
        }

        private void txtEstado_fra_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_fra.Text)
            {
                case "0": cboEstado_fra.SelectedIndex = 1; break;
                case "1": cboEstado_fra.SelectedIndex = 0; break;
                default: cboEstado_fra.SelectedIndex = -1; break;
            }
        }

        private void navegador1_btnEliminar_AfterClick(object sender, EventArgs e)
        {
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_fra.Text);
            alCodigos.Add(txtCod_srie.Text);
            alCodigos.Add(txtCod_suc.Text);
            Negocio.SNombreTabla = "tabt_fefraim";
            Negocio.vEliminarRegistros(alCodigos, dtDetalleImpuesto);
            vLlenarDgvDetalleImpuesto();
            dgvDetalleImpuesto.Refresh();
        }

        private void txtCod_flocte_TextChanged(object sender, EventArgs e)
        {
            vLlenarDgvDetalleFactura();
            vLlenarDgvDetalleImpuesto();
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_fra.Text;
        }

        private void navegador1_btnImprimir_AfterClick(object sender, EventArgs e)
        {
            Reporteador.wfReportes Reporteador = new Reporteador.wfReportes();
            Reporteador.SNombreReporte = "Facturas";
            Reporteador.ShowDialog();
        }    
    }
}
