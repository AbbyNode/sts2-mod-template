using BaseLib.Utils;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace BaseLib.Patches.Content;

[HarmonyPatch(typeof(NCreature), "SetAnimationTrigger")]
internal static class CustomAnimationPatch
{
	[HarmonyPrefix]
	public static bool Prefix(NCreature __instance, string trigger)
	{
		if (__instance.HasSpineAnimation)
		{
			return true;
		}
		string text = trigger switch
		{
			"Idle" => "idle", 
			"Attack" => "attack", 
			"Cast" => "cast", 
			"Hit" => "hurt", 
			"Dead" => "die", 
			_ => trigger.ToLowerInvariant(), 
		};
		return !CustomAnimation.PlayCustomAnimation((Node)(object)__instance.Visuals, text, trigger);
	}
}
