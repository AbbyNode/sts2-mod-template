using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.Orbs;

public class OrbQueue
{
	public const int maxCapacity = 10;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<OrbModel> Orbs { get; }

	public extern int Capacity
	{
		[CompilerGenerated]
		get;
	}

	public extern OrbQueue(Player owner);

	public extern void Clear();

	public extern void AddCapacity(int capacity);

	public extern void RemoveCapacity(int capacity);

	[AsyncStateMachine(typeof(_003CTryEnqueue_003Ed__13))]
	public extern Task<bool> TryEnqueue(OrbModel orb);

	public extern bool Remove(OrbModel orb);

	public extern void Insert(int idx, OrbModel orb);

	[AsyncStateMachine(typeof(_003CBeforeTurnEnd_003Ed__16))]
	public extern Task BeforeTurnEnd(PlayerChoiceContext choiceContext);

	[AsyncStateMachine(typeof(_003CAfterTurnStart_003Ed__17))]
	public extern Task AfterTurnStart(PlayerChoiceContext choiceContext);
}
