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
        
        
        
        //private void Receptor()
        //{
        //    //IPEndPoint ipEnd;
        //    //Socket sock;
        //    //public FTServerCode()
        //    {
        //        ipEnd = new IPEndPoint(IPAddress.Any, 5656);
        //        //Make IP end point to accept any IP address with port no 5656.
        //        sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        //        //Here creating new socket object with protocol type and transfer data type
        //        sock.Bind(ipEnd);
        //        //Bind end point with newly created socket.
        //    }
        //    //public static string receivedPath;
        //    //public static string curMsg = "Stopped";
        //    //public void StartServer()
        //    {
        //        try
        //        {
        //            curMsg = "Starting...";
        //            sock.Listen(100);
        //            /* That socket object can handle maximum 100 client connection at a time & 
        //            waiting for new client connection /
        //            curMsg = "Running and waiting to receive file.";
        //            Socket clientSock = sock.Accept();
        //            /* When request comes from client that accept it and return 
        //            new socket object for handle that client. */
        //            byte[] clientData = new byte[1024 * 5000];
        //            int receivedBytesLen = clientSock.Receive(clientData);
        //            curMsg = "Receiving data...";
        //            int fileNameLen = BitConverter.ToInt32(clientData, 0);
        //            /* I've sent byte array data from client in that format like 
        //            [file name length in byte][file name] [file data], so need to know 
        //            first how long the file name is. /
        //            string fileName = Encoding.ASCII.GetString(clientData, 4, fileNameLen);
        //            /* Read file name */
        //            BinaryWriter bWrite = new BinaryWriter(File.Open
        //            (receivedPath + "/" + fileName, FileMode.Append)); ;
        //            /* Make a Binary stream writer to saving the receiving data from client. /
        //            bWrite.Write(clientData, 4 + fileNameLen, 
        //             receivedBytesLen - 4 - fileNameLen);
        //            /* Read remain data (which is file content) and 
        //            save it by using binary writer. */
        //            curMsg = "Saving file...";
        //            bWrite.Close();
        //            clientSock.Close();
        //            /* Close binary writer and client socket */
        //            curMsg = "Received & Saved file; Server Stopped.";
        //        }
        //        catch (Exception ex)
        //        {
        //            curMsg = "File Receiving error.";
        //        }
        //    }
        //}
        
        //private void Recibidor()
        //{
        //    //public static string curMsg = "Idle";
        //    //public static void SendFile(string fileName)
        
        //    try
        //    {
        //        IPAddress[] ipAddress = Dns.GetHostAddresses("localhost");
        //        IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5554);
        //        /* Make IP end point same as Server. */
        //        Socket clientSock = new Socket(AddressFamily.InterNetwork,
        //        SocketType.Stream, ProtocolType.IP);
        //        /* Make a client socket to send data to server. */
        //        string filePath = "";
        //        /* File reading operation. */
        //        fileName = fileName.Replace("\\", "/");
        //        while (fileName.IndexOf("/") > -1)
        //        {
        //            filePath += fileName.Substring(0, fileName.IndexOf("/") + 1);
        //            fileName = fileName.Substring(fileName.IndexOf("/") + 1);
        //        }
        //        byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
        //        if (fileNameByte.Length > 850 * 1024)
        //        {
        //            curMsg = "File size is more than 850kb, please try with small file.";
        //            return;
        //        }
        //        curMsg = "Buffering ...";
        //        byte[] fileData = File.ReadAllBytes(filePath + fileName);
        //        /* Read & store file byte data in byte array. */
        //        byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
        //        /* clientData will store complete bytes which will store file name length, 
        //        file name & file data. */
        //        byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
        //        /* File name length’s binary data. */
        //        fileNameLen.CopyTo(clientData, 0);
        //        fileNameByte.CopyTo(clientData, 4);
        //        fileData.CopyTo(clientData, 4 + fileNameByte.Length);
        //        /* copy these bytes to a variable with format line [file name length]
        //        [file name] [ file content] */
        //        curMsg = "Connection to server ...";
        //        clientSock.Connect(ipEnd);
        //        /* Trying to connection with server. /
        //        curMsg = "File sending...";
        //        clientSock.Send(clientData);
        //        /* Now connection established, send client data to server. */
        //        curMsg = "Disconnecting...";
        //        clientSock.Close();
        //        /* Data send complete now close socket. */
        //        curMsg = "File transferred.";
        //    }
        //    catch (Exception ex)
        //    {
        //        if (ex.Message == "No connection could be made because the target machine 
        //            actively refused it")
        //             curMsg = "File Sending fail. Because server not running.";
        //     else
        //            curMsg = "File Sending fail." + ex.Message;
        //    }
        //}
        /////////

    }
}

    

    
        