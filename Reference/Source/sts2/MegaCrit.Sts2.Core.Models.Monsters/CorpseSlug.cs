using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Audio;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class CorpseSlug : MonsterModel
{
	public const string devourStartTrigger = "DevourStartTrigger";

	public const string devourEndTrigger = "DevourEndkTrigger";

	public const string ravenousSfx = "event:/sfx/enemy/enemy_attacks/corpse_slugs/corpse_slugs_ravenous";

	public const string ravenousUpSfxDouble = "event:/sfx/enemy/enemy_attacks/corpse_slugs/corpse_slugs_ravenous_up_double";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern string DeathSfx { get; }

	public extern bool IsRavenous { get; set; }

	public override extern DamageSfxType TakeDamageSfxType { get; }

	public extern int StarterMoveIdx { get; set; }

	[AsyncStateMachine(typeof(_003CAfterAddedToRoom_003Ed__34))]
	public override extern Task AfterAddedToRoom();

	public static extern void EnsureCorpseSlugsStartWithDifferentMoves(IEnumerable<MonsterModel> monsters, Rng rng);

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public extern CorpseSlug();
}
