using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Relics;

[ScriptPath("res://src/Core/Nodes/Relics/NRelicInventoryHolder.cs")]
public class NRelicInventoryHolder : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName RefreshAmount;

		public static readonly StringName RefreshStatus;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public static readonly StringName DoFlash;

		public static readonly StringName OnDisplayAmountChanged;

		public static readonly StringName OnStatusChanged;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName Relic;

		public static readonly StringName Inventory;

		public static readonly StringName _relic;

		public static readonly StringName _amountLabel;

		public static readonly StringName _hoverTween;

		public static readonly StringName _obtainedTween;

		public static readonly StringName _originalIconPosition;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern NRelic Relic { get; }

	public extern NRelicInventory Inventory
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static extern NRelicInventoryHolder? Create(RelicModel relic);

	public override extern void _Ready();

	public override extern void _ExitTree();

	[AsyncStateMachine(typeof(_003CPlayNewlyAcquiredAnimation_003Ed__27))]
	public extern Task PlayNewlyAcquiredAnimation(Vector2? startLocation, Vector2? startScale);

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

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

	public extern NRelicInventoryHolder();
}
