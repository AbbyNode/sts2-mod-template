using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NFullscreenTickbox.cs")]
public class NFullscreenTickbox : NSettingsTickbox
{
	public new class MethodName : NSettingsTickbox.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnTick;

		public new static readonly StringName OnUntick;

		public static readonly StringName OnWindowChange;

		public static readonly StringName SetFullscreen;

		public extern MethodName();
	}

	public new class PropertyName : NSettingsTickbox.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : NSettingsTickbox.SignalName
	{
		public extern SignalName();
	}

	public override extern void _Ready();

	protected override extern void OnTick();

	protected override extern void OnUntick();

	public static extern void SetFullscreen(bool fullscreen);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NFullscreenTickbox();
}
