using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NMultiplayerVoteContainer.cs")]
public class NMultiplayerVoteContainer : Control
{
	public delegate bool PlayerVotedDelegate(Player player);

	public new class MethodName : Control.MethodName
	{
		public static readonly StringName RefreshPlayerVotes;

		public static readonly StringName BouncePlayers;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern IEnumerable<Player> Players { get; }

	public extern void Initialize(PlayerVotedDelegate del, IReadOnlyList<Player> players);

	public extern void RefreshPlayerVotes(bool animate = true);

	public extern int GetVoteIndex(Player player);

	public extern void SetPlayerHighlighted(Player player, bool isHighlighted);

	public extern void BouncePlayers();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NMultiplayerVoteContainer();
}
