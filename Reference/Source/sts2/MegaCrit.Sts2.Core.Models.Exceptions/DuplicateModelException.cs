using System;

namespace MegaCrit.Sts2.Core.Models.Exceptions;

public class DuplicateModelException : Exception
{
	public extern DuplicateModelException(Type t);
}
