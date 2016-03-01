using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DCmicroservice
{
    public class MicroService
    {

        Thread thread;

        public virtual string Name { get; set; }

        public virtual byte Status { get; set; }

        public virtual short Id { get; set; }

        //register bus to send data to
        public event MessageEvent send;

        public virtual void Init()
        {
            thread = new Thread(run);
        }

        //receive data
        public virtual void OnMessageReceived(object sender, MessageReceivedEventArgs e)
        {

        }

        public virtual void run()
        {

        }

        public virtual void Shutdown()
        {

        }
    }
}
