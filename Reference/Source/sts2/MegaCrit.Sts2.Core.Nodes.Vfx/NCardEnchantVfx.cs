using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NCardEnchantVfx.cs")]
public class NCardEnchantVfx : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName EmbossCurve;

		public static readonly StringName _tween;

		public static readonly StringName _cardNode;

		public static readonly StringName _enchantmentSparkles;

		public static readonly StringName _enchantmentIcon;

		public static readonly StringName _enchantmentLabel;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	[Export(PropertyHint.None, "")]
	public extern Curve? EmbossCurve
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static extern NCardEnchantVfx? Create(CardModel card);

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

	public extern NCardEnchantVfx();
}
