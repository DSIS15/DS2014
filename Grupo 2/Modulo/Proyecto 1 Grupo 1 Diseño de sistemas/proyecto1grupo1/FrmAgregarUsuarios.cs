using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Gestor_de_Usuarios
{
    public partial class FrmAgregarUsuarios : Form
    {
        private MySqlConnection SQL_Conexion = new MySqlConnection();
        private String connectionString;
        private MySqlCommand SQL_cmd;

        public FrmAgregarUsuarios()
        {
            InitializeComponent();
        }

        private void FrmAgregarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                SQL_Conexion.ConnectionString = S_cadena;
                SQL_Conexion.Open();
                SQL_cmd = new MySqlCommand("INSERT INTO tabm_usuario VALUES  ('" + txtIdUsuario.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtApeCasada.Text + "','" + cboPermiso.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtCorreo.Text + "','" + txtPass.Text +  "')", SQL_Conexion);
                SQL_cmd.ExecuteNonQuery();
                SQL_Conexion.Close();

                MessageBox.Show("Usuario creado exitosamente ", "Creacion Cuenta Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtIdUsuario.Text="";
                txtNombre.Text="";
                txtApellido.Text="";
                txtApeCasada.Text="";
                cboPermiso.Text="";
                txtDireccion.Text="";
                txtTelefono.Text="";
                txtCorreo.Text="";
                txtPass.Text = "";   


            }
            catch (MySqlException)
            {
                MessageBox.Show("Revise sus datos, ingreso no completado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
