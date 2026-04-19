using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Multiplayer.Connection;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NJoinFriendScreen.cs")]
public class NJoinFriendScreen : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName OnSubmenuOpened;

		public new static readonly StringName OnSubmenuClosed;

		public static readonly StringName RefreshButtonClicked;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName DebugFriendsButtons;

		public static readonly StringName _buttonContainer;

		public static readonly StringName _loadingOverlay;

		public static readonly StringName _loadingFriendsIndicator;

		public static readonly StringName _noFriendsLabel;

		public static readonly StringName _refreshButton;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern Control? InitialFocusedControl { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern bool DebugFriendsButtons { get; }

	public static extern NJoinFriendScreen? Create();

	public override extern void _Ready();

	public override extern void OnSubmenuOpened();

	public override extern void OnSubmenuClosed();

	[AsyncStateMachine(typeof(_003CJoinGameAsync_003Ed__23))]
	public extern Task JoinGameAsync(IClientConnectionInitializer connInitializer);

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

	public extern NJoinFriendScreen();
}
