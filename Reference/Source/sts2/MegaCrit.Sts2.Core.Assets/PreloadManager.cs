using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.RestSite;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Assets;

public static class PreloadManager
{
	public static extern AssetCache Cache
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool Enabled
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[AsyncStateMachine(typeof(_003CLoadLogoAnimation_003Ed__7))]
	public static extern Task LoadLogoAnimation();

	[AsyncStateMachine(typeof(_003CLoadMainMenuEssentials_003Ed__8))]
	public static extern Task LoadMainMenuEssentials();

	[AsyncStateMachine(typeof(_003CLoadCommonAndMainMenuAssets_003Ed__9))]
	public static extern Task LoadCommonAndMainMenuAssets();

	[AsyncStateMachine(typeof(_003CLoadMainMenuAssets_003Ed__10))]
	public static extern Task LoadMainMenuAssets();

	[AsyncStateMachine(typeof(_003CLoadRunAssets_003Ed__11))]
	public static extern Task LoadRunAssets(IEnumerable<CharacterModel> characters);

	[AsyncStateMachine(typeof(_003CLoadActAssets_003Ed__12))]
	public static extern Task LoadActAssets(ActModel act);

	[AsyncStateMachine(typeof(_003CLoadRoomEventAssets_003Ed__13))]
	public static extern Task LoadRoomEventAssets(EventModel eventModel, IRunState runState);

	[AsyncStateMachine(typeof(_003CLoadRoomCombatAssets_003Ed__14))]
	public static extern Task LoadRoomCombatAssets(EncounterModel encounter, IRunState runState);

	[AsyncStateMachine(typeof(_003CLoadRoomTreasureAssets_003Ed__15))]
	public static extern Task LoadRoomTreasureAssets(ActModel actModel);

	[AsyncStateMachine(typeof(_003CLoadRoomMerchantAssets_003Ed__16))]
	public static extern Task LoadRoomMerchantAssets();

	[AsyncStateMachine(typeof(_003CLoadRoomRestSite_003Ed__17))]
	public static extern Task LoadRoomRestSite(ActModel actModel, IEnumerable<RestSiteOption> restSiteOptions);
}
