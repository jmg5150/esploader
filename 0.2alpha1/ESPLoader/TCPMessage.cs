using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ESPLoader
{
    class TCPMessage : EventArgs
    {
        public NetworkStream SenderClient { get; private set; }
        public string Content { get; private set; }

        public TCPMessage(NetworkStream client, string message)
        {
            SenderClient = client;
            Content = message;
        }
    }
}
