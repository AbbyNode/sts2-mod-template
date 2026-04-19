using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.sts2.Core.Nodes.TopBar;

[ScriptPath("res://src/Core/Nodes/TopBar/NTopBarBossIcon.cs")]
public class NTopBarBossIcon : NClickableControl
{
	public new class MethodName : NClickableControl.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName OnRoomEntered;

		public static readonly StringName OnActEntered;

		public static readonly StringName RefreshBossIcon;

		public static readonly StringName RefreshSecondBossIconColor;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public extern MethodName();
	}

	public new class PropertyName : NClickableControl.PropertyName
	{
		public static readonly StringName ShouldOnlyShowSecondBossIcon;

		public static readonly StringName _bossIcon;

		public static readonly StringName _bossIconOutline;

		public static readonly StringName _secondBossIcon;

		public static readonly StringName _secondBossIconOutline;

		public extern PropertyName();
	}

	public new class SignalName : NClickableControl.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public extern void Initialize(IRunState runState);

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void RefreshBossIcon();

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

	public extern NTopBarBossIcon();
}
