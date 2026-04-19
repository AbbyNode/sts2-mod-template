using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
using MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect;

[ScriptPath("res://src/Core/Nodes/Screens/CharacterSelect/NMultiplayerLoadGameScreen.cs")]
public class NMultiplayerLoadGameScreen : NSubmenu, ILoadRunLobbyListener
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName OnSubmenuOpened;

		public new static readonly StringName OnSubmenuShown;

		public new static readonly StringName OnSubmenuClosed;

		public new static readonly StringName OnSubmenuHidden;

		public static readonly StringName OnEmbarkPressed;

		public static readonly StringName OnUnreadyPressed;

		public static readonly StringName UpdateRichPresence;

		public new static readonly StringName _Process;

		public static readonly StringName CleanUpLobby;

		public static readonly StringName PlayerConnected;

		public static readonly StringName PlayerReadyChanged;

		public static readonly StringName RemotePlayerDisconnected;

		public static readonly StringName BeginRun;

		public static readonly StringName AfterMultiplayerStarted;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _name;

		public static readonly StringName _infoPanel;

		public static readonly StringName _hp;

		public static readonly StringName _gold;

		public static readonly StringName _selectedButton;

		public static readonly StringName _bgContainer;

		public static readonly StringName _confirmButton;

		public new static readonly StringName _backButton;

		public static readonly StringName _unreadyButton;

		public static readonly StringName _ascensionPanel;

		public static readonly StringName _floorLabel;

		public static readonly StringName _actLabel;

		public static readonly StringName _remotePlayerContainer;

		public static readonly StringName _infoPanelTween;

		public static readonly StringName _infoPanelPosFinalVal;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	protected override extern Control? InitialFocusedControl { get; }

	public static extern NMultiplayerLoadGameScreen? Create();

	public override extern void _Ready();

	public extern void InitializeAsHost(INetGameService gameService, SerializableRun run);

	public extern void InitializeAsClient(INetGameService gameService, ClientLoadJoinResponseMessage message);

	public override extern void OnSubmenuOpened();

	protected override extern void OnSubmenuShown();

	public override extern void OnSubmenuClosed();

	protected override extern void OnSubmenuHidden();

	public override extern void _Process(double delta);

	[AsyncStateMachine(typeof(_003CShouldAllowRunToBegin_003Ed__35))]
	public extern Task<bool> ShouldAllowRunToBegin();

	public extern void PlayerConnected(ulong playerId);

	public extern void PlayerReadyChanged(ulong playerId);

	public extern void RemotePlayerDisconnected(ulong playerId);

	public extern void BeginRun();

	public extern void LocalPlayerDisconnected(NetErrorInfo info);

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

	public extern NMultiplayerLoadGameScreen();
}
