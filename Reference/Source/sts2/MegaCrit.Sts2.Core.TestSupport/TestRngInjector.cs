using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.TestSupport;

public static class TestRngInjector
{
	public static extern void SetRelicOverride<T>() where T : RelicModel;

	public static extern RelicModel? ConsumeRelicOverride();

	public static extern void SetRelicRarityOverride(RelicRarity relicRarity);

	public static extern RelicRarity? GetRelicRarityOverride();

	public static extern void Cleanup();
}
