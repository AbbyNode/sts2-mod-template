using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class ActChangeSynchronizer
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ActChangeSynchronizer(RunState runState);

	public extern void SetLocalPlayerReady();

	public extern bool IsWaitingForOtherPlayers();

	public extern void OnPlayerReady(Player player);
}
