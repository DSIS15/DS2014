namespace proyecto1grupo1
{
    partial class wfPantallaTurnos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.St_Estado = new System.Windows.Forms.StatusStrip();
            this.tslblNom = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSlblNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSlblDescripcion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSlblID_usur = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblAuxID = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.St_Estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin,
            this.toolStripMenuItem12,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(784, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmiAdmin
            // 
            this.tsmiAdmin.Image = global::proyecto1grupo1.Properties.Resources.custom_settings_32;
            this.tsmiAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(135, 36);
            this.tsmiAdmin.Text = "Administracion ";
            this.tsmiAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmiAdmin.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Image = global::proyecto1grupo1.Properties.Resources.about;
            this.toolStripMenuItem12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(103, 36);
            this.toolStripMenuItem12.Text = "Acerca de";
            this.toolStripMenuItem12.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Image = global::proyecto1grupo1.Properties.Resources._1407830416_519660_164_QuestionMark;
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(69, 36);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // St_Estado
            // 
            this.St_Estado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblNom,
            this.tSlblNombre,
            this.tSlblDescripcion,
            this.tSlblID_usur,
            this.stlblAuxID});
            this.St_Estado.Location = new System.Drawing.Point(0, 540);
            this.St_Estado.Name = "St_Estado";
            this.St_Estado.Size = new System.Drawing.Size(784, 22);
            this.St_Estado.TabIndex = 7;
            this.St_Estado.Text = "statusStrip1";
            // 
            // tslblNom
            // 
            this.tslblNom.Name = "tslblNom";
            this.tslblNom.Size = new System.Drawing.Size(97, 17);
            this.tslblNom.Text = "Nombre Usuario:";
            // 
            // tSlblNombre
            // 
            this.tSlblNombre.Name = "tSlblNombre";
            this.tSlblNombre.Size = new System.Drawing.Size(51, 17);
            this.tSlblNombre.Text = "Nombre";
            // 
            // tSlblDescripcion
            // 
            this.tSlblDescripcion.Name = "tSlblDescripcion";
            this.tSlblDescripcion.Size = new System.Drawing.Size(68, 17);
            this.tSlblDescripcion.Text = "Nombre ID:";
            // 
            // tSlblID_usur
            // 
            this.tSlblID_usur.Name = "tSlblID_usur";
            this.tSlblID_usur.Size = new System.Drawing.Size(60, 17);
            this.tSlblID_usur.Text = "ID usuario";
            // 
            // stlblAuxID
            // 
            this.stlblAuxID.Name = "stlblAuxID";
            this.stlblAuxID.Size = new System.Drawing.Size(60, 17);
            this.stlblAuxID.Text = "ID_auxiliar";
            this.stlblAuxID.Visible = false;
            // 
            // wfPantallaTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.St_Estado);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "wfPantallaTurnos";
            this.Tag = "";
            this.Text = "MENU PRINCIPAL-TURNOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wfPantallaTurnos_FormClosing);
            this.Load += new System.EventHandler(this.wfPantallaTurnos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.St_Estado.ResumeLayout(false);
            this.St_Estado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
        private System.Windows.Forms.ToolStripStatusLabel tSlblDescripcion;
        public System.Windows.Forms.ToolStripStatusLabel tSlblID_usur;
        public System.Windows.Forms.ToolStripStatusLabel stlblAuxID;
        public System.Windows.Forms.StatusStrip St_Estado;
        public System.Windows.Forms.ToolStripStatusLabel tSlblNombre;
        private System.Windows.Forms.ToolStripStatusLabel tslblNom;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        public System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
    }
}