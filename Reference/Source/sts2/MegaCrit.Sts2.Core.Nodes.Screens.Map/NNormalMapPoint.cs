using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Map;

[ScriptPath("res://src/Core/Nodes/Screens/Map/NNormalMapPoint.cs")]
public class NNormalMapPoint : NMapPoint
{
	public new class MethodName : NMapPoint.MethodName
	{
		public static readonly StringName IconName;

		public static readonly StringName IconPath;

		public static readonly StringName OutlinePath;

		public static readonly StringName UnknownIconPath;

		public static readonly StringName UnknownOutlinePath;

		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public static readonly StringName RefreshMarkedIconVisibility;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName _Process;

		public new static readonly StringName OnSelected;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public static readonly StringName SetAngle;

		public new static readonly StringName RefreshColorInstantly;

		public new static readonly StringName RefreshState;

		public static readonly StringName UpdateIcon;

		public static readonly StringName ShowCircleVfx;

		public static readonly StringName AnimHover;

		public static readonly StringName AnimUnhover;

		public static readonly StringName AnimPressDown;

		public static readonly StringName OnHighlightPointType;

		public extern MethodName();
	}

	public new class PropertyName : NMapPoint.PropertyName
	{
		public new static readonly StringName TraveledColor;

		public new static readonly StringName UntravelableColor;

		public new static readonly StringName HoveredColor;

		public new static readonly StringName HoverScale;

		public new static readonly StringName DownScale;

		public static readonly StringName _iconContainer;

		public static readonly StringName _icon;

		public static readonly StringName _questIcon;

		public static readonly StringName _outline;

		public static readonly StringName _circleVfx;

		public static readonly StringName _tween;

		public static readonly StringName _pulseTween;

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

	public static extern NNormalMapPoint Create(MapPoint point, NMapScreen screen, IRunState runState);

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public override extern void _Process(double delta);

	public override extern void OnSelected();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	public extern void SetAngle(float degrees);

	protected override extern void RefreshColorInstantly();

	protected override extern void RefreshState();

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

	public extern NNormalMapPoint();
}
