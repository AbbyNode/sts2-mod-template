using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class CalculatedDamageVar : CalculatedVar
{
	public const string defaultName = "CalculatedDamage";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ValueProp Props
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsFromOsty
	{
		[CompilerGenerated]
		get;
	}

	public extern CalculatedDamageVar(ValueProp props);

	public extern CalculatedDamageVar FromOsty();

	public override extern void UpdateCardPreview(CardModel card, CardPreviewMode previewMode, Creature? target, bool runGlobalHooks);

	protected override extern DynamicVar GetExtraVar();
}
