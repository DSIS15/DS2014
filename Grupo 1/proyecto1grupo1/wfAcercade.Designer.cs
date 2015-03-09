namespace proyecto1grupo1
{
    partial class wfAcercade
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
            this.lblAcerca = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblJorgeL = new System.Windows.Forms.Label();
            this.lblCristianA = new System.Windows.Forms.Label();
            this.lblCristianP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJessica = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAcerca
            // 
            this.lblAcerca.AutoSize = true;
            this.lblAcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcerca.Location = new System.Drawing.Point(71, 24);
            this.lblAcerca.Name = "lblAcerca";
            this.lblAcerca.Size = new System.Drawing.Size(125, 25);
            this.lblAcerca.TabIndex = 0;
            this.lblAcerca.Text = "Acerca de:";
            this.lblAcerca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(30, 82);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(80, 13);
            this.lbldescripcion.TabIndex = 1;
            this.lbldescripcion.Text = "Desarrolladores";
            // 
            // lblJorgeL
            // 
            this.lblJorgeL.AutoSize = true;
            this.lblJorgeL.Location = new System.Drawing.Point(30, 115);
            this.lblJorgeL.Name = "lblJorgeL";
            this.lblJorgeL.Size = new System.Drawing.Size(56, 13);
            this.lblJorgeL.TabIndex = 2;
            this.lblJorgeL.Text = "Jorge Lam";
            // 
            // lblCristianA
            // 
            this.lblCristianA.AutoSize = true;
            this.lblCristianA.Location = new System.Drawing.Point(132, 115);
            this.lblCristianA.Name = "lblCristianA";
            this.lblCristianA.Size = new System.Drawing.Size(77, 13);
            this.lblCristianA.TabIndex = 3;
            this.lblCristianA.Text = "Cristian Aguirre";
            // 
            // lblCristianP
            // 
            this.lblCristianP.AutoSize = true;
            this.lblCristianP.Location = new System.Drawing.Point(132, 141);
            this.lblCristianP.Name = "lblCristianP";
            this.lblCristianP.Size = new System.Drawing.Size(75, 13);
            this.lblCristianP.TabIndex = 4;
            this.lblCristianP.Text = "Cristian Portillo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jaime Muñoz";
            // 
            // lblJessica
            // 
            this.lblJessica.AutoSize = true;
            this.lblJessica.Location = new System.Drawing.Point(74, 175);
            this.lblJessica.Name = "lblJessica";
            this.lblJessica.Size = new System.Drawing.Size(99, 13);
            this.lblJessica.TabIndex = 6;
            this.lblJessica.Text = "Jessica Castellanos";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::proyecto1grupo1.Properties.Resources.cerrar_borrar_la_salida_icono_9027_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(229, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wfAcercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 241);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblJessica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCristianP);
            this.Controls.Add(this.lblCristianA);
            this.Controls.Add(this.lblJorgeL);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblAcerca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wfAcercade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de";
            this.Load += new System.EventHandler(this.wfAcercade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcerca;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblJorgeL;
        private System.Windows.Forms.Label lblCristianA;
        private System.Windows.Forms.Label lblCristianP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJessica;
        private System.Windows.Forms.Button button1;
    }
}