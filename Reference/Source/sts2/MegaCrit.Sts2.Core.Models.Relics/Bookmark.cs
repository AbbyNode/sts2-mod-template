using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class Bookmark : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern Bookmark();
}
