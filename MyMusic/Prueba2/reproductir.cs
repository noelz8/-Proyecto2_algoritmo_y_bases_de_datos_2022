// imports necesarios para el funcionamiento
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Prueba2
{
    public partial class reproductir : Form
    {   //Globales a utilizar
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutadeArchivosMP3;
        public reproductir()
        {
            InitializeComponent();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)

        {
            //Creacion de Variable de busqueda de archivos
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;
            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //variable donde se guardaran los nombres e archivos(canciones)
                ArchivosMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;
                rutadeArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;
                foreach (var ArchivosMP3 in ArchivosMP3)
                {
                    lstCanciones.Items.Add(ArchivosMP3);
                }
                Reproductor.URL = rutadeArchivosMP3[0];
                lstCanciones.SelectedIndex = 0;
                btnPlay.Image = Properties.Resources.play;


            }
        }
        //Lugar donde se mostraran el listado de canciones añadidas
        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutadeArchivosMP3[lstCanciones.SelectedIndex];
            lblCancion.Text = ArchivosMP3[lstCanciones.SelectedIndex];

        }
        // botton de reproduccion de musica e pausa
        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch (Play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    btnPlay.Image = Properties.Resources.play;
                    Play = false;
                    break;
                case false:
                    Reproductor.Ctlcontrols.play();
                    btnPlay.Image = Properties.Resources.pause;
                    Play = true;
                    break;

            }
        }
        // botton de parar e reiniciar musica
        private void btnStop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            btnPlay.Image = Properties.Resources.play;
            Play = false;
        }
        // actulizador de datos 
        private void ActualizarDatosTrack()
        {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mtrackEstatus.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();

            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                mtrackEstatus.Value = 0;

            }
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {   // llama a actualizar datos
            ActualizarDatosTrack();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Reproductor.settings.volume = mtrackVolumen.Value;
        }
        // sockets que se conectaran a el servidor de java
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string toSend = "Hello!";

            IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5554);

            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(serverAddress);

            // Enviardor de bits
            int toSendLen = System.Text.Encoding.ASCII.GetByteCount(toSend);
            byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(toSend);
            byte[] toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);

            // Recibidor de bits
            byte[] rcvLenBytes = new byte[4];
            clientSocket.Receive(rcvLenBytes);
            int rcvLen = System.BitConverter.ToInt32(rcvLenBytes, 0);
            byte[] rcvBytes = new byte[rcvLen];
            clientSocket.Receive(rcvBytes);
            String rcv = System.Text.Encoding.ASCII.GetString(rcvBytes);

            Console.WriteLine("Client received: " + rcv);
            // cierra la conexion con el servidor
            clientSocket.Close();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void mtrackEstatus_Scroll(object sender, EventArgs e)
        {

        }

        private void lblCancion_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ActualizarDatosTrack();
            mtrackEstatus.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            mtrackVolumen.Value = Reproductor.settings.volume;

        }

        private void reproductir_Load(object sender, EventArgs e)
        {

        }
    }
}
