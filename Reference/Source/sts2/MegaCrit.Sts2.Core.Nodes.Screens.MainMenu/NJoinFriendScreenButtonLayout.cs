using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[Tool]
[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NJoinFriendScreenButtonLayout.cs")]
public class NJoinFriendScreenButtonLayout : Container
{
	public new class MethodName : Container.MethodName
	{
		public new static readonly StringName _Notification;

		public static readonly StringName LayoutChildren;

		public extern MethodName();
	}

	public new class PropertyName : Container.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : Container.SignalName
	{
		public extern SignalName();
	}

	public override extern void _Notification(int what);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NJoinFriendScreenButtonLayout();
}
