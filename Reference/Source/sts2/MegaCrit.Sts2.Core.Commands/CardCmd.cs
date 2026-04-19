using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Commands;

public static class CardCmd
{
	[AsyncStateMachine(typeof(_003CAutoPlay_003Ed__0))]
	public static extern Task AutoPlay(PlayerChoiceContext choiceContext, CardModel card, Creature? target, AutoPlayType type = AutoPlayType.Default, bool skipXCapture = false, bool skipCardPileVisuals = false);

	[AsyncStateMachine(typeof(_003CDiscard_003Ed__2))]
	public static extern Task Discard(PlayerChoiceContext choiceContext, CardModel card);

	[AsyncStateMachine(typeof(_003CDiscard_003Ed__3))]
	public static extern Task Discard(PlayerChoiceContext choiceContext, IEnumerable<CardModel> cards);

	[AsyncStateMachine(typeof(_003CDiscardAndDraw_003Ed__4))]
	public static extern Task DiscardAndDraw(PlayerChoiceContext choiceContext, IEnumerable<CardModel> cardsToDiscard, int cardsToDraw);

	public static extern void Downgrade(CardModel card);

	[AsyncStateMachine(typeof(_003CExhaust_003Ed__6))]
	public static extern Task Exhaust(PlayerChoiceContext choiceContext, CardModel card, bool causedByEthereal = false, bool skipVisuals = false);

	public static extern void Upgrade(CardModel card, CardPreviewStyle style = CardPreviewStyle.HorizontalLayout);

	public static extern void Upgrade(IEnumerable<CardModel> cards, CardPreviewStyle style);

	[AsyncStateMachine(typeof(_003CTransformToRandom_003Ed__9))]
	public static extern Task<CardPileAddResult> TransformToRandom(CardModel original, Rng rng, CardPreviewStyle style = CardPreviewStyle.HorizontalLayout);

	[AsyncStateMachine(typeof(_003CTransformTo_003Ed__10<>))]
	public static extern Task<CardPileAddResult?> TransformTo<T>(CardModel original, CardPreviewStyle style = CardPreviewStyle.HorizontalLayout) where T : CardModel;

	[AsyncStateMachine(typeof(_003CTransform_003Ed__11))]
	public static extern Task<CardPileAddResult?> Transform(CardModel original, CardModel replacement, CardPreviewStyle style = CardPreviewStyle.HorizontalLayout);

	[AsyncStateMachine(typeof(_003CTransform_003Ed__13))]
	public static extern Task<IEnumerable<CardPileAddResult>> Transform(IEnumerable<CardTransformation> transformations, Rng? rng, CardPreviewStyle style = CardPreviewStyle.HorizontalLayout);

	public static extern T? Enchant<T>(CardModel card, decimal amount) where T : EnchantmentModel;

	public static extern EnchantmentModel? Enchant(EnchantmentModel enchantment, CardModel card, decimal amount);

	public static extern void ClearEnchantment(CardModel card);

	[AsyncStateMachine(typeof(_003CAfflictAndPreview_003Ed__17<>))]
	public static extern Task<IEnumerable<T>> AfflictAndPreview<T>(IEnumerable<CardModel> cards, decimal amount, CardPreviewStyle style = CardPreviewStyle.HorizontalLayout) where T : AfflictionModel;

	[AsyncStateMachine(typeof(_003CAfflict_003Ed__18<>))]
	public static extern Task<T?> Afflict<T>(CardModel card, decimal amount) where T : AfflictionModel;

	public static extern Task<AfflictionModel?> Afflict(AfflictionModel affliction, CardModel card, decimal amount);

	public static extern void ClearAffliction(CardModel card);

	public static extern void ApplyKeyword(CardModel card, params CardKeyword[] keywords);

	public static extern void RemoveKeyword(CardModel card, params CardKeyword[] keywords);

	public static extern void ApplySingleTurnSly(CardModel card);

	public static extern TaskCompletionSource? Preview(CardModel card, float time = 1.2f, CardPreviewStyle style = CardPreviewStyle.HorizontalLayout);

	public static extern void Preview(IReadOnlyList<CardModel> cards, float time = 1.2f, CardPreviewStyle style = CardPreviewStyle.HorizontalLayout);

	public static extern void PreviewCardPileAdd(CardPileAddResult result, float time = 1.2f, CardPreviewStyle style = CardPreviewStyle.HorizontalLayout);

	public static extern void PreviewCardPileAdd(IReadOnlyList<CardPileAddResult> results, float time = 1.2f, CardPreviewStyle style = CardPreviewStyle.HorizontalLayout);
}
