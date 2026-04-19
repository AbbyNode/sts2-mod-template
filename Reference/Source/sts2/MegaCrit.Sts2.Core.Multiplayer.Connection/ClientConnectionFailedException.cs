using System;
using MegaCrit.Sts2.Core.Entities.Multiplayer;

namespace MegaCrit.Sts2.Core.Multiplayer.Connection;

public class ClientConnectionFailedException : Exception
{
	public NetErrorInfo info;

	public extern ClientConnectionFailedException(string message, NetErrorInfo info);
}
