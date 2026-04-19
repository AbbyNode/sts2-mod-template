using System.Collections.Generic;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public sealed class GremlinMercNormal : EncounterModel
{
	public const string mercSlot = "merc";

	public const string sneakySlot = "sneaky";

	public const string fatSlot = "fat";

	public override extern RoomType RoomType { get; }

	public override extern bool HasScene { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public extern GremlinMercNormal();
}
