using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Nodes.TopBar;

[ScriptPath("res://src/Core/Nodes/TopBar/NTopBarDeckButton.cs")]
public class NTopBarDeckButton : NTopBarButton
{
	public new class MethodName : NTopBarButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName OnPileContentsChanged;

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

		public static readonly StringName _elapsedTime;

		public static readonly StringName _rockBaseRotation;

		public static readonly StringName _countLabel;

		public static readonly StringName _count;

		public static readonly StringName _bumpTween;

		public extern PropertyName();
	}

	public new class SignalName : NTopBarButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern string[] Hotkeys { get; }

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void Initialize(Player player);

	protected override extern void OnRelease();

	protected override extern bool IsOpen();

	public override extern void _Process(double delta);

	public extern void ToggleAnimState();

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

	public extern NTopBarDeckButton();
}
