using System;
using System.Reflection;
using Microsoft.CSharp;
using System.Collections.Generic;

namespace microservice
{
	public static class MicroServiceCore
	{
		static List<Type> ServiceName = new List<Type>();
		static Dictionary<string,MicroServiceBus> busList = new Dictionary<string, MicroServiceBus>();
		static List<MicroService> services = new List<MicroService>();
		static MicroService current;

		static MicroServiceCore ()
		{ 
			//add default bus
			busList.Add("Main",new MicroServiceBus());
		}

		public static void Init(string @namespace,Assembly ass)
		{	
			var q = ass.GetTypes();
			foreach(Type t in q)
			{
				if(t.Namespace == @namespace && t.IsClass && t.BaseType == typeof(MicroService))
				{ 
					ServiceName.Add(t); 
					//debug
					Console.WriteLine(t.Name);
					//invoke new service instance
					current = (MicroService)Activator.CreateInstance(Type.GetType(t.Namespace + "." + t.Name));

					if(busList.ContainsKey(current.baseBusName))
					{
						busList[current.baseBusName].sendToService += current.receive;
						current.addSendToBus(busList[current.baseBusName].receiveFromService);
					}
					else
					{
						//check that service want to be connected to a message bus
						if(current.baseBusName != null || current.baseBusName != string.Empty)
						{
							busList.Add(current.baseBusName,new MicroServiceBus());
							busList[current.baseBusName].sendToService += current.receive;
							current.addSendToBus(busList[current.baseBusName].receiveFromService);
						}
					}

					if(current.StartServiceAtProgramStartup)
					{ current.InitService(); }

					services.Add(current);
				}
			}
		}
		//
	}
}

