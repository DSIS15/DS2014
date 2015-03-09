/* Autor: TODOS
 * Fecha: 02/08/2014 - Comentario: Interfaz de proyecto general
*/

namespace Football_Manager
{
    partial class wfMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfMenuPrincipal));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCampeonato = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEquipo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJugador = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSeparador1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCampeonatos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCalendarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJugadores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiControl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCanchas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTipoEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVisorEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSeparador2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.ssBarraEstado = new System.Windows.Forms.StatusStrip();
            this.tsslEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.hpAyuda = new System.Windows.Forms.HelpProvider();
            this.msMenu.SuspendLayout();
            this.ssBarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.AutoSize = false;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiCampeonatos,
            this.tsmiAdministracion,
            this.tsmiControl,
            this.windowsMenu,
            this.tsmiAyuda});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.msMenu.Size = new System.Drawing.Size(794, 55);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "MenuStrip";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.AutoSize = false;
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevo,
            this.tssSeparador1,
            this.tsmiCerrarSesion,
            this.tsmiSalir});
            this.tsmiArchivo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiArchivo.Image")));
            this.tsmiArchivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiArchivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(94, 51);
            this.tsmiArchivo.Text = "&Archivo";
            this.tsmiArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiNuevo
            // 
            this.tsmiNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCampeonato,
            this.tsmiEmpleado,
            this.tsmiEquipo,
            this.tsmiJugador});
            this.tsmiNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNuevo.Image")));
            this.tsmiNuevo.Name = "tsmiNuevo";
            this.tsmiNuevo.Size = new System.Drawing.Size(152, 22);
            this.tsmiNuevo.Text = "Nuevo";
            this.tsmiNuevo.Visible = false;
            // 
            // tsmiCampeonato
            // 
            this.tsmiCampeonato.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCampeonato.Image")));
            this.tsmiCampeonato.Name = "tsmiCampeonato";
            this.tsmiCampeonato.Size = new System.Drawing.Size(152, 22);
            this.tsmiCampeonato.Text = "&Campeonato";
            this.tsmiCampeonato.Visible = false;
            this.tsmiCampeonato.Click += new System.EventHandler(this.tsmiCampeonato_Click);
            // 
            // tsmiEmpleado
            // 
            this.tsmiEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEmpleado.Image")));
            this.tsmiEmpleado.Name = "tsmiEmpleado";
            this.tsmiEmpleado.Size = new System.Drawing.Size(152, 22);
            this.tsmiEmpleado.Text = "&Empleado";
            this.tsmiEmpleado.Visible = false;
            this.tsmiEmpleado.Click += new System.EventHandler(this.tsmiEmpleado_Click);
            // 
            // tsmiEquipo
            // 
            this.tsmiEquipo.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEquipo.Image")));
            this.tsmiEquipo.Name = "tsmiEquipo";
            this.tsmiEquipo.Size = new System.Drawing.Size(152, 22);
            this.tsmiEquipo.Text = "E&quipo";
            this.tsmiEquipo.Visible = false;
            this.tsmiEquipo.Click += new System.EventHandler(this.tsmiEquipo_Click);
            // 
            // tsmiJugador
            // 
            this.tsmiJugador.Image = ((System.Drawing.Image)(resources.GetObject("tsmiJugador.Image")));
            this.tsmiJugador.Name = "tsmiJugador";
            this.tsmiJugador.Size = new System.Drawing.Size(152, 22);
            this.tsmiJugador.Text = "&Jugador";
            this.tsmiJugador.Visible = false;
            this.tsmiJugador.Click += new System.EventHandler(this.tsmiJugador_Click);
            // 
            // tssSeparador1
            // 
            this.tssSeparador1.Name = "tssSeparador1";
            this.tssSeparador1.Size = new System.Drawing.Size(149, 6);
            this.tssSeparador1.Visible = false;
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCerrarSesion.Image")));
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(152, 22);
            this.tsmiCerrarSesion.Text = "&Cerrar Sesión";
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.stmiCerrarSesion_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSalir.Image")));
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(152, 22);
            this.tsmiSalir.Text = "&Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // tsmiCampeonatos
            // 
            this.tsmiCampeonatos.AutoSize = false;
            this.tsmiCampeonatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCalendarios,
            this.tsmiEstadisticas});
            this.tsmiCampeonatos.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCampeonatos.Image")));
            this.tsmiCampeonatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmiCampeonatos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiCampeonatos.Name = "tsmiCampeonatos";
            this.tsmiCampeonatos.Size = new System.Drawing.Size(94, 51);
            this.tsmiCampeonatos.Text = "&Campeonatos";
            this.tsmiCampeonatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiCampeonatos.Visible = false;
            // 
            // tsmiCalendarios
            // 
            this.tsmiCalendarios.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCalendarios.Image")));
            this.tsmiCalendarios.Name = "tsmiCalendarios";
            this.tsmiCalendarios.Size = new System.Drawing.Size(136, 22);
            this.tsmiCalendarios.Text = "&Calendarios";
            this.tsmiCalendarios.Visible = false;
            this.tsmiCalendarios.Click += new System.EventHandler(this.tsmiCalendarios_Click);
            // 
            // tsmiEstadisticas
            // 
            this.tsmiEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEstadisticas.Image")));
            this.tsmiEstadisticas.Name = "tsmiEstadisticas";
            this.tsmiEstadisticas.Size = new System.Drawing.Size(136, 22);
            this.tsmiEstadisticas.Text = "&Estadísticas";
            this.tsmiEstadisticas.Visible = false;
            this.tsmiEstadisticas.Click += new System.EventHandler(this.tsmiEstadisticas_Click);
            // 
            // tsmiAdministracion
            // 
            this.tsmiAdministracion.AutoSize = false;
            this.tsmiAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmpleados,
            this.tsmiJugadores});
            this.tsmiAdministracion.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAdministracion.Image")));
            this.tsmiAdministracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmiAdministracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAdministracion.Name = "tsmiAdministracion";
            this.tsmiAdministracion.Size = new System.Drawing.Size(94, 51);
            this.tsmiAdministracion.Text = "A&dministración";
            this.tsmiAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiAdministracion.Visible = false;
            // 
            // tsmiEmpleados
            // 
            this.tsmiEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEmpleados.Image")));
            this.tsmiEmpleados.Name = "tsmiEmpleados";
            this.tsmiEmpleados.Size = new System.Drawing.Size(132, 22);
            this.tsmiEmpleados.Text = "&Empleados";
            this.tsmiEmpleados.Visible = false;
            this.tsmiEmpleados.Click += new System.EventHandler(this.tsmiEmpleados_Click);
            // 
            // tsmiJugadores
            // 
            this.tsmiJugadores.Image = ((System.Drawing.Image)(resources.GetObject("tsmiJugadores.Image")));
            this.tsmiJugadores.Name = "tsmiJugadores";
            this.tsmiJugadores.Size = new System.Drawing.Size(132, 22);
            this.tsmiJugadores.Text = "&Jugadores";
            this.tsmiJugadores.Visible = false;
            this.tsmiJugadores.Click += new System.EventHandler(this.tsmiJugadores_Click);
            // 
            // tsmiControl
            // 
            this.tsmiControl.AutoSize = false;
            this.tsmiControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCanchas,
            this.tsmiTipoEmpleados,
            this.tsmiUsuarios,
            this.tsmiVisorEventos});
            this.tsmiControl.Image = ((System.Drawing.Image)(resources.GetObject("tsmiControl.Image")));
            this.tsmiControl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmiControl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiControl.Name = "tsmiControl";
            this.tsmiControl.Size = new System.Drawing.Size(94, 51);
            this.tsmiControl.Text = "Co&ntrol";
            this.tsmiControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiControl.Visible = false;
            // 
            // tsmiCanchas
            // 
            this.tsmiCanchas.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCanchas.Image")));
            this.tsmiCanchas.Name = "tsmiCanchas";
            this.tsmiCanchas.Size = new System.Drawing.Size(175, 22);
            this.tsmiCanchas.Text = "&Canchas";
            this.tsmiCanchas.Visible = false;
            this.tsmiCanchas.Click += new System.EventHandler(this.tsmiCanchas_Click);
            // 
            // tsmiTipoEmpleados
            // 
            this.tsmiTipoEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("tsmiTipoEmpleados.Image")));
            this.tsmiTipoEmpleados.Name = "tsmiTipoEmpleados";
            this.tsmiTipoEmpleados.Size = new System.Drawing.Size(175, 22);
            this.tsmiTipoEmpleados.Text = "&Tipo de Empleados";
            this.tsmiTipoEmpleados.Visible = false;
            this.tsmiTipoEmpleados.Click += new System.EventHandler(this.tsmiTipoEmpleados_Click);
            // 
            // tsmiUsuarios
            // 
            this.tsmiUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUsuarios.Image")));
            this.tsmiUsuarios.Name = "tsmiUsuarios";
            this.tsmiUsuarios.Size = new System.Drawing.Size(175, 22);
            this.tsmiUsuarios.Text = "&Usuarios";
            this.tsmiUsuarios.Visible = false;
            this.tsmiUsuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // tsmiVisorEventos
            // 
            this.tsmiVisorEventos.Image = ((System.Drawing.Image)(resources.GetObject("tsmiVisorEventos.Image")));
            this.tsmiVisorEventos.Name = "tsmiVisorEventos";
            this.tsmiVisorEventos.Size = new System.Drawing.Size(175, 22);
            this.tsmiVisorEventos.Text = "&Visor de Eventos";
            this.tsmiVisorEventos.Visible = false;
            this.tsmiVisorEventos.Click += new System.EventHandler(this.visorDeEventosToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.AutoSize = false;
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Image = ((System.Drawing.Image)(resources.GetObject("windowsMenu.Image")));
            this.windowsMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.windowsMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(94, 51);
            this.windowsMenu.Text = "&Ventanas";
            this.windowsMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cascadeToolStripMenuItem.Image")));
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tileVerticalToolStripMenuItem.Image")));
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tileHorizontalToolStripMenuItem.Image")));
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeAllToolStripMenuItem.Image")));
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.closeAllToolStripMenuItem.Text = "C&errar Todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.AutoSize = false;
            this.tsmiAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVerAyuda,
            this.tssSeparador2,
            this.tsmiAcercaDe});
            this.tsmiAyuda.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAyuda.Image")));
            this.tsmiAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmiAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(94, 51);
            this.tsmiAyuda.Text = "Ay&uda";
            this.tsmiAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmiVerAyuda
            // 
            this.tsmiVerAyuda.Image = ((System.Drawing.Image)(resources.GetObject("tsmiVerAyuda.Image")));
            this.tsmiVerAyuda.Name = "tsmiVerAyuda";
            this.tsmiVerAyuda.Size = new System.Drawing.Size(222, 22);
            this.tsmiVerAyuda.Text = "&Ver la Ayuda";
            this.tsmiVerAyuda.Click += new System.EventHandler(this.tsmiManualUsuario_Click);
            // 
            // tssSeparador2
            // 
            this.tssSeparador2.Name = "tssSeparador2";
            this.tssSeparador2.Size = new System.Drawing.Size(219, 6);
            // 
            // tsmiAcercaDe
            // 
            this.tsmiAcercaDe.Name = "tsmiAcercaDe";
            this.tsmiAcercaDe.Size = new System.Drawing.Size(222, 22);
            this.tsmiAcercaDe.Text = "&Acerca de Football Manager";
            this.tsmiAcercaDe.Click += new System.EventHandler(this.tsmiAcercaDe_Click);
            // 
            // ssBarraEstado
            // 
            this.ssBarraEstado.AutoSize = false;
            this.ssBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslEstado});
            this.ssBarraEstado.Location = new System.Drawing.Point(0, 542);
            this.ssBarraEstado.Name = "ssBarraEstado";
            this.ssBarraEstado.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ssBarraEstado.Size = new System.Drawing.Size(794, 30);
            this.ssBarraEstado.SizingGrip = false;
            this.ssBarraEstado.TabIndex = 2;
            this.ssBarraEstado.Text = "StatusStrip";
            // 
            // tsslEstado
            // 
            this.tsslEstado.Name = "tsslEstado";
            this.tsslEstado.Size = new System.Drawing.Size(42, 25);
            this.tsslEstado.Text = "Estado";
            // 
            // hpAyuda
            // 
            this.hpAyuda.HelpNamespace = "C:\\Ayuda\\Help.chm";
            // 
            // wfMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.ssBarraEstado);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "wfMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football Manager - Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wfMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.wfMenuPrincipal_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ssBarraEstado.ResumeLayout(false);
            this.ssBarraEstado.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion


        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.StatusStrip ssBarraEstado;
        private System.Windows.Forms.ToolStripMenuItem tsmiAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolTip ttTool1;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerAyuda;
        private System.Windows.Forms.ToolStripSeparator tssSeparador2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.HelpProvider hpAyuda;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiVisorEventos;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiUsuarios;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiTipoEmpleados;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiCanchas;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiAdministracion;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiCampeonatos;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiCalendarios;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiEstadisticas;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiNuevo;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiCampeonato;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiControl;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiEmpleados;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiJugadores;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiEmpleado;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiJugador;
        protected internal System.Windows.Forms.ToolStripMenuItem tsmiEquipo;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        protected internal System.Windows.Forms.ToolStripSeparator tssSeparador1;
        private System.Windows.Forms.ToolStripStatusLabel tsslEstado;
    }
}



