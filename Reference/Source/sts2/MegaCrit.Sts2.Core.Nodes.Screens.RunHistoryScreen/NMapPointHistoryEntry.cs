using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Runs.History;

namespace MegaCrit.Sts2.Core.Nodes.Screens.RunHistoryScreen;

[ScriptPath("res://src/Core/Nodes/Screens/RunHistoryScreen/NMapPointHistoryEntry.cs")]
public class NMapPointHistoryEntry : NClickableControl
{
	public new class MethodName : NClickableControl.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public static readonly StringName Highlight;

		public static readonly StringName Unhighlight;

		public static readonly StringName GetSfxVolume;

		public static readonly StringName HurryUp;

		public static readonly StringName SetupForAnimation;

		public extern MethodName();
	}

	public new class PropertyName : NClickableControl.PropertyName
	{
		public static readonly StringName FloorNum;

		public static readonly StringName _baseScale;

		public static readonly StringName _texture;

		public static readonly StringName _outline;

		public static readonly StringName _questIcon;

		public static readonly StringName _animateInTween;

		public static readonly StringName _hoverTween;

		public static readonly StringName _baseAngle;

		public static readonly StringName _hurryUp;

		public extern PropertyName();
	}

	public new class SignalName : NClickableControl.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern int FloorNum
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	public static extern NMapPointHistoryEntry Create(RunHistory history, MapPointHistoryEntry entry, int floorNum);

	public extern void SetPlayer(RunHistoryPlayer player);

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	public extern void Highlight();

	public extern void Unhighlight();

	[AsyncStateMachine(typeof(_003CAnimateIn_003Ed__27))]
	public extern Task AnimateIn(int index);

	public extern void HurryUp();

	public extern void SetupForAnimation();

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

	public extern NMapPointHistoryEntry();
}
