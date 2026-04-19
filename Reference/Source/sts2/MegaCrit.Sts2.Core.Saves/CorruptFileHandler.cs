namespace MegaCrit.Sts2.Core.Saves;

public static class CorruptFileHandler
{
	public static extern string GenerateCorruptFilePath(string originalPath, ReadSaveStatus status);
}
