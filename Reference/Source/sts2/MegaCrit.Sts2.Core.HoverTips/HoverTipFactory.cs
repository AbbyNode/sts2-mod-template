using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.HoverTips;

public static class HoverTipFactory
{
	public static extern IEnumerable<IHoverTip> FromEnchantment<T>(int amount = 1) where T : EnchantmentModel;

	public static extern IEnumerable<IHoverTip> FromAffliction<T>(int amount = 1) where T : AfflictionModel;

	public static extern IHoverTip FromKeyword(CardKeyword keyword);

	public static extern IHoverTip FromPower<T>() where T : PowerModel;

	public static extern IHoverTip FromPower(PowerModel model);

	public static extern IEnumerable<IHoverTip> FromPowerWithPowerHoverTips<T>() where T : PowerModel;

	public static extern IHoverTip FromPotion<T>() where T : PotionModel;

	public static extern IHoverTip FromPotion(PotionModel model);

	public static extern IHoverTip FromOrb<T>() where T : OrbModel;

	public static extern IEnumerable<IHoverTip> FromRelic<T>() where T : RelicModel;

	public static extern IEnumerable<IHoverTip> FromRelicExcludingItself<T>() where T : RelicModel;

	public static extern IEnumerable<IHoverTip> FromRelic(RelicModel relic);

	public static extern IEnumerable<IHoverTip> FromRelicExcludingItself(RelicModel relic);

	public static extern IEnumerable<IHoverTip> FromCardWithCardHoverTips<T>(bool inheritsUpgrades = false) where T : CardModel;

	public static extern IHoverTip FromCard<T>(bool upgrade = false) where T : CardModel;

	public static extern IHoverTip FromCard(CardModel card, bool upgrade = false);

	public static extern IHoverTip Static(StaticHoverTip tip, params DynamicVar[] vars);

	public static extern IHoverTip ForEnergy(CardModel card);

	public static extern IHoverTip ForEnergy(PotionModel potion);

	public static extern IHoverTip ForEnergy(PowerModel power);

	public static extern IHoverTip ForEnergy(Player player);

	public static extern IHoverTip ForEnergy(RelicModel relic);

	public static extern IEnumerable<IHoverTip> FromForge();
}
