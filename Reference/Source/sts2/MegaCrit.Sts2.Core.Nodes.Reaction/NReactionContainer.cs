using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game;

namespace MegaCrit.Sts2.Core.Nodes.Reaction;

[ScriptPath("res://src/Core/Nodes/Reaction/NReactionContainer.cs")]
public class NReactionContainer : Control
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName DeinitializeNetworking;

		public new static readonly StringName _ExitTree;

		public static readonly StringName DoLocalReaction;

		public static readonly StringName DoRemoteReaction;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName InMultiplayer;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool InMultiplayer { get; }

	public extern void InitializeNetworking(INetGameService netService);

	public extern void DeinitializeNetworking();

	public override extern void _ExitTree();

	public extern void DoLocalReaction(Texture2D tex, Vector2 position);

	public extern void DoRemoteReaction(ReactionType type, Vector2 position);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NReactionContainer();
}
