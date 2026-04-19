using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Commands;

public static class SfxCmd
{
	public static extern void Play(string sfx, float volume = 1f);

	public static extern void Play(string sfx, string param, float val, float volume = 1f);

	public static extern void PlayLoop(string sfx, bool usesLoopParam = true);

	public static extern void StopLoop(string sfx);

	public static extern void SetParam(string sfx, string param, float value);

	public static extern void PlayDamage(MonsterModel? monster, int damageAmount);

	public static extern void PlayDeath(MonsterModel? monster);

	public static extern void PlayDeath(Player player);
}
