using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Saves.Migrations;

namespace MegaCrit.Sts2.Core.Saves.Managers;

public class ProfileSaveManager
{
	public const int maxProfileCount = 3;

	public const string profileSaveFileName = "profile.save";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string ProfilePath { get; }

	public extern ProfileSave Profile
	{
		[CompilerGenerated]
		get;
	}

	public extern ProfileSaveManager(ISaveStore saveStore, MigrationManager migrationManager);

	public extern void SaveProfile();

	public extern ReadSaveResult<ProfileSave> LoadProfile();

	[AsyncStateMachine(typeof(_003CSyncCloudToLocal_003Ed__13))]
	public extern Task SyncCloudToLocal();

	[AsyncStateMachine(typeof(_003COverwriteCloudWithLocal_003Ed__14))]
	public extern Task OverwriteCloudWithLocal();
}
