using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Cards;

[ScriptPath("res://src/Core/Nodes/Cards/NCardBundle.cs")]
public class NCardBundle : Control
{
	[Signal]
	public delegate void ClickedEventHandler(NCardBundle cardHolder);

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName ReAddCardNodes;

		public static readonly StringName OnClicked;

		public static readonly StringName OnFocused;

		public static readonly StringName OnUnfocused;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Hitbox;

		public static readonly StringName _hoverScale;

		public static readonly StringName smallScale;

		public static readonly StringName _cardHolder;

		public static readonly StringName _hoverTween;

		public static readonly StringName _cardTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName Clicked;

		public extern SignalName();
	}

	public readonly Vector2 smallScale;

	public extern NClickableControl Hitbox
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<CardModel> Bundle
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<NCard> CardNodes { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern event ClickedEventHandler Clicked;

	public static extern NCardBundle? Create(IReadOnlyList<CardModel> bundle);

	public override extern void _Ready();

	public extern IReadOnlyList<NCard> RemoveCardNodes();

	public extern void ReAddCardNodes();

	public override extern void _ExitTree();

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

	protected extern void EmitSignalClicked(NCardBundle cardHolder);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NCardBundle();
}
