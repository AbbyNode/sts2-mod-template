using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection;

[ScriptPath("res://src/Core/Nodes/Screens/RelicCollection/NRelicCollectionCategory.cs")]
public class NRelicCollectionCategory : VBoxContainer
{
	public new class MethodName : VBoxContainer.MethodName
	{
		public static readonly StringName CreateForSubcategory;

		public new static readonly StringName _Ready;

		public static readonly StringName LoadIcon;

		public static readonly StringName ClearRelics;

		public static readonly StringName OnRelicEntryPressed;

		public extern MethodName();
	}

	public new class PropertyName : VBoxContainer.PropertyName
	{
		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _collection;

		public static readonly StringName _headerLabel;

		public static readonly StringName _relicsContainer;

		public static readonly StringName _spacer;

		public static readonly StringName _icon;

		public extern PropertyName();
	}

	public new class SignalName : VBoxContainer.SignalName
	{
		public extern SignalName();
	}

	public static readonly string scenePath;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Control? DefaultFocusedControl { get; }

	public override extern void _Ready();

	public extern void LoadRelics(RelicRarity relicRarity, NRelicCollection collection, LocString header, HashSet<RelicModel> seenRelics, UnlockState unlockState, HashSet<RelicModel> allUnlockedRelics);

	public extern void ClearRelics();

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

	public extern NRelicCollectionCategory();
}
