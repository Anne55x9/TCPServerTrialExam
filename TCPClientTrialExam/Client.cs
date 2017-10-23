using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxCalLib;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;

namespace TCPClientTrialExam
{
    internal class Client
    {
        /// <summary>
        /// Private instans af typen int.
        /// </summary>
        private int port;

        /// <summary>
        /// Default konstruktør.
        /// </summary>
        public Client()
        {
            
        }

        /// <summary>
        /// Overloaded konstruktor med 1 parameter.
        /// </summary>
        /// <param name="port"></param>
        public Client(int port)
        {
            this.port = port;
        }

        public void StartClient()
        {
            BoxCalVol vol = new BoxCalVol(2,2,2);
            
            BoxCalLength length = new BoxCalLength(8,2,2); 

            using (TcpClient cSocket = new TcpClient("localhost", port))
            using (Stream stream = cSocket.GetStream())
            using (StreamWriter toServer = new StreamWriter(stream))
            {
                string jsonStr = JsonConvert.SerializeObject(vol);
                Console.WriteLine($"Client json string: {jsonStr} and size:: {jsonStr.Length}");

                toServer.WriteLine(jsonStr);

                string jsonStr2 = JsonConvert.SerializeObject(length);
                Console.WriteLine($"Client json string: {jsonStr2} and size:: {jsonStr2.Length}");

                toServer.WriteLine(jsonStr);
                toServer.WriteLine(jsonStr2);

                toServer.Flush();
            }
        }

    }
}
