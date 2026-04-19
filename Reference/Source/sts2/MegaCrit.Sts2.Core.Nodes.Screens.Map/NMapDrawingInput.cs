using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Map;

[ScriptPath("res://src/Core/Nodes/Screens/Map/NMapDrawingInput.cs")]
public abstract class NMapDrawingInput : Control
{
	[Signal]
	public delegate void FinishedEventHandler();

	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName StopDrawing;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName DrawingMode;

		public static readonly StringName _drawings;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName Finished;

		public extern SignalName();
	}

	protected NMapDrawings _drawings;

	public extern DrawingMode DrawingMode
	{
		[CompilerGenerated]
		get;
	}

	public extern event FinishedEventHandler Finished;

	public static extern NMapDrawingInput Create(NMapDrawings drawings, DrawingMode drawingMode, bool stopOnMouseRelease = false);

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void StopDrawing();

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

	protected extern void EmitSignalFinished();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	protected extern NMapDrawingInput();
}
