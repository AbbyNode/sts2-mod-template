using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Commands;

public static class PowerCmd
{
	[AsyncStateMachine(typeof(_003CApply_003Ed__0<>))]
	public static extern Task<IReadOnlyList<T>> Apply<T>(IEnumerable<Creature> targets, decimal amount, Creature? applier, CardModel? cardSource, bool silent = false) where T : PowerModel;

	[AsyncStateMachine(typeof(_003CApply_003Ed__1<>))]
	public static extern Task<T?> Apply<T>(Creature target, decimal amount, Creature? applier, CardModel? cardSource, bool silent = false) where T : PowerModel;

	[AsyncStateMachine(typeof(_003CApply_003Ed__2))]
	public static extern Task Apply(PowerModel power, Creature target, decimal amount, Creature? applier, CardModel? cardSource, bool silent = false);

	[AsyncStateMachine(typeof(_003CDecrement_003Ed__3))]
	public static extern Task Decrement(PowerModel power);

	[AsyncStateMachine(typeof(_003CTickDownDuration_003Ed__4))]
	public static extern Task TickDownDuration(PowerModel power);

	[AsyncStateMachine(typeof(_003CModifyAmount_003Ed__5))]
	public static extern Task<int> ModifyAmount(PowerModel power, decimal offset, Creature? applier, CardModel? cardSource, bool silent = false);

	[AsyncStateMachine(typeof(_003CSetAmount_003Ed__6<>))]
	public static extern Task<T?> SetAmount<T>(Creature target, decimal amount, Creature? applier, CardModel? cardSource) where T : PowerModel;

	[AsyncStateMachine(typeof(_003CRemove_003Ed__7<>))]
	public static extern Task Remove<T>(Creature creature) where T : PowerModel;

	[AsyncStateMachine(typeof(_003CRemove_003Ed__8))]
	public static extern Task Remove(PowerModel? power);
}
