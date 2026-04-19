using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItems;

public class CrystalSphereCurse : CrystalSphereItem
{
	public override extern Vector2I Size { get; }

	public override extern bool IsGood { get; }

	[AsyncStateMachine(typeof(_003CRevealItem_003Ed__4))]
	public override extern Task RevealItem(Player owner);

	public extern CrystalSphereCurse();
}
