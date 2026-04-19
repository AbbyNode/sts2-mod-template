using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Models;

public abstract class CardPoolModel : AbstractModel, IPoolModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public abstract string Title { get; }

	public abstract string EnergyColorName { get; }

	public abstract string CardFrameMaterialPath { get; }

	public extern string FrameMaterialPath { get; }

	public extern Material FrameMaterial { get; }

	public abstract Color DeckEntryCardColor { get; }

	public virtual extern Color EnergyOutlineColor { get; }

	public extern string EnergyIconPath { get; }

	public virtual extern IEnumerable<CardModel> AllCards { get; }

	public extern IEnumerable<ModelId> AllCardIds { get; }

	public abstract bool IsColorless { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	protected abstract CardModel[] GenerateAllCards();

	public extern IEnumerable<CardModel> GetUnlockedCards(UnlockState unlockState, CardMultiplayerConstraint multiplayerConstraint);

	protected virtual extern IEnumerable<CardModel> FilterThroughEpochs(UnlockState unlockState, IEnumerable<CardModel> cards);

	public extern CardPoolModel ToMutable();

	protected extern CardPoolModel();
}
