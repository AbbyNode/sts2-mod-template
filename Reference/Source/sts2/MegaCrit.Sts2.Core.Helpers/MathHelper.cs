using Godot;

namespace MegaCrit.Sts2.Core.Helpers;

public static class MathHelper
{
	public const float degToRad = 0.0174533f;

	public static extern float Remap(float value, float from1, float to1, float from2, float to2);

	public static extern Vector2 BezierCurve(Vector2 v0, Vector2 v1, Vector2 c0, float t);

	public static extern float GetAngle(Vector2 vector);

	public static extern Vector2 Clamp(Vector2 input, float min, float max);

	public static extern float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float deltaTime, float maxSpeed = float.PositiveInfinity);

	public static extern Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float deltaTime, float maxSpeed = float.PositiveInfinity);
}
