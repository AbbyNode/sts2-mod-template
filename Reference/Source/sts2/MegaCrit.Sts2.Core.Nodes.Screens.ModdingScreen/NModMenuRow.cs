using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Modding;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Screens.ModdingScreen;

[ScriptPath("res://src/Core/Nodes/Screens/ModdingScreen/NModMenuRow.cs")]
public class NModMenuRow : NClickableControl
{
	public new class MethodName : NClickableControl.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnRelease;

		public static readonly StringName SetSelected;

		public static readonly StringName OnTickboxToggled;

		public static readonly StringName GetPlatformIcon;

		public extern MethodName();
	}

	public new class PropertyName : NClickableControl.PropertyName
	{
		public static readonly StringName _selectionHighlight;

		public static readonly StringName _tickbox;

		public static readonly StringName _screen;

		public static readonly StringName _isSelected;

		public extern PropertyName();
	}

	public new class SignalName : NClickableControl.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Mod? Mod
	{
		[CompilerGenerated]
		get;
	}

	public static extern NModMenuRow? Create(NModdingScreen screen, Mod mod);

	public override extern void _Ready();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnRelease();

	public extern void SetSelected(bool isSelected);

	public static extern Texture2D GetPlatformIcon(ModSource modSource);

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

	public extern NModMenuRow();
}
