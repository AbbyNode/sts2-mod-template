using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Relics;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class RewardSynchronizer : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern RewardSynchronizer(RunLocationTargetedMessageBuffer messageBuffer, INetGameService gameService, IPlayerCollection playerCollection, ulong localPlayerId);

	public extern void Dispose();

	public extern void SyncLocalObtainedCard(CardModel card);

	public extern void SyncLocalSkippedCard(CardModel card);

	public extern void SyncLocalObtainedRelic(RelicModel relic);

	public extern void SyncLocalSkippedRelic(RelicModel relic);

	public extern void SyncLocalObtainedPotion(PotionModel potion);

	public extern void SyncLocalSkippedPotion(PotionModel potion);

	public extern void SyncLocalObtainedGold(int goldAmount);

	public extern void SyncLocalGoldLost(int goldLost);

	[AsyncStateMachine(typeof(_003CDoLocalCardRemoval_003Ed__21))]
	public extern Task<bool> DoLocalCardRemoval();

	public extern void SyncLocalPaelsWingSacrifice(PaelsWing paelsWing);
}
