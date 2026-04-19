using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.UI;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CharacterSelect;

[ScriptPath("res://src/Core/Nodes/Screens/CharacterSelect/NAscensionPanel.cs")]
public class NAscensionPanel : Control
{
	[Signal]
	public delegate void AscensionLevelChangedEventHandler();

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Initialize;

		public static readonly StringName SetFireBlue;

		public static readonly StringName SetFireRed;

		public static readonly StringName Cleanup;

		public static readonly StringName SetAscensionLevel;

		public static readonly StringName IncrementAscension;

		public static readonly StringName DecrementAscension;

		public static readonly StringName RefreshArrowVisibility;

		public static readonly StringName SetMaxAscension;

		public static readonly StringName RefreshAscensionText;

		public static readonly StringName AnimIn;

		public static readonly StringName UpdateControllerButton;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Ascension;

		public static readonly StringName _maxAscension;

		public static readonly StringName _leftArrow;

		public static readonly StringName _rightArrow;

		public static readonly StringName _ascensionLevel;

		public static readonly StringName _info;

		public static readonly StringName _leftTriggerIcon;

		public static readonly StringName _rightTriggerIcon;

		public static readonly StringName _iconHsv;

		public static readonly StringName _arrowsVisible;

		public static readonly StringName _mode;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName AscensionLevelChanged;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int Ascension
	{
		[CompilerGenerated]
		get;
	}

	public extern event AscensionLevelChangedEventHandler AscensionLevelChanged;

	public override extern void _Ready();

	public extern void Initialize(MultiplayerUiMode mode);

	public extern void Cleanup();

	public extern void SetAscensionLevel(int ascension);

	public extern void SetMaxAscension(int maxAscension);

	public extern void AnimIn();

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

	protected extern void EmitSignalAscensionLevelChanged();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NAscensionPanel();
}
