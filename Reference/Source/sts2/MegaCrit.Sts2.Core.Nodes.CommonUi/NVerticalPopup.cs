using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.addons.mega_text;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NVerticalPopup.cs")]
public class NVerticalPopup : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetText;

		public static readonly StringName Close;

		public static readonly StringName HideNoButton;

		public static readonly StringName DisconnectSignals;

		public static readonly StringName DisconnectHotkeys;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName TitleLabel;

		public static readonly StringName BodyLabel;

		public static readonly StringName YesButton;

		public static readonly StringName NoButton;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern MegaLabel TitleLabel
	{
		[CompilerGenerated]
		get;
	}

	public extern MegaRichTextLabel BodyLabel
	{
		[CompilerGenerated]
		get;
	}

	public extern NPopupYesNoButton YesButton
	{
		[CompilerGenerated]
		get;
	}

	public extern NPopupYesNoButton NoButton
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	public extern void SetText(LocString title, LocString body);

	public extern void SetText(string title, string body);

	public extern void InitYesButton(LocString yesButton, Action<NButton> onPressed);

	public extern void InitNoButton(LocString noButton, Action<NButton> onPressed);

	public extern void HideNoButton();

	public extern void DisconnectSignals();

	public extern void DisconnectHotkeys();

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

	public extern NVerticalPopup();
}
