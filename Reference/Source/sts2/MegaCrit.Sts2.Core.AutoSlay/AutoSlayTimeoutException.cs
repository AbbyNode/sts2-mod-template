using System;

namespace MegaCrit.Sts2.Core.AutoSlay;

public class AutoSlayTimeoutException : TimeoutException
{
	public extern AutoSlayTimeoutException(string message);
}
