using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace MegaCrit.Sts2.Core.Helpers;

public static class ReflectionHelper
{
	public const BindingFlags allAccessLevels = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

	public static extern bool SubtypesAvailable { get; }

	public static extern Type[] AllTypes { get; }

	public static extern Type[] ModTypes { get; }

	public static extern IEnumerable<Type> GetSubtypes(Type parentType);

	public static extern IEnumerable<Type> GetSubtypesInMods(Type parentType);

	public static extern IEnumerable<Type> GetSubtypes<T>() where T : class;

	public static extern IEnumerable<Type> GetSubtypesInMods<T>() where T : class;

	public static extern bool InheritsOrImplements([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.Interfaces)] Type derived, Type baseType);
}
