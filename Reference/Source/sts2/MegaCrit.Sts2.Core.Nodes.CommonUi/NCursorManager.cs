using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NCursorManager.cs")]
public class NCursorManager : Node
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _EnterTree;

		public new static readonly StringName _Ready;

		public new static readonly StringName _Input;

		public static readonly StringName StopOverridingCursor;

		public static readonly StringName OverrideCursor;

		public static readonly StringName UpdateCursor;

		public static readonly StringName SetIsUsingController;

		public static readonly StringName SetCursorShown;

		public static readonly StringName RefreshCursorShown;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName CursorTilted;

		public static readonly StringName CursorNotTilted;

		public static readonly StringName HotSpot;

		public static readonly StringName _cursorTilted;

		public static readonly StringName _cursorNotTilted;

		public static readonly StringName _cursorInspect;

		public static readonly StringName _overriddenCursorTilted;

		public static readonly StringName _overriddenCursorNotTilted;

		public static readonly StringName _lastSetCursor;

		public static readonly StringName _isDown;

		public static readonly StringName _isUsingController;

		public static readonly StringName _shouldShowCursor;

		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _EnterTree();

	public override extern void _Ready();

	public override extern void _Input(InputEvent inputEvent);

	public extern void StopOverridingCursor();

	public extern void OverrideCursor(Image cursorTilted, Image cursorNotTilted, Vector2 hotspot);

	public extern void SetCursorShown(bool show);

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

	public extern NCursorManager();
}
