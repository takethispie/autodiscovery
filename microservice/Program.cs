using System;
using System.Collections.Generic;

namespace microservice
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MicroServiceCore.Init(typeof(MainClass).Namespace,typeof(MainClass).Assembly);
		}
	}
}
