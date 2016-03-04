using System;
using System.Threading;

namespace microservice
{
	public class MicroService
	{
		public static short IdCount = 1;

		public short Id;
		public short Type;
		public string baseBusName;
		Thread thread;
		public bool StartServiceAtProgramStartup;
		public bool canBeMultipleInstance;
		public virtual event MessageEvent sendToBus;

		public MicroService ()
		{
			thread = new Thread(RunService);
			baseBusName = "Main";

			//set unique ID
			Id = MicroService.IdCount;
			IdCount += 1;
		}

		/// <summary>
		/// Adds the bus to the sendToBus event.
		/// </summary>
		/// <param name="me">the delegate of the receiveFromService bus function</param>
		public virtual void addSendToBus(MessageEvent me)
		{
			sendToBus += me;
		}

		/// <summary>
		/// Receive rom sender the specified message in args.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="args">Arguments.</param>
		public virtual void receive(object sender, MicroServiceEventArgs args)
		{

		}

		/// <summary>
		/// Inits the service.
		/// </summary>
		public virtual void InitService()
		{
			thread.Start();
		}

		/// <summary>
		/// Runs the service.
		/// function run in the thread 
		/// beware of received data access
		/// might some rework too
		/// </summary>
		public virtual void RunService()
		{
			Console.WriteLine("BASE");
		}

		/// <summary>
		/// Shutdowns the service.
		/// need to use something cleaner
		/// </summary>
		public virtual void ShutdownService()
		{
			thread.Abort();
		}

	}
}

