using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NSovereignBladeVfx.cs")]
public class NSovereignBladeVfx : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName _Process;

		public static readonly StringName Forge;

		public static readonly StringName Attack;

		public static readonly StringName OnTargetingBegan;

		public static readonly StringName OnTargetingEnded;

		public static readonly StringName OnFocused;

		public static readonly StringName OnUnfocused;

		public static readonly StringName UpdateHoverTip;

		public static readonly StringName FireSparks;

		public static readonly StringName FireFlames;

		public static readonly StringName EndSlash;

		public static readonly StringName CleanupForge;

		public static readonly StringName CleanupAttack;

		public static readonly StringName RemoveSovereignBlade;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName OrbitProgress;

		public static readonly StringName _spineNode;

		public static readonly StringName _bladeGlow;

		public static readonly StringName _forgeSparks;

		public static readonly StringName _spawnFlames;

		public static readonly StringName _spawnFlamesBack;

		public static readonly StringName _slashParticles;

		public static readonly StringName _chargeParticles;

		public static readonly StringName _spikeParticles;

		public static readonly StringName _spikeParticles2;

		public static readonly StringName _spikeCircle;

		public static readonly StringName _spikeCircle2;

		public static readonly StringName _hilt;

		public static readonly StringName _hilt2;

		public static readonly StringName _detail;

		public static readonly StringName _trail;

		public static readonly StringName _orbitPath;

		public static readonly StringName _hitbox;

		public static readonly StringName _selectionReticle;

		public static readonly StringName _attackTween;

		public static readonly StringName _scaleTween;

		public static readonly StringName _sparkDelay;

		public static readonly StringName _glowTween;

		public static readonly StringName _trailStart;

		public static readonly StringName _bladeSize;

		public static readonly StringName _targetOrbitPosition;

		public static readonly StringName _isBehindCharacter;

		public static readonly StringName _isFocused;

		public static readonly StringName _hoverTip;

		public static readonly StringName _isForging;

		public static readonly StringName _isAttacking;

		public static readonly StringName _isKeyPressed;

		public static readonly StringName _testCharge;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern CardModel Card
	{
		[CompilerGenerated]
		get;
	}

	public extern double OrbitProgress
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public override extern void _Ready();

	public override extern void _ExitTree();

	public static extern NSovereignBladeVfx? Create(CardModel card);

	public override extern void _Process(double delta);

	public extern void Forge(float bladeDamage = 0f, bool showFlames = false);

	public extern void Attack(Vector2 targetPos);

	public extern void RemoveSovereignBlade();

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

	public extern NSovereignBladeVfx();
}
