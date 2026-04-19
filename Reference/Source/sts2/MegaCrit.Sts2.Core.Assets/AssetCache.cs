using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.Assets;

public class AssetCache
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern TS GetAsset<TS>(string path) where TS : Resource;

	public extern void MarkAssetFailed(string path);

	public extern AssetLoadingSession CreateSession(string name, IEnumerable<string> paths);

	public extern void UnloadAssets(IEnumerable<string> assetsToUnloadSet);

	public extern void UnloadMissedCacheAssets();

	public extern IReadOnlySet<string> GetLoadedCacheAssets();

	public extern IEnumerable<string> GetCacheKeys();

	public extern PackedScene GetScene(string path);

	public extern Texture2D GetTexture2D(string path);

	public extern Material GetMaterial(string path);

	public extern CompressedTexture2D GetCompressedTexture2D(string path);

	public extern bool ContainsKey(string s);

	public extern void SetAsset(string path, Resource resource);

	public extern AssetCache();
}
