/*Autor: Andrea Perez
 * Fecha:"05/julio/2014"
 * Comentario: Reportes de empleados
 */
 
namespace Football_Manager
{
    partial class wfEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEmpleados));
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.codempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipotempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsListadoEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD = new Football_Manager.dsDatosBD();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dsListadoEmpleadosTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoEmpleadosTA();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AutoGenerateColumns = false;
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codempDataGridViewTextBoxColumn,
            this.tipotempDataGridViewTextBoxColumn,
            this.nomempDataGridViewTextBoxColumn,
            this.apellempDataGridViewTextBoxColumn,
            this.direempDataGridViewTextBoxColumn,
            this.telempDataGridViewTextBoxColumn,
            this.salarioempDataGridViewTextBoxColumn});
            this.dgvEmpleados.DataSource = this.dsListadoEmpleadosBindingSource;
            this.dgvEmpleados.Location = new System.Drawing.Point(14, 14);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(583, 300);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // codempDataGridViewTextBoxColumn
            // 
            this.codempDataGridViewTextBoxColumn.DataPropertyName = "cod_emp";
            this.codempDataGridViewTextBoxColumn.HeaderText = "cod_emp";
            this.codempDataGridViewTextBoxColumn.Name = "codempDataGridViewTextBoxColumn";
            this.codempDataGridViewTextBoxColumn.ReadOnly = true;
            this.codempDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipotempDataGridViewTextBoxColumn
            // 
            this.tipotempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipotempDataGridViewTextBoxColumn.DataPropertyName = "tipo_temp";
            this.tipotempDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipotempDataGridViewTextBoxColumn.Name = "tipotempDataGridViewTextBoxColumn";
            this.tipotempDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipotempDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tipotempDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomempDataGridViewTextBoxColumn
            // 
            this.nomempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomempDataGridViewTextBoxColumn.DataPropertyName = "nom_emp";
            this.nomempDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomempDataGridViewTextBoxColumn.Name = "nomempDataGridViewTextBoxColumn";
            this.nomempDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomempDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nomempDataGridViewTextBoxColumn.Width = 110;
            // 
            // apellempDataGridViewTextBoxColumn
            // 
            this.apellempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.apellempDataGridViewTextBoxColumn.DataPropertyName = "apell_emp";
            this.apellempDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellempDataGridViewTextBoxColumn.Name = "apellempDataGridViewTextBoxColumn";
            this.apellempDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellempDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apellempDataGridViewTextBoxColumn.Width = 110;
            // 
            // direempDataGridViewTextBoxColumn
            // 
            this.direempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.direempDataGridViewTextBoxColumn.DataPropertyName = "dire_emp";
            this.direempDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direempDataGridViewTextBoxColumn.Name = "direempDataGridViewTextBoxColumn";
            this.direempDataGridViewTextBoxColumn.ReadOnly = true;
            this.direempDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.direempDataGridViewTextBoxColumn.Width = 120;
            // 
            // telempDataGridViewTextBoxColumn
            // 
            this.telempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telempDataGridViewTextBoxColumn.DataPropertyName = "tel_emp";
            this.telempDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telempDataGridViewTextBoxColumn.Name = "telempDataGridViewTextBoxColumn";
            this.telempDataGridViewTextBoxColumn.ReadOnly = true;
            this.telempDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.telempDataGridViewTextBoxColumn.Width = 80;
            // 
            // salarioempDataGridViewTextBoxColumn
            // 
            this.salarioempDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.salarioempDataGridViewTextBoxColumn.DataPropertyName = "salario_emp";
            this.salarioempDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioempDataGridViewTextBoxColumn.Name = "salarioempDataGridViewTextBoxColumn";
            this.salarioempDataGridViewTextBoxColumn.ReadOnly = true;
            this.salarioempDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.salarioempDataGridViewTextBoxColumn.Width = 80;
            // 
            // dsListadoEmpleadosBindingSource
            // 
            this.dsListadoEmpleadosBindingSource.DataMember = "dsListadoEmpleados";
            this.dsListadoEmpleadosBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsDatosBD
            // 
            this.dsDatosBD.DataSetName = "dsDatosBD";
            this.dsDatosBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(12, 332);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 15);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(63, 329);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(174, 21);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(504, 321);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(44, 36);
            this.btnEliminar.TabIndex = 3;
            this.ttTool1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(454, 321);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(44, 36);
            this.btnModificar.TabIndex = 2;
            this.ttTool1.SetToolTip(this.btnModificar, "Modificar");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(553, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 36);
            this.button1.TabIndex = 4;
            this.ttTool1.SetToolTip(this.button1, "Aceptar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(404, 321);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(44, 36);
            this.btnNuevo.TabIndex = 93;
            this.ttTool1.SetToolTip(this.btnNuevo, "Nuevo");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dsListadoEmpleadosTA
            // 
            this.dsListadoEmpleadosTA.ClearBeforeFill = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(243, 320);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(44, 36);
            this.btnRefrescar.TabIndex = 1;
            this.ttTool1.SetToolTip(this.btnRefrescar, "Refrescar");
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // wfEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 369);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvEmpleados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfEmpleados";
            this.ShowInTaskbar = false;
            this.Text = "Listado de Empleados";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.wfEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolTip ttTool1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button1;
        private dsDatosBD dsDatosBD;
        private System.Windows.Forms.BindingSource dsListadoEmpleadosBindingSource;
        private dsDatosBDTableAdapters.dsListadoEmpleadosTA dsListadoEmpleadosTA;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipotempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioempDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNuevo;
    }
}