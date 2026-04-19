using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class Pendulum : RelicModel
{
	public override extern string FlashSfx { get; }

	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterShuffle_003Ed__4))]
	public override extern Task AfterShuffle(PlayerChoiceContext choiceContext, Player player);

	public extern Pendulum();
}
