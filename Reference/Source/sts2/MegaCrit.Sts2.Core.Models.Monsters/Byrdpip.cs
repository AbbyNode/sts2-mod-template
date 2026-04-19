using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Byrdpip : MonsterModel
{
	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern bool IsHealthBarVisible { get; }

	public override extern void SetupSkins(NCreatureVisuals visuals);

	public extern Byrdpip();
}
