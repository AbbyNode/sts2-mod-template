using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NEnergyCounter.cs")]
public class NEnergyCounter : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName OnHovered;

		public static readonly StringName OnUnhovered;

		public static readonly StringName RefreshLabel;

		public static readonly StringName OnEnergyChanged;

		public new static readonly StringName _Process;

		public static readonly StringName AnimIn;

		public static readonly StringName AnimOut;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName OutlineColor;

		public static readonly StringName _label;

		public static readonly StringName _layers;

		public static readonly StringName _rotationLayers;

		public static readonly StringName _backParticles;

		public static readonly StringName _frontParticles;

		public static readonly StringName _animInTween;

		public static readonly StringName _animOutTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NEnergyCounter? Create(Player player);

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public override extern void _Process(double delta);

	public extern void AnimIn();

	public extern void AnimOut();

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

	public extern NEnergyCounter();
}
