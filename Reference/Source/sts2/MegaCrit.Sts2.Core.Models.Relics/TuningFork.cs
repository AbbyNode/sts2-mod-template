using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class TuningFork : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	[SavedProperty]
	public extern int SkillsPlayed { get; }

	public extern void NotifySkillPlayed();

	[AsyncStateMachine(typeof(_003CAfterCardPlayed_003Ed__22))]
	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	public extern TuningFork();
}
