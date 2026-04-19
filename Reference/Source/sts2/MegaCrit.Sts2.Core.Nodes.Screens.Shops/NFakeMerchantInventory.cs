using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Shops;

[ScriptPath("res://src/Core/Nodes/Screens/Shops/NFakeMerchantInventory.cs")]
public class NFakeMerchantInventory : NMerchantInventory
{
	public new class MethodName : NMerchantInventory.MethodName
	{
		public new static readonly StringName UpdateNavigation;

		public extern MethodName();
	}

	public new class PropertyName : NMerchantInventory.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : NMerchantInventory.SignalName
	{
		public extern SignalName();
	}

	protected override extern void UpdateNavigation();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NFakeMerchantInventory();
}
