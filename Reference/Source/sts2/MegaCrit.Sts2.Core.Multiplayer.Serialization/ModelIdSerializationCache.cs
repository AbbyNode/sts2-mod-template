using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Multiplayer.Serialization;

public static class ModelIdSerializationCache
{
	public static extern int CategoryIdBitSize
	{
		[CompilerGenerated]
		get;
	}

	public static extern int EntryIdBitSize
	{
		[CompilerGenerated]
		get;
	}

	public static extern int EpochIdBitSize
	{
		[CompilerGenerated]
		get;
	}

	public static extern int MaxCategoryId { get; }

	public static extern int MaxEntryId { get; }

	public static extern int MaxEpochId { get; }

	public static extern uint Hash
	{
		[CompilerGenerated]
		get;
	}

	public static extern void Init();

	public static extern int GetNetIdForCategory(string category);

	public static extern string GetCategoryForNetId(int netId);

	public static extern int GetNetIdForEntry(string entry);

	public static extern bool TryGetNetIdForEntry(string entry, out int netId);

	public static extern string GetEntryForNetId(int netId);

	public static extern int GetNetIdForEpochId(string epochId);

	public static extern string GetEpochIdForNetId(int netId);

	public static extern string Dump();
}
