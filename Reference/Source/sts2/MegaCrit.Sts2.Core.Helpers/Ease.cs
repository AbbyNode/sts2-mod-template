namespace MegaCrit.Sts2.Core.Helpers;

public static class Ease
{
	public enum Functions
	{
		QuadIn,
		QuadOut,
		QuadInOut,
		CubicIn,
		CubicOut,
		CubicInOut,
		QuartIn,
		QuartOut,
		QuartInOut,
		QuintIn,
		QuinOut,
		QuinInOut,
		SineIn,
		SineOut,
		SineInOut,
		CircIn,
		CircOut,
		CircInOut,
		ExpoIn,
		ExpoOut,
		ExpoInOut,
		ElasticIn,
		ElasticOut,
		ElasticInOut,
		BackIn,
		BackOut,
		BackInOut,
		BounceIn,
		BounceOut,
		BounceInOut
	}

	public static extern float Interpolate(float p, Functions function);

	public static extern float Linear(float p);

	public static extern float QuadIn(float p);

	public static extern float QuadOut(float p);

	public static extern float QuadInOut(float p);

	public static extern float CubicIn(float p);

	public static extern float CubicOut(float p);

	public static extern float CubicInOut(float p);

	public static extern float QuartIn(float p);

	public static extern float QuartOut(float p);

	public static extern float QuartInOut(float p);

	public static extern float QuintIn(float p);

	public static extern float QuintOut(float p);

	public static extern float QuintInOut(float p);

	public static extern float SineIn(float p);

	public static extern float SineOut(float p);

	public static extern float SineInOut(float p);

	public static extern float CircIn(float p);

	public static extern float CircOut(float p);

	public static extern float CircInOut(float p);

	public static extern float ExpoIn(float p);

	public static extern float ExpoOut(float p);

	public static extern float ExpoInOut(float p);

	public static extern float ElasticIn(float p);

	public static extern float ElasticOut(float p);

	public static extern float ElasticInOut(float p);

	public static extern float BackIn(float p, float strength = 1f);

	public static extern float BackOut(float p, float strength = 1f);

	public static extern float BackInOut(float p, float strength = 1f);

	public static extern float BounceIn(float p);

	public static extern float BounceOut(float p);

	public static extern float BounceInOut(float p);
}
