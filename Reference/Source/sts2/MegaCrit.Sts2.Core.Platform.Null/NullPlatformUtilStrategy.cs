using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Multiplayer.Game;

namespace MegaCrit.Sts2.Core.Platform.Null;

public class NullPlatformUtilStrategy : IPlatformUtilStrategy
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ulong LocalPlayerId
	{
		[CompilerGenerated]
		get;
	}

	public extern bool SupportsInviteDialog { get; }

	public extern NullPlatformUtilStrategy();

	public extern string GetPlayerName(ulong playerId);

	public extern ulong GetLocalPlayerId();

	public extern Task<IEnumerable<ulong>> GetFriendsWithOpenLobbies();

	public extern void OpenInviteDialog(INetGameService netService);

	public extern void OpenUrl(string url);

	public extern void OpenVirtualKeyboard();

	public extern void CloseVirtualKeyboard();

	public extern void SetRichPresence(string token, string? playerGroup, int? groupSize);

	public extern void SetRichPresenceValue(string key, string? value);

	public extern void ClearRichPresence();

	public extern string? GetPlatformBranch();

	public extern string? GetThreeLetterLanguageCode();

	public extern string GetRawLanguage();

	public extern SupportedWindowMode GetSupportedWindowMode();
}
