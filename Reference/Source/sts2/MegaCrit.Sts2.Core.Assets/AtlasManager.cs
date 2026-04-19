using Godot;

namespace MegaCrit.Sts2.Core.Assets;

public static class AtlasManager
{
	public static extern void LoadAllAtlases();

	public static extern void LoadEssentialAtlases();

	public static extern void LoadAtlas(string atlasName);

	public static extern AtlasTexture? GetSprite(string atlasName, string spriteName);

	public static extern bool HasSprite(string atlasName, string spriteName);

	public static extern int GetSpriteCount(string atlasName);

	public static extern bool IsAtlasLoaded(string atlasName);

	public static extern void Clear();
}
