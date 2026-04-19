using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.MapDrawing;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Map;

[ScriptPath("res://src/Core/Nodes/Screens/Map/NMapDrawings.cs")]
public class NMapDrawings : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName UpdateCurrentLinePositionLocal;

		public static readonly StringName StopLineLocal;

		public static readonly StringName SetDrawingModeLocal;

		public static readonly StringName ClearDrawnLinesLocal;

		public static readonly StringName IsDrawing;

		public static readonly StringName IsLocalDrawing;

		public static readonly StringName GetDrawingMode;

		public static readonly StringName GetLocalDrawingMode;

		public static readonly StringName ToNetPosition;

		public static readonly StringName FromNetPosition;

		public static readonly StringName ClearAllLines;

		public static readonly StringName OnPlayerScreenChanged;

		public static readonly StringName TrySendSyncMessage;

		public static readonly StringName SendSyncMessage;

		public static readonly StringName UpdateLocalCursor;

		public static readonly StringName RepositionBasedOnBackground;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _lineDrawScene;

		public static readonly StringName _lineEraseScene;

		public static readonly StringName _cursorManager;

		public static readonly StringName _eraserMaterial;

		public static readonly StringName _defaultSize;

		public static readonly StringName _lastMessageMsec;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	public const string drawingCursorPath = "res://images/packed/common_ui/cursor_quill.png";

	public const string drawingCursorTiltedPath = "res://images/packed/common_ui/cursor_quill_tilted.png";

	public static readonly Vector2 drawingCursorHotspot;

	public const string erasingCursorPath = "res://images/packed/common_ui/cursor_eraser.png";

	public const string erasingCursorTiltedPath = "res://images/packed/common_ui/cursor_eraser_tilted.png";

	public static readonly Vector2 erasingCursorHotspot;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public override extern void _Ready();

	public extern void Initialize(INetGameService netService, IPlayerCollection playerCollection, PeerInputSynchronizer inputSynchronizer);

	public override extern void _ExitTree();

	public extern void BeginLineLocal(Vector2 position, DrawingMode? overrideDrawingMode);

	public extern void UpdateCurrentLinePositionLocal(Vector2 position);

	public extern void StopLineLocal();

	public extern void SetDrawingModeLocal(DrawingMode drawingMode);

	public extern void ClearDrawnLinesLocal();

	public extern bool IsDrawing(ulong playerId);

	public extern bool IsLocalDrawing();

	public extern DrawingMode GetDrawingMode(ulong playerId);

	public extern DrawingMode GetLocalDrawingMode(bool useOverride = true);

	public extern void ClearAllLines();

	public extern SerializableMapDrawings GetSerializableMapDrawings();

	public extern void LoadDrawings(SerializableMapDrawings drawings);

	public extern void RepositionBasedOnBackground(Control mapBg);

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

	public extern NMapDrawings();
}
