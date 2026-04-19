using System;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

namespace MegaCrit.Sts2.Core.Nodes.Screens;

[ScriptPath("res://src/Core/Nodes/Screens/NRunSubmenuStack.cs")]
public class NRunSubmenuStack : NSubmenuStack
{
	public new class MethodName : NSubmenuStack.MethodName
	{
		public new static readonly StringName _Ready;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenuStack.PropertyName
	{
		public static readonly StringName _settingsScreenScene;

		public static readonly StringName _pauseMenuScene;

		public static readonly StringName _statsScreenScene;

		public static readonly StringName _runHistoryScreenScene;

		public static readonly StringName _compendiumSubmenu;

		public static readonly StringName _bestiarySubmenu;

		public static readonly StringName _relicCollectionSubmenu;

		public static readonly StringName _potionLabSubmenu;

		public static readonly StringName _cardLibrarySubmenu;

		public static readonly StringName _runHistoryScreen;

		public static readonly StringName _settingsScreen;

		public static readonly StringName _statsScreen;

		public static readonly StringName _pauseMenu;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenuStack.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public override extern T PushSubmenuType<T>();

	public override extern T GetSubmenuType<T>();

	public override extern NSubmenu PushSubmenuType(Type type);

	public override extern NSubmenu GetSubmenuType(Type type);

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

	public extern NRunSubmenuStack();
}
