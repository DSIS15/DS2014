/*Autor: "Cristian Portillo"
 *Fecha " Agosto 2014"
 *Comentario: "Este modulo agrega un item"
 *Estandarizado por: "Jessica Castellanos"
 *Fecha estandarizacion: 27 Agosto 2014*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyecto1grupo1
{
    public partial class wfAgregarItem : Form
    {
        private MySqlConnection SQL_Conexion = new MySqlConnection();
        private String connectionString;
        private MySqlCommand SQL_cmd;
        public wfAgregarItem()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                String S_cadena = "Server=192.168.1.100;UID= root; Database= bd_turnos; Password=GrupoSGT014;";
                SQL_Conexion.ConnectionString = S_cadena;
                SQL_Conexion.Open();
                SQL_cmd = new MySqlCommand("INSERT INTO tabm_modulo VALUES  ('" + txtIdmodulo.Text + "','" + txtModl_nom.Text + "','" + txtModl_estd.Text + "','" + txtModl_desp.Text + "')", SQL_Conexion);
                SQL_cmd.ExecuteNonQuery();
                SQL_Conexion.Close();

                MessageBox.Show("Item agregado Exitosamente ", "Bienvenido al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (MySqlException)
            {

            }
        }

        private void wfAgregarItem_Load(object sender, EventArgs e)
        {

        }
    }
}
