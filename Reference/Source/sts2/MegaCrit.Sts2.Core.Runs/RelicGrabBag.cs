using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Runs;

public class RelicGrabBag
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsPopulated { get; }

	public extern bool HasAvailableRelics(IRunState runState);

	public extern RelicGrabBag();

	public extern RelicGrabBag(bool refreshAllowed);

	public extern void Populate(Player player, Rng rng);

	public extern void Populate(IEnumerable<RelicModel> relics, Rng rng);

	public extern RelicModel? PullFromFront(RelicRarity rarity, IRunState runState);

	public extern RelicModel? PullFromBack(RelicRarity rarity, IEnumerable<RelicModel> blacklist, IRunState runState);

	public extern void Remove<T>() where T : RelicModel;

	public extern void Remove(RelicModel relic);

	public extern void MoveToFallback(RelicModel toRemove);

	public extern SerializableRelicGrabBag ToSerializable();

	public static extern RelicGrabBag FromSerializable(SerializableRelicGrabBag save);

	public extern void LoadFromSerializable(SerializableRelicGrabBag save);

	public extern bool Contains(RelicModel relic);
}
