using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Cards.Holders;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NControllerCardPlay.cs")]
public class NControllerCardPlay : NCardPlay
{
	[Signal]
	public delegate void ConfirmedEventHandler();

	[Signal]
	public delegate void CanceledEventHandler();

	public new class MethodName : NCardPlay.MethodName
	{
		public new static readonly StringName _Input;

		public static readonly StringName Create;

		public new static readonly StringName Start;

		public static readonly StringName MultiCreatureTargeting;

		public new static readonly StringName OnCancelPlayCard;

		public new static readonly StringName Cleanup;

		public extern MethodName();
	}

	public new class PropertyName : NCardPlay.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : NCardPlay.SignalName
	{
		public static readonly StringName Confirmed;

		public static readonly StringName Canceled;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern event ConfirmedEventHandler Confirmed;

	public extern event CanceledEventHandler Canceled;

	public override extern void _Input(InputEvent inputEvent);

	public static extern NControllerCardPlay Create(NHandCardHolder holder);

	public override extern void Start();

	protected override extern void OnCancelPlayCard();

	protected override extern void Cleanup();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	protected extern void EmitSignalConfirmed();

	protected extern void EmitSignalCanceled();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NControllerCardPlay();
}
