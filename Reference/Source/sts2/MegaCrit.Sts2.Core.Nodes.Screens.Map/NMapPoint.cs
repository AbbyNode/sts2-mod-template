using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Nodes.Combat;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Map;

[ScriptPath("res://src/Core/Nodes/Screens/Map/NMapPoint.cs")]
public abstract class NMapPoint : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName ConnectSignals;

		public static readonly StringName IsInputAllowed;

		public static readonly StringName RefreshVisualsInstantly;

		public static readonly StringName OnSelected;

		public new static readonly StringName OnRelease;

		public static readonly StringName RefreshColorInstantly;

		public static readonly StringName RefreshState;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName TraveledColor;

		public static readonly StringName UntravelableColor;

		public static readonly StringName HoveredColor;

		public static readonly StringName HoverScale;

		public static readonly StringName DownScale;

		public new static readonly StringName AllowFocusWhileDisabled;

		public static readonly StringName VoteContainer;

		public static readonly StringName IsTravelable;

		public static readonly StringName State;

		public static readonly StringName TargetColor;

		public static readonly StringName _state;

		public static readonly StringName _outlineColor;

		public static readonly StringName _controllerSelectionReticle;

		public static readonly StringName _screen;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	protected IRunState _runState;

	protected Color _outlineColor;

	protected const double _pressDownDur = 0.3;

	protected const double _unhoverAnimDur = 0.5;

	protected NSelectionReticle _controllerSelectionReticle;

	protected NMapScreen _screen;

	protected abstract Color TraveledColor { get; }

	protected abstract Color UntravelableColor { get; }

	protected abstract Color HoveredColor { get; }

	protected abstract Vector2 HoverScale { get; }

	protected abstract Vector2 DownScale { get; }

	protected override extern bool AllowFocusWhileDisabled { get; }

	public extern NMultiplayerVoteContainer VoteContainer
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	protected extern bool IsTravelable { get; }

	public extern MapPoint Point
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		protected set;
	}

	public extern MapPointState State { get; set; }

	protected extern Color TargetColor { get; }

	public override extern void _Ready();

	protected override extern void ConnectSignals();

	protected extern bool IsInputAllowed();

	public extern void RefreshVisualsInstantly();

	public virtual extern void OnSelected();

	protected sealed override extern void OnRelease();

	protected virtual extern void RefreshColorInstantly();

	protected virtual extern void RefreshState();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

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

	protected extern NMapPoint();
}
