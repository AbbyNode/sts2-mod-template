using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class CrackedCore : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CBeforeSideTurnStart_003Ed__7))]
	public override extern Task BeforeSideTurnStart(PlayerChoiceContext choiceContext, CombatSide side, CombatState combatState);

	public extern CrackedCore();
}
