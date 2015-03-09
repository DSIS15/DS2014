namespace Hoteleria
{
    partial class wfTipoAmbiente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfTipoAmbiente));
            this.navegador1 = new Navegador.Navegador();
            this.txtCod_tamb = new System.Windows.Forms.TextBox();
            this.txtAmbiente_tamb = new System.Windows.Forms.TextBox();
            this.cboEstado_tamb = new System.Windows.Forms.ComboBox();
            this.txtEstado_tamb = new System.Windows.Forms.TextBox();
            this.lblCod_tamb = new System.Windows.Forms.Label();
            this.lblAmbiente_tamb = new System.Windows.Forms.Label();
            this.lblEstado_tamb = new System.Windows.Forms.Label();
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
            this.navegador1.sNombreTabla = "tabm_fetambiente";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            // 
            // txtCod_tamb
            // 
            this.txtCod_tamb.Location = new System.Drawing.Point(121, 80);
            this.txtCod_tamb.MaxLength = 4;
            this.txtCod_tamb.Name = "txtCod_tamb";
            this.txtCod_tamb.Size = new System.Drawing.Size(150, 21);
            this.txtCod_tamb.TabIndex = 12;
            this.txtCod_tamb.Tag = "cod_tamb";
            this.txtCod_tamb.EnabledChanged += new System.EventHandler(this.txtCod_tamb_EnabledChanged);
            this.txtCod_tamb.TextChanged += new System.EventHandler(this.txtCod_tamb_TextChanged);
            // 
            // txtAmbiente_tamb
            // 
            this.txtAmbiente_tamb.Location = new System.Drawing.Point(121, 107);
            this.txtAmbiente_tamb.MaxLength = 25;
            this.txtAmbiente_tamb.Name = "txtAmbiente_tamb";
            this.txtAmbiente_tamb.Size = new System.Drawing.Size(150, 21);
            this.txtAmbiente_tamb.TabIndex = 13;
            this.txtAmbiente_tamb.Tag = "ambiente_tamb";
            this.txtAmbiente_tamb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmbiente_tamb_KeyPress);
            // 
            // cboEstado_tamb
            // 
            this.cboEstado_tamb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_tamb.Enabled = false;
            this.cboEstado_tamb.FormattingEnabled = true;
            this.cboEstado_tamb.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado_tamb.Location = new System.Drawing.Point(460, 107);
            this.cboEstado_tamb.Name = "cboEstado_tamb";
            this.cboEstado_tamb.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_tamb.TabIndex = 14;
            this.cboEstado_tamb.Tag = "";
            this.cboEstado_tamb.SelectedIndexChanged += new System.EventHandler(this.cboEstado_tamb_SelectedIndexChanged);
            // 
            // txtEstado_tamb
            // 
            this.txtEstado_tamb.Location = new System.Drawing.Point(382, 107);
            this.txtEstado_tamb.Name = "txtEstado_tamb";
            this.txtEstado_tamb.Size = new System.Drawing.Size(21, 21);
            this.txtEstado_tamb.TabIndex = 3;
            this.txtEstado_tamb.Tag = "estado_tamb";
            this.txtEstado_tamb.Visible = false;
            this.txtEstado_tamb.EnabledChanged += new System.EventHandler(this.txtEstado_tamb_EnabledChanged);
            this.txtEstado_tamb.TextChanged += new System.EventHandler(this.txtEstado_tamb_TextChanged);
            // 
            // lblCod_tamb
            // 
            this.lblCod_tamb.AutoSize = true;
            this.lblCod_tamb.Location = new System.Drawing.Point(12, 83);
            this.lblCod_tamb.Name = "lblCod_tamb";
            this.lblCod_tamb.Size = new System.Drawing.Size(46, 15);
            this.lblCod_tamb.TabIndex = 15;
            this.lblCod_tamb.Text = "Código";
            // 
            // lblAmbiente_tamb
            // 
            this.lblAmbiente_tamb.AutoSize = true;
            this.lblAmbiente_tamb.Location = new System.Drawing.Point(12, 110);
            this.lblAmbiente_tamb.Name = "lblAmbiente_tamb";
            this.lblAmbiente_tamb.Size = new System.Drawing.Size(103, 15);
            this.lblAmbiente_tamb.TabIndex = 16;
            this.lblAmbiente_tamb.Text = "Tipo de ambiente";
            // 
            // lblEstado_tamb
            // 
            this.lblEstado_tamb.AutoSize = true;
            this.lblEstado_tamb.Location = new System.Drawing.Point(409, 110);
            this.lblEstado_tamb.Name = "lblEstado_tamb";
            this.lblEstado_tamb.Size = new System.Drawing.Size(45, 15);
            this.lblEstado_tamb.TabIndex = 17;
            this.lblEstado_tamb.Text = "Estado";
            // 
            // wfTipoAmbiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 139);
            this.Controls.Add(this.lblEstado_tamb);
            this.Controls.Add(this.lblAmbiente_tamb);
            this.Controls.Add(this.lblCod_tamb);
            this.Controls.Add(this.txtEstado_tamb);
            this.Controls.Add(this.cboEstado_tamb);
            this.Controls.Add(this.txtAmbiente_tamb);
            this.Controls.Add(this.txtCod_tamb);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfTipoAmbiente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Ambientes";
            this.Load += new System.EventHandler(this.wfTipoAmbiente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtCod_tamb;
        private System.Windows.Forms.TextBox txtAmbiente_tamb;
        private System.Windows.Forms.ComboBox cboEstado_tamb;
        private System.Windows.Forms.TextBox txtEstado_tamb;
        private System.Windows.Forms.Label lblCod_tamb;
        private System.Windows.Forms.Label lblAmbiente_tamb;
        private System.Windows.Forms.Label lblEstado_tamb;

    }
}

