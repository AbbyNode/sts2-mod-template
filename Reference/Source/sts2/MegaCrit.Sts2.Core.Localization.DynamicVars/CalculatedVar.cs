using System;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Localization.DynamicVars;

public class CalculatedVar : DynamicVar
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CalculatedVar(string name);

	public override extern void SetOwner(AbstractModel owner);

	public extern CalculatedVar WithMultiplier(Func<CardModel, Creature?, decimal> multiplierCalc);

	public extern decimal Calculate(Creature? target);

	public extern void RecalculateForUpgradeOrEnchant();

	public override extern void UpdateCardPreview(CardModel card, CardPreviewMode previewMode, Creature? target, bool runGlobalHooks);

	protected virtual extern DynamicVar GetBaseVar();

	protected virtual extern DynamicVar GetExtraVar();

	protected override extern decimal GetBaseValueForIConvertible();

	public override extern string ToString();
}
