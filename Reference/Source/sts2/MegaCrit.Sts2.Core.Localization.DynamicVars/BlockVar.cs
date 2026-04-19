using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class BlockVar : DynamicVar
{
	public const string defaultName = "Block";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ValueProp Props
	{
		[CompilerGenerated]
		get;
	}

	public extern BlockVar(decimal block, ValueProp props);

	public extern BlockVar(string name, decimal block, ValueProp props);

	public override extern void UpdateCardPreview(CardModel card, CardPreviewMode previewMode, Creature? target, bool runGlobalHooks);
}
