using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models.Monsters.Mocks;

public sealed class MockPlatingMonster : MonsterModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern LocString Title { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern int PlatingAmount { get; set; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__13))]
	public override extern Task AfterAddedToRoom();

	public extern MockPlatingMonster();
}
