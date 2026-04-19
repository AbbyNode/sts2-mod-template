using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.CardSelection;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.TestSupport;

namespace MegaCrit.Sts2.Core.Commands;

public static class CardSelectCmd
{
	public static extern ICardSelector? Selector { get; }

	public static extern IDisposable UseSelector(ICardSelector selector);

	public static extern IDisposable PushSelector(ICardSelector selector);

	[AsyncStateMachine(typeof(_003CFromChooseACardScreen_003Ed__8))]
	public static extern Task<CardModel?> FromChooseACardScreen(PlayerChoiceContext context, IReadOnlyList<CardModel> cards, Player player, bool canSkip = false);

	[AsyncStateMachine(typeof(_003CFromSimpleGridForRewards_003Ed__9))]
	public static extern Task<IEnumerable<CardModel>> FromSimpleGridForRewards(PlayerChoiceContext context, List<CardCreationResult> cards, Player player, CardSelectorPrefs prefs);

	[AsyncStateMachine(typeof(_003CFromSimpleGrid_003Ed__10))]
	public static extern Task<IEnumerable<CardModel>> FromSimpleGrid(PlayerChoiceContext context, IReadOnlyList<CardModel> cardsIn, Player player, CardSelectorPrefs prefs);

	[AsyncStateMachine(typeof(_003CFromDeckForUpgrade_003Ed__11))]
	public static extern Task<IEnumerable<CardModel>> FromDeckForUpgrade(Player player, CardSelectorPrefs prefs);

	[AsyncStateMachine(typeof(_003CFromDeckForTransformation_003Ed__12))]
	public static extern Task<IEnumerable<CardModel>> FromDeckForTransformation(Player player, CardSelectorPrefs prefs, Func<CardModel, CardTransformation>? cardToTransformation = null);

	[AsyncStateMachine(typeof(_003CFromDeckForEnchantment_003Ed__13))]
	public static extern Task<IEnumerable<CardModel>> FromDeckForEnchantment(Player player, EnchantmentModel enchantment, int amount, CardSelectorPrefs prefs);

	[AsyncStateMachine(typeof(_003CFromDeckForEnchantment_003Ed__14))]
	public static extern Task<IEnumerable<CardModel>> FromDeckForEnchantment(Player player, EnchantmentModel enchantment, int amount, Func<CardModel?, bool>? additionalFilter, CardSelectorPrefs prefs);

	[AsyncStateMachine(typeof(_003CFromDeckForEnchantment_003Ed__15))]
	public static extern Task<IEnumerable<CardModel>> FromDeckForEnchantment(IReadOnlyList<CardModel> cards, EnchantmentModel enchantment, int amount, CardSelectorPrefs prefs);

	public static extern Task<IEnumerable<CardModel>> FromDeckForRemoval(Player player, CardSelectorPrefs prefs, Func<CardModel, bool>? filter = null);

	[AsyncStateMachine(typeof(_003CFromDeckGeneric_003Ed__17))]
	public static extern Task<IEnumerable<CardModel>> FromDeckGeneric(Player player, CardSelectorPrefs prefs, Func<CardModel, bool>? filter = null, Func<CardModel, int>? sortingOrder = null);

	[AsyncStateMachine(typeof(_003CFromHand_003Ed__18))]
	public static extern Task<IEnumerable<CardModel>> FromHand(PlayerChoiceContext context, Player player, CardSelectorPrefs prefs, Func<CardModel, bool>? filter, AbstractModel source);

	[AsyncStateMachine(typeof(_003CFromHandForDiscard_003Ed__19))]
	public static extern Task<IEnumerable<CardModel>> FromHandForDiscard(PlayerChoiceContext context, Player player, CardSelectorPrefs prefs, Func<CardModel, bool>? filter, AbstractModel source);

	[AsyncStateMachine(typeof(_003CFromHandForUpgrade_003Ed__20))]
	public static extern Task<CardModel?> FromHandForUpgrade(PlayerChoiceContext context, Player player, AbstractModel source);

	[AsyncStateMachine(typeof(_003CFromChooseABundleScreen_003Ed__21))]
	public static extern Task<IEnumerable<CardModel>> FromChooseABundleScreen(Player player, IReadOnlyList<IReadOnlyList<CardModel>> bundles);
}
