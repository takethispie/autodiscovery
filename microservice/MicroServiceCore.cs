using System;
using System.Reflection;
using Microsoft.CSharp;
using System.Collections.Generic;

namespace DustCatMicroService
{
    public static class MicroServiceCore
    {
        /// <summary>
        /// list of service
        /// </summary>
        static List<Type> ServiceName = new List<Type>();

        /// <summary>
        /// list of bus
        /// </summary>
        static Dictionary<string, MicroServiceBus> busList = new Dictionary<string, MicroServiceBus>();

        /// <summary>
        /// list of all service inside the program
        /// </summary>
        public static List<MicroService> services = new List<MicroService>();


        static MicroServiceCore()
        {
            //add default bus
            busList.Add("Main", new MicroServiceBus());
        }


        /// <summary>
        /// auto-discover all available services 
        /// </summary>
        /// <param name="namespace">namespace where the service are running</param>
        /// <param name="ass">assembly of the running program</param>
        public static void Init(Type type)
        {
            string @namespace = type.Namespace;
            Assembly assembly = type.Assembly;
            MicroService current;
            var q = assembly.GetTypes();
            foreach (Type t in q)
            {
                if (t.Namespace == @namespace && t.IsClass && t.BaseType == typeof(MicroService))
                {
                    ServiceName.Add(t);
                    //invoke new service instance
                    //current = (MicroService)Activator.CreateInstance(Type.GetType(t.Namespace + "." + t.Name));
                    current = (MicroService)Activator.CreateInstance(assembly.GetType(t.FullName));

                    if (busList.ContainsKey(current.baseBusName))
                    {
                        busList[current.baseBusName].sendToService += current.receive;
                        current.addSendToBus(busList[current.baseBusName].receiveFromService);
                    }
                    else {
                        //check that service want to be connected to a message bus
                        if (current.baseBusName != null || current.baseBusName != string.Empty)
                        {
                            busList.Add(current.baseBusName, new MicroServiceBus());
                            busList[current.baseBusName].sendToService += current.receive;
                            current.addSendToBus(busList[current.baseBusName].receiveFromService);
                        }
                    }

                    if (current.StartServiceAtProgramStartup)
                    {
                        current.InitService();
                    }

                    //debug
                    //Console.WriteLine(t.Name + " service has Id:" + current.Id + " Running: " + current.started);
                    services.Add(current);
                }
            }
        }
        //
    }
}

