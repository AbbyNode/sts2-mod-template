using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Cards;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NCardFlyVfx.cs")]
public class NCardFlyVfx : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName OnCardExitedTree;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName _card;

		public static readonly StringName _trailPath;

		public static readonly StringName _vfx;

		public static readonly StringName _fadeOutTween;

		public static readonly StringName _vfxFading;

		public static readonly StringName _isAddingToPile;

		public static readonly StringName _startPos;

		public static readonly StringName _endPos;

		public static readonly StringName _controlPointOffset;

		public static readonly StringName _duration;

		public static readonly StringName _speed;

		public static readonly StringName _accel;

		public static readonly StringName _arcDir;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern TaskCompletionSource? SwooshAwayCompletion
	{
		[CompilerGenerated]
		get;
	}

	public static extern NCardFlyVfx? Create(NCard card, Vector2 end, bool isAddingToPile, string trailPath);

	public override extern void _Ready();

	public override extern void _ExitTree();

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

	public extern NCardFlyVfx();
}
