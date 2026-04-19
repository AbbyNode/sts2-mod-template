using System.Collections.Generic;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public sealed class NibbitsNormal : EncounterModel
{
	public override extern IReadOnlyList<string> Slots { get; }

	public override extern RoomType RoomType { get; }

	public override extern bool HasScene { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public extern NibbitsNormal();
}
