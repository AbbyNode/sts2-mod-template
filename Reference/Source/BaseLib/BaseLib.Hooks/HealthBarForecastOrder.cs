using System;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace BaseLib.Hooks;

/// <summary>
///     Helpers for turn-relative <see cref="P:BaseLib.Hooks.HealthBarForecastSegment.Order" /> values shared by multiple sources.
/// </summary>
public static class HealthBarForecastOrder
{
	/// <summary>
	///     Returns an order key for effects that resolve at the start of <paramref name="triggerSide" />'s turn.
	/// </summary>
	/// <param name="creature">Creature used to read the active combat side.</param>
	/// <param name="triggerSide">Side whose turn start is being modeled.</param>
	/// <returns>Higher value when it is currently that side's turn (segments stack after others).</returns>
	public static int ForSideTurnStart(Creature creature, CombatSide triggerSide)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull(creature, "creature");
		CombatState combatState = creature.CombatState;
		return (combatState != null && combatState.CurrentSide == triggerSide) ? 1 : 0;
	}

	/// <summary>
	///     Returns an order key for effects that resolve at the end of <paramref name="triggerSide" />'s turn.
	/// </summary>
	/// <param name="creature">Creature used to read the active combat side.</param>
	/// <param name="triggerSide">Side whose turn end is being modeled.</param>
	/// <returns>Higher value when it is not currently that side's turn.</returns>
	public static int ForSideTurnEnd(Creature creature, CombatSide triggerSide)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull(creature, "creature");
		CombatState combatState = creature.CombatState;
		return (combatState == null || combatState.CurrentSide != triggerSide) ? 1 : 0;
	}
}
