using System;

namespace BaseLib.Config;

/// <summary>
/// Creates a new section in the ModConfig UI, where the next property will be the first entry after the section header.
/// </summary>
/// <param name="name">The LocString name. Will be transformed just like property names, so for "FirstSection", you need to
/// specify a value for YOURMOD-FIRST_SECTION.title in the localization file(s).</param>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public class ConfigSectionAttribute(string name) : Attribute
{
	public string Name { get; } = name;
}
