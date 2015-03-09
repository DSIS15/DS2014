namespace Inventario
{
    partial class wfBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfBodega));
            this.navegador1 = new Navegador.Navegador();
            this.lbCodBodega = new System.Windows.Forms.Label();
            this.lbCodSucursal = new System.Windows.Forms.Label();
            this.lbDescBodega = new System.Windows.Forms.Label();
            this.lbDireBodega = new System.Windows.Forms.Label();
            this.lbEstadoBodega = new System.Windows.Forms.Label();
            this.txtCod_bga = new System.Windows.Forms.TextBox();
            this.txtDescrip_bga = new System.Windows.Forms.TextBox();
            this.txtDire_bga = new System.Windows.Forms.TextBox();
            this.cboEstado_bga = new System.Windows.Forms.ComboBox();
            this.txtEstado_bga = new System.Windows.Forms.TextBox();
            this.txtCod_suc = new System.Windows.Forms.TextBox();
            this.dgvExistencias = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantcongelada_exis = new System.Windows.Forms.TextBox();
            this.lblCcongelada = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboCodigosCat = new System.Windows.Forms.ComboBox();
            this.lblCat_prod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).BeginInit();
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
            this.navegador1.sNombreTabla = "tabm_febodega";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.btnEliminar_AfterClick += new System.EventHandler(this.navegador1_btnEliminar_AfterClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // lbCodBodega
            // 
            this.lbCodBodega.AutoSize = true;
            this.lbCodBodega.Location = new System.Drawing.Point(12, 83);
            this.lbCodBodega.Name = "lbCodBodega";
            this.lbCodBodega.Size = new System.Drawing.Size(46, 15);
            this.lbCodBodega.TabIndex = 0;
            this.lbCodBodega.Text = "Código";
            // 
            // lbCodSucursal
            // 
            this.lbCodSucursal.AutoSize = true;
            this.lbCodSucursal.Location = new System.Drawing.Point(342, 83);
            this.lbCodSucursal.Name = "lbCodSucursal";
            this.lbCodSucursal.Size = new System.Drawing.Size(112, 15);
            this.lbCodSucursal.TabIndex = 0;
            this.lbCodSucursal.Text = "Código de sucursal";
            // 
            // lbDescBodega
            // 
            this.lbDescBodega.AutoSize = true;
            this.lbDescBodega.Location = new System.Drawing.Point(12, 110);
            this.lbDescBodega.Name = "lbDescBodega";
            this.lbDescBodega.Size = new System.Drawing.Size(72, 15);
            this.lbDescBodega.TabIndex = 0;
            this.lbDescBodega.Text = "Descripción";
            // 
            // lbDireBodega
            // 
            this.lbDireBodega.AutoSize = true;
            this.lbDireBodega.Location = new System.Drawing.Point(342, 110);
            this.lbDireBodega.Name = "lbDireBodega";
            this.lbDireBodega.Size = new System.Drawing.Size(59, 15);
            this.lbDireBodega.TabIndex = 0;
            this.lbDireBodega.Text = "Dirección";
            // 
            // lbEstadoBodega
            // 
            this.lbEstadoBodega.AutoSize = true;
            this.lbEstadoBodega.Location = new System.Drawing.Point(12, 137);
            this.lbEstadoBodega.Name = "lbEstadoBodega";
            this.lbEstadoBodega.Size = new System.Drawing.Size(45, 15);
            this.lbEstadoBodega.TabIndex = 0;
            this.lbEstadoBodega.Text = "Estado";
            // 
            // txtCod_bga
            // 
            this.txtCod_bga.Location = new System.Drawing.Point(90, 80);
            this.txtCod_bga.MaxLength = 4;
            this.txtCod_bga.Name = "txtCod_bga";
            this.txtCod_bga.Size = new System.Drawing.Size(150, 21);
            this.txtCod_bga.TabIndex = 12;
            this.txtCod_bga.Tag = "cod_bga";
            this.txtCod_bga.EnabledChanged += new System.EventHandler(this.txtCod_bga_EnabledChanged);
            this.txtCod_bga.TextChanged += new System.EventHandler(this.txtCod_bga_TextChanged);
            this.txtCod_bga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_bga_KeyPress);
            // 
            // txtDescrip_bga
            // 
            this.txtDescrip_bga.Location = new System.Drawing.Point(90, 107);
            this.txtDescrip_bga.MaxLength = 25;
            this.txtDescrip_bga.Name = "txtDescrip_bga";
            this.txtDescrip_bga.Size = new System.Drawing.Size(150, 21);
            this.txtDescrip_bga.TabIndex = 14;
            this.txtDescrip_bga.Tag = "descrip_bga";
            this.txtDescrip_bga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescrip_bga_KeyPress);
            // 
            // txtDire_bga
            // 
            this.txtDire_bga.Location = new System.Drawing.Point(460, 107);
            this.txtDire_bga.MaxLength = 25;
            this.txtDire_bga.Name = "txtDire_bga";
            this.txtDire_bga.Size = new System.Drawing.Size(150, 21);
            this.txtDire_bga.TabIndex = 15;
            this.txtDire_bga.Tag = "dire_bga";
            this.txtDire_bga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDire_bga_KeyPress);
            // 
            // cboEstado_bga
            // 
            this.cboEstado_bga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_bga.FormattingEnabled = true;
            this.cboEstado_bga.IntegralHeight = false;
            this.cboEstado_bga.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cboEstado_bga.Location = new System.Drawing.Point(90, 134);
            this.cboEstado_bga.Name = "cboEstado_bga";
            this.cboEstado_bga.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_bga.TabIndex = 16;
            this.cboEstado_bga.Tag = "";
            this.cboEstado_bga.SelectedIndexChanged += new System.EventHandler(this.cboEstado_bga_SelectedIndexChanged);
            // 
            // txtEstado_bga
            // 
            this.txtEstado_bga.Location = new System.Drawing.Point(246, 134);
            this.txtEstado_bga.MaxLength = 1;
            this.txtEstado_bga.Name = "txtEstado_bga";
            this.txtEstado_bga.Size = new System.Drawing.Size(21, 21);
            this.txtEstado_bga.TabIndex = 17;
            this.txtEstado_bga.Tag = "estado_bga";
            this.txtEstado_bga.Visible = false;
            this.txtEstado_bga.EnabledChanged += new System.EventHandler(this.txtEstadoBodega_EnabledChanged);
            this.txtEstado_bga.TextChanged += new System.EventHandler(this.txtEstadoBodega_TextChanged);
            // 
            // txtCod_suc
            // 
            this.txtCod_suc.Location = new System.Drawing.Point(460, 80);
            this.txtCod_suc.MaxLength = 4;
            this.txtCod_suc.Name = "txtCod_suc";
            this.txtCod_suc.Size = new System.Drawing.Size(150, 21);
            this.txtCod_suc.TabIndex = 13;
            this.txtCod_suc.Tag = "cod_suc";
            this.txtCod_suc.EnabledChanged += new System.EventHandler(this.txtCod_suc_EnabledChanged);
            this.txtCod_suc.Enter += new System.EventHandler(this.txtCod_suc_Enter);
            this.txtCod_suc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_suc_KeyPress);
            // 
            // dgvExistencias
            // 
            this.dgvExistencias.AllowUserToAddRows = false;
            this.dgvExistencias.AllowUserToResizeColumns = false;
            this.dgvExistencias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistencias.Location = new System.Drawing.Point(12, 173);
            this.dgvExistencias.MultiSelect = false;
            this.dgvExistencias.Name = "dgvExistencias";
            this.dgvExistencias.ReadOnly = true;
            this.dgvExistencias.RowHeadersVisible = false;
            this.dgvExistencias.RowHeadersWidth = 30;
            this.dgvExistencias.RowTemplate.Height = 20;
            this.dgvExistencias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExistencias.Size = new System.Drawing.Size(420, 170);
            this.dgvExistencias.TabIndex = 56;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(460, 308);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantcongelada_exis
            // 
            this.txtCantcongelada_exis.Location = new System.Drawing.Point(460, 281);
            this.txtCantcongelada_exis.MaxLength = 10;
            this.txtCantcongelada_exis.Name = "txtCantcongelada_exis";
            this.txtCantcongelada_exis.Size = new System.Drawing.Size(150, 21);
            this.txtCantcongelada_exis.TabIndex = 19;
            this.txtCantcongelada_exis.Tag = "";
            this.txtCantcongelada_exis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantcongelada_exis_KeyPress);
            // 
            // lblCcongelada
            // 
            this.lblCcongelada.AutoSize = true;
            this.lblCcongelada.Location = new System.Drawing.Point(457, 263);
            this.lblCcongelada.Name = "lblCcongelada";
            this.lblCcongelada.Size = new System.Drawing.Size(79, 15);
            this.lblCcongelada.TabIndex = 68;
            this.lblCcongelada.Text = "C. congelada";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(460, 239);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 21);
            this.txtCantidad.TabIndex = 18;
            this.txtCantidad.Tag = "";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(457, 221);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 66;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cboCodigosCat
            // 
            this.cboCodigosCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigosCat.FormattingEnabled = true;
            this.cboCodigosCat.IntegralHeight = false;
            this.cboCodigosCat.ItemHeight = 15;
            this.cboCodigosCat.Location = new System.Drawing.Point(460, 195);
            this.cboCodigosCat.Name = "cboCodigosCat";
            this.cboCodigosCat.Size = new System.Drawing.Size(150, 23);
            this.cboCodigosCat.TabIndex = 17;
            this.cboCodigosCat.Tag = "cod_catprod";
            // 
            // lblCat_prod
            // 
            this.lblCat_prod.AutoSize = true;
            this.lblCat_prod.Location = new System.Drawing.Point(457, 177);
            this.lblCat_prod.Name = "lblCat_prod";
            this.lblCat_prod.Size = new System.Drawing.Size(80, 15);
            this.lblCat_prod.TabIndex = 57;
            this.lblCat_prod.Text = "Cat. Producto";
            // 
            // wfBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 355);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantcongelada_exis);
            this.Controls.Add(this.lblCcongelada);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cboCodigosCat);
            this.Controls.Add(this.lblCat_prod);
            this.Controls.Add(this.dgvExistencias);
            this.Controls.Add(this.txtCod_suc);
            this.Controls.Add(this.txtEstado_bga);
            this.Controls.Add(this.cboEstado_bga);
            this.Controls.Add(this.txtDire_bga);
            this.Controls.Add(this.txtDescrip_bga);
            this.Controls.Add(this.txtCod_bga);
            this.Controls.Add(this.lbEstadoBodega);
            this.Controls.Add(this.lbDireBodega);
            this.Controls.Add(this.lbDescBodega);
            this.Controls.Add(this.lbCodSucursal);
            this.Controls.Add(this.lbCodBodega);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfBodega";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bodegas";
            this.Load += new System.EventHandler(this.wfBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lbCodBodega;
        private System.Windows.Forms.Label lbCodSucursal;
        private System.Windows.Forms.Label lbDescBodega;
        private System.Windows.Forms.Label lbDireBodega;
        private System.Windows.Forms.Label lbEstadoBodega;
        private System.Windows.Forms.TextBox txtCod_bga;
        private System.Windows.Forms.TextBox txtDescrip_bga;
        private System.Windows.Forms.TextBox txtDire_bga;
        private System.Windows.Forms.ComboBox cboEstado_bga;
        private System.Windows.Forms.TextBox txtEstado_bga;
        private System.Windows.Forms.TextBox txtCod_suc;
        private System.Windows.Forms.DataGridView dgvExistencias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantcongelada_exis;
        private System.Windows.Forms.Label lblCcongelada;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboCodigosCat;
        private System.Windows.Forms.Label lblCat_prod;
    }
}