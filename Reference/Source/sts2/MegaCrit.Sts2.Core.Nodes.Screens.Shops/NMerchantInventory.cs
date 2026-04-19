using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Merchant;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Shops;

[ScriptPath("res://src/Core/Nodes/Screens/Shops/NMerchantInventory.cs")]
public class NMerchantInventory : Control, IScreenContext
{
	[Signal]
	public delegate void InventoryClosedEventHandler();

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName Open;

		public static readonly StringName SubscribeToEntries;

		public static readonly StringName Close;

		public static readonly StringName OnCardRemovalUsed;

		public static readonly StringName UpdateNavigation;

		public static readonly StringName UpdateHorizontalNavigation;

		public static readonly StringName UpdateVerticalNavigation;

		public static readonly StringName OnActiveScreenUpdated;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName IsOpen;

		public static readonly StringName MerchantHand;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _characterCardContainer;

		public static readonly StringName _colorlessCardContainer;

		public static readonly StringName _relicContainer;

		public static readonly StringName _potionContainer;

		public static readonly StringName _cardRemovalNode;

		public static readonly StringName _backButton;

		public static readonly StringName _merchantDialogue;

		public static readonly StringName _inventoryTween;

		public static readonly StringName _slotsContainer;

		public static readonly StringName _backstop;

		public static readonly StringName _lastSlot;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName InventoryClosed;

		public extern SignalName();
	}

	protected Control? _relicContainer;

	public extern MerchantInventory? Inventory
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsOpen
	{
		[CompilerGenerated]
		get;
	}

	public extern NMerchantHand MerchantHand
	{
		[CompilerGenerated]
		get;
	}

	public extern Control? DefaultFocusedControl { get; }

	public extern event InventoryClosedEventHandler InventoryClosed;

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void Initialize(MerchantInventory inventory, MerchantDialogueSet dialogue);

	public extern void Open();

	public extern void OnCardRemovalUsed();

	public extern IEnumerable<NMerchantSlot> GetAllSlots();

	protected virtual extern void UpdateNavigation();

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

	protected extern void EmitSignalInventoryClosed();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NMerchantInventory();
}
