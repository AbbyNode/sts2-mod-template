using System.Collections.Generic;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public sealed class TestSubjectBoss : EncounterModel
{
	public override extern RoomType RoomType { get; }

	public override extern string BossNodePath { get; }

	public override extern string CustomBgm { get; }

	public override extern MegaSkeletonDataResource? BossNodeSpineResource { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public extern TestSubjectBoss();
}
