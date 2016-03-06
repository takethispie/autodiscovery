using System;
using System.Threading;
using DustCatMicroService;

namespace DCMSExampleApplication
{
    public class InputService : MicroService
    {
        public override event MessageEvent sendToBus;

        public InputService()
        {
            StartServiceAtProgramStartup = true;
        }

        public override void receive(object sender, MicroServiceEventArgs args)
        {

        }

        public override void RunService()
        {
            if (started)
            {
                MicroServiceEventArgs ev = new MicroServiceEventArgs();
                string cmd = "";
                while (!cmd.StartsWith("stop"))
                {
                    Console.Write(">");
                    cmd = Console.ReadLine();
                    if (cmd.StartsWith("start"))
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

