using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Relics;

[ScriptPath("res://src/Core/Nodes/Relics/NRelicInventory.cs")]
public class NRelicInventory : FlowContainer
{
	[Signal]
	public delegate void RelicsChangedEventHandler();

	public new class MethodName : FlowContainer.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName ConnectPlayerEvents;

		public static readonly StringName DisconnectPlayerEvents;

		public static readonly StringName OnRelicUnfocused;

		public static readonly StringName AnimShow;

		public static readonly StringName AnimHide;

		public static readonly StringName ShowImmediately;

		public static readonly StringName HideImmediately;

		public new static readonly StringName _Input;

		public static readonly StringName DebugHideTopBar;

		public static readonly StringName UpdateNavigation;

		public extern MethodName();
	}

	public new class PropertyName : FlowContainer.PropertyName
	{
		public static readonly StringName _originalPos;

		public static readonly StringName _curTween;

		public static readonly StringName _debugHideTween;

		public static readonly StringName _isDebugHidden;

		public extern PropertyName();
	}

	public new class SignalName : FlowContainer.SignalName
	{
		public static readonly StringName RelicsChanged;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<NRelicInventoryHolder> RelicNodes { get; }

	public extern event RelicsChangedEventHandler RelicsChanged;

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void Initialize(RunState runState);

	public extern void AnimateRelic(RelicModel relic, Vector2? startPosition = null, Vector2? startScale = null);

	public extern void AnimShow();

	public extern void AnimHide();

	public extern void ShowImmediately();

	public extern void HideImmediately();

	public override extern void _Input(InputEvent inputEvent);

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

	protected extern void EmitSignalRelicsChanged();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NRelicInventory();
}
