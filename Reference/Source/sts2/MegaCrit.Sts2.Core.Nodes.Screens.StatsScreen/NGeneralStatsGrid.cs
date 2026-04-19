using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.StatsScreen;

[ScriptPath("res://src/Core/Nodes/Screens/StatsScreen/NGeneralStatsGrid.cs")]
public class NGeneralStatsGrid : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName CreateSection;

		public static readonly StringName LoadStats;

		public static readonly StringName SetupHoverTips;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _gridContainer;

		public static readonly StringName _achievementsEntry;

		public static readonly StringName _playtimeEntry;

		public static readonly StringName _cardsEntry;

		public static readonly StringName _winLossEntry;

		public static readonly StringName _monsterEntry;

		public static readonly StringName _relicEntry;

		public static readonly StringName _potionEntry;

		public static readonly StringName _eventsEntry;

		public static readonly StringName _streakEntry;

		public static readonly StringName _characterStatContainer;

		public static readonly StringName _screenTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string[] AssetPaths { get; }

	public extern Control DefaultFocusedControl { get; }

	public override extern void _Ready();

	public extern void LoadStats();

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

	public extern NGeneralStatsGrid();
}
