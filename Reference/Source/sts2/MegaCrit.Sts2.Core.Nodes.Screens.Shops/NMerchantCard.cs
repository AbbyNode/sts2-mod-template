using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Merchant;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Shops;

[ScriptPath("res://src/Core/Nodes/Screens/Shops/NMerchantCard.cs")]
public class NMerchantCard : NMerchantSlot
{
	public new class MethodName : NMerchantSlot.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName UpdateVisual;

		public static readonly StringName OnInventoryOpened;

		public new static readonly StringName OnPreview;

		public new static readonly StringName CreateHoverTip;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : NMerchantSlot.PropertyName
	{
		public static readonly StringName IsShowingUpgradedCard;

		public new static readonly StringName Visual;

		public static readonly StringName _saleVisual;

		public static readonly StringName _cardHolder;

		public static readonly StringName _cardNode;

		public new static readonly StringName _hoverTween;

		public extern PropertyName();
	}

	public new class SignalName : NMerchantSlot.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsShowingUpgradedCard { get; }

	public override extern MerchantEntry Entry { get; }

	protected override extern CanvasItem Visual { get; }

	public override extern void _Ready();

	public extern void FillSlot(MerchantCardEntry cardEntry);

	protected override extern void UpdateVisual();

	public extern void OnInventoryOpened();

	[AsyncStateMachine(typeof(_003COnTryPurchase_003Ed__16))]
	protected override extern Task OnTryPurchase(MerchantInventory? inventory);

	protected extern void OnSuccessfulPurchase(PurchaseStatus _, MerchantEntry __);

	protected override extern void OnPreview();

	protected override extern void CreateHoverTip();

	public override extern void _ExitTree();

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

	public extern NMerchantCard();
}
