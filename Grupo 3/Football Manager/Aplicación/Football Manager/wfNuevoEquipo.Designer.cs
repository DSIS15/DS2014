/* Autor: Daniel Moreno
 * Crea nuevos equipos para luego ingresarlos a el campeonato
 * Fecha: 15/08/2014 - Comentario: Diseño y Programación de wfTipoEmpleados
 * Fecha: 08/08/2014 - Comentario: Preparación para interacción con BD
*/
namespace Football_Manager
{
    partial class wfNuevoEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfNuevoEquipo));
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pboEquipo = new System.Windows.Forms.PictureBox();
            this.btnGuardarEquipo = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(290, 65);
            this.txtNombreEquipo.MaxLength = 25;
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(174, 21);
            this.txtNombreEquipo.TabIndex = 0;
            this.txtNombreEquipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEquipo_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(171, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(111, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de Equipo";
            // 
            // pboEquipo
            // 
            this.pboEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboEquipo.Location = new System.Drawing.Point(14, 12);
            this.pboEquipo.Name = "pboEquipo";
            this.pboEquipo.Size = new System.Drawing.Size(145, 144);
            this.pboEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboEquipo.TabIndex = 5;
            this.pboEquipo.TabStop = false;
            // 
            // btnGuardarEquipo
            // 
            this.btnGuardarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEquipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardarEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarEquipo.Image")));
            this.btnGuardarEquipo.Location = new System.Drawing.Point(320, 120);
            this.btnGuardarEquipo.Name = "btnGuardarEquipo";
            this.btnGuardarEquipo.Size = new System.Drawing.Size(44, 36);
            this.btnGuardarEquipo.TabIndex = 2;
            this.ttTool1.SetToolTip(this.btnGuardarEquipo, "Guardar");
            this.btnGuardarEquipo.UseVisualStyleBackColor = true;
            this.btnGuardarEquipo.Click += new System.EventHandler(this.btnGuardarEquipo_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImagen.Location = new System.Drawing.Point(171, 130);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(75, 26);
            this.btnImagen.TabIndex = 1;
            this.btnImagen.Text = "Subir";
            this.btnImagen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(420, 120);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(44, 36);
            this.btnCancelar.TabIndex = 4;
            this.ttTool1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.Location = new System.Drawing.Point(370, 120);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnlimpiar.TabIndex = 3;
            this.ttTool1.SetToolTip(this.btnlimpiar, "Limpiar");
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // wfNuevoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 167);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.btnGuardarEquipo);
            this.Controls.Add(this.pboEquipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombreEquipo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfNuevoEquipo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscripcion de Equipo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.wfequipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pboEquipo;
        private System.Windows.Forms.Button btnGuardarEquipo;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip ttTool1;
        private System.Windows.Forms.Button btnlimpiar;
    }
}