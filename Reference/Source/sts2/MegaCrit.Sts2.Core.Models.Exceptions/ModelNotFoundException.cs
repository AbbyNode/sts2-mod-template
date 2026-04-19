using System;

namespace MegaCrit.Sts2.Core.Models.Exceptions;

public class ModelNotFoundException : Exception
{
	public extern ModelNotFoundException(ModelId id);
}
