namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class IfUpgradedVar : DynamicVar
{
	public const string defaultName = "IfUpgraded";

	public UpgradeDisplay upgradeDisplay;

	public extern IfUpgradedVar(UpgradeDisplay upgradeDisplay);

	public extern IfUpgradedVar(string name, decimal amount);
}
