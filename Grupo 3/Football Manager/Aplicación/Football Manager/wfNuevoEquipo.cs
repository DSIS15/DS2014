/* Autor: Daniel Moreno
 * Crea nuevos equipos para luego ingresarlos a el campeonato
 * Fecha: 03/08/2014 - Comentario: Diseño y Programación de wfTipoEmpleados
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
using System.Data.Odbc;

namespace Football_Manager
{
    public partial class wfNuevoEquipo : Form
    {
        string gsQuery, gsPath, gsNombreArchivo, gsPath2;

        public wfNuevoEquipo()
        {
            InitializeComponent();
        }

        private void wfequipo_Load(object sender, EventArgs e)
        {
            gsPath2 = gsPath;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            if (this.txtNombreEquipo.Text != "" && this.pboEquipo.Image !=null)
            {
                int iCodigo = DLL_Football_Manager.csFunciones.ObtenerNoRegistro("cod_eqp","tabm_equipo");
                string sDestino = @"\\192.168.10.50\FootballManager\Equipos\" + iCodigo + ".jpg";
                string sDestino2 = @"\\\\192.168.10.50\\FootballManager\\Equipos\\" + iCodigo + ".jpg";
                gsQuery = "Insert into tabm_equipo values (" + iCodigo + ",'" + this.txtNombreEquipo.Text + "','" + sDestino2 + "',1)";
                if (DLL_Football_Manager.csFunciones.Insertar(gsQuery, "tabm_equipo") == 1)
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
            else {
                MessageBox.Show("Ingrese todos los campos", "Football Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog CargarFotografia = new OpenFileDialog();
            CargarFotografia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (CargarFotografia.ShowDialog(this) == DialogResult.OK)
            {
                gsPath = CargarFotografia.FileName;
                gsNombreArchivo = CargarFotografia.SafeFileName;
                pboEquipo.ImageLocation = @gsPath;
                btnGuardarEquipo.Focus();
            }
        }

        private void txtNombreEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DLL_Football_Manager.csFunciones.ValidarTexto(e, "0123456789-_abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtNombreEquipo.Text = "";
            txtNombreEquipo.Focus();
            pboEquipo.Image = null;
        }
      
    }
}
