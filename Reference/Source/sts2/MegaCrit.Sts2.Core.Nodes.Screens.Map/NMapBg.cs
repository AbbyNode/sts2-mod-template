using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Map;

[ScriptPath("res://src/Core/Nodes/Screens/Map/NMapBg.cs")]
public class NMapBg : VBoxContainer
{
	public new class MethodName : VBoxContainer.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnVisibilityChanged;

		public static readonly StringName OnWindowChange;

		public extern MethodName();
	}

	public new class PropertyName : VBoxContainer.PropertyName
	{
		public static readonly StringName _mapTop;

		public static readonly StringName _mapMid;

		public static readonly StringName _mapBot;

		public static readonly StringName _drawings;

		public static readonly StringName _window;

		public static readonly StringName _offsetX;

		public extern PropertyName();
	}

	public new class SignalName : VBoxContainer.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public extern void Initialize(IRunState runState);

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

	public extern NMapBg();
}
