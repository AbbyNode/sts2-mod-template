namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class CardsVar : DynamicVar
{
	public const string defaultName = "Cards";

	public extern CardsVar(int cards);

	public extern CardsVar(string name, int cards);
}
