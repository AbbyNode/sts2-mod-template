using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Commands.Builders;

public sealed class AttackContext : IAsyncDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[AsyncStateMachine(typeof(_003CCreateAsync_003Ed__4))]
	public static extern Task<AttackContext> CreateAsync(CombatState combatState, CardModel cardSource);

	public extern void AddHit(IEnumerable<DamageResult> results);

	[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__6))]
	public extern ValueTask DisposeAsync();
}
