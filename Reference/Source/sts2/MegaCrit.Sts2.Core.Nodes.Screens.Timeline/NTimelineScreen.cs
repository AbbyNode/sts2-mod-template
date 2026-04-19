using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Timeline;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Timeline;

[ScriptPath("res://src/Core/Nodes/Screens/Timeline/NTimelineScreen.cs")]
public class NTimelineScreen : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName OnSubmenuOpened;

		public new static readonly StringName OnSubmenuClosed;

		public new static readonly StringName OnSubmenuShown;

		public new static readonly StringName OnSubmenuHidden;

		public new static readonly StringName _Ready;

		public static readonly StringName OnBackButtonPressed;

		public static readonly StringName GetEraTexturePath;

		public static readonly StringName GetSlot;

		public static readonly StringName OpenInspectScreen;

		public static readonly StringName QueueMiscUnlock;

		public static readonly StringName SetScreenDraggability;

		public static readonly StringName ShowBackstopAndHideUi;

		public static readonly StringName OpenQueuedScreen;

		public static readonly StringName IsScreenQueued;

		public static readonly StringName IsInspectScreenQueued;

		public static readonly StringName ShowHeaderAndActionsUi;

		public static readonly StringName DisableInput;

		public static readonly StringName EnableInput;

		public static readonly StringName RefreshBackButton;

		public static readonly StringName ResetScreen;

		public static readonly StringName GetReminderVfxHolder;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _inspectScreen;

		public static readonly StringName _reminderText;

		public static readonly StringName _reminderVfxHolder;

		public static readonly StringName _backstop;

		public static readonly StringName _inputBlocker;

		public static readonly StringName _lineContainer;

		public static readonly StringName _line;

		public static readonly StringName _epochSlotContainer;

		public static readonly StringName _slotsContainer;

		public new static readonly StringName _backButton;

		public static readonly StringName _isUiVisible;

		public static readonly StringName _queuedInspectScreen;

		public static readonly StringName _lineGrowTween;

		public static readonly StringName _backstopTween;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string[] AssetPaths { get; }

	public static extern NTimelineScreen Instance { get; }

	protected override extern Control? InitialFocusedControl { get; }

	public static extern NTimelineScreen? Create();

	public override extern void OnSubmenuOpened();

	public override extern void OnSubmenuClosed();

	protected override extern void OnSubmenuShown();

	protected override extern void OnSubmenuHidden();

	public override extern void _Ready();

	[AsyncStateMachine(typeof(_003CSpawnFirstTimeTimeline_003Ed__31))]
	public extern Task SpawnFirstTimeTimeline();

	[AsyncStateMachine(typeof(_003CAddEpochSlots_003Ed__34))]
	public extern Task AddEpochSlots(List<EpochSlotData> slotsToAdd, bool isAnimated);

	public static extern (Texture2D Texture, string Name) GetEraIcon(EpochEra era);

	public extern void OpenInspectScreen(NEpochSlot slot, bool playAnimation);

	public extern void QueueMiscUnlock(string text);

	public extern void QueueCharacterUnlock<T>(EpochModel epoch) where T : CharacterModel;

	public extern void QueueCardUnlock(IReadOnlyList<CardModel> cards);

	public extern void QueueRelicUnlock(List<RelicModel> relics);

	public extern void QueuePotionUnlock(List<PotionModel> potions);

	public extern void QueueTimelineExpansion(List<EpochSlotData> eraData);

	public extern void SetScreenDraggability();

	public extern void ShowBackstopAndHideUi();

	[AsyncStateMachine(typeof(_003CHideBackstopAndShowUi_003Ed__51))]
	public extern Task HideBackstopAndShowUi(bool showBackButton);

	public extern void OpenQueuedScreen();

	public extern bool IsScreenQueued();

	public extern void ShowHeaderAndActionsUi();

	public extern void DisableInput();

	public extern void EnableInput();

	public extern Control GetReminderVfxHolder();

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

	public extern NTimelineScreen();
}
