﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServerTrialExam
{
    class Program
    {
        private const int port = 9999;
        static void Main(string[] args)
        {
                Server server = new Server(port);
                server.StartServer();

                Console.ReadLine();
        }
    }
}
