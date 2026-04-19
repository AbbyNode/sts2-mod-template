using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Rooms;

namespace MegaCrit.Sts2.Core.Nodes.Events;

[ScriptPath("res://src/Core/Nodes/Events/NCombatEventLayout.cs")]
public class NCombatEventLayout : NEventLayout
{
	public new class MethodName : NEventLayout.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetCombatRoomNode;

		public new static readonly StringName InitializeVisuals;

		public static readonly StringName HideEventVisuals;

		public extern MethodName();
	}

	public new class PropertyName : NEventLayout.PropertyName
	{
		public static readonly StringName EmbeddedCombatRoom;

		public static readonly StringName HasCombatStarted;

		public new static readonly StringName DefaultFocusedControl;

		public static readonly StringName _combatRoomContainer;

		public extern PropertyName();
	}

	public new class SignalName : NEventLayout.SignalName
	{
		public extern SignalName();
	}

	public const string combatScenePath = "res://scenes/events/combat_event_layout.tscn";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NCombatRoom? EmbeddedCombatRoom
	{
		[CompilerGenerated]
		get;
	}

	public extern bool HasCombatStarted
	{
		[CompilerGenerated]
		get;
	}

	public override extern Control? DefaultFocusedControl { get; }

	public override extern void _Ready();

	public extern void SetCombatRoomNode(NCombatRoom? combatRoomNode);

	public override extern void SetEvent(EventModel eventModel);

	protected override extern void InitializeVisuals();

	public extern void HideEventVisuals();

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

	public extern NCombatEventLayout();
}
