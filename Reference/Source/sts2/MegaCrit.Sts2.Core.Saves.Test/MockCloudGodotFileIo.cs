namespace MegaCrit.Sts2.Core.Saves.Test;

public class MockCloudGodotFileIo : MockGodotFileIo, ICloudSaveStore, ISaveStore
{
	public extern MockCloudGodotFileIo(string saveDir);

	public extern bool HasCloudFiles();

	public extern void ForgetFile(string path);

	public extern bool IsFilePersisted(string path);

	public extern void BeginSaveBatch();

	public extern void EndSaveBatch();
}
