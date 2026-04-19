using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Merchant;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Shops;

[ScriptPath("res://src/Core/Nodes/Screens/Shops/NMerchantRelic.cs")]
public class NMerchantRelic : NMerchantSlot
{
	public new class MethodName : NMerchantSlot.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName UpdateVisual;

		public new static readonly StringName CreateHoverTip;

		public new static readonly StringName OnPreview;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : NMerchantSlot.PropertyName
	{
		public new static readonly StringName Visual;

		public static readonly StringName _iconSize;

		public static readonly StringName _relicHolder;

		public static readonly StringName _relicNode;

		public static readonly StringName _relicNodePosition;

		public extern PropertyName();
	}

	public new class SignalName : NMerchantSlot.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern MerchantEntry Entry { get; }

	protected override extern CanvasItem Visual { get; }

	public override extern void _Ready();

	public extern void FillSlot(MerchantRelicEntry relicEntry);

	protected override extern void UpdateVisual();

	[AsyncStateMachine(typeof(_003COnTryPurchase_003Ed__13))]
	protected override extern Task OnTryPurchase(MerchantInventory? inventory);

	protected override extern void CreateHoverTip();

	protected override extern void OnPreview();

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

	public extern NMerchantRelic();
}
