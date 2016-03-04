using System;

namespace microservice
{
	public class DisplayService : MicroService
	{
		public override event MessageEvent sendToBus;

		public DisplayService ()
		{
			StartServiceAtProgramStartup = true;
			baseBusName = "Main";
		}

		public override void addSendToBus(MessageEvent me)
		{
			sendToBus += me;
		}

		public override void receive(object sender, MicroServiceEventArgs args)
		{
			Console.WriteLine(args.message.content);
		}

		public override void RunService()
		{
			
		}
	}
}

