using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer;

public class PlayerChoiceSynchronizer : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<uint> ChoiceIds { get; }

	public extern event Action<Player, uint, NetPlayerChoiceResult>? PlayerChoiceReceived;

	public extern PlayerChoiceSynchronizer(INetGameService netService, IPlayerCollection players);

	public extern void Dispose();

	public extern uint ReserveChoiceId(Player player);

	public extern void SyncLocalChoice(Player player, uint choiceId, PlayerChoiceResult result);

	[AsyncStateMachine(typeof(_003CWaitForRemoteChoice_003Ed__15))]
	public extern Task<PlayerChoiceResult> WaitForRemoteChoice(Player player, uint choiceId);

	public extern void FastForwardChoiceIds(List<uint> choiceIds);

	public extern void ReceiveReplayChoice(Player player, uint choiceId, NetPlayerChoiceResult result);
}
