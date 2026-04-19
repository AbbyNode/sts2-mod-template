using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NScreenshakePaginator.cs")]
public class NScreenshakePaginator : NPaginator, IResettableSettingNode
{
	public new class MethodName : NPaginator.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetFromSettings;

		public new static readonly StringName OnIndexChanged;

		public static readonly StringName GetShakeMultiplier;

		public extern MethodName();
	}

	public new class PropertyName : NPaginator.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : NPaginator.SignalName
	{
		public extern SignalName();
	}

	public override extern void _Ready();

	public extern void SetFromSettings();

	protected override extern void OnIndexChanged(int index);

	public static extern float GetShakeMultiplier(int index);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NScreenshakePaginator();
}
