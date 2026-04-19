using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.GameActions;
using MegaCrit.Sts2.Core.Multiplayer.Replay;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class ChecksumTracker : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern uint NextId
	{
		[CompilerGenerated]
		get;
	}

	public extern event Action<NetFullCombatState>? StateDiverged;

	public extern event Action<NetChecksumData, string, NetFullCombatState>? ChecksumGenerated;

	public extern ChecksumTracker(INetGameService netService, IRunState runState);

	public extern void Dispose();

	public extern NetChecksumData GenerateChecksum(string context, GameAction? action);

	public extern void LoadReplayChecksums(List<ReplayChecksumData> replayChecksums, uint nextId);

	public extern uint GenerateChecksum(NetFullCombatState state);
}
