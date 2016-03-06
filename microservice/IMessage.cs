using System;
using System.Collections.Generic;

namespace DustCatMicroService
{
	public interface IMessage
	{
		string header{ get; set; }
		string content { get; set; }
		string TargetName { get; set; }
		short TargetId { get; set; }
	}
}

