using System;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class MapSelectionSynchronizer
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int MapGenerationCount
	{
		[CompilerGenerated]
		get;
	}

	public extern event Action<Player, MapVote?, MapVote?>? PlayerVoteChanged;

	public extern event Action<Player>? PlayerVoteCancelled;

	public extern event Action? PlayerVotesCleared;

	public extern MapSelectionSynchronizer(INetGameService netService, ActionQueueSynchronizer actionQueueSynchronizer, RunState runState);

	public extern void PlayerVotedForMapCoord(Player player, RunLocation source, MapVote? destination);

	public extern MapVote? GetVote(Player player);

	public extern void OnRunLocationChanged(RunLocation location);

	public extern void BeforeMapGenerated();
}
