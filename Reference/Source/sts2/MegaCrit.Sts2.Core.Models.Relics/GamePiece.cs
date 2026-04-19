using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class GamePiece : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern string FlashSfx { get; }

	[AsyncStateMachine(typeof(_003CAfterCardPlayed_003Ed__6))]
	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	public extern GamePiece();
}
