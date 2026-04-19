using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public static class SavedPropertiesTypeCache
{
	public static extern int NetIdBitSize
	{
		[CompilerGenerated]
		get;
	}

	public static extern int GetNetIdForPropertyName(string propertyName);

	public static extern string GetPropertyNameForNetId(int netId);

	public static extern List<PropertyInfo>? GetJsonPropertiesForType(Type t);

	public static extern void InjectTypeIntoCache([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties | DynamicallyAccessedMemberTypes.NonPublicProperties)] Type type);
}
