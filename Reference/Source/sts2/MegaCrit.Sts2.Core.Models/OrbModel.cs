using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Models;

public abstract class OrbModel : AbstractModel
{
	public const string locTable = "orbs";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public abstract decimal PassiveVal { get; }

	public abstract decimal EvokeVal { get; }

	public extern bool HasBeenRemovedFromState
	{
		[CompilerGenerated]
		get;
	}

	public extern LocString Title { get; }

	public extern LocString Description { get; }

	public extern bool HasSmartDescription { get; }

	public extern LocString SmartDescription { get; }

	protected virtual extern string PassiveSfx { get; }

	protected virtual extern string EvokeSfx { get; }

	protected virtual extern string ChannelSfx { get; }

	public static extern HoverTip EmptySlotHoverTipHoverTip { get; }

	public extern HoverTip DumbHoverTip { get; }

	protected virtual extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public extern IEnumerable<IHoverTip> HoverTips { get; }

	public extern CompressedTexture2D Icon { get; }

	public abstract Color DarkenedColor { get; }

	public extern Player Owner { get; set; }

	public extern CombatState CombatState { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	public extern IEnumerable<string> AssetPaths { get; }

	public extern event Action? Triggered;

	public static extern OrbModel GetRandomOrb(Rng rng);

	protected extern void PlayPassiveSfx();

	protected extern void PlayEvokeSfx();

	public extern void PlayChannelSfx();

	public extern Node2D CreateSprite();

	public extern OrbModel ToMutable(int initialAmount = 0);

	public extern void Trigger();

	public virtual extern Task BeforeTurnEndOrbTrigger(PlayerChoiceContext choiceContext);

	public virtual extern Task AfterTurnStartOrbTrigger(PlayerChoiceContext choiceContext);

	public virtual extern Task Passive(PlayerChoiceContext choiceContext, Creature? target);

	public virtual extern Task<IEnumerable<Creature>> Evoke(PlayerChoiceContext playerChoiceContext);

	protected extern decimal ModifyOrbValue(decimal result);

	protected override extern void AfterCloned();

	public extern void RemoveInternal();

	protected extern OrbModel();
}
