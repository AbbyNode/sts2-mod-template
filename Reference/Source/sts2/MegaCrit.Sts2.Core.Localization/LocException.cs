using System;

namespace MegaCrit.Sts2.Core.Localization;

public class LocException : Exception
{
	public extern LocException(string message);

	public extern LocException(string message, Exception e);
}
