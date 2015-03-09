/* Autor: Jeniffer Lopez
 * Categoriza los distintos empleados que existen 
 * Fecha: 07/08/2014 - Comentario: Diseño y Programación de wfTipoEmpleados
 * Fecha: 08/08/2014 - Comentario: Preparación para interacción con BD
*/
namespace Football_Manager
{
    partial class wfTipoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfTipoEmpleado));
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlTipoEmpleado = new System.Windows.Forms.Panel();
            this.txtNuevoTE = new System.Windows.Forms.TextBox();
            this.lblNuevoTE = new System.Windows.Forms.Label();
            this.cboTERegis = new System.Windows.Forms.ComboBox();
            this.lblTERegis = new System.Windows.Forms.Label();
            this.dsDatosBD = new Football_Manager.dsDatosBD();
            this.dsListadoTipoEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListadoTipoEmpleadosTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoTipoEmpleadosTA();
            this.pnlTipoEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoTipoEmpleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(141, 41);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(44, 36);
            this.btnNuevo.TabIndex = 48;
            this.ttTool1.SetToolTip(this.btnNuevo, "Nuevo");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(139, 34);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(44, 36);
            this.btnGuardar.TabIndex = 5;
            this.ttTool1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(189, 34);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 6;
            this.ttTool1.SetToolTip(this.btnLimpiar, "Limpiar");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(239, 34);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(44, 36);
            this.btnCancelar.TabIndex = 7;
            this.ttTool1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(191, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(44, 36);
            this.btnModificar.TabIndex = 46;
            this.ttTool1.SetToolTip(this.btnModificar, "Modificar");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(241, 41);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(44, 36);
            this.btnEliminar.TabIndex = 47;
            this.ttTool1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlTipoEmpleado
            // 
            this.pnlTipoEmpleado.Controls.Add(this.txtNuevoTE);
            this.pnlTipoEmpleado.Controls.Add(this.btnGuardar);
            this.pnlTipoEmpleado.Controls.Add(this.btnLimpiar);
            this.pnlTipoEmpleado.Controls.Add(this.lblNuevoTE);
            this.pnlTipoEmpleado.Controls.Add(this.btnCancelar);
            this.pnlTipoEmpleado.Location = new System.Drawing.Point(2, 84);
            this.pnlTipoEmpleado.Name = "pnlTipoEmpleado";
            this.pnlTipoEmpleado.Size = new System.Drawing.Size(289, 76);
            this.pnlTipoEmpleado.TabIndex = 49;
            this.pnlTipoEmpleado.Visible = false;
            // 
            // txtNuevoTE
            // 
            this.txtNuevoTE.Location = new System.Drawing.Point(133, 8);
            this.txtNuevoTE.MaxLength = 25;
            this.txtNuevoTE.Name = "txtNuevoTE";
            this.txtNuevoTE.Size = new System.Drawing.Size(150, 21);
            this.txtNuevoTE.TabIndex = 4;
            // 
            // lblNuevoTE
            // 
            this.lblNuevoTE.AutoSize = true;
            this.lblNuevoTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoTE.Location = new System.Drawing.Point(10, 11);
            this.lblNuevoTE.Name = "lblNuevoTE";
            this.lblNuevoTE.Size = new System.Drawing.Size(93, 15);
            this.lblNuevoTE.TabIndex = 25;
            this.lblNuevoTE.Text = "Registrar nuevo";
            // 
            // cboTERegis
            // 
            this.cboTERegis.DataSource = this.dsListadoTipoEmpleadosBindingSource;
            this.cboTERegis.DisplayMember = "tipo_temp";
            this.cboTERegis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTERegis.FormattingEnabled = true;
            this.cboTERegis.Location = new System.Drawing.Point(135, 12);
            this.cboTERegis.Name = "cboTERegis";
            this.cboTERegis.Size = new System.Drawing.Size(150, 23);
            this.cboTERegis.TabIndex = 45;
            this.cboTERegis.ValueMember = "cod_temp";
            // 
            // lblTERegis
            // 
            this.lblTERegis.AutoSize = true;
            this.lblTERegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTERegis.Location = new System.Drawing.Point(10, 15);
            this.lblTERegis.Name = "lblTERegis";
            this.lblTERegis.Size = new System.Drawing.Size(119, 15);
            this.lblTERegis.TabIndex = 50;
            this.lblTERegis.Text = "Tipos de empleados";
            // 
            // dsDatosBD
            // 
            this.dsDatosBD.DataSetName = "dsDatosBD";
            this.dsDatosBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsListadoTipoEmpleadosBindingSource
            // 
            this.dsListadoTipoEmpleadosBindingSource.DataMember = "dsListadoTipoEmpleados";
            this.dsListadoTipoEmpleadosBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsListadoTipoEmpleadosTA
            // 
            this.dsListadoTipoEmpleadosTA.ClearBeforeFill = true;
            // 
            // wfTipoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 162);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlTipoEmpleado);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cboTERegis);
            this.Controls.Add(this.lblTERegis);
            this.Controls.Add(this.btnEliminar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfTipoEmpleado";
            this.ShowInTaskbar = false;
            this.Text = "Administrar Tipos de Empleados";
            this.Load += new System.EventHandler(this.wfTipoEmpleado_Load);
            this.pnlTipoEmpleado.ResumeLayout(false);
            this.pnlTipoEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoTipoEmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttTool1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnlTipoEmpleado;
        private System.Windows.Forms.TextBox txtNuevoTE;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblNuevoTE;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboTERegis;
        private System.Windows.Forms.Label lblTERegis;
        private System.Windows.Forms.Button btnEliminar;
        private dsDatosBD dsDatosBD;
        private System.Windows.Forms.BindingSource dsListadoTipoEmpleadosBindingSource;
        private dsDatosBDTableAdapters.dsListadoTipoEmpleadosTA dsListadoTipoEmpleadosTA;
    }
}