/*Autor: "Cristian Portillo"
 *Fecha " Agosto 2014"
 *Comentario: "Este modulo solicita otro turno"
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
using System.Net;
using System.Net.Sockets;
namespace proyecto1grupo1
{
    public partial class wfOpciones : Form
    {
        private int I_contador = 1;
        private byte[] B_textoenviar;
        private String S_opcion;
        public wfOpciones(string S_datos)
        {
            InitializeComponent();
            S_opcion = S_datos;
        }
        

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Socket S_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPE_direccion = new IPEndPoint(IPAddress.Parse("192.168.1.20"), 1234);
            I_contador = I_contador - 1;
            String Stexto = S_opcion + "-" + I_contador.ToString();


            try
            {

                S_sock.Connect(IPE_direccion);
                B_textoenviar = Encoding.Default.GetBytes(Stexto);
                S_sock.Send(B_textoenviar, 0, B_textoenviar.Length, 0);
                //MessageBox.Show("Has dicho no");
                I_contador++;

            }
            catch
            {

            }
            S_sock.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Socket S_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPEdireccion = new IPEndPoint(IPAddress.Parse("192.168.1.20"), 1234);

            String S_texto = S_opcion + "-" + I_contador.ToString();


            try
            {

                S_sock.Connect(IPEdireccion);
                B_textoenviar = Encoding.Default.GetBytes(S_texto);
                S_sock.Send(B_textoenviar, 0, B_textoenviar.Length, 0);
                //MessageBox.Show("Has dicho no");
                I_contador++;
            }
            catch
            {

            }
            S_sock.Close();
        }

        private void wfOpciones_Load(object sender, EventArgs e)
        {

        }
    }
}
