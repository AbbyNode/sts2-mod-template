using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Audio;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class TheAdversaryMkTwo : MonsterModel
{
	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__16))]
	public override extern Task AfterAddedToRoom();

	public extern TheAdversaryMkTwo();
}
