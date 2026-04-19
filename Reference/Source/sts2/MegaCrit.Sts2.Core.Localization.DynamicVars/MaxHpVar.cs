namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class MaxHpVar : DynamicVar
{
	public const string defaultName = "MaxHp";

	public extern MaxHpVar(decimal maxHp);

	public extern MaxHpVar(string name, decimal maxHp);
}
