using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NTickbox.cs")]
public class NTickbox : NButton
{
	[Signal]
	public delegate void ToggledEventHandler(NTickbox tickbox);

	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName ConnectSignals;

		public new static readonly StringName OnRelease;

		public static readonly StringName OnUntick;

		public static readonly StringName OnTick;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnDisable;

		public new static readonly StringName OnEnable;

		public static readonly StringName UpdateShaderV;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName IsTicked;

		public static readonly StringName _isTicked;

		public static readonly StringName _imageContainer;

		public static readonly StringName _tickedImage;

		public static readonly StringName _notTickedImage;

		public static readonly StringName _hsv;

		public static readonly StringName _tween;

		public static readonly StringName _baseScale;

		public static readonly StringName _hoverScale;

		public static readonly StringName _pressDownScale;

		public static readonly StringName _hoverV;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public static readonly StringName Toggled;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsTicked { get; set; }

	public extern event ToggledEventHandler Toggled;

	public override extern void _Ready();

	protected override extern void ConnectSignals();

	protected override extern void OnRelease();

	protected virtual extern void OnUntick();

	protected virtual extern void OnTick();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	protected override extern void OnDisable();

	protected override extern void OnEnable();

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

	protected extern void EmitSignalToggled(NTickbox tickbox);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NTickbox();
}
