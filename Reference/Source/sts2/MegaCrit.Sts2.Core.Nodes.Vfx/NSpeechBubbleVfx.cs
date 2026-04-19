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

[ScriptPath("res://src/Core/Nodes/Vfx/NSpeechBubbleVfx.cs")]
public class NSpeechBubbleVfx : Control
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName SetSpeechBubbleColor;

		public new static readonly StringName _ExitTree;

		public static readonly StringName CreateInternal;

		public new static readonly StringName _Process;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName SecondsToDisplay;

		public static readonly StringName _container;

		public static readonly StringName _label;

		public static readonly StringName _contents;

		public static readonly StringName _bubble;

		public static readonly StringName _shadow;

		public static readonly StringName _hsv;

		public static readonly StringName _tween;

		public static readonly StringName _startPos;

		public static readonly StringName _vfxColor;

		public static readonly StringName _style;

		public static readonly StringName _side;

		public static readonly StringName _text;

		public static readonly StringName _elapsedTime;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern double SecondsToDisplay
	{
		[CompilerGenerated]
		get;
	}

	public static extern NSpeechBubbleVfx? Create(string text, Creature speaker, double secondsToDisplay, VfxColor vfxColor = VfxColor.White);

	public static extern NSpeechBubbleVfx? Create(string text, DialogueSide side, Vector2 globalPosition, double secondsToDisplay, VfxColor vfxColor = VfxColor.White);

	public override extern void _Ready();

	public override extern void _ExitTree();

	[AsyncStateMachine(typeof(_003CAnimOut_003Ed__33))]
	public extern Task AnimOut();

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

	public extern NSpeechBubbleVfx();
}
