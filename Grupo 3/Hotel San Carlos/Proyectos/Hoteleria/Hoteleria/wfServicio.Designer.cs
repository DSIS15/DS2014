namespace Hoteleria
{
    partial class wfServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfServicio));
            this.navegador1 = new Navegador.Navegador();
            this.lblCod_serv = new System.Windows.Forms.Label();
            this.txtCod_serv = new System.Windows.Forms.TextBox();
            this.txtServicio_serv = new System.Windows.Forms.TextBox();
            this.lblServicio_serv = new System.Windows.Forms.Label();
            this.lblDisponibilidad_serv = new System.Windows.Forms.Label();
            this.cboDisponibilidad_serv = new System.Windows.Forms.ComboBox();
            this.cboEstado_serv = new System.Windows.Forms.ComboBox();
            this.lblEstado_serv = new System.Windows.Forms.Label();
            this.txtDisponibilidad_serv = new System.Windows.Forms.TextBox();
            this.txtEstado_serv = new System.Windows.Forms.TextBox();
            this.lblPrecio_serv = new System.Windows.Forms.Label();
            this.txtPrecio_serv = new System.Windows.Forms.TextBox();
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
            this.navegador1.sNombreTabla = "tabm_feservicio";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            this.navegador1.btnImprimir_AfterClick += new System.EventHandler(this.navegador1_btnImprimir_AfterClick);
            // 
            // lblCod_serv
            // 
            this.lblCod_serv.AutoSize = true;
            this.lblCod_serv.Location = new System.Drawing.Point(12, 83);
            this.lblCod_serv.Name = "lblCod_serv";
            this.lblCod_serv.Size = new System.Drawing.Size(46, 15);
            this.lblCod_serv.TabIndex = 1;
            this.lblCod_serv.Text = "Código";
            // 
            // txtCod_serv
            // 
            this.txtCod_serv.Location = new System.Drawing.Point(63, 80);
            this.txtCod_serv.MaxLength = 4;
            this.txtCod_serv.Name = "txtCod_serv";
            this.txtCod_serv.Size = new System.Drawing.Size(150, 21);
            this.txtCod_serv.TabIndex = 12;
            this.txtCod_serv.Tag = "cod_serv";
            this.txtCod_serv.EnabledChanged += new System.EventHandler(this.txtCod_serv_EnabledChanged);
            // 
            // txtServicio_serv
            // 
            this.txtServicio_serv.Location = new System.Drawing.Point(460, 80);
            this.txtServicio_serv.MaxLength = 25;
            this.txtServicio_serv.Name = "txtServicio_serv";
            this.txtServicio_serv.Size = new System.Drawing.Size(150, 21);
            this.txtServicio_serv.TabIndex = 13;
            this.txtServicio_serv.Tag = "servicio_serv";
            this.txtServicio_serv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServicio_serv_KeyPress);
            // 
            // lblServicio_serv
            // 
            this.lblServicio_serv.AutoSize = true;
            this.lblServicio_serv.Location = new System.Drawing.Point(368, 83);
            this.lblServicio_serv.Name = "lblServicio_serv";
            this.lblServicio_serv.Size = new System.Drawing.Size(50, 15);
            this.lblServicio_serv.TabIndex = 3;
            this.lblServicio_serv.Text = "Servicio";
            // 
            // lblDisponibilidad_serv
            // 
            this.lblDisponibilidad_serv.AutoSize = true;
            this.lblDisponibilidad_serv.Location = new System.Drawing.Point(368, 110);
            this.lblDisponibilidad_serv.Name = "lblDisponibilidad_serv";
            this.lblDisponibilidad_serv.Size = new System.Drawing.Size(86, 15);
            this.lblDisponibilidad_serv.TabIndex = 5;
            this.lblDisponibilidad_serv.Text = "Disponibilidad";
            // 
            // cboDisponibilidad_serv
            // 
            this.cboDisponibilidad_serv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisponibilidad_serv.FormattingEnabled = true;
            this.cboDisponibilidad_serv.Items.AddRange(new object[] {
            "Disponible",
            "No disponible"});
            this.cboDisponibilidad_serv.Location = new System.Drawing.Point(460, 107);
            this.cboDisponibilidad_serv.Name = "cboDisponibilidad_serv";
            this.cboDisponibilidad_serv.Size = new System.Drawing.Size(150, 23);
            this.cboDisponibilidad_serv.TabIndex = 15;
            this.cboDisponibilidad_serv.SelectedIndexChanged += new System.EventHandler(this.cboDisponibilidad_serv_SelectedIndexChanged);
            // 
            // cboEstado_serv
            // 
            this.cboEstado_serv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_serv.FormattingEnabled = true;
            this.cboEstado_serv.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado_serv.Location = new System.Drawing.Point(64, 134);
            this.cboEstado_serv.Name = "cboEstado_serv";
            this.cboEstado_serv.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_serv.TabIndex = 16;
            this.cboEstado_serv.SelectedIndexChanged += new System.EventHandler(this.cboEstado_serv_SelectedIndexChanged);
            // 
            // lblEstado_serv
            // 
            this.lblEstado_serv.AutoSize = true;
            this.lblEstado_serv.Location = new System.Drawing.Point(12, 137);
            this.lblEstado_serv.Name = "lblEstado_serv";
            this.lblEstado_serv.Size = new System.Drawing.Size(45, 15);
            this.lblEstado_serv.TabIndex = 7;
            this.lblEstado_serv.Text = "Estado";
            // 
            // txtDisponibilidad_serv
            // 
            this.txtDisponibilidad_serv.Location = new System.Drawing.Point(341, 107);
            this.txtDisponibilidad_serv.Name = "txtDisponibilidad_serv";
            this.txtDisponibilidad_serv.Size = new System.Drawing.Size(21, 21);
            this.txtDisponibilidad_serv.TabIndex = 9;
            this.txtDisponibilidad_serv.Tag = "disponibilidad_serv";
            this.txtDisponibilidad_serv.Visible = false;
            this.txtDisponibilidad_serv.EnabledChanged += new System.EventHandler(this.txtDisponibilidad_serv_EnabledChanged);
            this.txtDisponibilidad_serv.TextChanged += new System.EventHandler(this.txtDisponibilidad_serv_TextChanged);
            // 
            // txtEstado_serv
            // 
            this.txtEstado_serv.Location = new System.Drawing.Point(220, 134);
            this.txtEstado_serv.Name = "txtEstado_serv";
            this.txtEstado_serv.Size = new System.Drawing.Size(21, 21);
            this.txtEstado_serv.TabIndex = 10;
            this.txtEstado_serv.Tag = "estado_serv";
            this.txtEstado_serv.Visible = false;
            this.txtEstado_serv.EnabledChanged += new System.EventHandler(this.txtEstado_serv_EnabledChanged);
            this.txtEstado_serv.TextChanged += new System.EventHandler(this.txtEstado_serv_TextChanged);
            // 
            // lblPrecio_serv
            // 
            this.lblPrecio_serv.AutoSize = true;
            this.lblPrecio_serv.Location = new System.Drawing.Point(12, 110);
            this.lblPrecio_serv.Name = "lblPrecio_serv";
            this.lblPrecio_serv.Size = new System.Drawing.Size(42, 15);
            this.lblPrecio_serv.TabIndex = 16;
            this.lblPrecio_serv.Text = "Precio";
            // 
            // txtPrecio_serv
            // 
            this.txtPrecio_serv.Location = new System.Drawing.Point(63, 107);
            this.txtPrecio_serv.MaxLength = 10;
            this.txtPrecio_serv.Name = "txtPrecio_serv";
            this.txtPrecio_serv.Size = new System.Drawing.Size(150, 21);
            this.txtPrecio_serv.TabIndex = 14;
            this.txtPrecio_serv.Tag = "precio_serv";
            this.txtPrecio_serv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_serv_KeyPress);
            // 
            // wfServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 168);
            this.Controls.Add(this.txtPrecio_serv);
            this.Controls.Add(this.lblPrecio_serv);
            this.Controls.Add(this.txtEstado_serv);
            this.Controls.Add(this.txtDisponibilidad_serv);
            this.Controls.Add(this.cboEstado_serv);
            this.Controls.Add(this.lblEstado_serv);
            this.Controls.Add(this.cboDisponibilidad_serv);
            this.Controls.Add(this.lblDisponibilidad_serv);
            this.Controls.Add(this.txtServicio_serv);
            this.Controls.Add(this.lblServicio_serv);
            this.Controls.Add(this.txtCod_serv);
            this.Controls.Add(this.lblCod_serv);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfServicio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.wfServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCod_serv;
        private System.Windows.Forms.TextBox txtCod_serv;
        private System.Windows.Forms.TextBox txtServicio_serv;
        private System.Windows.Forms.Label lblServicio_serv;
        private System.Windows.Forms.Label lblDisponibilidad_serv;
        private System.Windows.Forms.ComboBox cboDisponibilidad_serv;
        private System.Windows.Forms.ComboBox cboEstado_serv;
        private System.Windows.Forms.Label lblEstado_serv;
        private System.Windows.Forms.TextBox txtDisponibilidad_serv;
        private System.Windows.Forms.TextBox txtEstado_serv;
        private System.Windows.Forms.Label lblPrecio_serv;
        private System.Windows.Forms.TextBox txtPrecio_serv;
    }
}