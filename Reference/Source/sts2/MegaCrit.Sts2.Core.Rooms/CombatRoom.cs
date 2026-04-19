using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Rooms;

public class CombatRoom : AbstractRoom, ICombatRoomVisuals
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RoomType RoomType { get; }

	public override extern ModelId ModelId { get; }

	public extern EncounterModel Encounter { get; }

	public extern CombatState CombatState
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<Creature> Allies { get; }

	public extern IEnumerable<Creature> Enemies { get; }

	public extern ActModel Act { get; }

	public override extern bool IsPreFinished { get; }

	public extern float GoldProportion
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyDictionary<Player, List<Reward>> ExtraRewards { get; }

	public extern bool ShouldCreateCombat
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern bool ShouldResumeParentEventAfterCombat
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern ModelId? ParentEventId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern CombatRoom(EncounterModel encounter, IRunState? runState);

	public extern CombatRoom(CombatState combatState);

	public new static extern CombatRoom FromSerializable(SerializableRoom serializableRoom, IRunState? runState);

	[AsyncStateMachine(typeof(_003CEnter_003Ed__40))]
	public override extern Task Enter(IRunState? runState, bool isRestoringRoomStackBase);

	public override extern Task Exit(IRunState? runState);

	public override extern Task Resume(AbstractRoom _, IRunState? runState);

	public override extern SerializableRoom ToSerializable();

	public extern void MarkPreFinished();

	public extern void AddExtraReward(Player player, Reward reward);

	public extern void OnCombatEnded();
}
