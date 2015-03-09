/*Autor: "Daniel Moreno"
 * Fecha:"05/julio/2014"
 * Comentario: "Este modulo genera las plantillas de un equipo"
 */
 
namespace Football_Manager
{
    partial class wfDetalleJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfDetalleJugador));
            this.dgvSeleccionados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JugadoresSeleccionados = new System.Windows.Forms.Label();
            this.lblJugadoresDisponibles = new System.Windows.Forms.Label();
            this.dgvDisponibles = new System.Windows.Forms.DataGridView();
            this.codjdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomjdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelljdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teljdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsListadoJugadoresDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD = new Football_Manager.dsDatosBD();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboSeleccionarEquipo = new System.Windows.Forms.ComboBox();
            this.dsListadoEquiposDisponiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNombreCamp = new System.Windows.Forms.Label();
            this.btnNuevoJugador = new System.Windows.Forms.Button();
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAñadirEquipo = new System.Windows.Forms.Button();
            this.btnNuevoEquipo = new System.Windows.Forms.Button();
            this.dsListadoEquiposDisponiblesTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoEquiposDisponiblesTA();
            this.dsListadoJugadoresDisponiblesTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoJugadoresDisponiblesTA();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoJugadoresDisponiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoEquiposDisponiblesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeleccionados
            // 
            this.dgvSeleccionados.AllowUserToAddRows = false;
            this.dgvSeleccionados.AllowUserToDeleteRows = false;
            this.dgvSeleccionados.AllowUserToOrderColumns = true;
            this.dgvSeleccionados.AllowUserToResizeColumns = false;
            this.dgvSeleccionados.AllowUserToResizeRows = false;
            this.dgvSeleccionados.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellido,
            this.Telefono});
            this.dgvSeleccionados.Location = new System.Drawing.Point(375, 81);
            this.dgvSeleccionados.MultiSelect = false;
            this.dgvSeleccionados.Name = "dgvSeleccionados";
            this.dgvSeleccionados.ReadOnly = true;
            this.dgvSeleccionados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSeleccionados.RowHeadersVisible = false;
            this.dgvSeleccionados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeleccionados.ShowEditingIcon = false;
            this.dgvSeleccionados.Size = new System.Drawing.Size(305, 300);
            this.dgvSeleccionados.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // JugadoresSeleccionados
            // 
            this.JugadoresSeleccionados.AutoSize = true;
            this.JugadoresSeleccionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JugadoresSeleccionados.Location = new System.Drawing.Point(372, 60);
            this.JugadoresSeleccionados.Name = "JugadoresSeleccionados";
            this.JugadoresSeleccionados.Size = new System.Drawing.Size(142, 15);
            this.JugadoresSeleccionados.TabIndex = 2;
            this.JugadoresSeleccionados.Text = "Jugadores Seleccinados";
            // 
            // lblJugadoresDisponibles
            // 
            this.lblJugadoresDisponibles.AutoSize = true;
            this.lblJugadoresDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadoresDisponibles.ForeColor = System.Drawing.Color.Black;
            this.lblJugadoresDisponibles.Location = new System.Drawing.Point(11, 60);
            this.lblJugadoresDisponibles.Name = "lblJugadoresDisponibles";
            this.lblJugadoresDisponibles.Size = new System.Drawing.Size(133, 15);
            this.lblJugadoresDisponibles.TabIndex = 3;
            this.lblJugadoresDisponibles.Text = "Jugadores Disponibles";
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.AllowUserToAddRows = false;
            this.dgvDisponibles.AllowUserToDeleteRows = false;
            this.dgvDisponibles.AllowUserToOrderColumns = true;
            this.dgvDisponibles.AllowUserToResizeColumns = false;
            this.dgvDisponibles.AllowUserToResizeRows = false;
            this.dgvDisponibles.AutoGenerateColumns = false;
            this.dgvDisponibles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codjdrDataGridViewTextBoxColumn,
            this.nomjdrDataGridViewTextBoxColumn,
            this.apelljdrDataGridViewTextBoxColumn,
            this.teljdrDataGridViewTextBoxColumn});
            this.dgvDisponibles.DataSource = this.dsListadoJugadoresDisponiblesBindingSource;
            this.dgvDisponibles.Location = new System.Drawing.Point(14, 81);
            this.dgvDisponibles.MultiSelect = false;
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.ReadOnly = true;
            this.dgvDisponibles.RowHeadersVisible = false;
            this.dgvDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDisponibles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisponibles.Size = new System.Drawing.Size(305, 300);
            this.dgvDisponibles.TabIndex = 4;
            // 
            // codjdrDataGridViewTextBoxColumn
            // 
            this.codjdrDataGridViewTextBoxColumn.DataPropertyName = "cod_jdr";
            this.codjdrDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codjdrDataGridViewTextBoxColumn.Name = "codjdrDataGridViewTextBoxColumn";
            this.codjdrDataGridViewTextBoxColumn.ReadOnly = true;
            this.codjdrDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomjdrDataGridViewTextBoxColumn
            // 
            this.nomjdrDataGridViewTextBoxColumn.DataPropertyName = "nom_jdr";
            this.nomjdrDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomjdrDataGridViewTextBoxColumn.Name = "nomjdrDataGridViewTextBoxColumn";
            this.nomjdrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apelljdrDataGridViewTextBoxColumn
            // 
            this.apelljdrDataGridViewTextBoxColumn.DataPropertyName = "apell_jdr";
            this.apelljdrDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apelljdrDataGridViewTextBoxColumn.Name = "apelljdrDataGridViewTextBoxColumn";
            this.apelljdrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teljdrDataGridViewTextBoxColumn
            // 
            this.teljdrDataGridViewTextBoxColumn.DataPropertyName = "tel_jdr";
            this.teljdrDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.teljdrDataGridViewTextBoxColumn.Name = "teljdrDataGridViewTextBoxColumn";
            this.teljdrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsListadoJugadoresDisponiblesBindingSource
            // 
            this.dsListadoJugadoresDisponiblesBindingSource.DataMember = "dsListadoJugadoresDisponibles";
            this.dsListadoJugadoresDisponiblesBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsDatosBD
            // 
            this.dsDatosBD.DataSetName = "dsDatosBD";
            this.dsDatosBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(325, 218);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(44, 36);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "<<";
            this.ttTool1.SetToolTip(this.btnQuitar, "Quitar");
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(325, 176);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = ">>";
            this.ttTool1.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(636, 16);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(44, 36);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboSeleccionarEquipo
            // 
            this.cboSeleccionarEquipo.DataSource = this.dsListadoEquiposDisponiblesBindingSource;
            this.cboSeleccionarEquipo.DisplayMember = "nom_eqp";
            this.cboSeleccionarEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeleccionarEquipo.FormattingEnabled = true;
            this.cboSeleccionarEquipo.Location = new System.Drawing.Point(67, 24);
            this.cboSeleccionarEquipo.Name = "cboSeleccionarEquipo";
            this.cboSeleccionarEquipo.Size = new System.Drawing.Size(150, 23);
            this.cboSeleccionarEquipo.TabIndex = 0;
            this.cboSeleccionarEquipo.ValueMember = "cod_eqp";
            // 
            // dsListadoEquiposDisponiblesBindingSource
            // 
            this.dsListadoEquiposDisponiblesBindingSource.DataMember = "dsListadoEquiposDisponibles";
            this.dsListadoEquiposDisponiblesBindingSource.DataSource = this.dsDatosBD;
            // 
            // lblNombreCamp
            // 
            this.lblNombreCamp.AutoSize = true;
            this.lblNombreCamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCamp.Location = new System.Drawing.Point(15, 27);
            this.lblNombreCamp.Name = "lblNombreCamp";
            this.lblNombreCamp.Size = new System.Drawing.Size(46, 15);
            this.lblNombreCamp.TabIndex = 9;
            this.lblNombreCamp.Text = "Equipo";
            // 
            // btnNuevoJugador
            // 
            this.btnNuevoJugador.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoJugador.Image")));
            this.btnNuevoJugador.Location = new System.Drawing.Point(325, 260);
            this.btnNuevoJugador.Name = "btnNuevoJugador";
            this.btnNuevoJugador.Size = new System.Drawing.Size(44, 36);
            this.btnNuevoJugador.TabIndex = 4;
            this.ttTool1.SetToolTip(this.btnNuevoJugador, "Nuevo Jugador");
            this.btnNuevoJugador.UseVisualStyleBackColor = true;
            this.btnNuevoJugador.Click += new System.EventHandler(this.btnNuevoJugador_Click);
            // 
            // btnAñadirEquipo
            // 
            this.btnAñadirEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadirEquipo.Image")));
            this.btnAñadirEquipo.Location = new System.Drawing.Point(586, 16);
            this.btnAñadirEquipo.Name = "btnAñadirEquipo";
            this.btnAñadirEquipo.Size = new System.Drawing.Size(44, 36);
            this.btnAñadirEquipo.TabIndex = 5;
            this.ttTool1.SetToolTip(this.btnAñadirEquipo, "Añadir Equipo a Campeonato");
            this.btnAñadirEquipo.UseVisualStyleBackColor = true;
            this.btnAñadirEquipo.Click += new System.EventHandler(this.btnAñadirEquipo_Click);
            // 
            // btnNuevoEquipo
            // 
            this.btnNuevoEquipo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEquipo.Image")));
            this.btnNuevoEquipo.Location = new System.Drawing.Point(223, 16);
            this.btnNuevoEquipo.Name = "btnNuevoEquipo";
            this.btnNuevoEquipo.Size = new System.Drawing.Size(44, 36);
            this.btnNuevoEquipo.TabIndex = 1;
            this.ttTool1.SetToolTip(this.btnNuevoEquipo, "Nuevo Equipo");
            this.btnNuevoEquipo.UseVisualStyleBackColor = true;
            this.btnNuevoEquipo.Click += new System.EventHandler(this.btnNuevoEquipo_Click);
            // 
            // dsListadoEquiposDisponiblesTA
            // 
            this.dsListadoEquiposDisponiblesTA.ClearBeforeFill = true;
            // 
            // dsListadoJugadoresDisponiblesTA
            // 
            this.dsListadoJugadoresDisponiblesTA.ClearBeforeFill = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(13, 404);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 15);
            this.lblBuscar.TabIndex = 10;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(64, 401);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(174, 21);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(244, 393);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(44, 36);
            this.btnRefrescar.TabIndex = 12;
            this.ttTool1.SetToolTip(this.btnRefrescar, "Refrescar");
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // wfDetalleJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 442);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnNuevoEquipo);
            this.Controls.Add(this.btnAñadirEquipo);
            this.Controls.Add(this.btnNuevoJugador);
            this.Controls.Add(this.lblNombreCamp);
            this.Controls.Add(this.cboSeleccionarEquipo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.dgvDisponibles);
            this.Controls.Add(this.lblJugadoresDisponibles);
            this.Controls.Add(this.JugadoresSeleccionados);
            this.Controls.Add(this.dgvSeleccionados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfDetalleJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Equipos Campeonato - ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.wfPlantilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoJugadoresDisponiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoEquiposDisponiblesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeleccionados;
        private System.Windows.Forms.Label JugadoresSeleccionados;
        private System.Windows.Forms.Label lblJugadoresDisponibles;
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboSeleccionarEquipo;
        private System.Windows.Forms.Label lblNombreCamp;
        private System.Windows.Forms.Button btnNuevoJugador;
        private System.Windows.Forms.ToolTip ttTool1;
        private System.Windows.Forms.Button btnAñadirEquipo;
        private System.Windows.Forms.Button btnNuevoEquipo;
        private dsDatosBD dsDatosBD;
        private System.Windows.Forms.BindingSource dsListadoEquiposDisponiblesBindingSource;
        private dsDatosBDTableAdapters.dsListadoEquiposDisponiblesTA dsListadoEquiposDisponiblesTA;
        private System.Windows.Forms.BindingSource dsListadoJugadoresDisponiblesBindingSource;
        private dsDatosBDTableAdapters.dsListadoJugadoresDisponiblesTA dsListadoJugadoresDisponiblesTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn direjdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotojdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activojdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codjdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomjdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelljdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teljdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnRefrescar;
    }
}