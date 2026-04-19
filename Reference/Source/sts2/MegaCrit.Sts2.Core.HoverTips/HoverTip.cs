using System;
using System.Runtime.CompilerServices;
using Godot;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.HoverTips;

public struct HoverTip : IHoverTip, IEquatable<HoverTip>
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public readonly extern string? Title
	{
		[CompilerGenerated]
		get;
	}

	public readonly extern Texture2D? Icon
	{
		[CompilerGenerated]
		get;
	}

	public readonly extern string Description
	{
		[CompilerGenerated]
		get;
	}

	public extern string Id
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	public extern bool IsSmart
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	public extern bool IsDebuff
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	public extern bool IsInstanced
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	public readonly extern AbstractModel? CanonicalModel
	{
		[CompilerGenerated]
		get;
	}

	public extern bool ShouldOverrideTextOverflow
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	public extern HoverTip(LocString description, Texture2D? icon = null);

	public extern HoverTip(LocString title, LocString description, Texture2D? icon = null);

	public extern HoverTip(LocString title, string description, Texture2D? icon = null);

	public extern HoverTip(AfflictionModel affliction, LocString description);

	public extern HoverTip(OrbModel orb, LocString description);

	public extern HoverTip(PowerModel power, string description, bool isSmart);

	public extern void SetCanonicalModel(AbstractModel model);

	public static extern HoverTipAlignment GetHoverTipAlignment(Node2D node, float threshold = 0.75f);

	public static extern HoverTipAlignment GetHoverTipAlignment(Control node, float threshold = 0.75f);

	[CompilerGenerated]
	public override readonly extern string ToString();

	[CompilerGenerated]
	public static extern bool operator !=(HoverTip left, HoverTip right);

	[CompilerGenerated]
	public static extern bool operator ==(HoverTip left, HoverTip right);

	[CompilerGenerated]
	public override readonly extern int GetHashCode();

	[CompilerGenerated]
	public override readonly extern bool Equals(object obj);

	[CompilerGenerated]
	public readonly extern bool Equals(HoverTip other);
}
