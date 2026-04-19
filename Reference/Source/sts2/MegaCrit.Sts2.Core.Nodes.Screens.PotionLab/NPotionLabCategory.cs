using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Potions;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Nodes.Screens.PotionLab;

[ScriptPath("res://src/Core/Nodes/Screens/PotionLab/NPotionLabCategory.cs")]
public class NPotionLabCategory : VBoxContainer
{
	public new class MethodName : VBoxContainer.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName ClearPotions;

		public extern MethodName();
	}

	public new class PropertyName : VBoxContainer.PropertyName
	{
		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _headerLabel;

		public static readonly StringName _potionContainer;

		public extern PropertyName();
	}

	public new class SignalName : VBoxContainer.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Control? DefaultFocusedControl { get; }

	public override extern void _Ready();

	public extern void LoadPotions(PotionRarity potionRarity, LocString header, HashSet<PotionModel> seenPotions, UnlockState unlockState, HashSet<PotionModel> allUnlockedPotions, PotionRarity? secondRarity = null);

	public extern void ClearPotions();

	public extern List<IReadOnlyList<Control>> GetGridItems();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool SetGodotClassPropertyValue(in godot_string_name name, in godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NPotionLabCategory();
}
