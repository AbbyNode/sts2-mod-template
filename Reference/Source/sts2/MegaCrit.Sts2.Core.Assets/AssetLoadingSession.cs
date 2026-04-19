using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Godot;

namespace MegaCrit.Sts2.Core.Assets;

public class AssetLoadingSession
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Task<bool> Task { get; }

	public extern bool IsCompleted { get; }

	public extern AssetLoadingSession(string name, IEnumerable<string> paths, ConcurrentDictionary<string, Resource> cache, AssetCache? assetCache = null);

	public static extern AssetLoadingSession Empty();

	public extern void Process();

	public extern void PrintStatus();

	public extern Task WaitForCompletion();
}
