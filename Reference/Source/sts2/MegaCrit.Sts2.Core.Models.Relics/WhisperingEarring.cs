using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class WhisperingEarring : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyMaxEnergy(Player player, decimal amount);

	[AsyncStateMachine(typeof(_003CBeforePlayPhaseStart_003Ed__8))]
	public override extern Task BeforePlayPhaseStart(PlayerChoiceContext choiceContext, Player player);

	public extern WhisperingEarring();
}
