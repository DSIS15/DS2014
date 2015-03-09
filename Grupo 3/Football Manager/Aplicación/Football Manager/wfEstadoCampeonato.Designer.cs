/*Autor: Anthony Molineros y Marlon Aldana
 * Fecha: 05/julio/2014
 * Comentario: Muestra el listado de los partidos a jugar en un campeonato determinado.
 */
 
namespace Football_Manager
{
    partial class wfEstadoCampeonato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEstadoCampeonato));
            this.lblSelectCpn = new System.Windows.Forms.Label();
            this.cboCamponato = new System.Windows.Forms.ComboBox();
            this.dsListadoCampeonatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD = new Football_Manager.dsDatosBD();
            this.lblFechIni = new System.Windows.Forms.Label();
            this.lblFechFin = new System.Windows.Forms.Label();
            this.dgvPartidos = new System.Windows.Forms.DataGridView();
            this.cod_ptd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expr3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elocal_ptd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evisitante_ptd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomchaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jornadaptdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechhoraptdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeqpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlocalptdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvisitanteptdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadoptdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsListadoPartidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFechIni = new System.Windows.Forms.TextBox();
            this.txtFechFin = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnPartido = new System.Windows.Forms.Button();
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.dsListadoCampeonatosTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoCampeonatosTA();
            this.dsListadoPartidosTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoPartidosTA();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoCampeonatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoPartidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectCpn
            // 
            this.lblSelectCpn.AutoSize = true;
            this.lblSelectCpn.Location = new System.Drawing.Point(12, 17);
            this.lblSelectCpn.Name = "lblSelectCpn";
            this.lblSelectCpn.Size = new System.Drawing.Size(146, 15);
            this.lblSelectCpn.TabIndex = 0;
            this.lblSelectCpn.Text = "Seleccionar Campeonato";
            // 
            // cboCamponato
            // 
            this.cboCamponato.DataSource = this.dsListadoCampeonatosBindingSource;
            this.cboCamponato.DisplayMember = "nom_camp";
            this.cboCamponato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamponato.FormattingEnabled = true;
            this.cboCamponato.Location = new System.Drawing.Point(163, 14);
            this.cboCamponato.Name = "cboCamponato";
            this.cboCamponato.Size = new System.Drawing.Size(150, 23);
            this.cboCamponato.TabIndex = 1;
            this.cboCamponato.ValueMember = "cod_camp";
            this.cboCamponato.SelectedIndexChanged += new System.EventHandler(this.cboCamponato_SelectedIndexChanged);
            // 
            // dsListadoCampeonatosBindingSource
            // 
            this.dsListadoCampeonatosBindingSource.DataMember = "dsListadoCampeonatos";
            this.dsListadoCampeonatosBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsDatosBD
            // 
            this.dsDatosBD.DataSetName = "dsDatosBD";
            this.dsDatosBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblFechIni
            // 
            this.lblFechIni.AutoSize = true;
            this.lblFechIni.Location = new System.Drawing.Point(12, 46);
            this.lblFechIni.Name = "lblFechIni";
            this.lblFechIni.Size = new System.Drawing.Size(90, 15);
            this.lblFechIni.TabIndex = 2;
            this.lblFechIni.Text = "Fecha de Inicio";
            // 
            // lblFechFin
            // 
            this.lblFechFin.AutoSize = true;
            this.lblFechFin.Location = new System.Drawing.Point(12, 73);
            this.lblFechFin.Name = "lblFechFin";
            this.lblFechFin.Size = new System.Drawing.Size(127, 15);
            this.lblFechFin.TabIndex = 3;
            this.lblFechFin.Text = "Fecha de Finalización";
            // 
            // dgvPartidos
            // 
            this.dgvPartidos.AllowUserToAddRows = false;
            this.dgvPartidos.AllowUserToDeleteRows = false;
            this.dgvPartidos.AllowUserToResizeRows = false;
            this.dgvPartidos.AutoGenerateColumns = false;
            this.dgvPartidos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_ptd,
            this.Expr3,
            this.elocal_ptd,
            this.evisitante_ptd,
            this.nomchaDataGridViewTextBoxColumn,
            this.jornadaptdDataGridViewTextBoxColumn,
            this.fechhoraptdDataGridViewTextBoxColumn,
            this.nomeqpDataGridViewTextBoxColumn,
            this.mlocalptdDataGridViewTextBoxColumn,
            this.guion,
            this.mvisitanteptdDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.jugadoptdDataGridViewTextBoxColumn});
            this.dgvPartidos.DataSource = this.dsListadoPartidosBindingSource;
            this.dgvPartidos.Location = new System.Drawing.Point(12, 133);
            this.dgvPartidos.MultiSelect = false;
            this.dgvPartidos.Name = "dgvPartidos";
            this.dgvPartidos.ReadOnly = true;
            this.dgvPartidos.RowHeadersVisible = false;
            this.dgvPartidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartidos.Size = new System.Drawing.Size(699, 300);
            this.dgvPartidos.TabIndex = 6;
            this.dgvPartidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidos_CellContentClick);
            // 
            // cod_ptd
            // 
            this.cod_ptd.DataPropertyName = "cod_ptd";
            this.cod_ptd.HeaderText = "cod_ptd";
            this.cod_ptd.Name = "cod_ptd";
            this.cod_ptd.ReadOnly = true;
            this.cod_ptd.Visible = false;
            // 
            // Expr3
            // 
            this.Expr3.DataPropertyName = "Expr3";
            this.Expr3.HeaderText = "Arbitro";
            this.Expr3.Name = "Expr3";
            this.Expr3.ReadOnly = true;
            this.Expr3.Width = 120;
            // 
            // elocal_ptd
            // 
            this.elocal_ptd.DataPropertyName = "cod_eqp";
            this.elocal_ptd.HeaderText = "elocal_ptd";
            this.elocal_ptd.Name = "elocal_ptd";
            this.elocal_ptd.ReadOnly = true;
            this.elocal_ptd.Visible = false;
            // 
            // evisitante_ptd
            // 
            this.evisitante_ptd.DataPropertyName = "Expr2";
            this.evisitante_ptd.HeaderText = "evisitante_ptd";
            this.evisitante_ptd.Name = "evisitante_ptd";
            this.evisitante_ptd.ReadOnly = true;
            this.evisitante_ptd.Visible = false;
            // 
            // nomchaDataGridViewTextBoxColumn
            // 
            this.nomchaDataGridViewTextBoxColumn.DataPropertyName = "nom_cha";
            this.nomchaDataGridViewTextBoxColumn.HeaderText = "Cancha";
            this.nomchaDataGridViewTextBoxColumn.Name = "nomchaDataGridViewTextBoxColumn";
            this.nomchaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomchaDataGridViewTextBoxColumn.Width = 120;
            // 
            // jornadaptdDataGridViewTextBoxColumn
            // 
            this.jornadaptdDataGridViewTextBoxColumn.DataPropertyName = "jornada_ptd";
            this.jornadaptdDataGridViewTextBoxColumn.HeaderText = "J";
            this.jornadaptdDataGridViewTextBoxColumn.Name = "jornadaptdDataGridViewTextBoxColumn";
            this.jornadaptdDataGridViewTextBoxColumn.ReadOnly = true;
            this.jornadaptdDataGridViewTextBoxColumn.Width = 30;
            // 
            // fechhoraptdDataGridViewTextBoxColumn
            // 
            this.fechhoraptdDataGridViewTextBoxColumn.DataPropertyName = "fechhora_ptd";
            this.fechhoraptdDataGridViewTextBoxColumn.HeaderText = "Tiempo";
            this.fechhoraptdDataGridViewTextBoxColumn.Name = "fechhoraptdDataGridViewTextBoxColumn";
            this.fechhoraptdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeqpDataGridViewTextBoxColumn
            // 
            this.nomeqpDataGridViewTextBoxColumn.DataPropertyName = "nom_eqp";
            this.nomeqpDataGridViewTextBoxColumn.HeaderText = "Local";
            this.nomeqpDataGridViewTextBoxColumn.Name = "nomeqpDataGridViewTextBoxColumn";
            this.nomeqpDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeqpDataGridViewTextBoxColumn.Width = 125;
            // 
            // mlocalptdDataGridViewTextBoxColumn
            // 
            this.mlocalptdDataGridViewTextBoxColumn.DataPropertyName = "mlocal_ptd";
            this.mlocalptdDataGridViewTextBoxColumn.HeaderText = "";
            this.mlocalptdDataGridViewTextBoxColumn.Name = "mlocalptdDataGridViewTextBoxColumn";
            this.mlocalptdDataGridViewTextBoxColumn.ReadOnly = true;
            this.mlocalptdDataGridViewTextBoxColumn.Width = 30;
            // 
            // guion
            // 
            dataGridViewCellStyle1.NullValue = "-";
            this.guion.DefaultCellStyle = dataGridViewCellStyle1;
            this.guion.HeaderText = "";
            this.guion.Name = "guion";
            this.guion.ReadOnly = true;
            this.guion.Width = 15;
            // 
            // mvisitanteptdDataGridViewTextBoxColumn
            // 
            this.mvisitanteptdDataGridViewTextBoxColumn.DataPropertyName = "mvisitante_ptd";
            this.mvisitanteptdDataGridViewTextBoxColumn.HeaderText = "";
            this.mvisitanteptdDataGridViewTextBoxColumn.Name = "mvisitanteptdDataGridViewTextBoxColumn";
            this.mvisitanteptdDataGridViewTextBoxColumn.ReadOnly = true;
            this.mvisitanteptdDataGridViewTextBoxColumn.Width = 30;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Visitante";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Width = 125;
            // 
            // jugadoptdDataGridViewTextBoxColumn
            // 
            this.jugadoptdDataGridViewTextBoxColumn.DataPropertyName = "jugado_ptd";
            this.jugadoptdDataGridViewTextBoxColumn.HeaderText = "jugado_ptd";
            this.jugadoptdDataGridViewTextBoxColumn.Name = "jugadoptdDataGridViewTextBoxColumn";
            this.jugadoptdDataGridViewTextBoxColumn.ReadOnly = true;
            this.jugadoptdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsListadoPartidosBindingSource
            // 
            this.dsListadoPartidosBindingSource.DataMember = "dsListadoPartidos";
            this.dsListadoPartidosBindingSource.DataSource = this.dsDatosBD;
            // 
            // txtFechIni
            // 
            this.txtFechIni.Location = new System.Drawing.Point(163, 43);
            this.txtFechIni.Name = "txtFechIni";
            this.txtFechIni.ReadOnly = true;
            this.txtFechIni.Size = new System.Drawing.Size(150, 21);
            this.txtFechIni.TabIndex = 8;
            // 
            // txtFechFin
            // 
            this.txtFechFin.Location = new System.Drawing.Point(163, 70);
            this.txtFechFin.Name = "txtFechFin";
            this.txtFechFin.ReadOnly = true;
            this.txtFechFin.Size = new System.Drawing.Size(150, 21);
            this.txtFechFin.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 100);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(163, 97);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(150, 21);
            this.txtEstado.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(668, 14);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(44, 36);
            this.btnAceptar.TabIndex = 12;
            this.ttTool1.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnPartido
            // 
            this.btnPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartido.Image = ((System.Drawing.Image)(resources.GetObject("btnPartido.Image")));
            this.btnPartido.Location = new System.Drawing.Point(668, 56);
            this.btnPartido.Name = "btnPartido";
            this.btnPartido.Size = new System.Drawing.Size(44, 36);
            this.btnPartido.TabIndex = 13;
            this.ttTool1.SetToolTip(this.btnPartido, "Ficha de Partido");
            this.btnPartido.UseVisualStyleBackColor = true;
            this.btnPartido.Click += new System.EventHandler(this.btnPartido_Click);
            // 
            // dsListadoCampeonatosTA
            // 
            this.dsListadoCampeonatosTA.ClearBeforeFill = true;
            // 
            // dsListadoPartidosTA
            // 
            this.dsListadoPartidosTA.ClearBeforeFill = true;
            // 
            // wfEstadoCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 446);
            this.Controls.Add(this.btnPartido);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtFechFin);
            this.Controls.Add(this.txtFechIni);
            this.Controls.Add(this.dgvPartidos);
            this.Controls.Add(this.lblFechFin);
            this.Controls.Add(this.lblFechIni);
            this.Controls.Add(this.cboCamponato);
            this.Controls.Add(this.lblSelectCpn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfEstadoCampeonato";
            this.ShowInTaskbar = false;
            this.Text = "Estado de Campeonato";
            this.Load += new System.EventHandler(this.wfEstadoCampeonato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoCampeonatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoPartidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCpn;
        private System.Windows.Forms.Label lblFechIni;
        private System.Windows.Forms.Label lblFechFin;
        private System.Windows.Forms.DataGridView dgvPartidos;
        private System.Windows.Forms.TextBox txtFechIni;
        private System.Windows.Forms.TextBox txtFechFin;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolTip ttTool1;
        private dsDatosBD dsDatosBD;
        private System.Windows.Forms.BindingSource dsListadoCampeonatosBindingSource;
        private dsDatosBDTableAdapters.dsListadoCampeonatosTA dsListadoCampeonatosTA;
        private System.Windows.Forms.BindingSource dsListadoPartidosBindingSource;
        private dsDatosBDTableAdapters.dsListadoPartidosTA dsListadoPartidosTA;
        public System.Windows.Forms.ComboBox cboCamponato;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomempDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button btnPartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_ptd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expr3;
        private System.Windows.Forms.DataGridViewTextBoxColumn elocal_ptd;
        private System.Windows.Forms.DataGridViewTextBoxColumn evisitante_ptd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomchaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jornadaptdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechhoraptdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeqpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlocalptdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guion;
        private System.Windows.Forms.DataGridViewTextBoxColumn mvisitanteptdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jugadoptdDataGridViewTextBoxColumn;
    }
}