/* Autor: Anthony Molineros
 * Creacion de nuevos usuarios para el sistema de footballmanager
 * Fecha: 10/08/2014 - Comentario: Diseño y Programación de wfVisorEventos
 * Fecha: 03/08/2014 - Comentario: Configuración de dgvVisorEventos y preparación para interacción con BD
*/
namespace Football_Manager
{
    partial class wfUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfUsuarios));
            this.lblRegistrados = new System.Windows.Forms.Label();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.ttTool1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.dsListadoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD = new Football_Manager.dsDatosBD();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasena = new System.Windows.Forms.Label();
            this.pnlPanel1 = new System.Windows.Forms.Panel();
            this.lblNivel = new System.Windows.Forms.Label();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.dsListadoNivelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.dsListadoEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListadoEmpleadosTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoEmpleadosTA();
            this.dsListadoNivelesTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoNivelesTA();
            this.dsListadoUsuariosTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoUsuariosTA();
            this.dsListadoEmpleados2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsListadoEmpleados2 = new Football_Manager.dsDatosBDTableAdapters.dsListadoEmpleados2();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).BeginInit();
            this.pnlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoNivelesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoEmpleados2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistrados
            // 
            this.lblRegistrados.AutoSize = true;
            this.lblRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrados.Location = new System.Drawing.Point(12, 15);
            this.lblRegistrados.Name = "lblRegistrados";
            this.lblRegistrados.Size = new System.Drawing.Size(125, 15);
            this.lblRegistrados.TabIndex = 1;
            this.lblRegistrados.Text = "Usuarios Registrados";
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoUsuario.Image")));
            this.btnNuevoUsuario.Location = new System.Drawing.Point(151, 41);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(44, 36);
            this.btnNuevoUsuario.TabIndex = 1;
            this.ttTool1.SetToolTip(this.btnNuevoUsuario, "Nuevo usuario");
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(251, 41);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(44, 36);
            this.btnEliminar.TabIndex = 3;
            this.ttTool1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(149, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(44, 36);
            this.btnGuardar.TabIndex = 9;
            this.ttTool1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(249, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(44, 36);
            this.btnCancelar.TabIndex = 11;
            this.ttTool1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(143, 88);
            this.txtContrasena.MaxLength = 10;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(150, 21);
            this.txtContrasena.TabIndex = 7;
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(10, 91);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(70, 15);
            this.lblContrasena.TabIndex = 18;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(143, 61);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(150, 21);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(10, 64);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 15);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "Usuario ";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(201, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(44, 36);
            this.btnModificar.TabIndex = 2;
            this.ttTool1.SetToolTip(this.btnModificar, "Modificar");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(199, 142);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 10;
            this.ttTool1.SetToolTip(this.btnLimpiar, "Limpiar");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DataSource = this.dsListadoUsuariosBindingSource;
            this.cboUsuarios.DisplayMember = "usuario_usr";
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(145, 12);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(150, 23);
            this.cboUsuarios.TabIndex = 0;
            this.cboUsuarios.ValueMember = "cod_usr";
            // 
            // dsListadoUsuariosBindingSource
            // 
            this.dsListadoUsuariosBindingSource.DataMember = "dsListadoUsuarios";
            this.dsListadoUsuariosBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsDatosBD
            // 
            this.dsDatosBD.DataSetName = "dsDatosBD";
            this.dsDatosBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(143, 115);
            this.txtConfirmarContrasena.MaxLength = 10;
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.PasswordChar = '*';
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(150, 21);
            this.txtConfirmarContrasena.TabIndex = 8;
            this.txtConfirmarContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarContrasena_KeyPress);
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.AutoSize = true;
            this.lblConfirmarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(10, 118);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(127, 15);
            this.lblConfirmarContrasena.TabIndex = 23;
            this.lblConfirmarContrasena.Text = "Confirmar Contraseña";
            // 
            // pnlPanel1
            // 
            this.pnlPanel1.Controls.Add(this.btnLimpiar);
            this.pnlPanel1.Controls.Add(this.lblNivel);
            this.pnlPanel1.Controls.Add(this.cboNivel);
            this.pnlPanel1.Controls.Add(this.lblEmpleado);
            this.pnlPanel1.Controls.Add(this.cboEmpleado);
            this.pnlPanel1.Controls.Add(this.lblUsuario);
            this.pnlPanel1.Controls.Add(this.txtConfirmarContrasena);
            this.pnlPanel1.Controls.Add(this.txtUsuario);
            this.pnlPanel1.Controls.Add(this.lblConfirmarContrasena);
            this.pnlPanel1.Controls.Add(this.lblContrasena);
            this.pnlPanel1.Controls.Add(this.txtContrasena);
            this.pnlPanel1.Controls.Add(this.btnCancelar);
            this.pnlPanel1.Controls.Add(this.btnGuardar);
            this.pnlPanel1.Location = new System.Drawing.Point(2, 83);
            this.pnlPanel1.Name = "pnlPanel1";
            this.pnlPanel1.Size = new System.Drawing.Size(299, 181);
            this.pnlPanel1.TabIndex = 24;
            this.pnlPanel1.Visible = false;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(10, 35);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(34, 15);
            this.lblNivel.TabIndex = 27;
            this.lblNivel.Text = "Nivel";
            // 
            // cboNivel
            // 
            this.cboNivel.DataSource = this.dsListadoNivelesBindingSource;
            this.cboNivel.DisplayMember = "nivel_nvl";
            this.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Location = new System.Drawing.Point(143, 32);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(150, 23);
            this.cboNivel.TabIndex = 5;
            this.cboNivel.ValueMember = "cod_nvl";
            // 
            // dsListadoNivelesBindingSource
            // 
            this.dsListadoNivelesBindingSource.DataMember = "dsListadoNiveles";
            this.dsListadoNivelesBindingSource.DataSource = this.dsDatosBD;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(10, 6);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(64, 15);
            this.lblEmpleado.TabIndex = 25;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.DataSource = this.dsListadoEmpleados2BindingSource;
            this.cboEmpleado.DisplayMember = "Expr1";
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(143, 3);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(150, 23);
            this.cboEmpleado.TabIndex = 4;
            this.cboEmpleado.ValueMember = "cod_emp";
            // 
            // dsListadoEmpleadosBindingSource
            // 
            this.dsListadoEmpleadosBindingSource.DataMember = "dsListadoEmpleados";
            this.dsListadoEmpleadosBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsListadoEmpleadosTA
            // 
            this.dsListadoEmpleadosTA.ClearBeforeFill = true;
            // 
            // dsListadoNivelesTA
            // 
            this.dsListadoNivelesTA.ClearBeforeFill = true;
            // 
            // dsListadoUsuariosTA
            // 
            this.dsListadoUsuariosTA.ClearBeforeFill = true;
            // 
            // dsListadoEmpleados2BindingSource
            // 
            this.dsListadoEmpleados2BindingSource.DataMember = "dsListadoEmpleados2";
            this.dsListadoEmpleados2BindingSource.DataSource = this.dsDatosBD;
            // 
            // dsListadoEmpleados2
            // 
            this.dsListadoEmpleados2.ClearBeforeFill = true;
            // 
            // wfUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 271);
            this.Controls.Add(this.pnlPanel1);
            this.Controls.Add(this.cboUsuarios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.lblRegistrados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfUsuarios";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.wfUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).EndInit();
            this.pnlPanel1.ResumeLayout(false);
            this.pnlPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoNivelesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoEmpleados2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrados;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolTip ttTool1;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.Label lblConfirmarContrasena;
        private System.Windows.Forms.Panel pnlPanel1;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Button btnLimpiar;
        private dsDatosBD dsDatosBD;
        private System.Windows.Forms.BindingSource dsListadoEmpleadosBindingSource;
        private dsDatosBDTableAdapters.dsListadoEmpleadosTA dsListadoEmpleadosTA;
        private System.Windows.Forms.BindingSource dsListadoNivelesBindingSource;
        private dsDatosBDTableAdapters.dsListadoNivelesTA dsListadoNivelesTA;
        private System.Windows.Forms.BindingSource dsListadoUsuariosBindingSource;
        private dsDatosBDTableAdapters.dsListadoUsuariosTA dsListadoUsuariosTA;
        private System.Windows.Forms.BindingSource dsListadoEmpleados2BindingSource;
        private dsDatosBDTableAdapters.dsListadoEmpleados2 dsListadoEmpleados2;
    }
}