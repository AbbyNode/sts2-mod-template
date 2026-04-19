using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Saves.Test;

public class MockGodotFileIo : ISaveStore
{
	public static class Methods
	{
		public const string writeFile = "WriteFile";

		public const string writeFileAsync = "WriteFileAsync";

		public const string readFile = "ReadFile";

		public const string readFileAsync = "ReadFileAsync";

		public const string fileExists = "FileExists";

		public const string renameFile = "RenameFile";

		public const string deleteFile = "DeleteFile";

		public const string getFullPath = "GetFullPath";

		public const string getDirectoriesInDirectory = "GetDirectoriesInDirectory";

		public const string getFilesInDirectory = "GetFilesInDirectory";

		public const string createDirectory = "CreateDirectory";

		public const string deleteDirectory = "DeleteDirectory";

		public const string deleteTemporaryFiles = "DeleteTemporaryFiles";

		public const string getLastModifiedTime = "GetLastModifiedTime";
	}

	protected class File
	{
		public required string content;

		public DateTimeOffset? lastModifiedTime;

		public bool forgotten;

		public extern File();
	}

	protected readonly ConcurrentDictionary<string, File> _files;

	protected readonly ConcurrentDictionary<string, List<string>> _directories;

	protected readonly string _saveDir;

	public Func<DateTimeOffset>? getCurrentTime;

	public bool ShouldFailWrites;

	public bool ShouldFailTimestampSync;

	public extern List<(string Method, object[] Args)> Calls
	{
		[CompilerGenerated]
		get;
	}

	public extern Action<string, string>? RenameFileAction
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern MockGodotFileIo(string saveDir);

	public extern DateTimeOffset GetLastModifiedTime(string path);

	public extern int GetFileSize(string path);

	public extern void SetLastModifiedTime(string path, DateTimeOffset time);

	public extern string GetFullPath(string filename);

	public extern string? ReadFile(string path);

	public extern Task<string?> ReadFileAsync(string path);

	public extern void WriteFile(string path, string content);

	public extern void WriteFile(string path, byte[] bytes);

	public extern Task WriteFileAsync(string path, string content);

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

	protected extern void CanonicalizePath(ref string path, bool getFullPath = true);
}
