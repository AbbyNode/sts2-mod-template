using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.GodotExtensions;

[ScriptPath("res://src/Core/Nodes/GodotExtensions/NScrollableContainer.cs")]
public class NScrollableContainer : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetContent;

		public static readonly StringName DisableScrollingIfContentFits;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName UpdateScrollLimitBottom;

		public new static readonly StringName _GuiInput;

		public new static readonly StringName _Input;

		public static readonly StringName ProcessControllerEvent;

		public static readonly StringName ProcessMouseEvent;

		public static readonly StringName ProcessScrollEvent;

		public new static readonly StringName _Process;

		public static readonly StringName InstantlyScrollToTop;

		public static readonly StringName ProcessGuiFocus;

		public static readonly StringName UpdateScrollPosition;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName ScrollViewportTop;

		public static readonly StringName ScrollViewportSize;

		public static readonly StringName ScrollLimitBottom;

		public static readonly StringName Scrollbar;

		public static readonly StringName _controllerScrollAmount;

		public static readonly StringName _startDragPosY;

		public static readonly StringName _targetDragPosY;

		public static readonly StringName _isDragging;

		public static readonly StringName _paddingTop;

		public static readonly StringName _paddingBottom;

		public static readonly StringName _content;

		public static readonly StringName _scrollbarPressed;

		public static readonly StringName _disableScrollingIfContentFits;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NScrollbar Scrollbar
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	public extern void SetContent(Control? content, float paddingTop = 0f, float paddingBottom = 0f);

	public extern void DisableScrollingIfContentFits();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public override extern void _GuiInput(InputEvent inputEvent);

	public override extern void _Input(InputEvent inputEvent);

	public override extern void _Process(double delta);

	public extern void InstantlyScrollToTop();

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

	public extern NScrollableContainer();
}
