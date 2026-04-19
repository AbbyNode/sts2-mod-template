using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.Map;

namespace MegaCrit.Sts2.Core.Nodes.Multiplayer;

[ScriptPath("res://src/Core/Nodes/Multiplayer/NRemoteMouseCursor.cs")]
public class NRemoteMouseCursor : Control
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName SetNextPosition;

		public new static readonly StringName _Process;

		public static readonly StringName UpdateImage;

		public static readonly StringName GetHotspot;

		public static readonly StringName GetTexture;

		public static readonly StringName RefreshSize;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName PlayerId;

		public static readonly StringName _textureRect;

		public static readonly StringName _lastPositionUpdateMsec;

		public static readonly StringName _defaultHotspot;

		public static readonly StringName _drawingHotspot;

		public static readonly StringName _erasingHotspot;

		public static readonly StringName _defaultCursorImage;

		public static readonly StringName _tiltedCursorImage;

		public static readonly StringName _defaultDrawingImage;

		public static readonly StringName _tiltedDrawingImage;

		public static readonly StringName _defaultErasingImage;

		public static readonly StringName _tiltedErasingImage;

		public static readonly StringName _defaultCursorTexture;

		public static readonly StringName _tiltedCursorTexture;

		public static readonly StringName _defaultDrawingTexture;

		public static readonly StringName _tiltedDrawingTexture;

		public static readonly StringName _defaultErasingTexture;

		public static readonly StringName _tiltedErasingTexture;

		public static readonly StringName _drawingMode;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ulong PlayerId
	{
		[CompilerGenerated]
		get;
	}

	public static extern NRemoteMouseCursor Create(ulong playerId);

	public override extern void _Ready();

	public extern void SetNextPosition(Vector2 position);

	public override extern void _Process(double delta);

	public extern void UpdateImage(bool isDown, DrawingMode drawingMode);

	public extern void RefreshSize();

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

	public extern NRemoteMouseCursor();
}
