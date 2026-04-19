using System.ComponentModel;
using Godot;
using Godot.Bridge;

namespace RiderTestRunner;

[ScriptPath("res://RiderTestRunner/NetCoreRunner.cs")]
public class NetCoreRunner : Node
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NetCoreRunner();
}
