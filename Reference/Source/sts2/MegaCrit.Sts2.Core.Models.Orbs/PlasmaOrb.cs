using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Orbs;

public class PlasmaOrb : OrbModel
{
	protected override extern string ChannelSfx { get; }

	public override extern Color DarkenedColor { get; }

	public override extern decimal PassiveVal { get; }

	public override extern decimal EvokeVal { get; }

	[AsyncStateMachine(typeof(_003CAfterTurnStartOrbTrigger_003Ed__8))]
	public override extern Task AfterTurnStartOrbTrigger(PlayerChoiceContext choiceContext);

	[AsyncStateMachine(typeof(_003CPassive_003Ed__9))]
	public override extern Task Passive(PlayerChoiceContext choiceContext, Creature? target);

	[AsyncStateMachine(typeof(_003CEvoke_003Ed__10))]
	public override extern Task<IEnumerable<Creature>> Evoke(PlayerChoiceContext playerChoiceContext);

	public extern PlasmaOrb();
}
