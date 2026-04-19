using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Nodes.Screens.Capstones;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Multiplayer;

[ScriptPath("res://src/Core/Nodes/Multiplayer/NMultiplayerPlayerExpandedState.cs")]
public class NMultiplayerPlayerExpandedState : Control, ICapstoneScreen, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName AfterCapstoneOpened;

		public static readonly StringName AfterCapstoneClosed;

		public new static readonly StringName _Ready;

		public new static readonly StringName _Input;

		public static readonly StringName ShowEntry;

		public static readonly StringName BackButtonPressed;

		public static readonly StringName OnRelicClicked;

		public static readonly StringName UpdateNavigation;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName UseSharedBackstop;

		public static readonly StringName ScreenType;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _playerNameLabel;

		public static readonly StringName _cardsHeader;

		public static readonly StringName _cardContainer;

		public static readonly StringName _backButton;

		public static readonly StringName _potionsHeader;

		public static readonly StringName _potionContainer;

		public static readonly StringName _relicsHeader;

		public static readonly StringName _relicContainer;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool UseSharedBackstop { get; }

	public extern NetScreenType ScreenType { get; }

	public extern Control? DefaultFocusedControl { get; }

	public static extern NMultiplayerPlayerExpandedState Create(Player player);

	public extern void AfterCapstoneOpened();

	public extern void AfterCapstoneClosed();

	public override extern void _Ready();

	public override extern void _Input(InputEvent inputEvent);

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

	public extern NMultiplayerPlayerExpandedState();
}
