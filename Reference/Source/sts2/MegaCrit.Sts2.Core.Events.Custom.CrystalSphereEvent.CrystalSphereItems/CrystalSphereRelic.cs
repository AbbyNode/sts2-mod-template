using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItems;

public class CrystalSphereRelic : CrystalSphereItem
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern Vector2I Size { get; }

	public override extern bool IsGood { get; }

	protected override extern string TexturePath { get; }

	public extern CrystalSphereRelic(CrystalSphereMinigame grid);

	[AsyncStateMachine(typeof(_003CRevealItem_003Ed__8))]
	public override extern Task RevealItem(Player owner);
}
