using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ESPLoader
{
    class TCPServer
    {
        private TcpListener tcpListener;
        private Thread listenThread;
        private bool SeverActive;

        public event System.EventHandler<EventArgs> ClientConnected;
        public event System.EventHandler<EventArgs> ClientDisconnected;
        public event System.EventHandler<TCPMessage> DataReceived;

        public List<TCPMessage> ReceivedMessages;

        public TCPServer(int portnumber)
        {
            ReceivedMessages = new List<TCPMessage>();

            tcpListener = new TcpListener(IPAddress.Any, portnumber);
            listenThread = new Thread(new ThreadStart(ListenForClients));
            SeverActive = true;
            listenThread.Start();
        }

        public void Stop()
        {
            SeverActive = false;
            listenThread.Abort();

        }

        public void Restart()
        {
            listenThread = new Thread(new ThreadStart(ListenForClients));
            SeverActive = true;
            listenThread.Start();
        }

        private void ListenForClients()
        {
            tcpListener.Start();

            while (SeverActive)
            {
                //blocks until a client has connected to the server
                TcpClient client = tcpListener.AcceptTcpClient();

                if (ClientConnected != null)
                {
                    ClientConnected(this, EventArgs.Empty);
                }

                //create a thread to handle communication 
                //with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }

            tcpListener.Stop();
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (SeverActive)
            {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                    break;
                }

                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    if (ClientDisconnected != null)
                    {
                        ClientDisconnected(this, EventArgs.Empty);
                    }
                    break;
                }

                //message has successfully been received
                ASCIIEncoding encoder = new ASCIIEncoding();

                if (DataReceived != null)
                    DataReceived(this, new TCPMessage(clientStream, encoder.GetString(message, 0, bytesRead)));

            }
        }

        private void SendData(NetworkStream clientStream, string message)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(message);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
        }
    }
}
