using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class StringVar : DynamicVar
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string StringValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern StringVar(string name, string baseValue = "");

	public override extern string ToString();
}
