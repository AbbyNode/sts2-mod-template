using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen;

[ScriptPath("res://src/Core/Nodes/Screens/FeedbackScreen/NSendFeedbackCartoon.cs")]
public class NSendFeedbackCartoon : TextureRect
{
	public new class MethodName : TextureRect.MethodName
	{
		public static readonly StringName SetRotation1;

		public static readonly StringName SetRotation2;

		public extern MethodName();
	}

	public new class PropertyName : TextureRect.PropertyName
	{
		public static readonly StringName _tween;

		public static readonly StringName opposite;

		public extern PropertyName();
	}

	public new class SignalName : TextureRect.SignalName
	{
		public extern SignalName();
	}

	[Export(PropertyHint.None, "")]
	public bool opposite;

	public extern void SetRotation1();

	public extern void SetRotation2();

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

	public extern NSendFeedbackCartoon();
}
