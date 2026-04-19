namespace MegaCrit.Sts2.Core.Saves.Migrations.ProfileSaves;

[Migration(typeof(ProfileSave), 1, 2)]
public class ProfileSaveV1ToV2 : MigrationBase<ProfileSave>
{
	protected override extern void ApplyMigration(MigratingData saveData);

	public extern ProfileSaveV1ToV2();
}
