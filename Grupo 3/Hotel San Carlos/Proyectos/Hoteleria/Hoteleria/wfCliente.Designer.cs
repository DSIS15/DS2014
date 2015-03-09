namespace Hoteleria
{
    partial class wfCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCliente));
            this.navegador1 = new Navegador.Navegador();
            this.txtCod_cte = new System.Windows.Forms.TextBox();
            this.txtDpi_cte = new System.Windows.Forms.TextBox();
            this.txtNit_cte = new System.Windows.Forms.TextBox();
            this.txtNom1_cte = new System.Windows.Forms.TextBox();
            this.txtNom2_cte = new System.Windows.Forms.TextBox();
            this.txtApell1_cte = new System.Windows.Forms.TextBox();
            this.txtApell2_cte = new System.Windows.Forms.TextBox();
            this.txtTel_cte = new System.Windows.Forms.TextBox();
            this.txtCredito_cte = new System.Windows.Forms.TextBox();
            this.txtCargo_cte = new System.Windows.Forms.TextBox();
            this.txtAbono_cte = new System.Windows.Forms.TextBox();
            this.txtCargoacum_cte = new System.Windows.Forms.TextBox();
            this.txtEstado_cte = new System.Windows.Forms.TextBox();
            this.cboEstado_cte = new System.Windows.Forms.ComboBox();
            this.lblCod_cte = new System.Windows.Forms.Label();
            this.lblDpi_cte = new System.Windows.Forms.Label();
            this.lblNit_cte = new System.Windows.Forms.Label();
            this.lblNom1_cte = new System.Windows.Forms.Label();
            this.lblNom2_cte = new System.Windows.Forms.Label();
            this.lblApell1_cte = new System.Windows.Forms.Label();
            this.lblApell2_cte = new System.Windows.Forms.Label();
            this.lblTel_cte = new System.Windows.Forms.Label();
            this.lblCredito_cte = new System.Windows.Forms.Label();
            this.lblCargo_cte = new System.Windows.Forms.Label();
            this.lblAbono_cte = new System.Windows.Forms.Label();
            this.lblCargoacum_cte = new System.Windows.Forms.Label();
            this.lblEstado_cte = new System.Windows.Forms.Label();
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
            this.navegador1.sNombreTabla = "tabm_fecliente";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnLimpiar_BeforeClick += new System.EventHandler(this.navegador1_btnLimpiar_BeforeClick);
            this.navegador1.btnLimpiar_AfterClick += new System.EventHandler(this.navegador1_btnLimpiar_AfterClick);
            this.navegador1.btnImprimir_AfterClick += new System.EventHandler(this.navegador1_btnImprimir_AfterClick);
            // 
            // txtCod_cte
            // 
            this.txtCod_cte.Location = new System.Drawing.Point(108, 80);
            this.txtCod_cte.MaxLength = 4;
            this.txtCod_cte.Name = "txtCod_cte";
            this.txtCod_cte.Size = new System.Drawing.Size(150, 21);
            this.txtCod_cte.TabIndex = 12;
            this.txtCod_cte.Tag = "cod_cte";
            this.txtCod_cte.EnabledChanged += new System.EventHandler(this.txtCod_cte_EnabledChanged);
            this.txtCod_cte.TextChanged += new System.EventHandler(this.txtCod_cte_TextChanged);
            // 
            // txtDpi_cte
            // 
            this.txtDpi_cte.Location = new System.Drawing.Point(108, 107);
            this.txtDpi_cte.MaxLength = 25;
            this.txtDpi_cte.Name = "txtDpi_cte";
            this.txtDpi_cte.Size = new System.Drawing.Size(150, 21);
            this.txtDpi_cte.TabIndex = 13;
            this.txtDpi_cte.Tag = "dpi_cte";
            this.txtDpi_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoc_cte_KeyPress);
            // 
            // txtNit_cte
            // 
            this.txtNit_cte.Location = new System.Drawing.Point(458, 107);
            this.txtNit_cte.MaxLength = 25;
            this.txtNit_cte.Name = "txtNit_cte";
            this.txtNit_cte.Size = new System.Drawing.Size(150, 21);
            this.txtNit_cte.TabIndex = 14;
            this.txtNit_cte.Tag = "nit_cte";
            this.txtNit_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumdoc_cte_KeyPress);
            // 
            // txtNom1_cte
            // 
            this.txtNom1_cte.Location = new System.Drawing.Point(108, 134);
            this.txtNom1_cte.MaxLength = 25;
            this.txtNom1_cte.Name = "txtNom1_cte";
            this.txtNom1_cte.Size = new System.Drawing.Size(150, 21);
            this.txtNom1_cte.TabIndex = 15;
            this.txtNom1_cte.Tag = "nom1_cte";
            this.txtNom1_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom1_cte_KeyPress);
            // 
            // txtNom2_cte
            // 
            this.txtNom2_cte.Location = new System.Drawing.Point(458, 134);
            this.txtNom2_cte.MaxLength = 25;
            this.txtNom2_cte.Name = "txtNom2_cte";
            this.txtNom2_cte.Size = new System.Drawing.Size(150, 21);
            this.txtNom2_cte.TabIndex = 16;
            this.txtNom2_cte.Tag = "nom2_cte";
            this.txtNom2_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom2_cte_KeyPress);
            // 
            // txtApell1_cte
            // 
            this.txtApell1_cte.Location = new System.Drawing.Point(109, 161);
            this.txtApell1_cte.MaxLength = 25;
            this.txtApell1_cte.Name = "txtApell1_cte";
            this.txtApell1_cte.Size = new System.Drawing.Size(150, 21);
            this.txtApell1_cte.TabIndex = 17;
            this.txtApell1_cte.Tag = "apell1_cte";
            this.txtApell1_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApell1_cte_KeyPress);
            // 
            // txtApell2_cte
            // 
            this.txtApell2_cte.Location = new System.Drawing.Point(458, 161);
            this.txtApell2_cte.MaxLength = 25;
            this.txtApell2_cte.Name = "txtApell2_cte";
            this.txtApell2_cte.Size = new System.Drawing.Size(150, 21);
            this.txtApell2_cte.TabIndex = 18;
            this.txtApell2_cte.Tag = "apell2_cte";
            this.txtApell2_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApell2_cte_KeyPress);
            // 
            // txtTel_cte
            // 
            this.txtTel_cte.Location = new System.Drawing.Point(108, 188);
            this.txtTel_cte.MaxLength = 25;
            this.txtTel_cte.Name = "txtTel_cte";
            this.txtTel_cte.Size = new System.Drawing.Size(150, 21);
            this.txtTel_cte.TabIndex = 19;
            this.txtTel_cte.Tag = "tel_cte";
            this.txtTel_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_cte_KeyPress);
            // 
            // txtCredito_cte
            // 
            this.txtCredito_cte.Location = new System.Drawing.Point(109, 215);
            this.txtCredito_cte.MaxLength = 10;
            this.txtCredito_cte.Name = "txtCredito_cte";
            this.txtCredito_cte.Size = new System.Drawing.Size(150, 21);
            this.txtCredito_cte.TabIndex = 20;
            this.txtCredito_cte.Tag = "credito_cte";
            this.txtCredito_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredito_cte_KeyPress);
            // 
            // txtCargo_cte
            // 
            this.txtCargo_cte.Location = new System.Drawing.Point(458, 212);
            this.txtCargo_cte.MaxLength = 10;
            this.txtCargo_cte.Name = "txtCargo_cte";
            this.txtCargo_cte.Size = new System.Drawing.Size(150, 21);
            this.txtCargo_cte.TabIndex = 21;
            this.txtCargo_cte.Tag = "cargo_cte";
            this.txtCargo_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargo_cte_KeyPress);
            // 
            // txtAbono_cte
            // 
            this.txtAbono_cte.Location = new System.Drawing.Point(109, 242);
            this.txtAbono_cte.MaxLength = 10;
            this.txtAbono_cte.Name = "txtAbono_cte";
            this.txtAbono_cte.Size = new System.Drawing.Size(150, 21);
            this.txtAbono_cte.TabIndex = 22;
            this.txtAbono_cte.Tag = "abono_cte";
            this.txtAbono_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbono_cte_KeyPress);
            // 
            // txtCargoacum_cte
            // 
            this.txtCargoacum_cte.Location = new System.Drawing.Point(458, 239);
            this.txtCargoacum_cte.MaxLength = 10;
            this.txtCargoacum_cte.Name = "txtCargoacum_cte";
            this.txtCargoacum_cte.Size = new System.Drawing.Size(150, 21);
            this.txtCargoacum_cte.TabIndex = 23;
            this.txtCargoacum_cte.Tag = "cargoacum_cte";
            this.txtCargoacum_cte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargoacum_cte_KeyPress);
            // 
            // txtEstado_cte
            // 
            this.txtEstado_cte.Location = new System.Drawing.Point(264, 269);
            this.txtEstado_cte.Name = "txtEstado_cte";
            this.txtEstado_cte.Size = new System.Drawing.Size(21, 21);
            this.txtEstado_cte.TabIndex = 25;
            this.txtEstado_cte.Tag = "estado_cte";
            this.txtEstado_cte.Visible = false;
            this.txtEstado_cte.EnabledChanged += new System.EventHandler(this.txtEstado_cte_EnabledChanged);
            this.txtEstado_cte.TextChanged += new System.EventHandler(this.txtEstado_cte_TextChanged);
            // 
            // cboEstado_cte
            // 
            this.cboEstado_cte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado_cte.Enabled = false;
            this.cboEstado_cte.FormattingEnabled = true;
            this.cboEstado_cte.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cboEstado_cte.Location = new System.Drawing.Point(108, 269);
            this.cboEstado_cte.Name = "cboEstado_cte";
            this.cboEstado_cte.Size = new System.Drawing.Size(150, 23);
            this.cboEstado_cte.TabIndex = 24;
            this.cboEstado_cte.SelectedIndexChanged += new System.EventHandler(this.cboEstado_cte_SelectedIndexChanged);
            // 
            // lblCod_cte
            // 
            this.lblCod_cte.AutoSize = true;
            this.lblCod_cte.Location = new System.Drawing.Point(12, 83);
            this.lblCod_cte.Name = "lblCod_cte";
            this.lblCod_cte.Size = new System.Drawing.Size(46, 15);
            this.lblCod_cte.TabIndex = 16;
            this.lblCod_cte.Text = "Código";
            // 
            // lblDpi_cte
            // 
            this.lblDpi_cte.AutoSize = true;
            this.lblDpi_cte.Location = new System.Drawing.Point(12, 110);
            this.lblDpi_cte.Name = "lblDpi_cte";
            this.lblDpi_cte.Size = new System.Drawing.Size(27, 15);
            this.lblDpi_cte.TabIndex = 17;
            this.lblDpi_cte.Text = "DPI";
            // 
            // lblNit_cte
            // 
            this.lblNit_cte.AutoSize = true;
            this.lblNit_cte.Location = new System.Drawing.Point(318, 110);
            this.lblNit_cte.Name = "lblNit_cte";
            this.lblNit_cte.Size = new System.Drawing.Size(26, 15);
            this.lblNit_cte.TabIndex = 18;
            this.lblNit_cte.Text = "NIT";
            // 
            // lblNom1_cte
            // 
            this.lblNom1_cte.AutoSize = true;
            this.lblNom1_cte.Location = new System.Drawing.Point(12, 137);
            this.lblNom1_cte.Name = "lblNom1_cte";
            this.lblNom1_cte.Size = new System.Drawing.Size(90, 15);
            this.lblNom1_cte.TabIndex = 19;
            this.lblNom1_cte.Text = "Primer nombre";
            // 
            // lblNom2_cte
            // 
            this.lblNom2_cte.AutoSize = true;
            this.lblNom2_cte.Location = new System.Drawing.Point(318, 137);
            this.lblNom2_cte.Name = "lblNom2_cte";
            this.lblNom2_cte.Size = new System.Drawing.Size(103, 15);
            this.lblNom2_cte.TabIndex = 20;
            this.lblNom2_cte.Text = "Segundo nombre";
            // 
            // lblApell1_cte
            // 
            this.lblApell1_cte.AutoSize = true;
            this.lblApell1_cte.Location = new System.Drawing.Point(12, 164);
            this.lblApell1_cte.Name = "lblApell1_cte";
            this.lblApell1_cte.Size = new System.Drawing.Size(91, 15);
            this.lblApell1_cte.TabIndex = 21;
            this.lblApell1_cte.Text = "Primer apellido";
            // 
            // lblApell2_cte
            // 
            this.lblApell2_cte.AutoSize = true;
            this.lblApell2_cte.Location = new System.Drawing.Point(318, 164);
            this.lblApell2_cte.Name = "lblApell2_cte";
            this.lblApell2_cte.Size = new System.Drawing.Size(104, 15);
            this.lblApell2_cte.TabIndex = 22;
            this.lblApell2_cte.Text = "Segundo apellido";
            // 
            // lblTel_cte
            // 
            this.lblTel_cte.AutoSize = true;
            this.lblTel_cte.Location = new System.Drawing.Point(12, 191);
            this.lblTel_cte.Name = "lblTel_cte";
            this.lblTel_cte.Size = new System.Drawing.Size(55, 15);
            this.lblTel_cte.TabIndex = 23;
            this.lblTel_cte.Text = "Teléfono";
            // 
            // lblCredito_cte
            // 
            this.lblCredito_cte.AutoSize = true;
            this.lblCredito_cte.Location = new System.Drawing.Point(12, 218);
            this.lblCredito_cte.Name = "lblCredito_cte";
            this.lblCredito_cte.Size = new System.Drawing.Size(46, 15);
            this.lblCredito_cte.TabIndex = 24;
            this.lblCredito_cte.Text = "Crédito";
            // 
            // lblCargo_cte
            // 
            this.lblCargo_cte.AutoSize = true;
            this.lblCargo_cte.Location = new System.Drawing.Point(318, 215);
            this.lblCargo_cte.Name = "lblCargo_cte";
            this.lblCargo_cte.Size = new System.Drawing.Size(40, 15);
            this.lblCargo_cte.TabIndex = 25;
            this.lblCargo_cte.Text = "Cargo";
            // 
            // lblAbono_cte
            // 
            this.lblAbono_cte.AutoSize = true;
            this.lblAbono_cte.Location = new System.Drawing.Point(12, 245);
            this.lblAbono_cte.Name = "lblAbono_cte";
            this.lblAbono_cte.Size = new System.Drawing.Size(42, 15);
            this.lblAbono_cte.TabIndex = 26;
            this.lblAbono_cte.Text = "Abono";
            // 
            // lblCargoacum_cte
            // 
            this.lblCargoacum_cte.AutoSize = true;
            this.lblCargoacum_cte.Location = new System.Drawing.Point(318, 242);
            this.lblCargoacum_cte.Name = "lblCargoacum_cte";
            this.lblCargoacum_cte.Size = new System.Drawing.Size(105, 15);
            this.lblCargoacum_cte.TabIndex = 27;
            this.lblCargoacum_cte.Text = "Cargo Acumulado";
            // 
            // lblEstado_cte
            // 
            this.lblEstado_cte.AutoSize = true;
            this.lblEstado_cte.Location = new System.Drawing.Point(12, 272);
            this.lblEstado_cte.Name = "lblEstado_cte";
            this.lblEstado_cte.Size = new System.Drawing.Size(45, 15);
            this.lblEstado_cte.TabIndex = 28;
            this.lblEstado_cte.Text = "Estado";
            // 
            // wfCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 301);
            this.Controls.Add(this.lblEstado_cte);
            this.Controls.Add(this.lblCargoacum_cte);
            this.Controls.Add(this.lblAbono_cte);
            this.Controls.Add(this.lblCargo_cte);
            this.Controls.Add(this.lblCredito_cte);
            this.Controls.Add(this.lblTel_cte);
            this.Controls.Add(this.lblApell2_cte);
            this.Controls.Add(this.lblApell1_cte);
            this.Controls.Add(this.lblNom2_cte);
            this.Controls.Add(this.lblNom1_cte);
            this.Controls.Add(this.lblNit_cte);
            this.Controls.Add(this.lblDpi_cte);
            this.Controls.Add(this.lblCod_cte);
            this.Controls.Add(this.cboEstado_cte);
            this.Controls.Add(this.txtEstado_cte);
            this.Controls.Add(this.txtCargoacum_cte);
            this.Controls.Add(this.txtAbono_cte);
            this.Controls.Add(this.txtCargo_cte);
            this.Controls.Add(this.txtCredito_cte);
            this.Controls.Add(this.txtTel_cte);
            this.Controls.Add(this.txtApell2_cte);
            this.Controls.Add(this.txtApell1_cte);
            this.Controls.Add(this.txtNom2_cte);
            this.Controls.Add(this.txtNom1_cte);
            this.Controls.Add(this.txtNit_cte);
            this.Controls.Add(this.txtDpi_cte);
            this.Controls.Add(this.txtCod_cte);
            this.Controls.Add(this.navegador1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.wfCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtCod_cte;
        private System.Windows.Forms.TextBox txtDpi_cte;
        private System.Windows.Forms.TextBox txtNit_cte;
        private System.Windows.Forms.TextBox txtNom1_cte;
        private System.Windows.Forms.TextBox txtNom2_cte;
        private System.Windows.Forms.TextBox txtApell1_cte;
        private System.Windows.Forms.TextBox txtApell2_cte;
        private System.Windows.Forms.TextBox txtTel_cte;
        private System.Windows.Forms.TextBox txtCredito_cte;
        private System.Windows.Forms.TextBox txtCargo_cte;
        private System.Windows.Forms.TextBox txtAbono_cte;
        private System.Windows.Forms.TextBox txtCargoacum_cte;
        private System.Windows.Forms.TextBox txtEstado_cte;
        private System.Windows.Forms.ComboBox cboEstado_cte;
        private System.Windows.Forms.Label lblCod_cte;
        private System.Windows.Forms.Label lblDpi_cte;
        private System.Windows.Forms.Label lblNit_cte;
        private System.Windows.Forms.Label lblNom1_cte;
        private System.Windows.Forms.Label lblNom2_cte;
        private System.Windows.Forms.Label lblApell1_cte;
        private System.Windows.Forms.Label lblApell2_cte;
        private System.Windows.Forms.Label lblTel_cte;
        private System.Windows.Forms.Label lblCredito_cte;
        private System.Windows.Forms.Label lblCargo_cte;
        private System.Windows.Forms.Label lblAbono_cte;
        private System.Windows.Forms.Label lblCargoacum_cte;
        private System.Windows.Forms.Label lblEstado_cte;

    }
}