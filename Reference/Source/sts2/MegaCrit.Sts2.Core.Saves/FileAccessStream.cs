using System.IO;
using Godot;

namespace MegaCrit.Sts2.Core.Saves;

public class FileAccessStream : Stream
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool CanRead { get; }

	public override extern bool CanSeek { get; }

	public override extern bool CanWrite { get; }

	public override extern long Length { get; }

	public override extern long Position { get; set; }

	public extern FileAccessStream(string filePath, Godot.FileAccess.ModeFlags flags);

	public override extern void Flush();

	public override extern int Read(byte[] buffer, int offset, int count);

	public override extern void Write(byte[] buffer, int offset, int count);

	public override extern long Seek(long offset, SeekOrigin origin);

	public override extern void SetLength(long value);

	protected override extern void Dispose(bool disposing);
}
