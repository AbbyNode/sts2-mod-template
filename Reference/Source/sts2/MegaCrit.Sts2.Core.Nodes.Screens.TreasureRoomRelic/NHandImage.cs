using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.TreasureRelicPicking;

namespace MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic;

[ScriptPath("res://src/Core/Nodes/Screens/TreasureRoomRelic/NHandImage.cs")]
public class NHandImage : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetIsInFight;

		public static readonly StringName SetFrozenForRelicAwards;

		public static readonly StringName DoFightMove;

		public static readonly StringName SetTextureToFightMove;

		public static readonly StringName SetPointingPosition;

		public static readonly StringName AnimateAway;

		public static readonly StringName AnimateIn;

		public static readonly StringName SetIsDown;

		public static readonly StringName SetAnimateInProgress;

		public new static readonly StringName _Process;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Index;

		public static readonly StringName IsDown;

		public static readonly StringName _grabMarker;

		public static readonly StringName _textureRect;

		public static readonly StringName _currentVelocity;

		public static readonly StringName _desiredPosition;

		public static readonly StringName _downTween;

		public static readonly StringName _state;

		public static readonly StringName _isInFight;

		public static readonly StringName _originalPosition;

		public static readonly StringName _handAnimateInProgress;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Player Player
	{
		[CompilerGenerated]
		get;
	}

	public extern int Index
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsDown
	{
		[CompilerGenerated]
		get;
	}

	public static extern NHandImage Create(Player player, int slotIndex);

	public override extern void _Ready();

	public extern void SetIsInFight(bool inFight);

	public extern void SetFrozenForRelicAwards(bool frozenForRelicAwards);

	public extern Tween DoFightMove(RelicPickingFightMove move, float duration);

	public extern void SetPointingPosition(Vector2 position);

	public extern void AnimateAway();

	public extern void AnimateIn();

	public extern void SetIsDown(bool isDown);

	[AsyncStateMachine(typeof(_003CDoLoseShake_003Ed__35))]
	public extern Task DoLoseShake(float duration);

	[AsyncStateMachine(typeof(_003CGrabRelic_003Ed__36))]
	public extern Task GrabRelic(NTreasureRoomRelicHolder holder);

	public extern void SetAnimateInProgress(float animateInProgress);

	public override extern void _Process(double delta);

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

	public extern NHandImage();
}
