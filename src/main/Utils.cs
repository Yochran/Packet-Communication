using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketCommunicator
{
    class Utils
    {
        public static void U_SETCOLOR(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public static void U_RESETCOLOR()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected static void U_STARTUP()
        {
            U_RESETCOLOR();
            Console.Title = "Packet Communicator v1.0";
            Console.WriteLine("Packet communicator v1.0 has loaded.");
            Console.WriteLine("Running JavaScript now...");
            Console.WriteLine("[PREF]: JavaScript not run due to comments.");

            /*
            try
            {
                ProcessUtils.PU_RUNPROCESS("D:\\PacketCommunicator", "javascript.bat");
            } catch (SystemException e)
            {
                U_SETCOLOR(ConsoleColor.Red);
                Console.WriteLine($"Error: Could not start JavaScript process. ({e})");
                U_RESETCOLOR();
                Console.ReadLine();
            }
            */
        }
    }
}
