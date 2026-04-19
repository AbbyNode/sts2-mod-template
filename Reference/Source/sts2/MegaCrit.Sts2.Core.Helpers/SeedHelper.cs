namespace MegaCrit.Sts2.Core.Helpers;

public static class SeedHelper
{
	public const int seedDefaultLength = 10;

	public static extern string GetRandomSeed(int length = 10);

	public static extern string CanonicalizeSeed(string seed);
}
