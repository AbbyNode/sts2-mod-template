using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Abstracts;

public abstract class CustomOrbModel : OrbModel, ICustomModel, ILocalizationProvider
{
	internal static readonly List<CustomOrbModel> RegisteredOrbs = new List<CustomOrbModel>();

	public virtual string? CustomIconPath => null;

	public virtual string? CustomSpritePath => null;

	/// <summary>
	/// Set to true to include this orb in the random orb pool (e.g. Chaos).
	/// </summary>
	public virtual bool IncludeInRandomPool => false;

	public virtual string? CustomPassiveSfx => null;

	public virtual string? CustomEvokeSfx => null;

	public virtual string? CustomChannelSfx => null;

	protected override string PassiveSfx => CustomPassiveSfx ?? ((OrbModel)this).PassiveSfx;

	protected override string EvokeSfx => CustomEvokeSfx ?? ((OrbModel)this).EvokeSfx;

	protected override string ChannelSfx => CustomChannelSfx ?? ((OrbModel)this).ChannelSfx;

	/// <summary>
	/// Override this to define localization directly in your class.
	/// You are recommended to return an OrbLoc<seealso cref="T:BaseLib.Abstracts.OrbLoc" />.
	/// </summary>
	public virtual List<(string, string)>? Localization => null;

	/// <summary>
	/// Override to create a custom sprite for this orb.
	/// If null is returned, falls back to CustomSpritePath or the default sprite.
	/// </summary>
	public virtual Node2D? CreateCustomSprite()
	{
		return null;
	}

	public CustomOrbModel()
	{
		RegisteredOrbs.Add(this);
	}
}
