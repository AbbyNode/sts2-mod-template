using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.HoverTips;

public class CardHoverTip : IHoverTip
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CardModel Card
	{
		[CompilerGenerated]
		get;
	}

	public extern string Id
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsSmart { get; }

	public extern bool IsDebuff { get; }

	public extern bool IsInstanced { get; }

	public extern AbstractModel CanonicalModel { get; }

	public extern CardHoverTip(CardModel card);
}
