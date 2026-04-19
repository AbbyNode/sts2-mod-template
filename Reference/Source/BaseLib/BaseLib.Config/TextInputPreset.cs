namespace BaseLib.Config;

/// <summary>
/// Defines a set of allowed characters for a LineEdit.
/// </summary>
public enum TextInputPreset
{
	/// <summary>The default. No validation at all.</summary>
	Anything,
	/// <summary>English letters and numbers (a-z, A-Z, 0-9).</summary>
	Alphanumeric,
	/// <summary>English letters, numbers (a-z, A-Z, 0-9) and spaces.</summary>
	AlphanumericWithSpaces,
	/// <summary>Allows international letters, numbers, spaces, underscores, and hyphens.</summary>
	SafeDisplayName
}
