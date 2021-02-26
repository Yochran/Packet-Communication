using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketCommunicator
{
    class Program : Utils
    {
        static void Main(string[] args)
        {
            U_STARTUP();

            Packets SENDER = new Packets();

            String I_IP = M_SELECT_IP();
            String I_PDATA = M_SELECT_DATA();

            SENDER.P_SENDPACKET(I_IP, I_PDATA);

            Console.ReadLine();
        }

        // Selection Functions
        private static String M_SELECT_IP()
        {
            U_RESETCOLOR();
            Console.Write("\nEnter the IP You want to send to: ");
            U_SETCOLOR(ConsoleColor.Green);

            return Console.ReadLine();
        }

        private static String M_SELECT_DATA()
        {
            U_RESETCOLOR();
            Console.Write("\nEnter the message you want to send: ");
            U_SETCOLOR(ConsoleColor.Green);

            return Console.ReadLine();
        }
    }
}
