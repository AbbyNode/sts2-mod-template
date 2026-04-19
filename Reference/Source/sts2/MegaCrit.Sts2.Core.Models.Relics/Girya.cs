using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Entities.RestSite;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class Girya : RelicModel
{
	public const int maxLifts = 3;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	[SavedProperty]
	public extern int TimesLifted { get; set; }

	public override extern bool IsAllowed(IRunState runState);

	[AsyncStateMachine(typeof(_003CAfterRoomEntered_003Ed__14))]
	public override extern Task AfterRoomEntered(AbstractRoom room);

	public override extern bool TryModifyRestSiteOptions(Player player, ICollection<RestSiteOption> options);

	public extern Girya();
}
