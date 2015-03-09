/* Autor: Anthony Molineros
 * Se registran todos los movimientos que se realicen en el software de footballmanager
 * Fecha: 22/08/2014 - Comentario: Diseño y Programación de wfVisorEventos
 * Fecha: 03/08/2014 - Comentario: Configuración de dgvVisorEventos y preparación para interacción con BD
*/
namespace Football_Manager
{
    partial class wfVisorEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfVisorEventos));
            this.dgvVisorEventos = new System.Windows.Forms.DataGridView();
            this.codctrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariousrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechhoractrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionctrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipctrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maquinactrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsListadoEventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD = new Football_Manager.dsDatosBD();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dsListadoEventosTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoEventosTA();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisorEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoEventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisorEventos
            // 
            this.dgvVisorEventos.AllowUserToAddRows = false;
            this.dgvVisorEventos.AllowUserToDeleteRows = false;
            this.dgvVisorEventos.AllowUserToOrderColumns = true;
            this.dgvVisorEventos.AutoGenerateColumns = false;
            this.dgvVisorEventos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVisorEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisorEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codctrlDataGridViewTextBoxColumn,
            this.usuariousrDataGridViewTextBoxColumn,
            this.fechhoractrlDataGridViewTextBoxColumn,
            this.accionctrlDataGridViewTextBoxColumn,
            this.ipctrlDataGridViewTextBoxColumn,
            this.maquinactrlDataGridViewTextBoxColumn});
            this.dgvVisorEventos.DataSource = this.dsListadoEventosBindingSource;
            this.dgvVisorEventos.Location = new System.Drawing.Point(13, 15);
            this.dgvVisorEventos.MultiSelect = false;
            this.dgvVisorEventos.Name = "dgvVisorEventos";
            this.dgvVisorEventos.ReadOnly = true;
            this.dgvVisorEventos.RowHeadersVisible = false;
            this.dgvVisorEventos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVisorEventos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisorEventos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVisorEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisorEventos.ShowEditingIcon = false;
            this.dgvVisorEventos.Size = new System.Drawing.Size(708, 300);
            this.dgvVisorEventos.TabIndex = 2;
            // 
            // codctrlDataGridViewTextBoxColumn
            // 
            this.codctrlDataGridViewTextBoxColumn.DataPropertyName = "cod_ctrl";
            this.codctrlDataGridViewTextBoxColumn.HeaderText = "cod_ctrl";
            this.codctrlDataGridViewTextBoxColumn.Name = "codctrlDataGridViewTextBoxColumn";
            this.codctrlDataGridViewTextBoxColumn.ReadOnly = true;
            this.codctrlDataGridViewTextBoxColumn.Visible = false;
            this.codctrlDataGridViewTextBoxColumn.Width = 120;
            // 
            // usuariousrDataGridViewTextBoxColumn
            // 
            this.usuariousrDataGridViewTextBoxColumn.DataPropertyName = "usuario_usr";
            this.usuariousrDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuariousrDataGridViewTextBoxColumn.Name = "usuariousrDataGridViewTextBoxColumn";
            this.usuariousrDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuariousrDataGridViewTextBoxColumn.Width = 80;
            // 
            // fechhoractrlDataGridViewTextBoxColumn
            // 
            this.fechhoractrlDataGridViewTextBoxColumn.DataPropertyName = "fechhora_ctrl";
            this.fechhoractrlDataGridViewTextBoxColumn.HeaderText = "Tiempo";
            this.fechhoractrlDataGridViewTextBoxColumn.Name = "fechhoractrlDataGridViewTextBoxColumn";
            this.fechhoractrlDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechhoractrlDataGridViewTextBoxColumn.Width = 140;
            // 
            // accionctrlDataGridViewTextBoxColumn
            // 
            this.accionctrlDataGridViewTextBoxColumn.DataPropertyName = "accion_ctrl";
            this.accionctrlDataGridViewTextBoxColumn.HeaderText = "Acción";
            this.accionctrlDataGridViewTextBoxColumn.Name = "accionctrlDataGridViewTextBoxColumn";
            this.accionctrlDataGridViewTextBoxColumn.ReadOnly = true;
            this.accionctrlDataGridViewTextBoxColumn.Width = 160;
            // 
            // ipctrlDataGridViewTextBoxColumn
            // 
            this.ipctrlDataGridViewTextBoxColumn.DataPropertyName = "ip_ctrl";
            this.ipctrlDataGridViewTextBoxColumn.HeaderText = "IP";
            this.ipctrlDataGridViewTextBoxColumn.Name = "ipctrlDataGridViewTextBoxColumn";
            this.ipctrlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maquinactrlDataGridViewTextBoxColumn
            // 
            this.maquinactrlDataGridViewTextBoxColumn.DataPropertyName = "maquina_ctrl";
            this.maquinactrlDataGridViewTextBoxColumn.HeaderText = "Maquina";
            this.maquinactrlDataGridViewTextBoxColumn.Name = "maquinactrlDataGridViewTextBoxColumn";
            this.maquinactrlDataGridViewTextBoxColumn.ReadOnly = true;
            this.maquinactrlDataGridViewTextBoxColumn.Width = 225;
            // 
            // dsListadoEventosBindingSource
            // 
            this.dsListadoEventosBindingSource.DataMember = "dsListadoEventos";
            this.dsListadoEventosBindingSource.DataSource = this.dsDatosBD;
            this.dsListadoEventosBindingSource.Filter = "";
            // 
            // dsDatosBD
            // 
            this.dsDatosBD.DataSetName = "dsDatosBD";
            this.dsDatosBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(677, 321);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 36);
            this.btnCerrar.TabIndex = 2;
            this.ttTool1.SetToolTip(this.btnCerrar, "Aceptar");
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(10, 332);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 15);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(61, 329);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(150, 21);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // dsListadoEventosTA
            // 
            this.dsListadoEventosTA.ClearBeforeFill = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(217, 321);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(44, 36);
            this.btnRefrescar.TabIndex = 1;
            this.ttTool1.SetToolTip(this.btnRefrescar, "Refrescar");
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // wfVisorEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 367);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvVisorEventos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfVisorEventos";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Visor de Eventos";
            this.Load += new System.EventHandler(this.wfVisorEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisorEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoEventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisorEventos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ToolTip ttTool1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private dsDatosBD dsDatosBD;
        private dsDatosBDTableAdapters.dsListadoEventosTA dsListadoEventosTA;
        public System.Windows.Forms.BindingSource dsListadoEventosBindingSource;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codctrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariousrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechhoractrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accionctrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipctrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maquinactrlDataGridViewTextBoxColumn;
    }
}