namespace Modulo_de_Seguridad_3._0.Presentacion
{
    partial class wfInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfInicioSesion));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCancelarSesion = new System.Windows.Forms.Button();
            this.lklPregunta = new System.Windows.Forms.LinkLabel();
            this.btnSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbFotoUsuario = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(272, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // btnCancelarSesion
            // 
            this.btnCancelarSesion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelarSesion.Location = new System.Drawing.Point(320, 144);
            this.btnCancelarSesion.Name = "btnCancelarSesion";
            this.btnCancelarSesion.Size = new System.Drawing.Size(107, 31);
            this.btnCancelarSesion.TabIndex = 3;
            this.btnCancelarSesion.Text = "Cancelar";
            this.btnCancelarSesion.UseVisualStyleBackColor = false;
            this.btnCancelarSesion.Click += new System.EventHandler(this.btnCancelarSesion_Click);
            // 
            // lklPregunta
            // 
            this.lklPregunta.AutoSize = true;
            this.lklPregunta.Location = new System.Drawing.Point(179, 108);
            this.lklPregunta.Name = "lklPregunta";
            this.lklPregunta.Size = new System.Drawing.Size(148, 13);
            this.lklPregunta.TabIndex = 4;
            this.lklPregunta.TabStop = true;
            this.lklPregunta.Text = "¿Has olvidado la contraseña?";
            this.lklPregunta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklPregunta_LinkClicked);
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSesion.Location = new System.Drawing.Point(207, 144);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(107, 31);
            this.btnSesion.TabIndex = 2;
            this.btnSesion.Text = "Inciar Sesión";
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcbFotoUsuario);
            this.panel1.Location = new System.Drawing.Point(18, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 159);
            this.panel1.TabIndex = 47;
            // 
            // pcbFotoUsuario
            // 
            this.pcbFotoUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pcbFotoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbFotoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pcbFotoUsuario.Image")));
            this.pcbFotoUsuario.Location = new System.Drawing.Point(0, 0);
            this.pcbFotoUsuario.Name = "pcbFotoUsuario";
            this.pcbFotoUsuario.Size = new System.Drawing.Size(129, 157);
            this.pcbFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFotoUsuario.TabIndex = 0;
            this.pcbFotoUsuario.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(272, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(176, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblUsuario.Location = new System.Drawing.Point(179, 40);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 46;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPassword.Location = new System.Drawing.Point(179, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 15);
            this.lblPassword.TabIndex = 48;
            this.lblPassword.Text = "Contraseña";
            // 
            // wfInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 199);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnCancelarSesion);
            this.Controls.Add(this.lklPregunta);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion - HIF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wfInicioSesion_FormClosing);
            this.Load += new System.EventHandler(this.wfInicioSesion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCancelarSesion;
        private System.Windows.Forms.LinkLabel lklPregunta;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbFotoUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
    }
}