using System;
using System.Threading;

namespace DustCatMicroService
{
    public class MicroService
    {
        public static short IdCount = 1;

        public short Id;
        public short Type;
        public string baseBusName;

        protected virtual Thread thread { get; set; }

        public bool StartServiceAtProgramStartup;
        public bool canBeMultipleInstance;
        public bool started;
        public virtual event MessageEvent sendToBus;

        public MicroService()
        {
            thread = new Thread(RunService);
            baseBusName = "Main";
            started = false;
            //set unique ID
            Id = MicroService.IdCount;
            IdCount += 1;
        }

        /// <summary>
        /// Adds the bus to the sendToBus event.
        /// </summary>
        /// <param name="me">the delegate of the receiveFromService bus function</param>
        public void addSendToBus(MessageEvent me)
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
            started = true;
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
            throw new Exception("Error Cannott run base class");
        }

        /// <summary>
        /// Shutdowns the service.
        /// need to use something cleaner
        /// </summary>
        public virtual void ShutdownService()
        {
            started = false;
            thread.Abort();
        }

    }
}

