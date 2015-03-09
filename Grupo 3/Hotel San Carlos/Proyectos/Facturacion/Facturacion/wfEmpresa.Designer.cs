namespace Facturacion
{
    partial class wfEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEmpresa));
            this.lblCod_empresa = new System.Windows.Forms.Label();
            this.txtCod_empresa = new System.Windows.Forms.TextBox();
            this.lblCod_srie = new System.Windows.Forms.Label();
            this.lblRazsocial_empsa = new System.Windows.Forms.Label();
            this.lblNomComercial_empsa = new System.Windows.Forms.Label();
            this.lblNit_empsa = new System.Windows.Forms.Label();
            this.lblDire_empsa = new System.Windows.Forms.Label();
            this.txtRazsocial_empsa = new System.Windows.Forms.TextBox();
            this.txtNomcomercial_empsa = new System.Windows.Forms.TextBox();
            this.txtDire_empsa = new System.Windows.Forms.TextBox();
            this.txtCod_srie = new System.Windows.Forms.TextBox();
            this.txtNit_empsa = new System.Windows.Forms.TextBox();
            this.lblEstado_empsa = new System.Windows.Forms.Label();
            this.cboEstado_empsa = new System.Windows.Forms.ComboBox();
            this.txtEstado_empsa = new System.Windows.Forms.TextBox();
            this.navegador1 = new Navegador.Navegador();
            this.SuspendLayout();
            // 
            // lblCod_empresa
            // 
            this.lblCod_empresa.AutoSize = true;
            this.lblCod_empresa.Location = new System.Drawing.Point(12, 83);
            this.lblCod_empresa.Name = "lblCod_empresa";
            this.lblCod_empresa.Size = new System.Drawing.Size(46, 15);
            this.lblCod_empresa.TabIndex = 1;
            this.lblCod_empresa.Text = "Código";
            // 
            // txtCod_empresa
            // 
            this.txtCod_empresa.Enabled = false;
            this.txtCod_empresa.Location = new System.Drawing.Point(96, 80);
            this.txtCod_empresa.MaxLength = 4;
            this.txtCod_empresa.Name = "txtCod_empresa";
            this.txtCod_empresa.Size = new System.Drawing.Size(150, 21);
            this.txtCod_empresa.TabIndex = 12;
            this.txtCod_empresa.Tag = "cod_empsa";
            this.txtCod_empresa.EnabledChanged += new System.EventHandler(this.txtCod_empresa_EnabledChanged);
            this.txtCod_empresa.TextChanged += new System.EventHandler(this.txtCod_empresa_TextChanged);
            // 
            // lblCod_srie
            // 
            this.lblCod_srie.AutoSize = true;
            this.lblCod_srie.Location = new System.Drawing.Point(346, 83);
            this.lblCod_srie.Name = "lblCod_srie";
            this.lblCod_srie.Size = new System.Drawing.Size(93, 15);
            this.lblCod_srie.TabIndex = 3;
            this.lblCod_srie.Text = "Código de serie";
            // 
            // lblRazsocial_empsa
            // 
            this.lblRazsocial_empsa.AutoSize = true;
            this.lblRazsocial_empsa.Location = new System.Drawing.Point(12, 110);
            this.lblRazsocial_empsa.Name = "lblRazsocial_empsa";
            this.lblRazsocial_empsa.Size = new System.Drawing.Size(78, 15);
            this.lblRazsocial_empsa.TabIndex = 4;
            this.lblRazsocial_empsa.Text = "Razón social";
            // 
            // lblNomComercial_empsa
            // 
            this.lblNomComercial_empsa.AutoSize = true;
            this.lblNomComercial_empsa.Location = new System.Drawing.Point(346, 110);
            this.lblNomComercial_empsa.Name = "lblNomComercial_empsa";
            this.lblNomComercial_empsa.Size = new System.Drawing.Size(109, 15);
            this.lblNomComercial_empsa.TabIndex = 5;
            this.lblNomComercial_empsa.Text = "Nombre comercial";
            // 
            // lblNit_empsa
            // 
            this.lblNit_empsa.AutoSize = true;
            this.lblNit_empsa.Location = new System.Drawing.Point(346, 137);
            this.lblNit_empsa.Name = "lblNit_empsa";
            this.lblNit_empsa.Size = new System.Drawing.Size(26, 15);
            this.lblNit_empsa.TabIndex = 6;
            this.lblNit_empsa.Text = "NIT";
            // 
            // lblDire_empsa
            // 
            this.lblDire_empsa.AutoSize = true;
            this.lblDire_empsa.Location = new System.Drawing.Point(12, 137);
            this.lblDire_empsa.Name = "lblDire_empsa";
            this.lblDire_empsa.Size = new System.Drawing.Size(59, 15);
            this.lblDire_empsa.TabIndex = 7;
            this.lblDire_empsa.Text = "Dirección";
            // 
            // txtRazsocial_empsa
            // 
            this.txtRazsocial_empsa.Location = new System.Drawing.Point(96, 107);
            this.txtRazsocial_empsa.MaxLength = 50;
            this.txtRazsocial_empsa.Name = "txtRazsocial_empsa";
            this.txtRazsocial_empsa.Size = new System.Drawing.Size(150, 21);
            this.txtRazsocial_empsa.TabIndex = 14;
            this.txtRazsocial_empsa.Tag = "razsocial_empsa";
            this.txtRazsocial_empsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazsocial_empsa_KeyPress);
            // 
            // txtNomcomercial_empsa
            // 
            this.txtNomcomercial_empsa.Location = new System.Drawing.Point(461, 107);
            this.txtNomcomercial_empsa.MaxLength = 50;
            this.txtNomcomercial_empsa.Name = "txtNomcomercial_empsa";
            this.txtNomcomercial_empsa.Size = new System.Drawing.Size(150, 21);
            this.txtNomcomercial_empsa.TabIndex = 15;
            this.txtNomcomercial_empsa.Tag = "nomcomercial_empsa";
            this.txtNomcomercial_empsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomcomercial_empsa_KeyPress);
            // 
            // txtDire_empsa
            // 
            this.txtDire_empsa.Location = new System.Drawing.Point(96, 134);
            this.txtDire_empsa.MaxLength = 50;
            this.txtDire_empsa.Name = "txtDire_empsa";
            this.txtDire_empsa.Size = new System.Drawing.Size(150, 21);
            this.txtDire_empsa.TabIndex = 16;
            this.txtDire_empsa.Tag = "dire_empsa";
            this.txtDire_empsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDire_empsa_KeyPress);
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
            this.txtCod_srie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_srie_KeyPress);
            // 
            // txtNit_empsa
            // 
            this.txtNit_empsa.Location = new System.Drawing.Point(461, 134);
            this.txtNit_empsa.MaxLength = 25;
            this.txtNit_empsa.Name = "txtNit_empsa";
            this.txtNit_empsa.Size = new System.Drawing.Size(150, 21);
            this.txtNit_empsa.TabIndex = 17;
            this.txtNit_empsa.Tag = "nit_empsa";
            this.txtNit_empsa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_empsa_KeyPress);
            // 
            // lblEstado_empsa
            // 
            this.lblEstado_empsa.AutoSize = true;
            this.lblEstado_empsa.Location = new System.Drawing.Point(12, 164);
            this.lblEstado_empsa.Name = "lblEstado_empsa";
            this.lblEstado_empsa.Size = new System.Drawing.Size(45, 15);
            this.lblEstado_empsa.TabIndex = 15;
            this.lblEstado_empsa.Text = "Estado";
            // 
            // cboEstado_empsa
            // 
            this.cboEstado_empsa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_empsa.FormattingEnabled = true;
            this.cboEstado_empsa.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado_empsa.Location = new System.Drawing.Point(96, 161);
            this.cboEstado_empsa.Name = "cboEstado_empsa";
            this.cboEstado_empsa.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_empsa.TabIndex = 18;
            this.cboEstado_empsa.SelectedIndexChanged += new System.EventHandler(this.cboEstado_empsa_SelectedIndexChanged);
            // 
            // txtEstado_empsa
            // 
            this.txtEstado_empsa.Location = new System.Drawing.Point(252, 161);
            this.txtEstado_empsa.Name = "txtEstado_empsa";
            this.txtEstado_empsa.Size = new System.Drawing.Size(21, 21);
            this.txtEstado_empsa.TabIndex = 19;
            this.txtEstado_empsa.Tag = "estado_empsa";
            this.txtEstado_empsa.Visible = false;
            this.txtEstado_empsa.EnabledChanged += new System.EventHandler(this.txtEstado_empsa_EnabledChanged);
            this.txtEstado_empsa.TextChanged += new System.EventHandler(this.txtEstado_empsa_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_feempresa";
            this.navegador1.TabIndex = 21;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // wfEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 195);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstado_empsa);
            this.Controls.Add(this.cboEstado_empsa);
            this.Controls.Add(this.lblEstado_empsa);
            this.Controls.Add(this.txtNit_empsa);
            this.Controls.Add(this.txtCod_srie);
            this.Controls.Add(this.txtDire_empsa);
            this.Controls.Add(this.txtNomcomercial_empsa);
            this.Controls.Add(this.txtRazsocial_empsa);
            this.Controls.Add(this.lblDire_empsa);
            this.Controls.Add(this.lblNit_empsa);
            this.Controls.Add(this.lblNomComercial_empsa);
            this.Controls.Add(this.lblRazsocial_empsa);
            this.Controls.Add(this.lblCod_srie);
            this.Controls.Add(this.txtCod_empresa);
            this.Controls.Add(this.lblCod_empresa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfEmpresa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.wfEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod_empresa;
        private System.Windows.Forms.TextBox txtCod_empresa;
        private System.Windows.Forms.Label lblCod_srie;
        private System.Windows.Forms.Label lblRazsocial_empsa;
        private System.Windows.Forms.Label lblNomComercial_empsa;
        private System.Windows.Forms.Label lblNit_empsa;
        private System.Windows.Forms.Label lblDire_empsa;
        private System.Windows.Forms.TextBox txtRazsocial_empsa;
        private System.Windows.Forms.TextBox txtNomcomercial_empsa;
        private System.Windows.Forms.TextBox txtDire_empsa;
        private System.Windows.Forms.TextBox txtCod_srie;
        private System.Windows.Forms.TextBox txtNit_empsa;
        private System.Windows.Forms.Label lblEstado_empsa;
        private System.Windows.Forms.ComboBox cboEstado_empsa;
        private System.Windows.Forms.TextBox txtEstado_empsa;
        private Navegador.Navegador navegador1;
    }
}