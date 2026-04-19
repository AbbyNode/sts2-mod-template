namespace MegaCrit.Sts2.Core.Platform;

public static class StatsManager
{
	public static extern void RefreshGlobalStats();

	public static extern void IncrementArchitectDamage(int score);

	public static extern long GetPersonalArchitectDamage();

	public static extern long? GetGlobalArchitectDamage();
}
