using System.Collections.Generic;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Encounters;

public sealed class BattlewornDummyEventEncounter : EncounterModel
{
	public enum DummySetting
	{
		None,
		Setting1,
		Setting2,
		Setting3
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RoomType RoomType { get; }

	public override extern bool ShouldGiveRewards { get; }

	public extern DummySetting Setting { get; set; }

	public extern bool RanOutOfTime { get; set; }

	public override extern IEnumerable<MonsterModel> AllPossibleMonsters { get; }

	public override extern Dictionary<string, string> SaveCustomState();

	public override extern void LoadCustomState(Dictionary<string, string> state);

	public extern BattlewornDummyEventEncounter();
}
