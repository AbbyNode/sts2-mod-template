using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;

namespace BaseLib.Extensions;

public static class TypeExtensions
{
	private static Dictionary<Type, List<FieldInfo>> _declaredFields = new Dictionary<Type, List<FieldInfo>>();

	/// <summary>
	/// Finds a field in a generated state machine class for an async method, given the
	/// state machine type and the name of the original field.
	/// </summary>
	/// <param name="type"></param>
	/// <param name="originalFieldName"></param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentException"></exception>
	public static FieldInfo FindStateMachineField(this Type type, string originalFieldName)
	{
		string value = "<" + originalFieldName + ">";
		if (!_declaredFields.TryGetValue(type, out List<FieldInfo> value2))
		{
			value2 = AccessToolsExtensions.GetDeclaredFields(type);
		}
		foreach (FieldInfo item in value2)
		{
			if (item.Name.StartsWith(value))
			{
				return item;
			}
			if (item.Name.Equals(originalFieldName))
			{
				return item;
			}
		}
		throw new ArgumentException($"No matching field found in type {type} for name {originalFieldName}");
	}
}
