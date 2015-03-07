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
    public partial class FrmAdministracion : Form
    {
        private MySqlConnection SQL_Conexion = new MySqlConnection();
        private String connectionString;
       

        public FrmAdministracion()
        {
            InitializeComponent();
        }

      

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuarios FrmNuevoUsuario = new FrmAgregarUsuarios();
            FrmNuevoUsuario.Show();
        }

        private void btnModificarUser_Click(object sender, EventArgs e)
        {
            wfModificarUsuarios wfModificar = new wfModificarUsuarios();
            wfModificar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            wfEliminarUsuario wfEliminar = new wfEliminarUsuario();
            wfEliminar.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string S_Cconn = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";

                MySqlConnection SQL_conexion = new MySqlConnection();
                SQL_conexion.ConnectionString = S_Cconn;
                SQL_conexion.Open();
                MySqlDataAdapter SQL_da = new MySqlDataAdapter("Select * from tabm_usuario", SQL_conexion);
                MySqlCommand SQL_cmd= new MySqlCommand("select count(*) from tabm_usuario ", SQL_conexion);
                
                DataTable DT_dat = new DataTable();
                SQL_da.Fill(DT_dat);
                this.dgvUsuarios.DataSource = DT_dat;

                Object obj = SQL_cmd;
                this.lblTotal.Text = obj.ToString();

                SQL_conexion.Close();

                
            }
            catch (Exception ei)
            {
                MessageBox.Show("Ocurrio un error" + ei.Message);
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string S_Cconn = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";

                MySqlConnection SQL_conexion = new MySqlConnection();
                SQL_conexion.ConnectionString = S_Cconn;
                SQL_conexion.Open();
                MySqlDataAdapter SQL_da = new MySqlDataAdapter("Select * from  tabm_usuario WHERE id_usuario='" + txbBuscarUsuario.Text + "'", SQL_conexion);
                DataTable DT_dat = new DataTable();
                SQL_da.Fill(DT_dat);
                this.dgvUsuarios.DataSource = DT_dat;

                SQL_conexion.Close();
            }
            catch (Exception ei)
            {
                MessageBox.Show("Ocurrio un error" + ei.Message);
            }
        }

       
       

    }
}
