using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Platform;

namespace MegaCrit.Sts2.Core.Saves;

public static class UserDataPathProvider
{
	public static extern string SavesDir { get; }

	public static extern bool IsRunningModded
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static extern string GetProfileScopedPath(int profileId, string dataType, PlatformType? platformOverride = null, ulong? userIdOverride = null);

	public static extern string GetProfileScopedBasePath(int profileId, PlatformType? platformOverride = null, ulong? userIdOverride = null);

	public static extern string GetAccountScopedBasePath(string? dataType, PlatformType? platformOverride = null, ulong? userIdOverride = null);

	public static extern string GetProfileDir(int profileId);

	public static extern string GetLegacyPreAccountPath(string dataType);

	public static extern string GetPlatformDirectoryName(PlatformType platform);

	public static extern bool IsLegacyPath(string path);
}
