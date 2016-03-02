using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DCmicroservice
{
    public static class MicroServiceCore
    {
        static Dictionary<string,MicroServiceBus> MicroSBUS = new Dictionary<string, MicroServiceBus>();
        static List<Type> serviceNames = new List<Type>();
        public static List<MicroService> services = new List<MicroService>();

        static MicroServiceCore()
        {
            MicroSBUS.Add("Main", new MicroServiceBus("Main"));
        }

        public static void Init(string @namespace, Assembly ass)
        {
            var q = from t in ass.GetTypes()
                    where t.IsClass && t.Namespace == @namespace && t.BaseType == typeof(MicroService)
                    select t;
            q.ToList().ForEach(t => Console.WriteLine(t.Name));
            serviceNames = q.ToList();
        }
    }
}
