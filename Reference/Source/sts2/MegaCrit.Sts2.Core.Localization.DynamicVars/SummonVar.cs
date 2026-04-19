using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class SummonVar : DynamicVar
{
	public const string defaultName = "Summon";

	public extern SummonVar(decimal summonAmount);

	public extern SummonVar(string name, decimal summonAmount);

	public override extern void UpdateCardPreview(CardModel card, CardPreviewMode previewMode, Creature? target, bool runGlobalHooks);
}
