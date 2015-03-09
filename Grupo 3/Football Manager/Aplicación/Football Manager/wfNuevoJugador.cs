/* Autor: Gabriela Maria
 * Crea nuevos jugadores para ser usados en el campeonato
 * Fecha: 01/08/2014 - Comentario: Diseño y Programación de wfTipoEmpleados
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
    public partial class wfNuevoJugador : Form
    {
        public string gsPath, gsNombreArchivo, gsPath2;
        string gsQuery;
        public int giCodigo;
        public wfNuevoJugador()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            pboFoto.Image = null;
            this.txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text != "") && (txtApellido.Text != "") && (txtDireccion.Text != "") && (txtTelefono.Text != "") && (pboFoto.Image != null))
            {
                if (this.Text == "Inscripción Nuevo Jugador")
                {
                    giCodigo = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_jdr", "tabm_jugador");
                    string sDestino = @"\\192.168.10.50\FootballManager\Jugadores\" + giCodigo + ".jpg";
                    string sDestino2 = @"\\\\192.168.10.50\\FootballManager\\Jugadores\\" + giCodigo + ".jpg";
                    gsQuery = "insert into tabm_jugador values (" + giCodigo + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + sDestino2 + "',1)";
                    if (DLL_Football_Manager.csFunciones.Insertar(gsQuery,"tabm_jugador") == 1)
                    {
                        MessageBox.Show("Registro guardado correctamente", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.IO.File.Copy(@gsPath, sDestino, true);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar registro", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    gsQuery = "update tabm_jugador set nom_jdr='" + txtNombre.Text + "', apell_jdr='" + txtApellido.Text + "', dire_jdr='" + txtDireccion.Text + "', tel_jdr=" + txtTelefono.Text + " where cod_jdr=" + giCodigo;
                    int iResp = DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabm_jugador");
                    if (gsPath2 != gsPath)
                    {
                        System.IO.File.Delete(gsPath2);
                        string sDestino = @"\\192.168.10.50\FootballManager\Jugadores\" + giCodigo + ".jpg";
                        string sDestino2 = @"\\\\192.168.10.50\\FootballManager\\Jugadores\\" + giCodigo + ".jpg";
                        System.IO.File.Copy(@gsPath, sDestino, true);
                    }
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

        private void btnSubir_Click(object sender, EventArgs e)
        {
            OpenFileDialog CargarFotografia = new OpenFileDialog();
            CargarFotografia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (CargarFotografia.ShowDialog(this) == DialogResult.OK)
            {
               gsPath = CargarFotografia.FileName;
                gsNombreArchivo = CargarFotografia.SafeFileName;
                pboFoto.ImageLocation = @gsPath;
                btnGuardar.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789");
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

        private void wfNuevoJugador_Load(object sender, EventArgs e)
        {
            pboFoto.ImageLocation = @gsPath;
            gsPath2 = gsPath;
        }
    }
}
