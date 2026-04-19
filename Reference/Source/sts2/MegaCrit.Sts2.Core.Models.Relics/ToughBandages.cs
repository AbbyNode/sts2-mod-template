using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class ToughBandages : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterCardDiscarded_003Ed__6))]
	public override extern Task AfterCardDiscarded(PlayerChoiceContext choiceContext, CardModel card);

	public extern ToughBandages();
}
