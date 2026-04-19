using System;

namespace MegaCrit.Sts2.Core.Models.Exceptions;

public class MutableModelException : Exception
{
	public extern MutableModelException(Type t);
}
