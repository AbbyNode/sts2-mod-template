using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace BaseLib.Utils;

internal interface ISavedSpireField
{
	protected static readonly HashSet<Type> SupportedTypes = new HashSet<Type>
	{
		typeof(int),
		typeof(bool),
		typeof(string),
		typeof(ModelId),
		typeof(int[]),
		typeof(SerializableCard),
		typeof(SerializableCard[]),
		typeof(List<SerializableCard>)
	};

	string Name { get; }

	Type TargetType { get; }

	protected static bool IsTypeSupported(Type t)
	{
		if (!SupportedTypes.Contains(t) && !t.IsEnum)
		{
			if (t.IsArray)
			{
				return t.GetElementType().IsEnum;
			}
			return false;
		}
		return true;
	}

	void Export(object model, SavedProperties props);

	void Import(object model, SavedProperties props);
}
