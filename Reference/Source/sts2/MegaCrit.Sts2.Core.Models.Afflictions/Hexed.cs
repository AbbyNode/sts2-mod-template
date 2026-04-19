using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Models.Afflictions;

public sealed class Hexed : AfflictionModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool AppliedEthereal { get; set; }

	public override extern Task AfterCardEnteredCombat(CardModel card);

	public extern Hexed();
}
