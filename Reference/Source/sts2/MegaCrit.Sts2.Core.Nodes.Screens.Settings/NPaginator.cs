using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.addons.mega_text;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NPaginator.cs")]
public class NPaginator : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName ConnectSignals;

		public new static readonly StringName _GuiInput;

		public static readonly StringName OnIndexChanged;

		public static readonly StringName SetIndex;

		public static readonly StringName PageLeft;

		public static readonly StringName PageRight;

		public static readonly StringName IndexChangeHelper;

		public static readonly StringName OnFocus;

		public static readonly StringName OnUnfocus;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _label;

		public static readonly StringName _vfxLabel;

		public static readonly StringName _selectionReticle;

		public static readonly StringName _currentIndex;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	protected MegaLabel _label;

	protected readonly List<string> _options;

	protected int _currentIndex;

	public override extern void _Ready();

	protected extern void ConnectSignals();

	public override extern void _GuiInput(InputEvent input);

	protected virtual extern void OnIndexChanged(int index);

	public extern void SetIndex(int index);

	public extern void PageLeft();

	public extern void PageRight();

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

	public extern NPaginator();
}
