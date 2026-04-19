using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Timeline.UnlockScreens;

[ScriptPath("res://src/Core/Nodes/Screens/Timeline/UnlockScreens/NUnlockMiscScreen.cs")]
public class NUnlockMiscScreen : NUnlockScreen
{
	public new class MethodName : NUnlockScreen.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName Open;

		public static readonly StringName SetUnlocks;

		public new static readonly StringName OnScreenPreClose;

		public new static readonly StringName OnScreenClose;

		public extern MethodName();
	}

	public new class PropertyName : NUnlockScreen.PropertyName
	{
		public static readonly StringName _label;

		public static readonly StringName _textToSet;

		public new static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : NUnlockScreen.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NUnlockMiscScreen Create();

	public override extern void _Ready();

	public override extern void Open();

	public extern void SetUnlocks(string text);

	protected override extern void OnScreenPreClose();

	protected override extern void OnScreenClose();

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

	public extern NUnlockMiscScreen();
}
