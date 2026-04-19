using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
using MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby;
using MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CustomRun;

[ScriptPath("res://src/Core/Nodes/Screens/CustomRun/NCustomRunScreen.cs")]
public class NCustomRunScreen : NSubmenu, IStartRunLobbyListener, ICharacterSelectButtonDelegate
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName InitializeSingleplayer;

		public static readonly StringName OnSeedInputSubmitted;

		public static readonly StringName InitCharacterButtons;

		public new static readonly StringName _Input;

		public static readonly StringName DebugUnlockAllCharacters;

		public new static readonly StringName OnSubmenuOpened;

		public new static readonly StringName OnSubmenuClosed;

		public static readonly StringName OnEmbarkPressed;

		public static readonly StringName OnUnreadyPressed;

		public static readonly StringName UpdateRichPresence;

		public new static readonly StringName _Process;

		public static readonly StringName CleanUpLobby;

		public static readonly StringName GetModifiersString;

		public static readonly StringName OnAscensionPanelLevelChanged;

		public static readonly StringName OnModifiersListChanged;

		public static readonly StringName MaxAscensionChanged;

		public static readonly StringName AscensionChanged;

		public static readonly StringName SeedChanged;

		public static readonly StringName ModifiersChanged;

		public static readonly StringName AfterInitialized;

		public static readonly StringName UpdateControllerButton;

		public static readonly StringName TryFocusOnModifiersList;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public static readonly StringName ModifiersHotkey;

		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _selectedButton;

		public static readonly StringName _charButtonContainer;

		public static readonly StringName _confirmButton;

		public new static readonly StringName _backButton;

		public static readonly StringName _unreadyButton;

		public static readonly StringName _ascensionPanel;

		public static readonly StringName _readyAndWaitingContainer;

		public static readonly StringName _seedInput;

		public static readonly StringName _remotePlayerContainer;

		public static readonly StringName _modifiersList;

		public static readonly StringName _modifiersHotkeyIcon;

		public static readonly StringName _uiMode;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern StartRunLobby Lobby { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	protected override extern Control InitialFocusedControl { get; }

	public static extern NCustomRunScreen? Create();

	public override extern void _Ready();

	public extern void InitializeMultiplayerAsHost(INetGameService gameService, int maxPlayers);

	public extern void InitializeMultiplayerAsClient(INetGameService gameService, ClientLobbyJoinResponseMessage message);

	public extern void InitializeSingleplayer();

	public override extern void _Input(InputEvent inputEvent);

	public override extern void OnSubmenuOpened();

	public override extern void OnSubmenuClosed();

	public override extern void _Process(double delta);

	public extern void SelectCharacter(NCharacterSelectButton charSelectButton, CharacterModel characterModel);

	public extern void MaxAscensionChanged();

	public extern void PlayerConnected(LobbyPlayer player);

	public extern void PlayerChanged(LobbyPlayer player);

	public extern void AscensionChanged();

	public extern void SeedChanged();

	public extern void ModifiersChanged();

	public extern void RemotePlayerDisconnected(LobbyPlayer player);

	public extern void BeginRun(string seed, List<ActModel> acts, IReadOnlyList<ModifierModel> modifiers);

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

	public extern NCustomRunScreen();
}
