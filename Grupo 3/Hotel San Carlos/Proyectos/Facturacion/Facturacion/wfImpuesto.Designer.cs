namespace Facturacion
{
    partial class wfImpuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfImpuesto));
            this.txtCod_imp = new System.Windows.Forms.TextBox();
            this.txtNom_imp = new System.Windows.Forms.TextBox();
            this.txtValor_imp = new System.Windows.Forms.TextBox();
            this.txtEstado_imp = new System.Windows.Forms.TextBox();
            this.cboEstado_imp = new System.Windows.Forms.ComboBox();
            this.lblCod_imp = new System.Windows.Forms.Label();
            this.lblNom_imp = new System.Windows.Forms.Label();
            this.lblValor_imp = new System.Windows.Forms.Label();
            this.lblEstado_imp = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.SuspendLayout();
            // 
            // txtCod_imp
            // 
            this.txtCod_imp.Location = new System.Drawing.Point(115, 80);
            this.txtCod_imp.MaxLength = 4;
            this.txtCod_imp.Name = "txtCod_imp";
            this.txtCod_imp.Size = new System.Drawing.Size(150, 21);
            this.txtCod_imp.TabIndex = 12;
            this.txtCod_imp.Tag = "cod_imp";
            this.txtCod_imp.EnabledChanged += new System.EventHandler(this.txtCod_imp_EnabledChanged);
            this.txtCod_imp.TextChanged += new System.EventHandler(this.txtCod_imp_TextChanged);
            // 
            // txtNom_imp
            // 
            this.txtNom_imp.Location = new System.Drawing.Point(460, 80);
            this.txtNom_imp.MaxLength = 25;
            this.txtNom_imp.Name = "txtNom_imp";
            this.txtNom_imp.Size = new System.Drawing.Size(150, 21);
            this.txtNom_imp.TabIndex = 13;
            this.txtNom_imp.Tag = "nom_imp";
            this.txtNom_imp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_imp_KeyPress);
            // 
            // txtValor_imp
            // 
            this.txtValor_imp.Location = new System.Drawing.Point(115, 107);
            this.txtValor_imp.MaxLength = 10;
            this.txtValor_imp.Name = "txtValor_imp";
            this.txtValor_imp.Size = new System.Drawing.Size(150, 21);
            this.txtValor_imp.TabIndex = 14;
            this.txtValor_imp.Tag = "valor_imp";
            this.txtValor_imp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_imp_KeyPress);
            // 
            // txtEstado_imp
            // 
            this.txtEstado_imp.Location = new System.Drawing.Point(317, 107);
            this.txtEstado_imp.MaxLength = 1;
            this.txtEstado_imp.Name = "txtEstado_imp";
            this.txtEstado_imp.Size = new System.Drawing.Size(24, 21);
            this.txtEstado_imp.TabIndex = 16;
            this.txtEstado_imp.Tag = "estado_imp";
            this.txtEstado_imp.Visible = false;
            this.txtEstado_imp.EnabledChanged += new System.EventHandler(this.txtEstado_imp_EnabledChanged);
            this.txtEstado_imp.TextChanged += new System.EventHandler(this.txtEstado_imp_TextChanged);
            // 
            // cboEstado_imp
            // 
            this.cboEstado_imp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_imp.FormattingEnabled = true;
            this.cboEstado_imp.IntegralHeight = false;
            this.cboEstado_imp.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cboEstado_imp.Location = new System.Drawing.Point(460, 107);
            this.cboEstado_imp.Name = "cboEstado_imp";
            this.cboEstado_imp.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_imp.TabIndex = 15;
            this.cboEstado_imp.SelectedIndexChanged += new System.EventHandler(this.cboEstado_imp_SelectedIndexChanged);
            // 
            // lblCod_imp
            // 
            this.lblCod_imp.AutoSize = true;
            this.lblCod_imp.Location = new System.Drawing.Point(12, 84);
            this.lblCod_imp.Name = "lblCod_imp";
            this.lblCod_imp.Size = new System.Drawing.Size(100, 15);
            this.lblCod_imp.TabIndex = 6;
            this.lblCod_imp.Text = "Codigo Impuesto";
            // 
            // lblNom_imp
            // 
            this.lblNom_imp.AutoSize = true;
            this.lblNom_imp.Location = new System.Drawing.Point(347, 83);
            this.lblNom_imp.Name = "lblNom_imp";
            this.lblNom_imp.Size = new System.Drawing.Size(106, 15);
            this.lblNom_imp.TabIndex = 7;
            this.lblNom_imp.Text = "Nombre Impuesto";
            // 
            // lblValor_imp
            // 
            this.lblValor_imp.AutoSize = true;
            this.lblValor_imp.Location = new System.Drawing.Point(12, 110);
            this.lblValor_imp.Name = "lblValor_imp";
            this.lblValor_imp.Size = new System.Drawing.Size(89, 15);
            this.lblValor_imp.TabIndex = 8;
            this.lblValor_imp.Text = "Valor Impuesto";
            // 
            // lblEstado_imp
            // 
            this.lblEstado_imp.AutoSize = true;
            this.lblEstado_imp.Location = new System.Drawing.Point(347, 110);
            this.lblEstado_imp.Name = "lblEstado_imp";
            this.lblEstado_imp.Size = new System.Drawing.Size(99, 15);
            this.lblEstado_imp.TabIndex = 9;
            this.lblEstado_imp.Text = "Estado Impuesto";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_feimpuesto";
            this.navegador1.TabIndex = 10;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // wfImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 143);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblEstado_imp);
            this.Controls.Add(this.lblValor_imp);
            this.Controls.Add(this.lblNom_imp);
            this.Controls.Add(this.lblCod_imp);
            this.Controls.Add(this.cboEstado_imp);
            this.Controls.Add(this.txtEstado_imp);
            this.Controls.Add(this.txtValor_imp);
            this.Controls.Add(this.txtNom_imp);
            this.Controls.Add(this.txtCod_imp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfImpuesto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impuestos";
            this.Load += new System.EventHandler(this.wfImpuesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod_imp;
        private System.Windows.Forms.TextBox txtNom_imp;
        private System.Windows.Forms.TextBox txtValor_imp;
        private System.Windows.Forms.TextBox txtEstado_imp;
        private System.Windows.Forms.ComboBox cboEstado_imp;
        private System.Windows.Forms.Label lblCod_imp;
        private System.Windows.Forms.Label lblNom_imp;
        private System.Windows.Forms.Label lblValor_imp;
        private System.Windows.Forms.Label lblEstado_imp;
        private Navegador.Navegador navegador1;
    }
}