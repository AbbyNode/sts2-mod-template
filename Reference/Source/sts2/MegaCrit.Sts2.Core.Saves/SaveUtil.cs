using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Saves;

public static class SaveUtil
{
	public static extern EventModel EventOrDeprecated(ModelId id);

	public static extern AncientEventModel AncientEventOrDeprecated(ModelId id);

	public static extern EncounterModel EncounterOrDeprecated(ModelId id);

	public static extern CardModel CardOrDeprecated(ModelId id);

	public static extern RelicModel RelicOrDeprecated(ModelId id);

	public static extern PotionModel PotionOrDeprecated(ModelId id);

	public static extern ModifierModel ModifierOrDeprecated(ModelId id);

	public static extern EnchantmentModel EnchantmentOrDeprecated(ModelId id);
}
