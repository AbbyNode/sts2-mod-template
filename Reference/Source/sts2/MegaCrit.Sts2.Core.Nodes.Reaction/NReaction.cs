using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;

namespace MegaCrit.Sts2.Core.Nodes.Reaction;

[ScriptPath("res://src/Core/Nodes/Reaction/NReaction.cs")]
public class NReaction : TextureRect
{
	public new class MethodName : TextureRect.MethodName
	{
		public static readonly StringName Create;

		public static readonly StringName BeginAnim;

		public static readonly StringName TypeToTexture;

		public static readonly StringName TextureToType;

		public extern MethodName();
	}

	public new class PropertyName : TextureRect.PropertyName
	{
		public static readonly StringName Type;

		public extern PropertyName();
	}

	public new class SignalName : TextureRect.SignalName
	{
		public extern SignalName();
	}

	public extern ReactionType Type { get; }

	public static extern NReaction Create(Texture2D reactionTexture);

	public static extern NReaction Create(ReactionType type);

	public extern void BeginAnim();

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

	public extern NReaction();
}
