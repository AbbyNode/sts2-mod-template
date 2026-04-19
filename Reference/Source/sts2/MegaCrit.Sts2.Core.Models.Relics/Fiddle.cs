using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class Fiddle : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyHandDrawLate(Player player, decimal count);

	public override extern bool ShouldDraw(Player player, bool fromHandDraw);

	public override extern Task AfterPreventingDraw();

	public extern Fiddle();
}
