using System;
using System.Threading;
using DustCatMicroService;

namespace DCMSExampleApplication
{
    public class DisplayService : MicroService
    {
        public override event MessageEvent sendToBus;

        public DisplayService()
        {
            StartServiceAtProgramStartup = false;
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

