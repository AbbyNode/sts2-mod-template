using Godot;

namespace MegaCrit.Sts2.Core.Helpers;

public static class ScrollHelper
{
	public const float dragLerpSpeed = 15f;

	public const float snapThreshold = 0.5f;

	public const float bounceBackStrength = 12f;

	public static extern float GetDragForScrollEvent(InputEvent inputEvent);
}
