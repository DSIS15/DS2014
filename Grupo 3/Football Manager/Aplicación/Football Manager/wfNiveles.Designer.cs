/* Autor: Jeniffer Lopez
 * Fecha: 02/08/2014 - Comentario: Diseño y Programación de wfNiveles
 * Fecha: 08/08/2014 - Comentario: Preparación para interacción con BD
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Football_Manager
{
    partial class wfNiveles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfNiveles));
            this.pnlNuevoNvl = new System.Windows.Forms.Panel();
            this.txtRegisNvl = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblRegisNvl = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNvlRegis = new System.Windows.Forms.Label();
            this.cboNvlRegis = new System.Windows.Forms.ComboBox();
            this.dsListadoNivelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosBD = new Football_Manager.dsDatosBD();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.ttToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dsListadoNivelesTA = new Football_Manager.dsDatosBDTableAdapters.dsListadoNivelesTA();
            this.pnlNuevoNvl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoNivelesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNuevoNvl
            // 
            this.pnlNuevoNvl.Controls.Add(this.txtRegisNvl);
            this.pnlNuevoNvl.Controls.Add(this.btnGuardar);
            this.pnlNuevoNvl.Controls.Add(this.btnLimpiar);
            this.pnlNuevoNvl.Controls.Add(this.lblRegisNvl);
            this.pnlNuevoNvl.Controls.Add(this.btnCancelar);
            this.pnlNuevoNvl.Location = new System.Drawing.Point(0, 84);
            this.pnlNuevoNvl.Name = "pnlNuevoNvl";
            this.pnlNuevoNvl.Size = new System.Drawing.Size(262, 76);
            this.pnlNuevoNvl.TabIndex = 36;
            this.pnlNuevoNvl.Visible = false;
            // 
            // txtRegisNvl
            // 
            this.txtRegisNvl.Location = new System.Drawing.Point(101, 8);
            this.txtRegisNvl.MaxLength = 25;
            this.txtRegisNvl.Name = "txtRegisNvl";
            this.txtRegisNvl.Size = new System.Drawing.Size(150, 21);
            this.txtRegisNvl.TabIndex = 4;
            this.txtRegisNvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegisNvl_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(107, 34);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(44, 36);
            this.btnGuardar.TabIndex = 5;
            this.ttToolTip1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(157, 34);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(44, 36);
            this.btnLimpiar.TabIndex = 6;
            this.ttToolTip1.SetToolTip(this.btnLimpiar, "Limpiar");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblRegisNvl
            // 
            this.lblRegisNvl.AutoSize = true;
            this.lblRegisNvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisNvl.Location = new System.Drawing.Point(10, 11);
            this.lblRegisNvl.Name = "lblRegisNvl";
            this.lblRegisNvl.Size = new System.Drawing.Size(85, 15);
            this.lblRegisNvl.TabIndex = 25;
            this.lblRegisNvl.Text = "Registrar nivel";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(207, 34);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(44, 36);
            this.btnCancelar.TabIndex = 7;
            this.ttToolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(107, 41);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(44, 36);
            this.btnNuevo.TabIndex = 3;
            this.ttToolTip1.SetToolTip(this.btnNuevo, "Nuevo");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(157, 41);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(44, 36);
            this.btnModificar.TabIndex = 1;
            this.ttToolTip1.SetToolTip(this.btnModificar, "Modificar");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNvlRegis
            // 
            this.lblNvlRegis.AutoSize = true;
            this.lblNvlRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNvlRegis.Location = new System.Drawing.Point(10, 15);
            this.lblNvlRegis.Name = "lblNvlRegis";
            this.lblNvlRegis.Size = new System.Drawing.Size(47, 15);
            this.lblNvlRegis.TabIndex = 38;
            this.lblNvlRegis.Text = "Niveles";
            // 
            // cboNvlRegis
            // 
            this.cboNvlRegis.DataSource = this.dsListadoNivelesBindingSource;
            this.cboNvlRegis.DisplayMember = "nivel_nvl";
            this.cboNvlRegis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNvlRegis.FormattingEnabled = true;
            this.cboNvlRegis.Location = new System.Drawing.Point(101, 12);
            this.cboNvlRegis.Name = "cboNvlRegis";
            this.cboNvlRegis.Size = new System.Drawing.Size(150, 23);
            this.cboNvlRegis.TabIndex = 0;
            this.cboNvlRegis.ValueMember = "cod_nvl";
            // 
            // dsListadoNivelesBindingSource
            // 
            this.dsListadoNivelesBindingSource.DataMember = "dsListadoNiveles";
            this.dsListadoNivelesBindingSource.DataSource = this.dsDatosBD;
            // 
            // dsDatosBD
            // 
            this.dsDatosBD.DataSetName = "dsDatosBD";
            this.dsDatosBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(207, 41);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(44, 36);
            this.btnEliminar.TabIndex = 2;
            this.ttToolTip1.SetToolTip(this.btnEliminar, "Eliminar");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dsListadoNivelesTA
            // 
            this.dsListadoNivelesTA.ClearBeforeFill = true;
            // 
            // wfNiveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 161);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlNuevoNvl);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cboNvlRegis);
            this.Controls.Add(this.lblNvlRegis);
            this.Controls.Add(this.btnEliminar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfNiveles";
            this.Text = "Administrar Niveles";
            this.Load += new System.EventHandler(this.wfNiveles_Load);
            this.pnlNuevoNvl.ResumeLayout(false);
            this.pnlNuevoNvl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoNivelesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNuevoNvl;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblRegisNvl;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNvlRegis;
        private System.Windows.Forms.ComboBox cboNvlRegis;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRegisNvl;
        private ToolTip ttToolTip1;
        private dsDatosBD dsDatosBD;
        private BindingSource dsListadoNivelesBindingSource;
        private dsDatosBDTableAdapters.dsListadoNivelesTA dsListadoNivelesTA;
    }
}