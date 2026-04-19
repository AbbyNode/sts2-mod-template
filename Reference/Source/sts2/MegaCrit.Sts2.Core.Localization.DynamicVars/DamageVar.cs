using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class DamageVar : DynamicVar
{
	public const string defaultName = "Damage";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ValueProp Props
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern DamageVar(decimal damage, ValueProp props);

	public extern DamageVar(string name, decimal damage, ValueProp props);

	public override extern void UpdateCardPreview(CardModel card, CardPreviewMode previewMode, Creature? target, bool runGlobalHooks);
}
