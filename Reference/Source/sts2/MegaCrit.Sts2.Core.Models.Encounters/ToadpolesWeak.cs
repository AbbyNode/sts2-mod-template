using System.Collections.Generic;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public sealed class ToadpolesWeak : EncounterModel
{
	public override extern RoomType RoomType { get; }

	public override extern bool IsWeak { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public extern ToadpolesWeak();
}
