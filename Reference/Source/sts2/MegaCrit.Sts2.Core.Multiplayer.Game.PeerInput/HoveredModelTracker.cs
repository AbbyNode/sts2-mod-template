using System;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;

public class HoveredModelTracker
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern event Action<ulong>? HoverChanged;

	public extern HoveredModelTracker(PeerInputSynchronizer inputSynchronizer, IPlayerCollection playerCollection);

	public extern AbstractModel? GetHoveredModel(ulong playerId);

	public extern void OnLocalCardSelected(CardModel cardModel);

	public extern void OnLocalCardDeselected();

	public extern void OnLocalPotionSelected(PotionModel potionModel);

	public extern void OnLocalPotionDeselected();

	public extern void OnLocalCardHovered(CardModel cardModel);

	public extern void OnLocalCardUnhovered();

	public extern void OnLocalRelicHovered(RelicModel relicModel);

	public extern void OnLocalRelicUnhovered();

	public extern void OnLocalPotionHovered(PotionModel potionModel);

	public extern void OnLocalPotionUnhovered();
}
