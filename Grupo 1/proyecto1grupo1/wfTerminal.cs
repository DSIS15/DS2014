/*Autor: "Cristian Portillo"
 *Fecha " Agosto 2014"
 *Comentario: "Este modulo es la terminal tonta"
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
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;


namespace proyecto1grupo1
{
    
    public partial class wfTerminal : Form
    {
        private byte[] b_textorecivido;
        private Socket S_recive;
        private IPEndPoint IP_Direccion;
        private SpeechSynthesizer s_Synth = new SpeechSynthesizer();// 
        private PromptBuilder p_Builder = new PromptBuilder();
        private SpeechRecognitionEngine SR_recognze = new SpeechRecognitionEngine();
        public wfTerminal()
        {
            InitializeComponent();
            S_recive = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IP_Direccion = new IPEndPoint(IPAddress.Any, 1234);

        }

        private void wfTerminal_Load(object sender, EventArgs e)
        {

        }

        private void pr_hablar()
        {
            p_Builder.ClearContent(); // limpia el contenido que sera escrito
            p_Builder.AppendText(lblMostrar.Text);
            s_Synth.GetInstalledVoices(new System.Globalization.CultureInfo("es-ES"));  //ESTE ES PARA IDIOMA
            s_Synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            s_Synth.Rate = -5;
            s_Synth.Speak(p_Builder);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        S_recive = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IP_Direccion = new IPEndPoint(IPAddress.Any, 1234);
        try
        {
            S_recive.Bind(IP_Direccion);
            S_recive.Listen(2);
            Socket S_escuchar = S_recive.Accept();
            b_textorecivido = new byte[255];
            int i_num = S_escuchar.Receive(b_textorecivido, 0, b_textorecivido.Length, 0);
            Array.Resize(ref b_textorecivido, i_num);
            lblMostrar.Text = Encoding.Default.GetString(b_textorecivido);

            S_escuchar.Close();
            S_recive.Close();


        }
        catch
            { }
        }
    }
}
