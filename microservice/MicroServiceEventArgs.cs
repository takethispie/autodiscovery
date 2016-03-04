using System;

namespace microservice
{
	public class MicroServiceEventArgs : EventArgs
	{
		public IMessage message;

		public MicroServiceEventArgs() { }
	}
}

