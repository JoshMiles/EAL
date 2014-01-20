using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace EAL.Networking
{
    public class Server
    {
        TcpListener t;
        bool running = true;
        public Server(int PORT)
        {
           t = new TcpListener(PORT);
        }

        public void Start(int CONNECTION_LIMIT)
        {
            t.Start();
            for (int i = 0; i < CONNECTION_LIMIT; i++)
            {
                System.Threading.Thread th = new System.Threading.Thread(new System.Threading.ThreadStart(Service));
                th.Start();
            }
        }

        public void Stop()
        {
            running = false;
        }

        public void Service()
        {
            while (running)
            {
                Socket soc = t.AcceptSocket();

            }
        }
    }
}
