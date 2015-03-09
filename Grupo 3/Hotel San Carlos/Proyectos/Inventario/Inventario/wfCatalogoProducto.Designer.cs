namespace Inventario
{
    partial class wfCatalogoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCatalogoProducto));
            this.lblNom_catprod = new System.Windows.Forms.Label();
            this.lblPrecioc_catprod = new System.Windows.Forms.Label();
            this.lblPreciov_catprod = new System.Windows.Forms.Label();
            this.lblCmax_catprod = new System.Windows.Forms.Label();
            this.lblCmin_catprod = new System.Windows.Forms.Label();
            this.lblCtotal_catprod = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.txtNom_catprod = new System.Windows.Forms.TextBox();
            this.txtPrecioc_catprod = new System.Windows.Forms.TextBox();
            this.txtPreciov_catprod = new System.Windows.Forms.TextBox();
            this.txtCmax_catprod = new System.Windows.Forms.TextBox();
            this.txtCmin_catprod = new System.Windows.Forms.TextBox();
            this.txtCtotal_catprod = new System.Windows.Forms.TextBox();
            this.lblCod_catprod = new System.Windows.Forms.Label();
            this.txtCod_catprod = new System.Windows.Forms.TextBox();
            this.lblEstado_catprod = new System.Windows.Forms.Label();
            this.cboEstado_catprod = new System.Windows.Forms.ComboBox();
            this.txtEstado_catprod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo_catprod = new System.Windows.Forms.TextBox();
            this.cboTipo_catprod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNom_catprod
            // 
            this.lblNom_catprod.AutoSize = true;
            this.lblNom_catprod.Location = new System.Drawing.Point(353, 110);
            this.lblNom_catprod.Name = "lblNom_catprod";
            this.lblNom_catprod.Size = new System.Drawing.Size(52, 15);
            this.lblNom_catprod.TabIndex = 23;
            this.lblNom_catprod.Text = "Nombre";
            // 
            // lblPrecioc_catprod
            // 
            this.lblPrecioc_catprod.AutoSize = true;
            this.lblPrecioc_catprod.Location = new System.Drawing.Point(12, 139);
            this.lblPrecioc_catprod.Name = "lblPrecioc_catprod";
            this.lblPrecioc_catprod.Size = new System.Drawing.Size(74, 15);
            this.lblPrecioc_catprod.TabIndex = 24;
            this.lblPrecioc_catprod.Text = "Precio costo";
            // 
            // lblPreciov_catprod
            // 
            this.lblPreciov_catprod.AutoSize = true;
            this.lblPreciov_catprod.Location = new System.Drawing.Point(353, 137);
            this.lblPreciov_catprod.Name = "lblPreciov_catprod";
            this.lblPreciov_catprod.Size = new System.Drawing.Size(74, 15);
            this.lblPreciov_catprod.TabIndex = 3;
            this.lblPreciov_catprod.Text = "Precio venta";
            // 
            // lblCmax_catprod
            // 
            this.lblCmax_catprod.AutoSize = true;
            this.lblCmax_catprod.Location = new System.Drawing.Point(12, 166);
            this.lblCmax_catprod.Name = "lblCmax_catprod";
            this.lblCmax_catprod.Size = new System.Drawing.Size(104, 15);
            this.lblCmax_catprod.TabIndex = 4;
            this.lblCmax_catprod.Text = "Cantidad máxima";
            // 
            // lblCmin_catprod
            // 
            this.lblCmin_catprod.AutoSize = true;
            this.lblCmin_catprod.Location = new System.Drawing.Point(353, 164);
            this.lblCmin_catprod.Name = "lblCmin_catprod";
            this.lblCmin_catprod.Size = new System.Drawing.Size(101, 15);
            this.lblCmin_catprod.TabIndex = 5;
            this.lblCmin_catprod.Text = "Cantidad mínima";
            // 
            // lblCtotal_catprod
            // 
            this.lblCtotal_catprod.AutoSize = true;
            this.lblCtotal_catprod.Location = new System.Drawing.Point(12, 193);
            this.lblCtotal_catprod.Name = "lblCtotal_catprod";
            this.lblCtotal_catprod.Size = new System.Drawing.Size(82, 15);
            this.lblCtotal_catprod.TabIndex = 6;
            this.lblCtotal_catprod.Text = "Cantidad total";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_fecatprod";
            this.navegador1.TabIndex = 7;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            this.navegador1.btnImprimir_AfterClick += new System.EventHandler(this.navegador1_btnImprimir_AfterClick);
            // 
            // txtNom_catprod
            // 
            this.txtNom_catprod.Location = new System.Drawing.Point(460, 107);
            this.txtNom_catprod.MaxLength = 25;
            this.txtNom_catprod.Name = "txtNom_catprod";
            this.txtNom_catprod.Size = new System.Drawing.Size(150, 21);
            this.txtNom_catprod.TabIndex = 14;
            this.txtNom_catprod.Tag = "nom_catprod";
            this.txtNom_catprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_catprod_KeyPress);
            // 
            // txtPrecioc_catprod
            // 
            this.txtPrecioc_catprod.Location = new System.Drawing.Point(122, 136);
            this.txtPrecioc_catprod.MaxLength = 10;
            this.txtPrecioc_catprod.Name = "txtPrecioc_catprod";
            this.txtPrecioc_catprod.Size = new System.Drawing.Size(150, 21);
            this.txtPrecioc_catprod.TabIndex = 15;
            this.txtPrecioc_catprod.Tag = "precioc_catprod";
            this.txtPrecioc_catprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioc_catprod_KeyPress);
            // 
            // txtPreciov_catprod
            // 
            this.txtPreciov_catprod.Location = new System.Drawing.Point(460, 134);
            this.txtPreciov_catprod.MaxLength = 10;
            this.txtPreciov_catprod.Name = "txtPreciov_catprod";
            this.txtPreciov_catprod.Size = new System.Drawing.Size(150, 21);
            this.txtPreciov_catprod.TabIndex = 16;
            this.txtPreciov_catprod.Tag = "preciov_catprod";
            this.txtPreciov_catprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreciov_catprod_KeyPress_1);
            // 
            // txtCmax_catprod
            // 
            this.txtCmax_catprod.Location = new System.Drawing.Point(122, 163);
            this.txtCmax_catprod.MaxLength = 10;
            this.txtCmax_catprod.Name = "txtCmax_catprod";
            this.txtCmax_catprod.Size = new System.Drawing.Size(150, 21);
            this.txtCmax_catprod.TabIndex = 17;
            this.txtCmax_catprod.Tag = "cmax_catprod";
            this.txtCmax_catprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmax_catprod_KeyPress);
            // 
            // txtCmin_catprod
            // 
            this.txtCmin_catprod.Location = new System.Drawing.Point(460, 161);
            this.txtCmin_catprod.MaxLength = 10;
            this.txtCmin_catprod.Name = "txtCmin_catprod";
            this.txtCmin_catprod.Size = new System.Drawing.Size(150, 21);
            this.txtCmin_catprod.TabIndex = 18;
            this.txtCmin_catprod.Tag = "cmin_catprod";
            this.txtCmin_catprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCmin_catprod_KeyPress);
            // 
            // txtCtotal_catprod
            // 
            this.txtCtotal_catprod.Location = new System.Drawing.Point(122, 190);
            this.txtCtotal_catprod.MaxLength = 10;
            this.txtCtotal_catprod.Name = "txtCtotal_catprod";
            this.txtCtotal_catprod.Size = new System.Drawing.Size(150, 21);
            this.txtCtotal_catprod.TabIndex = 19;
            this.txtCtotal_catprod.Tag = "ctotal_catprod";
            this.txtCtotal_catprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCtotal_catprod_KeyPress);
            // 
            // lblCod_catprod
            // 
            this.lblCod_catprod.AutoSize = true;
            this.lblCod_catprod.Location = new System.Drawing.Point(12, 83);
            this.lblCod_catprod.Name = "lblCod_catprod";
            this.lblCod_catprod.Size = new System.Drawing.Size(49, 15);
            this.lblCod_catprod.TabIndex = 21;
            this.lblCod_catprod.Text = "Codigo ";
            // 
            // txtCod_catprod
            // 
            this.txtCod_catprod.Location = new System.Drawing.Point(122, 80);
            this.txtCod_catprod.MaxLength = 4;
            this.txtCod_catprod.Name = "txtCod_catprod";
            this.txtCod_catprod.Size = new System.Drawing.Size(150, 21);
            this.txtCod_catprod.TabIndex = 12;
            this.txtCod_catprod.Tag = "cod_catprod";
            this.txtCod_catprod.EnabledChanged += new System.EventHandler(this.txtCod_catprod_EnabledChanged);
            this.txtCod_catprod.TextChanged += new System.EventHandler(this.txtCod_catprod_TextChanged);
            // 
            // lblEstado_catprod
            // 
            this.lblEstado_catprod.AutoSize = true;
            this.lblEstado_catprod.Location = new System.Drawing.Point(12, 220);
            this.lblEstado_catprod.Name = "lblEstado_catprod";
            this.lblEstado_catprod.Size = new System.Drawing.Size(45, 15);
            this.lblEstado_catprod.TabIndex = 7;
            this.lblEstado_catprod.Text = "Estado";
            // 
            // cboEstado_catprod
            // 
            this.cboEstado_catprod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_catprod.FormattingEnabled = true;
            this.cboEstado_catprod.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado_catprod.Location = new System.Drawing.Point(122, 217);
            this.cboEstado_catprod.Name = "cboEstado_catprod";
            this.cboEstado_catprod.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_catprod.TabIndex = 20;
            this.cboEstado_catprod.Tag = "";
            this.cboEstado_catprod.SelectedIndexChanged += new System.EventHandler(this.cboEstado_catprod_SelectedIndexChanged);
            // 
            // txtEstado_catprod
            // 
            this.txtEstado_catprod.Location = new System.Drawing.Point(278, 217);
            this.txtEstado_catprod.Name = "txtEstado_catprod";
            this.txtEstado_catprod.Size = new System.Drawing.Size(21, 21);
            this.txtEstado_catprod.TabIndex = 21;
            this.txtEstado_catprod.Tag = "estado_catprod";
            this.txtEstado_catprod.Visible = false;
            this.txtEstado_catprod.EnabledChanged += new System.EventHandler(this.txtEstado_catprod_EnabledChanged);
            this.txtEstado_catprod.TextChanged += new System.EventHandler(this.txtEstado_catprod_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tipo";
            // 
            // txtTipo_catprod
            // 
            this.txtTipo_catprod.Location = new System.Drawing.Point(278, 107);
            this.txtTipo_catprod.MaxLength = 25;
            this.txtTipo_catprod.Name = "txtTipo_catprod";
            this.txtTipo_catprod.Size = new System.Drawing.Size(21, 21);
            this.txtTipo_catprod.TabIndex = 13;
            this.txtTipo_catprod.Tag = "tipo_catprod";
            this.txtTipo_catprod.Visible = false;
            this.txtTipo_catprod.EnabledChanged += new System.EventHandler(this.txtTipo_catprod_EnabledChanged);
            this.txtTipo_catprod.TextChanged += new System.EventHandler(this.txtTipo_catprod_TextChanged);
            this.txtTipo_catprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipo_catprod_KeyPress);
            // 
            // cboTipo_catprod
            // 
            this.cboTipo_catprod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo_catprod.FormattingEnabled = true;
            this.cboTipo_catprod.Items.AddRange(new object[] {
            "Mobiliario",
            "Producto"});
            this.cboTipo_catprod.Location = new System.Drawing.Point(122, 107);
            this.cboTipo_catprod.Name = "cboTipo_catprod";
            this.cboTipo_catprod.Size = new System.Drawing.Size(150, 23);
            this.cboTipo_catprod.TabIndex = 13;
            this.cboTipo_catprod.SelectedIndexChanged += new System.EventHandler(this.cboTipo_catprod_SelectedIndexChanged);
            // 
            // wfCatalogoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 252);
            this.Controls.Add(this.cboTipo_catprod);
            this.Controls.Add(this.txtTipo_catprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstado_catprod);
            this.Controls.Add(this.cboEstado_catprod);
            this.Controls.Add(this.lblEstado_catprod);
            this.Controls.Add(this.txtCod_catprod);
            this.Controls.Add(this.lblCod_catprod);
            this.Controls.Add(this.txtCtotal_catprod);
            this.Controls.Add(this.txtCmin_catprod);
            this.Controls.Add(this.txtCmax_catprod);
            this.Controls.Add(this.txtPreciov_catprod);
            this.Controls.Add(this.txtPrecioc_catprod);
            this.Controls.Add(this.txtNom_catprod);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblCtotal_catprod);
            this.Controls.Add(this.lblCmin_catprod);
            this.Controls.Add(this.lblCmax_catprod);
            this.Controls.Add(this.lblPreciov_catprod);
            this.Controls.Add(this.lblPrecioc_catprod);
            this.Controls.Add(this.lblNom_catprod);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfCatalogoProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Productos";
            this.Load += new System.EventHandler(this.wfCatalogoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom_catprod;
        private System.Windows.Forms.Label lblPrecioc_catprod;
        private System.Windows.Forms.Label lblPreciov_catprod;
        private System.Windows.Forms.Label lblCmax_catprod;
        private System.Windows.Forms.Label lblCmin_catprod;
        private System.Windows.Forms.Label lblCtotal_catprod;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtNom_catprod;
        private System.Windows.Forms.TextBox txtPrecioc_catprod;
        private System.Windows.Forms.TextBox txtPreciov_catprod;
        private System.Windows.Forms.TextBox txtCmax_catprod;
        private System.Windows.Forms.TextBox txtCmin_catprod;
        private System.Windows.Forms.TextBox txtCtotal_catprod;
        private System.Windows.Forms.Label lblCod_catprod;
        private System.Windows.Forms.TextBox txtCod_catprod;
        private System.Windows.Forms.Label lblEstado_catprod;
        private System.Windows.Forms.ComboBox cboEstado_catprod;
        private System.Windows.Forms.TextBox txtEstado_catprod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipo_catprod;
        private System.Windows.Forms.ComboBox cboTipo_catprod;

    }
}