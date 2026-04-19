namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class GoldVar : DynamicVar
{
	public const string defaultName = "Gold";

	public extern GoldVar(int gold);

	public extern GoldVar(string name, int gold);
}
