using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.TopBar;

[ScriptPath("res://src/Core/Nodes/TopBar/NTopBarPauseButton.cs")]
public class NTopBarPauseButton : NTopBarButton
{
	public new class MethodName : NTopBarButton.MethodName
	{
		public new static readonly StringName OnRelease;

		public new static readonly StringName IsOpen;

		public new static readonly StringName _Process;

		public static readonly StringName ToggleAnimState;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public extern MethodName();
	}

	public new class PropertyName : NTopBarButton.PropertyName
	{
		public new static readonly StringName Hotkeys;

		public extern PropertyName();
	}

	public new class SignalName : NTopBarButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern string[] Hotkeys { get; }

	protected override extern void OnRelease();

	protected override extern bool IsOpen();

	public override extern void _Process(double delta);

	public extern void Initialize(IRunState runState);

	[AsyncStateMachine(typeof(_003CAnimPressDown_003Ed__13))]
	protected override extern Task AnimPressDown(CancellationTokenSource cancelToken);

	[AsyncStateMachine(typeof(_003CAnimHover_003Ed__14))]
	protected override extern Task AnimHover(CancellationTokenSource cancelToken);

	[AsyncStateMachine(typeof(_003CAnimUnhover_003Ed__15))]
	protected override extern Task AnimUnhover(CancellationTokenSource cancelToken);

	public extern void ToggleAnimState();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NTopBarPauseButton();
}
