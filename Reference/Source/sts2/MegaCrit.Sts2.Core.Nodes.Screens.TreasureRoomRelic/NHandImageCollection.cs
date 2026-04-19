using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.TreasureRelicPicking;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.TreasureRoomRelic;

[ScriptPath("res://src/Core/Nodes/Screens/TreasureRoomRelic/NHandImageCollection.cs")]
public class NHandImageCollection : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName OnInputStateAdded;

		public static readonly StringName OnInputStateRemoved;

		public static readonly StringName AddHand;

		public static readonly StringName OnInputStateChanged;

		public new static readonly StringName _Input;

		public static readonly StringName ProcessGuiFocus;

		public static readonly StringName GetHand;

		public static readonly StringName RemoveHand;

		public static readonly StringName UpdateHandVisibility;

		public static readonly StringName BeforeRelicsAwarded;

		public static readonly StringName AnimateHandsIn;

		public static readonly StringName AnimateHandsAway;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _handAnimateInProgress;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void Initialize(IRunState runState);

	public override extern void _Input(InputEvent inputEvent);

	public extern NHandImage? GetHand(ulong playerId);

	public extern void BeforeRelicsAwarded();

	public extern void BeforeFightStarted(List<Player> playersInvolved);

	public extern void AnimateHandsIn();

	public extern void AnimateHandsAway();

	[AsyncStateMachine(typeof(_003CDoFight_003Ed__20))]
	public extern Task DoFight(RelicPickingResult result, NTreasureRoomRelicHolder holder);

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

	public extern NHandImageCollection();
}
