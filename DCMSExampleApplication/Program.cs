using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DustCatMicroService;

namespace DCMSExampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MicroServiceCore.Init(typeof(Program));
        }
    }
}
