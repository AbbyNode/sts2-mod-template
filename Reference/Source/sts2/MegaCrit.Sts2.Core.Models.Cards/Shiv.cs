using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Shiv : CardModel
{
	public override extern TargetType TargetType { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern Shiv();

	[AsyncStateMachine(typeof(_003CCreateInHand_003Ed__11))]
	public static extern Task<CardModel?> CreateInHand(Player owner, CombatState combatState);

	[AsyncStateMachine(typeof(_003CCreateInHand_003Ed__12))]
	public static extern Task<IEnumerable<CardModel>> CreateInHand(Player owner, int count, CombatState combatState);
}
