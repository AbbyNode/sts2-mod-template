using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class Soul : CardModel
{
	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern Soul();

	[AsyncStateMachine(typeof(_003CCreateInHand_003Ed__5))]
	public static extern Task<IEnumerable<Soul>> CreateInHand(Player owner, int amount, CombatState combatState);

	public static extern IEnumerable<Soul> Create(Player owner, int amount, CombatState combatState);
}
