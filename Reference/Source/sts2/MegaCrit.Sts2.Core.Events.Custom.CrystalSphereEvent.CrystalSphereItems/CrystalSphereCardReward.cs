using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent.CrystalSphereItems;

public class CrystalSphereCardReward : CrystalSphereItem
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Material BannerMaterial { get; }

	public extern Material FrameMaterial { get; }

	public override extern Vector2I Size { get; }

	protected override extern string TexturePath { get; }

	public override extern bool IsGood { get; }

	public extern CrystalSphereCardReward(CrystalSphereMinigame grid, CardRarity rarity, Player owner);

	[AsyncStateMachine(typeof(_003CRevealItem_003Ed__16))]
	public override extern Task RevealItem(Player owner);
}
