using System;
using System.Threading;

namespace microservice
{
	public class TestService1 : MicroService
	{
		public override event MessageEvent sendToBus;

		public TestService1 ()
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
			Console.WriteLine(">");
			MicroServiceEventArgs ev = new MicroServiceEventArgs();
			string cmd = "";
			while(!cmd.StartsWith("STOP"))
			{
				cmd = Console.ReadLine();
				ev.message = new StandardMessage("CMD_INPUT",cmd,"serviceTest2",2);
				sendToBus(this,ev);
			}
		}

	}
}

