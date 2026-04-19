using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Connection;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;

namespace MegaCrit.Sts2.Core.Nodes.Debug.Multiplayer;

[ScriptPath("res://src/Core/Nodes/Debug/Multiplayer/NMultiplayerTest.cs")]
public class NMultiplayerTest : Control, IStartRunLobbyListener
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName AddGame;

		public static readonly StringName HostButtonPressed;

		public static readonly StringName SteamHostButtonPressed;

		public static readonly StringName JoinButtonPressed;

		public static readonly StringName ReadyButtonPressed;

		public new static readonly StringName Disconnect;

		public static readonly StringName AfterMultiplayerStarted;

		public static readonly StringName ChooseReplayToLoad;

		public static readonly StringName LoadReplay;

		public new static readonly StringName _Process;

		public static readonly StringName AscensionChanged;

		public static readonly StringName SeedChanged;

		public static readonly StringName ModifiersChanged;

		public static readonly StringName MaxAscensionChanged;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _ipField;

		public static readonly StringName _idField;

		public static readonly StringName _readyButton;

		public static readonly StringName _readyIndicator;

		public static readonly StringName _loadingPanel;

		public static readonly StringName _characterPaginator;

		public static readonly StringName _game;

		public static readonly StringName _ignoreReplayModelIdHash;

		public static readonly StringName _beginningRun;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void BeginRun(string seed, List<ActModel> acts, IReadOnlyList<ModifierModel> __);

	[AsyncStateMachine(typeof(_003CJoinToHost_003Ed__27))]
	public extern Task JoinToHost(IClientConnectionInitializer initializer);

	public override extern void _Process(double delta);

	public extern void PlayerConnected(LobbyPlayer player);

	public extern void PlayerChanged(LobbyPlayer player);

	public extern void AscensionChanged();

	public extern void SeedChanged();

	public extern void ModifiersChanged();

	public extern void MaxAscensionChanged();

	public extern void RemotePlayerDisconnected(LobbyPlayer player);

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

	public extern NMultiplayerTest();
}
