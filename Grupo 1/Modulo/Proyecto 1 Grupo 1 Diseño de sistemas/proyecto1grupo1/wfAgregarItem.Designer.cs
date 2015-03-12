namespace proyecto1grupo1
{
    partial class wfAgregarItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdmodulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModl_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModl_estd = new System.Windows.Forms.TextBox();
            this.txtModl_desp = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Agregar Servicios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Módulo";
            // 
            // txtIdmodulo
            // 
            this.txtIdmodulo.Location = new System.Drawing.Point(134, 38);
            this.txtIdmodulo.Name = "txtIdmodulo";
            this.txtIdmodulo.Size = new System.Drawing.Size(100, 20);
            this.txtIdmodulo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Modulo";
            // 
            // txtModl_nom
            // 
            this.txtModl_nom.Location = new System.Drawing.Point(134, 72);
            this.txtModl_nom.Name = "txtModl_nom";
            this.txtModl_nom.Size = new System.Drawing.Size(100, 20);
            this.txtModl_nom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estado del Modulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripcion de Modulo";
            // 
            // txtModl_estd
            // 
            this.txtModl_estd.Location = new System.Drawing.Point(134, 104);
            this.txtModl_estd.Name = "txtModl_estd";
            this.txtModl_estd.Size = new System.Drawing.Size(100, 20);
            this.txtModl_estd.TabIndex = 7;
            // 
            // txtModl_desp
            // 
            this.txtModl_desp.Location = new System.Drawing.Point(134, 139);
            this.txtModl_desp.Name = "txtModl_desp";
            this.txtModl_desp.Size = new System.Drawing.Size(100, 20);
            this.txtModl_desp.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // wfAgregarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtModl_desp);
            this.Controls.Add(this.txtModl_estd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModl_nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdmodulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "wfAgregarItem";
            this.Text = "Agregar Servicios";
            this.Load += new System.EventHandler(this.wfAgregarItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdmodulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModl_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModl_estd;
        private System.Windows.Forms.TextBox txtModl_desp;
        private System.Windows.Forms.Button btnAgregar;
    }
}