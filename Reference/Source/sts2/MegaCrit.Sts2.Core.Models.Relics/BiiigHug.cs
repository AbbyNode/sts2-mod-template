using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class BiiigHug : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterObtained_003Ed__6))]
	public override extern Task AfterObtained();

	[AsyncStateMachine(typeof(_003CAfterShuffle_003Ed__7))]
	public override extern Task AfterShuffle(PlayerChoiceContext choiceContext, Player shuffler);

	public extern BiiigHug();
}
