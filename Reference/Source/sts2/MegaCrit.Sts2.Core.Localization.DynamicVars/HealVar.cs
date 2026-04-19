namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class HealVar : DynamicVar
{
	public const string defaultName = "Heal";

	public extern HealVar(decimal healAmount);

	public extern HealVar(string name, decimal healAmount);
}
