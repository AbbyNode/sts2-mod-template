using Godot;
using MegaCrit.Sts2.Core.Animation;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Models.Monsters;

public sealed class Osty : MonsterModel
{
	public const float attackerAnimDelay = 0.3f;

	public const string pokeAnim = "attack_poke";

	public const string ostyAttackSfx = "event:/sfx/characters/osty/osty_attack";

	public static extern Vector2 MinOffset { get; }

	public static extern Vector2 MaxOffset { get; }

	public static extern Vector2 ScaleRange { get; }

	public override extern int MinInitialHp { get; }

	public override extern int MaxInitialHp { get; }

	public override extern string DeathSfx { get; }

	public override extern bool HasDeathSfx { get; }

	public override extern bool IsHealthBarVisible { get; }

	public override extern CreatureAnimator GenerateAnimator(MegaSprite controller);

	public static extern bool CheckMissingWithAnim(Player owner);

	public extern Osty();
}
