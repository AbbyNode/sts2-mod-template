using System;

namespace BaseLib.Patches.Content;

/// <summary>
/// Marks a field as intended to contain a new generated enum value.
/// Certain types of enums have additional functionality. Currently: CardKeyword, PileType
/// </summary>
/// <param name="name">This is relevant only if the field is intended to be a keyword. If not supplied, field name will be used.</param>
[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public sealed class CustomEnumAttribute(string? name = null) : Attribute
{
	public string? Name { get; } = name;
}
