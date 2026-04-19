namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class ForgeVar : DynamicVar
{
	public const string defaultName = "Forge";

	public extern ForgeVar(int forge);

	public extern ForgeVar(string name, int forge);
}
