using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NTargetManager.cs")]
public class NTargetManager : Node2D
{
	[Signal]
	public delegate void CreatureHoveredEventHandler(NCreature creature);

	[Signal]
	public delegate void CreatureUnhoveredEventHandler(NCreature creature);

	[Signal]
	public delegate void NodeHoveredEventHandler(Node node);

	[Signal]
	public delegate void NodeUnhoveredEventHandler(Node node);

	[Signal]
	public delegate void TargetingBeganEventHandler();

	[Signal]
	public delegate void TargetingEndedEventHandler();

	public new class MethodName : Node2D.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName _Input;

		public new static readonly StringName _Process;

		public static readonly StringName CancelTargeting;

		public static readonly StringName FinishTargeting;

		public static readonly StringName AllowedToTargetNode;

		public static readonly StringName OnNodeHovered;

		public static readonly StringName OnNodeUnhovered;

		public static readonly StringName OnCreatureHovered;

		public static readonly StringName OnCreatureUnhovered;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName IsInSelection;

		public static readonly StringName HoveredNode;

		public static readonly StringName LastTargetingFinishedFrame;

		public static readonly StringName _targetingArrow;

		public static readonly StringName _targetMode;

		public static readonly StringName _validTargetsType;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public static readonly StringName CreatureHovered;

		public static readonly StringName CreatureUnhovered;

		public static readonly StringName NodeHovered;

		public static readonly StringName NodeUnhovered;

		public static readonly StringName TargetingBegan;

		public static readonly StringName TargetingEnded;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NTargetManager Instance { get; }

	public extern bool IsInSelection { get; }

	public extern long LastTargetingFinishedFrame
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern event CreatureHoveredEventHandler CreatureHovered;

	public extern event CreatureUnhoveredEventHandler CreatureUnhovered;

	public extern event NodeHoveredEventHandler NodeHovered;

	public extern event NodeUnhoveredEventHandler NodeUnhovered;

	public extern event TargetingBeganEventHandler TargetingBegan;

	public extern event TargetingEndedEventHandler TargetingEnded;

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public override extern void _Input(InputEvent inputEvent);

	public override extern void _Process(double delta);

	public extern void CancelTargeting();

	[AsyncStateMachine(typeof(_003CSelectionFinished_003Ed__32))]
	public extern Task<Node?> SelectionFinished();

	public extern void StartTargeting(TargetType validTargetsType, Vector2 startPosition, TargetMode startingMode, Func<bool>? exitEarlyCondition, Func<Node, bool>? nodeFilter);

	public extern void StartTargeting(TargetType validTargetsType, Control control, TargetMode startingMode, Func<bool>? exitEarlyCondition, Func<Node, bool>? nodeFilter);

	public extern bool AllowedToTargetNode(Node node);

	public extern void OnNodeHovered(Node node);

	public extern void OnNodeUnhovered(Node node);

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

	protected extern void EmitSignalCreatureHovered(NCreature creature);

	protected extern void EmitSignalCreatureUnhovered(NCreature creature);

	protected extern void EmitSignalNodeHovered(Node node);

	protected extern void EmitSignalNodeUnhovered(Node node);

	protected extern void EmitSignalTargetingBegan();

	protected extern void EmitSignalTargetingEnded();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NTargetManager();
}
