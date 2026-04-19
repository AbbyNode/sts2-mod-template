using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Debug;

[Tool]
[ScriptPath("res://src/Core/Debug/NBgLayerDebug.cs")]
public class NBgLayerDebug : Control
{
	public enum LayerVisibility
	{
		A,
		B,
		C
	}

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _EnterTree;

		public static readonly StringName ReloadLayers;

		public static readonly StringName UpdateLayers;

		public static readonly StringName AddLayer;

		public static readonly StringName ToLayerName;

		public static readonly StringName ClearLayers;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName VisibleLayer;

		public static readonly StringName ReloadLayersCallable;

		public static readonly StringName _layerA;

		public static readonly StringName _layerB;

		public static readonly StringName _layerC;

		public static readonly StringName _visibleLayer;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	[Export(PropertyHint.None, "")]
	public extern LayerVisibility VisibleLayer { get; set; }

	public override extern void _EnterTree();

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

	public extern NBgLayerDebug();
}
