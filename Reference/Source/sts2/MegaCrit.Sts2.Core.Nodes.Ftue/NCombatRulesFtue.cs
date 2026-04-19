using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Ftue;

[ScriptPath("res://src/Core/Nodes/Ftue/NCombatRulesFtue.cs")]
public class NCombatRulesFtue : NFtue
{
	public new class MethodName : NFtue.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Start;

		public static readonly StringName Create;

		public new static readonly StringName _Input;

		public static readonly StringName ToggleLeft;

		public static readonly StringName ToggleRight;

		public extern MethodName();
	}

	public new class PropertyName : NFtue.PropertyName
	{
		public static readonly StringName _image1;

		public static readonly StringName _image2;

		public static readonly StringName _image3;

		public static readonly StringName _prevButton;

		public static readonly StringName _nextButton;

		public static readonly StringName _pageCount;

		public static readonly StringName _image;

		public static readonly StringName _bodyText;

		public static readonly StringName _header;

		public static readonly StringName _currentPage;

		public static readonly StringName _imagePosition;

		public static readonly StringName _textPosition;

		public static readonly StringName _pageTurnTween;

		public extern PropertyName();
	}

	public new class SignalName : NFtue.SignalName
	{
		public extern SignalName();
	}

	public const string id = "combat_rules_ftue";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public extern void Start();

	public static extern NCombatRulesFtue? Create();

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

	public extern NCombatRulesFtue();
}
