/* Autor: Anthony Molineros
 * Fecha: 02/08/2014 - Comentario: Insercion de un campeonato nuevo.
*/

namespace Football_Manager
{
    partial class wfNuevoCampeonato
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfNuevoCampeonato));
            this.lblNomCpn = new System.Windows.Forms.Label();
            this.txtNomCpn = new System.Windows.Forms.TextBox();
            this.dtpFechIni = new System.Windows.Forms.DateTimePicker();
            this.lblFechIni = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomCpn
            // 
            this.lblNomCpn.AutoSize = true;
            this.lblNomCpn.Location = new System.Drawing.Point(14, 17);
            this.lblNomCpn.Name = "lblNomCpn";
            this.lblNomCpn.Size = new System.Drawing.Size(126, 15);
            this.lblNomCpn.TabIndex = 0;
            this.lblNomCpn.Text = "Nombre Campeonato";
            // 
            // txtNomCpn
            // 
            this.txtNomCpn.Location = new System.Drawing.Point(142, 14);
            this.txtNomCpn.MaxLength = 25;
            this.txtNomCpn.Name = "txtNomCpn";
            this.txtNomCpn.Size = new System.Drawing.Size(150, 21);
            this.txtNomCpn.TabIndex = 0;
            this.txtNomCpn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomCpn_KeyPress);
            // 
            // dtpFechIni
            // 
            this.dtpFechIni.CustomFormat = "yyyy-MM-dd";
            this.dtpFechIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechIni.Location = new System.Drawing.Point(142, 44);
            this.dtpFechIni.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dtpFechIni.Name = "dtpFechIni";
            this.dtpFechIni.Size = new System.Drawing.Size(150, 21);
            this.dtpFechIni.TabIndex = 1;
            this.dtpFechIni.Value = new System.DateTime(2014, 8, 29, 0, 0, 0, 0);
            // 
            // lblFechIni
            // 
            this.lblFechIni.AutoSize = true;
            this.lblFechIni.Location = new System.Drawing.Point(14, 51);
            this.lblFechIni.Name = "lblFechIni";
            this.lblFechIni.Size = new System.Drawing.Size(90, 15);
            this.lblFechIni.TabIndex = 4;
            this.lblFechIni.Text = "Fecha de Inicio";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(148, 74);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(44, 36);
            this.btnAceptar.TabIndex = 2;
            this.ttTool1.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(248, 74);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(44, 36);
            this.btnCancelar.TabIndex = 4;
            this.ttTool1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.Location = new System.Drawing.Point(198, 74);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 3;
            this.ttTool1.SetToolTip(this.btnLimpiar, "Limpiar");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // wfNuevoCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 119);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFechIni);
            this.Controls.Add(this.dtpFechIni);
            this.Controls.Add(this.txtNomCpn);
            this.Controls.Add(this.lblNomCpn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfNuevoCampeonato";
            this.ShowInTaskbar = false;
            this.Text = "Nuevo Campeonato";
            this.Load += new System.EventHandler(this.wfNuevoCampeonato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomCpn;
        private System.Windows.Forms.TextBox txtNomCpn;
        private System.Windows.Forms.DateTimePicker dtpFechIni;
        private System.Windows.Forms.Label lblFechIni;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolTip ttTool1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;

    }
}