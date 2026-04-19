using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Nodes.Cards.Holders;
using MegaCrit.Sts2.Core.Nodes.Relics;

namespace MegaCrit.Sts2.Core.Nodes.HoverTips;

[ScriptPath("res://src/Core/Nodes/HoverTips/NHoverTipSet.cs")]
public class NHoverTipSet : Control
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName SetFollowOwner;

		public static readonly StringName CreateAndShowMapPointHistory;

		public new static readonly StringName _Ready;

		public new static readonly StringName _Process;

		public static readonly StringName SetAlignment;

		public static readonly StringName SetAlignmentForRelic;

		public static readonly StringName SetAlignmentForCardHolder;

		public static readonly StringName CorrectVerticalOverflow;

		public static readonly StringName CorrectHorizontalOverflow;

		public static readonly StringName Clear;

		public static readonly StringName Remove;

		public static readonly StringName SetExtraFollowOffset;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName TextHoverTipDimensions;

		public static readonly StringName CardHoverTipDimensions;

		public static readonly StringName _textHoverTipContainer;

		public static readonly StringName _cardHoverTipContainer;

		public static readonly StringName _owner;

		public static readonly StringName _followOwner;

		public static readonly StringName _followOffset;

		public static readonly StringName _extraOffset;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	public static bool shouldBlockHoverTips;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern void SetFollowOwner();

	public static extern NHoverTipSet CreateAndShow(Control owner, IHoverTip hoverTip, HoverTipAlignment alignment = HoverTipAlignment.None);

	public static extern NHoverTipSet CreateAndShow(Control owner, IEnumerable<IHoverTip> hoverTips, HoverTipAlignment alignment = HoverTipAlignment.None);

	public static extern NHoverTipSet CreateAndShowMapPointHistory(Control owner, NMapPointHistoryHoverTip historyHoverTip);

	public override extern void _Ready();

	public override extern void _Process(double delta);

	public extern void SetAlignment(Control node, HoverTipAlignment alignment);

	public extern void SetAlignmentForRelic(NRelic relic);

	public extern void SetAlignmentForCardHolder(NCardHolder holder);

	public static extern void Clear();

	public static extern void Remove(Control owner);

	public extern void SetExtraFollowOffset(Vector2 offset);

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

	public extern NHoverTipSet();
}
