namespace Inventario
{
    partial class wfDocumentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfDocumentos));
            this.navegador1 = new Navegador.Navegador();
            this.txtCod_docs = new System.Windows.Forms.TextBox();
            this.lbCodEmpresa = new System.Windows.Forms.Label();
            this.lbCodDocs = new System.Windows.Forms.Label();
            this.txtCod_suc = new System.Windows.Forms.TextBox();
            this.txtCod_srie = new System.Windows.Forms.TextBox();
            this.lbCodSucursal = new System.Windows.Forms.Label();
            this.lbCodSrie = new System.Windows.Forms.Label();
            this.txtTotal_docs = new System.Windows.Forms.TextBox();
            this.lbTotalDocs = new System.Windows.Forms.Label();
            this.lbFechEntradaInv = new System.Windows.Forms.Label();
            this.lbCodTransaccion = new System.Windows.Forms.Label();
            this.cboEstado_docs = new System.Windows.Forms.ComboBox();
            this.txtEstado_docs = new System.Windows.Forms.TextBox();
            this.lbEstadoDocs = new System.Windows.Forms.Label();
            this.txtCod_empsa = new System.Windows.Forms.TextBox();
            this.txtCod_ttrans = new System.Windows.Forms.TextBox();
            this.dtpFechent_inv = new System.Windows.Forms.DateTimePicker();
            this.txtFechent_inv = new System.Windows.Forms.TextBox();
            this.lblCat_prod = new System.Windows.Forms.Label();
            this.cboCodigosCat = new System.Windows.Forms.ComboBox();
            this.cboCodigoBodega = new System.Windows.Forms.ComboBox();
            this.lblBodega = new System.Windows.Forms.Label();
            this.txtPrecioc = new System.Windows.Forms.TextBox();
            this.lblPrecioc = new System.Windows.Forms.Label();
            this.txtPreciov = new System.Windows.Forms.TextBox();
            this.lblPreciov = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDocumentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_fedocumentos";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.btnEliminar_AfterClick += new System.EventHandler(this.navegador1_btnEliminar_AfterClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            this.navegador1.btnImprimir_AfterClick += new System.EventHandler(this.navegador1_btnImprimir_AfterClick);
            // 
            // txtCod_docs
            // 
            this.txtCod_docs.Location = new System.Drawing.Point(121, 80);
            this.txtCod_docs.MaxLength = 4;
            this.txtCod_docs.Name = "txtCod_docs";
            this.txtCod_docs.Size = new System.Drawing.Size(150, 21);
            this.txtCod_docs.TabIndex = 12;
            this.txtCod_docs.Tag = "cod_docs";
            this.txtCod_docs.EnabledChanged += new System.EventHandler(this.txtCod_docs_EnabledChanged);
            this.txtCod_docs.TextChanged += new System.EventHandler(this.txtCodDocs_TextChanged);
            this.txtCod_docs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_docs_KeyPress);
            // 
            // lbCodEmpresa
            // 
            this.lbCodEmpresa.AutoSize = true;
            this.lbCodEmpresa.Location = new System.Drawing.Point(339, 83);
            this.lbCodEmpresa.Name = "lbCodEmpresa";
            this.lbCodEmpresa.Size = new System.Drawing.Size(115, 15);
            this.lbCodEmpresa.TabIndex = 31;
            this.lbCodEmpresa.Text = "Código de empresa";
            // 
            // lbCodDocs
            // 
            this.lbCodDocs.AutoSize = true;
            this.lbCodDocs.Location = new System.Drawing.Point(12, 83);
            this.lbCodDocs.Name = "lbCodDocs";
            this.lbCodDocs.Size = new System.Drawing.Size(49, 15);
            this.lbCodDocs.TabIndex = 30;
            this.lbCodDocs.Text = "Código ";
            // 
            // txtCod_suc
            // 
            this.txtCod_suc.Location = new System.Drawing.Point(460, 107);
            this.txtCod_suc.MaxLength = 4;
            this.txtCod_suc.Name = "txtCod_suc";
            this.txtCod_suc.Size = new System.Drawing.Size(150, 21);
            this.txtCod_suc.TabIndex = 15;
            this.txtCod_suc.Tag = "cod_suc";
            this.txtCod_suc.Enter += new System.EventHandler(this.txtCod_suc_Enter);
            this.txtCod_suc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_suc_KeyPress);
            // 
            // txtCod_srie
            // 
            this.txtCod_srie.Location = new System.Drawing.Point(121, 107);
            this.txtCod_srie.MaxLength = 4;
            this.txtCod_srie.Name = "txtCod_srie";
            this.txtCod_srie.Size = new System.Drawing.Size(150, 21);
            this.txtCod_srie.TabIndex = 14;
            this.txtCod_srie.Tag = "cod_srie";
            this.txtCod_srie.Enter += new System.EventHandler(this.txtCod_srie_Enter);
            this.txtCod_srie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_srie_KeyPress);
            // 
            // lbCodSucursal
            // 
            this.lbCodSucursal.AutoSize = true;
            this.lbCodSucursal.Location = new System.Drawing.Point(339, 110);
            this.lbCodSucursal.Name = "lbCodSucursal";
            this.lbCodSucursal.Size = new System.Drawing.Size(112, 15);
            this.lbCodSucursal.TabIndex = 33;
            this.lbCodSucursal.Text = "Código de sucursal";
            // 
            // lbCodSrie
            // 
            this.lbCodSrie.AutoSize = true;
            this.lbCodSrie.Location = new System.Drawing.Point(12, 110);
            this.lbCodSrie.Name = "lbCodSrie";
            this.lbCodSrie.Size = new System.Drawing.Size(93, 15);
            this.lbCodSrie.TabIndex = 32;
            this.lbCodSrie.Text = "Código de serie";
            // 
            // txtTotal_docs
            // 
            this.txtTotal_docs.Location = new System.Drawing.Point(460, 163);
            this.txtTotal_docs.MaxLength = 25;
            this.txtTotal_docs.Name = "txtTotal_docs";
            this.txtTotal_docs.Size = new System.Drawing.Size(150, 21);
            this.txtTotal_docs.TabIndex = 18;
            this.txtTotal_docs.Tag = "total_docs";
            this.txtTotal_docs.EnabledChanged += new System.EventHandler(this.txtTotal_docs_EnabledChanged);
            this.txtTotal_docs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_docs_KeyPress);
            // 
            // lbTotalDocs
            // 
            this.lbTotalDocs.AutoSize = true;
            this.lbTotalDocs.Location = new System.Drawing.Point(339, 166);
            this.lbTotalDocs.Name = "lbTotalDocs";
            this.lbTotalDocs.Size = new System.Drawing.Size(34, 15);
            this.lbTotalDocs.TabIndex = 36;
            this.lbTotalDocs.Text = "Total";
            // 
            // lbFechEntradaInv
            // 
            this.lbFechEntradaInv.AutoSize = true;
            this.lbFechEntradaInv.Location = new System.Drawing.Point(12, 166);
            this.lbFechEntradaInv.Name = "lbFechEntradaInv";
            this.lbFechEntradaInv.Size = new System.Drawing.Size(103, 15);
            this.lbFechEntradaInv.TabIndex = 35;
            this.lbFechEntradaInv.Text = "Fecha de entrada";
            // 
            // lbCodTransaccion
            // 
            this.lbCodTransaccion.AutoSize = true;
            this.lbCodTransaccion.Location = new System.Drawing.Point(12, 137);
            this.lbCodTransaccion.Name = "lbCodTransaccion";
            this.lbCodTransaccion.Size = new System.Drawing.Size(96, 15);
            this.lbCodTransaccion.TabIndex = 34;
            this.lbCodTransaccion.Text = "Código de trans.";
            // 
            // cboEstado_docs
            // 
            this.cboEstado_docs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_docs.FormattingEnabled = true;
            this.cboEstado_docs.IntegralHeight = false;
            this.cboEstado_docs.ItemHeight = 15;
            this.cboEstado_docs.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cboEstado_docs.Location = new System.Drawing.Point(121, 188);
            this.cboEstado_docs.Name = "cboEstado_docs";
            this.cboEstado_docs.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_docs.TabIndex = 19;
            this.cboEstado_docs.SelectedIndexChanged += new System.EventHandler(this.cboEstadoDocs_SelectedIndexChanged);
            // 
            // txtEstado_docs
            // 
            this.txtEstado_docs.Location = new System.Drawing.Point(277, 190);
            this.txtEstado_docs.MaxLength = 1;
            this.txtEstado_docs.Name = "txtEstado_docs";
            this.txtEstado_docs.Size = new System.Drawing.Size(21, 21);
            this.txtEstado_docs.TabIndex = 33;
            this.txtEstado_docs.Tag = "estado_docs";
            this.txtEstado_docs.Visible = false;
            this.txtEstado_docs.EnabledChanged += new System.EventHandler(this.txtEstado_docs_EnabledChanged);
            this.txtEstado_docs.TextChanged += new System.EventHandler(this.txtEstadoDocs_TextChanged);
            // 
            // lbEstadoDocs
            // 
            this.lbEstadoDocs.AutoSize = true;
            this.lbEstadoDocs.Location = new System.Drawing.Point(12, 193);
            this.lbEstadoDocs.Name = "lbEstadoDocs";
            this.lbEstadoDocs.Size = new System.Drawing.Size(45, 15);
            this.lbEstadoDocs.TabIndex = 37;
            this.lbEstadoDocs.Text = "Estado";
            // 
            // txtCod_empsa
            // 
            this.txtCod_empsa.Location = new System.Drawing.Point(460, 80);
            this.txtCod_empsa.MaxLength = 4;
            this.txtCod_empsa.Name = "txtCod_empsa";
            this.txtCod_empsa.Size = new System.Drawing.Size(150, 21);
            this.txtCod_empsa.TabIndex = 13;
            this.txtCod_empsa.Tag = "cod_empsa";
            this.txtCod_empsa.EnabledChanged += new System.EventHandler(this.txtCod_empsa_EnabledChanged);
            this.txtCod_empsa.Enter += new System.EventHandler(this.txtCod_empsa_Enter);
            this.txtCod_empsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_empsa_KeyPress);
            // 
            // txtCod_ttrans
            // 
            this.txtCod_ttrans.Location = new System.Drawing.Point(121, 134);
            this.txtCod_ttrans.MaxLength = 4;
            this.txtCod_ttrans.Name = "txtCod_ttrans";
            this.txtCod_ttrans.Size = new System.Drawing.Size(150, 21);
            this.txtCod_ttrans.TabIndex = 16;
            this.txtCod_ttrans.Tag = "cod_ttrans";
            this.txtCod_ttrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_ttrans_KeyPress);
            // 
            // dtpFechent_inv
            // 
            this.dtpFechent_inv.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpFechent_inv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechent_inv.Location = new System.Drawing.Point(121, 161);
            this.dtpFechent_inv.Name = "dtpFechent_inv";
            this.dtpFechent_inv.Size = new System.Drawing.Size(150, 21);
            this.dtpFechent_inv.TabIndex = 17;
            this.dtpFechent_inv.Tag = "";
            this.dtpFechent_inv.ValueChanged += new System.EventHandler(this.dtpFechent_inv_ValueChanged);
            // 
            // txtFechent_inv
            // 
            this.txtFechent_inv.Location = new System.Drawing.Point(277, 163);
            this.txtFechent_inv.MaxLength = 1;
            this.txtFechent_inv.Name = "txtFechent_inv";
            this.txtFechent_inv.Size = new System.Drawing.Size(21, 21);
            this.txtFechent_inv.TabIndex = 39;
            this.txtFechent_inv.Tag = "fechent_inv";
            this.txtFechent_inv.Visible = false;
            this.txtFechent_inv.EnabledChanged += new System.EventHandler(this.txtFechent_inv_EnabledChanged);
            this.txtFechent_inv.TextChanged += new System.EventHandler(this.txtFechent_inv_TextChanged);
            // 
            // lblCat_prod
            // 
            this.lblCat_prod.AutoSize = true;
            this.lblCat_prod.Location = new System.Drawing.Point(374, 233);
            this.lblCat_prod.Name = "lblCat_prod";
            this.lblCat_prod.Size = new System.Drawing.Size(80, 15);
            this.lblCat_prod.TabIndex = 42;
            this.lblCat_prod.Text = "Cat. Producto";
            // 
            // cboCodigosCat
            // 
            this.cboCodigosCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigosCat.FormattingEnabled = true;
            this.cboCodigosCat.IntegralHeight = false;
            this.cboCodigosCat.ItemHeight = 15;
            this.cboCodigosCat.Location = new System.Drawing.Point(460, 230);
            this.cboCodigosCat.Name = "cboCodigosCat";
            this.cboCodigosCat.Size = new System.Drawing.Size(150, 23);
            this.cboCodigosCat.TabIndex = 20;
            this.cboCodigosCat.Tag = "cod_catprod";
            // 
            // cboCodigoBodega
            // 
            this.cboCodigoBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoBodega.FormattingEnabled = true;
            this.cboCodigoBodega.IntegralHeight = false;
            this.cboCodigoBodega.ItemHeight = 15;
            this.cboCodigoBodega.Location = new System.Drawing.Point(460, 259);
            this.cboCodigoBodega.Name = "cboCodigoBodega";
            this.cboCodigoBodega.Size = new System.Drawing.Size(150, 23);
            this.cboCodigoBodega.TabIndex = 21;
            this.cboCodigoBodega.Tag = "cod_bga";
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.Location = new System.Drawing.Point(374, 262);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(56, 15);
            this.lblBodega.TabIndex = 44;
            this.lblBodega.Text = "Bodegas";
            // 
            // txtPrecioc
            // 
            this.txtPrecioc.Location = new System.Drawing.Point(460, 288);
            this.txtPrecioc.MaxLength = 10;
            this.txtPrecioc.Name = "txtPrecioc";
            this.txtPrecioc.Size = new System.Drawing.Size(150, 21);
            this.txtPrecioc.TabIndex = 22;
            this.txtPrecioc.Tag = "precioc_ddocs";
            this.txtPrecioc.TextChanged += new System.EventHandler(this.txtPrecioc_TextChanged);
            this.txtPrecioc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioc_KeyPress);
            // 
            // lblPrecioc
            // 
            this.lblPrecioc.AutoSize = true;
            this.lblPrecioc.Location = new System.Drawing.Point(374, 291);
            this.lblPrecioc.Name = "lblPrecioc";
            this.lblPrecioc.Size = new System.Drawing.Size(65, 15);
            this.lblPrecioc.TabIndex = 47;
            this.lblPrecioc.Text = "P. Compra";
            // 
            // txtPreciov
            // 
            this.txtPreciov.Location = new System.Drawing.Point(460, 315);
            this.txtPreciov.MaxLength = 10;
            this.txtPreciov.Name = "txtPreciov";
            this.txtPreciov.Size = new System.Drawing.Size(150, 21);
            this.txtPreciov.TabIndex = 23;
            this.txtPreciov.Tag = "preciov_ddocs";
            this.txtPreciov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreciov_KeyPress);
            // 
            // lblPreciov
            // 
            this.lblPreciov.AutoSize = true;
            this.lblPreciov.Location = new System.Drawing.Point(374, 318);
            this.lblPreciov.Name = "lblPreciov";
            this.lblPreciov.Size = new System.Drawing.Size(52, 15);
            this.lblPreciov.TabIndex = 49;
            this.lblPreciov.Text = "P. Venta";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(460, 342);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 21);
            this.txtCantidad.TabIndex = 24;
            this.txtCantidad.Tag = "cant_ddocs";
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(374, 345);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 51;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(460, 369);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(150, 21);
            this.txtValor.TabIndex = 25;
            this.txtValor.Tag = "valor_ddocs";
            this.txtValor.EnabledChanged += new System.EventHandler(this.txtValor_EnabledChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(374, 372);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(35, 15);
            this.lblValor.TabIndex = 53;
            this.lblValor.Text = "Valor";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(377, 396);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(233, 23);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar Documento";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.AllowUserToResizeColumns = false;
            this.dgvDocumentos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Location = new System.Drawing.Point(12, 230);
            this.dgvDocumentos.MultiSelect = false;
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.ReadOnly = true;
            this.dgvDocumentos.RowHeadersVisible = false;
            this.dgvDocumentos.RowHeadersWidth = 30;
            this.dgvDocumentos.RowTemplate.Height = 20;
            this.dgvDocumentos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocumentos.Size = new System.Drawing.Size(356, 170);
            this.dgvDocumentos.TabIndex = 55;
            this.dgvDocumentos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDocumentos_RowsAdded);
            this.dgvDocumentos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDocumentos_RowsRemoved);
            // 
            // wfDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 426);
            this.Controls.Add(this.dgvDocumentos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtPreciov);
            this.Controls.Add(this.lblPreciov);
            this.Controls.Add(this.txtPrecioc);
            this.Controls.Add(this.lblPrecioc);
            this.Controls.Add(this.cboCodigoBodega);
            this.Controls.Add(this.lblBodega);
            this.Controls.Add(this.cboCodigosCat);
            this.Controls.Add(this.lblCat_prod);
            this.Controls.Add(this.txtFechent_inv);
            this.Controls.Add(this.dtpFechent_inv);
            this.Controls.Add(this.txtCod_ttrans);
            this.Controls.Add(this.txtCod_empsa);
            this.Controls.Add(this.cboEstado_docs);
            this.Controls.Add(this.txtEstado_docs);
            this.Controls.Add(this.lbEstadoDocs);
            this.Controls.Add(this.txtTotal_docs);
            this.Controls.Add(this.lbTotalDocs);
            this.Controls.Add(this.lbFechEntradaInv);
            this.Controls.Add(this.lbCodTransaccion);
            this.Controls.Add(this.txtCod_suc);
            this.Controls.Add(this.txtCod_srie);
            this.Controls.Add(this.lbCodSucursal);
            this.Controls.Add(this.lbCodSrie);
            this.Controls.Add(this.txtCod_docs);
            this.Controls.Add(this.lbCodEmpresa);
            this.Controls.Add(this.lbCodDocs);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfDocumentos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos";
            this.Load += new System.EventHandler(this.wfDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtCod_docs;
        private System.Windows.Forms.Label lbCodEmpresa;
        private System.Windows.Forms.Label lbCodDocs;
        private System.Windows.Forms.TextBox txtCod_suc;
        private System.Windows.Forms.TextBox txtCod_srie;
        private System.Windows.Forms.Label lbCodSucursal;
        private System.Windows.Forms.Label lbCodSrie;
        private System.Windows.Forms.TextBox txtTotal_docs;
        private System.Windows.Forms.Label lbTotalDocs;
        private System.Windows.Forms.Label lbFechEntradaInv;
        private System.Windows.Forms.Label lbCodTransaccion;
        private System.Windows.Forms.ComboBox cboEstado_docs;
        private System.Windows.Forms.TextBox txtEstado_docs;
        private System.Windows.Forms.Label lbEstadoDocs;
        private System.Windows.Forms.TextBox txtCod_empsa;
        private System.Windows.Forms.TextBox txtCod_ttrans;
        private System.Windows.Forms.DateTimePicker dtpFechent_inv;
        private System.Windows.Forms.TextBox txtFechent_inv;
        private System.Windows.Forms.Label lblCat_prod;
        private System.Windows.Forms.ComboBox cboCodigosCat;
        private System.Windows.Forms.ComboBox cboCodigoBodega;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.TextBox txtPrecioc;
        private System.Windows.Forms.Label lblPrecioc;
        private System.Windows.Forms.TextBox txtPreciov;
        private System.Windows.Forms.Label lblPreciov;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDocumentos;
    }
}