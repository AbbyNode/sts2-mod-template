using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Commands;

public static class CardPileCmd
{
	[AsyncStateMachine(typeof(_003CRemoveFromDeck_003Ed__0))]
	public static extern Task RemoveFromDeck(CardModel card, bool showPreview = true);

	[AsyncStateMachine(typeof(_003CRemoveFromDeck_003Ed__1))]
	public static extern Task RemoveFromDeck(IReadOnlyList<CardModel> cards, bool showPreview = true);

	[AsyncStateMachine(typeof(_003CRemoveFromCombat_003Ed__2))]
	public static extern Task RemoveFromCombat(CardModel card, bool skipVisuals = false);

	[AsyncStateMachine(typeof(_003CRemoveFromCombat_003Ed__3))]
	public static extern Task RemoveFromCombat(IEnumerable<CardModel> cards, bool skipVisuals = false);

	[AsyncStateMachine(typeof(_003CAddGeneratedCardToCombat_003Ed__4))]
	public static extern Task<CardPileAddResult> AddGeneratedCardToCombat(CardModel card, PileType newPileType, bool addedByPlayer, CardPilePosition position = CardPilePosition.Bottom);

	[AsyncStateMachine(typeof(_003CAddGeneratedCardsToCombat_003Ed__5))]
	public static extern Task<IReadOnlyList<CardPileAddResult>> AddGeneratedCardsToCombat(IEnumerable<CardModel> cards, PileType newPileType, bool addedByPlayer, CardPilePosition position = CardPilePosition.Bottom);

	[AsyncStateMachine(typeof(_003CAdd_003Ed__6))]
	public static extern Task<CardPileAddResult> Add(CardModel card, PileType newPileType, CardPilePosition position = CardPilePosition.Bottom, AbstractModel? source = null, bool skipVisuals = false);

	[AsyncStateMachine(typeof(_003CAdd_003Ed__7))]
	public static extern Task<CardPileAddResult> Add(CardModel card, CardPile newPile, CardPilePosition position = CardPilePosition.Bottom, AbstractModel? source = null, bool skipVisuals = false);

	[AsyncStateMachine(typeof(_003CAdd_003Ed__8))]
	public static extern Task<IReadOnlyList<CardPileAddResult>> Add(IEnumerable<CardModel> cards, PileType newPileType, CardPilePosition position = CardPilePosition.Bottom, AbstractModel? source = null, bool skipVisuals = false);

	[AsyncStateMachine(typeof(_003CAdd_003Ed__9))]
	public static extern Task<IReadOnlyList<CardPileAddResult>> Add(IEnumerable<CardModel> cards, CardPile newPile, CardPilePosition position = CardPilePosition.Bottom, AbstractModel? source = null, bool skipVisuals = false);

	[AsyncStateMachine(typeof(_003CAddDuringManualCardPlay_003Ed__10))]
	public static extern Task AddDuringManualCardPlay(CardModel card);

	[AsyncStateMachine(typeof(_003CDraw_003Ed__15))]
	public static extern Task<CardModel?> Draw(PlayerChoiceContext choiceContext, Player player);

	[AsyncStateMachine(typeof(_003CDraw_003Ed__16))]
	public static extern Task<IEnumerable<CardModel>> Draw(PlayerChoiceContext choiceContext, decimal count, Player player, bool fromHandDraw = false);

	[AsyncStateMachine(typeof(_003CShuffle_003Ed__17))]
	public static extern Task Shuffle(PlayerChoiceContext choiceContext, Player player);

	[AsyncStateMachine(typeof(_003CAutoPlayFromDrawPile_003Ed__18))]
	public static extern Task AutoPlayFromDrawPile(PlayerChoiceContext choiceContext, Player player, int count, CardPilePosition position, bool forceExhaust);

	[AsyncStateMachine(typeof(_003CShuffleIfNecessary_003Ed__19))]
	public static extern Task ShuffleIfNecessary(PlayerChoiceContext choiceContext, Player player);

	[AsyncStateMachine(typeof(_003CAddToCombatAndPreview_003Ed__21<>))]
	public static extern Task AddToCombatAndPreview<T>(IEnumerable<Creature> targets, PileType pileType, int count, bool addedByPlayer, CardPilePosition position = CardPilePosition.Bottom) where T : CardModel;

	[AsyncStateMachine(typeof(_003CAddToCombatAndPreview_003Ed__22<>))]
	public static extern Task AddToCombatAndPreview<T>(Creature target, PileType pileType, int count, bool addedByPlayer, CardPilePosition position = CardPilePosition.Bottom) where T : CardModel;

	[AsyncStateMachine(typeof(_003CAddCurseToDeck_003Ed__23<>))]
	public static extern Task AddCurseToDeck<T>(Player owner) where T : CardModel;

	[AsyncStateMachine(typeof(_003CAddCursesToDeck_003Ed__24))]
	public static extern Task AddCursesToDeck(IEnumerable<CardModel> curses, Player owner);
}
