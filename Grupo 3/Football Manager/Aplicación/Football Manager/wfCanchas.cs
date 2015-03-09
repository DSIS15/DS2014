/* Autor: Kevin Gutierrez
 * Fecha: 02/08/2014
 * Comentario: Lleva el control de canchas ingresadas en el software
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
    public partial class wfCanchas : Form
    {
        int giFlag;
        string gsQuery;
        public wfCanchas()
        {
            InitializeComponent();
        }

        private void wfCancha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatosBD.dsListadoCanchas' Puede moverla o quitarla según sea necesario.
            this.dsListadoCanchasTA.Fill(this.dsDatosBD.dsListadoCanchas);
            this.Height = 114;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            giFlag = 0;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            pnlCancha.Visible = true;
            txtNuevaCancha.Text = "";
            txtNuevaCancha.Focus();
            this.Height = 190;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            giFlag = 1;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cboCancha.SelectedValue = Convert.ToInt32(dsDatosBD.dsListadoCanchas.Rows[cboCancha.SelectedIndex]["cod_cha"].ToString());
            txtNuevaCancha.Text = dsDatosBD.dsListadoCanchas.Rows[cboCancha.SelectedIndex]["nom_cha"].ToString();
            pnlCancha.Visible = true;
            txtNuevaCancha.Focus();
            this.Height = 194;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Football Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gsQuery = "update tabm_cancha set activo_cha=0 where cod_cha=" + cboCancha.SelectedValue;
                if (DLL_Football_Manager.csFunciones.Eliminar(gsQuery, "tabm_cancha") == 1)
                {
                    this.dsListadoCanchasTA.Fill(this.dsDatosBD.dsListadoCanchas);
                    MessageBox.Show("Registro eliminado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.cboCancha.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNuevaCancha.Text != "")
            {
                int iCodigo = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_cha", "tabm_cancha");
                if (giFlag == 0)
                {
                    gsQuery = "insert into tabm_cancha values (" + iCodigo + ",'" + txtNuevaCancha.Text  + "',1)";
                    if (DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabm_cancha") == 1)
                    {
                        btnNuevo.Enabled = true;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                        this.Height = 116;
                        this.dsListadoCanchasTA.Fill(this.dsDatosBD.dsListadoCanchas);
                        MessageBox.Show("Registro guardado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int iResp;
                    if (string.Compare(dsDatosBD.dsListadoCanchas.Rows[cboCancha.SelectedIndex]["nom_cha"].ToString(), txtNuevaCancha.Text) != 0)
                    {
                        gsQuery = "update tabm_cancha set nom_cha ='" + txtNuevaCancha.Text + "' where cod_cha=" + cboCancha.SelectedValue;
                        iResp = DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabm_cancha");
                    }
                    btnNuevo.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    this.Height = 116;
                    this.dsListadoCanchasTA.Fill(this.dsDatosBD.dsListadoCanchas);
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
            txtNuevaCancha.Text = "";
            txtNuevaCancha.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            pnlCancha.Visible = false;
            txtNuevaCancha.Text = "";
            txtNuevaCancha.Focus();
            this.Height = 116;
        }

        private void txtNuevaCancha_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        } 
    }
}
