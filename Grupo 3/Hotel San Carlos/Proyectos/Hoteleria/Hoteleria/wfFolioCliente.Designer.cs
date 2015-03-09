namespace Hoteleria
{
    partial class wfFolioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfFolioCliente));
            this.navegador1 = new Navegador.Navegador();
            this.txtCod_flocte = new System.Windows.Forms.TextBox();
            this.lblCod_flocte = new System.Windows.Forms.Label();
            this.lblCod_rsva = new System.Windows.Forms.Label();
            this.txtCod_rsva = new System.Windows.Forms.TextBox();
            this.dgvServiciosFolio = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboCodigos = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalAmbiente = new System.Windows.Forms.TextBox();
            this.lblEstado_flocte = new System.Windows.Forms.Label();
            this.cboEstado_flocte = new System.Windows.Forms.ComboBox();
            this.txtEstado_flocte = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosFolio)).BeginInit();
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
            this.navegador1.sNombreTabla = "tabm_fefoliocliente";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.btnEliminar_AfterClick += new System.EventHandler(this.navegador1_btnEliminar_AfterClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // txtCod_flocte
            // 
            this.txtCod_flocte.Location = new System.Drawing.Point(64, 80);
            this.txtCod_flocte.MaxLength = 4;
            this.txtCod_flocte.Name = "txtCod_flocte";
            this.txtCod_flocte.Size = new System.Drawing.Size(150, 21);
            this.txtCod_flocte.TabIndex = 12;
            this.txtCod_flocte.Tag = "cod_flocte";
            this.txtCod_flocte.EnabledChanged += new System.EventHandler(this.txtCod_flocte_EnabledChanged);
            this.txtCod_flocte.TextChanged += new System.EventHandler(this.txtCod_flocte_TextChanged);
            // 
            // lblCod_flocte
            // 
            this.lblCod_flocte.AutoSize = true;
            this.lblCod_flocte.Location = new System.Drawing.Point(12, 83);
            this.lblCod_flocte.Name = "lblCod_flocte";
            this.lblCod_flocte.Size = new System.Drawing.Size(46, 15);
            this.lblCod_flocte.TabIndex = 2;
            this.lblCod_flocte.Text = "Código";
            // 
            // lblCod_rsva
            // 
            this.lblCod_rsva.AutoSize = true;
            this.lblCod_rsva.Location = new System.Drawing.Point(323, 83);
            this.lblCod_rsva.Name = "lblCod_rsva";
            this.lblCod_rsva.Size = new System.Drawing.Size(129, 15);
            this.lblCod_rsva.TabIndex = 3;
            this.lblCod_rsva.Text = "Código de reservación";
            // 
            // txtCod_rsva
            // 
            this.txtCod_rsva.Location = new System.Drawing.Point(458, 80);
            this.txtCod_rsva.MaxLength = 4;
            this.txtCod_rsva.Name = "txtCod_rsva";
            this.txtCod_rsva.Size = new System.Drawing.Size(150, 21);
            this.txtCod_rsva.TabIndex = 13;
            this.txtCod_rsva.Tag = "cod_rsva";
            this.txtCod_rsva.EnabledChanged += new System.EventHandler(this.txtCod_rsva_EnabledChanged);
            this.txtCod_rsva.Enter += new System.EventHandler(this.txtCod_rsva_Enter);
            this.txtCod_rsva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_rsva_KeyPress);
            // 
            // dgvServiciosFolio
            // 
            this.dgvServiciosFolio.AllowUserToAddRows = false;
            this.dgvServiciosFolio.AllowUserToResizeColumns = false;
            this.dgvServiciosFolio.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvServiciosFolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiciosFolio.Location = new System.Drawing.Point(12, 141);
            this.dgvServiciosFolio.MultiSelect = false;
            this.dgvServiciosFolio.Name = "dgvServiciosFolio";
            this.dgvServiciosFolio.ReadOnly = true;
            this.dgvServiciosFolio.RowHeadersVisible = false;
            this.dgvServiciosFolio.RowHeadersWidth = 30;
            this.dgvServiciosFolio.RowTemplate.Height = 20;
            this.dgvServiciosFolio.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiciosFolio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiciosFolio.Size = new System.Drawing.Size(420, 170);
            this.dgvServiciosFolio.TabIndex = 18;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(455, 190);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 47;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(455, 141);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(50, 15);
            this.lblServicio.TabIndex = 46;
            this.lblServicio.Text = "Servicio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(458, 277);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar Servicio";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(458, 208);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 21);
            this.txtCantidad.TabIndex = 16;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cboCodigos
            // 
            this.cboCodigos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigos.FormattingEnabled = true;
            this.cboCodigos.Location = new System.Drawing.Point(458, 159);
            this.cboCodigos.Name = "cboCodigos";
            this.cboCodigos.Size = new System.Drawing.Size(150, 23);
            this.cboCodigos.TabIndex = 15;
            this.cboCodigos.SelectedIndexChanged += new System.EventHandler(this.cboCodigos_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(455, 232);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 15);
            this.lblTotal.TabIndex = 49;
            this.lblTotal.Text = "Total";
            // 
            // txtTotalAmbiente
            // 
            this.txtTotalAmbiente.Enabled = false;
            this.txtTotalAmbiente.Location = new System.Drawing.Point(460, 250);
            this.txtTotalAmbiente.Name = "txtTotalAmbiente";
            this.txtTotalAmbiente.Size = new System.Drawing.Size(150, 21);
            this.txtTotalAmbiente.TabIndex = 17;
            // 
            // lblEstado_flocte
            // 
            this.lblEstado_flocte.AutoSize = true;
            this.lblEstado_flocte.Location = new System.Drawing.Point(12, 110);
            this.lblEstado_flocte.Name = "lblEstado_flocte";
            this.lblEstado_flocte.Size = new System.Drawing.Size(45, 15);
            this.lblEstado_flocte.TabIndex = 50;
            this.lblEstado_flocte.Text = "Estado";
            // 
            // cboEstado_flocte
            // 
            this.cboEstado_flocte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_flocte.FormattingEnabled = true;
            this.cboEstado_flocte.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado_flocte.Location = new System.Drawing.Point(64, 107);
            this.cboEstado_flocte.Name = "cboEstado_flocte";
            this.cboEstado_flocte.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_flocte.TabIndex = 14;
            this.cboEstado_flocte.SelectedIndexChanged += new System.EventHandler(this.cboEstado_flocte_SelectedIndexChanged);
            // 
            // txtEstado_flocte
            // 
            this.txtEstado_flocte.Location = new System.Drawing.Point(220, 107);
            this.txtEstado_flocte.Name = "txtEstado_flocte";
            this.txtEstado_flocte.Size = new System.Drawing.Size(21, 21);
            this.txtEstado_flocte.TabIndex = 52;
            this.txtEstado_flocte.Tag = "estado_flocte";
            this.txtEstado_flocte.Visible = false;
            this.txtEstado_flocte.EnabledChanged += new System.EventHandler(this.txtEstado_flocte_EnabledChanged);
            this.txtEstado_flocte.TextChanged += new System.EventHandler(this.txtEstado_flocte_TextChanged);
            // 
            // wfFolioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 323);
            this.Controls.Add(this.txtEstado_flocte);
            this.Controls.Add(this.cboEstado_flocte);
            this.Controls.Add(this.lblEstado_flocte);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotalAmbiente);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboCodigos);
            this.Controls.Add(this.dgvServiciosFolio);
            this.Controls.Add(this.txtCod_rsva);
            this.Controls.Add(this.lblCod_rsva);
            this.Controls.Add(this.lblCod_flocte);
            this.Controls.Add(this.txtCod_flocte);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfFolioCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folios de Clientes";
            this.Load += new System.EventHandler(this.wfFolioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosFolio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtCod_flocte;
        private System.Windows.Forms.Label lblCod_flocte;
        private System.Windows.Forms.Label lblCod_rsva;
        private System.Windows.Forms.TextBox txtCod_rsva;
        private System.Windows.Forms.DataGridView dgvServiciosFolio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboCodigos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalAmbiente;
        private System.Windows.Forms.Label lblEstado_flocte;
        private System.Windows.Forms.ComboBox cboEstado_flocte;
        private System.Windows.Forms.TextBox txtEstado_flocte;
    }
}