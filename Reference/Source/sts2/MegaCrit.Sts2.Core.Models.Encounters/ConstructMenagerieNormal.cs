using System.Collections.Generic;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public sealed class ConstructMenagerieNormal : EncounterModel
{
	public override extern RoomType RoomType { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public extern ConstructMenagerieNormal();
}
