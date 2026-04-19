using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Nodes.Screens;

[ScriptPath("res://src/Core/Nodes/Screens/NSimpleCardsViewScreen.cs")]
public class NSimpleCardsViewScreen : NCardsViewScreen
{
	public new class MethodName : NCardsViewScreen.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName ConnectSignals;

		public new static readonly StringName AfterCapstoneOpened;

		public extern MethodName();
	}

	public new class PropertyName : NCardsViewScreen.PropertyName
	{
		public new static readonly StringName ScreenType;

		public static readonly StringName _confirmButton;

		public extern PropertyName();
	}

	public new class SignalName : NCardsViewScreen.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public override extern NetScreenType ScreenType { get; }

	public override extern void _Ready();

	protected override extern void ConnectSignals();

	public static extern NCardsViewScreen? ShowScreen(List<CardPileAddResult> cards, LocString infoText);

	public override extern void AfterCapstoneOpened();

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

	public extern NSimpleCardsViewScreen();
}
