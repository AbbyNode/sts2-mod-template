using System;

namespace MegaCrit.Sts2.Core.Models.Exceptions;

public class CanonicalModelException : Exception
{
	public extern CanonicalModelException(Type t);
}
