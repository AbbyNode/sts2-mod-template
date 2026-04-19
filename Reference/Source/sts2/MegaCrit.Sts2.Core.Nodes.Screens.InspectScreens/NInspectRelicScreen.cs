using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens;

[ScriptPath("res://src/Core/Nodes/Screens/InspectScreens/NInspectRelicScreen.cs")]
public class NInspectRelicScreen : Control, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName _Input;

		public static readonly StringName OnRightButtonPressed;

		public static readonly StringName OnLeftButtonPressed;

		public static readonly StringName SetRelic;

		public static readonly StringName UpdateRelicDisplay;

		public static readonly StringName SetRarityVisuals;

		public static readonly StringName Close;

		public static readonly StringName OnBackstopPressed;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _popup;

		public static readonly StringName _backstop;

		public static readonly StringName _nameLabel;

		public static readonly StringName _rarityLabel;

		public static readonly StringName _description;

		public static readonly StringName _flavor;

		public static readonly StringName _relicImage;

		public static readonly StringName _frameHsv;

		public static readonly StringName _leftButton;

		public static readonly StringName _rightButton;

		public static readonly StringName _hoverTipRect;

		public static readonly StringName _screenTween;

		public static readonly StringName _popupTween;

		public static readonly StringName _popupPosition;

		public static readonly StringName _leftButtonX;

		public static readonly StringName _rightButtonX;

		public static readonly StringName _index;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string[] AssetPaths { get; }

	public extern Control? DefaultFocusedControl { get; }

	public static extern NInspectRelicScreen? Create();

	public extern void Open(IReadOnlyList<RelicModel> relics, RelicModel relic);

	public override extern void _Ready();

	public override extern void _Input(InputEvent inputEvent);

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

	public extern NInspectRelicScreen();
}
