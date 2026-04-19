using System;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class SavedPropertyAttribute : Attribute
{
	public readonly SerializationCondition defaultBehaviour;

	public readonly int order;

	public extern SavedPropertyAttribute();

	public extern SavedPropertyAttribute(SerializationCondition defaultBehaviour);

	public extern SavedPropertyAttribute(SerializationCondition defaultBehaviour, int order);
}
