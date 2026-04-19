using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class LunarPastry : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__4))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern LunarPastry();
}
