using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class OstyDamageVar : DynamicVar
{
	public const string defaultName = "OstyDamage";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ValueProp Props
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern OstyDamageVar(decimal damage, ValueProp props);

	public extern OstyDamageVar(string name, decimal damage, ValueProp props);

	public override extern void UpdateCardPreview(CardModel card, CardPreviewMode previewMode, Creature? target, bool runGlobalHooks);
}
