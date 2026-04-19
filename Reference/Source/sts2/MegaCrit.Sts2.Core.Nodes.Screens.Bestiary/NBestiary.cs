using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Bestiary;

[ScriptPath("res://src/Core/Nodes/Screens/Bestiary/NBestiary.cs")]
public class NBestiary : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName OnSubmenuOpened;

		public new static readonly StringName OnSubmenuClosed;

		public static readonly StringName CreateEntries;

		public static readonly StringName OnMonsterClicked;

		public static readonly StringName SelectMonster;

		public static readonly StringName OnMoveButtonFocused;

		public static readonly StringName OnMoveButtonUnfocused;

		public static readonly StringName OnMoveButtonClicked;

		public static readonly StringName PlayIdleAnim;

		public static readonly StringName PlayMoveAnim;

		public static readonly StringName OnMoveAnimCompleted;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _monsterNameLabel;

		public static readonly StringName _epithet;

		public static readonly StringName _sidebar;

		public static readonly StringName _bestiaryList;

		public static readonly StringName _monsterVisualsContainer;

		public static readonly StringName _descriptionLabel;

		public static readonly StringName _selectionArrow;

		public static readonly StringName _moveList;

		public static readonly StringName _moveContainer;

		public static readonly StringName _arrowTween;

		public static readonly StringName _arrowPosReset;

		public static readonly StringName _monsterVisuals;

		public static readonly StringName _selectedEntry;

		public static readonly StringName _tween;

		public static readonly StringName _isPlayingMoveAnim;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern Control? InitialFocusedControl { get; }

	public static extern string[] AssetPaths { get; }

	public static extern NBestiary? Create();

	public override extern void _Ready();

	public override extern void OnSubmenuOpened();

	public override extern void OnSubmenuClosed();

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

	public extern NBestiary();
}
