namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class HpLossVar : DynamicVar
{
	public const string defaultName = "HpLoss";

	public extern HpLossVar(decimal hpLoss);

	public extern HpLossVar(string name, decimal hpLoss);
}
