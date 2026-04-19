using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Saves;

public class CloudSaveStore : ICloudSaveStore, ISaveStore
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ISaveStore LocalStore
	{
		[CompilerGenerated]
		get;
	}

	public extern ICloudSaveStore CloudStore
	{
		[CompilerGenerated]
		get;
	}

	public extern CloudSaveStore(ISaveStore localStore, ICloudSaveStore cloudStore);

	public extern string? ReadFile(string path);

	public extern Task<string?> ReadFileAsync(string path);

	public extern bool FileExists(string path);

	public extern bool DirectoryExists(string path);

	public extern void WriteFile(string path, string content);

	public extern void WriteFile(string path, byte[] bytes);

	[AsyncStateMachine(typeof(_003CWriteFileAsync_003Ed__13))]
	public extern Task WriteFileAsync(string path, string content);

	[AsyncStateMachine(typeof(_003CWriteFileAsync_003Ed__14))]
	public extern Task WriteFileAsync(string path, byte[] bytes);

	public extern void DeleteFile(string path);

	public extern void RenameFile(string sourcePath, string destinationPath);

	public extern string[] GetFilesInDirectory(string directoryPath);

	public extern string[] GetDirectoriesInDirectory(string directoryPath);

	public extern void CreateDirectory(string directoryPath);

	public extern void DeleteDirectory(string directoryPath);

	public extern void DeleteTemporaryFiles(string directoryPath);

	public extern DateTimeOffset GetLastModifiedTime(string path);

	public extern int GetFileSize(string path);

	public extern void SetLastModifiedTime(string path, DateTimeOffset time);

	public extern string GetFullPath(string filename);

	public extern bool HasCloudFiles();

	public extern void ForgetFile(string path);

	public extern bool IsFilePersisted(string path);

	public extern void BeginSaveBatch();

	public extern void EndSaveBatch();

	[AsyncStateMachine(typeof(_003CSyncCloudToLocal_003Ed__31))]
	public extern Task SyncCloudToLocal(string path);

	[IteratorStateMachine(typeof(_003CSyncCloudToLocalDirectory_003Ed__32))]
	public extern IEnumerable<Task> SyncCloudToLocalDirectory(string directoryPath);

	[AsyncStateMachine(typeof(_003COverwriteCloudWithLocal_003Ed__33))]
	public extern Task OverwriteCloudWithLocal(string path, bool forgetImmediately = false);

	[IteratorStateMachine(typeof(_003COverwriteCloudWithLocalDirectory_003Ed__34))]
	public extern IEnumerable<Task> OverwriteCloudWithLocalDirectory(string directoryPath, int? byteLimit, int? fileLimit);

	public extern void ForgetFilesInDirectoryBeforeWritingIfNecessary(string directoryPath, int bytesToBeWritten, int byteLimit, int fileLimit);
}
