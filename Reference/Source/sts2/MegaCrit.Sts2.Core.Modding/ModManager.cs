using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Modding;

public static class ModManager
{
	public delegate void MetricsUploadHook(SerializableRun run, bool isVictory, ulong localPlayerId);

	public static extern IReadOnlyList<Mod> AllMods { get; }

	public static extern IReadOnlyList<Mod> LoadedMods { get; }

	public static extern bool PlayerAgreedToModLoading { get; }

	public static extern event Action<Mod>? OnModDetected;

	public static extern event MetricsUploadHook? OnMetricsUpload;

	public static extern void Initialize(IModManagerFileIo fileIo, ModSettings? settings);

	public static extern void ResetForTests();

	[IteratorStateMachine(typeof(_003CGetModdedLocTables_003Ed__31))]
	public static extern IEnumerable<string> GetModdedLocTables(string language, string file);

	public static extern List<string>? GetGameplayRelevantModNameList();

	public static extern void CallMetricsHooks(SerializableRun run, bool isVictory, ulong localPlayerId);

	public static extern void Dispose();
}
