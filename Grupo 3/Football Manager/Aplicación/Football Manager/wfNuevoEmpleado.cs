/* Autor: Gabriela Maria
 * Crea nuevos empleados para el manejo del software de footballmanager
 * Fecha: 09/08/2014 - Comentario: Diseño y Programación de wfTipoEmpleados
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
    public partial class wfNuevoEmpleado : Form
    {
        public int giCodigo, iPerfil = -1;
        public string gsNombre, gsApellido, gsDireccion, gsTelefono, gsSalario;
        string gsQuery;
        
        public wfNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text != "") && (txtApellido.Text != "") && (txtDireccion.Text != "") && (txtTelefono.Text != "") && (cboPerfil.SelectedIndex != -1) && (txtSalario.Text != ""))
            {
                if (this.Text == "Nuevo Empleado")
                {
                    int iCodigo = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_emp", "tabm_empleado");
                    gsQuery = "insert into tabm_empleado values (" + iCodigo + "," + cboPerfil.SelectedValue + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtSalario.Text + "',1)";
                    if (DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabm_empleado") == 1)
                    {
                        this.dsListadoTipoEmpleadosTA.Fill(this.dsDatosBD.dsListadoTipoEmpleados);
                        MessageBox.Show("Registro guardado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    gsQuery = "update tabm_empleado set nom_emp='" + txtNombre.Text + "', apell_emp='" + txtApellido.Text + "', dire_emp='" + txtDireccion.Text + "', tel_emp=" + txtTelefono.Text + ", cod_temp=" + cboPerfil.SelectedValue + ", salario_emp=" + txtSalario.Text + " where cod_emp=" + giCodigo;
                    int iResp = DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabm_empleado");
                    this.dsListadoTipoEmpleadosTA.Fill(this.dsDatosBD.dsListadoTipoEmpleados);
                    MessageBox.Show("Registro actualizado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtNombre.Focus();
            }  
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cboPerfil.SelectedIndex = -1;
            txtSalario.Text = "";
            this.txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ ");
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ ");
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ., ");
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789");
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_.");
        }

        private void wfNuevoEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoTipoEmpleados' Puede moverla o quitarla según sea necesario.
            this.dsListadoTipoEmpleadosTA.Fill(this.dsDatosBD.dsListadoTipoEmpleados);
            gsNombre = txtNombre.Text;
            gsApellido = txtApellido.Text;
            gsDireccion = txtDireccion.Text;
            gsTelefono = txtTelefono.Text;
            gsSalario = txtSalario.Text;
            iPerfil = Convert.ToInt32(cboPerfil.SelectedValue.ToString());
        }
    }
}
