using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models.Events;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Cards;

public sealed class MadScience : CardModel
{
	public const int attackDamage = 12;

	public const int skillBlock = 8;

	public const string sappingWeakKey = "SappingWeak";

	public const int sappingWeakValue = 2;

	public const string sappingVulnerableKey = "SappingVulnerable";

	public const int sappingVulnerableValue = 2;

	public const string violenceHitsKey = "ViolenceHits";

	public const int violenceHitsValue = 3;

	public const string chokingDamageKey = "ChokingDamage";

	public const int chokingDamageValue = 6;

	public const string energizedEnergyKey = "EnergizedEnergy";

	public const int energizedEnergyValue = 2;

	public const string wisdomCardsKey = "WisdomCards";

	public const int wisdomCardsValue = 3;

	public const string expertiseStrengthKey = "ExpertiseStrength";

	public const int expertiseStrengthValue = 2;

	public const string expertiseDexterityKey = "ExpertiseDexterity";

	public const int expertiseDexterityValue = 2;

	public const string curiousReductionKey = "CuriousReduction";

	public const int curiousReductionValue = 1;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern string PortraitPath { get; }

	public override extern string BetaPortraitPath { get; }

	public override extern string[] AllPortraitPaths { get; }

	public override extern CardType Type { get; }

	public override extern TargetType TargetType { get; }

	public override extern bool GainsBlock { get; }

	[SavedProperty(SerializationCondition.AlwaysSave, -1)]
	public extern CardType TinkerTimeType { get; set; }

	[SavedProperty(SerializationCondition.SaveIfNotTypeDefault)]
	public extern TinkerTime.RiderEffect TinkerTimeRider { get; set; }

	public extern MadScience();

	public extern void MockChaosCard(CardModel card);
}
