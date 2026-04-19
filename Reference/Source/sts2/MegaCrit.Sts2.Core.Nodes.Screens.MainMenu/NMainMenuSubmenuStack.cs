using System;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NMainMenuSubmenuStack.cs")]
public class NMainMenuSubmenuStack : NSubmenuStack
{
	public new class MethodName : NSubmenuStack.MethodName
	{
		public new static readonly StringName _Ready;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenuStack.PropertyName
	{
		public static readonly StringName _settingsScreenScene;

		public static readonly StringName _characterSelectScreenScene;

		public static readonly StringName _singleplayerSubmenu;

		public static readonly StringName _multiplayerSubmenu;

		public static readonly StringName _multiplayerHostSubmenu;

		public static readonly StringName _joinFriendSubmenu;

		public static readonly StringName _characterSelectSubmenu;

		public static readonly StringName _loadMultiplayerSubmenu;

		public static readonly StringName _compendiumSubmenu;

		public static readonly StringName _bestiarySubmenu;

		public static readonly StringName _relicCollectionSubmenu;

		public static readonly StringName _potionLabSubmenu;

		public static readonly StringName _cardLibrarySubmenu;

		public static readonly StringName _runHistorySubmenu;

		public static readonly StringName _statsScreen;

		public static readonly StringName _timelineScreen;

		public static readonly StringName _settingsScreen;

		public static readonly StringName _dailyScreen;

		public static readonly StringName _dailyLoadScreen;

		public static readonly StringName _customRunScreen;

		public static readonly StringName _customRunLoadScreen;

		public static readonly StringName _moddingScreen;

		public static readonly StringName _profileScreen;

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

	public extern NMainMenuSubmenuStack();
}
