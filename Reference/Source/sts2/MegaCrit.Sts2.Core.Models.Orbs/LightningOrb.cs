using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Orbs;

public class LightningOrb : OrbModel
{
	protected override extern string PassiveSfx { get; }

	protected override extern string EvokeSfx { get; }

	protected override extern string ChannelSfx { get; }

	public override extern Color DarkenedColor { get; }

	public override extern decimal PassiveVal { get; }

	public override extern decimal EvokeVal { get; }

	[AsyncStateMachine(typeof(_003CBeforeTurnEndOrbTrigger_003Ed__12))]
	public override extern Task BeforeTurnEndOrbTrigger(PlayerChoiceContext choiceContext);

	[AsyncStateMachine(typeof(_003CPassive_003Ed__13))]
	public override extern Task Passive(PlayerChoiceContext choiceContext, Creature? target);

	[AsyncStateMachine(typeof(_003CEvoke_003Ed__14))]
	public override extern Task<IEnumerable<Creature>> Evoke(PlayerChoiceContext playerChoiceContext);

	public extern LightningOrb();
}
