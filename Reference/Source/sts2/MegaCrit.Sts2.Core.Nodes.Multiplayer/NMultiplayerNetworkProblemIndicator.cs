using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Multiplayer;

[ScriptPath("res://src/Core/Nodes/Multiplayer/NMultiplayerNetworkProblemIndicator.cs")]
public class NMultiplayerNetworkProblemIndicator : TextureRect
{
	public new class MethodName : TextureRect.MethodName
	{
		public static readonly StringName Initialize;

		public extern MethodName();
	}

	public new class PropertyName : TextureRect.PropertyName
	{
		public static readonly StringName IsShown;

		public static readonly StringName _peerId;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : TextureRect.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsShown
	{
		[CompilerGenerated]
		get;
	}

	public extern void Initialize(ulong peerId);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool SetGodotClassPropertyValue(in godot_string_name name, in godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NMultiplayerNetworkProblemIndicator();
}
