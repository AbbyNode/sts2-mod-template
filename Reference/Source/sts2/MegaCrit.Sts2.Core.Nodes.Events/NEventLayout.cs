using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Events;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.addons.mega_text;

namespace MegaCrit.Sts2.Core.Nodes.Events;

[ScriptPath("res://src/Core/Nodes/Events/NEventLayout.cs")]
public class NEventLayout : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName InitializeVisuals;

		public static readonly StringName SetPortrait;

		public static readonly StringName AddVfxAnchoredToPortrait;

		public static readonly StringName RemoveNodesOnPortrait;

		public static readonly StringName SetTitle;

		public static readonly StringName SetDescription;

		public static readonly StringName AnimateIn;

		public static readonly StringName ClearOptions;

		public static readonly StringName OnSetupComplete;

		public static readonly StringName AnimateButtonsIn;

		public static readonly StringName DisableEventOptions;

		public new static readonly StringName _Input;

		public static readonly StringName ApplyDebugUiVisibility;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName VfxContainer;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _descriptionTween;

		public static readonly StringName _optionsContainer;

		public static readonly StringName _portrait;

		public static readonly StringName _title;

		public static readonly StringName _sharedEventLabel;

		public static readonly StringName _description;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	public const string defaultScenePath = "res://scenes/events/default_event_layout.tscn";

	protected Tween? _descriptionTween;

	protected VBoxContainer _optionsContainer;

	protected EventModel _event;

	protected MegaLabel? _sharedEventLabel;

	protected MegaRichTextLabel? _description;

	public extern Control? VfxContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<NEventOptionButton> OptionButtons { get; }

	public virtual extern Control? DefaultFocusedControl { get; }

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public virtual extern void SetEvent(EventModel eventModel);

	protected virtual extern void InitializeVisuals();

	public extern void SetPortrait(Texture2D portrait);

	public extern void AddVfxAnchoredToPortrait(Node? vfx);

	public extern void RemoveNodesOnPortrait();

	public extern void SetTitle(string title);

	public extern void SetDescription(string description);

	protected virtual extern void AnimateIn();

	public extern void ClearOptions();

	public extern void AddOptions(IEnumerable<EventOption> options);

	public virtual extern void OnSetupComplete();

	protected virtual extern void AnimateButtonsIn();

	[AsyncStateMachine(typeof(_003CBeforeSharedOptionChosen_003Ed__31))]
	public extern Task BeforeSharedOptionChosen(EventOption option);

	public extern void DisableEventOptions();

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

	public extern NEventLayout();
}
