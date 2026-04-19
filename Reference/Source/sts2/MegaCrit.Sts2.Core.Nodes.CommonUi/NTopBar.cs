using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Potions;
using MegaCrit.Sts2.Core.Nodes.TopBar;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.sts2.Core.Nodes.TopBar;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NTopBar.cs")]
public class NTopBar : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName ToggleAnimState;

		public new static readonly StringName _Input;

		public static readonly StringName DebugHideTopBar;

		public static readonly StringName AnimHide;

		public static readonly StringName AnimShow;

		public static readonly StringName MaxPotionsChanged;

		public static readonly StringName UpdateNavigation;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Map;

		public static readonly StringName Deck;

		public static readonly StringName Pause;

		public static readonly StringName PotionContainer;

		public static readonly StringName RoomIcon;

		public static readonly StringName FloorIcon;

		public static readonly StringName BossIcon;

		public static readonly StringName Gold;

		public static readonly StringName Hp;

		public static readonly StringName Portrait;

		public static readonly StringName PortraitTip;

		public static readonly StringName Timer;

		public static readonly StringName TrailContainer;

		public static readonly StringName _capstoneContainer;

		public static readonly StringName _modifiersContainer;

		public static readonly StringName _ascensionIcon;

		public static readonly StringName _ascensionLabel;

		public static readonly StringName _ascensionHsv;

		public static readonly StringName _hideTween;

		public static readonly StringName _isDebugHidden;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NTopBarMapButton Map
	{
		[CompilerGenerated]
		get;
	}

	public extern NTopBarDeckButton Deck
	{
		[CompilerGenerated]
		get;
	}

	public extern NTopBarPauseButton Pause
	{
		[CompilerGenerated]
		get;
	}

	public extern NPotionContainer PotionContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NTopBarRoomIcon RoomIcon
	{
		[CompilerGenerated]
		get;
	}

	public extern NTopBarFloorIcon FloorIcon
	{
		[CompilerGenerated]
		get;
	}

	public extern NTopBarBossIcon BossIcon
	{
		[CompilerGenerated]
		get;
	}

	public extern NTopBarGold Gold
	{
		[CompilerGenerated]
		get;
	}

	public extern NTopBarHp Hp
	{
		[CompilerGenerated]
		get;
	}

	public extern NTopBarPortrait Portrait
	{
		[CompilerGenerated]
		get;
	}

	public extern NTopBarPortraitTip PortraitTip
	{
		[CompilerGenerated]
		get;
	}

	public extern NRunTimer Timer
	{
		[CompilerGenerated]
		get;
	}

	public extern Node TrailContainer
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	public extern void Initialize(IRunState runState);

	public override extern void _ExitTree();

	public override extern void _Input(InputEvent inputEvent);

	public extern void AnimHide();

	public extern void AnimShow();

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

	public extern NTopBar();
}
