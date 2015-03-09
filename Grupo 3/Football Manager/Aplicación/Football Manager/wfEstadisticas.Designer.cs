/*Autor: Marlon Aldana
 * Fecha: 05/julio/2014
 * Comentario: Presenta reportes de tabla de posiciones y el control de goleadores
 */
 
namespace Football_Manager
{
    partial class wfEstadisticas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEstadisticas));
            this.dsListadoGoleadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD = new Football_Manager.dsDatosBD();
            this.dsListadoCampeonatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEstadisticaEquiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbElegirCpn = new System.Windows.Forms.ComboBox();
            this.lblCpn = new System.Windows.Forms.Label();
            this.tpGoleadores = new System.Windows.Forms.TabPage();
            this.rvGoleadores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpPosiciones = new System.Windows.Forms.TabPage();
            this.rvPosiciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tcTabsEstadisticas = new System.Windows.Forms.TabControl();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblJornada = new System.Windows.Forms.Label();
            this.cboJornada = new System.Windows.Forms.ComboBox();
            this.dsListadoJornadasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsListadoJornadasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD2 = new Football_Manager.dsDatosBD();
            this.dsListadoJornadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListadoPartidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD1 = new Football_Manager.dsDatosBD();
            this.dsListadoCampeonatosTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoCampeonatosTA();
            this.dsListadoPartidosTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoPartidosTA();
            this.dsListadoJornadasTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoJornadasTA();
            this.dsListadoGoleadoresTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoGoleadoresTA();
            this.dsEstadisticaEquiposTA = new Football_Manager.dsDatosBDTableAdapters.dsEstadisticaEquiposTA();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoGoleadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoCampeonatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadisticaEquiposBindingSource)).BeginInit();
            this.tpGoleadores.SuspendLayout();
            this.tpPosiciones.SuspendLayout();
            this.tcTabsEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoJornadasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoJornadasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoJornadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoPartidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsListadoGoleadoresBindingSource
            // 
            this.dsListadoGoleadoresBindingSource.DataMember = "dsListadoGoleadores";
            this.dsListadoGoleadoresBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsDatosBD
            // 
            this.dsDatosBD.DataSetName = "dsDatosBD";
            this.dsDatosBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsListadoCampeonatosBindingSource
            // 
            this.dsListadoCampeonatosBindingSource.DataMember = "dsListadoCampeonatos";
            this.dsListadoCampeonatosBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsEstadisticaEquiposBindingSource
            // 
            this.dsEstadisticaEquiposBindingSource.DataMember = "dsEstadisticaEquipos";
            this.dsEstadisticaEquiposBindingSource.DataSource = this.dsDatosBD;
            // 
            // cbElegirCpn
            // 
            this.cbElegirCpn.DataSource = this.dsListadoCampeonatosBindingSource;
            this.cbElegirCpn.DisplayMember = "nom_camp";
            this.cbElegirCpn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbElegirCpn.FormattingEnabled = true;
            this.cbElegirCpn.Location = new System.Drawing.Point(97, 14);
            this.cbElegirCpn.Name = "cbElegirCpn";
            this.cbElegirCpn.Size = new System.Drawing.Size(150, 23);
            this.cbElegirCpn.TabIndex = 0;
            this.cbElegirCpn.ValueMember = "cod_camp";
            this.cbElegirCpn.SelectedIndexChanged += new System.EventHandler(this.cbElegirCpn_SelectedIndexChanged);
            // 
            // lblCpn
            // 
            this.lblCpn.AutoSize = true;
            this.lblCpn.Location = new System.Drawing.Point(13, 17);
            this.lblCpn.Name = "lblCpn";
            this.lblCpn.Size = new System.Drawing.Size(78, 15);
            this.lblCpn.TabIndex = 4;
            this.lblCpn.Text = "Campeonato";
            // 
            // tpGoleadores
            // 
            this.tpGoleadores.Controls.Add(this.rvGoleadores);
            this.tpGoleadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpGoleadores.Location = new System.Drawing.Point(4, 24);
            this.tpGoleadores.Name = "tpGoleadores";
            this.tpGoleadores.Padding = new System.Windows.Forms.Padding(3);
            this.tpGoleadores.Size = new System.Drawing.Size(607, 375);
            this.tpGoleadores.TabIndex = 2;
            this.tpGoleadores.Text = "Tabla de Goleadores";
            this.tpGoleadores.UseVisualStyleBackColor = true;
            // 
            // rvGoleadores
            // 
            reportDataSource1.Name = "dsGoleadores";
            reportDataSource1.Value = this.dsListadoGoleadoresBindingSource;
            reportDataSource2.Name = "dsDettCampeonato";
            reportDataSource2.Value = this.dsListadoCampeonatosBindingSource;
            this.rvGoleadores.LocalReport.DataSources.Add(reportDataSource1);
            this.rvGoleadores.LocalReport.DataSources.Add(reportDataSource2);
            this.rvGoleadores.LocalReport.ReportEmbeddedResource = "Football_Manager.rGoleadores.rdlc";
            this.rvGoleadores.Location = new System.Drawing.Point(6, 6);
            this.rvGoleadores.Name = "rvGoleadores";
            this.rvGoleadores.ShowBackButton = false;
            this.rvGoleadores.ShowDocumentMapButton = false;
            this.rvGoleadores.ShowFindControls = false;
            this.rvGoleadores.ShowPageNavigationControls = false;
            this.rvGoleadores.ShowPrintButton = false;
            this.rvGoleadores.ShowRefreshButton = false;
            this.rvGoleadores.ShowStopButton = false;
            this.rvGoleadores.ShowZoomControl = false;
            this.rvGoleadores.Size = new System.Drawing.Size(595, 363);
            this.rvGoleadores.TabIndex = 2;
            this.rvGoleadores.Visible = false;
            // 
            // tpPosiciones
            // 
            this.tpPosiciones.Controls.Add(this.rvPosiciones);
            this.tpPosiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPosiciones.Location = new System.Drawing.Point(4, 24);
            this.tpPosiciones.Name = "tpPosiciones";
            this.tpPosiciones.Padding = new System.Windows.Forms.Padding(3);
            this.tpPosiciones.Size = new System.Drawing.Size(607, 375);
            this.tpPosiciones.TabIndex = 1;
            this.tpPosiciones.Text = "Tabla de Posiciones";
            this.tpPosiciones.UseVisualStyleBackColor = true;
            // 
            // rvPosiciones
            // 
            this.rvPosiciones.DocumentMapWidth = 8;
            reportDataSource3.Name = "dsEquipos";
            reportDataSource3.Value = this.dsEstadisticaEquiposBindingSource;
            reportDataSource4.Name = "dsCampeonatos";
            reportDataSource4.Value = this.dsListadoCampeonatosBindingSource;
            this.rvPosiciones.LocalReport.DataSources.Add(reportDataSource3);
            this.rvPosiciones.LocalReport.DataSources.Add(reportDataSource4);
            this.rvPosiciones.LocalReport.ReportEmbeddedResource = "Football_Manager.rEquipos.rdlc";
            this.rvPosiciones.Location = new System.Drawing.Point(6, 6);
            this.rvPosiciones.Name = "rvPosiciones";
            this.rvPosiciones.ShowBackButton = false;
            this.rvPosiciones.ShowFindControls = false;
            this.rvPosiciones.ShowPageNavigationControls = false;
            this.rvPosiciones.ShowPrintButton = false;
            this.rvPosiciones.ShowRefreshButton = false;
            this.rvPosiciones.ShowStopButton = false;
            this.rvPosiciones.ShowZoomControl = false;
            this.rvPosiciones.Size = new System.Drawing.Size(595, 363);
            this.rvPosiciones.TabIndex = 2;
            this.rvPosiciones.Visible = false;
            this.rvPosiciones.Load += new System.EventHandler(this.rvPosiciones_Load);
            // 
            // tcTabsEstadisticas
            // 
            this.tcTabsEstadisticas.Controls.Add(this.tpPosiciones);
            this.tcTabsEstadisticas.Controls.Add(this.tpGoleadores);
            this.tcTabsEstadisticas.Location = new System.Drawing.Point(14, 45);
            this.tcTabsEstadisticas.Name = "tcTabsEstadisticas";
            this.tcTabsEstadisticas.RightToLeftLayout = true;
            this.tcTabsEstadisticas.SelectedIndex = 0;
            this.tcTabsEstadisticas.Size = new System.Drawing.Size(615, 403);
            this.tcTabsEstadisticas.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(581, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(44, 36);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblJornada
            // 
            this.lblJornada.AutoSize = true;
            this.lblJornada.Location = new System.Drawing.Point(253, 17);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(52, 15);
            this.lblJornada.TabIndex = 5;
            this.lblJornada.Text = "Jornada";
            // 
            // cboJornada
            // 
            this.cboJornada.DataSource = this.dsListadoJornadasBindingSource2;
            this.cboJornada.DisplayMember = "jornada_dcamp";
            this.cboJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJornada.FormattingEnabled = true;
            this.cboJornada.Location = new System.Drawing.Point(311, 14);
            this.cboJornada.Name = "cboJornada";
            this.cboJornada.Size = new System.Drawing.Size(150, 23);
            this.cboJornada.TabIndex = 6;
            this.cboJornada.ValueMember = "jornada_dcamp";
            this.cboJornada.SelectedIndexChanged += new System.EventHandler(this.cboJornada_SelectedIndexChanged);
            // 
            // dsListadoJornadasBindingSource2
            // 
            this.dsListadoJornadasBindingSource2.DataMember = "dsListadoJornadas";
            this.dsListadoJornadasBindingSource2.DataSource = this.dsDatosBD;
            // 
            // dsListadoJornadasBindingSource1
            // 
            this.dsListadoJornadasBindingSource1.DataMember = "dsListadoJornadas";
            this.dsListadoJornadasBindingSource1.DataSource = this.dsDatosBD2;
            // 
            // dsDatosBD2
            // 
            this.dsDatosBD2.DataSetName = "dsDatosBD";
            this.dsDatosBD2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsListadoJornadasBindingSource
            // 
            this.dsListadoJornadasBindingSource.DataMember = "dsListadoJornadas";
            this.dsListadoJornadasBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsListadoPartidosBindingSource
            // 
            this.dsListadoPartidosBindingSource.DataMember = "dsListadoPartidos";
            this.dsListadoPartidosBindingSource.DataSource = this.dsDatosBD1;
            // 
            // dsDatosBD1
            // 
            this.dsDatosBD1.DataSetName = "dsDatosBD";
            this.dsDatosBD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsListadoCampeonatosTA
            // 
            this.dsListadoCampeonatosTA.ClearBeforeFill = true;
            // 
            // dsListadoPartidosTA
            // 
            this.dsListadoPartidosTA.ClearBeforeFill = true;
            // 
            // dsListadoJornadasTA
            // 
            this.dsListadoJornadasTA.ClearBeforeFill = true;
            // 
            // dsListadoGoleadoresTA
            // 
            this.dsListadoGoleadoresTA.ClearBeforeFill = true;
            // 
            // dsEstadisticaEquiposTA
            // 
            this.dsEstadisticaEquiposTA.ClearBeforeFill = true;
            // 
            // wfEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 460);
            this.Controls.Add(this.cboJornada);
            this.Controls.Add(this.lblJornada);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbElegirCpn);
            this.Controls.Add(this.lblCpn);
            this.Controls.Add(this.tcTabsEstadisticas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfEstadisticas";
            this.ShowInTaskbar = false;
            this.Text = "Estadisticas de Campeonatos";
            this.Load += new System.EventHandler(this.wfEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoGoleadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoCampeonatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstadisticaEquiposBindingSource)).EndInit();
            this.tpGoleadores.ResumeLayout(false);
            this.tpPosiciones.ResumeLayout(false);
            this.tcTabsEstadisticas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoJornadasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoJornadasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoJornadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoPartidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbElegirCpn;
        private System.Windows.Forms.Label lblCpn;
        private System.Windows.Forms.TabPage tpGoleadores;
        private System.Windows.Forms.TabPage tpPosiciones;
        private System.Windows.Forms.TabControl tcTabsEstadisticas;
        private System.Windows.Forms.Button btnAceptar;
        private Microsoft.Reporting.WinForms.ReportViewer rvPosiciones;
        private Microsoft.Reporting.WinForms.ReportViewer rvGoleadores;
        private dsDatosBD dsDatosBD;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.ComboBox cboJornada;
        private System.Windows.Forms.BindingSource dsListadoCampeonatosBindingSource;
        private dsDatosBDTableAdapters.dsListadoCampeonatosTA dsListadoCampeonatosTA;
        private dsDatosBD dsDatosBD1;
        private System.Windows.Forms.BindingSource dsListadoPartidosBindingSource;
        private dsDatosBDTableAdapters.dsListadoPartidosTA dsListadoPartidosTA;
        private System.Windows.Forms.BindingSource dsListadoJornadasBindingSource;
        private dsDatosBDTableAdapters.dsListadoJornadasTA dsListadoJornadasTA;
        private dsDatosBD dsDatosBD2;
        private System.Windows.Forms.BindingSource dsListadoJornadasBindingSource1;
        private System.Windows.Forms.BindingSource dsListadoJornadasBindingSource2;
        private System.Windows.Forms.BindingSource dsListadoGoleadoresBindingSource;
        private dsDatosBDTableAdapters.dsListadoGoleadoresTA dsListadoGoleadoresTA;
        private System.Windows.Forms.BindingSource dsEstadisticaEquiposBindingSource;
        private dsDatosBDTableAdapters.dsEstadisticaEquiposTA dsEstadisticaEquiposTA;
    }
}