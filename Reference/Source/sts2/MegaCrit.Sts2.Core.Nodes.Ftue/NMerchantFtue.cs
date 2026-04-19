using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Rooms;

namespace MegaCrit.Sts2.Core.Nodes.Ftue;

[ScriptPath("res://src/Core/Nodes/Ftue/NMerchantFtue.cs")]
public class NMerchantFtue : NFtue
{
	public new class MethodName : NFtue.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Create;

		public static readonly StringName CloseFtueAndOpenRug;

		public new static readonly StringName CloseFtue;

		public extern MethodName();
	}

	public new class PropertyName : NFtue.PropertyName
	{
		public static readonly StringName _confirmButton;

		public static readonly StringName _header;

		public static readonly StringName _description;

		public static readonly StringName _sneakyHitbox;

		public static readonly StringName _merchantRoom;

		public static readonly StringName _defaultZIndex;

		public extern PropertyName();
	}

	public new class SignalName : NFtue.SignalName
	{
		public extern SignalName();
	}

	public const string id = "merchant_ftue";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public static extern NMerchantFtue? Create(NMerchantRoom merchantRoom);

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

	public extern NMerchantFtue();
}
