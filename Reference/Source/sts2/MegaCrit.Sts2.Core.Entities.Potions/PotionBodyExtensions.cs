namespace MegaCrit.Sts2.Core.Entities.Potions;

public static class PotionBodyExtensions
{
	public static extern string GetBodyPath(this PotionBody body);

	public static extern string? GetGradientPath(this PotionBody body);

	public static extern string GetJuicePath(this PotionBody body);

	public static extern string? GetOverlayPath(this PotionBody body, PotionOverlay overlay);
}
