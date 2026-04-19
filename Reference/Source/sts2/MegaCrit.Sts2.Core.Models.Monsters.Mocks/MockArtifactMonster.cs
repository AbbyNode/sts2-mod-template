using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models.Monsters.Mocks;

public sealed class MockArtifactMonster : MonsterModel
{
	public override extern LocString Title { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__9))]
	public override extern Task AfterAddedToRoom();

	public extern MockArtifactMonster();
}
