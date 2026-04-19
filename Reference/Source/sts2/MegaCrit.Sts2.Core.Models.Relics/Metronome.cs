using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public class Metronome : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	protected override extern IEnumerable<DynamicVar> CanonicalVars { get; }

	public override extern Task AfterRoomEntered(AbstractRoom room);

	[AsyncStateMachine(typeof(_003CAfterOrbChanneled_003Ed__18))]
	public override extern Task AfterOrbChanneled(PlayerChoiceContext choiceContext, Player player, OrbModel orb);

	public override extern Task AfterCombatEnd(CombatRoom _);

	public extern Metronome();
}
