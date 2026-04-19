using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

namespace MegaCrit.Sts2.Core.Nodes.Screens.ProfileScreen;

[ScriptPath("res://src/Core/Nodes/Screens/ProfileScreen/NProfileScreen.cs")]
public class NProfileScreen : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName OnSubmenuOpened;

		public static readonly StringName ShowLoading;

		public static readonly StringName Refresh;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _loadingOverlay;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	public static int? forceShowProfileAsDeleted;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string[] AssetPaths { get; }

	protected override extern Control InitialFocusedControl { get; }

	public static extern NProfileScreen? Create();

	public override extern void _Ready();

	public override extern void OnSubmenuOpened();

	public extern void ShowLoading();

	public extern void Refresh();

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

	public extern NProfileScreen();
}
