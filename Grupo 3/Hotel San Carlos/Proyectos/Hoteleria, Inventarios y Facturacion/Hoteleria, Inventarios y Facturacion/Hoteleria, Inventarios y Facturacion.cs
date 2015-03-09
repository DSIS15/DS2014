using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_de_Seguridad_3._0.Negocio;

namespace Hoteleria_Inventarios_y_Facturacion
{
    public partial class HoteleriaInventariosFacturacion : Form
    {
        wfLogoHSC Logotipo = new wfLogoHSC();
        N_ControlesUsuario cerrar_sesion = new N_ControlesUsuario();
           
        public HoteleriaInventariosFacturacion()
        {
            InitializeComponent();
        }

        private void HoteleriaInventariosFacturacion_Load(object sender, EventArgs e)
        {
            Logotipo.MdiParent = this;
            Logotipo.Dock = DockStyle.Fill;
            Logotipo.Show();
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            cerrar_sesion.vSalirSesion();
        }

        private void tsmiAmbientes_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfAmbiente").SingleOrDefault();
            if (fmValidacion == null)
            {
                Hoteleria.wfAmbiente Ambientes = new Hoteleria.wfAmbiente();
                Ambientes.MdiParent = this;
                Ambientes.Show();
            }
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfCliente").SingleOrDefault();
            if (fmValidacion == null)
            {
                Hoteleria.wfCliente Clientes = new Hoteleria.wfCliente();
                Clientes.MdiParent = this;
                Clientes.Show();
            }
        }

        private void tsmiFoliosDeClientes_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfFolioCliente").SingleOrDefault();
            if (fmValidacion == null)
            {
                Hoteleria.wfFolioCliente FoliosDeClientes = new Hoteleria.wfFolioCliente();
                FoliosDeClientes.MdiParent = this;
                FoliosDeClientes.Show();
            }
        }

        private void tsmiReservaciones_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfReservacion").SingleOrDefault();
            if (fmValidacion == null)
            {
                Hoteleria.wfReservacion Reservaciones = new Hoteleria.wfReservacion();
                Reservaciones.MdiParent = this;
                Reservaciones.Show();
            }
        }

        private void tsmiServicios_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfServicio").SingleOrDefault();
            if (fmValidacion == null)
            {
                Hoteleria.wfServicio Servicios = new Hoteleria.wfServicio();
                Servicios.MdiParent = this;
                Servicios.Show();
            }
        }

        private void tsmiTiposDeAmbientes_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfTipoAmbiente").SingleOrDefault();
            if (fmValidacion == null)
            {
                Hoteleria.wfTipoAmbiente TiposDeAmbientes = new Hoteleria.wfTipoAmbiente();
                TiposDeAmbientes.MdiParent = this;
                TiposDeAmbientes.Show();
            }
        }

        private void tsmiBodegas_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfBodega").SingleOrDefault();
            if (fmValidacion == null)
            {
                Inventario.wfBodega Bodegas = new Inventario.wfBodega();
                Bodegas.MdiParent = this;
                Bodegas.Show();
            }
        }

        private void tsmiDocumentos_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfDocumentos").SingleOrDefault();
            if (fmValidacion == null)
            {
                Inventario.wfDocumentos Documentos = new Inventario.wfDocumentos();
                Documentos.MdiParent = this;
                Documentos.Show();
            }
        }

        private void tsmiSucursales_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfSucursal").SingleOrDefault();
            if (fmValidacion == null)
            {
                Inventario.wfSucursal Sucursales = new Inventario.wfSucursal();
                Sucursales.MdiParent = this;
                Sucursales.Show();
            }
        }

        private void tsmiEmpresa_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfEmpresa").SingleOrDefault();
            if (fmValidacion == null)
            {
                Facturacion.wfEmpresa Empresa = new Facturacion.wfEmpresa();
                Empresa.MdiParent = this;
                Empresa.Show();
            }
        }

        private void tsmiFacturas_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfFactura").SingleOrDefault();
            if (fmValidacion == null)
            {
                Facturacion.wfFactura Facturas = new Facturacion.wfFactura();
                Facturas.MdiParent = this;
                Facturas.Show();
            }
        }

        private void tsmiImpuestos_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfImpuesto").SingleOrDefault();
            if (fmValidacion == null)
            {
                Facturacion.wfImpuesto Impuestos = new Facturacion.wfImpuesto();
                Impuestos.MdiParent = this;
                Impuestos.Show();
            }
        }

        private void tsmiSeries_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfSerie").SingleOrDefault();
            if (fmValidacion == null)
            {
                Facturacion.wfSerie Series = new Facturacion.wfSerie();
                Series.MdiParent = this;
                Series.Show();
            }
        }

        private void tsmiCascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiMosaicoVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tsmiMosaicoHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiCerrarTodo_Click(object sender, EventArgs e)
        {
            foreach (Form fmFormularioHijo in MdiChildren)
            {
                if (string.Compare(fmFormularioHijo.Text, "wfLohoHSC") != 0)
                {
                    fmFormularioHijo.Close();
                }
            }
        }

        private void tsmiAcercaDe_Click(object sender, EventArgs e)
        {
            wfAcercaDe AcercaDe = new wfAcercaDe();
            AcercaDe.ShowDialog();
        }

        private void tsmiCatalogoDeProductos_Click(object sender, EventArgs e)
        {
            Form fmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "wfCatalogoProducto").SingleOrDefault();
            if (fmValidacion == null)
            {
                Inventario.wfCatalogoProducto CatalogoDeProductos = new Inventario.wfCatalogoProducto();
                CatalogoDeProductos.MdiParent = this;
                CatalogoDeProductos.Show();
            }
        }

        private void tsmiAyudaWorkshop_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,hpAyuda.HelpNamespace);
        }

        private void tsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            cerrar_sesion.vCerrarSesion();
        }

        private void HoteleriaInventariosFacturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrar_sesion.vSalirSesion();
        }
    }
}
