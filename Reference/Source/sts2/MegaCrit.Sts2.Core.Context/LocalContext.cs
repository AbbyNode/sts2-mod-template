using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Context;

public static class LocalContext
{
	public static extern ulong? NetId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static extern Player? GetMe(IPlayerCollection? playerCollection);

	public static extern SerializablePlayer? GetMe(SerializableRun? run);

	public static extern Player? GetMe(CombatState? combatState);

	public static extern Player? GetMe(IEnumerable<Player> players);

	public static extern Creature? GetMe(IEnumerable<Creature> creatures);

	public static extern bool IsMe(Player? player);

	public static extern bool IsMe(Creature? creature);

	public static extern bool ContainsMe(IEnumerable<Player> players);

	public static extern bool ContainsMe(IEnumerable<Creature> creatures);

	public static extern bool IsMine(CardModel? card);

	public static extern bool IsMine(PotionModel? potion);

	public static extern bool IsMine(RelicModel? relic);

	public static extern bool IsMine(EventModel? eventModel);
}
