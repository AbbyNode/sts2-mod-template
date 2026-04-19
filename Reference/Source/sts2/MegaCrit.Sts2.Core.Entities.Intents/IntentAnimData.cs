using System.Collections.Generic;

namespace MegaCrit.Sts2.Core.Entities.Intents;

public static class IntentAnimData
{
	public const string attack1 = "attack_1";

	public const string attack2 = "attack_2";

	public const string attack3 = "attack_3";

	public const string attack4 = "attack_4";

	public const string attack5 = "attack_5";

	public const string buff = "buff";

	public const string cardDebuff = "card_debuff";

	public const string deathBlow = "death_blow";

	public const string debuff = "debuff";

	public const string defend = "defend";

	public const string escape = "escape";

	public const string heal = "heal";

	public const string hidden = "hidden";

	public const string sleep = "sleep";

	public const string status = "status";

	public const string stun = "stun";

	public const string summon = "summon";

	public const string unknown = "unknown";

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern string GetAnimationFrame(string animation, int frame);

	public static extern int GetAnimationFrameCount(string animation);
}
