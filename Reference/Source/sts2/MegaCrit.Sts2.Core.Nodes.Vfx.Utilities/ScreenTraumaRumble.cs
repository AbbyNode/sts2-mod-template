using Godot;

namespace MegaCrit.Sts2.Core.Nodes.Vfx.Utilities;

public class ScreenTraumaRumble
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ScreenTraumaRumble();

	public extern void AddTrauma(ShakeStrength amount);

	public extern Vector2 Update(double delta);

	public extern void SetMultiplier(float multiplier);
}
