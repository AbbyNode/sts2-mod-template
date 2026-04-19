using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Runs.History;

namespace MegaCrit.Sts2.Core.Nodes.HoverTips;

[ScriptPath("res://src/Core/Nodes/HoverTips/NMapPointHistoryHoverTip.cs")]
public class NMapPointHistoryHoverTip : MarginContainer
{
	public new class MethodName : MarginContainer.MethodName
	{
		public new static readonly StringName _Ready;

		public extern MethodName();
	}

	public new class PropertyName : MarginContainer.PropertyName
	{
		public static readonly StringName _floorNum;

		public static readonly StringName _playerId;

		public static readonly StringName _titleLabel;

		public static readonly StringName _playerStats;

		public static readonly StringName _roomStats;

		public static readonly StringName _rewardStatsContainer;

		public static readonly StringName _skippedStatsContainer;

		public static readonly StringName _actionStats;

		public extern PropertyName();
	}

	public new class SignalName : MarginContainer.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NMapPointHistoryHoverTip Create(int floorNum, ulong playerId, MapPointHistoryEntry historyEntry);

	public override extern void _Ready();

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

	public extern NMapPointHistoryHoverTip();
}
