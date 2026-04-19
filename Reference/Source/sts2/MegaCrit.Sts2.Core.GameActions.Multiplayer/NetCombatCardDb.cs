using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer;

public class NetCombatCardDb
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NetCombatCardDb Instance
	{
		[CompilerGenerated]
		get;
	}

	public extern void StartCombat(IReadOnlyList<Player> players);

	public extern uint GetCardId(CardModel card);

	public extern CardModel GetCard(uint id);

	public extern bool TryGetCardId(CardModel card, out uint id);

	public extern bool TryGetCard(uint id, out CardModel? card);

	public extern uint IdCardForTesting(CardModel card);

	public extern void ClearCardsForTesting();

	public extern NetCombatCardDb();
}
