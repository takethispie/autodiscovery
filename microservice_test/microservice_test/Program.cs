using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DCmicroservice;
using System.Reflection;


namespace microservice_test
{
    class Program
    {
        static void Main(string[] args)
        {
            MicroServiceCore.Init(typeof(Program).Namespace, Assembly.GetExecutingAssembly());
            Console.WriteLine("Press key to quit...");
            Console.ReadKey();
        }
    }
}
