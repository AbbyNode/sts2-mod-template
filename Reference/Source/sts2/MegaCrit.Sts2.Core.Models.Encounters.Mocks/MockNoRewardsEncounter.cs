using System.Collections.Generic;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters.Mocks;

public sealed class MockNoRewardsEncounter : EncounterModel
{
	public override extern RoomType RoomType { get; }

	public override extern bool IsDebugEncounter { get; }

	public override extern bool ShouldGiveRewards { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public extern MockNoRewardsEncounter();
}
