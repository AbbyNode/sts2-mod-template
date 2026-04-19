using System;
using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.DailyRun;

[ScriptPath("res://src/Core/Nodes/Screens/DailyRun/NDailyRunLeaderboard.cs")]
public class NDailyRunLeaderboard : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetLocalizedText;

		public static readonly StringName Cleanup;

		public static readonly StringName ChangePage;

		public static readonly StringName SetPage;

		public static readonly StringName ClearEntries;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _titleLabel;

		public static readonly StringName _paginator;

		public static readonly StringName _scoreContainer;

		public static readonly StringName _leftArrow;

		public static readonly StringName _rightArrow;

		public static readonly StringName _loadingIndicator;

		public static readonly StringName _noScoresIndicator;

		public static readonly StringName _noFriendsIndicator;

		public static readonly StringName _noScoreUploadIndicator;

		public static readonly StringName _currentPage;

		public static readonly StringName _hasNegativeScore;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string[] AssetPaths { get; }

	public override extern void _Ready();

	public extern void Cleanup();

	public extern void Initialize(DateTimeOffset dateTime, IEnumerable<ulong> playersInRun, bool allowPagination);

	public extern void SetDay(DateTimeOffset dateTime);

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

	public extern NDailyRunLeaderboard();
}
