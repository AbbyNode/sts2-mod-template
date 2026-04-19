using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Potions;

[ScriptPath("res://src/Core/Nodes/Potions/NPotionContainer.cs")]
public class NPotionContainer : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName ConnectPlayerEvents;

		public static readonly StringName DisconnectPlayerEvents;

		public static readonly StringName GrowPotionHolders;

		public static readonly StringName UpdateNavigation;

		public static readonly StringName PotionFtueCheck;

		public static readonly StringName PlayAddFailedAnim;

		public static readonly StringName OnPotionHolderFocused;

		public static readonly StringName OnPotionHolderUnfocused;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName FirstPotionControl;

		public static readonly StringName LastPotionControl;

		public static readonly StringName _potionHolders;

		public static readonly StringName _potionErrorBg;

		public static readonly StringName _potionShortcutButton;

		public static readonly StringName _potionsFullTween;

		public static readonly StringName _potionHolderInitPos;

		public static readonly StringName _focusedHolder;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Control? FirstPotionControl { get; }

	public extern Control? LastPotionControl { get; }

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void Initialize(IRunState runState);

	public extern void AnimatePotion(PotionModel potion, Vector2? startPosition = null);

	public extern void OnPotionUseCanceled(PotionModel potion);

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

	public extern NPotionContainer();
}
