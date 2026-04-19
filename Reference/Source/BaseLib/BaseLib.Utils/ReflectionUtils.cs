using System;
using System.Reflection;

namespace BaseLib.Utils;

public static class ReflectionUtils
{
	private const BindingFlags DeclaredOnlyLookup = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

	public static Action<T, TValue>? GetSetterForProperty<T, TValue>(string propName) where T : class
	{
		PropertyInfo property = typeof(T).GetProperty(propName, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if ((object)property == null)
		{
			BaseLibMain.Logger.Warn("Property " + propName + " not found in type " + typeof(T).FullName, 1);
			return null;
		}
		return GetPropertySetter(property);
		static Action<T, TValue> GetPropertySetter(PropertyInfo prop)
		{
			MethodInfo setter = prop.GetSetMethod(nonPublic: true);
			if ((object)setter != null)
			{
				return delegate(T obj, TValue value)
				{
					setter.Invoke(obj, new object[1] { value });
				};
			}
			FieldInfo backingField = prop.DeclaringType?.GetField("<" + prop.Name + ">k__BackingField", BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if ((object)backingField == null)
			{
				throw new InvalidOperationException($"Could not find a way to set {prop.DeclaringType?.FullName}.{prop.Name}. Try adding a private setter.");
			}
			return delegate(T obj, TValue value)
			{
				backingField.SetValue(obj, value);
			};
		}
	}
}
