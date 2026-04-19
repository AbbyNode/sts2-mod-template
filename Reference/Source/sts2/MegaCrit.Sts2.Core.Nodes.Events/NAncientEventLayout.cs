using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Ancients;

namespace MegaCrit.Sts2.Core.Nodes.Events;

[ScriptPath("res://src/Core/Nodes/Events/NAncientEventLayout.cs")]
public class NAncientEventLayout : NEventLayout
{
	public new class MethodName : NEventLayout.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName InitializeVisuals;

		public new static readonly StringName AnimateIn;

		public static readonly StringName ClearDialogue;

		public new static readonly StringName OnSetupComplete;

		public new static readonly StringName AnimateButtonsIn;

		public static readonly StringName OnDialogueHitboxClicked;

		public static readonly StringName SetDialogueLineAndAnimate;

		public static readonly StringName UpdateFakeNextButton;

		public static readonly StringName HideNameBanner;

		public static readonly StringName ShowNameBanner;

		public static readonly StringName UpdateBannerVisibility;

		public static readonly StringName UpdateHotkeyDisplay;

		public extern MethodName();
	}

	public new class PropertyName : NEventLayout.PropertyName
	{
		public static readonly StringName IsDialogueOnLastLine;

		public new static readonly StringName DefaultFocusedControl;

		public static readonly StringName _currentDialogueLine;

		public static readonly StringName _ancientBgContainer;

		public static readonly StringName _ancientNameBanner;

		public static readonly StringName _bannerTween;

		public static readonly StringName _contentContainer;

		public static readonly StringName _originalContentContainerHeight;

		public static readonly StringName _content;

		public static readonly StringName _dialogueContainer;

		public static readonly StringName _dialogueHitbox;

		public static readonly StringName _fakeNextButtonContainer;

		public static readonly StringName _fakeNextButton;

		public static readonly StringName _fakeNextButtonControllerIcon;

		public static readonly StringName _fakeNextButtonLabel;

		public static readonly StringName _contentTween;

		public extern PropertyName();
	}

	public new class SignalName : NEventLayout.SignalName
	{
		public extern SignalName();
	}

	public const string ancientScenePath = "res://scenes/events/ancient_event_layout.tscn";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern Control? DefaultFocusedControl { get; }

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	protected override extern void InitializeVisuals();

	protected override extern void AnimateIn();

	public extern void SetDialogue(IReadOnlyList<AncientDialogueLine> lines);

	public extern void ClearDialogue();

	public override extern void OnSetupComplete();

	protected override extern void AnimateButtonsIn();

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

	public extern NAncientEventLayout();
}
