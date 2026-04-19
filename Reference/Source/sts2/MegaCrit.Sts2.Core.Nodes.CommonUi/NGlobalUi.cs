using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Cards;
using MegaCrit.Sts2.Core.Nodes.Combat;
using MegaCrit.Sts2.Core.Nodes.Multiplayer;
using MegaCrit.Sts2.Core.Nodes.Relics;
using MegaCrit.Sts2.Core.Nodes.Screens;
using MegaCrit.Sts2.Core.Nodes.Screens.Capstones;
using MegaCrit.Sts2.Core.Nodes.Screens.Map;
using MegaCrit.Sts2.Core.Nodes.Screens.Overlays;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NGlobalUi.cs")]
public class NGlobalUi : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnWindowChange;

		public static readonly StringName ReparentCard;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName TopBar;

		public static readonly StringName Overlays;

		public static readonly StringName CapstoneContainer;

		public static readonly StringName RelicInventory;

		public static readonly StringName EventCardPreviewContainer;

		public static readonly StringName CardPreviewContainer;

		public static readonly StringName MessyCardPreviewContainer;

		public static readonly StringName GridCardPreviewContainer;

		public static readonly StringName AboveTopBarVfxContainer;

		public static readonly StringName MapScreen;

		public static readonly StringName MultiplayerPlayerContainer;

		public static readonly StringName TimeoutOverlay;

		public static readonly StringName SubmenuStack;

		public static readonly StringName TargetManager;

		public static readonly StringName _window;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NTopBar TopBar
	{
		[CompilerGenerated]
		get;
	}

	public extern NOverlayStack Overlays
	{
		[CompilerGenerated]
		get;
	}

	public extern NCapstoneContainer CapstoneContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NRelicInventory RelicInventory
	{
		[CompilerGenerated]
		get;
	}

	public extern Control EventCardPreviewContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern Control CardPreviewContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NMessyCardPreviewContainer MessyCardPreviewContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NGridCardPreviewContainer GridCardPreviewContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern Control AboveTopBarVfxContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NMapScreen MapScreen
	{
		[CompilerGenerated]
		get;
	}

	public extern NMultiplayerPlayerStateContainer MultiplayerPlayerContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NMultiplayerTimeoutOverlay TimeoutOverlay
	{
		[CompilerGenerated]
		get;
	}

	public extern NCapstoneSubmenuStack SubmenuStack
	{
		[CompilerGenerated]
		get;
	}

	public extern NTargetManager TargetManager
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	public extern void ReparentCard(NCard card);

	public extern void Initialize(RunState runState);

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

	public extern NGlobalUi();
}
