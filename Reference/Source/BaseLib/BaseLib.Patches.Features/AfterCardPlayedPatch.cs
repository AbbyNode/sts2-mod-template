using System;
using System.Threading.Tasks;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Hooks;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Patches.Features;

[HarmonyPatch(typeof(Hook), "AfterCardPlayed")]
internal class AfterCardPlayedPatch
{
	[HarmonyPostfix]
	private static void AfterPlay(CombatState combatState, PlayerChoiceContext choiceContext, CardPlay cardPlay, ref Task __result)
	{
		Task followTask = __result;
		__result = Task.Run(async delegate
		{
			DynamicVar val = default(DynamicVar);
			int num = (cardPlay.Card.DynamicVars.TryGetValue("Refund", ref val) ? val.IntValue : 0);
			if (num > 0)
			{
				ResourceInfo resources = cardPlay.Resources;
				if (((ResourceInfo)(ref resources)).EnergySpent > 0)
				{
					resources = cardPlay.Resources;
					await PlayerCmd.GainEnergy((decimal)Math.Min(num, ((ResourceInfo)(ref resources)).EnergySpent), cardPlay.Card.Owner);
				}
			}
			if (PurgePatch.ShouldPurge(cardPlay.Card))
			{
				CardModel deckVersion = cardPlay.Card.DeckVersion;
				if (deckVersion != null)
				{
					await CardPileCmd.RemoveFromDeck(deckVersion, false);
				}
			}
		}).ContinueWith((Task _) => followTask);
	}
}
