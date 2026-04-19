using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NCompendiumSubmenu.cs")]
public class NCompendiumSubmenu : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName OnSubmenuOpened;

		public static readonly StringName OpenCardLibrary;

		public static readonly StringName OpenRelicCollection;

		public static readonly StringName OpenPotionLab;

		public static readonly StringName OpenBestiary;

		public static readonly StringName OpenLeaderboards;

		public static readonly StringName OpenStatistics;

		public static readonly StringName OpenRunHistory;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _confirmButton;

		public static readonly StringName _cardLibraryButton;

		public static readonly StringName _relicCollectionButton;

		public static readonly StringName _potionLabButton;

		public static readonly StringName _bestiaryButton;

		public static readonly StringName _leaderboardsButton;

		public static readonly StringName _statisticsButton;

		public static readonly StringName _runHistoryButton;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern Control InitialFocusedControl { get; }

	public static extern NCompendiumSubmenu? Create();

	public override extern void _Ready();

	public override extern void OnSubmenuOpened();

	public extern void Initialize(IRunState runState);

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

	public extern NCompendiumSubmenu();
}
