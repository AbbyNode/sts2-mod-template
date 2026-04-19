using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Gold;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Commands;

public static class PlayerCmd
{
	public const string goldSmallSfx = "event:/sfx/ui/gold/gold_1";

	public const string goldMediumSfx = "event:/sfx/ui/gold/gold_2";

	public const string goldLargeSfx = "event:/sfx/ui/gold/gold_3";

	public static extern Task GainEnergy(decimal amount, Player player);

	public static extern Task LoseEnergy(decimal amount, Player player);

	[AsyncStateMachine(typeof(_003CSetEnergy_003Ed__5))]
	public static extern Task SetEnergy(decimal amount, Player player);

	[AsyncStateMachine(typeof(_003CGainStars_003Ed__6))]
	public static extern Task GainStars(decimal amount, Player player);

	public static extern Task LoseStars(decimal amount, Player player);

	[AsyncStateMachine(typeof(_003CSetStars_003Ed__8))]
	public static extern Task SetStars(decimal amount, Player player);

	[AsyncStateMachine(typeof(_003CGainGold_003Ed__9))]
	public static extern Task GainGold(decimal amount, Player player, bool wasStolenBack = false);

	public static extern Task LoseGold(decimal amount, Player player, GoldLossType goldLossType = GoldLossType.Lost);

	[AsyncStateMachine(typeof(_003CSetGold_003Ed__11))]
	public static extern Task SetGold(decimal amount, Player player);

	public static extern Task GainMaxPotionCount(int amount, Player player);

	public static extern Task LoseMaxPotionCount(int amount, Player player);

	[AsyncStateMachine(typeof(_003CAddPet_003Ed__14<>))]
	public static extern Task<Creature> AddPet<T>(Player player) where T : MonsterModel;

	[AsyncStateMachine(typeof(_003CAddPet_003Ed__15))]
	public static extern Task AddPet(Creature pet, Player player);

	[AsyncStateMachine(typeof(_003CMimicRestSiteHeal_003Ed__16))]
	public static extern Task MimicRestSiteHeal(Player player, bool playSfx = true);

	public static extern void EndTurn(Player player, bool canBackOut, Func<Task>? actionDuringEnemyTurn = null);

	public static extern void CompleteQuest(CardModel questCard);
}
