using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.TreasureRelicPicking;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class TreasureRoomRelicSynchronizer
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<RelicModel>? CurrentRelics { get; }

	public extern event Action? VotesChanged;

	public extern event Action<List<RelicPickingResult>>? RelicsAwarded;

	public extern TreasureRoomRelicSynchronizer(IPlayerCollection playerCollection, ulong localPlayerId, ActionQueueSynchronizer actionQueueSynchronizer, RelicGrabBag sharedGrabBag, Rng rng);

	public extern void BeginRelicPicking();

	public extern void PickRelicLocally(int index);

	public extern void OnPicked(Player player, int index);

	public extern int? GetPlayerVote(Player player);

	public extern void CompleteWithNoRelics();
}
