using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NResetGraphicsButton.cs")]
public class NResetGraphicsButton : NSettingsButton
{
	public new class MethodName : NSettingsButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnRelease;

		public extern MethodName();
	}

	public new class PropertyName : NSettingsButton.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : NSettingsButton.SignalName
	{
		public extern SignalName();
	}

	public override extern void _Ready();

	protected override extern void OnRelease();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NResetGraphicsButton();
}
