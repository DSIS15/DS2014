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
    public partial class wfNiveles : Form
    {
        string gsQuery;
        int giFlag;
        public wfNiveles()
        {
            InitializeComponent();
        }

        private void wfNiveles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoNiveles' Puede moverla o quitarla según sea necesario.
            this.dsListadoNivelesTA.Fill(this.dsDatosBD.dsListadoNiveles);
            this.Height = 116;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            giFlag = 0;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false; 
            pnlNuevoNvl.Visible = true;
            txtRegisNvl.Text = "";
            txtRegisNvl.Focus();
            this.Height = 194;
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            giFlag = 1;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cboNvlRegis.SelectedValue = Convert.ToInt32(dsDatosBD.dsListadoNiveles.Rows[cboNvlRegis.SelectedIndex]["cod_nvl"].ToString());
            txtRegisNvl.Text = dsDatosBD.dsListadoNiveles.Rows[cboNvlRegis.SelectedIndex]["nivel_nvl"].ToString();
            pnlNuevoNvl.Visible = true;
            txtRegisNvl.Focus();
            this.Height = 194;
        }
            
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Football Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gsQuery = "update tabm_nivel set activo_nvl=0 where cod_nvl=" + cboNvlRegis.SelectedValue;
                if (DLL_Football_Manager.csFunciones.Eliminar(gsQuery,"tabm_nivel") == 1)
                {
                    this.dsListadoNivelesTA.Fill(this.dsDatosBD.dsListadoNiveles);
                    MessageBox.Show("Registro eliminado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.cboNvlRegis.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboNvlRegis.SelectedIndex = -1;
            txtRegisNvl.Text = "";
            cboNvlRegis.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            pnlNuevoNvl.Visible = false;
            txtRegisNvl.Text = "";
            cboNvlRegis.Focus();
            this.Height = 116;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRegisNvl.Text != "")
            {
                int iCodigo = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_nvl", "tabm_nivel");
                if (giFlag == 0)
                {
                    gsQuery = "insert into tabm_nivel values (" + iCodigo + ",'" + txtRegisNvl.Text + "',1)";
                    if (DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabm_nivel") == 1)
                    {
                        btnNuevo.Enabled = true;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        this.Height = 116;
                        this.dsListadoNivelesTA.Fill(this.dsDatosBD.dsListadoNiveles);
                        MessageBox.Show("Registro guardado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    gsQuery = "update tabm_nivel set nivel_nvl='" + txtRegisNvl.Text + "' where cod_nvl=" + cboNvlRegis.SelectedValue;
                    int iResp = DLL_Football_Manager.csFunciones.Insertar(gsQuery,"tabm_nivel");
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    this.Height = 116;
                    this.dsListadoNivelesTA.Fill(this.dsDatosBD.dsListadoNiveles);
                    MessageBox.Show("Registro actualizado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtRegisNvl_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        }
    }
}
