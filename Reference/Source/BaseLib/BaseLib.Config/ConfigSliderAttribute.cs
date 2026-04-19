using System;

namespace BaseLib.Config;

/// <summary>
/// Specifies settings for a slider: range, step and label format string. Negative numbers are supported, as are
/// noninteger numbers.<br />
/// Supported property types: <see cref="T:System.Int32" />, <see cref="T:System.Single" />, <see cref="T:System.Double" />.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class ConfigSliderAttribute(double min = 0.0, double max = 100.0, double step = 1.0) : Attribute
{
	/// <summary>The minimum value the user can select.</summary>
	public double Min { get; } = min;

	/// <summary>The maximum value the user can select.</summary>
	public double Max { get; } = max;

	/// <summary>The smallest step between two values, and the amount moved by a quick controller input.</summary>
	public double Step { get; } = step;

	/// <summary>
	/// The string format to use for the slider's label.
	/// Uses standard C# format, see <see cref="M:System.String.Format(System.String,System.Object)" />.
	/// </summary>
	public string? Format { get; set; }
}
