using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.GameActions;

public sealed class PlayCardAction : GameAction
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern ulong OwnerId { get; }

	public override extern GameActionType ActionType { get; }

	public extern Player Player
	{
		[CompilerGenerated]
		get;
	}

	public extern NetCombatCard NetCombatCard
	{
		[CompilerGenerated]
		get;
	}

	public extern ModelId CardModelId
	{
		[CompilerGenerated]
		get;
	}

	public extern uint? TargetId
	{
		[CompilerGenerated]
		get;
	}

	public extern PlayerChoiceContext? PlayerChoiceContext
	{
		[CompilerGenerated]
		get;
	}

	public extern Creature? Target { get; }

	public extern PlayCardAction(CardModel cardModel, Creature? target);

	public extern PlayCardAction(Player player, NetCombatCard netCombatCard, ModelId cardModelId, uint? targetId);

	public override extern INetAction ToNetAction();

	public override extern string ToString();
}
