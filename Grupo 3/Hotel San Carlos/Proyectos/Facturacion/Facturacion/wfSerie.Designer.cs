namespace Facturacion
{
    partial class wfSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfSerie));
            this.navegador1 = new Navegador.Navegador();
            this.lbCod_srie = new System.Windows.Forms.Label();
            this.lblSerie_srie = new System.Windows.Forms.Label();
            this.lbEstado_srie = new System.Windows.Forms.Label();
            this.txtCod_srie = new System.Windows.Forms.TextBox();
            this.txtSerie_srie = new System.Windows.Forms.TextBox();
            this.txtEstado_srie = new System.Windows.Forms.TextBox();
            this.cboEstado_srie = new System.Windows.Forms.ComboBox();
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
            this.navegador1.sNombreTabla = "tabm_feserie";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // lbCod_srie
            // 
            this.lbCod_srie.AutoSize = true;
            this.lbCod_srie.Location = new System.Drawing.Point(12, 83);
            this.lbCod_srie.Name = "lbCod_srie";
            this.lbCod_srie.Size = new System.Drawing.Size(46, 15);
            this.lbCod_srie.TabIndex = 1;
            this.lbCod_srie.Text = "Código";
            // 
            // lblSerie_srie
            // 
            this.lblSerie_srie.AutoSize = true;
            this.lblSerie_srie.Location = new System.Drawing.Point(418, 83);
            this.lblSerie_srie.Name = "lblSerie_srie";
            this.lblSerie_srie.Size = new System.Drawing.Size(36, 15);
            this.lblSerie_srie.TabIndex = 2;
            this.lblSerie_srie.Text = "Serie";
            // 
            // lbEstado_srie
            // 
            this.lbEstado_srie.AutoSize = true;
            this.lbEstado_srie.Location = new System.Drawing.Point(12, 110);
            this.lbEstado_srie.Name = "lbEstado_srie";
            this.lbEstado_srie.Size = new System.Drawing.Size(45, 15);
            this.lbEstado_srie.TabIndex = 3;
            this.lbEstado_srie.Text = "Estado";
            // 
            // txtCod_srie
            // 
            this.txtCod_srie.Location = new System.Drawing.Point(64, 80);
            this.txtCod_srie.MaxLength = 4;
            this.txtCod_srie.Name = "txtCod_srie";
            this.txtCod_srie.Size = new System.Drawing.Size(150, 21);
            this.txtCod_srie.TabIndex = 12;
            this.txtCod_srie.Tag = "cod_srie";
            this.txtCod_srie.EnabledChanged += new System.EventHandler(this.txtCod_srie_EnabledChanged);
            this.txtCod_srie.TextChanged += new System.EventHandler(this.txtCod_srie_TextChanged);
            // 
            // txtSerie_srie
            // 
            this.txtSerie_srie.Location = new System.Drawing.Point(460, 80);
            this.txtSerie_srie.MaxLength = 25;
            this.txtSerie_srie.Name = "txtSerie_srie";
            this.txtSerie_srie.Size = new System.Drawing.Size(150, 21);
            this.txtSerie_srie.TabIndex = 13;
            this.txtSerie_srie.Tag = "serie_srie";
            this.txtSerie_srie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerie_srie_KeyPress);
            // 
            // txtEstado_srie
            // 
            this.txtEstado_srie.Location = new System.Drawing.Point(220, 107);
            this.txtEstado_srie.MaxLength = 1;
            this.txtEstado_srie.Name = "txtEstado_srie";
            this.txtEstado_srie.Size = new System.Drawing.Size(26, 21);
            this.txtEstado_srie.TabIndex = 7;
            this.txtEstado_srie.Tag = "estado_srie";
            this.txtEstado_srie.Visible = false;
            this.txtEstado_srie.EnabledChanged += new System.EventHandler(this.txtEstado_srie_EnabledChanged);
            this.txtEstado_srie.TextChanged += new System.EventHandler(this.txtEstado_srie_TextChanged);
            // 
            // cboEstado_srie
            // 
            this.cboEstado_srie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_srie.FormattingEnabled = true;
            this.cboEstado_srie.IntegralHeight = false;
            this.cboEstado_srie.ItemHeight = 15;
            this.cboEstado_srie.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cboEstado_srie.Location = new System.Drawing.Point(64, 107);
            this.cboEstado_srie.Name = "cboEstado_srie";
            this.cboEstado_srie.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_srie.TabIndex = 14;
            this.cboEstado_srie.SelectedIndexChanged += new System.EventHandler(this.cboEstado_srie_SelectedIndexChanged);
            // 
            // wfSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 140);
            this.Controls.Add(this.cboEstado_srie);
            this.Controls.Add(this.txtEstado_srie);
            this.Controls.Add(this.txtSerie_srie);
            this.Controls.Add(this.txtCod_srie);
            this.Controls.Add(this.lbEstado_srie);
            this.Controls.Add(this.lblSerie_srie);
            this.Controls.Add(this.lbCod_srie);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfSerie";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Series";
            this.Load += new System.EventHandler(this.wfSerie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lbCod_srie;
        private System.Windows.Forms.Label lblSerie_srie;
        private System.Windows.Forms.Label lbEstado_srie;
        private System.Windows.Forms.TextBox txtCod_srie;
        private System.Windows.Forms.TextBox txtSerie_srie;
        private System.Windows.Forms.TextBox txtEstado_srie;
        private System.Windows.Forms.ComboBox cboEstado_srie;
    }
}