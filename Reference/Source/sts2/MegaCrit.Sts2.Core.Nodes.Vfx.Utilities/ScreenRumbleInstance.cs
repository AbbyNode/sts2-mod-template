using Godot;

namespace MegaCrit.Sts2.Core.Nodes.Vfx.Utilities;

public class ScreenRumbleInstance : ShakeInstance
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ScreenRumbleInstance(float strength, double duration, float speedMultiplier, RumbleStyle style);

	public override extern Vector2 Update(double delta);
}
