﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        static void Main(string[] args)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, 904));
            socket.Listen(5);
            Socket client = socket.Accept();
            Console.WriteLine("New connection");
            byte[] buffer = new byte[1024];
            client.Receive(buffer);
            Console.WriteLine(Encoding.ASCII.GetString(buffer));
            Console.ReadLine();
        }
    }
}
