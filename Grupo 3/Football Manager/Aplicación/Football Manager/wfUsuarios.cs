/* Autor: Anthony Molineros
 * Creacion de nuevos usuarios para el sistema de footballmanager
 * Fecha: 05/08/2014 - Comentario: Diseño y Programación de wfVisorEventos
 * Fecha: 03/08/2014 - Comentario: Configuración de dgvVisorEventos y preparación para interacción con BD
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
    public partial class wfUsuarios : Form
    {
        string gsQuery;
        int giFlag;

        public wfUsuarios()
        {
            InitializeComponent();
        }

        private void wfUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoEmpleados2' Puede moverla o quitarla según sea necesario.
            this.dsListadoEmpleados2.Fill(this.dsDatosBD.dsListadoEmpleados2);
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoUsuarios' Puede moverla o quitarla según sea necesario.
            this.dsListadoUsuariosTA.Fill(this.dsDatosBD.dsListadoUsuarios);
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoNiveles' Puede moverla o quitarla según sea necesario.
            this.dsListadoNivelesTA.Fill(this.dsDatosBD.dsListadoNiveles);
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoEmpleados' Puede moverla o quitarla según sea necesario.
            this.dsListadoEmpleadosTA.Fill(this.dsDatosBD.dsListadoEmpleados);
            this.Height = 114;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            giFlag = 0;
            pnlPanel1.Visible = true;
            btnNuevoUsuario.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cboEmpleado.SelectedIndex = -1;
            cboNivel.SelectedIndex = -1;
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            txtConfirmarContrasena.Text = "";
            this.Height = 300;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlPanel1.Visible = false;
            btnNuevoUsuario.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            this.Height = 114;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text != "") && (txtContrasena.Text != "") && (txtConfirmarContrasena.Text != "") && (cboEmpleado.SelectedIndex != -1))
            {
                if (string.Compare(txtContrasena.Text, txtConfirmarContrasena.Text) == 0)
                {
                    int iCodigo = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_usr", "tabm_usuario");
                    if (giFlag == 0)
                    {
                        gsQuery = "insert into tabm_usuario values (" + iCodigo + "," + cboNivel.SelectedValue + "," + cboEmpleado.SelectedValue + ",'" + txtUsuario.Text + "','" + txtContrasena.Text + "',1)";
                        if (DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabm_usuari") == 1)
                        {
                            btnNuevoUsuario.Enabled = true;
                            btnModificar.Enabled = true;
                            btnEliminar.Enabled = true;
                            this.dsListadoUsuariosTA.Fill(this.dsDatosBD.dsListadoUsuarios);
                            MessageBox.Show("Registro guardado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Height = 114;
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        gsQuery = "update tabm_usuario set cod_nvl=" + cboNivel.SelectedValue + ", cod_emp=" + cboEmpleado.SelectedValue + ", cod_usr=" + cboUsuarios.SelectedValue + ", usuario_usr='" + txtUsuario.Text + "', contrasena_usr='" + txtContrasena.Text + "' where cod_usr=" + cboUsuarios.SelectedValue;
                        int iResp = DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabm_usuario");
                        btnNuevoUsuario.Enabled = true;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        this.dsListadoUsuariosTA.Fill(this.dsDatosBD.dsListadoUsuarios);
                        MessageBox.Show("Registro guardado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Height = 114;
                    }
                }
                else
                {
                    MessageBox.Show("Error las contraseñas no coinciden", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Text = "";
                    txtConfirmarContrasena.Text = "";
                    txtContrasena.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            giFlag = 1;
            pnlPanel1.Visible = true;
            btnNuevoUsuario.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cboEmpleado.SelectedValue = Convert.ToInt32(dsDatosBD.dsListadoUsuarios.Rows[cboUsuarios.SelectedIndex]["cod_emp"].ToString());
            cboNivel.SelectedValue = Convert.ToInt32(dsDatosBD.dsListadoUsuarios.Rows[cboUsuarios.SelectedIndex]["cod_nvl"].ToString());
            txtUsuario.Text= dsDatosBD.dsListadoUsuarios.Rows[cboUsuarios.SelectedIndex]["usuario_usr"].ToString();
            txtContrasena.Text = dsDatosBD.dsListadoUsuarios.Rows[cboUsuarios.SelectedIndex]["contrasena_usr"].ToString();
            txtConfirmarContrasena.Text = dsDatosBD.dsListadoUsuarios.Rows[cboUsuarios.SelectedIndex]["contrasena_usr"].ToString();
            this.Height = 300;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboEmpleado.SelectedIndex = -1;
            cboNivel.SelectedIndex = -1;
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            txtConfirmarContrasena.Text = "";
            this.cboEmpleado.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Football Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gsQuery = "update tabm_usuario set activo_usr=0 where cod_usr="+cboUsuarios.SelectedValue;
                if (DLL_Football_Manager.csFunciones.Eliminar(gsQuery, "tabm_usuario") == 1)
                {
                    this.dsListadoUsuariosTA.Fill(this.dsDatosBD.dsListadoUsuarios);
                    MessageBox.Show("Registro eliminado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.cboUsuarios.Focus();
            }
        }

        private void txtConfirmarContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnGuardar_Click(this, e);
            }
            else
            {
                DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        }
    }
}
