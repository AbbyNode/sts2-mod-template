using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Cards.Holders;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NMouseCardPlay.cs")]
public class NMouseCardPlay : NCardPlay
{
	public new class MethodName : NCardPlay.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Input;

		public new static readonly StringName Start;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName DisconnectTargetingSignals;

		public new static readonly StringName OnCancelPlayCard;

		public static readonly StringName IsCardInPlayZone;

		public static readonly StringName IsCardInCancelZone;

		public extern MethodName();
	}

	public new class PropertyName : NCardPlay.PropertyName
	{
		public static readonly StringName PlayZoneThreshold;

		public static readonly StringName CancelZoneThreshold;

		public static readonly StringName _dragStartYPosition;

		public static readonly StringName _isLeftMouseDown;

		public static readonly StringName _onCreatureHoverCallable;

		public static readonly StringName _onCreatureUnhoverCallable;

		public static readonly StringName _signalsConnected;

		public static readonly StringName _cancelShortcut;

		public static readonly StringName _skipStartCardDrag;

		public extern PropertyName();
	}

	public new class SignalName : NCardPlay.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NMouseCardPlay Create(NHandCardHolder holder, StringName cancelShortcut, bool wasStartedWithShortcut);

	public override extern void _Input(InputEvent inputEvent);

	public override extern void Start();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	protected override extern void OnCancelPlayCard();

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

	public extern NMouseCardPlay();
}
