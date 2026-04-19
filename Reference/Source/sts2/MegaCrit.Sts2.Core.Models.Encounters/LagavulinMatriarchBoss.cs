using System.Collections.Generic;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public sealed class LagavulinMatriarchBoss : EncounterModel
{
	public override extern RoomType RoomType { get; }

	public override extern string BossNodePath { get; }

	public override extern MegaSkeletonDataResource? BossNodeSpineResource { get; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public override extern float GetCameraScaling();

	public extern LagavulinMatriarchBoss();
}
