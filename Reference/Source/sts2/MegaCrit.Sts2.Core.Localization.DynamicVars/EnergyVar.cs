using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class EnergyVar : DynamicVar
{
	public const string defaultName = "Energy";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string ColorPrefix
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern EnergyVar(int energy);

	public extern EnergyVar(string name, int energy);
}
