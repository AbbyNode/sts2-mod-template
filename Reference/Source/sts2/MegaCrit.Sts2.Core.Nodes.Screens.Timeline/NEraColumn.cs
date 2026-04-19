using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Timeline;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Timeline;

[ScriptPath("res://src/Core/Nodes/Screens/Timeline/NEraColumn.cs")]
public class NEraColumn : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SpawnIcon;

		public static readonly StringName SetPredictedPosition;

		public static readonly StringName RectChange;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _icon;

		public static readonly StringName _name;

		public static readonly StringName _year;

		public static readonly StringName _iconTween;

		public static readonly StringName _labelTween;

		public static readonly StringName _labelSpawned;

		public static readonly StringName era;

		public static readonly StringName _prevLocalPos;

		public static readonly StringName _prevGlobalPos;

		public static readonly StringName _predictedPosition;

		public static readonly StringName _targetPosition;

		public static readonly StringName _isAnimated;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	public static readonly IEnumerable<string> assetPaths;

	public EpochEra era;

	public static extern NEraColumn Create(EpochSlotData data);

	public override extern void _Ready();

	public extern void Init(EpochSlotData epochSlot);

	public extern void AddSlot(EpochSlotData epochSlotData);

	public extern void SpawnIcon();

	[AsyncStateMachine(typeof(_003CSpawnSlots_003Ed__20))]
	public extern Task SpawnSlots(bool isAnimated);

	[AsyncStateMachine(typeof(_003CSpawnNameAndYear_003Ed__21))]
	public extern Task SpawnNameAndYear();

	[AsyncStateMachine(typeof(_003CSaveBeforeAnimationPosition_003Ed__22))]
	public extern Task SaveBeforeAnimationPosition();

	public extern void SetPredictedPosition(Vector2 setPredictedPosition);

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

	public extern NEraColumn();
}
