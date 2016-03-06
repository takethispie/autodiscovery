using System;

namespace DustCatMicroService
{
	/// <summary>
	/// Micro service event arguments.
	/// used to transmitt messages between services
	/// </summary>
	public class MicroServiceEventArgs : EventArgs
	{
		public IMessage message;

		public MicroServiceEventArgs() { }
	}
}

