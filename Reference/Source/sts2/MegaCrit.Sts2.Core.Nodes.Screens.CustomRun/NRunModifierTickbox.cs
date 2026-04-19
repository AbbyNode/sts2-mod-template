using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.CommonUi;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CustomRun;

[ScriptPath("res://src/Core/Nodes/Screens/CustomRun/NRunModifierTickbox.cs")]
public class NRunModifierTickbox : NTickbox
{
	public new class MethodName : NTickbox.MethodName
	{
		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public new static readonly StringName _Ready;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public extern MethodName();
	}

	public new class PropertyName : NTickbox.PropertyName
	{
		public static readonly StringName _label;

		public static readonly StringName _highlight;

		public extern PropertyName();
	}

	public new class SignalName : NTickbox.SignalName
	{
		public extern SignalName();
	}

	public const string scenePath = "res://scenes/screens/custom_run/modifier_tickbox.tscn";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ModifierModel? Modifier
	{
		[CompilerGenerated]
		get;
	}

	public static extern NRunModifierTickbox? Create(ModifierModel model);

	protected override extern void OnEnable();

	protected override extern void OnDisable();

	public override extern void _Ready();

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

	public extern NRunModifierTickbox();
}
