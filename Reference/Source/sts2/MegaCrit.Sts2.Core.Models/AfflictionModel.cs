using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models;

public abstract class AfflictionModel : AbstractModel
{
	public const string locTable = "afflictions";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern LocString Title { get; }

	public extern LocString Description { get; }

	public extern LocString ExtraCardText { get; }

	public virtual extern bool HasExtraCardText { get; }

	public extern LocString DynamicDescription { get; }

	public extern LocString? DynamicExtraCardText { get; }

	public extern string OverlayPath { get; }

	public extern bool HasOverlay { get; }

	public extern CardModel Card { get; set; }

	public extern bool HasCard { get; }

	public extern int Amount { get; set; }

	public extern CombatState CombatState { get; }

	public virtual extern bool CanAfflictUnplayableCards { get; }

	public virtual extern bool IsStackable { get; }

	public extern AfflictionModel CanonicalInstance { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	protected virtual extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public extern HoverTip HoverTip { get; }

	public extern IEnumerable<IHoverTip> HoverTips { get; }

	public extern event Action<int, int>? AmountChanged;

	public extern Control CreateOverlay();

	public virtual extern bool CanAfflictCardType(CardType cardType);

	public virtual extern bool CanAfflict(CardModel card);

	public virtual extern void AfterApplied();

	public virtual extern void BeforeRemoved();

	public virtual extern Task OnPlay(PlayerChoiceContext choiceContext, Creature? target);

	public extern AfflictionModel ToMutable();

	protected override extern void AfterCloned();

	public extern IReadOnlyList<CardModel> PickRandomTargets(RunRngSet rngSet, IEnumerable<CardModel> cards, int count);

	public extern void ClearInternal();

	protected extern AfflictionModel();
}
