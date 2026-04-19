using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class SoulNexus : MonsterModel
{
	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern bool ShouldFadeAfterDeath { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public override extern void SetupSkins(NCreatureVisuals visuals);

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__17))]
	public override extern Task AfterAddedToRoom();

	public override extern void BeforeRemovedFromRoom();

	public extern SoulNexus();
}
