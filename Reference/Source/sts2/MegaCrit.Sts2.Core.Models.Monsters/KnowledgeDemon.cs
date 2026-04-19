using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class KnowledgeDemon : MonsterModel
{
	public interface IChoosable
	{
		Task OnChosen();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public extern bool IsBurnt { get; set; }

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern KnowledgeDemon();
}
