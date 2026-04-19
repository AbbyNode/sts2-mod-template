using System.IO;
using Godot;

namespace MegaCrit.Sts2.Core.Modding;

public class ModManagerFileIo : IModManagerFileIo
{
	public extern string[] GetFilesAt(string path);

	public extern string[] GetDirectoriesAt(string path);

	public extern bool FileExists(string path);

	public extern bool DirectoryExists(string path);

	public extern Stream OpenStream(string path, Godot.FileAccess.ModeFlags mode);

	public extern ModManagerFileIo();
}
