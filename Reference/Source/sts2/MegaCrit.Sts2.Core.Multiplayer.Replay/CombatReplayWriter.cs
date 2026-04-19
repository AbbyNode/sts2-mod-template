using System;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Multiplayer.Replay;

public class CombatReplayWriter : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsEnabled
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool IsRecordingReplay { get; }

	public extern CombatReplayWriter(PlayerChoiceSynchronizer playerChoiceSynchronizer, ActionQueueSet actionQueueSet, ActionQueueSynchronizer actionQueueSynchronizer, ChecksumTracker checksumTracker);

	public extern void Dispose();

	public extern void RecordInitialState(SerializableRun serializableRun);

	public extern void WriteReplay(string filePath, bool stopRecording);

	public extern void StopRecording();
}
