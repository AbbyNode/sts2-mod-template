using System;
using System.Collections.Generic;
using BaseLib.Patches.Content;
using BaseLib.Patches.UI;
using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Relics;

namespace BaseLib.Abstracts;

[HarmonyPatch(/*Could not decode attribute arguments.*/)]
public class ModelDbCustomCharacters
{
	public static readonly List<CustomCharacterModel> CustomCharacters = new List<CustomCharacterModel>();

	[HarmonyPostfix]
	private static IEnumerable<CharacterModel> AddCustomCharacters(IEnumerable<CharacterModel> __result)
	{
		List<CharacterModel> list = new List<CharacterModel>();
		list.AddRange(__result);
		foreach (CustomCharacterModel customCharacter in CustomCharacters)
		{
			list.Add((CharacterModel)(object)customCharacter);
		}
		return new _003C_003Ez__ReadOnlyList<CharacterModel>(list);
	}

	public static void Register(CustomCharacterModel character)
	{
		if (!CustomContentDictionary.RegisterType(((object)character).GetType()))
		{
			return;
		}
		CustomCharacters.Add(character);
		RelicIconData customYummyCookie = character.CustomYummyCookie;
		if (!(customYummyCookie != null))
		{
			return;
		}
		RelicImageOverridePatch.AddOverride<YummyCookie>(customYummyCookie, (Func<RelicModel, bool>?)delegate(RelicModel relic)
		{
			if (((AbstractModel)relic).IsMutable)
			{
				ModelId id = ((AbstractModel)character).Id;
				Player owner = relic.Owner;
				return id.Equals((owner != null) ? ((AbstractModel)owner.Character).Id : null);
			}
			return false;
		});
	}
}
