using System.Runtime.CompilerServices;
using Godot;
using Steamworks;

namespace MegaCrit.Sts2.Core.Platform.Steam;

public static class SteamInitializer
{
	public const ulong steamAppId = 2868840uL;

	public static extern bool Initialized
	{
		[CompilerGenerated]
		get;
	}

	public static extern ESteamAPIInitResult? InitResult
	{
		[CompilerGenerated]
		get;
	}

	public static extern string? InitErrorMessage
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool Initialize(Node node);

	public static extern void Uninitialize();
}
