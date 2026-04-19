using MegaCrit.Sts2.Core.Entities.Ascension;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Helpers;

public static class AscensionHelper
{
	public static extern double PovertyAscensionGoldMultiplier { get; }

	public static extern int GetValueIfAscension(AscensionLevel level, int ascensionValue, int fallbackValue);

	public static extern float GetValueIfAscension(AscensionLevel level, float ascensionValue, float fallbackValue);

	public static extern decimal GetValueIfAscension(AscensionLevel level, decimal ascensionValue, decimal fallbackValue);

	public static extern bool HasAscension(AscensionLevel level);

	public static extern LocString GetTitle(int level);

	public static extern LocString GetDescription(int level);

	public static extern HoverTip GetHoverTip(CharacterModel character, int level);
}
