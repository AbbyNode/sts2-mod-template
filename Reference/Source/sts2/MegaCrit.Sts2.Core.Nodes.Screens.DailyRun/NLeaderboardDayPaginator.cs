using System;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.addons.mega_text;

namespace MegaCrit.Sts2.Core.Nodes.Screens.DailyRun;

[ScriptPath("res://src/Core/Nodes/Screens/DailyRun/NLeaderboardDayPaginator.cs")]
public class NLeaderboardDayPaginator : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _GuiInput;

		public static readonly StringName PageLeft;

		public static readonly StringName PageRight;

		public static readonly StringName DayChangeHelper;

		public static readonly StringName OnDayChanged;

		public static readonly StringName Disable;

		public static readonly StringName Enable;

		public static readonly StringName OnFocus;

		public static readonly StringName OnUnfocus;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _label;

		public static readonly StringName _vfxLabel;

		public static readonly StringName _leftArrow;

		public static readonly StringName _rightArrow;

		public static readonly StringName _selectionReticle;

		public static readonly StringName _tween;

		public static readonly StringName _leaderboard;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	protected MegaLabel _label;

	public override extern void _Ready();

	public extern void Initialize(NDailyRunLeaderboard leaderboard, DateTimeOffset dateTime, bool showArrows);

	public override extern void _GuiInput(InputEvent input);

	public extern void Disable();

	public extern void Enable(bool leftArrowEnabled, bool rightArrowEnabled);

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

	public extern NLeaderboardDayPaginator();
}
