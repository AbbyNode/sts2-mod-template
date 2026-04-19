using System.ComponentModel;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Merchant;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.addons.mega_text;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Shops;

[ScriptPath("res://src/Core/Nodes/Screens/Shops/NMerchantSlot.cs")]
public abstract class NMerchantSlot : Control
{
	[Signal]
	public delegate void HoveredEventHandler(NMerchantSlot slot);

	[Signal]
	public delegate void UnhoveredEventHandler(NMerchantSlot slot);

	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Initialize;

		public new static readonly StringName _Ready;

		public static readonly StringName ConnectSignals;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName _GuiInput;

		public static readonly StringName OnMousePressed;

		public static readonly StringName OnMouseReleased;

		public static readonly StringName OnFocus;

		public static readonly StringName OnUnfocus;

		public static readonly StringName TriggerMerchantHandToPointHere;

		public static readonly StringName OnPreview;

		public static readonly StringName CreateHoverTip;

		public static readonly StringName ClearHoverTip;

		public static readonly StringName OnMerchantHandHovered;

		public static readonly StringName OnMerchantHandUnhovered;

		public static readonly StringName OnPurchaseFailed;

		public static readonly StringName UpdateVisual;

		public static readonly StringName WiggleAnimation;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Hitbox;

		public static readonly StringName Visual;

		public static readonly StringName _isHovered;

		public static readonly StringName _hitbox;

		public static readonly StringName _costLabel;

		public static readonly StringName _hoverTween;

		public static readonly StringName _purchaseFailedTween;

		public static readonly StringName _merchantRug;

		public static readonly StringName _ignoreMouseRelease;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName Hovered;

		public static readonly StringName Unhovered;

		public extern SignalName();
	}

	protected NClickableControl _hitbox;

	protected MegaLabel _costLabel;

	public extern NClickableControl Hitbox { get; }

	public abstract MerchantEntry Entry { get; }

	protected abstract CanvasItem Visual { get; }

	protected extern Player? Player { get; }

	public extern event HoveredEventHandler Hovered;

	public extern event UnhoveredEventHandler Unhovered;

	public extern void Initialize(NMerchantInventory rug);

	public override extern void _Ready();

	protected virtual extern void ConnectSignals();

	public override extern void _ExitTree();

	public override extern void _GuiInput(InputEvent inputEvent);

	protected abstract Task OnTryPurchase(MerchantInventory? inventory);

	protected extern void TriggerMerchantHandToPointHere();

	protected virtual extern void OnPreview();

	protected abstract void CreateHoverTip();

	protected extern void ClearHoverTip();

	protected extern void OnPurchaseFailed(PurchaseStatus status);

	protected virtual extern void UpdateVisual();

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

	protected extern void EmitSignalHovered(NMerchantSlot slot);

	protected extern void EmitSignalUnhovered(NMerchantSlot slot);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	protected extern NMerchantSlot();
}
