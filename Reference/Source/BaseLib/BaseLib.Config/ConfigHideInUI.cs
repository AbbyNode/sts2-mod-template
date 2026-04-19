using System;

namespace BaseLib.Config;

/// <summary>
/// Saves and loads this property to the config file normally, but generates no UI for it in SimpleModConfig.<br />
/// Intended for when you want to create the UI manually, or easily persist things that aren't user-configurable (e.g.
/// total gold gained / number of runs played with the mod active).
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ConfigHideInUI : Attribute
{
}
