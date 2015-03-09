namespace Facturacion
{
    partial class wfFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfFactura));
            this.txtCod_fra = new System.Windows.Forms.TextBox();
            this.txtFechaemitida_fra = new System.Windows.Forms.TextBox();
            this.txtValor_fra = new System.Windows.Forms.TextBox();
            this.txtImpuesto_fra = new System.Windows.Forms.TextBox();
            this.txtTotal_fra = new System.Windows.Forms.TextBox();
            this.lblCod_fra = new System.Windows.Forms.Label();
            this.dtpFechemitida_fra = new System.Windows.Forms.DateTimePicker();
            this.lblCod_srie = new System.Windows.Forms.Label();
            this.lblCod_suc = new System.Windows.Forms.Label();
            this.lblCod_empsa = new System.Windows.Forms.Label();
            this.lblCod_flocte = new System.Windows.Forms.Label();
            this.lblFechemitida_fra = new System.Windows.Forms.Label();
            this.lblValor_fra = new System.Windows.Forms.Label();
            this.lblImpuesto_fra = new System.Windows.Forms.Label();
            this.lblTotal_fra = new System.Windows.Forms.Label();
            this.txtCod_srie = new System.Windows.Forms.TextBox();
            this.txtCod_suc = new System.Windows.Forms.TextBox();
            this.txtCod_empsa = new System.Windows.Forms.TextBox();
            this.txtCod_flocte = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.btnGenerarDetalle = new System.Windows.Forms.Button();
            this.dgvDetalleImpuesto = new System.Windows.Forms.DataGridView();
            this.cboSeleccionarImp = new System.Windows.Forms.ComboBox();
            this.btnAgregarImp = new System.Windows.Forms.Button();
            this.txtTotalImp = new System.Windows.Forms.TextBox();
            this.lblTotalImp = new System.Windows.Forms.Label();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstado_fra = new System.Windows.Forms.Label();
            this.cboEstado_fra = new System.Windows.Forms.ComboBox();
            this.txtEstado_fra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleImpuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCod_fra
            // 
            this.txtCod_fra.Location = new System.Drawing.Point(146, 80);
            this.txtCod_fra.MaxLength = 4;
            this.txtCod_fra.Name = "txtCod_fra";
            this.txtCod_fra.Size = new System.Drawing.Size(150, 21);
            this.txtCod_fra.TabIndex = 12;
            this.txtCod_fra.Tag = "cod_fra";
            this.txtCod_fra.EnabledChanged += new System.EventHandler(this.txtCod_fra_EnabledChanged);
            this.txtCod_fra.TextChanged += new System.EventHandler(this.txtCod_fra_TextChanged);
            // 
            // txtFechaemitida_fra
            // 
            this.txtFechaemitida_fra.Location = new System.Drawing.Point(311, 136);
            this.txtFechaemitida_fra.Name = "txtFechaemitida_fra";
            this.txtFechaemitida_fra.Size = new System.Drawing.Size(23, 21);
            this.txtFechaemitida_fra.TabIndex = 5;
            this.txtFechaemitida_fra.Tag = "fechemitida_fra";
            this.txtFechaemitida_fra.Visible = false;
            this.txtFechaemitida_fra.EnabledChanged += new System.EventHandler(this.txtFechaemitida_fra_EnabledChanged);
            this.txtFechaemitida_fra.TextChanged += new System.EventHandler(this.txtFechaemitida_fra_TextChanged);
            // 
            // txtValor_fra
            // 
            this.txtValor_fra.Enabled = false;
            this.txtValor_fra.Location = new System.Drawing.Point(146, 161);
            this.txtValor_fra.MaxLength = 10;
            this.txtValor_fra.Name = "txtValor_fra";
            this.txtValor_fra.Size = new System.Drawing.Size(150, 21);
            this.txtValor_fra.TabIndex = 18;
            this.txtValor_fra.Tag = "valor_fra";
            this.txtValor_fra.EnabledChanged += new System.EventHandler(this.txtValor_fra_EnabledChanged);
            this.txtValor_fra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_fra_KeyPress);
            // 
            // txtImpuesto_fra
            // 
            this.txtImpuesto_fra.Enabled = false;
            this.txtImpuesto_fra.Location = new System.Drawing.Point(461, 161);
            this.txtImpuesto_fra.MaxLength = 10;
            this.txtImpuesto_fra.Name = "txtImpuesto_fra";
            this.txtImpuesto_fra.Size = new System.Drawing.Size(150, 21);
            this.txtImpuesto_fra.TabIndex = 19;
            this.txtImpuesto_fra.Tag = "impuesto_fra";
            this.txtImpuesto_fra.EnabledChanged += new System.EventHandler(this.txtImpuesto_fra_EnabledChanged);
            this.txtImpuesto_fra.TextChanged += new System.EventHandler(this.txtImpuesto_fra_TextChanged);
            this.txtImpuesto_fra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImpuesto_fra_KeyPress);
            // 
            // txtTotal_fra
            // 
            this.txtTotal_fra.Enabled = false;
            this.txtTotal_fra.Location = new System.Drawing.Point(146, 188);
            this.txtTotal_fra.MaxLength = 10;
            this.txtTotal_fra.Name = "txtTotal_fra";
            this.txtTotal_fra.Size = new System.Drawing.Size(150, 21);
            this.txtTotal_fra.TabIndex = 20;
            this.txtTotal_fra.Tag = "total_fra";
            this.txtTotal_fra.EnabledChanged += new System.EventHandler(this.txtTotal_fra_EnabledChanged);
            this.txtTotal_fra.Enter += new System.EventHandler(this.txtTotal_fra_Enter);
            this.txtTotal_fra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_fra_KeyPress);
            // 
            // lblCod_fra
            // 
            this.lblCod_fra.AutoSize = true;
            this.lblCod_fra.Location = new System.Drawing.Point(12, 83);
            this.lblCod_fra.Name = "lblCod_fra";
            this.lblCod_fra.Size = new System.Drawing.Size(46, 15);
            this.lblCod_fra.TabIndex = 9;
            this.lblCod_fra.Text = "Código";
            // 
            // dtpFechemitida_fra
            // 
            this.dtpFechemitida_fra.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpFechemitida_fra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechemitida_fra.Location = new System.Drawing.Point(461, 134);
            this.dtpFechemitida_fra.Name = "dtpFechemitida_fra";
            this.dtpFechemitida_fra.Size = new System.Drawing.Size(150, 21);
            this.dtpFechemitida_fra.TabIndex = 17;
            this.dtpFechemitida_fra.ValueChanged += new System.EventHandler(this.dtpFechemitida_fra_ValueChanged);
            // 
            // lblCod_srie
            // 
            this.lblCod_srie.AutoSize = true;
            this.lblCod_srie.Location = new System.Drawing.Point(340, 83);
            this.lblCod_srie.Name = "lblCod_srie";
            this.lblCod_srie.Size = new System.Drawing.Size(93, 15);
            this.lblCod_srie.TabIndex = 11;
            this.lblCod_srie.Text = "Código de serie";
            // 
            // lblCod_suc
            // 
            this.lblCod_suc.AutoSize = true;
            this.lblCod_suc.Location = new System.Drawing.Point(12, 110);
            this.lblCod_suc.Name = "lblCod_suc";
            this.lblCod_suc.Size = new System.Drawing.Size(112, 15);
            this.lblCod_suc.TabIndex = 12;
            this.lblCod_suc.Text = "Código de sucursal";
            // 
            // lblCod_empsa
            // 
            this.lblCod_empsa.AutoSize = true;
            this.lblCod_empsa.Location = new System.Drawing.Point(340, 110);
            this.lblCod_empsa.Name = "lblCod_empsa";
            this.lblCod_empsa.Size = new System.Drawing.Size(115, 15);
            this.lblCod_empsa.TabIndex = 13;
            this.lblCod_empsa.Text = "Código de empresa";
            // 
            // lblCod_flocte
            // 
            this.lblCod_flocte.AutoSize = true;
            this.lblCod_flocte.Location = new System.Drawing.Point(12, 137);
            this.lblCod_flocte.Name = "lblCod_flocte";
            this.lblCod_flocte.Size = new System.Drawing.Size(128, 15);
            this.lblCod_flocte.TabIndex = 14;
            this.lblCod_flocte.Text = "Código de folio cliente";
            // 
            // lblFechemitida_fra
            // 
            this.lblFechemitida_fra.AutoSize = true;
            this.lblFechemitida_fra.Location = new System.Drawing.Point(340, 139);
            this.lblFechemitida_fra.Name = "lblFechemitida_fra";
            this.lblFechemitida_fra.Size = new System.Drawing.Size(105, 15);
            this.lblFechemitida_fra.TabIndex = 15;
            this.lblFechemitida_fra.Text = "Fecha de emisión";
            // 
            // lblValor_fra
            // 
            this.lblValor_fra.AutoSize = true;
            this.lblValor_fra.Location = new System.Drawing.Point(12, 164);
            this.lblValor_fra.Name = "lblValor_fra";
            this.lblValor_fra.Size = new System.Drawing.Size(35, 15);
            this.lblValor_fra.TabIndex = 16;
            this.lblValor_fra.Text = "Valor";
            // 
            // lblImpuesto_fra
            // 
            this.lblImpuesto_fra.AutoSize = true;
            this.lblImpuesto_fra.Location = new System.Drawing.Point(340, 164);
            this.lblImpuesto_fra.Name = "lblImpuesto_fra";
            this.lblImpuesto_fra.Size = new System.Drawing.Size(64, 15);
            this.lblImpuesto_fra.TabIndex = 17;
            this.lblImpuesto_fra.Text = "Impuestos";
            // 
            // lblTotal_fra
            // 
            this.lblTotal_fra.AutoSize = true;
            this.lblTotal_fra.Location = new System.Drawing.Point(12, 191);
            this.lblTotal_fra.Name = "lblTotal_fra";
            this.lblTotal_fra.Size = new System.Drawing.Size(34, 15);
            this.lblTotal_fra.TabIndex = 18;
            this.lblTotal_fra.Text = "Total";
            // 
            // txtCod_srie
            // 
            this.txtCod_srie.Location = new System.Drawing.Point(461, 80);
            this.txtCod_srie.MaxLength = 4;
            this.txtCod_srie.Name = "txtCod_srie";
            this.txtCod_srie.Size = new System.Drawing.Size(150, 21);
            this.txtCod_srie.TabIndex = 13;
            this.txtCod_srie.Tag = "cod_srie";
            this.txtCod_srie.Enter += new System.EventHandler(this.txtCod_srie_Enter);
            // 
            // txtCod_suc
            // 
            this.txtCod_suc.Location = new System.Drawing.Point(146, 107);
            this.txtCod_suc.MaxLength = 4;
            this.txtCod_suc.Name = "txtCod_suc";
            this.txtCod_suc.Size = new System.Drawing.Size(150, 21);
            this.txtCod_suc.TabIndex = 14;
            this.txtCod_suc.Tag = "cod_suc";
            this.txtCod_suc.Enter += new System.EventHandler(this.txtCod_suc_Enter_1);
            // 
            // txtCod_empsa
            // 
            this.txtCod_empsa.Location = new System.Drawing.Point(461, 107);
            this.txtCod_empsa.MaxLength = 4;
            this.txtCod_empsa.Name = "txtCod_empsa";
            this.txtCod_empsa.Size = new System.Drawing.Size(150, 21);
            this.txtCod_empsa.TabIndex = 15;
            this.txtCod_empsa.Tag = "cod_empsa";
            this.txtCod_empsa.Enter += new System.EventHandler(this.txtCod_empsa_Enter);
            // 
            // txtCod_flocte
            // 
            this.txtCod_flocte.Location = new System.Drawing.Point(146, 134);
            this.txtCod_flocte.MaxLength = 4;
            this.txtCod_flocte.Name = "txtCod_flocte";
            this.txtCod_flocte.Size = new System.Drawing.Size(150, 21);
            this.txtCod_flocte.TabIndex = 16;
            this.txtCod_flocte.Tag = "cod_flocte";
            this.txtCod_flocte.TextChanged += new System.EventHandler(this.txtCod_flocte_TextChanged);
            this.txtCod_flocte.Enter += new System.EventHandler(this.txtCod_flocte_Enter);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(13, 13);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_fefactura";
            this.navegador1.TabIndex = 27;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.btnEliminar_AfterClick += new System.EventHandler(this.navegador1_btnEliminar_AfterClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            this.navegador1.btnImprimir_AfterClick += new System.EventHandler(this.navegador1_btnImprimir_AfterClick);
            // 
            // btnGenerarDetalle
            // 
            this.btnGenerarDetalle.Location = new System.Drawing.Point(12, 215);
            this.btnGenerarDetalle.Name = "btnGenerarDetalle";
            this.btnGenerarDetalle.Size = new System.Drawing.Size(599, 23);
            this.btnGenerarDetalle.TabIndex = 22;
            this.btnGenerarDetalle.Text = "Generar Detalle";
            this.btnGenerarDetalle.UseVisualStyleBackColor = true;
            this.btnGenerarDetalle.Click += new System.EventHandler(this.btnGenerarDetalle_Click);
            // 
            // dgvDetalleImpuesto
            // 
            this.dgvDetalleImpuesto.AllowUserToAddRows = false;
            this.dgvDetalleImpuesto.AllowUserToResizeColumns = false;
            this.dgvDetalleImpuesto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetalleImpuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleImpuesto.Location = new System.Drawing.Point(343, 278);
            this.dgvDetalleImpuesto.MultiSelect = false;
            this.dgvDetalleImpuesto.Name = "dgvDetalleImpuesto";
            this.dgvDetalleImpuesto.ReadOnly = true;
            this.dgvDetalleImpuesto.RowHeadersVisible = false;
            this.dgvDetalleImpuesto.RowHeadersWidth = 30;
            this.dgvDetalleImpuesto.RowTemplate.Height = 20;
            this.dgvDetalleImpuesto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleImpuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleImpuesto.Size = new System.Drawing.Size(268, 170);
            this.dgvDetalleImpuesto.TabIndex = 27;
            // 
            // cboSeleccionarImp
            // 
            this.cboSeleccionarImp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeleccionarImp.Enabled = false;
            this.cboSeleccionarImp.FormattingEnabled = true;
            this.cboSeleccionarImp.Location = new System.Drawing.Point(106, 250);
            this.cboSeleccionarImp.Name = "cboSeleccionarImp";
            this.cboSeleccionarImp.Size = new System.Drawing.Size(150, 23);
            this.cboSeleccionarImp.TabIndex = 23;
            this.cboSeleccionarImp.SelectedIndexChanged += new System.EventHandler(this.cboSeleccionarImp_SelectedIndexChanged);
            // 
            // btnAgregarImp
            // 
            this.btnAgregarImp.Enabled = false;
            this.btnAgregarImp.Location = new System.Drawing.Point(461, 248);
            this.btnAgregarImp.Name = "btnAgregarImp";
            this.btnAgregarImp.Size = new System.Drawing.Size(150, 24);
            this.btnAgregarImp.TabIndex = 25;
            this.btnAgregarImp.Text = "Agregar Impuesto";
            this.btnAgregarImp.UseVisualStyleBackColor = true;
            this.btnAgregarImp.Click += new System.EventHandler(this.btnAgregarImp_Click);
            // 
            // txtTotalImp
            // 
            this.txtTotalImp.Enabled = false;
            this.txtTotalImp.Location = new System.Drawing.Point(305, 250);
            this.txtTotalImp.Name = "txtTotalImp";
            this.txtTotalImp.Size = new System.Drawing.Size(150, 21);
            this.txtTotalImp.TabIndex = 24;
            // 
            // lblTotalImp
            // 
            this.lblTotalImp.AutoSize = true;
            this.lblTotalImp.Location = new System.Drawing.Point(262, 253);
            this.lblTotalImp.Name = "lblTotalImp";
            this.lblTotalImp.Size = new System.Drawing.Size(37, 15);
            this.lblTotalImp.TabIndex = 40;
            this.lblTotalImp.Text = "Total ";
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AllowUserToAddRows = false;
            this.dgvDetalleFactura.AllowUserToDeleteRows = false;
            this.dgvDetalleFactura.AllowUserToResizeColumns = false;
            this.dgvDetalleFactura.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(15, 278);
            this.dgvDetalleFactura.MultiSelect = false;
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.ReadOnly = true;
            this.dgvDetalleFactura.RowHeadersVisible = false;
            this.dgvDetalleFactura.RowHeadersWidth = 30;
            this.dgvDetalleFactura.RowTemplate.Height = 20;
            this.dgvDetalleFactura.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(320, 170);
            this.dgvDetalleFactura.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Impuesto";
            // 
            // lblEstado_fra
            // 
            this.lblEstado_fra.AutoSize = true;
            this.lblEstado_fra.Location = new System.Drawing.Point(340, 191);
            this.lblEstado_fra.Name = "lblEstado_fra";
            this.lblEstado_fra.Size = new System.Drawing.Size(45, 15);
            this.lblEstado_fra.TabIndex = 43;
            this.lblEstado_fra.Text = "Estado";
            // 
            // cboEstado_fra
            // 
            this.cboEstado_fra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_fra.FormattingEnabled = true;
            this.cboEstado_fra.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado_fra.Location = new System.Drawing.Point(461, 188);
            this.cboEstado_fra.Name = "cboEstado_fra";
            this.cboEstado_fra.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_fra.TabIndex = 21;
            this.cboEstado_fra.SelectedIndexChanged += new System.EventHandler(this.cboEstado_fra_SelectedIndexChanged);
            // 
            // txtEstado_fra
            // 
            this.txtEstado_fra.Location = new System.Drawing.Point(312, 188);
            this.txtEstado_fra.Name = "txtEstado_fra";
            this.txtEstado_fra.Size = new System.Drawing.Size(23, 21);
            this.txtEstado_fra.TabIndex = 45;
            this.txtEstado_fra.Tag = "estado_fra";
            this.txtEstado_fra.Visible = false;
            this.txtEstado_fra.EnabledChanged += new System.EventHandler(this.txtEstado_fra_EnabledChanged);
            this.txtEstado_fra.TextChanged += new System.EventHandler(this.txtEstado_fra_TextChanged);
            // 
            // wfFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 465);
            this.Controls.Add(this.txtEstado_fra);
            this.Controls.Add(this.cboEstado_fra);
            this.Controls.Add(this.lblEstado_fra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetalleFactura);
            this.Controls.Add(this.lblTotalImp);
            this.Controls.Add(this.txtTotalImp);
            this.Controls.Add(this.btnAgregarImp);
            this.Controls.Add(this.cboSeleccionarImp);
            this.Controls.Add(this.dgvDetalleImpuesto);
            this.Controls.Add(this.btnGenerarDetalle);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtCod_flocte);
            this.Controls.Add(this.txtCod_empsa);
            this.Controls.Add(this.txtCod_suc);
            this.Controls.Add(this.txtCod_srie);
            this.Controls.Add(this.lblTotal_fra);
            this.Controls.Add(this.lblImpuesto_fra);
            this.Controls.Add(this.lblValor_fra);
            this.Controls.Add(this.lblFechemitida_fra);
            this.Controls.Add(this.lblCod_flocte);
            this.Controls.Add(this.lblCod_empsa);
            this.Controls.Add(this.lblCod_suc);
            this.Controls.Add(this.lblCod_srie);
            this.Controls.Add(this.dtpFechemitida_fra);
            this.Controls.Add(this.lblCod_fra);
            this.Controls.Add(this.txtTotal_fra);
            this.Controls.Add(this.txtImpuesto_fra);
            this.Controls.Add(this.txtValor_fra);
            this.Controls.Add(this.txtFechaemitida_fra);
            this.Controls.Add(this.txtCod_fra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfFactura";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.wfFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleImpuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod_fra;
        private System.Windows.Forms.TextBox txtFechaemitida_fra;
        private System.Windows.Forms.TextBox txtValor_fra;
        private System.Windows.Forms.TextBox txtImpuesto_fra;
        private System.Windows.Forms.TextBox txtTotal_fra;
        private System.Windows.Forms.Label lblCod_fra;
        private System.Windows.Forms.DateTimePicker dtpFechemitida_fra;
        private System.Windows.Forms.Label lblCod_srie;
        private System.Windows.Forms.Label lblCod_suc;
        private System.Windows.Forms.Label lblCod_empsa;
        private System.Windows.Forms.Label lblCod_flocte;
        private System.Windows.Forms.Label lblFechemitida_fra;
        private System.Windows.Forms.Label lblValor_fra;
        private System.Windows.Forms.Label lblImpuesto_fra;
        private System.Windows.Forms.Label lblTotal_fra;
        private System.Windows.Forms.TextBox txtCod_srie;
        private System.Windows.Forms.TextBox txtCod_suc;
        private System.Windows.Forms.TextBox txtCod_empsa;
        private System.Windows.Forms.TextBox txtCod_flocte;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Button btnGenerarDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleImpuesto;
        private System.Windows.Forms.ComboBox cboSeleccionarImp;
        private System.Windows.Forms.Button btnAgregarImp;
        private System.Windows.Forms.TextBox txtTotalImp;
        private System.Windows.Forms.Label lblTotalImp;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstado_fra;
        private System.Windows.Forms.ComboBox cboEstado_fra;
        private System.Windows.Forms.TextBox txtEstado_fra;
    }
}