using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer;

public class CombatStateSynchronizer : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsDisabled
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern CombatStateSynchronizer(INetGameService netService, RunLobby? runLobby, RunState runState);

	public extern void Dispose();

	public extern void StartSync();

	[AsyncStateMachine(typeof(_003CWaitForSync_003Ed__18))]
	public extern Task WaitForSync();
}
