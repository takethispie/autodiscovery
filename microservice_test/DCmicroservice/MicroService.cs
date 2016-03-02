using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DCmicroservice
{
    public abstract class MicroService
    {

        Thread thread;

        /// <summary>
        /// service name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// value follow design implementation, can be used for anything
        /// </summary>
        public byte Status { get; set; }

        /// <summary>
        /// the Id of the service
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// value follow design implementation, can be used for anything
        /// </summary>
        public short type { get; set; }

        /// <summary>
        /// name of the bus to connect the service to
        /// </summary>
        public string busName { get; set; }

        /// <summary>
        /// register bus to send data to
        /// </summary>
        public event MessageEvent send;

        public virtual void Init()
        {
            thread = new Thread(run);
        }

        //receive data
        public abstract void OnMessageReceived(object sender, MessageReceivedEventArgs e);

        public abstract void run();

        public virtual void Shutdown()
        {
            thread.Abort();
        }
    }
}
