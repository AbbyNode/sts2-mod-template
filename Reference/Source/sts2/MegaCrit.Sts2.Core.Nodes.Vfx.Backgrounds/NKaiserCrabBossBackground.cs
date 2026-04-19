using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx.Backgrounds;

[GlobalClass]
[ScriptPath("res://src/Core/Nodes/Vfx/Backgrounds/NKaiserCrabBossBackground.cs")]
public class NKaiserCrabBossBackground : Node
{
	public enum ArmSide
	{
		Left,
		Right
	}

	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName PlayHurtAnim;

		public static readonly StringName PlayArmDeathAnim;

		public static readonly StringName PlayBodyDeathAnim;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _leftArm;

		public static readonly StringName _rightArm;

		public static readonly StringName _rightArmState;

		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	[AsyncStateMachine(typeof(_003CPlayAttackAnim_003Ed__11))]
	public extern Task PlayAttackAnim(ArmSide side, string animation, float duration);

	public extern void PlayHurtAnim(ArmSide side);

	public extern void PlayArmDeathAnim(ArmSide side);

	[AsyncStateMachine(typeof(_003CPlayRightSideChargeUpAnim_003Ed__14))]
	public extern Task PlayRightSideChargeUpAnim(float duration);

	[AsyncStateMachine(typeof(_003CPlayRightSideHeavy_003Ed__15))]
	public extern Task PlayRightSideHeavy(float duration);

	[AsyncStateMachine(typeof(_003CPlayRightRecharge_003Ed__16))]
	public extern Task PlayRightRecharge(float duration);

	public extern void PlayBodyDeathAnim();

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

	public extern NKaiserCrabBossBackground();
}
