using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Overlays;

[ScriptPath("res://src/Core/Nodes/Screens/Overlays/NOverlayStack.cs")]
public class NOverlayStack : Control
{
	[Signal]
	public delegate void ChangedEventHandler();

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName Clear;

		public static readonly StringName HideOverlays;

		public static readonly StringName ShowOverlays;

		public static readonly StringName ShowBackstop;

		public static readonly StringName HideBackstop;

		public static readonly StringName OnActiveScreenChanged;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName ScreenCount;

		public static readonly StringName _backstop;

		public static readonly StringName _backstopFade;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName Changed;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NOverlayStack? Instance { get; }

	public extern int ScreenCount { get; }

	public extern event ChangedEventHandler Changed;

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void Push(IOverlayScreen screen);

	public extern void Remove(IOverlayScreen screen);

	public extern void Clear();

	public extern void HideOverlays();

	public extern void ShowOverlays();

	public extern void ShowBackstop();

	public extern void HideBackstop();

	public extern IOverlayScreen? Peek();

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

	protected extern void EmitSignalChanged();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NOverlayStack();
}
