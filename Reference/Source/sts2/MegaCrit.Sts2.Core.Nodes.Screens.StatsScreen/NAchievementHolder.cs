using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Achievements;

namespace MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen;

[ScriptPath("res://src/Core/Nodes/Screens/StatsScreen/NAchievementHolder.cs")]
public class NAchievementHolder : Control
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName RefreshUnlocked;

		public static readonly StringName SetLockVisuals;

		public static readonly StringName SetDateLabel;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName IsUnlocked;

		public static readonly StringName _border;

		public static readonly StringName _icon;

		public static readonly StringName _lock;

		public static readonly StringName _iconHsv;

		public static readonly StringName _borderHsv;

		public static readonly StringName _infoLabel;

		public static readonly StringName _date;

		public static readonly StringName _achievement;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsUnlocked
	{
		[CompilerGenerated]
		get;
	}

	public static extern NAchievementHolder? Create(Achievement achievement);

	public override extern void _Ready();

	public static extern string GetPathForAchievement(Enum achievement);

	public extern void RefreshUnlocked();

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

	public extern NAchievementHolder();
}
