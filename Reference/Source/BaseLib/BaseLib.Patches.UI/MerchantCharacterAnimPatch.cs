using BaseLib.Utils;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Screens.Shops;

namespace BaseLib.Patches.UI;

[HarmonyPatch(typeof(NMerchantCharacter), "PlayAnimation")]
internal class MerchantCharacterAnimPatch
{
	[HarmonyPrefix]
	public static bool SkipAnimIfNotSpine(NMerchantCharacter __instance, string anim, bool loop)
	{
		return !CustomAnimation.PlayCustomAnimation((Node)(object)__instance, anim);
	}
}
