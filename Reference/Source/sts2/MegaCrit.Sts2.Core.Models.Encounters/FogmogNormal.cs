using System.Collections.Generic;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public sealed class FogmogNormal : EncounterModel
{
	public const string illusionSlot = "illusion";

	public const string fogmogSlot = "fogmog";

	public override extern RoomType RoomType { get; }

	public override extern IReadOnlyList<string> Slots { get; }

	public override extern bool HasScene { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public extern FogmogNormal();
}
