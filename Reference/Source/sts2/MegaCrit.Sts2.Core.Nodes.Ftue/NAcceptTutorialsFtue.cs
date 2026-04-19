using System;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect;

namespace MegaCrit.Sts2.Core.Nodes.Ftue;

[ScriptPath("res://src/Core/Nodes/Ftue/NAcceptTutorialsFtue.cs")]
public class NAcceptTutorialsFtue : NFtue
{
	public new class MethodName : NFtue.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName NoTutorials;

		public static readonly StringName YesTutorials;

		public extern MethodName();
	}

	public new class PropertyName : NFtue.PropertyName
	{
		public static readonly StringName _charSelectScreen;

		public static readonly StringName _verticalPopup;

		public extern PropertyName();
	}

	public new class SignalName : NFtue.SignalName
	{
		public extern SignalName();
	}

	public const string id = "accept_tutorials_ftue";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public static extern NAcceptTutorialsFtue? Create(NCharacterSelectScreen charSelectScreen, Action onFinished);

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

	public extern NAcceptTutorialsFtue();
}
