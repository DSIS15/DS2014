namespace Inventario
{
    partial class wfSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfSucursal));
            this.navegador1 = new Navegador.Navegador();
            this.txtNom_suc = new System.Windows.Forms.TextBox();
            this.txtCod_suc = new System.Windows.Forms.TextBox();
            this.lbNombreSucursal = new System.Windows.Forms.Label();
            this.lbCodSucursal = new System.Windows.Forms.Label();
            this.txtUbic_suc = new System.Windows.Forms.TextBox();
            this.lbUbiSucursal = new System.Windows.Forms.Label();
            this.txtEstadoSucursal = new System.Windows.Forms.TextBox();
            this.lbEstadoSerie = new System.Windows.Forms.Label();
            this.cboEstado_suc = new System.Windows.Forms.ComboBox();
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
            this.navegador1.sNombreTabla = "tabm_fesucursal";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // txtNom_suc
            // 
            this.txtNom_suc.Location = new System.Drawing.Point(70, 107);
            this.txtNom_suc.MaxLength = 25;
            this.txtNom_suc.Name = "txtNom_suc";
            this.txtNom_suc.Size = new System.Drawing.Size(150, 21);
            this.txtNom_suc.TabIndex = 13;
            this.txtNom_suc.Tag = "nom_suc";
            this.txtNom_suc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreSucursal_KeyPress);
            // 
            // txtCod_suc
            // 
            this.txtCod_suc.Location = new System.Drawing.Point(70, 80);
            this.txtCod_suc.MaxLength = 4;
            this.txtCod_suc.Name = "txtCod_suc";
            this.txtCod_suc.Size = new System.Drawing.Size(150, 21);
            this.txtCod_suc.TabIndex = 12;
            this.txtCod_suc.Tag = "cod_suc";
            this.txtCod_suc.EnabledChanged += new System.EventHandler(this.txtCod_suc_EnabledChanged);
            this.txtCod_suc.TextChanged += new System.EventHandler(this.txtCodSucursal_TextChanged);
            this.txtCod_suc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodSucursal_KeyPress);
            // 
            // lbNombreSucursal
            // 
            this.lbNombreSucursal.AutoSize = true;
            this.lbNombreSucursal.Location = new System.Drawing.Point(12, 110);
            this.lbNombreSucursal.Name = "lbNombreSucursal";
            this.lbNombreSucursal.Size = new System.Drawing.Size(52, 15);
            this.lbNombreSucursal.TabIndex = 0;
            this.lbNombreSucursal.Text = "Nombre";
            // 
            // lbCodSucursal
            // 
            this.lbCodSucursal.AutoSize = true;
            this.lbCodSucursal.Location = new System.Drawing.Point(12, 83);
            this.lbCodSucursal.Name = "lbCodSucursal";
            this.lbCodSucursal.Size = new System.Drawing.Size(46, 15);
            this.lbCodSucursal.TabIndex = 0;
            this.lbCodSucursal.Text = "Código";
            // 
            // txtUbic_suc
            // 
            this.txtUbic_suc.Location = new System.Drawing.Point(460, 107);
            this.txtUbic_suc.MaxLength = 25;
            this.txtUbic_suc.Name = "txtUbic_suc";
            this.txtUbic_suc.Size = new System.Drawing.Size(150, 21);
            this.txtUbic_suc.TabIndex = 14;
            this.txtUbic_suc.Tag = "ubic_suc";
            this.txtUbic_suc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUbiSucursal_KeyPress);
            // 
            // lbUbiSucursal
            // 
            this.lbUbiSucursal.AutoSize = true;
            this.lbUbiSucursal.Location = new System.Drawing.Point(392, 110);
            this.lbUbiSucursal.Name = "lbUbiSucursal";
            this.lbUbiSucursal.Size = new System.Drawing.Size(62, 15);
            this.lbUbiSucursal.TabIndex = 0;
            this.lbUbiSucursal.Text = "Ubicación";
            // 
            // txtEstadoSucursal
            // 
            this.txtEstadoSucursal.Location = new System.Drawing.Point(226, 134);
            this.txtEstadoSucursal.MaxLength = 1;
            this.txtEstadoSucursal.Name = "txtEstadoSucursal";
            this.txtEstadoSucursal.Size = new System.Drawing.Size(21, 21);
            this.txtEstadoSucursal.TabIndex = 16;
            this.txtEstadoSucursal.Tag = "estado_suc";
            this.txtEstadoSucursal.Visible = false;
            this.txtEstadoSucursal.EnabledChanged += new System.EventHandler(this.txtEstadoSucursal_EnabledChanged);
            this.txtEstadoSucursal.TextChanged += new System.EventHandler(this.txtEstadoSucursal_TextChanged);
            // 
            // lbEstadoSerie
            // 
            this.lbEstadoSerie.AutoSize = true;
            this.lbEstadoSerie.Location = new System.Drawing.Point(12, 137);
            this.lbEstadoSerie.Name = "lbEstadoSerie";
            this.lbEstadoSerie.Size = new System.Drawing.Size(45, 15);
            this.lbEstadoSerie.TabIndex = 0;
            this.lbEstadoSerie.Text = "Estado";
            // 
            // cboEstado_suc
            // 
            this.cboEstado_suc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_suc.Enabled = false;
            this.cboEstado_suc.FormattingEnabled = true;
            this.cboEstado_suc.IntegralHeight = false;
            this.cboEstado_suc.Items.AddRange(new object[] {
            "Activado ",
            "Desactivado"});
            this.cboEstado_suc.Location = new System.Drawing.Point(70, 134);
            this.cboEstado_suc.Name = "cboEstado_suc";
            this.cboEstado_suc.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_suc.TabIndex = 15;
            this.cboEstado_suc.SelectedIndexChanged += new System.EventHandler(this.cboEstadoSucursal_SelectedIndexChanged);
            // 
            // wfSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 167);
            this.Controls.Add(this.cboEstado_suc);
            this.Controls.Add(this.txtEstadoSucursal);
            this.Controls.Add(this.lbEstadoSerie);
            this.Controls.Add(this.txtUbic_suc);
            this.Controls.Add(this.lbUbiSucursal);
            this.Controls.Add(this.txtNom_suc);
            this.Controls.Add(this.txtCod_suc);
            this.Controls.Add(this.lbNombreSucursal);
            this.Controls.Add(this.lbCodSucursal);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfSucursal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.wfSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtNom_suc;
        private System.Windows.Forms.TextBox txtCod_suc;
        private System.Windows.Forms.Label lbNombreSucursal;
        private System.Windows.Forms.Label lbCodSucursal;
        private System.Windows.Forms.TextBox txtUbic_suc;
        private System.Windows.Forms.Label lbUbiSucursal;
        private System.Windows.Forms.TextBox txtEstadoSucursal;
        private System.Windows.Forms.Label lbEstadoSerie;
        private System.Windows.Forms.ComboBox cboEstado_suc;
    }
}