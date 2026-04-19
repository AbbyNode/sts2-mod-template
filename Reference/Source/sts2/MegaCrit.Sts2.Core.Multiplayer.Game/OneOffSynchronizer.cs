using System;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class OneOffSynchronizer : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern OneOffSynchronizer(RunLocationTargetedMessageBuffer messageBuffer, INetGameService gameService, IPlayerCollection playerCollection, ulong localPlayerId);

	public extern void Dispose();

	public extern Task<bool> DoLocalMerchantCardRemoval(int goldCost, bool cancelable = true);

	public extern Task<int> DoLocalTreasureRoomRewards();
}
