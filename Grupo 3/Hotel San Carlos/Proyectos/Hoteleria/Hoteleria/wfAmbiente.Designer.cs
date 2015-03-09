namespace Hoteleria
{
    partial class wfAmbiente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfAmbiente));
            this.txtCod_amb = new System.Windows.Forms.TextBox();
            this.lblCod_amb = new System.Windows.Forms.Label();
            this.lblCod_tabm = new System.Windows.Forms.Label();
            this.lblPrecio_amb = new System.Windows.Forms.Label();
            this.txtPrecio_amb = new System.Windows.Forms.TextBox();
            this.lblDisponibilidad_amb = new System.Windows.Forms.Label();
            this.lblEstado_amb = new System.Windows.Forms.Label();
            this.cboDisponibilidad_amb = new System.Windows.Forms.ComboBox();
            this.cboEstado_amb = new System.Windows.Forms.ComboBox();
            this.txtEstado_amb = new System.Windows.Forms.TextBox();
            this.txtDisponibilidad_amb = new System.Windows.Forms.TextBox();
            this.txtCod_tamb = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.lblCatprod = new System.Windows.Forms.Label();
            this.cboCodigos = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCant_ambcatprod = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvProductosAmbiente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAmbiente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCod_amb
            // 
            this.txtCod_amb.Location = new System.Drawing.Point(64, 80);
            this.txtCod_amb.MaxLength = 4;
            this.txtCod_amb.Name = "txtCod_amb";
            this.txtCod_amb.Size = new System.Drawing.Size(150, 21);
            this.txtCod_amb.TabIndex = 12;
            this.txtCod_amb.Tag = "cod_amb";
            this.txtCod_amb.EnabledChanged += new System.EventHandler(this.txtCod_amb_EnabledChanged);
            this.txtCod_amb.TextChanged += new System.EventHandler(this.txtCod_amb_TextChanged);
            // 
            // lblCod_amb
            // 
            this.lblCod_amb.AutoSize = true;
            this.lblCod_amb.Location = new System.Drawing.Point(12, 83);
            this.lblCod_amb.Name = "lblCod_amb";
            this.lblCod_amb.Size = new System.Drawing.Size(46, 15);
            this.lblCod_amb.TabIndex = 2;
            this.lblCod_amb.Text = "Código";
            // 
            // lblCod_tabm
            // 
            this.lblCod_tabm.AutoSize = true;
            this.lblCod_tabm.Location = new System.Drawing.Point(308, 83);
            this.lblCod_tabm.Name = "lblCod_tabm";
            this.lblCod_tabm.Size = new System.Drawing.Size(141, 15);
            this.lblCod_tabm.TabIndex = 4;
            this.lblCod_tabm.Text = "Código tipo de ambiente";
            // 
            // lblPrecio_amb
            // 
            this.lblPrecio_amb.AutoSize = true;
            this.lblPrecio_amb.Location = new System.Drawing.Point(12, 110);
            this.lblPrecio_amb.Name = "lblPrecio_amb";
            this.lblPrecio_amb.Size = new System.Drawing.Size(42, 15);
            this.lblPrecio_amb.TabIndex = 6;
            this.lblPrecio_amb.Text = "Precio";
            // 
            // txtPrecio_amb
            // 
            this.txtPrecio_amb.Location = new System.Drawing.Point(64, 107);
            this.txtPrecio_amb.MaxLength = 10;
            this.txtPrecio_amb.Name = "txtPrecio_amb";
            this.txtPrecio_amb.Size = new System.Drawing.Size(150, 21);
            this.txtPrecio_amb.TabIndex = 14;
            this.txtPrecio_amb.Tag = "precio_amb";
            this.txtPrecio_amb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_amb_KeyPress);
            // 
            // lblDisponibilidad_amb
            // 
            this.lblDisponibilidad_amb.AutoSize = true;
            this.lblDisponibilidad_amb.Location = new System.Drawing.Point(308, 110);
            this.lblDisponibilidad_amb.Name = "lblDisponibilidad_amb";
            this.lblDisponibilidad_amb.Size = new System.Drawing.Size(86, 15);
            this.lblDisponibilidad_amb.TabIndex = 8;
            this.lblDisponibilidad_amb.Text = "Disponibilidad";
            // 
            // lblEstado_amb
            // 
            this.lblEstado_amb.AutoSize = true;
            this.lblEstado_amb.Location = new System.Drawing.Point(13, 137);
            this.lblEstado_amb.Name = "lblEstado_amb";
            this.lblEstado_amb.Size = new System.Drawing.Size(45, 15);
            this.lblEstado_amb.TabIndex = 10;
            this.lblEstado_amb.Text = "Estado";
            // 
            // cboDisponibilidad_amb
            // 
            this.cboDisponibilidad_amb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisponibilidad_amb.FormattingEnabled = true;
            this.cboDisponibilidad_amb.Items.AddRange(new object[] {
            "Disponible",
            "No disponible"});
            this.cboDisponibilidad_amb.Location = new System.Drawing.Point(458, 107);
            this.cboDisponibilidad_amb.Name = "cboDisponibilidad_amb";
            this.cboDisponibilidad_amb.Size = new System.Drawing.Size(150, 23);
            this.cboDisponibilidad_amb.TabIndex = 15;
            this.cboDisponibilidad_amb.Tag = "";
            this.cboDisponibilidad_amb.SelectedIndexChanged += new System.EventHandler(this.cboDisponibilidad_amb_SelectedIndexChanged);
            // 
            // cboEstado_amb
            // 
            this.cboEstado_amb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_amb.FormattingEnabled = true;
            this.cboEstado_amb.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado_amb.Location = new System.Drawing.Point(64, 134);
            this.cboEstado_amb.Name = "cboEstado_amb";
            this.cboEstado_amb.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_amb.TabIndex = 16;
            this.cboEstado_amb.Tag = "";
            this.cboEstado_amb.SelectedIndexChanged += new System.EventHandler(this.cboEstado_amb_SelectedIndexChanged);
            // 
            // txtEstado_amb
            // 
            this.txtEstado_amb.Location = new System.Drawing.Point(220, 134);
            this.txtEstado_amb.Name = "txtEstado_amb";
            this.txtEstado_amb.Size = new System.Drawing.Size(21, 21);
            this.txtEstado_amb.TabIndex = 18;
            this.txtEstado_amb.Tag = "estado_amb";
            this.txtEstado_amb.Visible = false;
            this.txtEstado_amb.EnabledChanged += new System.EventHandler(this.txtEstado_amb_EnabledChanged);
            this.txtEstado_amb.TextChanged += new System.EventHandler(this.txtEstado_amb_TextChanged);
            // 
            // txtDisponibilidad_amb
            // 
            this.txtDisponibilidad_amb.Location = new System.Drawing.Point(587, 134);
            this.txtDisponibilidad_amb.Name = "txtDisponibilidad_amb";
            this.txtDisponibilidad_amb.Size = new System.Drawing.Size(21, 21);
            this.txtDisponibilidad_amb.TabIndex = 20;
            this.txtDisponibilidad_amb.Tag = "disponibilidad_amb";
            this.txtDisponibilidad_amb.Visible = false;
            this.txtDisponibilidad_amb.EnabledChanged += new System.EventHandler(this.txtDisponibilidad_amb_EnabledChanged);
            this.txtDisponibilidad_amb.TextChanged += new System.EventHandler(this.txtDisponibilidad_amb_TextChanged);
            // 
            // txtCod_tamb
            // 
            this.txtCod_tamb.Location = new System.Drawing.Point(458, 80);
            this.txtCod_tamb.MaxLength = 4;
            this.txtCod_tamb.Name = "txtCod_tamb";
            this.txtCod_tamb.Size = new System.Drawing.Size(150, 21);
            this.txtCod_tamb.TabIndex = 13;
            this.txtCod_tamb.Tag = "cod_tamb";
            this.txtCod_tamb.EnabledChanged += new System.EventHandler(this.txtCod_tamb_EnabledChanged);
            this.txtCod_tamb.Enter += new System.EventHandler(this.txtCod_tamb_Enter);
            this.txtCod_tamb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_tamb_KeyPress);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_feambiente";
            this.navegador1.TabIndex = 21;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.btnEliminar_AfterClick += new System.EventHandler(this.navegador1_btnEliminar_AfterClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            this.navegador1.btnImprimir_AfterClick += new System.EventHandler(this.navegador1_btnImprimir_AfterClick);
            // 
            // lblCatprod
            // 
            this.lblCatprod.AutoSize = true;
            this.lblCatprod.Location = new System.Drawing.Point(352, 194);
            this.lblCatprod.Name = "lblCatprod";
            this.lblCatprod.Size = new System.Drawing.Size(102, 15);
            this.lblCatprod.TabIndex = 23;
            this.lblCatprod.Text = "Cat. de productos";
            // 
            // cboCodigos
            // 
            this.cboCodigos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigos.FormattingEnabled = true;
            this.cboCodigos.Location = new System.Drawing.Point(460, 191);
            this.cboCodigos.Name = "cboCodigos";
            this.cboCodigos.Size = new System.Drawing.Size(150, 23);
            this.cboCodigos.TabIndex = 17;
            this.cboCodigos.Tag = "";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(460, 220);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 21);
            this.txtCantidad.TabIndex = 18;
            this.txtCantidad.Tag = "cod_tamb";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCant_ambcatprod
            // 
            this.lblCant_ambcatprod.AutoSize = true;
            this.lblCant_ambcatprod.Location = new System.Drawing.Point(352, 223);
            this.lblCant_ambcatprod.Name = "lblCant_ambcatprod";
            this.lblCant_ambcatprod.Size = new System.Drawing.Size(56, 15);
            this.lblCant_ambcatprod.TabIndex = 26;
            this.lblCant_ambcatprod.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(355, 247);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(255, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvProductosAmbiente
            // 
            this.dgvProductosAmbiente.AllowUserToAddRows = false;
            this.dgvProductosAmbiente.AllowUserToResizeColumns = false;
            this.dgvProductosAmbiente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProductosAmbiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosAmbiente.Location = new System.Drawing.Point(16, 172);
            this.dgvProductosAmbiente.MultiSelect = false;
            this.dgvProductosAmbiente.Name = "dgvProductosAmbiente";
            this.dgvProductosAmbiente.ReadOnly = true;
            this.dgvProductosAmbiente.RowHeadersVisible = false;
            this.dgvProductosAmbiente.RowHeadersWidth = 30;
            this.dgvProductosAmbiente.RowTemplate.Height = 20;
            this.dgvProductosAmbiente.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosAmbiente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosAmbiente.Size = new System.Drawing.Size(320, 170);
            this.dgvProductosAmbiente.TabIndex = 27;
            // 
            // wfAmbiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 354);
            this.Controls.Add(this.dgvProductosAmbiente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCant_ambcatprod);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboCodigos);
            this.Controls.Add(this.lblCatprod);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtDisponibilidad_amb);
            this.Controls.Add(this.txtEstado_amb);
            this.Controls.Add(this.cboEstado_amb);
            this.Controls.Add(this.cboDisponibilidad_amb);
            this.Controls.Add(this.lblEstado_amb);
            this.Controls.Add(this.lblDisponibilidad_amb);
            this.Controls.Add(this.lblPrecio_amb);
            this.Controls.Add(this.txtPrecio_amb);
            this.Controls.Add(this.lblCod_tabm);
            this.Controls.Add(this.txtCod_tamb);
            this.Controls.Add(this.lblCod_amb);
            this.Controls.Add(this.txtCod_amb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfAmbiente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ambientes";
            this.Load += new System.EventHandler(this.wfAmbiente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAmbiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod_amb;
        private System.Windows.Forms.Label lblCod_amb;
        private System.Windows.Forms.Label lblCod_tabm;
        private System.Windows.Forms.Label lblPrecio_amb;
        private System.Windows.Forms.TextBox txtPrecio_amb;
        private System.Windows.Forms.Label lblDisponibilidad_amb;
        private System.Windows.Forms.Label lblEstado_amb;
        private System.Windows.Forms.ComboBox cboDisponibilidad_amb;
        private System.Windows.Forms.ComboBox cboEstado_amb;
        private System.Windows.Forms.TextBox txtEstado_amb;
        private System.Windows.Forms.TextBox txtDisponibilidad_amb;
        private System.Windows.Forms.TextBox txtCod_tamb;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCatprod;
        private System.Windows.Forms.ComboBox cboCodigos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCant_ambcatprod;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvProductosAmbiente;
    }
}