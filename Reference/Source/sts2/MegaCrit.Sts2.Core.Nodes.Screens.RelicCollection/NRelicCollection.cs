using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

namespace MegaCrit.Sts2.Core.Nodes.Screens.RelicCollection;

[ScriptPath("res://src/Core/Nodes/Screens/RelicCollection/NRelicCollection.cs")]
public class NRelicCollection : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName OnSubmenuOpened;

		public new static readonly StringName OnSubmenuClosed;

		public new static readonly StringName OnSubmenuShown;

		public static readonly StringName ClearRelics;

		public static readonly StringName SetLastFocusedRelic;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _screenContents;

		public static readonly StringName _starter;

		public static readonly StringName _common;

		public static readonly StringName _uncommon;

		public static readonly StringName _rare;

		public static readonly StringName _shop;

		public static readonly StringName _ancient;

		public static readonly StringName _event;

		public static readonly StringName _screenTween;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<RelicModel> Relics { get; }

	public static extern string[] AssetPaths { get; }

	protected override extern Control? InitialFocusedControl { get; }

	public static extern NRelicCollection? Create();

	public override extern void _Ready();

	public override extern void OnSubmenuOpened();

	public override extern void OnSubmenuClosed();

	protected override extern void OnSubmenuShown();

	public extern void AddRelics(IEnumerable<RelicModel> relics);

	public extern void SetLastFocusedRelic(NRelicCollectionEntry relic);

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

	public extern NRelicCollection();
}
