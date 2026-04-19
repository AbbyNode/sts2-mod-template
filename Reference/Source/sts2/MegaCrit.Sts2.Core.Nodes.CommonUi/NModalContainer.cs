using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NModalContainer.cs")]
public class NModalContainer : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Add;

		public static readonly StringName Clear;

		public static readonly StringName ShowBackstop;

		public static readonly StringName HideBackstop;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _backstop;

		public static readonly StringName _backstopTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NModalContainer? Instance
	{
		[CompilerGenerated]
		get;
	}

	public extern IScreenContext? OpenModal
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	public extern void Add(Node modalToCreate, bool showBackstop = true);

	public extern void Clear();

	public extern void ShowBackstop();

	public extern void HideBackstop();

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

	public extern NModalContainer();
}
