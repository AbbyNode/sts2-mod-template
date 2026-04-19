using System;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NSubmenuStack.cs")]
public abstract class NSubmenuStack : Control
{
	[Signal]
	public delegate void StackModifiedEventHandler();

	public new class MethodName : Control.MethodName
	{
		public static readonly StringName InitializeForMainMenu;

		public static readonly StringName Push;

		public static readonly StringName Pop;

		public static readonly StringName ShowBackstop;

		public static readonly StringName HideBackstop;

		public static readonly StringName Peek;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName SubmenusOpen;

		public static readonly StringName _mainMenu;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName StackModified;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool SubmenusOpen { get; }

	public extern event StackModifiedEventHandler StackModified;

	public extern void InitializeForMainMenu(NMainMenu mainMenu);

	public abstract T PushSubmenuType<T>() where T : NSubmenu;

	public abstract T GetSubmenuType<T>() where T : NSubmenu;

	public abstract NSubmenu PushSubmenuType(Type type);

	public abstract NSubmenu GetSubmenuType(Type type);

	public extern void Push(NSubmenu screen);

	public extern void Pop();

	public extern NSubmenu? Peek();

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

	protected extern void EmitSignalStackModified();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	protected extern NSubmenuStack();
}
