namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class StarsVar : DynamicVar
{
	public const string defaultName = "Stars";

	public extern StarsVar(int stars);

	public extern StarsVar(string name, int stars);
}
