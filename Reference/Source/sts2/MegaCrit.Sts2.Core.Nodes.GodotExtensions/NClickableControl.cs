using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.GodotExtensions;

[ScriptPath("res://src/Core/Nodes/GodotExtensions/NClickableControl.cs")]
public class NClickableControl : Control
{
	[Signal]
	public delegate void ReleasedEventHandler(NClickableControl button);

	[Signal]
	public delegate void FocusedEventHandler(NClickableControl button);

	[Signal]
	public delegate void UnfocusedEventHandler(NClickableControl button);

	[Signal]
	public delegate void MouseReleasedEventHandler(InputEvent inputEvent);

	[Signal]
	public delegate void MousePressedEventHandler(InputEvent inputEvent);

	public new class MethodName : Control.MethodName
	{
		public static readonly StringName ConnectSignals;

		public static readonly StringName OnVisibilityChanged;

		public static readonly StringName OnFocusHandler;

		public static readonly StringName OnUnFocusHandler;

		public static readonly StringName HandleMousePress;

		public static readonly StringName HandleMouseRelease;

		public static readonly StringName OnHoverHandler;

		public static readonly StringName OnUnhoverHandler;

		public static readonly StringName OnPressHandler;

		public static readonly StringName OnReleaseHandler;

		public static readonly StringName RefreshFocus;

		public static readonly StringName OnFocus;

		public static readonly StringName OnUnfocus;

		public static readonly StringName OnPress;

		public static readonly StringName OnRelease;

		public new static readonly StringName _GuiInput;

		public static readonly StringName CheckMouseDragThreshold;

		public static readonly StringName DebugPress;

		public static readonly StringName DebugRelease;

		public static readonly StringName ForceClick;

		public static readonly StringName SetEnabled;

		public static readonly StringName Enable;

		public static readonly StringName Disable;

		public static readonly StringName OnEnable;

		public static readonly StringName OnDisable;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName AllowFocusWhileDisabled;

		public static readonly StringName IsFocused;

		public static readonly StringName IsEnabled;

		public static readonly StringName _ignoreDragThreshold;

		public static readonly StringName _isEnabled;

		public static readonly StringName _isHovered;

		public static readonly StringName _isControllerFocused;

		public static readonly StringName _isControllerNavigable;

		public static readonly StringName _beginDragPosition;

		public static readonly StringName _isPressed;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName Released;

		public static readonly StringName Focused;

		public static readonly StringName Unfocused;

		public static readonly StringName MouseReleased;

		public static readonly StringName MousePressed;

		public extern SignalName();
	}

	[Export(PropertyHint.None, "")]
	protected float _ignoreDragThreshold;

	protected bool _isEnabled;

	protected virtual extern bool AllowFocusWhileDisabled { get; }

	protected extern bool IsFocused
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsEnabled { get; }

	public extern event ReleasedEventHandler Released;

	public extern event FocusedEventHandler Focused;

	public extern event UnfocusedEventHandler Unfocused;

	public extern event MouseReleasedEventHandler MouseReleased;

	public extern event MousePressedEventHandler MousePressed;

	protected virtual extern void ConnectSignals();

	protected extern void OnPressHandler();

	protected extern void OnReleaseHandler();

	protected virtual extern void OnFocus();

	protected virtual extern void OnUnfocus();

	protected virtual extern void OnPress();

	protected virtual extern void OnRelease();

	public override extern void _GuiInput(InputEvent inputEvent);

	protected extern void CheckMouseDragThreshold(InputEvent inputEvent);

	public extern void DebugPress();

	public extern void DebugRelease();

	public extern void ForceClick();

	public extern void SetEnabled(bool enabled);

	public extern void Enable();

	public extern void Disable();

	protected virtual extern void OnEnable();

	protected virtual extern void OnDisable();

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

	protected extern void EmitSignalReleased(NClickableControl button);

	protected extern void EmitSignalFocused(NClickableControl button);

	protected extern void EmitSignalUnfocused(NClickableControl button);

	protected extern void EmitSignalMouseReleased(InputEvent inputEvent);

	protected extern void EmitSignalMousePressed(InputEvent inputEvent);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NClickableControl();
}
