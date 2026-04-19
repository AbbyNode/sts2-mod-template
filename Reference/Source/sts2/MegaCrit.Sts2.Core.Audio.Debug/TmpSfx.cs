using System.Collections.Generic;

namespace MegaCrit.Sts2.Core.Audio.Debug;

public static class TmpSfx
{
	public const string gameOver = "event:/temp/sfx/game_over";

	public static readonly IReadOnlyList<string> assetPaths;

	public const string gainPotion = "gain_potion.mp3";

	public const string victory = "victory.mp3";

	public const string startPlayerTurn = "player_turn.mp3";

	public const string startEnemyTurn = "enemy_turn.mp3";

	public const string openCardScreen = "map_open.mp3";

	public const string mapPing = "map_ping.mp3";

	public const string cardDeal = "card_deal.mp3";

	public const string cardSelect = "card_select.mp3";

	public const string cardExhaust = "card_exhaust.mp3";

	public const string deny = "deny.mp3";

	public const string mapSplitVoteTick = "map_split_tick.mp3";

	public const string relicGet = "relic_get.mp3";

	public const string shovel = "sts_sfx_shovel_v1.mp3";

	public const string heavyAttack = "heavy_attack.mp3";

	public const string slashAttack = "slash_attack.mp3";

	public const string daggerThrow = "dagger_throw.mp3";

	public const string applyDoom = "doom_apply.mp3";

	public const string bluntAttack = "blunt_attack.mp3";

	public const string lightningStrike = "lightning_orb_evoke.mp3";

	public const string logo = "SOTE_Logo_Echoing_ShortTail.mp3";

	public const string restSiteHealBlanket = "SOTE_SFX_SleepBlanket_v1.mp3";

	public const string restSiteHealJingle = "sleep.tres";

	public const string cardSmith = "card_smith.mp3";

	public const string characterUnlock = "character_unlock.mp3";

	public const string characterUnlockCharge = "character_unlock_charge.mp3";

	public const string shortDeathStinger = "STS_DeathStinger_v4_Short_SFX.mp3";

	public const string dollRoomAmbience = "doll_room_amb.mp3";

	public const string hey = "hey.mp3";

	public const string hiss = "hiss.mp3";

	public static extern IEnumerable<string> BattleStart { get; }

	public static extern IEnumerable<string> PotionSlosh { get; }

	public static extern string GetPath(string sfx);
}
