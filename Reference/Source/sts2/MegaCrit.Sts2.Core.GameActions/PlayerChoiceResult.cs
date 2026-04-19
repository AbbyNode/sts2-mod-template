using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Models;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.GameActions;

public class PlayerChoiceResult
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern PlayerChoiceType ChoiceType
	{
		[CompilerGenerated]
		get;
	}

	public static extern PlayerChoiceResult FromCanonicalCard(CardModel? canonicalCard);

	public static extern PlayerChoiceResult FromMutableCombatCard(CardModel? combatCard);

	public static extern PlayerChoiceResult FromMutableDeckCard(CardModel? deckCard);

	public static extern PlayerChoiceResult FromCanonicalCards(IEnumerable<CardModel> canonicalCards);

	public static extern PlayerChoiceResult FromMutableCombatCards(IEnumerable<CardModel> combatCards);

	public static extern PlayerChoiceResult FromMutableDeckCards(IEnumerable<CardModel> deckCards);

	public static extern PlayerChoiceResult FromMutableCard(CardModel? mutableCard);

	public static extern PlayerChoiceResult FromMutableCards(IEnumerable<CardModel> mutableCards);

	public static extern PlayerChoiceResult FromCards(IEnumerable<CardModel> cards, PlayerChoiceType choiceType);

	public static extern PlayerChoiceResult FromPlayerId(ulong? playerId);

	public static extern PlayerChoiceResult FromIndex(int index);

	public static extern PlayerChoiceResult FromIndexes(List<int> indexes);

	public extern CardModel? AsCanonicalCard();

	public extern IEnumerable<CardModel> AsCanonicalCards();

	public extern IEnumerable<CardModel> AsCombatCards();

	public extern IEnumerable<CardModel> AsDeckCards();

	public extern CardModel? AsMutableCard();

	public extern IEnumerable<CardModel> AsMutableCards();

	public extern IEnumerable<CardModel> AsCards(PlayerChoiceType type);

	public extern ulong? AsPlayerId();

	public extern int AsIndex();

	public extern List<int> AsIndexes();

	public static extern PlayerChoiceResult FromNetData(Player sender, IPlayerCollection players, NetPlayerChoiceResult netData);

	public extern NetPlayerChoiceResult ToNetData();

	public override extern string ToString();

	public extern PlayerChoiceResult();
}
