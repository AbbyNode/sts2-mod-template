using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NMultiplayerSubmenu.cs")]
public class NMultiplayerSubmenu : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName UpdateButtons;

		public static readonly StringName AbandonRun;

		public static readonly StringName StartLoad;

		public static readonly StringName OnHostPressed;

		public static readonly StringName FastHost;

		public static readonly StringName OpenJoinFriendsScreen;

		public static readonly StringName OnJoinFriendsPressed;

		public new static readonly StringName OnSubmenuShown;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _hostButton;

		public static readonly StringName _loadButton;

		public static readonly StringName _abandonButton;

		public static readonly StringName _joinButton;

		public static readonly StringName _loadingOverlay;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern Control InitialFocusedControl { get; }

	public static extern NMultiplayerSubmenu? Create();

	public override extern void _Ready();

	public extern void FastHost(GameMode gameMode);

	public extern void StartHost(SerializableRun run);

	public extern NJoinFriendScreen OnJoinFriendsPressed();

	protected override extern void OnSubmenuShown();

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

	public extern NMultiplayerSubmenu();
}
