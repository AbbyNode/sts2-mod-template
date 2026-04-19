using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.CommonUi;

namespace MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen;

[ScriptPath("res://src/Core/Nodes/Screens/RunHistoryScreen/NRunHistoryArrowButton.cs")]
public class NRunHistoryArrowButton : NGoldArrowButton
{
	public new class MethodName : NGoldArrowButton.MethodName
	{
		public new static readonly StringName _Ready;

		public extern MethodName();
	}

	public new class PropertyName : NGoldArrowButton.PropertyName
	{
		public static readonly StringName IsLeft;

		public new static readonly StringName Hotkeys;

		public static readonly StringName _isLeft;

		public extern PropertyName();
	}

	public new class SignalName : NGoldArrowButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsLeft { get; set; }

	protected override extern string[] Hotkeys { get; }

	public override extern void _Ready();

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

	public extern NRunHistoryArrowButton();
}
