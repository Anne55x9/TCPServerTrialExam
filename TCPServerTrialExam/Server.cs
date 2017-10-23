using BoxCalLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TCPServerTrialExam
{
    internal class Server
    {
        /// <summary>
        /// Private instans felt af typen int.
        /// </summary>
        private int port;

        /// <summary>
        /// Default konstruktor.
        /// </summary>
        public Server()
        {
            
        }

        /// <summary>
        /// Overloaded konstruktor med parametren port af tyen int.
        /// </summary>
        /// <param name="port"></param>
        public Server(int port)
        {
            this.port = port;
        }


        /// <summary>
        /// Metode som initierer en TCplistener og accepterer en Tcpclient.
        /// </summary>
        public void StartServer()
        {
            TcpListener server = new TcpListener(IPAddress.Any,port);
            server.Start();

            while (true)
            {
                TcpClient clientSocket = server.AcceptTcpClient();
                Task.Run(() =>
                {
                    TcpClient socket = clientSocket;
                    DoClient(socket);
                });
            }
        }

     

        private void DoClient(TcpClient socket)
        {
            using (NetworkStream stream = socket.GetStream())
            using (StreamReader fromClient = new StreamReader(stream))
            {
                string strFromClient = fromClient.ReadLine();
                Console.WriteLine($"From Client text : {strFromClient}");

                BoxCalVol vol = JsonConvert.DeserializeObject<BoxCalVol>(strFromClient);
                Console.WriteLine($"From Client as box volume : {vol}");

                BoxCalLength length = JsonConvert.DeserializeObject<BoxCalLength>(strFromClient);
                Console.WriteLine($"From Client as box length: {length}");



            }
        }
    }
}
