using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NSubmenu.cs")]
public abstract class NSubmenu : Control, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName ConnectSignals;

		public static readonly StringName HideBackButtonImmediately;

		public static readonly StringName SetStack;

		public static readonly StringName OnScreenVisibilityChange;

		public static readonly StringName OnSubmenuShown;

		public static readonly StringName OnSubmenuHidden;

		public static readonly StringName OnSubmenuOpened;

		public static readonly StringName OnSubmenuClosed;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName InitialFocusedControl;

		public static readonly StringName _backButton;

		public static readonly StringName _stack;

		public static readonly StringName _lastFocusedControl;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	protected NSubmenuStack _stack;

	protected Control? _lastFocusedControl;

	public extern Control? DefaultFocusedControl { get; }

	protected abstract Control? InitialFocusedControl { get; }

	public override extern void _Ready();

	protected virtual extern void ConnectSignals();

	public extern void HideBackButtonImmediately();

	public extern void SetStack(NSubmenuStack stack);

	protected virtual extern void OnSubmenuShown();

	protected virtual extern void OnSubmenuHidden();

	public virtual extern void OnSubmenuOpened();

	public virtual extern void OnSubmenuClosed();

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

	protected extern NSubmenu();
}
