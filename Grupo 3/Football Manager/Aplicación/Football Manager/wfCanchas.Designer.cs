/* Autor: Kevin Gutierrez
 * Fecha: 02/08/2014
 * Comentario: Lleva el control de canchas ingresadas en el software
*/

namespace Football_Manager
{
    partial class wfCanchas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCanchas));
            this.cboCancha = new System.Windows.Forms.ComboBox();
            this.dsListadoCanchasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD = new Football_Manager.dsDatosBD();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblCancha = new System.Windows.Forms.Label();
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblDescripcionCancha = new System.Windows.Forms.Label();
            this.pnlCancha = new System.Windows.Forms.Panel();
            this.txtNuevaCancha = new System.Windows.Forms.TextBox();
            this.dsListadoCanchasTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoCanchasTA();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoCanchasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).BeginInit();
            this.pnlCancha.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCancha
            // 
            this.cboCancha.DataSource = this.dsListadoCanchasBindingSource;
            this.cboCancha.DisplayMember = "nom_cha";
            this.cboCancha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCancha.FormattingEnabled = true;
            this.cboCancha.Location = new System.Drawing.Point(122, 13);
            this.cboCancha.Name = "cboCancha";
            this.cboCancha.Size = new System.Drawing.Size(150, 23);
            this.cboCancha.TabIndex = 0;
            this.cboCancha.ValueMember = "cod_cha";
            // 
            // dsListadoCanchasBindingSource
            // 
            this.dsListadoCanchasBindingSource.DataMember = "dsListadoCanchas";
            this.dsListadoCanchasBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsDatosBD
            // 
            this.dsDatosBD.DataSetName = "dsDatosBD";
            this.dsDatosBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(228, 41);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(44, 36);
            this.btnEliminar.TabIndex = 2;
            this.ttTool1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(178, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(44, 36);
            this.btnModificar.TabIndex = 1;
            this.ttTool1.SetToolTip(this.btnModificar, "Modificar");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(128, 41);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(44, 36);
            this.btnNuevo.TabIndex = 3;
            this.ttTool1.SetToolTip(this.btnNuevo, "Nueva");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblCancha
            // 
            this.lblCancha.AutoSize = true;
            this.lblCancha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancha.Location = new System.Drawing.Point(12, 16);
            this.lblCancha.Name = "lblCancha";
            this.lblCancha.Size = new System.Drawing.Size(96, 15);
            this.lblCancha.TabIndex = 25;
            this.lblCancha.Text = "Verificar Cancha";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(126, 32);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(44, 36);
            this.btnGuardar.TabIndex = 5;
            this.ttTool1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(226, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(44, 36);
            this.btnCancelar.TabIndex = 7;
            this.ttTool1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(176, 32);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 6;
            this.ttTool1.SetToolTip(this.btnLimpiar, "Limpiar");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblDescripcionCancha
            // 
            this.lblDescripcionCancha.AutoSize = true;
            this.lblDescripcionCancha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCancha.Location = new System.Drawing.Point(10, 8);
            this.lblDescripcionCancha.Name = "lblDescripcionCancha";
            this.lblDescripcionCancha.Size = new System.Drawing.Size(97, 15);
            this.lblDescripcionCancha.TabIndex = 23;
            this.lblDescripcionCancha.Text = "Nombre Cancha";
            // 
            // pnlCancha
            // 
            this.pnlCancha.Controls.Add(this.txtNuevaCancha);
            this.pnlCancha.Controls.Add(this.btnLimpiar);
            this.pnlCancha.Controls.Add(this.lblDescripcionCancha);
            this.pnlCancha.Controls.Add(this.btnCancelar);
            this.pnlCancha.Controls.Add(this.btnGuardar);
            this.pnlCancha.Location = new System.Drawing.Point(2, 80);
            this.pnlCancha.Name = "pnlCancha";
            this.pnlCancha.Size = new System.Drawing.Size(277, 74);
            this.pnlCancha.TabIndex = 30;
            // 
            // txtNuevaCancha
            // 
            this.txtNuevaCancha.Location = new System.Drawing.Point(120, 8);
            this.txtNuevaCancha.MaxLength = 25;
            this.txtNuevaCancha.Name = "txtNuevaCancha";
            this.txtNuevaCancha.Size = new System.Drawing.Size(150, 21);
            this.txtNuevaCancha.TabIndex = 24;
            this.txtNuevaCancha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevaCancha_KeyPress);
            // 
            // dsListadoCanchasTA
            // 
            this.dsListadoCanchasTA.ClearBeforeFill = true;
            // 
            // wfCanchas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 156);
            this.Controls.Add(this.pnlCancha);
            this.Controls.Add(this.cboCancha);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblCancha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfCanchas";
            this.Text = "Administrar Canchas";
            this.Load += new System.EventHandler(this.wfCancha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoCanchasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).EndInit();
            this.pnlCancha.ResumeLayout(false);
            this.pnlCancha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCancha;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblCancha;
        private System.Windows.Forms.ToolTip ttTool1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDescripcionCancha;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlCancha;
        private System.Windows.Forms.TextBox txtNuevaCancha;
        private dsDatosBD dsDatosBD;
        private System.Windows.Forms.BindingSource dsListadoCanchasBindingSource;
        private dsDatosBDTableAdapters.dsListadoCanchasTA dsListadoCanchasTA;
    }
}