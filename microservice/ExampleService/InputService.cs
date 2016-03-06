using System;
using System.Threading;

namespace DustCatMicroService
{
    public class InputService : MicroService
    {
        public override event MessageEvent sendToBus;

        public InputService()
        {
            StartServiceAtProgramStartup = true;
            baseBusName = "Main";
        }

        public override void receive(object sender, MicroServiceEventArgs args)
        {

        }

        public override void RunService()
        {
            if (started)
            {
                Console.Write(">");
                MicroServiceEventArgs ev = new MicroServiceEventArgs();
                string cmd = "";
                while (!cmd.StartsWith("stop"))
                {
                    cmd = Console.ReadLine();
                    if (cmd.StartsWith("start"))
                    {
                        ev.message = new StandardMessage("START_SERV", cmd, "DisplayService", 0);
                    }
                    else if (cmd.StartsWith("servicestart"))
                    {
                        ev.message = new StandardMessage("START_SERV", cmd, cmd.Split(' ')[1], 0);
                    }
                    else
                    {
                        ev.message = new StandardMessage("CMD_INPUT", cmd, "ProcessService", 2);
                    }
                    sendToBus(this, ev);
                }
            }
        }

    }

}

