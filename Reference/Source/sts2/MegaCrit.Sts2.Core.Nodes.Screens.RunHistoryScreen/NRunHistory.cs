using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen;

[ScriptPath("res://src/Core/Nodes/Screens/RunHistoryScreen/NRunHistory.cs")]
public class NRunHistory : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName OnLeftButtonButtonReleased;

		public static readonly StringName OnRightButtonButtonReleased;

		public static readonly StringName CanBeShown;

		public new static readonly StringName OnSubmenuOpened;

		public new static readonly StringName OnSubmenuShown;

		public new static readonly StringName OnSubmenuHidden;

		public new static readonly StringName _Input;

		public static readonly StringName SelectPlayer;

		public static readonly StringName LoadGoldHpAndPotionInfo;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _screenContents;

		public static readonly StringName _playerIconContainer;

		public static readonly StringName _hpLabel;

		public static readonly StringName _goldLabel;

		public static readonly StringName _potionHolder;

		public static readonly StringName _floorLabel;

		public static readonly StringName _timeLabel;

		public static readonly StringName _dateLabel;

		public static readonly StringName _seedLabel;

		public static readonly StringName _gameModeLabel;

		public static readonly StringName _buildLabel;

		public static readonly StringName _deathQuoteLabel;

		public static readonly StringName _mapPointHistory;

		public static readonly StringName _relicHistory;

		public static readonly StringName _deckHistory;

		public static readonly StringName _outOfDateVisual;

		public static readonly StringName _index;

		public static readonly StringName _prevButton;

		public static readonly StringName _nextButton;

		public static readonly StringName _selectedPlayerIcon;

		public static readonly StringName _screenTween;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	public const string locTable = "run_history";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern Control? InitialFocusedControl { get; }

	public static extern string[] AssetPaths { get; }

	public static extern NRunHistory? Create();

	public override extern void _Ready();

	public static extern bool CanBeShown();

	public override extern void OnSubmenuOpened();

	protected override extern void OnSubmenuShown();

	protected override extern void OnSubmenuHidden();

	public override extern void _Input(InputEvent inputEvent);

	public static extern GameOverType GetGameOverType(RunHistory history);

	public static extern string GetDeathQuote(RunHistory history, ModelId characterId, GameOverType gameOverType);

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

	public extern NRunHistory();
}
