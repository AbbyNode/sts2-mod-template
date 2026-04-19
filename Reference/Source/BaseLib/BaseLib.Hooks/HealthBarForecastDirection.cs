namespace BaseLib.Hooks;

/// <summary>
///     Which edge of the health bar a forecast segment grows from.
/// </summary>
public enum HealthBarForecastDirection
{
	/// <summary>
	///     Grows inward from the current HP edge (e.g. poison-style).
	/// </summary>
	FromRight,
	/// <summary>
	///     Grows outward from the empty side (e.g. doom-style).
	/// </summary>
	FromLeft
}
