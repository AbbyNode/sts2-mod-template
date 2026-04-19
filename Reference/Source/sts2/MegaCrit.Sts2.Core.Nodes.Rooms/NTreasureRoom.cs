using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Rooms;

[ScriptPath("res://src/Core/Nodes/Rooms/NTreasureRoom.cs")]
public class NTreasureRoom : Control, IScreenContext, IRoomWithProceedButton
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName OnProceedButtonPressed;

		public static readonly StringName OnProceedButtonReleased;

		public static readonly StringName OnChestButtonReleased;

		public static readonly StringName OnMouseEntered;

		public static readonly StringName OnMouseExited;

		public static readonly StringName UpdateChestSkin;

		public static readonly StringName OnActiveScreenChanged;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName ProceedButton;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _banner;

		public static readonly StringName _chestButton;

		public static readonly StringName _chestNode;

		public static readonly StringName _proceedButton;

		public static readonly StringName _goldParticles;

		public static readonly StringName _relicCollection;

		public static readonly StringName _isRelicCollectionOpen;

		public static readonly StringName _hasRelicBeenClaimed;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NProceedButton ProceedButton { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern Control? DefaultFocusedControl { get; }

	public static extern NTreasureRoom? Create(TreasureRoom room, IRunState runState);

	public override extern void _Ready();

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

	public extern NTreasureRoom();
}
