using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class PaleBlueDotPower : PowerModel
{
	public const string cardPlayThresholdKey = "CardPlay";

	public const int cardPlayThresholdValue = 5;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern decimal ModifyHandDraw(Player player, decimal count);

	public override extern Task AfterModifyingHandDraw();

	public extern PaleBlueDotPower();
}
