using System;
using System.Reflection;
using BaseLib.Extensions;
using BaseLib.Patches.Content;
using BaseLib.Patches.Features;
using BaseLib.Patches.Utils;
using BaseLib.Utils;
using HarmonyLib;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace BaseLib.Patches;

[HarmonyPatch(typeof(LocManager), "Initialize")]
internal class PostModInitPatch
{
	[HarmonyPrefix]
	private static void ProcessModdedTypes()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		BaseLibMain.Logger.Info("Performing post-mod init patch", 1);
		Harmony harmony = new Harmony("PostModInit");
		AddActContent.Patch(harmony);
		ModInterop modInterop = new ModInterop();
		Type[] modTypes = ReflectionHelper.ModTypes;
		foreach (Type type in modTypes)
		{
			modInterop.ProcessType(harmony, type);
			bool flag = false;
			PropertyInfo[] properties = type.GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (((MemberInfo)propertyInfo).GetCustomAttribute<SavedPropertyAttribute>() == null || propertyInfo.DeclaringType == null)
				{
					continue;
				}
				if (propertyInfo.DeclaringType.GetRootNamespace() != "MegaCrit")
				{
					string value = propertyInfo.DeclaringType.GetRootNamespace() + "_";
					if (propertyInfo.Name.Length < 16 && !propertyInfo.Name.StartsWith(value))
					{
						BaseLibMain.Logger.Warn($"Recommended to add a prefix such as \"{value}\" to SavedProperty {propertyInfo.Name} for compatibility.", 1);
					}
				}
				flag = true;
			}
			FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			for (int j = 0; j < fields.Length; j++)
			{
				CheckSpecialSpireField(fields[j]);
			}
			if (flag)
			{
				SavedPropertiesTypeCache.InjectTypeIntoCache(type);
			}
		}
		SavedSpireFieldPatch.AddFieldsSorted();
	}

	private static void CheckSpecialSpireField(FieldInfo field)
	{
		Type fieldType = field.FieldType;
		if (fieldType.IsGenericType)
		{
			Type genericTypeDefinition = fieldType.GetGenericTypeDefinition();
			if (!(genericTypeDefinition != typeof(SavedSpireField<, >)) || !(genericTypeDefinition != typeof(AddedNode<, >)))
			{
				field.GetValue(null);
			}
		}
	}
}
