using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItems;

public class CrystalSphereGold : CrystalSphereItem
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern string TexturePath { get; }

	public override extern Vector2I Size { get; }

	public override extern bool IsGood { get; }

	public extern CrystalSphereGold(CrystalSphereMinigame grid, bool isBig);

	[AsyncStateMachine(typeof(_003CRevealItem_003Ed__13))]
	public override extern Task RevealItem(Player owner);
}
