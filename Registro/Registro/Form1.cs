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

namespace Prueba
{
    public partial class Form1 : Form
    {
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutadeArchivosMP3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;
            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
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

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutadeArchivosMP3[lstCanciones.SelectedIndex];
            lblCancion.Text = ArchivosMP3[lstCanciones.SelectedIndex];

        }

        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {

        }

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

        private void btnStop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            btnPlay.Image = Properties.Resources.play;
            Play = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();
            mtrackEstatus.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            mtrackVolumen.Value = Reproductor.settings.volume;

        }
        private void ActualizarDatosTrack()
        {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mtrackEstatus.Maximum=(int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if(Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
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
        {
            ActualizarDatosTrack();
        }

        private void mtrackVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = mtrackVolumen.Value;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string toSend = "Hello!";

            IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5554);

            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(serverAddress);

            // Sending
            int toSendLen = System.Text.Encoding.ASCII.GetByteCount(toSend);
            byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(toSend);
            byte[] toSendLenBytes = System.BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);

            // Receiving
            byte[] rcvLenBytes = new byte[4];
            clientSocket.Receive(rcvLenBytes);
            int rcvLen = System.BitConverter.ToInt32(rcvLenBytes, 0);
            byte[] rcvBytes = new byte[rcvLen];
            clientSocket.Receive(rcvBytes);
            String rcv = System.Text.Encoding.ASCII.GetString(rcvBytes);

            Console.WriteLine("Client received: " + rcv);

            clientSocket.Close();
        }
    }
}
    
        