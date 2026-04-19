using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Potions;

[ScriptPath("res://src/Core/Nodes/Potions/NPotionPopup.cs")]
public class NPotionPopup : Control
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName OnUseButtonPressed;

		public static readonly StringName OnDiscardButtonPressed;

		public new static readonly StringName _Input;

		public new static readonly StringName _ExitTree;

		public static readonly StringName Remove;

		public static readonly StringName DisconnectSignals;

		public static readonly StringName RefreshUseButton;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName IsUsable;

		public static readonly StringName InACardSelectScreen;

		public static readonly StringName _holder;

		public static readonly StringName _popupContainer;

		public static readonly StringName _useButton;

		public static readonly StringName _discardButton;

		public static readonly StringName _hoverTipBounds;

		public static readonly StringName _tween;

		public static readonly StringName _markedForRemoval;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsUsable { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NPotionPopup Create(NPotionHolder holder);

	public override extern void _Ready();

	public override extern void _Input(InputEvent inputEvent);

	public override extern void _ExitTree();

	public extern void Remove();

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

	public extern NPotionPopup();
}
