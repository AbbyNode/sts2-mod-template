using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Entities.RestSite;

public sealed class HealRestSiteOption : RestSiteOption
{
	public override extern string OptionId { get; }

	public override extern IEnumerable<string> AssetPaths { get; }

	public override extern LocString Description { get; }

	public static extern decimal GetHealAmount(Player player);

	public extern HealRestSiteOption(Player owner);

	[AsyncStateMachine(typeof(_003COnSelect_003Ed__8))]
	public override extern Task<bool> OnSelect();

	[AsyncStateMachine(typeof(_003CDoLocalPostSelectVfx_003Ed__9))]
	public override extern Task DoLocalPostSelectVfx(CancellationToken ct = default(CancellationToken));

	public override extern Task DoRemotePostSelectVfx();

	public static extern decimal GetBaseHealAmount(Creature creature);

	public static extern void PlayRestSiteHealSfx();

	[AsyncStateMachine(typeof(_003CExecuteRestSiteHeal_003Ed__13))]
	public static extern Task ExecuteRestSiteHeal(Player player, bool isMimicked);
}
