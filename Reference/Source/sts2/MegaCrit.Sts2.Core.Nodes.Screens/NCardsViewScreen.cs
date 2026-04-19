using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Cards;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Nodes.Screens.Capstones;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens;

[ScriptPath("res://src/Core/Nodes/Screens/NCardsViewScreen.cs")]
public abstract class NCardsViewScreen : Control, ICapstoneScreen, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName ConnectSignals;

		public static readonly StringName ToggleShowUpgrades;

		public static readonly StringName OnReturnButtonPressed;

		public static readonly StringName AfterCapstoneOpened;

		public static readonly StringName AfterCapstoneClosed;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName ScreenType;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName FocusedControlFromTopBar;

		public static readonly StringName UseSharedBackstop;

		public static readonly StringName _background;

		public static readonly StringName _grid;

		public static readonly StringName _backButton;

		public static readonly StringName _showUpgrades;

		public static readonly StringName _bottomLabel;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	protected NCardGrid _grid;

	protected NButton _backButton;

	protected List<CardModel> _cards;

	protected LocString _infoText;

	public abstract NetScreenType ScreenType { get; }

	public extern Control? DefaultFocusedControl { get; }

	public extern Control? FocusedControlFromTopBar { get; }

	public extern bool UseSharedBackstop { get; }

	public override extern void _Ready();

	protected virtual extern void ConnectSignals();

	protected extern void OnReturnButtonPressed(NButton _);

	public virtual extern void AfterCapstoneOpened();

	public virtual extern void AfterCapstoneClosed();

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

	protected extern NCardsViewScreen();
}
