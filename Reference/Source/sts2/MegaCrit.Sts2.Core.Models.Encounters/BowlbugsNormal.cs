using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Encounters;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public sealed class BowlbugsNormal : EncounterModel
{
	public override extern IEnumerable<EncounterTag> Tags { get; }

	public override extern RoomType RoomType { get; }

	public override extern bool HasScene { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public extern BowlbugsNormal();
}
