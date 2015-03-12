/*Autor: "Cristian Portillo"
 *Fecha " Julio 2014"
 *Comentario: "Este modulo mostrara el inicio de sesion del usuario"
 *Estandarizado por: "Jessica Castellanos"
 *Fecha estandarizacion: 10 Agosto 2014*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Net;
using System.Security.Principal;

namespace proyecto1grupo1
{
    public partial class wfInicioSesion : Form
    {

       private MySqlConnection SQL_Conexion = new MySqlConnection();
       private String connectionString;
       private MySqlCommand SQL_cmd;

        int contadorInicioSesion=0;


        public wfInicioSesion()
        {
            InitializeComponent();
        }

         

        private void button1_Click(object sender, EventArgs e)
        {        
            
            wfInicioSesion frmSesion = new wfInicioSesion();
            wfPantallaTurnos frmPantalla = new wfPantallaTurnos();
           
           
                try
                {
                    String S_cadena = "Server=192.168.1.100;User ID= root; Database= bd_turnos; Password=GrupoSGT014;";                   
                    SQL_Conexion.ConnectionString = S_cadena;
                    SQL_Conexion.Open();
                    SQL_cmd = new MySqlCommand("Select id_usuario from tabm_usuario WHERE usur_pass='" + txt_pass.Text + "'", SQL_Conexion);                    
                    Object obj = SQL_cmd.ExecuteScalar();

                    if (obj == null)
                    {
                        
                        MessageBox.Show("Error", "El  usuario y contraseña son invalidos validos, intente de nuevo");
                        contadorInicioSesion += 1;
                        txt_usuario.Text = "";
                        txt_pass.Text = "";
                        SQL_Conexion.Close();
                        

                    }
                    else
                         {
                             IPHostEntry IP_host;
                             string S_localIP = "";
                             IP_host = Dns.GetHostEntry(Dns.GetHostName());
                             foreach (IPAddress ip in IP_host.AddressList)
                             {
                                 if (ip.AddressFamily.ToString() == "InterNetwork")
                                 {
                                     S_localIP = ip.ToString();
                                 }
                             }
                            
                            WindowsIdentity W_user = WindowsIdentity.GetCurrent();
                            string S_usuario=W_user.Name;
                            
                            
                            SQL_cmd = new MySqlCommand("INSERT INTO tabm_sesion(usur_id,ses_fech_inic,ses_hora_inic,ses_dir_ip,ses_host) values (\"" + txt_usuario.Text + "\",now(),now(),'" + S_localIP + "','" + S_usuario + "')", SQL_Conexion);
                            SQL_cmd.ExecuteNonQuery();
                            

                            SQL_cmd = new MySqlCommand("SELECT MAX(id_sesion)  FROM tabm_sesion where usur_id='"+txt_usuario.Text+"'", SQL_Conexion);
                            Object Oobj = SQL_cmd.ExecuteScalar();

                           

                            SQL_cmd = new MySqlCommand("select usur_nom,usur_ape,usur_permiso from tabm_usuario WHERE id_usuario='" + txt_usuario.Text + "'", SQL_Conexion);
                            MySqlDataReader dataReader =  SQL_cmd.ExecuteReader();

                          
                            while (dataReader.Read()){
                                String sFlag = dataReader["usur_permiso"] + "";
                                if (sFlag != "1")
                                {
                                    frmPantalla.tsmiAdmin.Enabled = false;
                                } 
                        
                                frmPantalla.tSlblNombre.Text = dataReader["usur_nom"] + " " + dataReader["usur_ape"];
                            }

                            frmPantalla.tSlblID_usur.Text = txt_usuario.Text;
                            frmPantalla.stlblAuxID.Text = Oobj.ToString();
                            frmPantalla.Show();
                            txt_usuario.Text = "";
                            txt_pass.Text = "";
                            SQL_Conexion.Close();
                            this.Hide();
                                                       
                           }
                }
                catch (MySqlException)
                {  }

           
            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void wfInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
