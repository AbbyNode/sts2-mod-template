using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Nodes.Vfx;

namespace MegaCrit.Sts2.Core.Nodes.Rooms;

[ScriptPath("res://src/Core/Nodes/Rooms/NMerchantButton.cs")]
public class NMerchantButton : NButton
{
	[Signal]
	public delegate void MerchantOpenedEventHandler(NMerchantButton merchantButton);

	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnRelease;

		public new static readonly StringName RefreshFocus;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public new static readonly StringName Hotkeys;

		public static readonly StringName IsLocalPlayerDead;

		public static readonly StringName _merchantSelectionReticle;

		public static readonly StringName _focusedWhileTargeting;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public static readonly StringName MerchantOpened;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern string[] Hotkeys { get; }

	public extern bool IsLocalPlayerDead
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern IReadOnlyList<LocString> PlayerDeadLines
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern event MerchantOpenedEventHandler MerchantOpened;

	public override extern void _Ready();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnRelease();

	public extern NSpeechBubbleVfx? PlayDialogue(LocString line, double duration = 2.0);

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

	protected extern void EmitSignalMerchantOpened(NMerchantButton merchantButton);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NMerchantButton();
}
