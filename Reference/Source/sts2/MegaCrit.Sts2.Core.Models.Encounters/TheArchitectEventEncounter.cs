using System.Collections.Generic;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public class TheArchitectEventEncounter : EncounterModel
{
	protected override extern bool HasCustomBackground { get; }

	public override extern RoomType RoomType { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	protected override extern IReadOnlyList<(MonsterModel, string?)> GenerateMonsters();

	public extern TheArchitectEventEncounter();
}
