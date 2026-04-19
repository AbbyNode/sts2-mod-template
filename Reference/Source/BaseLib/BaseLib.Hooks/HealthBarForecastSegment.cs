using Godot;

namespace BaseLib.Hooks;

/// <summary>
///     One forecast overlay segment for a creature health bar.
/// </summary>
/// <param name="Amount">HP amount represented by this segment.</param>
/// <param name="Color">
///     Lethal HP label theming; also used as the forecast nine-patch <see cref="P:Godot.CanvasItem.SelfModulate" /> when
///     <see cref="P:BaseLib.Hooks.HealthBarForecastSegment.OverlaySelfModulate" /> is null.
/// </param>
/// <param name="Direction">Which edge the segment grows from.</param>
/// <param name="Order">
///     Lower values are rendered earlier in the chain.
///     For <see cref="F:BaseLib.Hooks.HealthBarForecastDirection.FromRight" />, earlier segments stay closer to the current HP edge; for
///     <see cref="F:BaseLib.Hooks.HealthBarForecastDirection.FromLeft" />, earlier segments stay closer to the empty edge.
/// </param>
/// <param name="OverlayMaterial">
///     Optional Godot material (e.g. shader like vanilla doom). When null, only <see cref="P:BaseLib.Hooks.HealthBarForecastSegment.Color" /> tint applies.
/// </param>
/// <param name="OverlaySelfModulate">
///     Optional <see cref="P:Godot.CanvasItem.SelfModulate" /> for the forecast nine-patch. When null, <see cref="P:BaseLib.Hooks.HealthBarForecastSegment.Color" /> is
///     used
///     for both overlay tint and lethal HP label; when set, <see cref="P:BaseLib.Hooks.HealthBarForecastSegment.Color" /> is still used for lethal label theming.
/// </param>
public readonly record struct HealthBarForecastSegment(int Amount, Color Color, HealthBarForecastDirection Direction, int Order, Material? OverlayMaterial, Color? OverlaySelfModulate = null)
{
	/// <summary>
	///     Initializes a segment without overlay material or separate overlay modulate.
	/// </summary>
	public HealthBarForecastSegment(int amount, Color color, HealthBarForecastDirection direction, int order = 0)
		: this(amount, color, direction, order, null, null)
	{
	}//IL_0002: Unknown result type (might be due to invalid IL or missing references)


	/// <summary>
	///     Initializes a segment with an optional <see cref="P:BaseLib.Hooks.HealthBarForecastSegment.OverlayMaterial" /> and default overlay modulate.
	/// </summary>
	public HealthBarForecastSegment(int amount, Color color, HealthBarForecastDirection direction, int order, Material? overlayMaterial)
		: this(amount, color, direction, order, overlayMaterial, null)
	{
	}//IL_0002: Unknown result type (might be due to invalid IL or missing references)

}
