using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Entities.RestSite;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PaelsGrowth : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__6))]
	public override extern Task AfterObtained();

	public override extern bool TryModifyRestSiteOptions(Player player, ICollection<RestSiteOption> options);

	public extern PaelsGrowth();
}
