using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BaseLib.Utils;
using BaseLib.Utils.ModInterop;
using BaseLib.Utils.Patching;
using HarmonyLib;
using MegaCrit.Sts2.Core.Modding;

namespace BaseLib.Patches.Features;

internal class ModInterop
{
	private static class QuickTranspiler
	{
		public static List<CodeInstruction> Insert = new List<CodeInstruction>();

		public static List<CodeInstruction> Transpile(IEnumerable<CodeInstruction> instructions)
		{
			return new InstructionPatcher(instructions).Match(new InstructionMatcher().ret()).Step(-1).Insert((IEnumerable<CodeInstruction>)Insert);
		}
	}

	private static readonly BindingFlags ValidMemberFlags = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;

	private static readonly FieldInfo WrappedValueField = AccessTools.DeclaredField(typeof(InteropClassWrapper), "Value");

	private readonly Dictionary<string, Assembly?> _loadedIds;

	internal ModInterop()
	{
		BaseLibMain.Logger.Info("Generating interop methods and properties", 1);
		_loadedIds = (from mod in BetaMainCompatibility.Renamed.LoadedMods.Get()
			where mod.manifest != null && mod.assembly != null
			select mod).ToDictionary((Mod mod) => mod.manifest?.id ?? "", (Mod mod) => mod.assembly);
	}

	internal void ProcessType(Harmony harmony, Type t)
	{
		ModInteropAttribute customAttribute = t.GetCustomAttribute<ModInteropAttribute>();
		if (customAttribute != null && _loadedIds.TryGetValue(customAttribute.ModId, out Assembly value))
		{
			if (value == null)
			{
				BaseLibMain.Logger.Error("Cannot generate interop for mod " + customAttribute.ModId + ", assembly not found", 1);
				return;
			}
			BaseLibMain.Logger.Info($"Interop type {t} for mod {customAttribute.ModId}", 1);
			GenInteropMembers(t.GetMembers(ValidMemberFlags), harmony, value, customAttribute.Type, requireStatic: true);
		}
	}

	private static bool GenInteropMembers(MemberInfo[] members, Harmony harmony, Assembly assembly, string? contextTargetType, bool requireStatic)
	{
		foreach (MemberInfo memberInfo in members)
		{
			if (!(memberInfo is PropertyInfo propertyInfo))
			{
				if (!(memberInfo is MethodInfo methodInfo))
				{
					if (memberInfo is TypeInfo typeInfo && typeInfo.IsAssignableTo(typeof(InteropClassWrapper)) && !GenInteropType(harmony, assembly, contextTargetType, typeInfo))
					{
						return false;
					}
				}
				else if ((!requireStatic || methodInfo.IsStatic) && !methodInfo.IsConstructor && methodInfo.GetCustomAttribute<CompilerGeneratedAttribute>() == null && !GenInteropMethod(harmony, assembly, contextTargetType, methodInfo))
				{
					return false;
				}
				continue;
			}
			if (requireStatic)
			{
				MethodInfo? setMethod = propertyInfo.SetMethod;
				if ((object)setMethod != null && !setMethod.IsStatic)
				{
					continue;
				}
			}
			if (GenInteropPropertyOrField(harmony, assembly, contextTargetType, propertyInfo))
			{
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool GenInteropType(Harmony harmony, Assembly targetAssembly, string? contextTargetType, TypeInfo type)
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		ConstructorInfo[] constructors = type.GetConstructors();
		if (constructors.Length < 1)
		{
			throw new Exception($"{type} must have at least one public constructor");
		}
		InteropTargetAttribute customAttribute = type.GetCustomAttribute<InteropTargetAttribute>();
		string text = customAttribute?.Type ?? customAttribute?.Name ?? contextTargetType ?? throw new Exception($"No target type provided for Interop type {type}");
		try
		{
			Type type2 = Type.GetType($"{text}, {targetAssembly}") ?? throw new Exception($"Type {text} not found in assembly {targetAssembly}");
			ConstructorInfo[] array = constructors;
			foreach (ConstructorInfo constructorInfo in array)
			{
				Type[] array2 = (from p in constructorInfo.GetParameters()
					select p.ParameterType).ToArray();
				ConstructorInfo constructor = type2.GetConstructor(array2);
				if (constructor == null)
				{
					throw new Exception("Failed to find matching constructor for " + GeneralExtensions.FullDescription((MethodBase)constructorInfo));
				}
				List<CodeInstruction> list = new List<CodeInstruction>();
				list.Add(CodeInstruction.LoadArgument(0, false));
				list.AddRange(from param in array2.Index()
					select CodeInstruction.LoadArgument(param.Index + 1, false));
				list.Add(new CodeInstruction(OpCodes.Newobj, (object)constructor));
				list.Add(new CodeInstruction(OpCodes.Stfld, (object)WrappedValueField));
				QuickTranspiler.Insert = list;
				harmony.Patch((MethodBase)constructorInfo, (HarmonyMethod)null, (HarmonyMethod)null, new HarmonyMethod((Delegate)new Func<IEnumerable<CodeInstruction>, List<CodeInstruction>>(QuickTranspiler.Transpile)), (HarmonyMethod)null);
			}
			BaseLibMain.Logger.Info("Generated interop type " + type.FullName, 1);
			return GenInteropMembers(type.GetMembers(ValidMemberFlags), harmony, targetAssembly, text, requireStatic: false);
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Info(ex.ToString(), 1);
			return false;
		}
	}

	private static bool GenInteropMethod(Harmony harmony, Assembly targetAssembly, string? contextTargetType, MethodInfo method)
	{
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		InteropTargetAttribute? customAttribute = method.GetCustomAttribute<InteropTargetAttribute>();
		string value = customAttribute?.Type ?? contextTargetType ?? throw new Exception("Mod interop " + GeneralExtensions.FullDescription((MethodBase)method) + " does not define target type");
		string text = customAttribute?.Name ?? method.Name;
		try
		{
			Type type = Type.GetType($"{value}, {targetAssembly}") ?? throw new Exception($"Type {value} not found in assembly {targetAssembly}");
			Type[] array = (from p in method.GetParameters()
				select p.ParameterType).ToArray();
			Type[] array2 = (method.IsStatic ? array.Skip(1).ToArray() : array);
			MethodInfo methodInfo = null;
			List<CodeInstruction> list = new List<CodeInstruction>();
			foreach (MethodInfo declaredMethod in AccessToolsExtensions.GetDeclaredMethods(type))
			{
				if (declaredMethod.Name != text)
				{
					continue;
				}
				ParameterInfo[] parameters = declaredMethod.GetParameters();
				Type[] checkParams = (declaredMethod.IsStatic ? array : array2);
				if (!CheckParamMatch(parameters, checkParams))
				{
					continue;
				}
				methodInfo = declaredMethod;
				if (!methodInfo.IsStatic && method.IsStatic)
				{
					throw new Exception($"Method {method} should not be static to match target {methodInfo}");
				}
				if (methodInfo.ReturnType != typeof(void))
				{
					list.Add(new CodeInstruction(OpCodes.Pop, (object)null));
				}
				int num = 0;
				if (!methodInfo.IsStatic)
				{
					if (method.IsStatic)
					{
						list.Add(CodeInstruction.LoadArgument(0, false));
						if (array[0] != type)
						{
							list.Add(new CodeInstruction(OpCodes.Castclass, (object)type));
						}
						num++;
					}
					else
					{
						list.Add(CodeInstruction.LoadArgument(0, false));
						list.Add(new CodeInstruction(OpCodes.Ldfld, (object)WrappedValueField));
					}
				}
				for (int num2 = 0; num2 < parameters.Length; num2++)
				{
					list.Add(CodeInstruction.LoadArgument(num2 + num, false));
					if (array[num2 + num] != parameters[num2].ParameterType)
					{
						list.Add(new CodeInstruction(OpCodes.Castclass, (object)parameters[num2].ParameterType));
					}
				}
				break;
			}
			if (methodInfo == null)
			{
				throw new Exception($"Method {text} with matching parameters not found in type {type}");
			}
			if (methodInfo.ReturnType != method.ReturnType)
			{
				throw new Exception($"Method {text} return type {method.ReturnType} does not match target method return type {methodInfo.ReturnType}");
			}
			List<CodeInstruction> list2 = list;
			int num3 = 1 + list2.Count;
			List<CodeInstruction> list3 = new List<CodeInstruction>(num3);
			CollectionsMarshal.SetCount(list3, num3);
			Span<CodeInstruction> span = CollectionsMarshal.AsSpan(list3);
			int num4 = 0;
			Span<CodeInstruction> span2 = CollectionsMarshal.AsSpan(list2);
			span2.CopyTo(span.Slice(num4, span2.Length));
			num4 += span2.Length;
			span[num4] = new CodeInstruction(OpCodes.Call, (object)methodInfo);
			QuickTranspiler.Insert = list3;
			harmony.Patch((MethodBase)method, (HarmonyMethod)null, (HarmonyMethod)null, new HarmonyMethod((Delegate)new Func<IEnumerable<CodeInstruction>, List<CodeInstruction>>(QuickTranspiler.Transpile)), (HarmonyMethod)null);
			BaseLibMain.Logger.Info("Generated interop method " + method.Name, 1);
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Info(ex.ToString(), 1);
			return false;
		}
		return true;
	}

	private static bool GenInteropPropertyOrField(Harmony harmony, Assembly targetAssembly, string? contextTargetType, PropertyInfo property)
	{
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected O, but got Unknown
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected O, but got Unknown
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected O, but got Unknown
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Expected O, but got Unknown
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected O, but got Unknown
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected O, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected O, but got Unknown
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Expected O, but got Unknown
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081d: Expected O, but got Unknown
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		InteropTargetAttribute? customAttribute = property.GetCustomAttribute<InteropTargetAttribute>();
		string text = customAttribute?.Type ?? contextTargetType ?? throw new Exception($"Mod interop {property} does not define target type");
		string text2 = customAttribute?.Name ?? property.Name;
		try
		{
			Type type = Type.GetType($"{text}, {targetAssembly}") ?? throw new Exception($"Type {text} not found in assembly {targetAssembly}");
			PropertyInfo propertyInfo = AccessToolsExtensions.DeclaredProperty(type, text2);
			if (propertyInfo != null && propertyInfo.PropertyType == property.PropertyType)
			{
				if (propertyInfo.SetMethod == null && propertyInfo.GetMethod == null)
				{
					throw new Exception($"Cannot get or set target property {propertyInfo}");
				}
				MethodInfo? setMethod = propertyInfo.SetMethod;
				bool flag = ((object)setMethod != null && setMethod.IsStatic) || (propertyInfo.GetMethod?.IsStatic ?? false);
				MethodInfo? setMethod2 = property.SetMethod;
				bool flag2 = ((object)setMethod2 != null && setMethod2.IsStatic) || (property.GetMethod?.IsStatic ?? false);
				if (flag && !flag2)
				{
					throw new Exception($"Target property {propertyInfo} is static; interop property must also be static");
				}
				if (flag2 && !flag)
				{
					throw new Exception($"Target property {propertyInfo} is not static; interop property should not be static");
				}
				if (propertyInfo.SetMethod != null)
				{
					if (property.SetMethod == null)
					{
						throw new Exception($"Property {property} should have a setter to match target property");
					}
					if (flag)
					{
						int num = 2;
						List<CodeInstruction> list = new List<CodeInstruction>(num);
						CollectionsMarshal.SetCount(list, num);
						Span<CodeInstruction> span = CollectionsMarshal.AsSpan(list);
						int num2 = 0;
						span[num2] = new CodeInstruction(OpCodes.Ldarg_0, (object)null);
						num2++;
						span[num2] = new CodeInstruction(OpCodes.Call, (object)propertyInfo.SetMethod);
						QuickTranspiler.Insert = list;
					}
					else
					{
						int num2 = 4;
						List<CodeInstruction> list2 = new List<CodeInstruction>(num2);
						CollectionsMarshal.SetCount(list2, num2);
						Span<CodeInstruction> span2 = CollectionsMarshal.AsSpan(list2);
						int num = 0;
						span2[num] = new CodeInstruction(OpCodes.Ldarg_0, (object)null);
						num++;
						span2[num] = new CodeInstruction(OpCodes.Ldfld, (object)WrappedValueField);
						num++;
						span2[num] = new CodeInstruction(OpCodes.Ldarg_1, (object)null);
						num++;
						span2[num] = new CodeInstruction(OpCodes.Call, (object)propertyInfo.SetMethod);
						QuickTranspiler.Insert = list2;
					}
					harmony.Patch((MethodBase)property.SetMethod, (HarmonyMethod)null, (HarmonyMethod)null, new HarmonyMethod((Delegate)new Func<IEnumerable<CodeInstruction>, List<CodeInstruction>>(QuickTranspiler.Transpile)), (HarmonyMethod)null);
				}
				if (propertyInfo.GetMethod != null)
				{
					if (property.GetMethod == null)
					{
						throw new Exception($"Property {property} should have a getter to match target property");
					}
					if (flag)
					{
						int num = 2;
						List<CodeInstruction> list3 = new List<CodeInstruction>(num);
						CollectionsMarshal.SetCount(list3, num);
						Span<CodeInstruction> span3 = CollectionsMarshal.AsSpan(list3);
						int num2 = 0;
						span3[num2] = new CodeInstruction(OpCodes.Pop, (object)null);
						num2++;
						span3[num2] = new CodeInstruction(OpCodes.Call, (object)propertyInfo.GetMethod);
						QuickTranspiler.Insert = list3;
					}
					else
					{
						int num2 = 4;
						List<CodeInstruction> list4 = new List<CodeInstruction>(num2);
						CollectionsMarshal.SetCount(list4, num2);
						Span<CodeInstruction> span4 = CollectionsMarshal.AsSpan(list4);
						int num = 0;
						span4[num] = new CodeInstruction(OpCodes.Pop, (object)null);
						num++;
						span4[num] = new CodeInstruction(OpCodes.Ldarg_0, (object)null);
						num++;
						span4[num] = new CodeInstruction(OpCodes.Ldfld, (object)WrappedValueField);
						num++;
						span4[num] = new CodeInstruction(OpCodes.Call, (object)propertyInfo.GetMethod);
						QuickTranspiler.Insert = list4;
					}
					harmony.Patch((MethodBase)property.GetMethod, (HarmonyMethod)null, (HarmonyMethod)null, new HarmonyMethod((Delegate)new Func<IEnumerable<CodeInstruction>, List<CodeInstruction>>(QuickTranspiler.Transpile)), (HarmonyMethod)null);
				}
				BaseLibMain.Logger.Info("Generated interop property " + property.Name, 1);
				return true;
			}
			FieldInfo fieldInfo = AccessToolsExtensions.DeclaredField(type, text2);
			if (fieldInfo != null && fieldInfo.FieldType == property.PropertyType)
			{
				if (property.SetMethod == null)
				{
					throw new Exception($"Interop property {property} should have a setter for field {fieldInfo}");
				}
				if (property.GetMethod == null)
				{
					throw new Exception($"Interop property {property} should have a getter for field {fieldInfo}");
				}
				MethodInfo? setMethod3 = property.SetMethod;
				bool flag3 = ((object)setMethod3 != null && setMethod3.IsStatic) || (property.GetMethod?.IsStatic ?? false);
				if (fieldInfo.IsStatic && !flag3)
				{
					throw new Exception($"Target field {fieldInfo} is static; interop property must also be static");
				}
				if (flag3 && !fieldInfo.IsStatic)
				{
					throw new Exception($"Target field {fieldInfo} is not static; interop property should not be static");
				}
				if (fieldInfo.IsStatic)
				{
					int num = 2;
					List<CodeInstruction> list5 = new List<CodeInstruction>(num);
					CollectionsMarshal.SetCount(list5, num);
					Span<CodeInstruction> span5 = CollectionsMarshal.AsSpan(list5);
					int num2 = 0;
					span5[num2] = new CodeInstruction(OpCodes.Ldarg_0, (object)null);
					num2++;
					span5[num2] = new CodeInstruction(OpCodes.Stfld, (object)fieldInfo);
					QuickTranspiler.Insert = list5;
				}
				else
				{
					int num2 = 4;
					List<CodeInstruction> list6 = new List<CodeInstruction>(num2);
					CollectionsMarshal.SetCount(list6, num2);
					Span<CodeInstruction> span6 = CollectionsMarshal.AsSpan(list6);
					int num = 0;
					span6[num] = new CodeInstruction(OpCodes.Ldarg_0, (object)null);
					num++;
					span6[num] = new CodeInstruction(OpCodes.Ldfld, (object)WrappedValueField);
					num++;
					span6[num] = new CodeInstruction(OpCodes.Ldarg_1, (object)null);
					num++;
					span6[num] = new CodeInstruction(OpCodes.Stfld, (object)fieldInfo);
					QuickTranspiler.Insert = list6;
				}
				harmony.Patch((MethodBase)property.SetMethod, (HarmonyMethod)null, (HarmonyMethod)null, new HarmonyMethod((Delegate)new Func<IEnumerable<CodeInstruction>, List<CodeInstruction>>(QuickTranspiler.Transpile)), (HarmonyMethod)null);
				if (fieldInfo.IsStatic)
				{
					int num = 2;
					List<CodeInstruction> list7 = new List<CodeInstruction>(num);
					CollectionsMarshal.SetCount(list7, num);
					Span<CodeInstruction> span7 = CollectionsMarshal.AsSpan(list7);
					int num2 = 0;
					span7[num2] = new CodeInstruction(OpCodes.Pop, (object)null);
					num2++;
					span7[num2] = new CodeInstruction(OpCodes.Ldfld, (object)fieldInfo);
					QuickTranspiler.Insert = list7;
				}
				else
				{
					int num2 = 4;
					List<CodeInstruction> list8 = new List<CodeInstruction>(num2);
					CollectionsMarshal.SetCount(list8, num2);
					Span<CodeInstruction> span8 = CollectionsMarshal.AsSpan(list8);
					int num = 0;
					span8[num] = new CodeInstruction(OpCodes.Pop, (object)null);
					num++;
					span8[num] = new CodeInstruction(OpCodes.Ldarg_0, (object)null);
					num++;
					span8[num] = new CodeInstruction(OpCodes.Ldfld, (object)WrappedValueField);
					num++;
					span8[num] = new CodeInstruction(OpCodes.Ldfld, (object)fieldInfo);
					QuickTranspiler.Insert = list8;
				}
				harmony.Patch((MethodBase)property.GetMethod, (HarmonyMethod)null, (HarmonyMethod)null, new HarmonyMethod((Delegate)new Func<IEnumerable<CodeInstruction>, List<CodeInstruction>>(QuickTranspiler.Transpile)), (HarmonyMethod)null);
				BaseLibMain.Logger.Info("Generated interop field property " + property.Name, 1);
				return true;
			}
			throw new Exception("Could not find property or field for name " + text2 + " in type " + text);
		}
		catch (Exception ex)
		{
			BaseLibMain.Logger.Info(ex.ToString(), 1);
			return false;
		}
	}

	/// <summary>
	/// Check if checkParams can be passed as targetParams, with object being treated as a wildcard.
	/// </summary>
	/// <param name="targetParams"></param>
	/// <param name="checkParams"></param>
	/// <returns></returns>
	private static bool CheckParamMatch(ParameterInfo[] targetParams, Type[] checkParams)
	{
		if (targetParams.Length != checkParams.Length)
		{
			return false;
		}
		return !checkParams.Where((Type t, int i) => t != typeof(object) && !t.IsAssignableTo(targetParams[i].ParameterType)).Any();
	}
}
