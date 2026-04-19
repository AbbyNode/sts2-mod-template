using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Entities.Ascension;

public class AscensionManager
{
	public const int maxAscensionAllowed = 10;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern AscensionManager(int level);

	public extern AscensionManager(AscensionLevel level);

	public extern bool HasLevel(AscensionLevel level);

	public extern void ApplyEffectsTo(Player player);
}
