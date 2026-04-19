using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Chomper : MonsterModel
{
	public const string screechMoveId = "SCREECH_MOVE";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern bool ScreamFirst { get; set; }

	public override extern string TakeDamageSfx { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__15))]
	public override extern Task AfterAddedToRoom();

	public extern Chomper();
}
