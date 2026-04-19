using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class CalculatedBlockVar : CalculatedVar
{
	public const string defaultName = "CalculatedBlock";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ValueProp Props
	{
		[CompilerGenerated]
		get;
	}

	public extern CalculatedBlockVar(ValueProp props);

	public override extern void UpdateCardPreview(CardModel card, CardPreviewMode previewMode, Creature? target, bool runGlobalHooks);
}
