using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PacketCommunicator
{
    class Packets : Utils
    {
        public void P_SENDPACKET(String I_IP, String I_PDATA)
        {
            try
            {
                byte[] R_PDATA = ASCIIEncoding.ASCII.GetBytes(I_PDATA);
                IPEndPoint R_LOC = new IPEndPoint(IPAddress.Parse(I_IP), 80);
                Socket R_CLIENT = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                R_CLIENT.SendTimeout = 1;

                R_CLIENT.SendTo(R_PDATA, R_LOC);

                U_SETCOLOR(ConsoleColor.DarkGreen);
                Console.WriteLine($"\nSent message to {I_IP}: {I_PDATA}");
                U_RESETCOLOR();

                P_RECEIVEPACKET(R_PDATA);
            } catch (SystemException)
            {
                U_SETCOLOR(ConsoleColor.Red);
                Console.WriteLine($"ERROR: Could not send message to {I_IP}.");
                U_RESETCOLOR();
                Console.ReadLine();
            }
        }

        public void P_RECEIVEPACKET(byte[] I_PDATA)
        {
            IPEndPoint R_EP = new IPEndPoint(IPAddress.Any, 80);
            Socket R_CLIENT = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            R_CLIENT.Bind(R_EP);

            IPEndPoint R_SENDER = new IPEndPoint(IPAddress.Any, 80);
            EndPoint R_REMOTE = (EndPoint)(R_SENDER);
            int R_REC_V = R_CLIENT.ReceiveFrom(I_PDATA, ref R_REMOTE);

            U_SETCOLOR(ConsoleColor.DarkGreen);
            Console.WriteLine($"\nTest");
            Console.WriteLine($"\nReceived message message from {0}: {R_REMOTE.ToString()}");
            Console.WriteLine(Encoding.ASCII.GetString(I_PDATA, 80, R_REC_V));
            U_RESETCOLOR();
        }
    }
}
