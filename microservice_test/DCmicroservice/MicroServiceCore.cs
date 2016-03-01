using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCmicroservice
{
    public class MicroServiceCore
    {
        Dictionary<string,MicroServiceBus> MicroSBUS;

        public MicroServiceCore()
        {
            MicroSBUS = new Dictionary<string,MicroServiceBus>();
            MicroSBUS.Add("Main",new MicroServiceBus("Main"));
        }
    }
}
