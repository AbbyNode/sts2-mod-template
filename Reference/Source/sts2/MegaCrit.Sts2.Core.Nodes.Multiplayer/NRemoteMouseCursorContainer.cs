using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;

namespace MegaCrit.Sts2.Core.Nodes.Multiplayer;

[ScriptPath("res://src/Core/Nodes/Multiplayer/NRemoteMouseCursorContainer.cs")]
public class NRemoteMouseCursorContainer : Control
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Deinitialize;

		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName ForceUpdateAllCursors;

		public static readonly StringName GetCursorPosition;

		public static readonly StringName OnInputStateAdded;

		public static readonly StringName OnInputStateRemoved;

		public static readonly StringName AddCursor;

		public static readonly StringName OnInputStateChanged;

		public static readonly StringName DrawingCursorStateChanged;

		public static readonly StringName GetDrawingMode;

		public static readonly StringName GetCursor;

		public static readonly StringName RemoveCursor;

		public static readonly StringName UpdateCursorVisibility;

		public new static readonly StringName _Input;

		public static readonly StringName OnGuiFocusChanged;

		public static readonly StringName ApplyDebugUiVisibility;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern void Initialize(PeerInputSynchronizer synchronizer, IEnumerable<ulong> connectedPlayerIds);

	public extern void Deinitialize();

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void ForceUpdateAllCursors();

	public extern Vector2 GetCursorPosition(ulong playerId);

	public extern void DrawingCursorStateChanged(ulong playerId);

	public override extern void _Input(InputEvent inputEvent);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NRemoteMouseCursorContainer();
}
