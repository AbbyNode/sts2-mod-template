using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.TopBar;

[ScriptPath("res://src/Core/Nodes/TopBar/NTopBarButton.cs")]
public abstract class NTopBarButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName InitTopBarButton;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName OnRelease;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public new static readonly StringName OnUnfocus;

		public static readonly StringName UpdateScreenOpen;

		public static readonly StringName OnScreenClosed;

		public static readonly StringName CancelAnimations;

		public static readonly StringName IsOpen;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName IsScreenOpen;

		public static readonly StringName _icon;

		public static readonly StringName _hsv;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	protected Control _icon;

	protected ShaderMaterial? _hsv;

	protected const float _hoverAnimDur = 0.5f;

	protected static readonly Vector2 _hoverScale;

	protected const float _unhoverAnimDur = 1f;

	protected const float _pressDownDur = 0.25f;

	protected extern bool IsScreenOpen
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	protected extern void InitTopBarButton();

	public override extern void _ExitTree();

	protected override extern void OnRelease();

	protected override extern void OnPress();

	[AsyncStateMachine(typeof(_003CAnimPressDown_003Ed__23))]
	protected virtual extern Task AnimPressDown(CancellationTokenSource cancelToken);

	protected override extern void OnFocus();

	protected override extern void OnEnable();

	protected override extern void OnDisable();

	[AsyncStateMachine(typeof(_003CAnimHover_003Ed__27))]
	protected virtual extern Task AnimHover(CancellationTokenSource cancelToken);

	protected override extern void OnUnfocus();

	[AsyncStateMachine(typeof(_003CAnimUnhover_003Ed__29))]
	protected virtual extern Task AnimUnhover(CancellationTokenSource cancelToken);

	protected extern void UpdateScreenOpen();

	protected abstract bool IsOpen();

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

	protected extern NTopBarButton();
}
