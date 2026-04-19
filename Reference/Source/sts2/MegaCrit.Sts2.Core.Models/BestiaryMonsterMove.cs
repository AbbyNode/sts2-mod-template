using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models;

public class BestiaryMonsterMove
{
	public string moveName;

	public readonly string animId;

	public readonly string? sfx;

	public float sfxDelay;

	public extern BestiaryMonsterMove(string moveName, string animId, string sfx = "", float sfxDelay = 0f);

	public extern BestiaryMonsterMove(LocString moveName, string animId, string sfx = "", float sfxDelay = 0f);
}
