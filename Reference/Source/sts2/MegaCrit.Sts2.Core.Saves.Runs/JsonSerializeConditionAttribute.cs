using System;
using System.Text.Json.Serialization.Metadata;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class JsonSerializeConditionAttribute : Attribute
{
	public readonly SerializationCondition defaultBehaviour;

	public extern JsonSerializeConditionAttribute(SerializationCondition defaultBehaviour);

	public static extern void CheckJsonSerializeConditionsModifier(JsonTypeInfo typeInfo);
}
