using System.Collections.Generic;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters.Mocks;

public sealed class MockPlatingEncounter : EncounterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RoomType RoomType { get; }

	public override extern bool IsDebugEncounter { get; }

	public extern int PlatingAmount { get; set; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public extern MockPlatingEncounter();
}
