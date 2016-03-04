using System;

namespace microservice
{
	public delegate void MessageEvent(object sender,MicroServiceEventArgs e);

	public class MicroServiceBus
	{
		public string Name;

		public event MessageEvent sendToService;

		public MicroServiceBus ()
		{
			
		}

		public void receiveFromService(object sender, MicroServiceEventArgs e)
		{
			//Console.WriteLine("receiving message to bus with:");
			//Console.WriteLine("header: " + e.message.header);
			//Console.WriteLine("content: " + e.message.content);
			//Console.WriteLine("Target Name: " + e.message.TargetName);
			//Console.WriteLine("Target ID: " + e.message.TargetId);
			foreach(Delegate d in sendToService.GetInvocationList())
			{
				MicroService ms = (MicroService)d.Target;
				if(ms.GetType().Name == e.message.TargetName && e.message.TargetId !=  0)
				{ ms.receive(sender,e); }
				else if (e.message.TargetId == 0)
				{ throw new Exception("Error: can't use Core Id"); }
				else if(e.message.TargetId == 0)
				{
					//Core request
				}
			}
			//sendToService(sender,e);
		}
	}
}

