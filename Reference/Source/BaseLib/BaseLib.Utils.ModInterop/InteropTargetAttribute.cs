using System;

namespace BaseLib.Utils.ModInterop;

/// <summary>
/// Type must be provided in this attribute or in the containing class's ModInteropAttribute.
/// If name is not provided, the name of the attached member will be used.
/// If targeting a class, Type and Name function identically.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public sealed class InteropTargetAttribute : Attribute
{
	public string? Type { get; }

	public string? Name { get; }

	public InteropTargetAttribute(string type, string? name = null)
	{
		Type = type;
		Name = name;
	}

	public InteropTargetAttribute(string? name = null)
	{
		Name = name;
	}
}
