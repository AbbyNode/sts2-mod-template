using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.RestSite;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.RestSite;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Rooms;

[ScriptPath("res://src/Core/Nodes/Rooms/NRestSiteRoom.cs")]
public class NRestSiteRoom : Control, IScreenContext, IRoomWithProceedButton
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName DisableOptions;

		public static readonly StringName EnableOptions;

		public static readonly StringName AnimateDescriptionDown;

		public static readonly StringName AnimateDescriptionUp;

		public static readonly StringName UpdateRestSiteOptions;

		public static readonly StringName RestSiteButtonHovered;

		public static readonly StringName RestSiteButtonUnhovered;

		public static readonly StringName OnPlayerChangedHoveredRestSiteOption;

		public static readonly StringName ShowProceedButton;

		public static readonly StringName OnProceedButtonReleased;

		public static readonly StringName SetText;

		public static readonly StringName FadeOutOptionDescription;

		public new static readonly StringName _Input;

		public static readonly StringName ExtinguishFireIfAble;

		public static readonly StringName OnActiveScreenUpdated;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName ProceedButton;

		public static readonly StringName Header;

		public static readonly StringName Description;

		public static readonly StringName BgContainer;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _choicesContainer;

		public static readonly StringName _choicesScreen;

		public static readonly StringName _proceedButton;

		public static readonly StringName _restSiteLighting;

		public static readonly StringName _descriptionTween;

		public static readonly StringName _descriptionPositionTween;

		public static readonly StringName _choicesTween;

		public static readonly StringName _originalDescriptionYPos;

		public static readonly StringName _lastFocused;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	public readonly List<NRestSiteCharacter> characterAnims;

	public static extern NRestSiteRoom? Instance { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern NProceedButton ProceedButton { get; }

	public extern IReadOnlyList<RestSiteOption> Options { get; }

	public extern List<NRestSiteCharacter> Characters
	{
		[CompilerGenerated]
		get;
	}

	public extern Control? DefaultFocusedControl { get; }

	public static extern NRestSiteRoom? Create(RestSiteRoom room, IRunState runState);

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void AfterSelectingOption(RestSiteOption option);

	public extern void DisableOptions();

	public extern void EnableOptions();

	public extern void AnimateDescriptionDown();

	public extern void AnimateDescriptionUp();

	public extern NRestSiteButton? GetButtonForOption(RestSiteOption option);

	public extern NRestSiteCharacter? GetCharacterForPlayer(Player player);

	public extern void SetText(string formattedText);

	public extern void FadeOutOptionDescription();

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

	public extern NRestSiteRoom();
}
