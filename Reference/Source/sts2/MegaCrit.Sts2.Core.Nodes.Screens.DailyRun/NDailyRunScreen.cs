using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
using MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

namespace MegaCrit.Sts2.Core.Nodes.Screens.DailyRun;

[ScriptPath("res://src/Core/Nodes/Screens/DailyRun/NDailyRunScreen.cs")]
public class NDailyRunScreen : NSubmenu, IStartRunLobbyListener
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName InitializeSingleplayer;

		public new static readonly StringName OnSubmenuOpened;

		public new static readonly StringName OnSubmenuClosed;

		public static readonly StringName InitializeLeaderboard;

		public static readonly StringName InitializeDisplay;

		public static readonly StringName SetIsLoading;

		public new static readonly StringName _Process;

		public static readonly StringName MaxAscensionChanged;

		public static readonly StringName AscensionChanged;

		public static readonly StringName SeedChanged;

		public static readonly StringName ModifiersChanged;

		public static readonly StringName OnEmbarkPressed;

		public static readonly StringName OnUnreadyPressed;

		public static readonly StringName UpdateRichPresence;

		public static readonly StringName CleanUpLobby;

		public static readonly StringName AfterLobbyInitialized;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _titleLabel;

		public static readonly StringName _dateLabel;

		public static readonly StringName _timeLeftLabel;

		public static readonly StringName _characterContainer;

		public static readonly StringName _embarkButton;

		public new static readonly StringName _backButton;

		public static readonly StringName _unreadyButton;

		public static readonly StringName _leaderboard;

		public static readonly StringName _modifiersTitleLabel;

		public static readonly StringName _modifiersContainer;

		public static readonly StringName _remotePlayerContainer;

		public static readonly StringName _readyAndWaitingContainer;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	public static readonly string dateFormat;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string[] AssetPaths { get; }

	protected override extern Control? InitialFocusedControl { get; }

	public static extern NDailyRunScreen? Create();

	public override extern void _Ready();

	public extern void InitializeMultiplayerAsHost(INetGameService gameService);

	public extern void InitializeMultiplayerAsClient(INetGameService gameService, ClientLobbyJoinResponseMessage message);

	public extern void InitializeSingleplayer();

	public override extern void OnSubmenuOpened();

	public override extern void OnSubmenuClosed();

	public override extern void _Process(double delta);

	public extern void PlayerConnected(LobbyPlayer player);

	public extern void PlayerChanged(LobbyPlayer player);

	public extern void MaxAscensionChanged();

	public extern void AscensionChanged();

	public extern void SeedChanged();

	public extern void ModifiersChanged();

	public extern void RemotePlayerDisconnected(LobbyPlayer player);

	public extern void BeginRun(string seed, List<ActModel> acts, IReadOnlyList<ModifierModel> modifiers);

	public extern void LocalPlayerDisconnected(NetErrorInfo info);

	[AsyncStateMachine(typeof(_003CStartNewSingleplayerRun_003Ed__53))]
	public extern Task StartNewSingleplayerRun(string seed, List<ActModel> acts, IReadOnlyList<ModifierModel> modifiers);

	[AsyncStateMachine(typeof(_003CStartNewMultiplayerRun_003Ed__54))]
	public extern Task StartNewMultiplayerRun(string seed, List<ActModel> acts, IReadOnlyList<ModifierModel> modifiers);

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

	public extern NDailyRunScreen();
}
