using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NPingButton.cs")]
public class NPingButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName OnRelease;

		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public static readonly StringName AnimOut;

		public static readonly StringName AnimIn;

		public static readonly StringName OnCombatEnded;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public static readonly StringName UpdateShaderV;

		public static readonly StringName SetState;

		public static readonly StringName RefreshEnabled;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName ShowPos;

		public static readonly StringName HidePos;

		public new static readonly StringName Hotkeys;

		public static readonly StringName _state;

		public static readonly StringName _visuals;

		public static readonly StringName _image;

		public static readonly StringName _label;

		public static readonly StringName _viewport;

		public static readonly StringName _hsv;

		public static readonly StringName _positionTween;

		public static readonly StringName _hoverTween;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern string[] Hotkeys { get; }

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	protected override extern void OnRelease();

	protected override extern void OnEnable();

	protected override extern void OnDisable();

	public extern void OnCombatEnded();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	public extern void RefreshEnabled();

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

	public extern NPingButton();
}
