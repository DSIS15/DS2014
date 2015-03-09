/* Autor: Jeniffer Lopez
 * Categoriza los distintos empleados que existen 
 * Fecha: 06/08/2014 - Comentario: Diseño y Programación de wfTipoEmpleados
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
    public partial class wfTipoEmpleado : Form
    {
        string gsQuery;
        int giFlag;
        public wfTipoEmpleado()
        {
            InitializeComponent();
        }

        private void wfTipoEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoTipoEmpleados' Puede moverla o quitarla según sea necesario.
            this.dsListadoTipoEmpleadosTA.Fill(this.dsDatosBD.dsListadoTipoEmpleados);
            this.Height = 116;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            pnlTipoEmpleado.Visible = true;
            txtNuevoTE.Text = "";
            txtNuevoTE.Focus();
            this.Height = 194;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            giFlag = 1;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cboTERegis.SelectedValue = Convert.ToInt32(dsDatosBD.dsListadoTipoEmpleados.Rows[cboTERegis.SelectedIndex]["cod_temp"].ToString());
            txtNuevoTE.Text = dsDatosBD.dsListadoTipoEmpleados.Rows[cboTERegis.SelectedIndex]["tipo_temp"].ToString();
            pnlTipoEmpleado.Visible = true;
            txtNuevoTE.Focus();
            this.Height = 194;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Football Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gsQuery = "update tabm_tipoemp set activo_temp=0 where cod_temp=" + cboTERegis.SelectedValue;
                if (DLL_Football_Manager.csFunciones.Eliminar(gsQuery, "tabm_tipoemp") == 1)
                {
                    this.dsListadoTipoEmpleadosTA.Fill(this.dsDatosBD.dsListadoTipoEmpleados);
                    MessageBox.Show("Registro eliminado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.cboTERegis.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNuevoTE.Text != "")
            {
                int iCodigo = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_temp", "tabm_tipoemp");
                if (giFlag == 0)
                {
                    gsQuery = "insert into tabm_tipoemp values (" + iCodigo + ",'" + txtNuevoTE.Text + "',1)";
                    if (DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabm_tipoemp") == 1)
                    {
                        btnNuevo.Enabled = true;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        this.Height = 116;
                        this.dsListadoTipoEmpleadosTA.Fill(this.dsDatosBD.dsListadoTipoEmpleados);
                        MessageBox.Show("Registro guardado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    gsQuery = "update tabm_tipoemp set tipo_temp='" + txtNuevoTE.Text + "' where cod_temp=" + cboTERegis.SelectedValue;
                    int iResp = DLL_Football_Manager.csFunciones.Insertar(gsQuery,"tabm_tipoemp");
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    this.Height = 116;
                    this.dsListadoTipoEmpleadosTA.Fill(this.dsDatosBD.dsListadoTipoEmpleados);
                    MessageBox.Show("Registro actualizado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboTERegis.SelectedIndex = -1;
            txtNuevoTE.Text = "";
            txtNuevoTE.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            pnlTipoEmpleado.Visible = false;
            txtNuevoTE.Text = "";
            cboTERegis.Focus();
            this.Height = 116;
        }
    }
}
