using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class ChoicesParadox : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterPlayerTurnStart_003Ed__6))]
	public override extern Task AfterPlayerTurnStart(PlayerChoiceContext choiceContext, Player player);

	public extern ChoicesParadox();
}
