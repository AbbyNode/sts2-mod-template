using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Events.Custom.CrystalSphereEvent;
using MegaCrit.Sts2.Core.Nodes.Screens.Overlays;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Events.Custom.CrystalSphere;

[ScriptPath("res://src/Core/Nodes/Events/Custom/CrystalSphere/NCrystalSphereScreen.cs")]
public class NCrystalSphereScreen : Control, IOverlayScreen, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetBigDivination;

		public static readonly StringName SetSmallDivination;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName OnHoverCell;

		public static readonly StringName OnUnhoverCell;

		public static readonly StringName UpdateDivinationsLeft;

		public static readonly StringName OnMinigameFinished;

		public static readonly StringName OnProceedButtonPressed;

		public static readonly StringName AfterOverlayOpened;

		public static readonly StringName AfterOverlayClosed;

		public static readonly StringName AfterOverlayShown;

		public static readonly StringName AfterOverlayHidden;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName ScreenType;

		public static readonly StringName UseSharedBackstop;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _itemsContainer;

		public static readonly StringName _cellContainer;

		public static readonly StringName _bigDivinationButton;

		public static readonly StringName _smallDivinationButton;

		public static readonly StringName _divinationsLeftLabel;

		public static readonly StringName _mask;

		public static readonly StringName _proceedButton;

		public static readonly StringName _instructionsTitleLabel;

		public static readonly StringName _instructionsDescriptionLabel;

		public static readonly StringName _instructionsContainer;

		public static readonly StringName _dialogue;

		public static readonly StringName _fadeTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NetScreenType ScreenType { get; }

	public extern bool UseSharedBackstop { get; }

	public extern Control DefaultFocusedControl { get; }

	public static extern NCrystalSphereScreen ShowScreen(CrystalSphereMinigame grid);

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void AfterOverlayOpened();

	public extern void AfterOverlayClosed();

	public extern void AfterOverlayShown();

	public extern void AfterOverlayHidden();

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

	public extern NCrystalSphereScreen();
}
