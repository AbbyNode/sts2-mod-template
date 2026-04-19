using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Orbs;

[ScriptPath("res://src/Core/Nodes/Orbs/NOrb.cs")]
public class NOrb : NClickableControl
{
	public new class MethodName : NClickableControl.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName UpdateVisuals;

		public static readonly StringName Flash;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public extern MethodName();
	}

	public new class PropertyName : NClickableControl.PropertyName
	{
		public static readonly StringName _outline;

		public static readonly StringName _visualContainer;

		public static readonly StringName _labelContainer;

		public static readonly StringName _passiveLabel;

		public static readonly StringName _evokeLabel;

		public static readonly StringName _bounds;

		public static readonly StringName _flashParticle;

		public static readonly StringName _selectionReticle;

		public static readonly StringName _isLocal;

		public static readonly StringName _sprite;

		public static readonly StringName _curTween;

		public extern PropertyName();
	}

	public new class SignalName : NClickableControl.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern OrbModel? Model
	{
		[CompilerGenerated]
		get;
	}

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NOrb Create(bool isLocal);

	public static extern NOrb Create(bool isLocal, OrbModel? model);

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void ReplaceOrb(OrbModel model);

	public extern void UpdateVisuals(bool isEvoking);

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

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

	public extern NOrb();
}
