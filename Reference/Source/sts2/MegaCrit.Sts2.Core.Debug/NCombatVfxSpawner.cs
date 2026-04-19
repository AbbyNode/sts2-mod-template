using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Debug;

[ScriptPath("res://src/Core/Debug/NCombatVfxSpawner.cs")]
public class NCombatVfxSpawner : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _Process;

		public new static readonly StringName _Input;

		public static readonly StringName GetRandomColor;

		public static readonly StringName TestFunctionA;

		public static readonly StringName TestFunctionB;

		public static readonly StringName TestFunctionC;

		public static readonly StringName SpawnVfx;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _backCombatVfxContainer;

		public static readonly StringName _combatVfxContainer;

		public static readonly StringName _env;

		public static readonly StringName _playerPosition;

		public static readonly StringName _playerGroundPosition;

		public static readonly StringName _enemyPosition;

		public static readonly StringName _enemyGroundPosition;

		public static readonly StringName _defectEyePosition;

		public static readonly StringName _lowHpBorderVfx;

		public static readonly StringName _gaseousScreenVfx;

		public static readonly StringName _shiftPressed;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public override extern void _Process(double delta);

	public override extern void _Input(InputEvent inputEvent);

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

	public extern NCombatVfxSpawner();
}
