using Godot;

namespace MegaCrit.Sts2.Core.Nodes.Vfx.Utilities;

public class ScreenPunchInstance : ShakeInstance
{
	public extern ScreenPunchInstance(float strength, double duration, float degAngle);

	public override extern Vector2 Update(double delta);

	public extern void Cancel();
}
