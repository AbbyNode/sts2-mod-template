using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Rooms;

public class RoomSet
{
	public readonly List<EventModel> events;

	public int eventsVisited;

	public readonly List<EncounterModel> normalEncounters;

	public int normalEncountersVisited;

	public readonly List<EncounterModel> eliteEncounters;

	public int eliteEncountersVisited;

	public int bossEncountersVisited;

	public extern bool HasAncient { get; }

	public extern bool HasSecondBoss { get; }

	public extern AncientEventModel Ancient { get; set; }

	public extern EncounterModel Boss { get; set; }

	public extern EncounterModel? SecondBoss
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern EventModel NextEvent { get; }

	public extern EncounterModel NextNormalEncounter { get; }

	public extern EncounterModel NextEliteEncounter { get; }

	public extern EncounterModel NextBossEncounter { get; }

	public extern void MarkVisited(RoomType roomType);

	public extern void EnsureNextEventIsValid(RunState runState);

	public extern SerializableRoomSet ToSave();

	public static extern RoomSet FromSave(SerializableRoomSet save);

	public static extern void SwapToOrCreateAtIndex<TBaseModel, TSpecificModel>(List<TBaseModel> list, int desiredIndex) where TBaseModel : AbstractModel where TSpecificModel : TBaseModel;

	public extern RoomSet();
}
