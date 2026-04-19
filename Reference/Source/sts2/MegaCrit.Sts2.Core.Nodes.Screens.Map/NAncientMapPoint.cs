using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Map;

[ScriptPath("res://src/Core/Nodes/Screens/Map/NAncientMapPoint.cs")]
public class NAncientMapPoint : NMapPoint
{
	public new class MethodName : NMapPoint.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _Process;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnSelected;

		public new static readonly StringName RefreshColorInstantly;

		public static readonly StringName AnimHover;

		public static readonly StringName AnimUnhover;

		public static readonly StringName AnimPressDown;

		public extern MethodName();
	}

	public new class PropertyName : NMapPoint.PropertyName
	{
		public new static readonly StringName TraveledColor;

		public new static readonly StringName UntravelableColor;

		public new static readonly StringName HoveredColor;

		public new static readonly StringName HoverScale;

		public new static readonly StringName DownScale;

		public static readonly StringName TargetMaterial;

		public static readonly StringName _icon;

		public static readonly StringName _outline;

		public static readonly StringName _tween;

		public static readonly StringName _elapsedTime;

		public extern PropertyName();
	}

	public new class SignalName : NMapPoint.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern Color TraveledColor { get; }

	protected override extern Color UntravelableColor { get; }

	protected override extern Color HoveredColor { get; }

	protected override extern Vector2 HoverScale { get; }

	protected override extern Vector2 DownScale { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NAncientMapPoint Create(MapPoint point, NMapScreen screen, IRunState runState);

	public override extern void _Ready();

	public override extern void _Process(double delta);

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	public override extern void OnSelected();

	protected override extern void RefreshColorInstantly();

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

	public extern NAncientMapPoint();
}
