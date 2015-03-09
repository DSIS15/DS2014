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
    public partial class wfBodega : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        BindingSource bsExistencias = new BindingSource();
        DataTable dtExistencias = new DataTable();
        DataTable dtDetalle = new DataTable();
        BindingSource bsCatProductos = new BindingSource();
        DataTable dtCatProductos = new DataTable();
        private bool bModificarRegistro = false;
        private string sCod_bga = string.Empty;
        private string sCodigo = string.Empty;

        public string SCod_bga
        {
            get { return sCod_bga; }
            set { sCod_bga = value; }
        }

        public wfBodega()
        {
            InitializeComponent();
        }

        private void wfBodega_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_bga);
            alDatosEnviados.Add(txtCod_suc);
            alDatosEnviados.Add(txtDescrip_bga);
            alDatosEnviados.Add(txtDire_bga);
            alDatosEnviados.Add(txtEstado_bga);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
        }

        private void cboEstado_bga_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_bga.SelectedIndex)
            {
                case 0: txtEstado_bga.Text = "1"; break;
                case 1: txtEstado_bga.Text = "0"; break;
                default: txtEstado_bga.Text = string.Empty; break;
            }
        }

        private void txtEstadoBodega_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_bga.Text)
            {
                case "1": cboEstado_bga.SelectedIndex = 0; break;
                case "0": cboEstado_bga.SelectedIndex = 1; break;
                default: cboEstado_bga.SelectedIndex = -1; break;
            }
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_bga.Text = sCodigo;
            cboEstado_bga.SelectedIndex = 0;
            vLlenarCboCatalogo();
        }

        private void vLlenarDgvExistencias()
        {
            dtExistencias = Negocio.dtConsultarRegistros("select * from tabt_feexistencias where cod_bga='" + txtCod_bga.Text + "'");
            if (dtExistencias.Rows.Count != 0)
            {
                dtExistencias.Columns.RemoveAt(0);
                dtExistencias.Columns[0].ColumnName = "Producto";
                dtExistencias.Columns[1].ColumnName = "Cantidad";
                dtExistencias.Columns[2].ColumnName = "C. congelada";
                dtExistencias.Columns[3].ColumnName = "Estado";
            }
            else
            {
                dtExistencias.Columns.Add("Producto");
                dtExistencias.Columns.Add("Cantidad");
                dtExistencias.Columns.Add("C. congelada");
                dtExistencias.Columns.Add("Estado");
            }
            bsExistencias.DataSource = dtExistencias;
            dgvExistencias.DataSource = bsExistencias;
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

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            dtDetalle = dtExistencias;
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void txtEstadoBodega_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_bga.Enabled = txtEstado_bga.Enabled;
        }

        private void txtCod_bga_TextChanged(object sender, EventArgs e)
        {
            SCod_bga = txtCod_bga.Text;
            vLlenarDgvExistencias();
        }

        private void txtCod_suc_Enter(object sender, EventArgs e)
        {
            wfSucursal Sucursales = new wfSucursal();
            Sucursales.ShowDialog();
            txtCod_suc.Text = Sucursales.SCod_suc;
        }

        private void txtCod_bga_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "1234567890");
        }

        private void txtCod_suc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "1234567890");
        }

        private void txtDescrip_bga_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtDire_bga_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtCod_bga_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_bga.Enabled = false;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            cboEstado_bga.SelectedIndex = 0;
            txtCod_bga.Focus();
            vLlenarCboCatalogo();
            vLlenarDgvExistencias();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((string.Compare(txtCantidad.Text, string.Empty) != 0) && (string.Compare(txtCantcongelada_exis.Text, string.Empty) != 0))
            {
                dtExistencias.Rows.Add(cboCodigosCat.SelectedValue, txtCantidad.Text, txtCantcongelada_exis.Text, "1");
                dgvExistencias.Refresh();
                cboCodigosCat.SelectedIndex = -1;
                txtCantidad.Text = string.Empty;
                txtCantcongelada_exis.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos.", "Hotel San Carlos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
            }
        }

        private void txtCod_suc_EnabledChanged(object sender, EventArgs e)
        {
            dgvExistencias.Enabled = txtCod_suc.Enabled;
            cboCodigosCat.Enabled = txtCod_suc.Enabled;
            txtCantidad.Enabled = txtCod_suc.Enabled;
            txtCantcongelada_exis.Enabled = txtCod_suc.Enabled;
            btnAgregar.Enabled = txtCod_suc.Enabled;
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            bModificarRegistro = true;
            vLlenarCboCatalogo();
            dgvExistencias.ReadOnly = false;
            dgvExistencias.AllowUserToDeleteRows = false;
            dgvExistencias.Columns[0].ReadOnly = true;
            dgvExistencias.Columns[1].ReadOnly = false;
            dgvExistencias.Columns[2].ReadOnly = false;
            dgvExistencias.Columns[3].ReadOnly = false;
            cboCodigosCat.Enabled = false;
            txtCantidad.Enabled = false;
            txtCantcongelada_exis.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_bga.Text);
            Negocio.SNombreTabla = "tabt_feexistencias";
            if (bModificarRegistro)
            {
                Negocio.vModificarRegistros(alCodigos, dtDetalle);
                bModificarRegistro = false;
            }
            else
            {
                Negocio.vInsertarRegistros(alCodigos, dtDetalle);
            }
            vLlenarDgvExistencias();
        }

        private void navegador1_btnEliminar_AfterClick(object sender, EventArgs e)
        {
            Negocio.SNombreTabla = "tabt_feexistencias";
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_bga.Text);
            Negocio.vEliminarRegistros(alCodigos, dtExistencias);
            vLlenarDgvExistencias();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void txtCantcongelada_exis_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_bga.Text;
        }
    }
}
