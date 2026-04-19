using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Saves;

public class GodotFileIo : ISaveStore
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string SaveDir
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern GodotFileIo(string saveDir);

	public extern string GetFullPath(string filename);

	public extern string? ReadFile(string path);

	[AsyncStateMachine(typeof(_003CReadFileAsync_003Ed__7))]
	public extern Task<string?> ReadFileAsync(string path);

	public extern DateTimeOffset GetLastModifiedTime(string path);

	public extern int GetFileSize(string path);

	public extern void SetLastModifiedTime(string path, DateTimeOffset time);

	public extern void WriteFile(string path, string content);

	public extern void WriteFile(string path, byte[] bytes);

	public extern Task WriteFileAsync(string path, string content);

	[AsyncStateMachine(typeof(_003CWriteFileAsync_003Ed__14))]
	public extern Task WriteFileAsync(string path, byte[] bytes);

	public extern bool FileExists(string path);

	public extern bool DirectoryExists(string path);

	public extern void DeleteFile(string path);

	public extern void RenameFile(string sourcePath, string destinationPath);

	public extern string[] GetFilesInDirectory(string directoryPath);

	public extern string[] GetDirectoriesInDirectory(string directoryPath);

	public extern void CreateDirectory(string directoryPath);

	public extern void DeleteDirectory(string directoryPath);

	public extern void DeleteTemporaryFiles(string directoryPath);
}
