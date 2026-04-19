using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Commands;

public static class VfxCmd
{
	public const string adrenalinePath = "vfx/vfx_adrenaline";

	public const string bitePath = "vfx/vfx_bite";

	public const string blockPath = "vfx/vfx_block";

	public const string bloodyImpactPath = "vfx/vfx_bloody_impact";

	public const string bluntPath = "vfx/vfx_attack_blunt";

	public const string chainPath = "vfx/vfx_chain";

	public const string coinExplosionSmallPath = "vfx/vfx_coin_explosion_small";

	public const string coinExplosionRegularPath = "vfx/vfx_coin_explosion_regular";

	public const string coinExplosionJumboPath = "vfx/vfx_coin_explosion_jumbo";

	public const string daggerThrowPath = "vfx/vfx_dagger_throw";

	public const string daggerSprayPath = "vfx/vfx_dagger_spray";

	public const string dramaticStabPath = "vfx/vfx_dramatic_stab";

	public const string flyingSlashPath = "vfx/vfx_flying_slash";

	public const string gazePath = "vfx/vfx_gaze";

	public const string giantHorizontalSlashPath = "vfx/vfx_giant_horizontal_slash";

	public const string healPath = "vfx/vfx_cross_heal";

	public const string lightningPath = "vfx/vfx_attack_lightning";

	public const string thrashPath = "vfx/vfx_thrash";

	public const string rockShatterPath = "vfx/vfx_rock_shatter";

	public const string sandyImpactPath = "vfx/vfx_sandy_impact";

	public const string scratchPath = "vfx/vfx_scratch";

	public const string slashPath = "vfx/vfx_attack_slash";

	public const string slimeImpactVfxPath = "vfx/vfx_slime_impact";

	public const string hellraiserSwordVfxPath = "vfx/hellraiser_attack_vfx";

	public const string heavyBluntPath = "vfx/vfx_heavy_blunt";

	public const string starryImpactVfx = "vfx/vfx_starry_impact";

	public const string screamVfx = "vfx/vfx_scream";

	public const string spookyScreamVfx = "vfx/vfx_spooky_scream";

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern void PlayFullScreenInCombat(string path);

	public static extern Vector2? GetSideCenter(CombatSide side, CombatState combatState);

	public static extern Vector2? GetSideCenterFloor(CombatSide side, CombatState combatState);

	public static extern void PlayOnSide(CombatSide side, string path, CombatState combatState);

	public static extern void PlayOnCreatureCenters(IEnumerable<Creature> targets, string path);

	public static extern void PlayOnCreatureCenter(Creature target, string path);

	public static extern void PlayOnCreatures(IEnumerable<Creature> targets, string path);

	public static extern void PlayOnCreature(Creature target, string path);

	public static extern void PlayVfx(Vector2 position, string path);

	public static extern Node2D? PlayNonCombatVfx(Node container, Vector2 position, string path);
}
