using System;
using System.Threading;

namespace DustCatMicroService
{
    public class DisplayService : MicroService
    {
        public override event MessageEvent sendToBus;

        public DisplayService()
        {
            StartServiceAtProgramStartup = false;
            baseBusName = "Main";
        }

        public override void receive(object sender, MicroServiceEventArgs args)
        {
            if (started)
            {
                Console.WriteLine(args.message.content);
            }
        }

        public override void RunService()
        {

        }
    }
}

