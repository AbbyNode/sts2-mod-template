using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class NightTerrors : ModifierModel
{
	public override extern decimal ModifyRestSiteHealAmount(Creature creature, decimal amount);

	[AsyncStateMachine(typeof(_003CAfterRestSiteHeal_003Ed__2))]
	public override extern Task AfterRestSiteHeal(Player player, bool isMimicked);

	public override extern IReadOnlyList<LocString> ModifyExtraRestSiteHealText(Player player, IReadOnlyList<LocString> currentExtraText);

	public extern NightTerrors();
}
