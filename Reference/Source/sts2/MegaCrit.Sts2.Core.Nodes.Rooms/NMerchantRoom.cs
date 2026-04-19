using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models.Potions;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Nodes.Screens.Shops;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Nodes.Rooms;

[ScriptPath("res://src/Core/Nodes/Rooms/NMerchantRoom.cs")]
public class NMerchantRoom : Control, IScreenContext, IRoomWithProceedButton
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName ToggleMerchantTrack;

		public static readonly StringName AfterRoomIsLoaded;

		public static readonly StringName HideScreen;

		public static readonly StringName MerchantFtueCheck;

		public static readonly StringName OnMerchantOpened;

		public static readonly StringName OpenInventory;

		public static readonly StringName OnActiveScreenUpdated;

		public static readonly StringName BlockInput;

		public static readonly StringName UnblockInput;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName ProceedButton;

		public static readonly StringName Inventory;

		public static readonly StringName MerchantButton;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _proceedButton;

		public static readonly StringName _characterContainer;

		public static readonly StringName _inputBlocker;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NMerchantRoom? Instance { get; }

	public extern NProceedButton ProceedButton { get; }

	public extern MerchantRoom Room
	{
		[CompilerGenerated]
		get;
	}

	public extern NMerchantInventory Inventory
	{
		[CompilerGenerated]
		get;
	}

	public extern NMerchantButton MerchantButton
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<NMerchantCharacter> PlayerVisuals { get; }

	public extern Control? DefaultFocusedControl { get; }

	public static extern NMerchantRoom? Create(MerchantRoom room, IReadOnlyList<Player> players);

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void FoulPotionThrown(FoulPotion potion);

	public extern void OpenInventory();

	public extern void BlockInput();

	public extern void UnblockInput();

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

	public extern NMerchantRoom();
}
