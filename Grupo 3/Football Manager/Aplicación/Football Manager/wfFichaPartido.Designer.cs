/*Autor: Kevin Gutierrez
 * Fecha: 05/julio/2014
 * Comentario: Lleva el control de las actividades de un determinado campeonato.
 */
 
namespace Football_Manager
{
    partial class wfFichaPartido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfFichaPartido));
            this.lblEquipoLocal = new System.Windows.Forms.Label();
            this.lblEquipoVisitante = new System.Windows.Forms.Label();
            this.dgvEquipoLocal = new System.Windows.Forms.DataGridView();
            this.cod_jdrL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomjdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelljdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPartidoLocalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD = new Football_Manager.dsDatosBD();
            this.dgvEquipoVisitante = new System.Windows.Forms.DataGridView();
            this.cod_jdrV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomjdrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelljdrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ta_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tr_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gl_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPartidoVisitanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEquipoVisitanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEquipoLocal = new System.Windows.Forms.TextBox();
            this.txtEquipoVisitante = new System.Windows.Forms.TextBox();
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.dsPartidoLocalTA = new Football_Manager.dsDatosBDTableAdapters.dsPartidoLocalTA();
            this.dsPartidoVisitanteTA = new Football_Manager.dsDatosBDTableAdapters.dsPartidoVisitanteTA();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipoLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPartidoLocalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipoVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPartidoVisitanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEquipoVisitanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEquipoLocal
            // 
            this.lblEquipoLocal.AutoSize = true;
            this.lblEquipoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoLocal.Location = new System.Drawing.Point(12, 16);
            this.lblEquipoLocal.Name = "lblEquipoLocal";
            this.lblEquipoLocal.Size = new System.Drawing.Size(79, 15);
            this.lblEquipoLocal.TabIndex = 0;
            this.lblEquipoLocal.Text = "Equipo Local";
            this.lblEquipoLocal.Click += new System.EventHandler(this.lblEquipoLocal_Click);
            // 
            // lblEquipoVisitante
            // 
            this.lblEquipoVisitante.AutoSize = true;
            this.lblEquipoVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoVisitante.Location = new System.Drawing.Point(371, 16);
            this.lblEquipoVisitante.Name = "lblEquipoVisitante";
            this.lblEquipoVisitante.Size = new System.Drawing.Size(95, 15);
            this.lblEquipoVisitante.TabIndex = 1;
            this.lblEquipoVisitante.Text = "Equipo Visitante";
            this.lblEquipoVisitante.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvEquipoLocal
            // 
            this.dgvEquipoLocal.AllowUserToAddRows = false;
            this.dgvEquipoLocal.AllowUserToDeleteRows = false;
            this.dgvEquipoLocal.AllowUserToResizeColumns = false;
            this.dgvEquipoLocal.AllowUserToResizeRows = false;
            this.dgvEquipoLocal.AutoGenerateColumns = false;
            this.dgvEquipoLocal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEquipoLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipoLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_jdrL,
            this.nomjdrDataGridViewTextBoxColumn,
            this.apelljdrDataGridViewTextBoxColumn,
            this.ta,
            this.tr,
            this.gl});
            this.dgvEquipoLocal.DataSource = this.dsPartidoLocalBindingSource;
            this.dgvEquipoLocal.Location = new System.Drawing.Point(12, 40);
            this.dgvEquipoLocal.MultiSelect = false;
            this.dgvEquipoLocal.Name = "dgvEquipoLocal";
            this.dgvEquipoLocal.RowHeadersVisible = false;
            this.dgvEquipoLocal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEquipoLocal.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipoLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipoLocal.Size = new System.Drawing.Size(356, 300);
            this.dgvEquipoLocal.StandardTab = true;
            this.dgvEquipoLocal.TabIndex = 5;
            this.dgvEquipoLocal.Tag = "";
            this.dgvEquipoLocal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipoLocal_CellContentClick);
            // 
            // cod_jdrL
            // 
            this.cod_jdrL.DataPropertyName = "cod_jdr";
            this.cod_jdrL.HeaderText = "Codigo Jugador";
            this.cod_jdrL.Name = "cod_jdrL";
            this.cod_jdrL.Visible = false;
            // 
            // nomjdrDataGridViewTextBoxColumn
            // 
            this.nomjdrDataGridViewTextBoxColumn.DataPropertyName = "nom_jdr";
            this.nomjdrDataGridViewTextBoxColumn.HeaderText = "Nombre Jugador";
            this.nomjdrDataGridViewTextBoxColumn.Name = "nomjdrDataGridViewTextBoxColumn";
            this.nomjdrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apelljdrDataGridViewTextBoxColumn
            // 
            this.apelljdrDataGridViewTextBoxColumn.DataPropertyName = "apell_jdr";
            this.apelljdrDataGridViewTextBoxColumn.HeaderText = "Apellido Jugador";
            this.apelljdrDataGridViewTextBoxColumn.Name = "apelljdrDataGridViewTextBoxColumn";
            this.apelljdrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ta
            // 
            dataGridViewCellStyle1.Format = "N0";
            this.ta.DefaultCellStyle = dataGridViewCellStyle1;
            this.ta.HeaderText = "Tarjeta Amarilla";
            this.ta.MaxInputLength = 2;
            this.ta.Name = "ta";
            this.ta.Width = 50;
            // 
            // tr
            // 
            dataGridViewCellStyle2.Format = "N0";
            this.tr.DefaultCellStyle = dataGridViewCellStyle2;
            this.tr.HeaderText = "Tarjeta Roja";
            this.tr.MaxInputLength = 2;
            this.tr.Name = "tr";
            this.tr.Width = 50;
            // 
            // gl
            // 
            dataGridViewCellStyle3.Format = "N0";
            this.gl.DefaultCellStyle = dataGridViewCellStyle3;
            this.gl.HeaderText = "Gol (es)";
            this.gl.MaxInputLength = 2;
            this.gl.Name = "gl";
            this.gl.Width = 50;
            // 
            // dsPartidoLocalBindingSource
            // 
            this.dsPartidoLocalBindingSource.DataMember = "dsPartidoLocal";
            this.dsPartidoLocalBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsDatosBD
            // 
            this.dsDatosBD.DataSetName = "dsDatosBD";
            this.dsDatosBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvEquipoVisitante
            // 
            this.dgvEquipoVisitante.AllowUserToAddRows = false;
            this.dgvEquipoVisitante.AllowUserToDeleteRows = false;
            this.dgvEquipoVisitante.AllowUserToResizeColumns = false;
            this.dgvEquipoVisitante.AllowUserToResizeRows = false;
            this.dgvEquipoVisitante.AutoGenerateColumns = false;
            this.dgvEquipoVisitante.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEquipoVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipoVisitante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_jdrV,
            this.nomjdrDataGridViewTextBoxColumn1,
            this.apelljdrDataGridViewTextBoxColumn1,
            this.ta_v,
            this.tr_v,
            this.gl_v});
            this.dgvEquipoVisitante.DataSource = this.dsPartidoVisitanteBindingSource;
            this.dgvEquipoVisitante.Location = new System.Drawing.Point(374, 40);
            this.dgvEquipoVisitante.MultiSelect = false;
            this.dgvEquipoVisitante.Name = "dgvEquipoVisitante";
            this.dgvEquipoVisitante.RowHeadersVisible = false;
            this.dgvEquipoVisitante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEquipoVisitante.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipoVisitante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipoVisitante.Size = new System.Drawing.Size(355, 300);
            this.dgvEquipoVisitante.TabIndex = 6;
            // 
            // cod_jdrV
            // 
            this.cod_jdrV.DataPropertyName = "cod_jdr";
            this.cod_jdrV.HeaderText = "Codigo Jugador";
            this.cod_jdrV.Name = "cod_jdrV";
            this.cod_jdrV.Visible = false;
            // 
            // nomjdrDataGridViewTextBoxColumn1
            // 
            this.nomjdrDataGridViewTextBoxColumn1.DataPropertyName = "nom_jdr";
            this.nomjdrDataGridViewTextBoxColumn1.HeaderText = "Nombre Jugador";
            this.nomjdrDataGridViewTextBoxColumn1.Name = "nomjdrDataGridViewTextBoxColumn1";
            this.nomjdrDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // apelljdrDataGridViewTextBoxColumn1
            // 
            this.apelljdrDataGridViewTextBoxColumn1.DataPropertyName = "apell_jdr";
            this.apelljdrDataGridViewTextBoxColumn1.HeaderText = "Apellido Jugador";
            this.apelljdrDataGridViewTextBoxColumn1.Name = "apelljdrDataGridViewTextBoxColumn1";
            this.apelljdrDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ta_v
            // 
            dataGridViewCellStyle4.Format = "N0";
            this.ta_v.DefaultCellStyle = dataGridViewCellStyle4;
            this.ta_v.HeaderText = "Tarjeta Amarilla";
            this.ta_v.MaxInputLength = 2;
            this.ta_v.Name = "ta_v";
            this.ta_v.Width = 50;
            // 
            // tr_v
            // 
            dataGridViewCellStyle5.Format = "N0";
            this.tr_v.DefaultCellStyle = dataGridViewCellStyle5;
            this.tr_v.HeaderText = "Tarjeta Roja";
            this.tr_v.MaxInputLength = 2;
            this.tr_v.Name = "tr_v";
            this.tr_v.Width = 50;
            // 
            // gl_v
            // 
            dataGridViewCellStyle6.Format = "N0";
            this.gl_v.DefaultCellStyle = dataGridViewCellStyle6;
            this.gl_v.HeaderText = "Gol (es)";
            this.gl_v.MaxInputLength = 2;
            this.gl_v.Name = "gl_v";
            this.gl_v.Width = 50;
            // 
            // dsPartidoVisitanteBindingSource
            // 
            this.dsPartidoVisitanteBindingSource.DataMember = "dsPartidoVisitante";
            this.dsPartidoVisitanteBindingSource.DataSource = this.dsDatosBD;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(685, 346);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(44, 36);
            this.btnGuardar.TabIndex = 0;
            this.ttTool1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEquipoLocal
            // 
            this.txtEquipoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipoLocal.Location = new System.Drawing.Point(97, 13);
            this.txtEquipoLocal.Name = "txtEquipoLocal";
            this.txtEquipoLocal.ReadOnly = true;
            this.txtEquipoLocal.Size = new System.Drawing.Size(150, 21);
            this.txtEquipoLocal.TabIndex = 10;
            this.txtEquipoLocal.TextChanged += new System.EventHandler(this.txtEquipoLocal_TextChanged);
            // 
            // txtEquipoVisitante
            // 
            this.txtEquipoVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipoVisitante.Location = new System.Drawing.Point(472, 13);
            this.txtEquipoVisitante.Name = "txtEquipoVisitante";
            this.txtEquipoVisitante.ReadOnly = true;
            this.txtEquipoVisitante.Size = new System.Drawing.Size(150, 21);
            this.txtEquipoVisitante.TabIndex = 11;
            this.txtEquipoVisitante.TextChanged += new System.EventHandler(this.txtEquipoVisitante_TextChanged);
            // 
            // dsPartidoLocalTA
            // 
            this.dsPartidoLocalTA.ClearBeforeFill = true;
            // 
            // dsPartidoVisitanteTA
            // 
            this.dsPartidoVisitanteTA.ClearBeforeFill = true;
            // 
            // wfFichaPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 394);
            this.Controls.Add(this.txtEquipoVisitante);
            this.Controls.Add(this.txtEquipoLocal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvEquipoVisitante);
            this.Controls.Add(this.dgvEquipoLocal);
            this.Controls.Add(this.lblEquipoVisitante);
            this.Controls.Add(this.lblEquipoLocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfFichaPartido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ficha de Partido";
            this.Load += new System.EventHandler(this.wfPartido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipoLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPartidoLocalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipoVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPartidoVisitanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEquipoVisitanteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquipoLocal;
        private System.Windows.Forms.Label lblEquipoVisitante;
        private System.Windows.Forms.DataGridView dgvEquipoLocal;
        private System.Windows.Forms.DataGridView dgvEquipoVisitante;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ToolTip ttTool1;
        private System.Windows.Forms.BindingSource dsEquipoVisitanteBindingSource;
        public System.Windows.Forms.TextBox txtEquipoLocal;
        public System.Windows.Forms.TextBox txtEquipoVisitante;
        private dsDatosBD dsDatosBD;
        private System.Windows.Forms.BindingSource dsPartidoLocalBindingSource;
        private dsDatosBDTableAdapters.dsPartidoLocalTA dsPartidoLocalTA;
        private System.Windows.Forms.BindingSource dsPartidoVisitanteBindingSource;
        private dsDatosBDTableAdapters.dsPartidoVisitanteTA dsPartidoVisitanteTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn codjdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddjdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddptdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tadptdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trdptdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gldptdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codjdrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddjdrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddptdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tadptdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trdptdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gldptdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_jdrL;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomjdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelljdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tr;
        private System.Windows.Forms.DataGridViewTextBoxColumn gl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_jdrV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomjdrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelljdrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ta_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn tr_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn gl_v;
    }
}