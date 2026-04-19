namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class RepeatVar : DynamicVar
{
	public const string defaultName = "Repeat";

	public extern RepeatVar(int times);

	public extern RepeatVar(string name, int times);
}
