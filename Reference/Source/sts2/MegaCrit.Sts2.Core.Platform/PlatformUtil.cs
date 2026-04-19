using System.Collections.Generic;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Multiplayer.Game;

namespace MegaCrit.Sts2.Core.Platform;

public static class PlatformUtil
{
	public static extern PlatformType PrimaryPlatform { get; }

	public static extern string GetPlayerName(PlatformType platformType, ulong playerId);

	public static extern ulong GetLocalPlayerId(PlatformType platformType);

	public static extern Task<IEnumerable<ulong>> GetFriendsWithOpenLobbies(PlatformType platformType);

	public static extern bool SupportsInviteDialog(PlatformType platformType);

	public static extern void OpenInviteDialog(INetGameService netService);

	public static extern void OpenUrl(string url);

	public static extern void OpenVirtualKeyboard();

	public static extern void CloseVirtualKeyboard();

	public static extern string? GetPlatformBranch();

	public static extern string? GetThreeLetterLanguageCode();

	public static extern string GetRawLanguage();

	public static extern void SetRichPresence(string token, string? playerGroup, int? groupSize);

	public static extern void SetRichPresenceValue(string key, string? value);

	public static extern void ClearRichPresence();

	public static extern SupportedWindowMode GetSupportedWindowMode();
}
