using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Nodes.Vfx.Utilities;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NThoughtBubbleVfx.cs")]
public class NThoughtBubbleVfx : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName SetTexture;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _container;

		public static readonly StringName _label;

		public static readonly StringName _textureRect;

		public static readonly StringName _contents;

		public static readonly StringName _tail;

		public static readonly StringName _style;

		public static readonly StringName _side;

		public static readonly StringName _text;

		public static readonly StringName _texture;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NThoughtBubbleVfx? Create(string text, Creature speaker, double? secondsToDisplay);

	public static extern NThoughtBubbleVfx? Create(string text, DialogueSide side, double? secondsToDisplay);

	public static extern NThoughtBubbleVfx? Create(Texture2D texture, DialogueSide side, double? secondsToDisplay);

	public override extern void _Ready();

	public override extern void _ExitTree();

	[AsyncStateMachine(typeof(_003CGoAway_003Ed__24))]
	public extern Task GoAway();

	public static extern Vector2 GetCreatureSpeechPosition(Creature speaker);

	public extern void SetTexture(Texture2D texture);

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

	public extern NThoughtBubbleVfx();
}
