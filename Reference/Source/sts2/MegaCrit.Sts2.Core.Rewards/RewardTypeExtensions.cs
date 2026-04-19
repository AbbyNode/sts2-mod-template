using System.Collections.Generic;

namespace MegaCrit.Sts2.Core.Rewards;

public static class RewardTypeExtensions
{
	public static extern IEnumerable<string> GetAssetPaths(this RewardType rewardType);
}
