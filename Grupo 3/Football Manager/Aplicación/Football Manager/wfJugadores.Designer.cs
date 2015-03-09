/* Autor: Andrea Perez
 * Fecha: 02/08/2014 - Comentario: Listado de jugadores activos
*/

namespace Football_Manager
{
    partial class wfJugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfJugadores));
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.codjdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomjdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelljdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direjdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teljdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotojdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsListadoJugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD = new Football_Manager.dsDatosBD();
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dsListadoJugadoresTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoJugadoresTA();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoJugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(394, 320);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(44, 36);
            this.btnModificar.TabIndex = 2;
            this.ttTool1.SetToolTip(this.btnModificar, "Modificar");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(444, 320);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(44, 36);
            this.btnEliminar.TabIndex = 3;
            this.ttTool1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(12, 332);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 15);
            this.lblBuscar.TabIndex = 10;
            this.lblBuscar.Text = "Buscar";
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AllowUserToDeleteRows = false;
            this.dgvJugadores.AllowUserToResizeRows = false;
            this.dgvJugadores.AutoGenerateColumns = false;
            this.dgvJugadores.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codjdrDataGridViewTextBoxColumn,
            this.nomjdrDataGridViewTextBoxColumn,
            this.apelljdrDataGridViewTextBoxColumn,
            this.direjdrDataGridViewTextBoxColumn,
            this.teljdrDataGridViewTextBoxColumn,
            this.fotojdrDataGridViewTextBoxColumn});
            this.dgvJugadores.DataSource = this.dsListadoJugadoresBindingSource;
            this.dgvJugadores.Location = new System.Drawing.Point(14, 14);
            this.dgvJugadores.MultiSelect = false;
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.ReadOnly = true;
            this.dgvJugadores.RowHeadersVisible = false;
            this.dgvJugadores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugadores.Size = new System.Drawing.Size(523, 300);
            this.dgvJugadores.TabIndex = 0;
            // 
            // codjdrDataGridViewTextBoxColumn
            // 
            this.codjdrDataGridViewTextBoxColumn.DataPropertyName = "cod_jdr";
            this.codjdrDataGridViewTextBoxColumn.HeaderText = "cod_jdr";
            this.codjdrDataGridViewTextBoxColumn.Name = "codjdrDataGridViewTextBoxColumn";
            this.codjdrDataGridViewTextBoxColumn.ReadOnly = true;
            this.codjdrDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomjdrDataGridViewTextBoxColumn
            // 
            this.nomjdrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomjdrDataGridViewTextBoxColumn.DataPropertyName = "nom_jdr";
            this.nomjdrDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomjdrDataGridViewTextBoxColumn.Name = "nomjdrDataGridViewTextBoxColumn";
            this.nomjdrDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomjdrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nomjdrDataGridViewTextBoxColumn.Width = 140;
            // 
            // apelljdrDataGridViewTextBoxColumn
            // 
            this.apelljdrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.apelljdrDataGridViewTextBoxColumn.DataPropertyName = "apell_jdr";
            this.apelljdrDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apelljdrDataGridViewTextBoxColumn.Name = "apelljdrDataGridViewTextBoxColumn";
            this.apelljdrDataGridViewTextBoxColumn.ReadOnly = true;
            this.apelljdrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apelljdrDataGridViewTextBoxColumn.Width = 140;
            // 
            // direjdrDataGridViewTextBoxColumn
            // 
            this.direjdrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.direjdrDataGridViewTextBoxColumn.DataPropertyName = "dire_jdr";
            this.direjdrDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direjdrDataGridViewTextBoxColumn.Name = "direjdrDataGridViewTextBoxColumn";
            this.direjdrDataGridViewTextBoxColumn.ReadOnly = true;
            this.direjdrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.direjdrDataGridViewTextBoxColumn.Width = 140;
            // 
            // teljdrDataGridViewTextBoxColumn
            // 
            this.teljdrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.teljdrDataGridViewTextBoxColumn.DataPropertyName = "tel_jdr";
            this.teljdrDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.teljdrDataGridViewTextBoxColumn.Name = "teljdrDataGridViewTextBoxColumn";
            this.teljdrDataGridViewTextBoxColumn.ReadOnly = true;
            this.teljdrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fotojdrDataGridViewTextBoxColumn
            // 
            this.fotojdrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fotojdrDataGridViewTextBoxColumn.DataPropertyName = "foto_jdr";
            this.fotojdrDataGridViewTextBoxColumn.HeaderText = "Fotografía";
            this.fotojdrDataGridViewTextBoxColumn.Name = "fotojdrDataGridViewTextBoxColumn";
            this.fotojdrDataGridViewTextBoxColumn.ReadOnly = true;
            this.fotojdrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fotojdrDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsListadoJugadoresBindingSource
            // 
            this.dsListadoJugadoresBindingSource.DataMember = "dsListadoJugadores";
            this.dsListadoJugadoresBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsDatosBD
            // 
            this.dsDatosBD.DataSetName = "dsDatosBD";
            this.dsDatosBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(493, 320);
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
            this.btnNuevo.Location = new System.Drawing.Point(344, 320);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(44, 36);
            this.btnNuevo.TabIndex = 11;
            this.ttTool1.SetToolTip(this.btnNuevo, "Nuevo");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dsListadoJugadoresTA
            // 
            this.dsListadoJugadoresTA.ClearBeforeFill = true;
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
            // wfJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 369);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvJugadores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfJugadores";
            this.Text = "Listado de Jugadores";
            this.Load += new System.EventHandler(this.wfJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoJugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.ToolTip ttTool1;
        private System.Windows.Forms.Button button1;
        private dsDatosBD dsDatosBD;
        private System.Windows.Forms.BindingSource dsListadoJugadoresBindingSource;
        private dsDatosBDTableAdapters.dsListadoJugadoresTA dsListadoJugadoresTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn codjdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomjdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelljdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direjdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teljdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotojdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnNuevo;
    }
}