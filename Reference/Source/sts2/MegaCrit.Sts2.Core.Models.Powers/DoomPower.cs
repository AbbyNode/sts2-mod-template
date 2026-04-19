using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class DoomPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern Color AmountLabelColor { get; }

	[AsyncStateMachine(typeof(_003CDoomKill_003Ed__6))]
	public static extern Task DoomKill(IReadOnlyList<Creature> creatures);

	public static extern IReadOnlyList<Creature> GetDoomedCreatures(IReadOnlyList<Creature> creatures);

	public extern bool IsOwnerDoomed();

	[AsyncStateMachine(typeof(_003CBeforeTurnEnd_003Ed__9))]
	public override extern Task BeforeTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern DoomPower();
}
