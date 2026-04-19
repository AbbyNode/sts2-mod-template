using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.RestSite;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class RestSiteSynchronizer : IDisposable
{
	public const int minHoverMessageMsec = 50;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern event Action<ulong>? PlayerHoverChanged;

	public extern event Action<RestSiteOption, ulong>? BeforePlayerOptionChosen;

	public extern event Action<RestSiteOption, bool, ulong>? AfterPlayerOptionChosen;

	public extern RestSiteSynchronizer(RunLocationTargetedMessageBuffer messageBuffer, INetGameService netService, IPlayerCollection playerCollection, ulong localPlayerId);

	public extern void Dispose();

	public extern void BeginRestSite();

	public extern Task<bool> ChooseLocalOption(int index);

	public extern void LocalOptionHovered(RestSiteOption? option);

	public extern int? GetHoveredOptionIndex(ulong playerId);

	public extern int? GetChosenOptionIndex(ulong playerId);

	public extern IReadOnlyList<RestSiteOption> GetLocalOptions();

	public extern IReadOnlyList<RestSiteOption> GetOptionsForPlayer(ulong playerId);

	public extern IReadOnlyList<RestSiteOption> GetOptionsForPlayer(Player player);
}
