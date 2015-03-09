namespace Gestor_de_Usuarios
{
    partial class FrmAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministracion));
            this.tctAdministracion = new System.Windows.Forms.TabControl();
            this.tpgUsuarios = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblNumeroAct = new System.Windows.Forms.Label();
            this.lblNumeroUser = new System.Windows.Forms.Label();
            this.lblNumeroNorm = new System.Windows.Forms.Label();
            this.lblNumeroAdm = new System.Windows.Forms.Label();
            this.lblNormales = new System.Windows.Forms.Label();
            this.lblActivos = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pnlMenuUsuario = new System.Windows.Forms.Panel();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txbBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificarUser = new System.Windows.Forms.Button();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.tpgEstadisticas = new System.Windows.Forms.TabPage();
            this.tpgBitacora = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.tpgSesiones = new System.Windows.Forms.TabPage();
            this.tpgAreas = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tctAdministracion.SuspendLayout();
            this.tpgUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlMenuUsuario.SuspendLayout();
            this.tpgBitacora.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpgAreas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tctAdministracion
            // 
            this.tctAdministracion.Controls.Add(this.tpgUsuarios);
            this.tctAdministracion.Controls.Add(this.tpgEstadisticas);
            this.tctAdministracion.Controls.Add(this.tpgBitacora);
            this.tctAdministracion.Controls.Add(this.tpgSesiones);
            this.tctAdministracion.Controls.Add(this.tpgAreas);
            this.tctAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctAdministracion.Location = new System.Drawing.Point(2, 58);
            this.tctAdministracion.Name = "tctAdministracion";
            this.tctAdministracion.SelectedIndex = 0;
            this.tctAdministracion.Size = new System.Drawing.Size(789, 510);
            this.tctAdministracion.TabIndex = 1;
            // 
            // tpgUsuarios
            // 
            this.tpgUsuarios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgUsuarios.Controls.Add(this.label12);
            this.tpgUsuarios.Controls.Add(this.splitContainer1);
            this.tpgUsuarios.Controls.Add(this.dgvUsuarios);
            this.tpgUsuarios.Controls.Add(this.pnlMenuUsuario);
            this.tpgUsuarios.Location = new System.Drawing.Point(4, 25);
            this.tpgUsuarios.Name = "tpgUsuarios";
            this.tpgUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpgUsuarios.Size = new System.Drawing.Size(781, 481);
            this.tpgUsuarios.TabIndex = 0;
            this.tpgUsuarios.Text = "Usuarios";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(295, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(285, 73);
            this.label12.TabIndex = 7;
            this.label12.Text = "Usuarios";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 354);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblNumeroAct);
            this.splitContainer1.Panel1.Controls.Add(this.lblNumeroUser);
            this.splitContainer1.Panel1.Controls.Add(this.lblNumeroNorm);
            this.splitContainer1.Panel1.Controls.Add(this.lblNumeroAdm);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.lblNormales);
            this.splitContainer1.Panel2.Controls.Add(this.lblActivos);
            this.splitContainer1.Panel2.Controls.Add(this.lblAdmin);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotal);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Size = new System.Drawing.Size(242, 114);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 4;
            // 
            // lblNumeroAct
            // 
            this.lblNumeroAct.AutoSize = true;
            this.lblNumeroAct.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNumeroAct.Location = new System.Drawing.Point(5, 93);
            this.lblNumeroAct.Name = "lblNumeroAct";
            this.lblNumeroAct.Size = new System.Drawing.Size(129, 15);
            this.lblNumeroAct.TabIndex = 4;
            this.lblNumeroAct.Text = "Núm. Usuarios Activos";
            // 
            // lblNumeroUser
            // 
            this.lblNumeroUser.AutoSize = true;
            this.lblNumeroUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNumeroUser.Location = new System.Drawing.Point(7, 12);
            this.lblNumeroUser.Name = "lblNumeroUser";
            this.lblNumeroUser.Size = new System.Drawing.Size(97, 15);
            this.lblNumeroUser.TabIndex = 0;
            this.lblNumeroUser.Text = "Total de Usuario";
            // 
            // lblNumeroNorm
            // 
            this.lblNumeroNorm.AutoSize = true;
            this.lblNumeroNorm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNumeroNorm.Location = new System.Drawing.Point(7, 69);
            this.lblNumeroNorm.Name = "lblNumeroNorm";
            this.lblNumeroNorm.Size = new System.Drawing.Size(123, 15);
            this.lblNumeroNorm.TabIndex = 3;
            this.lblNumeroNorm.Text = "Núm. Usuarios Norm";
            // 
            // lblNumeroAdm
            // 
            this.lblNumeroAdm.AutoSize = true;
            this.lblNumeroAdm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNumeroAdm.Location = new System.Drawing.Point(7, 41);
            this.lblNumeroAdm.Name = "lblNumeroAdm";
            this.lblNumeroAdm.Size = new System.Drawing.Size(127, 15);
            this.lblNumeroAdm.TabIndex = 2;
            this.lblNumeroAdm.Text = "Num. Usuarios Admin";
            // 
            // lblNormales
            // 
            this.lblNormales.AutoSize = true;
            this.lblNormales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormales.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNormales.Location = new System.Drawing.Point(4, 69);
            this.lblNormales.Name = "lblNormales";
            this.lblNormales.Size = new System.Drawing.Size(41, 15);
            this.lblNormales.TabIndex = 2;
            this.lblNormales.Text = "label3";
            // 
            // lblActivos
            // 
            this.lblActivos.AutoSize = true;
            this.lblActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblActivos.Location = new System.Drawing.Point(4, 93);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(41, 15);
            this.lblActivos.TabIndex = 3;
            this.lblActivos.Text = "label3";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAdmin.Location = new System.Drawing.Point(4, 40);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(41, 15);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "label3";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotal.Location = new System.Drawing.Point(4, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(6, 6);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(574, 322);
            this.dgvUsuarios.TabIndex = 2;
            // 
            // pnlMenuUsuario
            // 
            this.pnlMenuUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenuUsuario.Controls.Add(this.btnBuscarUsuario);
            this.pnlMenuUsuario.Controls.Add(this.txbBuscarUsuario);
            this.pnlMenuUsuario.Controls.Add(this.btnActualizar);
            this.pnlMenuUsuario.Controls.Add(this.btnEliminar);
            this.pnlMenuUsuario.Controls.Add(this.btnModificarUser);
            this.pnlMenuUsuario.Controls.Add(this.btnAgregarUser);
            this.pnlMenuUsuario.ForeColor = System.Drawing.Color.Crimson;
            this.pnlMenuUsuario.Location = new System.Drawing.Point(586, 0);
            this.pnlMenuUsuario.Name = "pnlMenuUsuario";
            this.pnlMenuUsuario.Size = new System.Drawing.Size(199, 490);
            this.pnlMenuUsuario.TabIndex = 3;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuario.Image")));
            this.btnBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(3, 268);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(192, 40);
            this.btnBuscarUsuario.TabIndex = 5;
            this.btnBuscarUsuario.Text = "  Buscar Usuario";
            this.btnBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txbBuscarUsuario
            // 
            this.txbBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarUsuario.Location = new System.Drawing.Point(14, 248);
            this.txbBuscarUsuario.Name = "txbBuscarUsuario";
            this.txbBuscarUsuario.Size = new System.Drawing.Size(174, 24);
            this.txbBuscarUsuario.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(0, 440);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(200, 41);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar  ";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Image = global::Gestor_de_Usuarios.Properties.Resources._1407481755_circle_cross1;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(3, 100);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "  Eliminar Usuario";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificarUser
            // 
            this.btnModificarUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificarUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificarUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarUser.Image = global::Gestor_de_Usuarios.Properties.Resources._1407482248_cog1;
            this.btnModificarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUser.Location = new System.Drawing.Point(4, 146);
            this.btnModificarUser.Name = "btnModificarUser";
            this.btnModificarUser.Size = new System.Drawing.Size(192, 40);
            this.btnModificarUser.TabIndex = 1;
            this.btnModificarUser.Text = "  Modificar Usuario";
            this.btnModificarUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarUser.UseVisualStyleBackColor = false;
            this.btnModificarUser.Click += new System.EventHandler(this.btnModificarUser_Click);
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarUser.Image = global::Gestor_de_Usuarios.Properties.Resources._1407480710_circle_add1;
            this.btnAgregarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUser.Location = new System.Drawing.Point(3, 54);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(192, 40);
            this.btnAgregarUser.TabIndex = 0;
            this.btnAgregarUser.Text = "  Agregar Usuario ";
            this.btnAgregarUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarUser.UseVisualStyleBackColor = false;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // tpgEstadisticas
            // 
            this.tpgEstadisticas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgEstadisticas.Location = new System.Drawing.Point(4, 25);
            this.tpgEstadisticas.Name = "tpgEstadisticas";
            this.tpgEstadisticas.Size = new System.Drawing.Size(781, 481);
            this.tpgEstadisticas.TabIndex = 4;
            this.tpgEstadisticas.Text = "Informes y Estadisticas";
            // 
            // tpgBitacora
            // 
            this.tpgBitacora.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgBitacora.Controls.Add(this.label1);
            this.tpgBitacora.Controls.Add(this.panel2);
            this.tpgBitacora.Location = new System.Drawing.Point(4, 25);
            this.tpgBitacora.Name = "tpgBitacora";
            this.tpgBitacora.Size = new System.Drawing.Size(781, 481);
            this.tpgBitacora.TabIndex = 2;
            this.tpgBitacora.Text = "Registro de Actividades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(205, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 73);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bitacora";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button11);
            this.panel2.ForeColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 490);
            this.panel2.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 268);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 40);
            this.button7.TabIndex = 5;
            this.button7.Text = "  Buscar";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(14, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 24);
            this.textBox2.TabIndex = 4;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(3, 100);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(192, 40);
            this.button9.TabIndex = 2;
            this.button9.Text = "  Semana ";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(4, 146);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(192, 40);
            this.button10.TabIndex = 1;
            this.button10.Text = "  Mes";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button11.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(3, 54);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(192, 40);
            this.button11.TabIndex = 0;
            this.button11.Text = "  Hoy";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // tpgSesiones
            // 
            this.tpgSesiones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgSesiones.Location = new System.Drawing.Point(4, 25);
            this.tpgSesiones.Name = "tpgSesiones";
            this.tpgSesiones.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSesiones.Size = new System.Drawing.Size(781, 481);
            this.tpgSesiones.TabIndex = 1;
            this.tpgSesiones.Text = "Sesiones";
            // 
            // tpgAreas
            // 
            this.tpgAreas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpgAreas.Controls.Add(this.label11);
            this.tpgAreas.Controls.Add(this.splitContainer2);
            this.tpgAreas.Controls.Add(this.panel1);
            this.tpgAreas.Controls.Add(this.dataGridView1);
            this.tpgAreas.Location = new System.Drawing.Point(4, 25);
            this.tpgAreas.Name = "tpgAreas";
            this.tpgAreas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tpgAreas.Size = new System.Drawing.Size(781, 481);
            this.tpgAreas.TabIndex = 5;
            this.tpgAreas.Text = "Areas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(380, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 73);
            this.label11.TabIndex = 6;
            this.label11.Text = "Areas";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(6, 357);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(242, 114);
            this.splitContainer2.SplitterDistance = 137;
            this.splitContainer2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de Areas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(4, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "label3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(4, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "label3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(4, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "label3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(4, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "label3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.ForeColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(586, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 483);
            this.panel1.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(3, 260);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "  Buscar Usuario";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 24);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(-1, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Actualizar  ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::Gestor_de_Usuarios.Properties.Resources._1407481755_circle_cross1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(3, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "  Eliminar Area";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::Gestor_de_Usuarios.Properties.Resources._1407482248_cog1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(4, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "  Modificar Area";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Image = global::Gestor_de_Usuarios.Properties.Resources._1407480710_circle_add1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(3, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "  Agregar Area";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 293);
            this.dataGridView1.TabIndex = 3;
            // 
            // FrmAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.tctAdministracion);
            this.Name = "FrmAdministracion";
            this.Text = "Administración";
            this.tctAdministracion.ResumeLayout(false);
            this.tpgUsuarios.ResumeLayout(false);
            this.tpgUsuarios.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlMenuUsuario.ResumeLayout(false);
            this.pnlMenuUsuario.PerformLayout();
            this.tpgBitacora.ResumeLayout(false);
            this.tpgBitacora.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpgAreas.ResumeLayout(false);
            this.tpgAreas.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctAdministracion;
        private System.Windows.Forms.TabPage tpgUsuarios;
        private System.Windows.Forms.TabPage tpgSesiones;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel pnlMenuUsuario;
        private System.Windows.Forms.Button btnAgregarUser;
        private System.Windows.Forms.TabPage tpgEstadisticas;
        private System.Windows.Forms.TabPage tpgAreas;
        private System.Windows.Forms.Button btnModificarUser;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeroUser;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Label lblNormales;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNumeroAct;
        private System.Windows.Forms.Label lblNumeroNorm;
        private System.Windows.Forms.Label lblNumeroAdm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbBuscarUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tpgBitacora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

