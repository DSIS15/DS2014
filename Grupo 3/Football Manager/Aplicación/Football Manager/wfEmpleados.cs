/*Autor: Andrea Perez
 * Fecha:"05/julio/2014"
 * Comentario: Reportes de empleados
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
    public partial class wfEmpleados : Form
    {
        string gsQuery;
        int giCodigo, giIndex;

        public wfEmpleados()
        {
            InitializeComponent();
        }

        private void wfEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoEmpleados' Puede moverla o quitarla según sea necesario.
            this.dsListadoEmpleadosTA.Fill(this.dsDatosBD.dsListadoEmpleados);
        }

        private void ObtenerRegSeleccionado()
        {
            foreach (DataGridViewRow row in dgvEmpleados.Rows)
            {
                if (row.Selected == true)
                {
                    giIndex = row.Index;
                    giCodigo = Convert.ToInt32(row.Cells[0].Value.ToString());
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Football Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ObtenerRegSeleccionado();
                gsQuery = "update tabm_empleado set activo_emp=0 where cod_emp=" + giCodigo;
                if (DLL_Football_Manager.csFunciones.Eliminar(gsQuery,"tabm_empleado") == 1)
                {
                    this.dsListadoEmpleadosTA.Fill(this.dsDatosBD.dsListadoEmpleados);
                    MessageBox.Show("Registro eliminado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                this.dgvEmpleados.Focus();
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnRefrescar_Click(this, e);
            }
            else
            {
                DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ,. ");
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObtenerRegSeleccionado();
            wfNuevoEmpleado NuevoEmpleado = new wfNuevoEmpleado();
            NuevoEmpleado.giCodigo = Convert.ToInt32(dsDatosBD.dsListadoEmpleados.Rows[giIndex]["cod_emp"].ToString());
            NuevoEmpleado.txtNombre.Text = dsDatosBD.dsListadoEmpleados.Rows[giIndex]["nom_emp"].ToString();
            NuevoEmpleado.txtApellido.Text = dsDatosBD.dsListadoEmpleados.Rows[giIndex]["apell_emp"].ToString();
            NuevoEmpleado.txtDireccion.Text = dsDatosBD.dsListadoEmpleados.Rows[giIndex]["dire_emp"].ToString();
            NuevoEmpleado.txtTelefono.Text = dsDatosBD.dsListadoEmpleados.Rows[giIndex]["tel_emp"].ToString();
            NuevoEmpleado.cboPerfil.SelectedItem = dsDatosBD.dsListadoEmpleados.Rows[giIndex]["tipo_temp"].ToString();
            NuevoEmpleado.txtSalario.Text = dsDatosBD.dsListadoEmpleados.Rows[giIndex]["salario_emp"].ToString();
            NuevoEmpleado.Text = "Modificar Empleado";
            NuevoEmpleado.ShowDialog();
            this.dsListadoEmpleadosTA.Fill(this.dsDatosBD.dsListadoEmpleados);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            wfNuevoEmpleado NuevoEmpleado = new wfNuevoEmpleado();
            NuevoEmpleado.StartPosition = FormStartPosition.CenterParent;
            NuevoEmpleado.ShowDialog();
            this.dsListadoEmpleadosTA.Fill(this.dsDatosBD.dsListadoEmpleados);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.dsListadoEmpleadosTA.Adapter.SelectCommand.CommandText = "select a.cod_emp, b.tipo_temp, a.nom_emp, a.apell_emp, a.dire_emp, a.tel_emp, a.salario_emp from tabm_empleado a, tabm_tipoemp b where a.cod_temp = b.cod_temp and a.activo_emp = 1 and (b.tipo_temp like '" + txtBuscar.Text + "%' or a.nom_emp like '" + txtBuscar.Text + "%' or a.apell_emp like '" + txtBuscar.Text + "%' or a.dire_emp like '" + txtBuscar.Text + "%' or a.tel_emp like '" + txtBuscar.Text + "%' or a.salario_emp like '" + txtBuscar.Text + "%')";
            this.dsListadoEmpleadosTA.Fill(this.dsDatosBD.dsListadoEmpleados);
        }
    }
}
