using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPClientTrialExam
{
    class Program
    {
        private const int port = 9999;
        static void Main(string[] args)
        {
           
                Client client = new Client(port);
                client.StartClient();

                Console.ReadLine();
            
        }
    }
}
