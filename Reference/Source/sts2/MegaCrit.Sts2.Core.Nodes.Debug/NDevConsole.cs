using System.ComponentModel;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Nodes.Debug;

[ScriptPath("res://src/Core/Nodes/Debug/NDevConsole.cs")]
public class NDevConsole : Panel
{
	public new class MethodName : Panel.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName PrintUsage;

		public new static readonly StringName _Input;

		public static readonly StringName HandleReadlineKeybinding;

		public static readonly StringName DeleteWordBackward;

		public static readonly StringName KillToEndOfLine;

		public static readonly StringName Yank;

		public static readonly StringName EnableTabBuffer;

		public static readonly StringName DisableTabBuffer;

		public static readonly StringName SetBackgroundColor;

		public static readonly StringName HideGhostText;

		public static readonly StringName ShowGhostText;

		public static readonly StringName UpdateGhostText;

		public static readonly StringName AutocompleteCommand;

		public static readonly StringName RenderSelectionMenu;

		public static readonly StringName OnInputTextChanged;

		public static readonly StringName ExitSelectionMode;

		public static readonly StringName NavigateSelection;

		public static readonly StringName AcceptSelection;

		public static readonly StringName ProcessCommand;

		public static readonly StringName ShowConsole;

		public static readonly StringName HideConsole;

		public static readonly StringName MakeHalfScreen;

		public static readonly StringName MakeFullScreen;

		public static readonly StringName OnToggleMaximizeButtonPressed;

		public static readonly StringName MoveInputCursorToEndOfLine;

		public static readonly StringName UpdatePromptStyle;

		public static readonly StringName AddChildToTree;

		public extern MethodName();
	}

	public new class PropertyName : Panel.PropertyName
	{
		public static readonly StringName _outputBuffer;

		public static readonly StringName _tabBuffer;

		public static readonly StringName _inputContainer;

		public static readonly StringName _inputBuffer;

		public static readonly StringName _promptLabel;

		public static readonly StringName _ghostTextLabel;

		public static readonly StringName _isFullscreen;

		public static readonly StringName _yankBuffer;

		public extern PropertyName();
	}

	public new class SignalName : Panel.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NDevConsole Instance { get; }

	public override extern void _Ready();

	public override extern void _ExitTree();

	public override extern void _Input(InputEvent inputEvent);

	public extern void SetBackgroundColor(Color color);

	public extern Task ProcessNetCommand(Player? player, string netCommand);

	public extern void ShowConsole();

	public extern void HideConsole();

	public extern void MakeHalfScreen();

	public extern void MakeFullScreen();

	public extern void MoveInputCursorToEndOfLine();

	public extern void AddChildToTree(Node node);

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

	public extern NDevConsole();
}
