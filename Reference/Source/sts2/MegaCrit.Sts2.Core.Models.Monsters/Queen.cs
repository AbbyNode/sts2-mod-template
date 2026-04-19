using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Queen : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern IEnumerable<string> AssetPaths { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern void SetupSkins(NCreatureVisuals visuals);

	public override extern void BeforeRemovedFromRoom();

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__35))]
	public override extern Task AfterAddedToRoom();

	public extern Queen();
}
