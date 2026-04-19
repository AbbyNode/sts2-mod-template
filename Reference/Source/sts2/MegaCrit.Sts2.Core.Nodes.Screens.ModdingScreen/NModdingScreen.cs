using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

namespace MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen;

[ScriptPath("res://src/Core/Nodes/Screens/ModdingScreen/NModdingScreen.cs")]
public class NModdingScreen : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName OnSubmenuOpened;

		public static readonly StringName OnGetModsPressed;

		public static readonly StringName OnMakeModsPressed;

		public static readonly StringName OnRowSelected;

		public static readonly StringName OnModEnabledOrDisabled;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _modInfoContainer;

		public static readonly StringName _modRowContainer;

		public static readonly StringName _pendingChangesWarning;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern Control? InitialFocusedControl { get; }

	public static extern string[] AssetPaths { get; }

	public static extern NModdingScreen? Create();

	public override extern void _Ready();

	public override extern void OnSubmenuOpened();

	public extern void OnRowSelected(NModMenuRow row);

	public extern void OnModEnabledOrDisabled();

	public override extern void _ExitTree();

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

	public extern NModdingScreen();
}
