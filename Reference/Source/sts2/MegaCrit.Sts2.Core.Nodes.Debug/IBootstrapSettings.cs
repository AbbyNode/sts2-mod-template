using System.Collections.Generic;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Nodes.Debug;

public interface IBootstrapSettings
{
	CharacterModel Character { get; }

	RoomType RoomType { get; }

	EncounterModel Encounter { get; }

	EventModel Event { get; }

	ActModel Act { get; }

	int Ascension { get; }

	bool SaveRunHistory { get; }

	string? Seed { get; }

	bool DoPreloading { get; }

	bool BootstrapInMultiplayer { get; }

	List<ModifierModel> Modifiers { get; }

	string? Language { get; }

	MapPointType MapPointType { get; }

	Task Setup(Player localPlayer);
}
