using System;

namespace microservice
{
	public class InputService : MicroService
	{
		public override event MessageEvent sendToBus;

		public InputService ()
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

		}

		public override void RunService()
		{
			Console.Write(">");
			MicroServiceEventArgs ev = new MicroServiceEventArgs();
			string cmd = "";
			while(!cmd.StartsWith("STOP"))
			{
				cmd = Console.ReadLine();
				ev.message = new StandardMessage("CMD_INPUT",cmd,"ProcessService",2);
				sendToBus(this,ev);
			}
		}

	}
		
}

