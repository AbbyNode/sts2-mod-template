using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class BlessedAntler : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyMaxEnergy(Player player, decimal amount);

	[AsyncStateMachine(typeof(_003CBeforeHandDraw_003Ed__7))]
	public override extern Task BeforeHandDraw(Player player, PlayerChoiceContext choiceContext, CombatState combatState);

	public extern BlessedAntler();
}
