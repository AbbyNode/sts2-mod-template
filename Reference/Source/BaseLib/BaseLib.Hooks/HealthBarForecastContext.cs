using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace BaseLib.Hooks;

/// <summary>
///     Runtime context passed to <see cref="T:BaseLib.Hooks.IHealthBarForecastSource" /> when resolving forecast segments.
/// </summary>
/// <param name="Creature">Creature whose health bar is being rendered.</param>
public readonly record struct HealthBarForecastContext(Creature Creature)
{
	/// <summary>
	///     Current combat state when the creature is in combat.
	/// </summary>
	public CombatState? CombatState => Creature.CombatState;

	/// <summary>
	///     Side whose turn is active when available.
	/// </summary>
	public CombatSide? CurrentSide
	{
		get
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			CombatState combatState = Creature.CombatState;
			if (combatState == null)
			{
				return null;
			}
			return combatState.CurrentSide;
		}
	}
}
