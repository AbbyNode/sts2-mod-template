using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class ExtraDamageVar : DynamicVar
{
	public const string defaultName = "ExtraDamage";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsFromOsty
	{
		[CompilerGenerated]
		get;
	}

	public extern ExtraDamageVar FromOsty();

	public extern ExtraDamageVar(decimal damage);

	public override extern void UpdateCardPreview(CardModel card, CardPreviewMode previewMode, Creature? target, bool runGlobalHooks);
}
