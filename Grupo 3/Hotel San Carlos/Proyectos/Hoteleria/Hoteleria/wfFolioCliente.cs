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
    public partial class wfFolioCliente : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        BindingSource bsServiciosFolio = new BindingSource();
        DataTable dtServiciosFolio = new DataTable();
        DataTable dtDetalle = new DataTable();
        DataTable dtServicios = new DataTable();
        BindingSource bsServicios = new BindingSource();
        private string sCod_flocte = string.Empty;
        private bool bModificarRegistro = false;
        private string sCodigo = string.Empty;

        public string SCod_flocte
        {
            get { return sCod_flocte; }
            set { sCod_flocte = value; }
        }

        public wfFolioCliente()
        {
            InitializeComponent();
        }

        private void wfFolioCliente_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_flocte);
            alDatosEnviados.Add(txtCod_rsva);
            alDatosEnviados.Add(txtEstado_flocte);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Negocio.SNombreTabla = navegador1.sNombreTabla;
            bsServiciosFolio.DataSource = dtServiciosFolio;
            dgvServiciosFolio.DataSource = bsServiciosFolio;
        }

        private void txtCod_flocte_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_flocte.Enabled = false;
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            wfReservacion Reservaciones = new wfReservacion();
            Reservaciones.ShowDialog();
            txtCod_rsva.Text = Reservaciones.SCod_rsva;
        }

        private void txtCod_rsva_EnabledChanged(object sender, EventArgs e)
        {
            dgvServiciosFolio.Enabled = txtCod_rsva.Enabled;
            cboCodigos.Enabled = txtCod_rsva.Enabled;
            txtCantidad.Enabled = txtCod_rsva.Enabled;
            btnAgregar.Enabled = txtCod_rsva.Enabled;
        }

        private void txtCod_rsva_Enter(object sender, EventArgs e)
        {
            wfReservacion Reservaciones = new wfReservacion();
            Reservaciones.ShowDialog();
            txtCod_rsva.Text = Reservaciones.SCod_rsva;
        }

        private void txtCod_rsva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Negocio.vValidarTexto(e, "0123456789.");
        }

        private void vLlenarDgvServiciosFolio()
        {
            dtServiciosFolio = Negocio.dtConsultarRegistros("select * from tabt_feservflocte where cod_flocte = '" + txtCod_flocte.Text + "'");
            if (dtServiciosFolio.Rows.Count != 0)
            {
                dtServiciosFolio.Columns.RemoveAt(0);
                dtServiciosFolio.Columns[0].ColumnName = "Código";
                dtServiciosFolio.Columns[1].ColumnName = "Cantidad";
                dtServiciosFolio.Columns[2].ColumnName = "Total";
                dtServiciosFolio.Columns[3].ColumnName = "Estado";
            }
            else
            {
                dtServiciosFolio.Columns.Add("Código");
                dtServiciosFolio.Columns.Add("Cantidad");
                dtServiciosFolio.Columns.Add("Total");
                dtServiciosFolio.Columns.Add("Estado");
            }
            bsServiciosFolio.DataSource = dtServiciosFolio;
            dgvServiciosFolio.DataSource = bsServiciosFolio;
        }

        private void txtCod_flocte_TextChanged(object sender, EventArgs e)
        {
            SCod_flocte = txtCod_flocte.Text;
            vLlenarDgvServiciosFolio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dtServiciosFolio.Rows.Add(cboCodigos.SelectedValue, txtCantidad.Text, txtTotalAmbiente.Text,"1");
            dgvServiciosFolio.Refresh();
            cboCodigos.SelectedIndex = -1;
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            dtDetalle = dtServiciosFolio;
            if (!Negocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void vLlenarCboServicios() {
            dtServicios = Negocio.dtConsultarRegistros("select cod_serv, servicio_serv, precio_serv from tabm_feservicio where disponibilidad_serv=1 and estado_serv=1 order by servicio_serv asc");
            if (dtServicios.Rows.Count != 0)
            {
                dtServicios.Columns[0].ColumnName = "Codigo";
                dtServicios.Columns[1].ColumnName = "Ambiente";
                dtServicios.Columns[2].ColumnName = "Precio";
                bsServicios.DataSource = dtServicios;
                cboCodigos.DataSource = bsServicios;
                cboCodigos.DisplayMember = "Ambiente";
                cboCodigos.ValueMember = "Codigo";
                cboCodigos.Refresh();
                cboCodigos.SelectedIndex = -1;
            }
        }
        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            bModificarRegistro = true;
            vLlenarCboServicios();
            dgvServiciosFolio.ReadOnly = false;
            dgvServiciosFolio.AllowUserToDeleteRows = false;
            dgvServiciosFolio.Columns[0].ReadOnly = true;
            dgvServiciosFolio.Columns[1].ReadOnly = false;
            dgvServiciosFolio.Columns[2].ReadOnly = false;
            dgvServiciosFolio.Columns[3].ReadOnly = false;
            cboCodigos.Enabled = false;
            txtCantidad.Enabled = false;
            txtTotalAmbiente.Enabled = false;
            btnAgregar.Enabled = false;
        }

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_flocte.Text);
            Negocio.SNombreTabla = "tabt_feservflocte";
            if (bModificarRegistro)
            {
                Negocio.vModificarRegistros(alCodigos, dtDetalle);
                bModificarRegistro = false;
            }
            else
            {
                Negocio.vInsertarRegistros(alCodigos, dtDetalle);
            }
            vLlenarDgvServiciosFolio();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(txtCantidad.Text, string.Empty) != 0)
            {
                float fPrecio = 0;
                foreach (DataRow drFila in dtServicios.Rows)
                {
                    if (string.Compare(cboCodigos.SelectedValue.ToString(), drFila[0].ToString()) == 0)
                    {
                        fPrecio = Convert.ToSingle(drFila[2].ToString());
                    }
                }
                float fTotal = fPrecio * Convert.ToSingle(txtCantidad.Text);
                txtTotalAmbiente.Text = fTotal.ToString();
            }
            else
            {
                txtTotalAmbiente.Text = string.Empty;
            }
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            cboEstado_flocte.SelectedIndex = 0;
            vLlenarCboServicios();
            vLlenarDgvServiciosFolio();
        }

        private void cboCodigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCodigos.SelectedIndex != -1)
            {
                txtCantidad.Text = "1";
            } else
            {
                txtCantidad.Text = string.Empty;
            }
        }

        private void navegador1_btnEliminar_AfterClick(object sender, EventArgs e)
        {
            Negocio.SNombreTabla = "tabt_feservflocte";
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCod_flocte.Text);
            Negocio.vEliminarRegistros(alCodigos, dtServiciosFolio);
            vLlenarDgvServiciosFolio();
        }

        private void txtEstado_flocte_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_flocte.Text)
            {
                case "1": cboEstado_flocte.SelectedIndex = 0; break;
                case "0": cboEstado_flocte.SelectedIndex = 1; break;
                default: cboEstado_flocte.SelectedIndex = -1; break;
            }
        }

        private void cboEstado_flocte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_flocte.SelectedIndex)
            {
                case 0: txtEstado_flocte.Text = "1"; break;
                case 1: txtEstado_flocte.Text = "0"; break;
                default: txtEstado_flocte.Text = string.Empty; break;
            }
        }

        private void txtEstado_flocte_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado_flocte.Enabled = txtEstado_flocte.Enabled;
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            txtCod_flocte.Text = sCodigo;
            cboEstado_flocte.SelectedIndex = 0;
            vLlenarCboServicios();
            vLlenarDgvServiciosFolio();
            txtCantidad.Text = string.Empty;
        }

        private void navegador1_btnLimpiar_BeforeClick(object sender, EventArgs e)
        {
            sCodigo = txtCod_flocte.Text;
        }
    }
}
