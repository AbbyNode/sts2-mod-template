using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NContinueRunInfo.cs")]
public class NContinueRunInfo : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName AnimShow;

		public static readonly StringName AnimHide;

		public static readonly StringName ShowError;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName HasResult;

		public static readonly StringName _visTween;

		public static readonly StringName _initPosition;

		public static readonly StringName _runInfoContainer;

		public static readonly StringName _errorContainer;

		public static readonly StringName _dateLabel;

		public static readonly StringName _goldLabel;

		public static readonly StringName _healthLabel;

		public static readonly StringName _progressLabel;

		public static readonly StringName _ascensionLabel;

		public static readonly StringName _charIcon;

		public static readonly StringName _isShown;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool HasResult
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	public extern void AnimShow();

	public extern void AnimHide();

	public extern void SetResult(ReadSaveResult<SerializableRun>? result);

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

	public extern NContinueRunInfo();
}
