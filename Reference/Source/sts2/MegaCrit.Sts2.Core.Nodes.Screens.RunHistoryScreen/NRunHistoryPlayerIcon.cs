using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen;

[ScriptPath("res://src/Core/Nodes/Screens/RunHistoryScreen/NRunHistoryPlayerIcon.cs")]
public class NRunHistoryPlayerIcon : NClickableControl
{
	public new class MethodName : NClickableControl.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Select;

		public static readonly StringName Deselect;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public extern MethodName();
	}

	public new class PropertyName : NClickableControl.PropertyName
	{
		public static readonly StringName _ascensionIcon;

		public static readonly StringName _ascensionLabel;

		public static readonly StringName _selectionReticle;

		public static readonly StringName _currentIcon;

		public extern PropertyName();
	}

	public new class SignalName : NClickableControl.SignalName
	{
		public extern SignalName();
	}

	public static readonly string scenePath;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern RunHistoryPlayer Player
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	public extern void LoadRun(RunHistoryPlayer player, RunHistory history);

	public extern void Select();

	public extern void Deselect();

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

	public extern NRunHistoryPlayerIcon();
}
