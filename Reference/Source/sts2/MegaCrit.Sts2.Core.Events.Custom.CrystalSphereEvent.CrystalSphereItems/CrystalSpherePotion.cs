using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItems;

public class CrystalSpherePotion : CrystalSphereItem
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern string TexturePath { get; }

	public override extern bool IsGood { get; }

	public override extern Vector2I Size { get; }

	public extern CrystalSpherePotion(CrystalSphereMinigame grid, PotionModel potion);

	[AsyncStateMachine(typeof(_003CRevealItem_003Ed__9))]
	public override extern Task RevealItem(Player owner);
}
