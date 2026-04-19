using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NPatchNotesScreen.cs")]
public class NPatchNotesScreen : Control, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName CreateNewPatchEntry;

		public static readonly StringName NextPatchNote;

		public static readonly StringName PreviousPatchNote;

		public static readonly StringName Open;

		public static readonly StringName Close;

		public static readonly StringName LoadPatchNoteText;

		public static readonly StringName ReadPatchNoteFile;

		public static readonly StringName UpdateDateLabel;

		public static readonly StringName GetFileNameFromPath;

		public static readonly StringName RemoveFileExtension;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName IsOpen;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _screenContents;

		public static readonly StringName _marginContainer;

		public static readonly StringName _prevButton;

		public static readonly StringName _nextButton;

		public static readonly StringName _patchNotesToggle;

		public static readonly StringName _backButton;

		public static readonly StringName _dateLabel;

		public static readonly StringName _patchText;

		public static readonly StringName _tween;

		public static readonly StringName _cachedScene;

		public static readonly StringName _index;

		public static readonly StringName _currentScrollLine;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsOpen
	{
		[CompilerGenerated]
		get;
	}

	public extern Control? DefaultFocusedControl { get; }

	public override extern void _Ready();

	public extern void Open();

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

	public extern NPatchNotesScreen();
}
