using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
using MegaCrit.Sts2.Core.Platform;

namespace MegaCrit.Sts2.Core.Nodes.Multiplayer;

[ScriptPath("res://src/Core/Nodes/Multiplayer/NRemoteLobbyPlayer.cs")]
public class NRemoteLobbyPlayer : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName RefreshVisuals;

		public static readonly StringName CancelShake;

		public new static readonly StringName _Process;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName PlayerId;

		public static readonly StringName _characterIcon;

		public static readonly StringName _readyIndicator;

		public static readonly StringName _disconnectedIndicator;

		public static readonly StringName _nameplateLabel;

		public static readonly StringName _characterLabel;

		public static readonly StringName _platform;

		public static readonly StringName _isSingleplayer;

		public static readonly StringName _playerId;

		public static readonly StringName _isReady;

		public static readonly StringName _isConnected;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern ulong PlayerId { get; }

	public static extern NRemoteLobbyPlayer Create(LobbyPlayer player, PlatformType platform, bool isSingleplayer);

	public static extern NRemoteLobbyPlayer Create(LoadRunLobby runLobby, ulong playerId, PlatformType platform, bool isSingleplayer);

	public override extern void _Ready();

	public extern void OnPlayerChanged(LobbyPlayer lobbyPlayer);

	public extern void OnPlayerChanged(LoadRunLobby runLobby, ulong playerId);

	public extern void CancelShake();

	public override extern void _Process(double delta);

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

	public extern NRemoteLobbyPlayer();
}
