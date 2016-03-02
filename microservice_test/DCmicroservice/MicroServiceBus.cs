using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCmicroservice
{

    public delegate void MessageEvent(object sender, MessageReceivedEventArgs e);

    public class MicroServiceBus
    {
        public MicroServiceBus(string name)
        {
            Name = name; 
        }

        public string Name;

        /// <summary>
        /// send message to microservice
        /// </summary>
        event MessageEvent send;

        /// <summary>
        /// add microservice to Bus
        /// </summary>
        /// <param name="ev"></param>
        public void add(MessageEvent ev)
        {
            send += ev;
        }
    }
}
