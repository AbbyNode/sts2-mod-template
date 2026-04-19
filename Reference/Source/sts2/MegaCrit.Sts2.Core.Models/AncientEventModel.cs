using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Ancients;
using MegaCrit.Sts2.Core.Events;
using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Models;

public abstract class AncientEventModel : EventModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern string LocTable { get; }

	public extern LocString Epithet { get; }

	public extern AncientDialogueSet DialogueSet { get; }

	public virtual extern IEnumerable<CharacterModel> AnyCharacterDialogueBlacklist { get; }

	public override extern Color ButtonColor { get; }

	public virtual extern Color DialogueColor
	{
		[CompilerGenerated]
		get;
	}

	public extern string? DebugOption { get; set; }

	public override extern EventLayoutType LayoutType { get; }

	public extern Texture2D MapIcon { get; }

	public extern Texture2D MapIconOutline { get; }

	public extern IEnumerable<string> MapNodeAssetPaths { get; }

	public virtual extern string AmbientBgm { get; }

	public extern bool HasAmbientBgm { get; }

	public extern Texture2D RunHistoryIcon { get; }

	public extern Texture2D RunHistoryIconOutline { get; }

	public extern int HealedAmount
	{
		[CompilerGenerated]
		get;
	}

	public abstract IEnumerable<EventOption> AllPossibleOptions { get; }

	protected virtual extern Color EventButtonColor
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public override extern LocString InitialDescription { get; }

	protected abstract AncientDialogueSet DefineDialogues();

	protected static extern string CharKey<T>() where T : CharacterModel;

	[AsyncStateMachine(typeof(_003CBeforeEventStarted_003Ed__62))]
	protected override extern Task BeforeEventStarted();

	protected sealed override extern IReadOnlyList<EventOption> GenerateInitialOptionsWrapper();

	protected override extern void SetInitialEventState(bool isPreFinished);

	public extern void StartPreFinished();

	protected extern void Done();

	protected extern EventOption RelicOption<T>(string pageName = "INITIAL", string? customDonePage = null) where T : RelicModel;

	protected extern EventOption RelicOption(RelicModel relic, string pageName = "INITIAL", string? customDonePage = null);

	protected extern AncientEventModel();
}
