using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;

namespace MegaCrit.Sts2.GameInfo;

[ScriptPath("res://src/GameInfo/NGameInfoUploader.cs")]
public class NGameInfoUploader : Node
{
	public new class MethodName : Node.MethodName
	{
		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public extern SignalName();
	}

	public static extern bool IsRunning
	{
		[CompilerGenerated]
		get;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NGameInfoUploader();
}
