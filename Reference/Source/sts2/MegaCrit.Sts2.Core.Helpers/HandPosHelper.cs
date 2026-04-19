using Godot;

namespace MegaCrit.Sts2.Core.Helpers;

public static class HandPosHelper
{
	public static extern Vector2 GetPosition(int handSize, int cardIndex);

	public static extern float GetAngle(int handSize, int cardIndex);

	public static extern Vector2 GetScale(int handSize);
}
