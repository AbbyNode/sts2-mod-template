using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Rooms;

public class CombatEventVisuals : ICombatRoomVisuals
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern EncounterModel Encounter
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<Creature> Allies
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<Creature> Enemies { get; }

	public extern ActModel Act
	{
		[CompilerGenerated]
		get;
	}

	public extern CombatEventVisuals(EncounterModel encounter, IEnumerable<Player> players, ActModel act);
}
