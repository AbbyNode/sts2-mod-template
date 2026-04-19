using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.CardRewardAlternatives;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.TestSupport;

public class TestCardSelector : ICardSelector
{
	public delegate CardModel? CardRewardSelectionDelegate(IReadOnlyList<CardCreationResult> options, IReadOnlyList<CardRewardAlternative> alternatives);

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern void Cleanup();

	public extern void SetupForAsyncCardSelection();

	public extern void SetupForAsyncIndexSelection();

	public extern void PrepareToSelect(IEnumerable<CardModel> cards);

	public extern void PrepareToSelect(IEnumerable<int> indices);

	public extern void PrepareToSelectCardReward(CardRewardSelectionDelegate del);

	public extern CardModel? GetSelectedCardReward(IReadOnlyList<CardCreationResult> options, IReadOnlyList<CardRewardAlternative> alternatives);

	public extern void PrepareToBlock();

	[AsyncStateMachine(typeof(_003CGetSelectedCards_003Ed__13))]
	public extern Task<IEnumerable<CardModel>> GetSelectedCards(IEnumerable<CardModel> options, int minSelect, int maxSelect);

	public extern TestCardSelector();
}
