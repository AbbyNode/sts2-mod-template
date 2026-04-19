namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class BoolVar : DynamicVar
{
	public extern bool BoolVal { get; set; }

	public extern BoolVar(string name);

	public extern BoolVar(string name, bool value);
}
