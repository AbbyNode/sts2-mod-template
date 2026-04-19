using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BaseLib.Abstracts;
using BaseLib.Extensions;
using BaseLib.Patches.Localization;
using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Patches.Content;

/// <summary>
/// Generates and assigns values to fields marked with the CustomEnum attribute,
/// and also performs some special logic for certain types of enums, like keywords and piletypes.
/// </summary>
[HarmonyPatch(typeof(ModelDb), "Init")]
internal class GenEnumValues
{
	[HarmonyPrefix]
	private static void FindAndGenerate()
	{
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		List<FieldInfo> list = new List<FieldInfo>();
		Type[] modTypes = ReflectionHelper.ModTypes;
		for (int i = 0; i < modTypes.Length; i++)
		{
			foreach (FieldInfo item in from field in modTypes[i].GetFields()
				where Attribute.IsDefined(field, typeof(CustomEnumAttribute))
				select field)
			{
				if (!item.FieldType.IsEnum)
				{
					throw new Exception($"Field {item.DeclaringType?.FullName}.{item.Name} should be an enum type for CustomEnum");
				}
				if (!item.IsStatic)
				{
					throw new Exception($"Field {item.DeclaringType?.FullName}.{item.Name} should be static for CustomEnum");
				}
				if (!(item.DeclaringType == null))
				{
					list.Add(item);
				}
			}
		}
		list.Sort(delegate(FieldInfo a, FieldInfo b)
		{
			int num = string.Compare(a.Name, b.Name, StringComparison.Ordinal);
			return (num == 0) ? string.Compare(a.DeclaringType?.Name, b.DeclaringType?.Name, StringComparison.Ordinal) : num;
		});
		foreach (FieldInfo item2 in list)
		{
			CustomEnumAttribute customAttribute = item2.GetCustomAttribute<CustomEnumAttribute>();
			object obj = CustomEnums.GenerateKey(item2);
			Type declaringType = item2.DeclaringType;
			if (declaringType == null)
			{
				continue;
			}
			item2.SetValue(null, obj);
			if (item2.FieldType == typeof(CardKeyword))
			{
				string key = declaringType.GetPrefix() + (customAttribute?.Name ?? item2.Name).ToUpperInvariant();
				KeywordPropertiesAttribute customAttribute2 = item2.GetCustomAttribute<KeywordPropertiesAttribute>();
				AutoKeywordPosition autoKeywordPosition = customAttribute2?.Position ?? AutoKeywordPosition.None;
				switch (autoKeywordPosition)
				{
				case AutoKeywordPosition.Before:
					AutoKeywordText.AdditionalBeforeKeywords.Add((CardKeyword)obj);
					break;
				case AutoKeywordPosition.After:
					AutoKeywordText.AdditionalAfterKeywords.Add((CardKeyword)obj);
					break;
				}
				CustomKeywords.KeywordIDs.Add((int)obj, new CustomKeywords.KeywordInfo(key)
				{
					AutoPosition = autoKeywordPosition,
					RichKeyword = (customAttribute2?.RichKeyword ?? true)
				});
			}
			else if (!(item2.FieldType != typeof(PileType)) && declaringType.IsAssignableTo(typeof(CustomPile)))
			{
				ConstructorInfo constructor = declaringType.GetConstructor(BindingFlags.Instance | BindingFlags.Public, Array.Empty<Type>()) ?? throw new Exception("CustomPile " + declaringType.FullName + " with custom PileType does not have an accessible no-parameter constructor");
				PileType? val = (PileType?)item2.GetValue(null);
				if (!val.HasValue)
				{
					throw new Exception("Failed to be set up custom PileType in " + declaringType.FullName);
				}
				CustomPiles.RegisterCustomPile(val.Value, () => (CustomPile)constructor.Invoke(null));
			}
		}
	}
}
