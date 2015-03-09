namespace Hoteleria_Inventarios_y_Facturacion
{
    partial class HoteleriaInventariosFacturacion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoteleriaInventariosFacturacion));
            this.ssBarraInferior = new System.Windows.Forms.StatusStrip();
            this.tsslEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHoteleria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAmbientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFoliosDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReservaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTiposDeAmbientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInventarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBodegas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCatalogoDeProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSucursales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImpuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMosaicoVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMosaicoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCerrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyudaWorkshop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.hpAyuda = new System.Windows.Forms.HelpProvider();
            this.ssBarraInferior.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssBarraInferior
            // 
            this.ssBarraInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslEstado});
            this.ssBarraInferior.Location = new System.Drawing.Point(0, 539);
            this.ssBarraInferior.Name = "ssBarraInferior";
            this.ssBarraInferior.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ssBarraInferior.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.ssBarraInferior.Size = new System.Drawing.Size(784, 22);
            this.ssBarraInferior.SizingGrip = false;
            this.ssBarraInferior.TabIndex = 0;
            this.ssBarraInferior.Text = "statusStrip1";
            // 
            // tsslEstado
            // 
            this.tsslEstado.Name = "tsslEstado";
            this.tsslEstado.Size = new System.Drawing.Size(65, 17);
            this.tsslEstado.Text = "Conectado";
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.Control;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiHoteleria,
            this.tsmiInventarios,
            this.tsmiFacturacion,
            this.tsmiVentanas,
            this.tsmiAyuda});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(784, 55);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCerrarSesion,
            this.tsmiSalir});
            this.tsmiArchivo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiArchivo.Image")));
            this.tsmiArchivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmiArchivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(60, 51);
            this.tsmiArchivo.Text = "&Archivo";
            this.tsmiArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCerrarSesion.Image")));
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(152, 22);
            this.tsmiCerrarSesion.Text = "&Cerrar Sesión";
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSalir.Image")));
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(152, 22);
            this.tsmiSalir.Text = "&Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // tsmiHoteleria
            // 
            this.tsmiHoteleria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAmbientes,
            this.tsmiClientes,
            this.tsmiFoliosDeClientes,
            this.tsmiReservaciones,
            this.tsmiServicios,
            this.tsmiTiposDeAmbientes});
            this.tsmiHoteleria.Image = ((System.Drawing.Image)(resources.GetObject("tsmiHoteleria.Image")));
            this.tsmiHoteleria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiHoteleria.Name = "tsmiHoteleria";
            this.tsmiHoteleria.Size = new System.Drawing.Size(67, 51);
            this.tsmiHoteleria.Text = "&Hoteleria";
            this.tsmiHoteleria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiAmbientes
            // 
            this.tsmiAmbientes.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAmbientes.Image")));
            this.tsmiAmbientes.Name = "tsmiAmbientes";
            this.tsmiAmbientes.Size = new System.Drawing.Size(177, 22);
            this.tsmiAmbientes.Text = "&Ambientes";
            this.tsmiAmbientes.Click += new System.EventHandler(this.tsmiAmbientes_Click);
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Image = ((System.Drawing.Image)(resources.GetObject("tsmiClientes.Image")));
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(177, 22);
            this.tsmiClientes.Text = "&Clientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiFoliosDeClientes
            // 
            this.tsmiFoliosDeClientes.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFoliosDeClientes.Image")));
            this.tsmiFoliosDeClientes.Name = "tsmiFoliosDeClientes";
            this.tsmiFoliosDeClientes.Size = new System.Drawing.Size(177, 22);
            this.tsmiFoliosDeClientes.Text = "&Folios de clientes";
            this.tsmiFoliosDeClientes.Click += new System.EventHandler(this.tsmiFoliosDeClientes_Click);
            // 
            // tsmiReservaciones
            // 
            this.tsmiReservaciones.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReservaciones.Image")));
            this.tsmiReservaciones.Name = "tsmiReservaciones";
            this.tsmiReservaciones.Size = new System.Drawing.Size(177, 22);
            this.tsmiReservaciones.Text = "&Reservaciones";
            this.tsmiReservaciones.Click += new System.EventHandler(this.tsmiReservaciones_Click);
            // 
            // tsmiServicios
            // 
            this.tsmiServicios.Image = ((System.Drawing.Image)(resources.GetObject("tsmiServicios.Image")));
            this.tsmiServicios.Name = "tsmiServicios";
            this.tsmiServicios.Size = new System.Drawing.Size(177, 22);
            this.tsmiServicios.Text = "&Servicios";
            this.tsmiServicios.Click += new System.EventHandler(this.tsmiServicios_Click);
            // 
            // tsmiTiposDeAmbientes
            // 
            this.tsmiTiposDeAmbientes.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTiposDeAmbientes.Image")));
            this.tsmiTiposDeAmbientes.Name = "tsmiTiposDeAmbientes";
            this.tsmiTiposDeAmbientes.Size = new System.Drawing.Size(177, 22);
            this.tsmiTiposDeAmbientes.Text = "&Tipos de ambientes";
            this.tsmiTiposDeAmbientes.Click += new System.EventHandler(this.tsmiTiposDeAmbientes_Click);
            // 
            // tsmiInventarios
            // 
            this.tsmiInventarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBodegas,
            this.tsmiCatalogoDeProductos,
            this.tsmiDocumentos,
            this.tsmiSucursales});
            this.tsmiInventarios.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInventarios.Image")));
            this.tsmiInventarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmiInventarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiInventarios.Name = "tsmiInventarios";
            this.tsmiInventarios.Size = new System.Drawing.Size(77, 51);
            this.tsmiInventarios.Text = "&Inventarios";
            this.tsmiInventarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiBodegas
            // 
            this.tsmiBodegas.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBodegas.Image")));
            this.tsmiBodegas.Name = "tsmiBodegas";
            this.tsmiBodegas.Size = new System.Drawing.Size(195, 22);
            this.tsmiBodegas.Text = "&Bodegas";
            this.tsmiBodegas.Click += new System.EventHandler(this.tsmiBodegas_Click);
            // 
            // tsmiCatalogoDeProductos
            // 
            this.tsmiCatalogoDeProductos.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCatalogoDeProductos.Image")));
            this.tsmiCatalogoDeProductos.Name = "tsmiCatalogoDeProductos";
            this.tsmiCatalogoDeProductos.Size = new System.Drawing.Size(195, 22);
            this.tsmiCatalogoDeProductos.Text = "Catálogo de &productos";
            this.tsmiCatalogoDeProductos.Click += new System.EventHandler(this.tsmiCatalogoDeProductos_Click);
            // 
            // tsmiDocumentos
            // 
            this.tsmiDocumentos.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDocumentos.Image")));
            this.tsmiDocumentos.Name = "tsmiDocumentos";
            this.tsmiDocumentos.Size = new System.Drawing.Size(195, 22);
            this.tsmiDocumentos.Text = "&Documentos";
            this.tsmiDocumentos.Click += new System.EventHandler(this.tsmiDocumentos_Click);
            // 
            // tsmiSucursales
            // 
            this.tsmiSucursales.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSucursales.Image")));
            this.tsmiSucursales.Name = "tsmiSucursales";
            this.tsmiSucursales.Size = new System.Drawing.Size(195, 22);
            this.tsmiSucursales.Text = "&Sucursales";
            this.tsmiSucursales.Click += new System.EventHandler(this.tsmiSucursales_Click);
            // 
            // tsmiFacturacion
            // 
            this.tsmiFacturacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmpresa,
            this.tsmiFacturas,
            this.tsmiImpuestos,
            this.tsmiSeries});
            this.tsmiFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFacturacion.Image")));
            this.tsmiFacturacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiFacturacion.Name = "tsmiFacturacion";
            this.tsmiFacturacion.Size = new System.Drawing.Size(81, 51);
            this.tsmiFacturacion.Text = "&Facturación";
            this.tsmiFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiEmpresa
            // 
            this.tsmiEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEmpresa.Image")));
            this.tsmiEmpresa.Name = "tsmiEmpresa";
            this.tsmiEmpresa.Size = new System.Drawing.Size(129, 22);
            this.tsmiEmpresa.Text = "&Empresa";
            this.tsmiEmpresa.Click += new System.EventHandler(this.tsmiEmpresa_Click);
            // 
            // tsmiFacturas
            // 
            this.tsmiFacturas.Image = ((System.Drawing.Image)(resources.GetObject("tsmiFacturas.Image")));
            this.tsmiFacturas.Name = "tsmiFacturas";
            this.tsmiFacturas.Size = new System.Drawing.Size(129, 22);
            this.tsmiFacturas.Text = "&Facturas";
            this.tsmiFacturas.Click += new System.EventHandler(this.tsmiFacturas_Click);
            // 
            // tsmiImpuestos
            // 
            this.tsmiImpuestos.Image = ((System.Drawing.Image)(resources.GetObject("tsmiImpuestos.Image")));
            this.tsmiImpuestos.Name = "tsmiImpuestos";
            this.tsmiImpuestos.Size = new System.Drawing.Size(129, 22);
            this.tsmiImpuestos.Text = "&Impuestos";
            this.tsmiImpuestos.Click += new System.EventHandler(this.tsmiImpuestos_Click);
            // 
            // tsmiSeries
            // 
            this.tsmiSeries.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSeries.Image")));
            this.tsmiSeries.Name = "tsmiSeries";
            this.tsmiSeries.Size = new System.Drawing.Size(129, 22);
            this.tsmiSeries.Text = "&Series";
            this.tsmiSeries.Click += new System.EventHandler(this.tsmiSeries_Click);
            // 
            // tsmiVentanas
            // 
            this.tsmiVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCascada,
            this.tsmiMosaicoVertical,
            this.tsmiMosaicoHorizontal,
            this.tssSeparador,
            this.tsmiCerrarTodo});
            this.tsmiVentanas.Image = ((System.Drawing.Image)(resources.GetObject("tsmiVentanas.Image")));
            this.tsmiVentanas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiVentanas.Name = "tsmiVentanas";
            this.tsmiVentanas.Size = new System.Drawing.Size(67, 51);
            this.tsmiVentanas.Text = "&Ventanas";
            this.tsmiVentanas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiCascada
            // 
            this.tsmiCascada.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCascada.Image")));
            this.tsmiCascada.Name = "tsmiCascada";
            this.tsmiCascada.Size = new System.Drawing.Size(175, 22);
            this.tsmiCascada.Text = "&Cascada";
            this.tsmiCascada.Click += new System.EventHandler(this.tsmiCascada_Click);
            // 
            // tsmiMosaicoVertical
            // 
            this.tsmiMosaicoVertical.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMosaicoVertical.Image")));
            this.tsmiMosaicoVertical.Name = "tsmiMosaicoVertical";
            this.tsmiMosaicoVertical.Size = new System.Drawing.Size(175, 22);
            this.tsmiMosaicoVertical.Text = "Mosaico &vertical";
            this.tsmiMosaicoVertical.Click += new System.EventHandler(this.tsmiMosaicoVertical_Click);
            // 
            // tsmiMosaicoHorizontal
            // 
            this.tsmiMosaicoHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMosaicoHorizontal.Image")));
            this.tsmiMosaicoHorizontal.Name = "tsmiMosaicoHorizontal";
            this.tsmiMosaicoHorizontal.Size = new System.Drawing.Size(175, 22);
            this.tsmiMosaicoHorizontal.Text = "Mosaico &horizontal";
            this.tsmiMosaicoHorizontal.Click += new System.EventHandler(this.tsmiMosaicoHorizontal_Click);
            // 
            // tssSeparador
            // 
            this.tssSeparador.Name = "tssSeparador";
            this.tssSeparador.Size = new System.Drawing.Size(172, 6);
            // 
            // tsmiCerrarTodo
            // 
            this.tsmiCerrarTodo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCerrarTodo.Image")));
            this.tsmiCerrarTodo.Name = "tsmiCerrarTodo";
            this.tsmiCerrarTodo.Size = new System.Drawing.Size(175, 22);
            this.tsmiCerrarTodo.Text = "C&errar todo";
            this.tsmiCerrarTodo.Click += new System.EventHandler(this.tsmiCerrarTodo_Click);
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAyudaWorkshop,
            this.tsmiAcercaDe});
            this.tsmiAyuda.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAyuda.Image")));
            this.tsmiAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(53, 51);
            this.tsmiAyuda.Text = "&Ayuda";
            this.tsmiAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiAyudaWorkshop
            // 
            this.tsmiAyudaWorkshop.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAyudaWorkshop.Image")));
            this.tsmiAyudaWorkshop.Name = "tsmiAyudaWorkshop";
            this.tsmiAyudaWorkshop.Size = new System.Drawing.Size(147, 22);
            this.tsmiAyudaWorkshop.Text = "Ayuda HIF";
            this.tsmiAyudaWorkshop.Click += new System.EventHandler(this.tsmiAyudaWorkshop_Click);
            // 
            // tsmiAcercaDe
            // 
            this.tsmiAcercaDe.Name = "tsmiAcercaDe";
            this.tsmiAcercaDe.Size = new System.Drawing.Size(147, 22);
            this.tsmiAcercaDe.Text = "&Acerca de HIF";
            this.tsmiAcercaDe.Click += new System.EventHandler(this.tsmiAcercaDe_Click);
            // 
            // hpAyuda
            // 
            this.hpAyuda.HelpNamespace = "AyudaHIF.chm";
            // 
            // HoteleriaInventariosFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ssBarraInferior);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "HoteleriaInventariosFacturacion";
            this.hpAyuda.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoteleria, Inventarios y Facturación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoteleriaInventariosFacturacion_FormClosing);
            this.Load += new System.EventHandler(this.HoteleriaInventariosFacturacion_Load);
            this.ssBarraInferior.ResumeLayout(false);
            this.ssBarraInferior.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssBarraInferior;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoteleria;
        private System.Windows.Forms.ToolStripMenuItem tsmiInventarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiFacturacion;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmiAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem tsmiAmbientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiFoliosDeClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiReservaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiServicios;
        private System.Windows.Forms.ToolStripMenuItem tsmiTiposDeAmbientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiBodegas;
        private System.Windows.Forms.ToolStripMenuItem tsmiCatalogoDeProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmiDocumentos;
        private System.Windows.Forms.ToolStripMenuItem tsmiSucursales;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmpresa;
        private System.Windows.Forms.ToolStripMenuItem tsmiFacturas;
        private System.Windows.Forms.ToolStripMenuItem tsmiImpuestos;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeries;
        private System.Windows.Forms.ToolStripMenuItem tsmiVentanas;
        private System.Windows.Forms.ToolStripMenuItem tsmiMosaicoVertical;
        private System.Windows.Forms.ToolStripMenuItem tsmiMosaicoHorizontal;
        private System.Windows.Forms.ToolStripMenuItem tsmiCascada;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarTodo;
        private System.Windows.Forms.ToolStripSeparator tssSeparador;
        private System.Windows.Forms.ToolStripStatusLabel tsslEstado;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyudaWorkshop;
        private System.Windows.Forms.HelpProvider hpAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
    }
}

