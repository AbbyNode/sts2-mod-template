using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Capstones;

[ScriptPath("res://src/Core/Nodes/Screens/Capstones/NCapstoneContainer.cs")]
public class NCapstoneContainer : Control
{
	[Signal]
	public delegate void ChangedEventHandler();

	[Signal]
	public delegate void CapstoneClosedEventHandler();

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName Close;

		public static readonly StringName CloseInternal;

		public static readonly StringName DisableBackstopInstantly;

		public static readonly StringName EnableBackstopInstantly;

		public static readonly StringName CleanUp;

		public static readonly StringName OnActiveScreenChanged;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName InUse;

		public static readonly StringName _backstop;

		public static readonly StringName _backstopFade;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName Changed;

		public static readonly StringName CapstoneClosed;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ICapstoneScreen? CurrentCapstoneScreen
	{
		[CompilerGenerated]
		get;
	}

	public extern bool InUse { get; }

	public static extern NCapstoneContainer? Instance { get; }

	public extern event ChangedEventHandler Changed;

	public extern event CapstoneClosedEventHandler CapstoneClosed;

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void Open(ICapstoneScreen screen);

	public extern void Close();

	public extern void DisableBackstopInstantly();

	public extern void EnableBackstopInstantly();

	public extern void CleanUp();

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

	protected extern void EmitSignalChanged();

	protected extern void EmitSignalCapstoneClosed();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NCapstoneContainer();
}
