using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens;

[ScriptPath("res://src/Core/Nodes/Screens/NInspectCardScreen.cs")]
public class NInspectCardScreen : Control, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName Close;

		public static readonly StringName OnRightButtonReleased;

		public static readonly StringName OnLeftButtonReleased;

		public static readonly StringName ToggleShowUpgrade;

		public static readonly StringName UpdateCardDisplay;

		public static readonly StringName SetCard;

		public static readonly StringName OnBackstopPressed;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName IsShowingUpgradedCard;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _card;

		public static readonly StringName _backstop;

		public static readonly StringName _upgradeTickbox;

		public static readonly StringName _leftButton;

		public static readonly StringName _rightButton;

		public static readonly StringName _hoverTipRect;

		public static readonly StringName _index;

		public static readonly StringName _openTween;

		public static readonly StringName _cardTween;

		public static readonly StringName _cardPosition;

		public static readonly StringName _leftButtonX;

		public static readonly StringName _rightButtonX;

		public static readonly StringName _viewAllUpgraded;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string[] AssetPaths { get; }

	public extern Control? DefaultFocusedControl { get; }

	public static extern NInspectCardScreen? Create();

	public override extern void _Ready();

	public extern void Open(List<CardModel> cards, int index, bool viewAllUpgraded = false);

	public extern void Close();

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

	public extern NInspectCardScreen();
}
