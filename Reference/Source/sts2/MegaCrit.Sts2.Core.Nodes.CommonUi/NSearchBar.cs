using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NSearchBar.cs")]
public class NSearchBar : Control
{
	[Signal]
	public delegate void QueryChangedEventHandler(string query);

	[Signal]
	public delegate void QuerySubmittedEventHandler(string query);

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName TextUpdated;

		public static readonly StringName TextSubmitted;

		public static readonly StringName ClearText;

		public static readonly StringName Normalize;

		public static readonly StringName RemoveHtmlTags;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Text;

		public static readonly StringName TextArea;

		public static readonly StringName _textArea;

		public static readonly StringName _clearButton;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName QueryChanged;

		public static readonly StringName QuerySubmitted;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string Text { get; }

	public extern LineEdit TextArea { get; }

	public extern event QueryChangedEventHandler QueryChanged;

	public extern event QuerySubmittedEventHandler QuerySubmitted;

	public override extern void _Ready();

	public extern void ClearText();

	public static extern string Normalize(string text);

	public static extern string RemoveHtmlTags(string text);

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

	protected extern void EmitSignalQueryChanged(string query);

	protected extern void EmitSignalQuerySubmitted(string query);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NSearchBar();
}
