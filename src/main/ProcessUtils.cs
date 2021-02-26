using System;
using System.Diagnostics;

namespace PacketCommunicator
{
    class ProcessUtils
    {
        public static void PU_RUNPROCESS(String I_DIR, String I_FNAME)
        {
            ProcessStartInfo P_SINFO = new ProcessStartInfo();

            P_SINFO.WorkingDirectory = I_DIR;
            P_SINFO.FileName = I_FNAME;

            Process.Start(P_SINFO);
        }

        public static void PU_RUNCMD(String I_ARGS)
        {
            ProcessStartInfo P_SINFO = new ProcessStartInfo();

            P_SINFO.WorkingDirectory = "C:\\Windows\\System32";
            P_SINFO.FileName = "CMD.exe";
            P_SINFO.Arguments = I_ARGS;

            Process.Start(P_SINFO);
        }
    }
}
