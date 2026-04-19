using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class BloodVial : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterPlayerTurnStartLate_003Ed__4))]
	public override extern Task AfterPlayerTurnStartLate(PlayerChoiceContext choiceContext, Player player);

	public extern BloodVial();
}
