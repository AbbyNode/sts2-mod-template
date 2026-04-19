using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Entities.Players;

public class ExtraPlayerFields
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int CardShopRemovalsUsed
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int WongoPoints
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern SerializableExtraPlayerFields ToSerializable();

	public static extern ExtraPlayerFields FromSerializable(SerializableExtraPlayerFields save);

	public extern ExtraPlayerFields();
}
