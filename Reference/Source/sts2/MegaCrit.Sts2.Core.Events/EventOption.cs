using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Events;

public class EventOption
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string TextKey
	{
		[CompilerGenerated]
		get;
	}

	public extern LocString Title
	{
		[CompilerGenerated]
		get;
	}

	public extern LocString Description
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<IHoverTip> HoverTips
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool IsLocked
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsProceed
	{
		[CompilerGenerated]
		get;
	}

	public extern bool WasChosen
	{
		[CompilerGenerated]
		get;
	}

	public extern RelicModel? Relic
	{
		[CompilerGenerated]
		get;
	}

	public extern Func<Player, bool>? WillKillPlayer
	{
		[CompilerGenerated]
		get;
	}

	public extern bool ShouldSaveChoiceToHistory
	{
		[CompilerGenerated]
		get;
	}

	public extern LocString HistoryName
	{
		[CompilerGenerated]
		get;
	}

	public extern bool ShouldSaveVariablesToHistory
	{
		[CompilerGenerated]
		get;
	}

	public extern event Func<EventOption, Task>? BeforeChosen;

	public extern EventOption(EventModel eventModel, Func<Task>? onChosen, LocString title, LocString description, string textKey, IEnumerable<IHoverTip> hoverTips);

	public extern EventOption(EventModel eventModel, Func<Task>? onChosen, string textKey, IEnumerable<IHoverTip> hoverTips);

	public extern EventOption(EventModel eventModel, Func<Task>? onChosen, string textKey, params IHoverTip[] hoverTips);

	public extern EventOption(EventModel eventModel, Func<Task>? onChosen, string textKey, bool disableOnChosen = true, bool isProceed = false, params IHoverTip[] hoverTips);

	public static extern EventOption FromRelic(RelicModel relic, EventModel eventModel, Func<Task>? onChosen, string textKey);

	public extern EventOption WithRelic<T>(Player? owner) where T : RelicModel;

	public extern EventOption WithRelic(RelicModel relic);

	[AsyncStateMachine(typeof(_003CChosen_003Ed__63))]
	public extern Task Chosen();

	public extern EventOption WithOverridenHistoryName(LocString historyName);

	public extern EventOption ThatDoesDamage(decimal damage);

	public extern EventOption ThatDecreasesMaxHp(decimal value);

	public extern EventOption ThatWillKillPlayerIf(Func<Player, bool> willKillPlayer);

	public extern EventOption ThatHasDynamicTitle();

	public extern EventOption ThatWontSaveToChoiceHistory();

	public override extern string ToString();
}
