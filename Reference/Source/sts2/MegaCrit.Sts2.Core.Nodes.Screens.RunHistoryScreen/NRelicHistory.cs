using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Nodes.Relics;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen;

[ScriptPath("res://src/Core/Nodes/Screens/RunHistoryScreen/NRelicHistory.cs")]
public class NRelicHistory : VBoxContainer
{
	[Signal]
	public delegate void HoveredEventHandler(NRelicBasicHolder relic);

	[Signal]
	public delegate void UnhoveredEventHandler(NRelicBasicHolder relic);

	public new class MethodName : VBoxContainer.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnRelicClicked;

		public extern MethodName();
	}

	public new class PropertyName : VBoxContainer.PropertyName
	{
		public static readonly StringName _headerLabel;

		public static readonly StringName _relicsContainer;

		public extern PropertyName();
	}

	public new class SignalName : VBoxContainer.SignalName
	{
		public static readonly StringName Hovered;

		public static readonly StringName Unhovered;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern event HoveredEventHandler Hovered;

	public extern event UnhoveredEventHandler Unhovered;

	public override extern void _Ready();

	public extern void LoadRelics(Player player, IEnumerable<SerializableRelic> relics);

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

	protected extern void EmitSignalHovered(NRelicBasicHolder relic);

	protected extern void EmitSignalUnhovered(NRelicBasicHolder relic);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NRelicHistory();
}
