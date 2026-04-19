using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NCreatureVisuals.cs")]
public class NCreatureVisuals : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetScaleAndHue;

		public static readonly StringName IsPlayingHurtAnimation;

		public static readonly StringName TryApplyLiquidOverlay;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName Body;

		public static readonly StringName Bounds;

		public static readonly StringName IntentPosition;

		public static readonly StringName OrbPosition;

		public static readonly StringName TalkPosition;

		public static readonly StringName HasSpineAnimation;

		public static readonly StringName VfxSpawnPosition;

		public static readonly StringName DefaultScale;

		public static readonly StringName _hue;

		public static readonly StringName _liquidOverlayTimer;

		public static readonly StringName _savedNormalMaterial;

		public static readonly StringName _currentLiquidOverlayMaterial;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Node2D Body
	{
		[CompilerGenerated]
		get;
	}

	public extern Control Bounds
	{
		[CompilerGenerated]
		get;
	}

	public extern Marker2D IntentPosition
	{
		[CompilerGenerated]
		get;
	}

	public extern Marker2D OrbPosition
	{
		[CompilerGenerated]
		get;
	}

	public extern Marker2D? TalkPosition
	{
		[CompilerGenerated]
		get;
	}

	public extern bool HasSpineAnimation { get; }

	public extern MegaSprite? SpineBody
	{
		[CompilerGenerated]
		get;
	}

	public extern Marker2D VfxSpawnPosition
	{
		[CompilerGenerated]
		get;
	}

	public extern float DefaultScale
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public override extern void _Ready();

	public extern void SetUpSkin(MonsterModel model);

	public extern void SetScaleAndHue(float scale, float hue);

	public extern bool IsPlayingHurtAnimation();

	public extern void TryApplyLiquidOverlay(Color tint);

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

	public extern NCreatureVisuals();
}
