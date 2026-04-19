using System.Collections.Generic;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters.Mocks;

public sealed class MockTwoMonsterEncounter : EncounterModel
{
	public override extern RoomType RoomType { get; }

	public override extern bool IsDebugEncounter { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public extern MockTwoMonsterEncounter();
}
