using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class LanternKey : CardModel
{
	public override extern int MaxUpgradeLevel { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public extern LanternKey();

	public override extern IReadOnlySet<RoomType> ModifyUnknownMapPointRoomTypes(IReadOnlySet<RoomType> roomTypes);

	public override extern EventModel ModifyNextEvent(EventModel currentEvent);
}
